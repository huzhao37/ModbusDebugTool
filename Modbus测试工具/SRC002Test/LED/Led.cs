using ModbusDebugTool.Core;
using ModbusDebugTool.Core.LEDProtocol;
using NewLife.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusDebugTool.LED
{
    public partial class Led : DevComponents.DotNetBar.Office2007Form
    {
          private static string _arg1;//参数1
        private static string _arg2;//参数2
        private static string _arg3;//参数3
         private static bool flag;//通信方式
        public Led()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置通信方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            if(this.rbtS.Checked==true&&this.rbtN.Checked==false)
            {
                _arg1 = this.cbSerialName.Text;
                _arg2 = this.cbBaudRate.Text;
                _arg3 = this.txtAddress.Text.Trim();
                flag = false;
            }
            if (this.rbtS.Checked == false && this.rbtN.Checked == true)
            {
                _arg1 = this.txtIP.Text.Trim();
                _arg2 = this.txtPort.Text.Trim();
                _arg3 = this.txtAddress1.Text.Trim();
                flag=true;
            }
        }
        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            //小卡通信
            if (this.cbCardType.SelectedIndex == 0 && _arg1 != null)
            {
                if(cbSendMethod.Text.EqualIgnoreCase("SendRom"))
                {
                    ModbusDebugTool.Core.LEDProtocol.SendRom led = new ModbusDebugTool.Core.LEDProtocol.SendRom();
                    var sendBytes = led.GetBytes(this.txtMessage.Text.ToString(), Convert.ToByte(_arg3));
                    if (flag) //网络通讯模式
                    {
                        #region 网络
                        var isPingOk = PingHelper.PingIpIsConnection(_arg1);
                        if (isPingOk)
                        {
                            var sessionString = string.Format("Tcp://{0}:{1}", _arg1, _arg2);
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
                                    receiveBytes[0] == ModbusDebugTool.Core.LEDProtocol.SendRom.Response)
                                {
                                    this.lblResult.Text = "发送成功！";
                                }
                                else
                                {
                                    this.lblResult.Text = "发送失败！";
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("网络不通！");
                        }
                        #endregion
                    }
                    else
                    {

                        try
                        {
                            SerialPort sp = new SerialPort(_arg1);
                            if (!sp.IsOpen) sp.Open();
                            sp.Write(sendBytes, 0, sendBytes.Length);
                            Thread.Sleep(50);
                            var b = sp.ReadByte();
                            if (b == ModbusDebugTool.Core.LEDProtocol.SendRom.Response)
                            {
                                this.lblResult.Text = "发送成功！";
                            }
                            else
                            {
                                this.lblResult.Text = "发送失败！";
                            }
                            //关闭串口
                            sp.Close();
                        }
                        catch (Exception ex)
                        {


                        }


                    }
               
                }

                else
                {
                    ModbusDebugTool.Core.LEDProtocol.SendRam led = new ModbusDebugTool.Core.LEDProtocol.SendRam();
                    var sendBytes = led.GetBytes(this.txtMessage.Text.ToString(), Convert.ToByte(_arg3));
                    if (flag) //网络通讯模式
                    {
                        #region 网络
                        var isPingOk = PingHelper.PingIpIsConnection(_arg1);
                        if (isPingOk)
                        {
                            var sessionString = string.Format("Tcp://{0}:{1}", _arg1, _arg2);
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
                                    receiveBytes[0] == ModbusDebugTool.Core.LEDProtocol.SendRam.Response)
                                {
                                    this.lblResult.Text = "发送成功！";
                                }
                                else
                                {
                                    this.lblResult.Text = "发送失败！";
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("网络不通！");
                        }
                        #endregion
                    }
                    else
                    {

                        try
                        {
                            SerialPort sp = new SerialPort(_arg1);
                            if (!sp.IsOpen) sp.Open();
                            sp.Write(sendBytes, 0, sendBytes.Length);
                            Thread.Sleep(50);
                            var b = sp.ReadByte();
                            if (b == ModbusDebugTool.Core.LEDProtocol.SendRam.Response)
                            {
                                this.lblResult.Text = "发送成功！";
                            }
                            else
                            {
                                this.lblResult.Text = "发送失败！";
                            }
                            //关闭串口
                            sp.Close();
                        }
                        catch (Exception ex)
                        {


                        }


                    }
                }

            }
            //大卡通信
            if (this.cbCardType.SelectedIndex == 1)
            {

                if (flag) //网络通讯模式
                {
                    #region 大卡发送


                    var result = -1;
                    //读数据，重试二次
                    if (result != 0)
                    {
                        for (var i = 0; i < 2; i++)
                        {
                            try
                            {
                                result = ModbusDebugTool.Core.LEDProtocol.TDLedAccess.SS_Send_Buffer_Ex((int.Parse(this.txtPage.Text) - 1) * 12 + Convert.ToInt32(this.txtNum.Text.Trim()), 9, 5, 5, 24, 1, this.txtMessage.Text.ToString(), false);
                                break;
                            }
                            catch (ObjectDisposedException odx)
                            {

                                //重新构建transport
                                TDLedAccess.SS_Open_Tcp(_arg1, Convert.ToInt32(_arg2), 3000);
                            }
                            catch (Exception ex)
                            {

                            }
                            this.lblResult.Text = String.Format("第{0}次发送数据失败", (i + 1).ToString());
                        }

                    }
                }
                    #endregion

            }
        }

        private void Led_Load(object sender, EventArgs e)
        {

        }
    }
}
