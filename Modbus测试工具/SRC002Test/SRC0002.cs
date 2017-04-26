using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLife.Net.Sockets;
using NewLife.Log;
using NewLife.Net;
using NewLife.Net.Common;
using NewLife;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using SRC002Test.Common;
namespace SRC0002Test
{
    public partial class SRC0002 : Form
    {
        private static string regNum;//读取的寄存器数量
        private static string workMode;//工作模式
        private static string onOff;//开关状态
        private static byte[] sendBuff;//发送的数据
        private static byte[] receiveBuff;//接收的数据
        private static string recv;//接收数据的字符串形式
        private static string funtionCode;//功能码
        private static string deviceAddress;//设备地址
        private static string startRegAddress;//起始地址
        public SRC0002()
        {
            InitializeComponent();
            this.lstReceiveData.Hide();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse("192.168.1.233", out ip))
            {
                MessageBox.Show("配置的IP地址格式错误,请先配置IP.");
                return;
            }

            int port = 10001;
            string sessionString = string.Format("Tcp://{0}:{1}", ip, port);
            TcpSession session;
            try
            {
                //session = NetService.CreateSession(new NetUri(sessionString));
                session = new TcpSession
                {
                    Remote = sessionString,
                    DisconnectWhenEmptyData = false,
                    AutoReconnect = false,

                    ThrowException = true
                };
                session.Open();
                session.Socket.ReceiveTimeout = 20 * 1000;
                //发送数据
                FunctionHandler();
                this.txtSendData.Text = BaseConfig.byteToHexStr(sendBuff);
                session.Send(sendBuff);//发送数据
                //接收数据
                receiveBuff = session.Receive();              
                recv = BaseConfig.byteToHexStr(receiveBuff);
                RecvDeal();
                string recvData = Regex.Replace(recv, @"(?<=[0-9A-F]{2})[0-9A-F]{2}", "$0");

                //string.Join(" ", Regex.Matches(recv.Replace(" ", ""), "\\d{2}").Cast<Match>().Select(x => x.Value).ToArray());
                //this.lstReceiveData.Items.Add(recv);
                this.lstReceiveData.Items.Add(recvData);
                session.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建连接失败");
            }
        }

        #region 发送数据处理
        /// <summary>
        /// 根据功能码执行发送数据的处理
        /// </summary>
        public void FunctionHandler()
        {
            int functionCode = this.cbFunction.SelectedIndex;//获取功能码的索引
            switch (functionCode)
            {
                case 0: ReadAbleWriteDigitalStatus(out sendBuff);
                    break;
                case 1: ReadOnlyReadDigitalStatus(out sendBuff);
                    break;
                case 2: ReadAbleWriteDigital(out sendBuff);
                    break;
                case 3: ReadOnlyReadAnalog(out sendBuff);
                    break;
                case 4: WriteSingleDigitalStatus(out sendBuff);
                    break;
                case 5: WriteSingleAnalogStatus(out sendBuff);
                    break;
                case 6: WriteMultiDigitalStatus(out sendBuff);
                    break;
                case 7: WriteMultiAnalogStatus(out sendBuff);
                    break;
            }
        }
        /// <summary>
        /// 根据选择索引给选项的Value赋值
        /// </summary>
        public void SelectConvert()
        {
            int indexOnOff = this.cbOnOrOff.SelectedIndex;
            switch (indexOnOff)
            {
                case 0: onOff = "FF00";
                    break;
                case 1: onOff = "0000";
                    break;
            }
        }
        /// <summary>
        /// 读可读写数字量寄存器线圈状态
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void ReadAbleWriteDigitalStatus(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "0" + (this.cbFunction.SelectedIndex + 1).ToString();
            startRegAddress = "000" + this.cbStartRegAddress.SelectedIndex.ToString();
            regNum = this.cbReadRegNum.SelectedItem.ToString();
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + BaseConfig.byteToHexStr(crc));
        }
        /// <summary>
        /// 读只读数字量寄存器的输入状态
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void ReadOnlyReadDigitalStatus(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "02";
            startRegAddress = "000" + this.cbStartRegAddress.SelectedIndex.ToString();
            regNum = this.cbReadRegNum.SelectedItem.ToString();
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + BaseConfig.byteToHexStr(crc));
        }
        /// <summary>
        /// 读可读写数字量寄存器
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void ReadAbleWriteDigital(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "03";
            startRegAddress = "0041";
            regNum = this.cbReadRegNum.SelectedItem.ToString();
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + BaseConfig.byteToHexStr(crc));
        }
        /// <summary>
        /// 读只读模拟量寄存器
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void ReadOnlyReadAnalog(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "04";
            startRegAddress = "000" + this.cbStartRegAddress.SelectedIndex.ToString();
            regNum = this.cbReadRegNum.SelectedItem.ToString();
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + BaseConfig.byteToHexStr(crc));
        }
        /// <summary>
        /// 写单个数字量寄存器状态
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void WriteSingleDigitalStatus(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "05";
            workMode = "000" + (this.cbSelectMode.SelectedIndex).ToString();
            SelectConvert();//获取设置的开关状态
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + workMode + onOff);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + workMode + onOff + BaseConfig.byteToHexStr(crc));
        }
        /// <summary>
        /// 写单个模拟量寄存器状态或者写波特率
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void WriteSingleAnalogStatus(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "06";
            startRegAddress = this.cbStartRegAddress.SelectedItem.ToString();
            if(startRegAddress!="0000")
            {
                SelectConvert();//获取设置的开关状态
                byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + onOff);
                byte[] crc = BaseConfig.crc16(byteSend);
                sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + onOff + BaseConfig.byteToHexStr(crc));
            }
            else
            {
                string setBaudRate = "000"+this.cbSetBaudRate.SelectedIndex.ToString();//获取设置的波特率数据
                byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + setBaudRate);
                byte[] crc = BaseConfig.crc16(byteSend);
                sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + setBaudRate + BaseConfig.byteToHexStr(crc));
            }         
        }
        /// <summary>
        /// 写多路数字量寄存器状态
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void WriteMultiDigitalStatus(out byte[] sendData)
        {
            byte[] byteSend = null;
            deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            funtionCode = "0F";
            startRegAddress = this.cbStartRegAddress.SelectedItem.ToString();/*起始寄存器地址待定*/
            regNum = this.cbReadRegNum.SelectedItem.ToString();
            string sendByteNum = "01";
            string[] statusBuff = new string[8];//发送字节的字符串数组
            #region 通过各路控制状态得到发送的数据
            if (int.Parse(regNum.Substring(2, 2)) == 1)
            {
                statusBuff[0] = "0";
                statusBuff[1] = "0";
                statusBuff[2] = "0";
                statusBuff[3] = "0";
                statusBuff[4] = "0";
                statusBuff[5] = "0";
                statusBuff[6] = "0";
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 2)
            {
                statusBuff[0] = "0";
                statusBuff[1] = "0";
                statusBuff[2] = "0";
                statusBuff[3] = "0";
                statusBuff[4] = "0";
                statusBuff[5] = "0";
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 3)
            {
                statusBuff[0] = "0";
                statusBuff[1] = "0";
                statusBuff[2] = "0";
                statusBuff[3] = "0";
                statusBuff[4] = "0";
                statusBuff[5] = this.cbThird.SelectedIndex.ToString();
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 4)
            {
                statusBuff[0] = "0";
                statusBuff[1] = "0";
                statusBuff[2] = "0";
                statusBuff[3] = "0";
                statusBuff[4] = this.cbFourth.SelectedIndex.ToString();
                statusBuff[5] = this.cbThird.SelectedIndex.ToString();
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 5)
            {
                statusBuff[0] = "0";
                statusBuff[1] = "0";
                statusBuff[2] = "0";
                statusBuff[3] = this.cbFifth.SelectedIndex.ToString();
                statusBuff[4] = this.cbFourth.SelectedIndex.ToString();
                statusBuff[5] = this.cbThird.SelectedIndex.ToString();
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 6)
            {
                statusBuff[0] = "0";
                statusBuff[1] = "0";
                statusBuff[2] = this.cbSixth.SelectedIndex.ToString();
                statusBuff[3] = this.cbFifth.SelectedIndex.ToString();
                statusBuff[4] = this.cbFourth.SelectedIndex.ToString();
                statusBuff[5] = this.cbThird.SelectedIndex.ToString();
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 7)
            {
                statusBuff[0] = "0";
                statusBuff[1] = this.cbSenven.SelectedIndex.ToString();
                statusBuff[2] = this.cbSixth.SelectedIndex.ToString();
                statusBuff[3] = this.cbFifth.SelectedIndex.ToString();
                statusBuff[4] = this.cbFourth.SelectedIndex.ToString();
                statusBuff[5] = this.cbThird.SelectedIndex.ToString();
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            if (int.Parse(regNum.Substring(2, 2)) == 8)
            {
                statusBuff[0] = this.cbEighth.SelectedIndex.ToString();
                statusBuff[1] = this.cbSenven.SelectedIndex.ToString();
                statusBuff[2] = this.cbSixth.SelectedIndex.ToString();
                statusBuff[3] = this.cbFifth.SelectedIndex.ToString();
                statusBuff[4] = this.cbFourth.SelectedIndex.ToString();
                statusBuff[5] = this.cbThird.SelectedIndex.ToString();
                statusBuff[6] = this.cbSecond.SelectedIndex.ToString();
                statusBuff[7] = this.cbFirst.SelectedIndex.ToString();
            }
            #endregion
            //int status = Convert.ToInt32(statusBuff.ToString(), 2);
            string s1 = statusBuff[0] + statusBuff[1] + statusBuff[2] + statusBuff[3];
            string s2 = statusBuff[4] + statusBuff[5] + statusBuff[6] + statusBuff[7];
            string status = String.Format("{0:X}", Convert.ToInt32(s1, 2)) + String.Format("{0:X}", Convert.ToInt32(s2, 2));
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + sendByteNum + status);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + sendByteNum + status + BaseConfig.byteToHexStr(crc));
        }
        /// <summary>
        /// 写多路模拟量寄存器状态
        /// </summary>
        /// <returns>返回发送指令</returns>
        public void WriteMultiAnalogStatus(out byte[] sendData)
        {
            byte[] byteSend = null;
            string deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
            string funtionCode = "10";
            string startRegAddress = this.cbStartRegAddress.SelectedItem.ToString();/*起始寄存器地址待定*/
            regNum = this.cbReadRegNum.SelectedItem.ToString();
            string sendByteNum = (Int32.Parse(regNum.Substring(3, 1)) * 2).ToString("X2");
            string[] statusBuff = new string[Int32.Parse(regNum.Substring(3, 1)) * 2 - 1];//发送字节的字符串数组
            #region 通过各路控制状态得到发送的数据
            if (Int32.Parse(regNum.Substring(3, 1)) == 1)
            {
                statusBuff[0] = this.txtFirst.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 2)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 3)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
                statusBuff[2] = this.txtThird.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 4)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
                statusBuff[2] = this.txtThird.Text;
                statusBuff[3] = this.txtFourth.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 5)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
                statusBuff[2] = this.txtThird.Text;
                statusBuff[3] = this.txtFourth.Text;
                statusBuff[4] = this.txtFifth.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 6)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
                statusBuff[2] = this.txtThird.Text;
                statusBuff[3] = this.txtFourth.Text;
                statusBuff[4] = this.txtFifth.Text;
                statusBuff[5] = this.txtSixth.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 7)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
                statusBuff[2] = this.txtThird.Text;
                statusBuff[3] = this.txtFourth.Text;
                statusBuff[4] = this.txtFifth.Text;
                statusBuff[5] = this.txtSixth.Text;
                statusBuff[6] = this.txtSeven.Text;
            }
            if (Int32.Parse(regNum.Substring(3, 1)) == 8)
            {
                statusBuff[0] = this.txtFirst.Text;
                statusBuff[1] = this.txtSecond.Text;
                statusBuff[2] = this.txtThird.Text;
                statusBuff[3] = this.txtFourth.Text;
                statusBuff[4] = this.txtFifth.Text;
                statusBuff[5] = this.txtSixth.Text;
                statusBuff[6] = this.txtSeven.Text;
                statusBuff[7] = this.txtEight.Text;
            }
            string buff = null;
            for (int i = 0; i < statusBuff.Length; i++)
            {
                buff = statusBuff[i] + buff;
            }
            #endregion
            //int status = Convert.ToInt32(statusBuff.ToString(), 2);
            //string s1 = statusBuff[0] + statusBuff[1] + statusBuff[2] + statusBuff[3];
            //string s2 = statusBuff[4] + statusBuff[5] + statusBuff[6] + statusBuff[7];
            //string status = String.Format("{0:X}", Convert.ToInt32(s1, 2)) + String.Format("{0:X}", Convert.ToInt32(s2, 2));
            byteSend = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + sendByteNum + buff);
            byte[] crc = BaseConfig.crc16(byteSend);
            sendData = BaseConfig.strToToHexByte(deviceAddress + funtionCode + startRegAddress + regNum + sendByteNum + buff + BaseConfig.byteToHexStr(crc));
        }

        #endregion

        #region 接收数据处理
        public void RecvDeal()
        {
            if ( funtionCode == "03")
            {
                string countStr = recv.Substring(6, 4 * Convert.ToInt32(regNum.Substring(3, 1)));//截取返回数据中的有效的计数十六进制字符串
                string[] str=new string[BaseConfig.strToToHexByte(countStr).Length];//定义一个用来存放计数数据的字符串数组
                for(int i=0;i<str.Length;i++)
                {
                    str[i] =Int32.Parse(BaseConfig.strToToHexByte(countStr)[i].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                }
               this.txtCount.Text = str.Join();//默认用逗号将计数分隔                
            }
        }
        #endregion

        private void btnReceive_Click(object sender, EventArgs e)
        {
            this.lstReceiveData.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteSingleAnalogStatus(out sendBuff);
        }

        //private void sRC0002ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.TopLevel = false;
        //    childForm.Parent = this;
        //    childForm.Show();
        //}
    }
    //    #region SRC0002测试
    //    public class TestService : NetServer
    //    {
    //        public TestService()
    //        {
    //            Name = "SCR0002测试服务端";
    //            Port = 10001;//监听端口号
    //        }
    //        /// <summary>
    //        /// 启动服务
    //        /// </summary>
    //        public void StartServer()
    //        {
    //            base.Start();//基类方法，启动服务
    //            foreach (var item in Servers)
    //            {
    //                TcpServer se = item as NewLife.Net.TcpServer;
    //                if (se != null)
    //                {
    //                    se.MaxNotActive = 0;//设置自动断开时间，这里为不自动断开
    //                    se.Error += new EventHandler<NewLife.ExceptionEventArgs>(OnError);
    //#if DEBUG
    //                    XTrace.WriteLine("设置{0}最大自动断开时间为0秒，并绑定错误事件。", se.ToString());
    //#endif
    //                }
    //            }

    //        }
    //        /// <summary>
    //        /// 停止服务
    //        /// </summary>
    //        public void StopServer()
    //        {
    //            foreach (var item in Servers)
    //            {
    //                TcpServer se = item as NewLife.Net.TcpServer;
    //                if (se != null)
    //                {
    //                    se.Error += new EventHandler<NewLife.ExceptionEventArgs>(OnError);
    //#if DEBUG
    //                    XTrace.WriteLine("设置{0}最大自动断开时间为0秒，并绑定错误事件。", se.ToString());
    //#endif
    //                }
    //            }
    //            base.Stop();
    //        }
    //        ///// <summary>
    //        ///// 网络错误
    //        ///// </summary>
    //        ///// <param name="sender"></param>
    //        ///// <param name="e"></param>
    //        //protected override void OnError(Object sender, NetEventArgs e)
    //        //{
    //        //    if (!EnableLog) return;

    //        //    if ((e.SocketError == SocketError.OperationAborted || e.SocketError == SocketError.ConnectionReset) && !ShowAbortAsError) return;

    //        //    if (e.SocketError != SocketError.Success || e.Error != null)
    //        //        WriteLog("{0} {1}错误 {2} {3}", sender, e.LastOperation, e.SocketError, e.Error);
    //        //    else
    //        //        WriteDebugLog("{0} {1}断开！", sender, e.LastOperation);
    //        //}
    //    #endregion




}
