using ModbusDebugTool.Core;
using ModbusDebugTool.Core;
using NewLife.Net;
using NewLife.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace ModbusDebugTool
{
    public partial class HandTest : DevComponents.DotNetBar.Office2007Form
    {
        private TimerX _sendTimer;//发送定时器
        public HandTest()
        {
            InitializeComponent();

        }

        private void HandTest_Load(object sender, EventArgs e)
        {

        }

        #region 命令1窗口到命令3窗口事件
        /// <summary>
        ///校验1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParity1_Click(object sender, EventArgs e)
        {
            txtCommand1.Text = Parity(txtCommand1.Text);

        }
        /// <summary>
        /// 发送命令1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend1_Click(object sender, EventArgs e)
        {
            SendCommand(txtCommand1.Text);
        }


        /// <summary>
        /// 校验2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParity2_Click(object sender, EventArgs e)
        {
            txtCommand2.Text = Parity(txtCommand2.Text);
        }
        /// <summary>
        /// 发送命令2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend2_Click(object sender, EventArgs e)
        {
            SendCommand(txtCommand2.Text);
        }


        /// <summary>
        /// 校验3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParity3_Click(object sender, EventArgs e)
        {
            txtCommand3.Text = Parity(txtCommand3.Text);
        }
        /// <summary>
        /// 发送命令3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend3_Click(object sender, EventArgs e)
        {
            SendCommand(txtCommand3.Text);
        }
        #endregion

        #region 公共事件
        /// <summary>
        /// 关闭定时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_sendTimer != null)
            {
                _sendTimer.Dispose();
            }
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstReturnCommand.Items.Clear();
        }
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <returns></returns>
        public string Trans(string command)
        {
            string recvData = null;
            ITransport transport=null;
            dynamic obj = new ExpandoObject();
            try
            {
                if (BaseConfig._ip == null)
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
                MessageBox.Show("创建通讯异常：{0}", transportException.Message);
            }

            if (transport != null)
            {

                try
                {
                    var sendBuff = BaseConfig.strToToHexByte(command);//要发送的命令
                    //定时器
                    if (!this.txtTime.Text.Trim().IsNullOrWhiteSpace() && this.cbTimer.Checked == true)
                    {
                        //transport.Send(sendBuff);//发送数据

                        ////接收数据
                        //byte[] recvByte = new byte[1024];
                        //int bytes = transport.Receive(recvByte);

                        //receiveBuff = new byte[bytes];
                        //Array.Copy(recvByte, 0, receiveBuff, 0, bytes); ;
                        //recv = BaseConfig.byteToHexStr(receiveBuff);
                        //string recvData = Regex.Replace(recv, @"(?<=[0-9A-F]{2})[0-9A-F]{2}", "$0");
                        //BaseConfig._recvData = recvData;//备用
                        ////BaseConfig._receive.Add(recvData);//用来存放接受数据的集合
                        //transport.Dispose();
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
                        var receiveBuff = new byte[bytes];
                        Array.Copy(recvByte, 0, receiveBuff, 0, bytes); ;
                        var recv = BaseConfig.byteToHexStr(receiveBuff);
                        recvData = Regex.Replace(recv, @"(?<=[0-9A-F]{2})[0-9A-F]{2}", "$0");
                        BaseConfig._recvData = recvData;//备用
                        //break;

                    }

                    //}
                    //MessageBox.Show("成功！");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("创建通讯异常", ex.Message);

                }
                finally
                {
                    transport.Dispose();
                }

            }
            return recvData;

        }
        /// <summary>
        /// 发送命令
        /// </summary>
        /// <param name="command"></param>
        public void SendCommand(string command)
        {
            if (!command.Trim().IsNullOrWhiteSpace())
            {
                if (cbTimer.Checked == false)
                {

                    SendDeal(command);

                }
                else
                {
                    //定时发送
                    if (txtTime.Value != null)
                    {
                        var time = Convert.ToInt32(txtTime.Value);
                        if (_sendTimer == null)
                            _sendTimer = new TimerX(obj => SendDeal(command), null, 100, time * 100);
                    }
                }
            }
        }
        /// <summary>
        /// 发送处理
        /// </summary>
        /// <param name="command"></param>
        public void SendDeal(string command)
        {
            string recv = null;//返回的命令
            recv = Trans(command.Replace(" ", ""));
            Log.WriteLog("发送命令：", command);
            Log.WriteLog("接受命令：", recv);
            if (recv != null)
            {
                lstReturnCommand.Items.Add(recv);
            }
        }
        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="inputCommand"></param>
        public string Parity(string inputCommand)
        {
            string commandStr = null;
            try
            {
                if (!inputCommand.Trim().IsNullOrWhiteSpace())
                {
                    var command = inputCommand.Replace(" ", "");
                    byte[] crc = BaseConfig.crc16(BaseConfig.strToToHexByte(command));//把16进制字符串转换为十六进制字节数组，然后校验
                    string crc16 = BaseConfig.byteToHexStr(crc);//把十六进制字节数组转换为十六进制字符串
                    commandStr = inputCommand + " " + crc16.Substring(0, 2) + " " + crc16.Substring(2, 2);
                }
            }
            catch (Exception)
            {
                commandStr = inputCommand;
                // throw;
                MessageBox.Show("输入的字符串有误！请认真检查！");
            }
            return commandStr;
        }

        /// <summary>
        /// 打开日志文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            String path = @"/bin/Debug/";
            System.Diagnostics.Process.Start("log.txt", path);
        }
        #endregion
    }
}
