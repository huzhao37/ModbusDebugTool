using DeviceDebugTool.Core.LEDProtocol;
using NewLife.Net;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;

namespace DeviceDebugTool.Core
{
    public class Helper
    {
        private static ITransport transport = null;
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="args">参数</param>
        /// <param name="communicatonType">通讯类型</param>
        public static bool CreateConnect(dynamic args1, dynamic args2, bool communicatonType)
        {
            var open = false;
            //communicatonType = false;//默认网络通讯
            dynamic args = new ExpandoObject();
            args.Args1 = args1;
            args.Args2 = args2;

            //串口通讯
            if (communicatonType == true)
            {
                transport = TransportFactory.CreateTransport(args, TransportEnum.Rs232);
            }
            else
            {
                transport = TransportFactory.CreateTransport(args, TransportEnum.Tcp);
            }
            open = transport.Open();
            return open;
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        /// <returns></returns>
        public static bool DisConnect()
        {
            var result = false;
            try
            {
                transport.Dispose();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }
        /// <summary>
        /// 发送命令
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static string Send(string command)
        {
            var recvStr = "";
            try
            {
                if (transport != null)
                {
                    var sendBuff = BaseConfig.strToToHexByte(command);//要发送的命令
                    transport.Send(sendBuff);//发送数据
                    //接收数据
                    byte[] recvByte = new byte[4096];
                    System.Threading.Thread.Sleep(300);
                    int bytes = transport.Receive(recvByte);
                    //System.Threading.Thread.Sleep(1000);
                    var receiveBuff = new byte[bytes];
                    Array.Copy(recvByte, 0, receiveBuff, 0, bytes); ;
                    var recv = BaseConfig.byteToHexStr(receiveBuff);
                    recvStr = Regex.Replace(recv, @"(?<=[0-9A-F]{2})[0-9A-F]{2}", "$0");
                    BaseConfig._recvData = recvStr;//备用
                }
            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return recvStr;
        }


        /// <summary>
        /// 发送圆心LED
        /// </summary>
        /// <param name="communicateType">通讯方式</param>
        /// <param name="isCardType">卡类型</param>
        /// <param name="deviceAddress">设备地址</param>
        /// <param name="args1">参数1</param>
        /// <param name="args2">参数2</param>
        /// <param name="sendMethod">发送方法</param>
        /// <param name="message">发送消息内容</param>
        /// <param name="page">节目页</param>
        /// <param name="num">位置</param>
        /// <returns>是否发送成功</returns>
        public static bool SendLed(bool communicateType,bool isCardType,int deviceAddress,string args1,int args2,string sendMethod,string message,int page,int num)
        {
            var result = false;
              //小卡通信
            if (isCardType==true)
            {
                if (sendMethod.EqualIgnoreCase("SendRom"))
                {
                    SendRom led = new SendRom();
                    var sendBytes = led.GetBytes(message, Convert.ToByte(deviceAddress));
                    if (communicateType) //网络通讯模式
                    {
                        #region 网络
                        var isPingOk = PingHelper.PingIpIsConnection(args1);
                        if (isPingOk)
                        {
                            var sessionString = string.Format("Tcp://{0}:{1}", args1, args2);
                            TcpSession socketSession = null;
                            try
                            {
                                socketSession = new TcpSession
                                {
                                    Remote = sessionString,
                                    DisconnectWhenEmptyData = false,
                                    AutoReconnect = false,
                                    ThrowException = true
                                };
                                //socketSession.Error += tcpSession_Error;
                                socketSession.Open();
                                //设置接收超时时间
                                socketSession.Socket.ReceiveTimeout = 5000;
                                socketSession.Send(sendBytes);
                                Thread.Sleep(50);
                                var receiveBytes = socketSession.Receive();
                                if (receiveBytes != null && receiveBytes.Length == 1 &&
                                    receiveBytes[0] ==SendRom.Response)
                                {
                                    result = true;
                                }
                                else
                                {
                                    result = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                result = false;
                                MainFrm frm = new MainFrm();
                                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            result = false;
                        }
                        #endregion
                    }
                    else
                    {

                        try
                        {
                            SerialPort sp = new SerialPort(args1);
                            if (!sp.IsOpen) sp.Open();
                            sp.Write(sendBytes, 0, sendBytes.Length);
                            Thread.Sleep(50);
                            var b = sp.ReadByte();
                            if (b == SendRom.Response)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                            //关闭串口
                            sp.Close();
                        }
                        catch (Exception ex)
                        {
                            result = false;
                            MainFrm frm = new MainFrm();
                            MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
               
                }

                else
                {
                    SendRam led = new SendRam();
                    var sendBytes = led.GetBytes(message, Convert.ToByte(deviceAddress));
                    if (communicateType) //网络通讯模式
                    {
                        #region 网络
                        var isPingOk = PingHelper.PingIpIsConnection(args1);
                        if (isPingOk)
                        {
                            var sessionString = string.Format("Tcp://{0}:{1}", args1, args2);
                            TcpSession socketSession = null;
                            try
                            {
                                socketSession = new TcpSession
                                {
                                    Remote = sessionString,
                                    DisconnectWhenEmptyData = false,
                                    AutoReconnect = false,
                                    ThrowException = true
                                };
                                //socketSession.Error += tcpSession_Error;
                                socketSession.Open();
                                //设置接收超时时间
                                socketSession.Socket.ReceiveTimeout = 5000;
                                socketSession.Send(sendBytes);
                                Thread.Sleep(50);
                                var receiveBytes = socketSession.Receive();
                                if (receiveBytes != null && receiveBytes.Length == 1 &&
                                    receiveBytes[0] == SendRam.Response)
                                {
                                    result = true;
                                }
                                else
                                {
                                    result = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                result = false;
                                MainFrm frm = new MainFrm();
                                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            result = false;
                        }
                        #endregion
                    }
                    else
                    {

                        try
                        {
                            SerialPort sp = new SerialPort(args1);
                            if (!sp.IsOpen) sp.Open();
                            sp.Write(sendBytes, 0, sendBytes.Length);
                            Thread.Sleep(50);
                            var b = sp.ReadByte();
                            if (b == SendRam.Response)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                            //关闭串口
                            sp.Close();
                        }
                        catch (Exception ex)
                        {
                            result = false;
                            MainFrm frm = new MainFrm();
                            MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }

            }
            //大卡通信
            else
            {

                if (communicateType) //网络通讯模式
                {
                    #region 大卡发送

                    TDLedAccess.SendReplay();//复位
                    var result1 = -1;
                    //读数据，重试二次
                    if (result1 != 0)
                    {
                        for (var i = 0; i < 2; i++)
                        {
                            try
                            {
                                TDLedAccess.SS_Open_Tcp(args1, Convert.ToInt32(args2), 3000);
                                result1 = TDLedAccess.SS_Send_Buffer_Ex((page - 1) * 12 + num, 16, 0, 1000, 16, 2, message, false);
                                if (result1 == 0) { result = true; break; }
                                else { result = false; }
                            }
                            catch (ObjectDisposedException odx)
                            {
                                result = false;
                                //重新构建transport
                                TDLedAccess.SS_Open_Tcp(args1, Convert.ToInt32(args2), 3000);
                                MainFrm frm = new MainFrm();
                                MetroMessageBox.Show(frm, odx.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                result = false;
                                MainFrm frm = new MainFrm();
                                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    TDLedAccess.SS_Close();
                    #endregion
                }


            }
            return result;
        }
    }
}
