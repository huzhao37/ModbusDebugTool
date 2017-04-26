//****************************************************************************
//
//  File:      SubMain.cs
//
//  Copyright (c) HU ZHAO
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************
using ModbusDebugTool.Core;
using NewLife.Net;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusDebugTool.Core
{
    public class ModbusProtocol
    {
        #region 字段
        private static string regNum;//读取的寄存器数量
        private static byte[] sendBuff;//发送的数据
        private static byte[] receiveBuff;//接收的数据
        public static string recv;//接收数据的字符串形式
        private static string baseFunctionCode;//功能码
        private static string baseDeviceAddress;//装置设备地址
        private static string baseStartRegAddress;//起始地址
        #endregion

        #region 通信
        /// <summary>
        /// 与设备进行通信
        /// </summary>
        /// <param name="deviceAddress">设备地址</param>
        /// <param name="functionCode">功能码</param>
        /// <param name="startRegaddress">起始寄存器地址</param>
        /// <param name="setData">设置数据</param>
        public void Communication(string deviceAddress, string functionCode, string startRegaddress, string setData)
        {
            ITransport transport;
            dynamic obj = new ExpandoObject();
            try
            {
                if (BaseConfig._ip==null)
                {
                    obj.Args1 = BaseConfig._serialName; //串口名
                    obj.Args2 = BaseConfig._baudRate; //波特率
                    transport = TransportFactory.CreateTransport(obj, TransportEnum.Rs232);
                }
                else
                {
                    obj.Args1 = BaseConfig._ip + ""; //IP地址
                    obj.Args2 = BaseConfig._port; //端口号
                    transport = TransportFactory.CreateTransport(obj, TransportEnum.Tcp);
                    var open = transport.Open();
                    if (!open)
                    {
                        //MessageBox.Show("连接打开失败");
                    }
                }
               
            }
            catch (Exception transportException)
            {
                //MessageBox.Show("创建通讯异常：{0}", transportException.Message);
                transport = null;
            }
            
            if (transport != null)
            {
                
                try
                {
                    sendBuff = WriteSingleAnalog(deviceAddress, functionCode, startRegaddress, setData);
                    //while (true)
                    //{
                    if (!BaseConfig.timer.Equals("") && BaseConfig.timer != 0)
                    {
                        transport.Send(sendBuff);//发送数据

                        //接收数据
                        byte[] recvByte = new byte[1024];
                        int bytes = transport.Receive(recvByte);

                        receiveBuff = new byte[bytes];
                        Array.Copy(recvByte, 0, receiveBuff, 0, bytes); ;
                        recv = BaseConfig.byteToHexStr(receiveBuff);
                        string recvData = Regex.Replace(recv, @"(?<=[0-9A-F]{2})[0-9A-F]{2}", "$0");
                        BaseConfig._recvData = recvData;//备用
                        //BaseConfig._receive.Add(recvData);//用来存放接受数据的集合
                        transport.Dispose();
                        //System.Threading.Thread.Sleep(BaseConfig.timer);
                    }
                    else
                    {
                        transport.Send(sendBuff);//发送数据

                        //接收数据
                        byte[] recvByte = new byte[4096];
                        System.Threading.Thread.Sleep(1000);
                        int bytes = transport.Receive(recvByte);
                        //System.Threading.Thread.Sleep(1000);
                        receiveBuff = new byte[bytes];
                        Array.Copy(recvByte, 0, receiveBuff, 0, bytes); ;
                        recv = BaseConfig.byteToHexStr(receiveBuff);
                        string recvData = Regex.Replace(recv, @"(?<=[0-9A-F]{2})[0-9A-F]{2}", "$0");
                        BaseConfig._recvData = recvData;//备用
                        //BaseConfig._receive.Add(recvData);//用来存放接受数据的集合
                        transport.Dispose();
                        //break;

                    }

                    //}
                    //MessageBox.Show("成功！");

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("创建通讯异常", ex.Message);
                    transport.Dispose();
                }
            }
        }

        #endregion

        #region 发送数据处理
        /// <summary>
        /// 写单个寄存器状态
        /// </summary>
        /// <param name="deviceAddress">设备地址</param>
        /// <param name="functionCode">功能码</param>
        /// <param name="startRegaddress">起始寄存器地址</param>
        /// <param name="setData">设置数据</param>
        /// <returns></returns>
        public byte[] WriteSingleAnalog(string deviceAddress, string functionCode, string startRegaddress, string setData)
        {
            byte[] byteSend = null;
            baseDeviceAddress = deviceAddress;
            baseFunctionCode = functionCode;
            baseStartRegAddress = startRegaddress;
            regNum = setData;
            byteSend = BaseConfig.strToToHexByte(deviceAddress + functionCode + baseStartRegAddress + regNum);
            byte[] crc = BaseConfig.crc16(byteSend);
            return BaseConfig.strToToHexByte(deviceAddress + functionCode + baseStartRegAddress + regNum + BaseConfig.byteToHexStr(crc));
        }
        #endregion

        #region 接收数据处理
        /// <summary>
        /// 对接收到的数据进行处理，获取需要的数据
        /// </summary>
        /// <returns>返回需要的有效数据</returns>
        public string RecvDeal()
        {
            if (recv != null)
            {
                if (baseFunctionCode == "03" && !regNum.Equals("0002") && !regNum.Equals("0010") && !regNum.Equals("003C") && !regNum.Equals("0004") && !regNum.Equals("0018"))
                {
                    string countStr = recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串           
                    return Int32.Parse(countStr, System.Globalization.NumberStyles.HexNumber).ToString();//将读取的计数值显示到文本框中 
                }

                if (baseFunctionCode == "04" && !regNum.Equals("0002") && !regNum.Equals("0004"))
                {
                    string countStr = recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串           
                    return Int32.Parse(countStr, System.Globalization.NumberStyles.HexNumber).ToString();//将读取的计数值显示到文本框中
                }
                //if (baseFunctionCode == "03" && regNum.Equals("0002") && !regNum.Equals("0004"))
                //{
                //    return recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串 
                //}
                //if (baseFunctionCode == "03" && regNum.Equals("0010") && !regNum.Equals("0004"))
                //{
                //    return recv.Substring(6, 4 * Int32.Parse(regNum, System.Globalization.NumberStyles.HexNumber));//截取返回数据中的有效的计数十六进制字符串 

                //}

                if (baseFunctionCode == "04" && regNum.Equals("0002") && !regNum.Equals("0004"))
                {
                    return recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串 
                }
                if (baseFunctionCode == "04" && regNum.Equals("0004"))
                {
                    return recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串 
                }
                if (baseFunctionCode == "06" && regNum.Equals("0010"))
                {
                    return recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串 
                }
                //if (baseFunctionCode == "03" && regNum.Equals("003C") && !regNum.Equals("0004"))
                //{
                //    return recv.Substring(6, 4 * Int32.Parse(regNum, System.Globalization.NumberStyles.HexNumber));//截取返回数据中的有效的计数十六进制字符串 
                //}
                if (baseFunctionCode == "01")
                {
                    return recv.Substring(6, 2 * ((Int32.Parse(regNum, System.Globalization.NumberStyles.HexNumber) + 7) / 8));//截取返回数据中的有效的计数十六进制字符串 
                }
                if (baseFunctionCode == "03" && (regNum.Equals("0004") || regNum.Equals("0018") || regNum.Equals("003C") || regNum.Equals("0010") || regNum.Equals("0002")))
                {
                    return recv.Substring(6,4 * (Int32.Parse(regNum, System.Globalization.NumberStyles.HexNumber)));//截取返回数据中的有效的计数十六进制字符串 
                }
                //    if (baseFunctionCode == "03" && regNum.Equals("0018"))
                //{
                //    return recv.Substring(6, 4 * (Int32.Parse(regNum, System.Globalization.NumberStyles.HexNumber)));//截取返回数据中的有效的计数十六进制字符串 
                //}
                else
                {
                    string statusStr = recv.Substring(9, 1);
                    return statusStr;
                }
            }
            else
            {

                return null;
               
            }

        }
        #endregion
    }
}
