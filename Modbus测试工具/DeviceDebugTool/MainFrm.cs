using DeviceDebugTool.Core;
using DeviceDebugTool.Core.TTSProtocal;
using IWshRuntimeLibrary;
using MetroFramework;
using NewLife.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviceDebugTool.Core.VideoProtocol;

namespace DeviceDebugTool
{
    public partial class MainFrm : MetroFramework.Forms.MetroForm
    {
        #region 实例化类对象及公共变量
        /// <summary>
        /// send TTS timer.
        /// </summary>
        private TimerX _ttsSendTimer;
        private TimerX _sendTimer;//发送定时器
        private Thread myThread;
        private static string cmds = "";
        string StartIPAddress = "";
        string EndIPAddress = "";
        int intStart = 0;                          //开始扫描地址
        int intEnd = 0;                           //终止扫描地址
        string strIP = "";
        string strflag = "";                      //扫描到的IP地址

        string hostName;
        string login;
        string password;
        int port = 23;
        IPAddress ipAdd;
        IPEndPoint ipEnd;
        Socket mysocket;
        /// <summary>
        ///球机相关信息
        /// </summary>
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private bool m_bInitSDK = false;
        private bool m_bRecord = false;
        private Int32 m_lRealHandle = -1;
        private string str;
        ModbusProtocol modbus = new ModbusProtocol();
        #endregion

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            this.rbtN.Checked = true;//加载默认网络通讯设置
            this.cbSerialName.SelectedIndex = 0;
            this.cbBaudRate.SelectedIndex = 6;

            #region 创建桌面快捷方式并开机启动的方法

            //获取当前系统用户启动目录
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            //获取当前系统用户桌面目录
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            FileInfo fileStartup = new FileInfo(startupPath + "\\DeviceDebugTool.exe.lnk");
            FileInfo fileDesktop = new FileInfo(desktopPath + "\\DeviceDebugTool.exe.lnk");

            if (!fileDesktop.Exists)
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(
                      Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
                       "\\" + "DeviceDebugTool.exe.lnk"
                       );
                shortcut.TargetPath = Application.StartupPath + "\\" + "DeviceDebugTool.exe";//启动更新程序★
                shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                shortcut.WindowStyle = 1;
                shortcut.Description = "设备调试工具";
                shortcut.IconLocation = Application.ExecutablePath;
                shortcut.Save();
            }

            if (!fileStartup.Exists)
            {
                //获取可执行文件快捷方式的全部路径
                string exeDir = desktopPath + "\\DeviceDebugTool.exe.lnk";
                //把程序快捷方式复制到启动目录
                //System.IO.File.Copy(exeDir, startupPath + "\\DeviceDebugTool.exe.lnk", true);
            }
            #endregion

        }
        /// <summary>
        /// 主题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void theme_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }
        /// <summary>
        /// 皮肤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skin_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }

        #region 工具
        /// <summary>
        /// modbus规约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel20_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                String path = @"/bin/Debug/";
                System.Diagnostics.Process.Start("Modbus规约.doc", path);
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// src0001寄存器说明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel21_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                String path = @"/bin/Debug/";
                System.Diagnostics.Process.Start("SRC0001寄存器说明.xlsx", path);
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// src0002寄存器说明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel22_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                String path = @"/bin/Debug/";
                System.Diagnostics.Process.Start("SRC0002寄存器说明.xlsx", path);
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region 搜索工具
        /// <summary>
        /// 定时扫描IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (strIP != "")                           //判读是否有可用IP地址
                {
                    if (strIP.IndexOf(',') == -1)
                    {
                        if (listBox3.Items.Count > 0)
                        {
                            for (int i = 0; i < listBox3.Items.Count; i++)
                            {
                                //判断扫描到的IP地址是否与列表中的重复
                                if (listBox3.Items[i].ToString() != strIP)
                                {
                                    //向列表中添加扫描到的已用IP地址
                                    listBox3.Items.Add(strIP);
                                }
                            }
                        }
                        else
                            //向列表汇总添加扫描到的已用IP地址
                            listBox3.Items.Add(strIP);
                    }
                    else
                    {
                        string[] strIPS = strIP.Split(',');
                        for (int i = 0; i < strIPS.Length; i++)
                        {
                            listBox3.Items.Add(strIPS[i].ToString());
                        }
                    }
                    strIP = "";
                }
                for (int i = 0; i < listBox3.Items.Count; i++)
                    //listBox3.Items[i].ImageIndex = 0;
                    if (progressBar1.Value < progressBar1.Maximum)  //判断进度条的当前值是否超出其最大值
                        //progressBar1.Value = strflag.LastIndexOf(".") + 1;                    //将进度条的值加1
                        progressBar1.Value = Int32.Parse(strflag.Substring(strflag.LastIndexOf(".") + 1));
                if (strflag == txtEnd.Text)  //判断正在扫描的IP地址是否是结束IP地址
                {
                    timer1.Stop();                              //停止运行计时器
                    txtStart.Enabled = txtEnd.Enabled = true;
                    btnStart.Text = "开始";                      //设置按钮文本为扫描
                    MessageBox.Show("IP地址扫描结束！");
                }
            }
            catch (Exception ex)
            {

                //throw;
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ///释放资源
            if (myThread != null)               //判断线程对象是否为空
            {
                //判断扫描IP地址的线程是否正在运行
                if (myThread.ThreadState == ThreadState.Running)
                {
                    myThread.Abort();           //终止线程
                }
            }

            if (_sendTimer != null)
            {
                _sendTimer.Dispose();
                //transport.Dispose();
            }
        }
        /// <summary>
        /// 开始扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            try
            {
                if (btnStart.Text == "开始")
                {
                    listBox3.Items.Clear();            //清空ListView控件中的项
                    txtStart.Enabled = txtEnd.Enabled = false;
                    strIP = "";
                    strflag = txtStart.Text;
                    StartIPAddress = txtStart.Text;
                    EndIPAddress = txtEnd.Text;
                    //开始扫描地址
                    intStart = Int32.Parse(StartIPAddress.Substring(StartIPAddress.LastIndexOf(".") + 1));
                    //终止扫描地址
                    intEnd = Int32.Parse(EndIPAddress.Substring(EndIPAddress.LastIndexOf(".") + 1));
                    //指定进度条最大值
                    progressBar1.Minimum = intStart;
                    //指定进度条最小值
                    progressBar1.Maximum = intEnd;
                    //指定进度条初始值
                    progressBar1.Value = progressBar1.Minimum;
                    timer1.Start();             //开始运行计时器
                    btnStart.Text = "停止";      //设置按钮文本为停止
                    //使用自定义方法StartScan实例化线程对象
                    myThread = new Thread(new ThreadStart(this.StartScan));
                    myThread.Start();                           //开始运行扫描IP的线程
                }
                else
                {
                    this.txtStart.Enabled = this.txtEnd.Enabled = true;
                    this.btnStart.Text = "开始";      //设置按钮文本为开始
                    timer1.Stop();              //停止运行计时器
                    //设置进度条的值为最大值
                    progressBar1.Value = intEnd;
                    if (myThread != null)       //判断线程对象是否为空
                    {
                        //判断扫描IP地址的线程是否正在运行
                        if (myThread.ThreadState == ThreadState.Running)
                        {
                            myThread.Abort();   //终止线程
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region 扫描局域网IP地址
        /// <summary>
        /// 扫描局域网IP地址
        /// </summary>
        /// <param name="StartIPAddress">开始扫描地址</param>
        /// <param name="intStart">起始地址</param>
        /// <param name="intEnd">结束地址</param>
        /// <param name="strIP">扫描到的IP地址</param>
        /// <param name="strflag"></param>
        private void StartScan()
        {
            try
            {
                //扫描的操作
                for (int i = intStart; i <= intEnd; i++)
                {
                    string strScanIP = StartIPAddress.Substring(0, StartIPAddress.LastIndexOf(".") + 1) + i.ToString();
                    //转换成IP地址
                    IPAddress myScanIP = IPAddress.Parse(strScanIP);
                    strflag = strScanIP;

                    //址获取DNS主机信息
                    //IPHostEntry myScanHost = Dns.GetHostEntry(myScanIP);
                    Ping ping = new Ping();
                    var address = strScanIP;//当前IP地址
                    var pingReply = ping.Send(address);
                    //获取主机名
                    //string strHostName = myScanHost.HostName.ToString();
                    //string strHostName = strScanIP;
                    //if (strIP == "")
                    if (pingReply.Buffer.Length > 0)
                    {
                        strIP += string.Format("来自 {0} 的回复：字节={1} 时间={2} TTL={3},", pingReply.Address, pingReply.Buffer.Length,
                                       pingReply.RoundtripTime, pingReply.Options.Ttl);
                    }
                }
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion
        /// <summary>
        /// 计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cacl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process sysCalculator = System.Diagnostics.Process.Start("calc.exe");
        }
        #endregion


        #endregion 工具

        #region 通讯设置

        /// <summary>
        /// 设置通讯方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.btnSet.Text == "连接")
            {
                dynamic obj = new ExpandoObject();
                if (this.rbtN.Checked == true)
                {

                    obj.Args1 = BaseConfig._ip = this.txtIP.Text.Trim();
                    obj.Args2 = BaseConfig._port = this.txtPort.Text;
                    BaseConfig._communicationMethod = 0;
                    try
                    {
                        var result = Helper.CreateConnect(obj.Args1, obj.Args2, false);
                        if (result == true) this.btnSet.Text = "断开";
                        else { MetroMessageBox.Show(this, "连接失败！", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (this.rbtS.Checked == true)
                {
                    obj.Args2 = BaseConfig._baudRate = Convert.ToInt32(this.cbBaudRate.Text.ToString());
                    obj.Args1 = BaseConfig._serialName = this.cbSerialName.Text.ToString();
                    //this.Close();
                    BaseConfig._communicationMethod = 1;
                    try
                    {
                        var result = Helper.CreateConnect(obj.Args1, obj.Args2, true);
                        if (result == true) this.btnSet.Text = "断开";
                        else { MetroMessageBox.Show(this, "连接失败！", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //MessageBox.Show("请选择通信方式！");
                    BaseConfig._communicationMethod = 0;
                }
            }
            else
            {
                if (Helper.DisConnect())//断开连接
                {
                    this.btnSet.Text = "连接";
                }
            }

        }
        /// <summary>
        /// ping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                var address = this.txtIP.Text;//当前IP地址
                var pingReply = ping.Send(address);
                if (pingReply.Buffer.Length > 0)
                {
                    string str = string.Format("来自 {0} 的回复：字节={1} 时间={2} TTL={3},", pingReply.Address, pingReply.Buffer.Length,
                                    pingReply.RoundtripTime, pingReply.Options.Ttl);
                    MetroMessageBox.Show(this, str, "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "网络不通！", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                //throw;
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        #region 手动测试
        /// <summary>
        /// 校验1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParity1_Click(object sender, EventArgs e)
        {
            txtCommand1.Text = Parity(txtCommand1.Text);
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
        /// 校验3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParity3_Click(object sender, EventArgs e)
        {
            txtCommand3.Text = Parity(txtCommand3.Text);
        }
        /// <summary>
        /// 发送命令1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend1_Click(object sender, EventArgs e)
        {

            ////创建线程
            //Thread newThread = new Thread(() =>
            //{
            SendCommand(txtCommand1.Text);
            //});
            ////加上这句话，否则在关闭窗体时会出现如下错误：在创建窗口句柄之前，不能在控件上调用 Invoke 或 BeginInvoke。
            //newThread.IsBackground = true;
            //newThread.Start();

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
        /// 发送命令3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend3_Click(object sender, EventArgs e)
        {
            SendCommand(txtCommand3.Text);
        }

        /// <summary>
        /// 清空窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstReturnCommand.Items.Clear();
        }
        /// <summary>
        /// 打开日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            String path = @"/bin/Debug/";
            System.Diagnostics.Process.Start("log.txt", path);
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
        /// 发送处理
        /// </summary>
        /// <param name="command"></param>
        public void SendDeal(string command)
        {
            string recv = null;//返回的命令
            recv = Helper.Send(command.Replace(" ", ""));
            Log.WriteLog("发送命令：", command);
            Log.WriteLog("接受命令：", recv);
            if (!recv.IsNullOrWhiteSpace())
            {
                try
                {
                    this.Invoke((EventHandler)(delegate
                    {
                        lstReturnCommand.Items.Add(recv);
                    }));
                }
                catch (Exception ex)
                {
                    MainFrm frm = new MainFrm();
                    MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //throw;
                }

            }
        }
        /// <summary>
        /// 发送命令
        /// </summary>
        /// <param name="command"></param>
        public void SendCommand(string command)
        {
            if (!command.Trim().IsNullOrWhiteSpace())
            {
                cmds = command;
                if (cbTimer1.Checked == false)
                {
                    //this.timer2.Enabled = false;
                    SendDeal(cmds);
                }
                else
                {
                    //定时发送

                    //this.timer2.Enabled = true;
                    //var time = Convert.ToInt32(txtTime1.Value) * 100;
                    ////if (_sendTimer == null)
                    ////_sendTimer = new TimerX(obj => SendDeal(command), null, 1000, time * 100);

                    //if (txtTime1.Value != 0)
                    //{
                    //    this.timer2.Interval = time;
                    //}
                }
            }
        }
        /// <summary>
        /// 定时器2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            SendDeal(cmds);
        }

        /// <summary>
        /// 控制是否定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTimer1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbTimer1.Checked == true) { this.timer2.Enabled = true; this.timer2.Interval = Convert.ToInt32(txtTime1.Value) * 100; }
            else { this.timer2.Enabled = false; }
        }
        #endregion

        #region TTS语音播报器
        /// <summary>
        /// 发送TTS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendTts_Click(object sender, EventArgs e)
        {
            if (this.cbTimer.Checked == false)
            {
                SendTts();
            }
            else
            {
                if (!this.txtTime.Value.ToString().IsNullOrWhiteSpace())
                {
                    var sendtime = Convert.ToInt32(this.txtTime.Value);
                    if (_ttsSendTimer == null)
                        //  this._ttsSendTimer = new TimerX(this.SendTts, null, 5000, sendtime * 1000 * 60);
                        _ttsSendTimer = new TimerX(obj => SendTts(), null, 5000, sendtime * 1000 * 60);
                }
            }
        }
        /// <summary>
        /// tts发送
        /// </summary>
        private void SendTts()
        {

            try
            {
                var com = BaseConfig._serialName;
                var serial = new SerialPort(com);
                serial.DataReceived += serial_DataReceived;
                if (!serial.IsOpen)
                    serial.Open();
                SpeechSynthesis sendText = new SpeechSynthesis();
                var info = txtInfo.Text;
                sendText.Data = Encoding.Default.GetBytes(info).ToList();
                sendText.CalculateExtendData();
                byte[] sendData = sendText.GetStream().ReadBytes();

                if (!_dicTtsAutoResetEvents.ContainsKey(com))
                {
                    _dicTtsAutoResetEvents.Add(com, new AutoResetEvent(false));
                }
                var are = _dicTtsAutoResetEvents[com];
                are.Reset();
                //发送数据
                serial.Write(sendData, 0, sendData.Length);
                //WsnServerConfig.WriteLog("TTS发送：" + sendData.ToHex());
                var hechengResult = are.WaitOne(2000, true);
                if (!hechengResult) //合成失败
                {
                    //WsnServerConfig.WriteLog("语音合成失败");
                    this.lblTtsMessage.Text = "语音合成失败";
                }
                else
                {
                    are.Reset();
                    var playResult = are.WaitOne(10 * 1000, true);
                    if (playResult)
                    {
                        //WsnServerConfig.WriteLog("语音播放成功");
                        this.lblTtsMessage.Text = "语音播放成功";
                    }
                    else
                    {
                        //WsnServerConfig.WriteLog("语音播放失败");
                        this.lblTtsMessage.Text = "语音播放失败";
                    }

                    Thread.Sleep(50);
                }

                if (serial.IsOpen)
                    serial.Close();
            }
            catch (Exception ex)
            {
                this.lblTtsMessage.Text = "通讯异常";
            }
        }

        void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var com = sender as SerialPort;
            if (com == null) return;
            if (!_dicTtsAutoResetEvents.ContainsKey(com.PortName)) return;

            var are = _dicTtsAutoResetEvents[com.PortName];
            var b = com.ReadByte();
            if (b == 0x41)
            {
                are.Set();
            }
            else if (b == 0x4f)
            {
                are.Set();
            }
            else if (b == 0x45)
            {
                //MessageBox.Show ("语音发送失败");
                this.lblTtsMessage.Text = "语音发送失败";
            }
        }

        private Dictionary<string, AutoResetEvent> _dicTtsAutoResetEvents = new Dictionary<string, AutoResetEvent>();
        #endregion

        #region LED
        /// <summary>
        /// LED发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            var card = true;
            var communicateType = true;
            var sendMethod = "SendRom";
            var page = Convert.ToInt32(txtPage.Text.Trim());
            var num = Convert.ToInt32(txtNum.Text.Trim());
            var message = txtMessage.Text.Trim();
            var address = Convert.ToInt32(txtLedAddress.Text.Trim());
            var args1 = "";
            var args2 = 0;
            if (cbCardType.Text == "圆心小卡") card = true;
            else card = false;
            if (BaseConfig._communicationMethod == 0)
            {
                communicateType = true; args1 = BaseConfig._ip; args2 = Convert.ToInt32(BaseConfig._port);
            }
            else
            {
                communicateType = false; args1 = BaseConfig._serialName; args2 = Convert.ToInt32(BaseConfig._baudRate);
            }

            if (cbSendMethod.Text == "SendRom") sendMethod = "SendRom";
            else sendMethod = "SendRam";
            var result = Helper.SendLed(communicateType, card, address, args1, args2, sendMethod, message, page, num);
            if (result) lblResult.Text = "发送成功";
            else lblResult.Text = "发送失败";

        }
        #endregion

        #region 海康威视

        //      /// <summary>
        ///// 清理所有正在使用的资源。
        ///// </summary>
        //protected override void Dispose(bool disposing)
        //      {
        //          if (m_lRealHandle >= 0)
        //          {
        //              CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
        //          }
        //          if (m_lUserID >= 0)
        //          {
        //              CHCNetSDK.NET_DVR_Logout(m_lUserID);
        //          }
        //          if (m_bInitSDK == true)
        //          {
        //              CHCNetSDK.NET_DVR_Cleanup();
        //          }
        //          if (disposing)
        //          {
        //              if (components != null)
        //              {
        //                  components.Dispose();
        //              }
        //          }
        //          base.Dispose(disposing);
        //      }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (this.btnSet.Text.Equals("断开"))
            {
                MetroMessageBox.Show(this, "请选断开连接！", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dynamic obj = new ExpandoObject();
            if (this.rbtN.Checked == true)
            {

                obj.Args1 = BaseConfig._ip = this.txtIP.Text.Trim();
                obj.Args2 = BaseConfig._port = this.txtPort.Text;
                BaseConfig._communicationMethod = 0;

            }
            else if (this.rbtS.Checked == true)
            {
                obj.Args1 = BaseConfig._baudRate = Convert.ToInt32(this.cbBaudRate.Text.ToString());
                obj.Args2 = BaseConfig._serialName = this.cbSerialName.Text.ToString();
                BaseConfig._communicationMethod = 1;
            }
            else
            {
                BaseConfig._communicationMethod = 0;
            }

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region 海康威视初始化
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MetroMessageBox.Show(this, "NET_DVR_Init error!", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //保存SDK日志 To save the SDK log
                //CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }
            #endregion

            if (txtI.Text == "" || txtDataport.Text == "" ||
                txtLoginName.Text == "" || txtLoginPwd.Text == "")
            {
                MetroMessageBox.Show(this, "Please input IP, Port, User name and Password!", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (m_lUserID < 0)
            {
                string DVRIPAddress = txtI.Text; //设备IP地址或者域名
                Int16 DVRPortNumber = Int16.Parse(txtDataport.Text);//设备服务端口号
                string DVRUserName = txtLoginName.Text;//设备登录用户名
                string DVRPassword = txtLoginPwd.Text;//设备登录密码

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //登录设备 Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //登录失败，输出错误号
                    MetroMessageBox.Show(this, str, "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //登录成功
                    MetroMessageBox.Show(this, "Login Success!", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.Text = "退出";
                }

            }
            else
            {
                //注销登录 Logout the device
                if (m_lRealHandle >= 0)
                {
                    MetroMessageBox.Show(this, "Please stop live view firstly", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MetroMessageBox.Show(this, str, "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                m_lUserID = -1;
                btnLogin.Text = "登录";
            }
            return;
        }
        /// <summary>
        /// 打开或关闭视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.btnOn.Checked == true)
            {
                if (m_lUserID < 0)
                {
                    MetroMessageBox.Show(this, "Please login the device firstly", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (m_lRealHandle < 0)
                {
                    CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                    lpPreviewInfo.hPlayWnd = this.RealPlayWnd.Handle;//预览窗口
                    lpPreviewInfo.lChannel = Int16.Parse("1");//预te览的设备通道
                    lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                    lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                    lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                    lpPreviewInfo.dwDisplayBufNum = 15; //播放库播放缓冲区最大缓冲帧数

                    CHCNetSDK.REALDATACALLBACK RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数
                    IntPtr pUser = new IntPtr();//用户数据

                    //打开预览 Start live view 
                    m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
                    if (m_lRealHandle < 0)
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //预览失败，输出错误号
                        MetroMessageBox.Show(this, str, "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        //预览成功
                        //btnPreview.Text = "Stop Live View";
                    }
                }
                else
                {
                    //停止预览 Stop live view 
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                        MessageBox.Show(str);
                        return;
                    }
                    m_lRealHandle = -1;
                    //btnPreview.Text = "Live View";
                    MetroMessageBox.Show(this, "预览失败！", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnLogin.Text = "登录";
                }
                return;
            }
            else
            {
                //停止预览 Stop live view 
                if (m_lRealHandle >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                    m_lRealHandle = -1;
                }

                //注销登录 Logout the device
                if (m_lUserID >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID);
                    m_lUserID = -1;
                }

                CHCNetSDK.NET_DVR_Cleanup();
                this.btnLogin.Text = "登录";
            }

        }

        /// <summary>
        /// 回调函数
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwDataType"></param>
        /// <param name="pBuffer"></param>
        /// <param name="dwBufSize"></param>
        /// <param name="pUser"></param>
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
        }

        #region Telnet
        /// <summary>
        /// 检查摄像机端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTelnet_Click(object sender, EventArgs e)
        {
            try
            {
                m_bInitSDK = CHCNetSDK.NET_DVR_Init();
                if (m_bInitSDK == false)
                {
                    MetroMessageBox.Show(this, "NET_DVR_Init error!", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //保存SDK日志 To save the SDK log
                    //CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
                }
                this.hostName = this.txtI.Text;
                this.login = this.txtLoginName.Text;
                this.password = this.txtLoginPwd.Text;
                this.port = Convert.ToInt32(this.txtDataport.Text);
                ipAdd = IPAddress.Parse(hostName);
                ipEnd = new IPEndPoint(ipAdd, port);
                mysocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                string result = GetData("telnet");
                MetroMessageBox.Show(this, result.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// 连接
        /// </summary>
        private void ConnetServer()
        {
            char[] sendfirst = new char[3];
            sendfirst[0] = (char)(255);
            sendfirst[1] = (char)(252);
            sendfirst[2] = (char)(24);
            byte[] sendfirstbytetemp = Encoding.Unicode.GetBytes(sendfirst);
            byte[] sendfirstbyte = new byte[sendfirstbytetemp.Length / 2];
            sendfirstbyte[0] = sendfirstbytetemp[0];
            sendfirstbyte[1] = sendfirstbytetemp[2];
            sendfirstbyte[2] = sendfirstbytetemp[4];
            mysocket.Send(sendfirstbyte, 0, sendfirstbyte.Length, SocketFlags.None);
            Thread.Sleep(300);
            byte[] sendusernametemp = Encoding.ASCII.GetBytes(login);
            byte[] sendusername = new byte[sendusernametemp.Length + 1];
            char[] closechar = new char[2];
            closechar[0] = (char)(10);
            closechar[1] = (char)(13);
            byte[] closebyte = Encoding.ASCII.GetBytes(closechar);
            for (int i = 0; i < sendusernametemp.Length; i++)
            {
                sendusername[i] = sendusernametemp[i];
            }
            sendusername[sendusername.Length - 1] = closebyte[0];
            mysocket.Send(sendusername, 0, sendusername.Length, SocketFlags.None);
            Thread.Sleep(300);
            byte[] senduserpasswdtemp = Encoding.ASCII.GetBytes(password);
            byte[] senduserpasswd = new byte[senduserpasswdtemp.Length + 1];
            char[] closechar2 = new char[2];
            closechar2[0] = (char)(10);
            closechar2[1] = (char)(13);
            byte[] closebyte2 = Encoding.ASCII.GetBytes(closechar2);
            for (int i = 0; i < senduserpasswdtemp.Length; i++)
            {
                senduserpasswd[i] = senduserpasswdtemp[i];
            }
            senduserpasswd[senduserpasswd.Length - 1] = closebyte2[0];
            mysocket.Send(senduserpasswd, 0, senduserpasswd.Length, SocketFlags.None);
            Thread.Sleep(500);
        }
        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="cmd"></param>
        private void ExcuteCommand(string cmd)
        {
            char[] sendfirst = new char[3];
            sendfirst[0] = (char)(255);
            sendfirst[1] = (char)(252);
            sendfirst[2] = (char)(24);
            byte[] sendfirstbytetemp = Encoding.Unicode.GetBytes(sendfirst);
            byte[] sendfirstbyte = new byte[sendfirstbytetemp.Length / 2];
            sendfirstbyte[0] = sendfirstbytetemp[0];
            sendfirstbyte[1] = sendfirstbytetemp[2];
            sendfirstbyte[2] = sendfirstbytetemp[4];
            mysocket.Send(sendfirstbyte, 0, sendfirstbyte.Length, SocketFlags.None);
            Thread.Sleep(300);
            byte[] recvdatauser = new byte[4096];
            mysocket.Receive(recvdatauser, 0, mysocket.Available, SocketFlags.None);
            string recvuserstr = Encoding.ASCII.GetString(recvdatauser);
            recvuserstr = recvuserstr.Substring(login.Length, recvuserstr.Length - login.Length);//去掉了服务器回显的用户名
            recvuserstr = recvuserstr.TrimEnd('\0');
            Console.Write(recvuserstr);
            Thread.Sleep(300);
            byte[] sendusernametemp = Encoding.ASCII.GetBytes(cmd);
            byte[] sendusername = new byte[sendusernametemp.Length + 1];
            char[] closechar = new char[2];
            closechar[0] = (char)(10);
            closechar[1] = (char)(13);
            byte[] closebyte = Encoding.ASCII.GetBytes(closechar);
            for (int i = 0; i < sendusernametemp.Length; i++)
            {
                sendusername[i] = sendusernametemp[i];
            }
            sendusername[sendusername.Length - 1] = closebyte[0];
            mysocket.Send(sendusername, 0, sendusername.Length, SocketFlags.None);
            Thread.Sleep(500);
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public string GetData(string cmd)
        {
            try
            {
                mysocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                mysocket.Connect(ipEnd);
                ConnetServer(); //连接服务
                ExcuteCommand(cmd);//执行命令
                byte[] recvdatauser = new byte[8192];
                mysocket.Receive(recvdatauser, 0, mysocket.Available, SocketFlags.None);
                string recvuserstr = Encoding.ASCII.GetString(recvdatauser);
                recvuserstr = recvuserstr.TrimEnd('\0');
                mysocket.Close();
                System.Threading.Thread.Sleep(300);
                //Console.Write("recvuserstr_string：" + recvuserstr);
                recvuserstr = recvuserstr.Substring(cmd.Length, recvuserstr.Length - cmd.Length).TrimStart();//去掉了服务器回显
                recvuserstr = this.login.Equals("root") ? recvuserstr.Replace("#", "").TrimEnd() : recvuserstr.Replace("$", "").TrimEnd();
                return recvuserstr;//.Split('\r')[1].Trim();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "EXError：" + ex.ToString();
            }
        }
        #endregion

        #endregion

        #region 485采集设备

        /// <summary>
        /// CO2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCo2_Click(object sender, EventArgs e)
        {
            this.cbCo2Function.SelectedIndex = 4;
            try
            {
                int index = this.cbCo2Function.SelectedIndex;
                switch (index)
                {
                    case 0:
                        if (DialogResult.OK == MessageBox.Show("你确定要用此功能？（慎用！）", "警告", MessageBoxButtons.OKCancel))
                        {
                            modbus.Communication("00", "03", "0000", "0001");
                            this.txtCo2PreAddress.Text = modbus.RecvDeal();
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case 1:
                        if (!this.txtCo2PreAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtCo2PreAddress.Text).ToString("X2"), "06", "0000", "00" + Convert.ToInt32(this.txtCo2FolAddress.Text).ToString("X2"));
                        }
                        else
                        {
                            MessageBox.Show("请输入当前设备地址！");
                        }
                        break;
                    case 2:
                        if (!this.txtCo2PreAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtCo2PreAddress.Text).ToString("X2"), "03", "0000", "0001");
                            this.txtCo2PreBaudRate.Text = modbus.RecvDeal();
                        }
                        else { MessageBox.Show("请输入当前设备地址！"); }
                        break;
                    case 3:
                        if (!this.txtCo2PreAddress.Text.Equals("") && !this.txtCo2PreBaudRate.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtCo2PreAddress.Text).ToString("X2"), "06", "0001", "00" + Convert.ToInt32(this.txtCo2FolBaudRate.Text).ToString("X2"));
                        }

                        else { MessageBox.Show("请输入当前设备地址或波特率！"); }
                        break;
                    case 4:
                        if (!this.txtCo2PreAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtCo2PreAddress.Text).ToString("X2"), "04", "0000", "0001");
                            this.txtCo2Value.Text = modbus.RecvDeal();
                        }
                        else
                        {
                            MessageBox.Show("请输入当前设备地址！");
                        }
                        break;
                    case 5:
                        if (!this.txtCo2PreAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtCo2PreAddress.Text).ToString("X2"), "03", "0000", "0002");
                            string baudRateAndAddesss = modbus.RecvDeal();
                            this.txtCo2PreAddress.Text = Int32.Parse(baudRateAndAddesss.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                            this.txtCo2PreBaudRate.Text = Int32.Parse(baudRateAndAddesss.Substring(4, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                        }
                        else
                        {
                            MessageBox.Show("请输入当前设备地址！");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// 有毒气体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPio_Click(object sender, EventArgs e)
        {
            try
            {

                modbus.Communication(Convert.ToInt32(this.txtPioPreAddress.Text).ToString("X2"), "03", "0065", "0001");
                this.txtPioValue.Text = modbus.RecvDeal();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 设施农业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTempHum_Click(object sender, EventArgs e)
        {
            this.cbTempHumFuction.SelectedIndex = 4;
            try
            {
                int index = this.cbTempHumFuction.SelectedIndex;
                switch (index)
                {
                    case 0:
                        if (DialogResult.OK == MessageBox.Show("你确定要用此功能？（慎用！）", "警告", MessageBoxButtons.OKCancel))
                        {
                            modbus.Communication("00", "03", "0000", "0001");
                            this.txtTempHumPreAddress.Text = modbus.RecvDeal();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 1:
                        if (!this.txtTempHumPreAddress.Text.Equals("") && !this.txtTempHumFolAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtTempHumPreAddress.Text).ToString("X2"), "06", "0000", Convert.ToInt32(this.txtTempHumFolAddress.Text).ToString("X2"));
                        }
                        else { MessageBox.Show("请输入当前的设备地址或者要设置的设备地址！"); }
                        break;
                    case 2:
                        if (!this.txtTempHumPreAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtTempHumPreAddress.Text).ToString("X2"), "03", "0000", "0001");
                            this.txtTempHumPreBaudRate.Text = modbus.RecvDeal();
                        }
                        else { MessageBox.Show("请输入当前的设备地址！"); }
                        break;
                    case 3:
                        if (!this.txtTempHumPreAddress.Text.Equals("") && !this.txtTempHumFolBaudRate.Text.Equals(""))
                        {

                            modbus.Communication(Convert.ToInt32(this.txtTempHumPreAddress.Text).ToString("X2"), "06", "0001", Convert.ToInt32(this.txtTempHumFolBaudRate.Text).ToString("X2"));
                        }
                        else { MessageBox.Show("请输入当前的设备地址或者要设置的波特率！！"); }
                        break;
                    case 4:
                        if (!this.txtTempHumPreAddress.Text.Equals(""))
                        {
                            modbus.Communication(Convert.ToInt32(this.txtTempHumPreAddress.Text).ToString("X2"), "04", "0000", "0002");
                            string tempAndHumi = modbus.RecvDeal();
                            var txtAirTemp = Int32.Parse(tempAndHumi.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                            var txtHumi = Int32.Parse(tempAndHumi.Substring(4, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                            this.txtTempHumValue.Text = "T:" + txtAirTemp + "  H:" + txtHumi;
                        }
                        else { MessageBox.Show("请输入当前的设备地址！"); }
                        break;
                    case 5:
                        if (!this.txtTempHumPreAddress.Text.Equals(""))
                        {

                            modbus.Communication(Convert.ToInt32(this.txtTempHumPreAddress.Text).ToString("X2"), "03", "0000", "0002");
                            string baudRateAndAddesss = modbus.RecvDeal();
                            this.txtTempHumPreAddress.Text = Int32.Parse(baudRateAndAddesss.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                            this.txtTempHumPreBaudRate.Text = Int32.Parse(baudRateAndAddesss.Substring(4, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                        }
                        else { MessageBox.Show("请输入当前的设备地址！"); }
                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// 气象站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWea_Click(object sender, EventArgs e)
        {
            cbWeaFunction.SelectedIndex = 4;
            try
            {
                modbus.Communication(Convert.ToInt32(this.txtWeaPreAddress.Text).ToString("X2"), "03", "0000", "000D");
                var value = modbus.RecvDeal();
                var v1 = (Int32.Parse(value.Substring(0, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v2 = (Int32.Parse(value.Substring(4, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v3 = (Int32.Parse(value.Substring(8, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v4 = (Int32.Parse(value.Substring(12, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v5 = (Int32.Parse(value.Substring(16, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v6 = (Int32.Parse(value.Substring(20, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v7 = (Int32.Parse(value.Substring(24, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v8 = (Int32.Parse(value.Substring(28, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v9 = (Int32.Parse(value.Substring(32, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v10 = (Int32.Parse(value.Substring(36, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v11 = (Int32.Parse(value.Substring(40, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v12 = (Int32.Parse(value.Substring(44, 4), System.Globalization.NumberStyles.HexNumber)).ToString();
                var v13 = (Int32.Parse(value.Substring(48, 4), System.Globalization.NumberStyles.HexNumber)).ToString();

                this.txtWeaValue.Text = "1:" + v1 + "  2:" + v2 + "  3:" + v3 + "  4:" + v4 + "  5:" + v5 + "  6:" + v6 + "  7:" + v7 + "  8:" + v8 + "  9:" + v9 + "  10:" + v10 + "  11:" + v11 + "  12:" + v12 + "  13:" + v13;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 4-20mA采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnmAValue_Click(object sender, EventArgs e)
        {
            this.cbReg.Text = "0000";
            try
            {
                modbus.Communication(Convert.ToInt32(this.txtCollectAddress.Text).ToString("X2"), "04", this.cbReg.Text.ToString(), "0001");
                this.txtCollectValue.Text = modbus.RecvDeal();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 写线圈状态
        private void btnOnOrOff1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0000", this.cbOnOrOff1.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0001", this.cbOnOrOff2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0002", this.cbOnOrOff3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0003", this.cbOnOrOff4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0004", this.cbOnOrOff5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0005", this.cbOnOrOff6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0006", this.cbOnOrOff7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0007", this.cbOnOrOff8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff9_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0008", this.cbOnOrOff9.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff10_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0009", this.cbOnOrOff10.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff11_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000A", this.cbOnOrOff11.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff12_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000B", this.cbOnOrOff12.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff13_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000C", this.cbOnOrOff13.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff14_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000D", this.cbOnOrOff14.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff15_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000E", this.cbOnOrOff15.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff16_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "000F", this.cbOnOrOff16.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff17_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0010", this.cbOnOrOff17.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff18_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0011", this.cbOnOrOff18.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff19_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0012", this.cbOnOrOff19.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnOnOrOff20_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0013", this.cbOnOrOff20.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] onOrOffChar = new string[20];//存放线圈状态的字符数组
            //高低位反过来
            onOrOffChar[7] = cbOnOrOff1.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[6] = cbOnOrOff2.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[5] = cbOnOrOff3.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[4] = cbOnOrOff4.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[3] = cbOnOrOff5.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[2] = cbOnOrOff6.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[1] = cbOnOrOff7.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[0] = cbOnOrOff8.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[15] = cbOnOrOff9.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[14] = cbOnOrOff10.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[13] = cbOnOrOff11.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[12] = cbOnOrOff12.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[11] = cbOnOrOff13.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[10] = cbOnOrOff14.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[9] = cbOnOrOff15.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[8] = cbOnOrOff16.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[19] = cbOnOrOff17.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[18] = cbOnOrOff18.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[17] = cbOnOrOff19.SelectedValue.ToString().Substring(0, 1);
            onOrOffChar[16] = cbOnOrOff20.SelectedValue.ToString().Substring(0, 1);
            for (int i = 0; i < 20; i++)
            {
                if (onOrOffChar[i] == "F")
                {
                    onOrOffChar[i] = "1";
                }
                else
                {
                    onOrOffChar[i] = "0";
                }
            }
            string str1 = onOrOffChar[0] + onOrOffChar[1] + onOrOffChar[2] + onOrOffChar[3];
            string str2 = onOrOffChar[4] + onOrOffChar[5] + onOrOffChar[6] + onOrOffChar[7];
            string str3 = onOrOffChar[8] + onOrOffChar[9] + onOrOffChar[10] + onOrOffChar[11];
            string str4 = onOrOffChar[12] + onOrOffChar[13] + onOrOffChar[14] + onOrOffChar[15];
            string str5 = onOrOffChar[16] + onOrOffChar[17] + onOrOffChar[18] + onOrOffChar[19];

            string statusStr = string.Format("{0:x}", Convert.ToInt32(str1, 2)) + string.Format("{0:x}", Convert.ToInt32(str2, 2)) + string.Format("{0:x}", Convert.ToInt32(str3, 2)) + string.Format("{0:x}", Convert.ToInt32(str4, 2)) + string.Format("{0:x}", "0" + Convert.ToInt32(str5, 2));
            modbus.Communication(BaseConfig._deviceAddress, "0F", "0000", "001403" + statusStr);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "01", "0000", "0014");
                if (modbus.RecvDeal() != null)
                {


                    string statusStr = modbus.RecvDeal();
                    string statusStr1 = statusStr.Substring(0, 1);
                    string statusStr2 = statusStr.Substring(1, 1);
                    string statusStr3 = statusStr.Substring(2, 1);
                    string statusStr4 = statusStr.Substring(3, 1);
                    string statusStr5 = statusStr.Substring(5, 1);
                    string status1 = Convert.ToString(Int32.Parse(statusStr1, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status2 = Convert.ToString(Int32.Parse(statusStr2, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status3 = Convert.ToString(Int32.Parse(statusStr3, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status4 = Convert.ToString(Int32.Parse(statusStr4, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status5 = Convert.ToString(Int32.Parse(statusStr5, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制

                    string[] coilChar = new string[20];//存放线圈状态的字符数组
                    //判断status1的情况
                    if (status1.Length == 1)
                    {
                        status1 = "000" + status1;
                    }
                    if (status1.Length == 2)
                    {
                        status1 = "00" + status1;
                    }
                    if (status1.Length == 3)
                    {
                        status1 = "0" + status1;
                    }

                    //判断status2的情况
                    if (status2.Length == 1)
                    {
                        status2 = "000" + status2;
                    }
                    if (status2.Length == 2)
                    {
                        status2 = "00" + status2;
                    }
                    if (status2.Length == 3)
                    {
                        status2 = "0" + status2;
                    }

                    //判断status3的情况
                    if (status3.Length == 1)
                    {
                        status3 = "000" + status3;
                    }
                    if (status3.Length == 2)
                    {
                        status3 = "00" + status3;
                    }
                    if (status3.Length == 3)
                    {
                        status3 = "0" + status3;
                    }

                    //判断status4的情况
                    if (status4.Length == 1)
                    {
                        status4 = "000" + status4;
                    }
                    if (status4.Length == 2)
                    {
                        status4 = "00" + status4;
                    }
                    if (status4.Length == 3)
                    {
                        status4 = "0" + status4;
                    }

                    //判断status5的情况
                    if (status5.Length == 1)
                    {
                        status5 = "000" + status5;
                    }
                    if (status5.Length == 2)
                    {
                        status5 = "00" + status5;
                    }
                    if (status5.Length == 3)
                    {
                        status5 = "0" + status5;
                    }

                    string status = status1 + status2 + status3 + status4 + status5;//存放线圈状态的字符串
                    for (int i = 0; i < status.Length; i++)
                    {
                        coilChar[i] = status.Substring(i, 1);
                        if (coilChar[i].Equals("1"))
                        {
                            coilChar[i] = "FF";
                        }
                        else
                        {
                            coilChar[i] = "00";
                        }
                    }
                    cbOnOrOff1.SelectedValue = coilChar[7] + "00";
                    cbOnOrOff2.SelectedValue = coilChar[6] + "00";
                    cbOnOrOff3.SelectedValue = coilChar[5] + "00";
                    cbOnOrOff4.SelectedValue = coilChar[4] + "00";
                    cbOnOrOff5.SelectedValue = coilChar[3] + "00";
                    cbOnOrOff6.SelectedValue = coilChar[2] + "00";
                    cbOnOrOff7.SelectedValue = coilChar[1] + "00";
                    cbOnOrOff8.SelectedValue = coilChar[0] + "00";
                    cbOnOrOff9.SelectedValue = coilChar[15] + "00";
                    cbOnOrOff10.SelectedValue = coilChar[14] + "00";
                    cbOnOrOff11.SelectedValue = coilChar[13] + "00";
                    cbOnOrOff12.SelectedValue = coilChar[12] + "00";
                    cbOnOrOff13.SelectedValue = coilChar[11] + "00";
                    cbOnOrOff14.SelectedValue = coilChar[10] + "00";
                    cbOnOrOff15.SelectedValue = coilChar[9] + "00";
                    cbOnOrOff16.SelectedValue = coilChar[8] + "00";
                    cbOnOrOff17.SelectedValue = coilChar[19] + "00";
                    cbOnOrOff18.SelectedValue = coilChar[18] + "00";
                    cbOnOrOff19.SelectedValue = coilChar[17] + "00";
                    cbOnOrOff20.SelectedValue = coilChar[16] + "00";
                }
                else
                {
                    //MessageBox.Show("通讯异常！"); 
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("通讯异常！");
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region 组合方式
        private void btnCombination1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0029", this.cbCombination1.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002A", this.cbCombination2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002B", this.cbCombination3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002C", this.cbCombination4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002D", this.cbCombination5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002E", this.cbCombination6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002F", this.cbCombination7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0030", this.cbCombination8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination9_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0031", this.cbCombination9.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination10_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0032", this.cbCombination10.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination11_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0033", this.cbCombination11.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination12_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0034", this.cbCombination12.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination13_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0035", this.cbCombination13.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination14_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0036", this.cbCombination14.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination15_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0037", this.cbCombination15.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination16_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0038", this.cbCombination16.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination17_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0039", this.cbCombination17.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination18_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "003A", this.cbCombination18.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination19_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "003B", this.cbCombination19.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination20_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "003C", this.cbCombination20.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string[] combinationChar = new string[20];//存放组合方式的字符数组      

                //组合方式
                combinationChar[0] = cbCombination1.SelectedValue.ToString();
                combinationChar[1] = cbCombination2.SelectedValue.ToString();
                combinationChar[2] = cbCombination3.SelectedValue.ToString();
                combinationChar[3] = cbCombination4.SelectedValue.ToString();
                combinationChar[4] = cbCombination5.SelectedValue.ToString();
                combinationChar[5] = cbCombination6.SelectedValue.ToString();
                combinationChar[6] = cbCombination7.SelectedValue.ToString();
                combinationChar[7] = cbCombination8.SelectedValue.ToString();
                combinationChar[8] = cbCombination9.SelectedValue.ToString();
                combinationChar[9] = cbCombination10.SelectedValue.ToString();
                combinationChar[10] = cbCombination11.SelectedValue.ToString();
                combinationChar[11] = cbCombination12.SelectedValue.ToString();
                combinationChar[12] = cbCombination13.SelectedValue.ToString();
                combinationChar[13] = cbCombination14.SelectedValue.ToString();
                combinationChar[14] = cbCombination15.SelectedValue.ToString();
                combinationChar[15] = cbCombination16.SelectedValue.ToString();
                combinationChar[16] = cbCombination17.SelectedValue.ToString();
                combinationChar[17] = cbCombination18.SelectedValue.ToString();
                combinationChar[18] = cbCombination19.SelectedValue.ToString();
                combinationChar[19] = cbCombination20.SelectedValue.ToString();

                string statusStr = String.Join("", combinationChar);

                modbus.Communication(BaseConfig._deviceAddress, "10", "0029", "0014" + "28" + statusStr);


            }
            catch (Exception ex)
            {
                //MessageBox.Show("通讯异常！"); 
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 获取当前设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "03", "0001", "003C");
                if (modbus.RecvDeal() != null)
                {
                    string statusStr = modbus.RecvDeal();
                    string combinationStatus = statusStr.Substring(160, 80);
                    string[] combinationChar = new string[20];//存放组合状态的字符数组
                    for (int i = 0; i < combinationStatus.Length / 4; i++)
                    {
                        combinationChar[i] = combinationStatus.Substring(i * 4, 4);
                    }
                    cbCombination1.SelectedValue = combinationChar[0];
                    cbCombination2.SelectedValue = combinationChar[1];
                    cbCombination3.SelectedValue = combinationChar[2];
                    cbCombination4.SelectedValue = combinationChar[3];
                    cbCombination5.SelectedValue = combinationChar[4];
                    cbCombination6.SelectedValue = combinationChar[5];
                    cbCombination7.SelectedValue = combinationChar[6];
                    cbCombination8.SelectedValue = combinationChar[7];
                    cbCombination9.SelectedValue = combinationChar[8];
                    cbCombination10.SelectedValue = combinationChar[9];
                    cbCombination11.SelectedValue = combinationChar[10];
                    cbCombination12.SelectedValue = combinationChar[11];
                    cbCombination13.SelectedValue = combinationChar[12];
                    cbCombination14.SelectedValue = combinationChar[13];
                    cbCombination15.SelectedValue = combinationChar[14];
                    cbCombination16.SelectedValue = combinationChar[15];
                    cbCombination17.SelectedValue = combinationChar[16];
                    cbCombination18.SelectedValue = combinationChar[17];
                    cbCombination19.SelectedValue = combinationChar[18];
                    cbCombination20.SelectedValue = combinationChar[19];

                }
                else
                {
                    //MessageBox.Show("通讯异常！");
                }
            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
        }

        /// <summary>
        /// 数据源绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel7_Enter(object sender, EventArgs e)
        {
            //var list = new[]{
            //    new {
            //        SelectedText = "与第1路组合端口",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "与第2路组合端口",
            //        SelectedValue="0001"
            //    },
            //    new {
            //        SelectedText = "与第3路组合端口",
            //        SelectedValue="0002"
            //    },
            //    new {
            //        SelectedText = "与第4路组合端口",
            //        SelectedValue="0003"
            //    },
            //    new {
            //        SelectedText = "与第5路组合端口",
            //        SelectedValue="0004"
            //    },
            //    new {
            //        SelectedText = "与第6路组合端口",
            //        SelectedValue="0005"
            //    },
            //    new {
            //        SelectedText = "与第7路组合端口",
            //        SelectedValue="0006"
            //    },

            //    new {
            //        SelectedText = "与第8路组合端口",
            //        SelectedValue="0007"
            //    },
            //     new {
            //        SelectedText = "与第9路组合端口",
            //        SelectedValue="0008"
            //    },
            //    new {
            //        SelectedText = "与第10路组合端口",
            //        SelectedValue="0009"
            //    },
            //    new {
            //        SelectedText = "与第11路组合端口",
            //        SelectedValue="000A"
            //    },
            //    new {
            //        SelectedText = "与第12路组合端口",
            //        SelectedValue="000B"
            //    },
            //    new {
            //        SelectedText = "与第13路组合端口",
            //        SelectedValue="000C"
            //    },
            //    new {
            //        SelectedText = "与第14路组合端口",
            //        SelectedValue="000D"
            //    },
            //    new {
            //        SelectedText = "与第15路组合端口",
            //        SelectedValue="000E"
            //    },

            //    new {
            //        SelectedText = "与第16路组合端口",
            //        SelectedValue="000F"
            //    },
            //    new {
            //        SelectedText = "与第17路组合端口",
            //        SelectedValue="0010"
            //    },
            //    new {
            //        SelectedText = "与第18路组合端口",
            //        SelectedValue="0011"
            //    },
            //    new {
            //        SelectedText = "与第19路组合端口",
            //        SelectedValue="0012"
            //    },

            //    new {
            //        SelectedText = "与第20路组合端口",
            //        SelectedValue="0013"
            //    }
            //};
            //cbCombination1.DataSource = list.Clone();
            //cbCombination1.DisplayMember = "SelectedText";
            //cbCombination1.ValueMember = "SelectedValue";
            //cbCombination2.DataSource = list.Clone();
            //cbCombination2.DisplayMember = "SelectedText";
            //cbCombination2.ValueMember = "SelectedValue";
            //cbCombination3.DataSource = list.Clone();
            //cbCombination3.DisplayMember = "SelectedText";
            //cbCombination3.ValueMember = "SelectedValue";
            //cbCombination4.DataSource = list.Clone();
            //cbCombination4.DisplayMember = "SelectedText";
            //cbCombination4.ValueMember = "SelectedValue";
            //cbCombination5.DataSource = list.Clone();
            //cbCombination5.DisplayMember = "SelectedText";
            //cbCombination5.ValueMember = "SelectedValue";
            //cbCombination6.DataSource = list.Clone();
            //cbCombination6.DisplayMember = "SelectedText";
            //cbCombination6.ValueMember = "SelectedValue";
            //cbCombination7.DataSource = list.Clone();
            //cbCombination7.DisplayMember = "SelectedText";
            //cbCombination7.ValueMember = "SelectedValue";
            //cbCombination8.DataSource = list.Clone();
            //cbCombination8.DisplayMember = "SelectedText";
            //cbCombination8.ValueMember = "SelectedValue";
            //cbCombination9.DataSource = list.Clone();
            //cbCombination9.DisplayMember = "SelectedText";
            //cbCombination9.ValueMember = "SelectedValue";
            //cbCombination10.DataSource = list.Clone();
            //cbCombination10.DisplayMember = "SelectedText";
            //cbCombination10.ValueMember = "SelectedValue";
            //cbCombination11.DataSource = list.Clone();
            //cbCombination11.DisplayMember = "SelectedText";
            //cbCombination11.ValueMember = "SelectedValue";
            //cbCombination12.DataSource = list.Clone();
            //cbCombination12.DisplayMember = "SelectedText";
            //cbCombination12.ValueMember = "SelectedValue";
            //cbCombination13.DataSource = list.Clone();
            //cbCombination13.DisplayMember = "SelectedText";
            //cbCombination13.ValueMember = "SelectedValue";
            //cbCombination14.DataSource = list.Clone();
            //cbCombination14.DisplayMember = "SelectedText";
            //cbCombination14.ValueMember = "SelectedValue";
            //cbCombination15.DataSource = list.Clone();
            //cbCombination15.DisplayMember = "SelectedText";
            //cbCombination15.ValueMember = "SelectedValue";
            //cbCombination16.DataSource = list.Clone();
            //cbCombination16.DisplayMember = "SelectedText";
            //cbCombination16.ValueMember = "SelectedValue";
            //cbCombination17.DataSource = list.Clone();
            //cbCombination17.DisplayMember = "SelectedText";
            //cbCombination17.ValueMember = "SelectedValue";
            //cbCombination18.DataSource = list.Clone();
            //cbCombination18.DisplayMember = "SelectedText";
            //cbCombination18.ValueMember = "SelectedValue";
            //cbCombination19.DataSource = list.Clone();
            //cbCombination19.DisplayMember = "SelectedText";
            //cbCombination19.ValueMember = "SelectedValue";
            //cbCombination20.DataSource = list.Clone();
            //cbCombination20.DisplayMember = "SelectedText";
            //cbCombination20.ValueMember = "SelectedValue";
        }
        #endregion

        #region 设置延迟时间和工作模式设置

        #region 工作模式设置
        private void btnMode1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0001", this.cbMode1.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void btnMode2_Click(object sender, EventArgs e)
        {

            modbus.Communication(BaseConfig._deviceAddress, "06", "0002", this.cbMode2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0003", this.cbMode3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode4_Click(object sender, EventArgs e)
        {

            modbus.Communication(BaseConfig._deviceAddress, "06", "0004", this.cbMode4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0005", this.cbMode5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0006", this.cbMode6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0007", this.cbMode7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0008", this.cbMode8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void btnMode9_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0009", this.cbMode9.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode10_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000A", this.cbMode10.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode11_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000B", this.cbMode11.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode12_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000C", this.cbMode12.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode13_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000D", this.cbMode13.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode14_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000E", this.cbMode14.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode15_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "000F", this.cbMode15.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode16_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0010", this.cbMode16.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode17_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0011", this.cbMode17.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode18_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0012", this.cbMode18.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode19_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0013", this.cbMode19.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnMode20_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0014", this.cbMode20.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        #endregion

        #region 延迟时间
        private void btnDelay1_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime1.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "0009", "00" + Convert.ToInt32(this.txtDelayTime1.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay2_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime2.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000A", "00" + Convert.ToInt32(this.txtDelayTime2.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay3_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime3.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000B", "00" + Convert.ToInt32(this.txtDelayTime3.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay4_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime4.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000C", "00" + Convert.ToInt32(this.txtDelayTime4.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay5_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime5.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000D", "00" + Convert.ToInt32(this.txtDelayTime5.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay6_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime6.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000E", "00" + Convert.ToInt32(this.txtDelayTime6.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay7_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime7.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "000F", "00" + Convert.ToInt32(this.txtDelayTime7.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay8_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime8.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0010", "00" + Convert.ToInt32(this.txtDelayTime8.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }
        private void btnDelay9_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime9.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0011", "00" + Convert.ToInt32(this.txtDelayTime9.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay10_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime10.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0012", "00" + Convert.ToInt32(this.txtDelayTime10.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay11_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime11.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0013", "00" + Convert.ToInt32(this.txtDelayTime11.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay12_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime12.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0014", "00" + Convert.ToInt32(this.txtDelayTime12.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay13_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime13.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0015", "00" + Convert.ToInt32(this.txtDelayTime13.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay14_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime14.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0016", "00" + Convert.ToInt32(this.txtDelayTime14.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay15_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime15.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0017", "00" + Convert.ToInt32(this.txtDelayTime15.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay16_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime16.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0018", "00" + Convert.ToInt32(this.txtDelayTime16.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay17_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime17.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "0019", "00" + Convert.ToInt32(this.txtDelayTime17.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay18_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime18.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "001A", "00" + Convert.ToInt32(this.txtDelayTime18.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay19_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime19.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "001B", "00" + Convert.ToInt32(this.txtDelayTime19.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void btnDelay20_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime20.Text.Equals(""))
            {

                modbus.Communication(BaseConfig._deviceAddress, "06", "001C", "00" + Convert.ToInt32(this.txtDelayTime20.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        #endregion

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string[] modeChar = new string[20];//存放工作模式的字符数组
                string[] delayChar = new string[20];//存放ad状态的字符数组       
                //工作模式
                modeChar[0] = cbMode1.SelectedValue.ToString();
                modeChar[1] = cbMode2.SelectedValue.ToString();
                modeChar[2] = cbMode3.SelectedValue.ToString();
                modeChar[3] = cbMode4.SelectedValue.ToString();
                modeChar[4] = cbMode5.SelectedValue.ToString();
                modeChar[5] = cbMode6.SelectedValue.ToString();
                modeChar[6] = cbMode7.SelectedValue.ToString();
                modeChar[7] = cbMode8.SelectedValue.ToString();
                modeChar[8] = cbMode9.SelectedValue.ToString();
                modeChar[9] = cbMode10.SelectedValue.ToString();
                modeChar[10] = cbMode11.SelectedValue.ToString();
                modeChar[11] = cbMode12.SelectedValue.ToString();
                modeChar[12] = cbMode13.SelectedValue.ToString();
                modeChar[13] = cbMode14.SelectedValue.ToString();
                modeChar[14] = cbMode15.SelectedValue.ToString();
                modeChar[15] = cbMode16.SelectedValue.ToString();
                modeChar[16] = cbMode17.SelectedValue.ToString();
                modeChar[17] = cbMode18.SelectedValue.ToString();
                modeChar[18] = cbMode19.SelectedValue.ToString();
                modeChar[19] = cbMode20.SelectedValue.ToString();

                //延迟时间
                delayChar[0] = "00" + Convert.ToInt32(txtDelayTime1.Text).ToString("X2");//十进制转十六进制
                delayChar[1] = "00" + Convert.ToInt32(txtDelayTime2.Text).ToString("X2");
                delayChar[2] = "00" + Convert.ToInt32(txtDelayTime3.Text).ToString("X2");
                delayChar[3] = "00" + Convert.ToInt32(txtDelayTime4.Text).ToString("X2");
                delayChar[4] = "00" + Convert.ToInt32(txtDelayTime5.Text).ToString("X2");
                delayChar[5] = "00" + Convert.ToInt32(txtDelayTime6.Text).ToString("X2");
                delayChar[6] = "00" + Convert.ToInt32(txtDelayTime7.Text).ToString("X2");
                delayChar[7] = "00" + Convert.ToInt32(txtDelayTime8.Text).ToString("X2");
                delayChar[8] = "00" + Convert.ToInt32(txtDelayTime9.Text).ToString("X2");
                delayChar[9] = "00" + Convert.ToInt32(txtDelayTime10.Text).ToString("X2");
                delayChar[10] = "00" + Convert.ToInt32(txtDelayTime11.Text).ToString("X2");
                delayChar[11] = "00" + Convert.ToInt32(txtDelayTime12.Text).ToString("X2");
                delayChar[12] = "00" + Convert.ToInt32(txtDelayTime13.Text).ToString("X2");
                delayChar[13] = "00" + Convert.ToInt32(txtDelayTime14.Text).ToString("X2");
                delayChar[14] = "00" + Convert.ToInt32(txtDelayTime15.Text).ToString("X2");
                delayChar[15] = "00" + Convert.ToInt32(txtDelayTime16.Text).ToString("X2");
                delayChar[16] = "00" + Convert.ToInt32(txtDelayTime17.Text).ToString("X2");
                delayChar[17] = "00" + Convert.ToInt32(txtDelayTime18.Text).ToString("X2");
                delayChar[18] = "00" + Convert.ToInt32(txtDelayTime19.Text).ToString("X2");
                delayChar[19] = "00" + Convert.ToInt32(txtDelayTime20.Text).ToString("X2");

                string statusStr = String.Join("", modeChar) + String.Join("", delayChar);

                modbus.Communication(BaseConfig._deviceAddress, "10", "0001", "0028" + "50" + statusStr);
            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("通讯异常！");
            }
        }
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "03", "0001", "003C");
            if (modbus.RecvDeal() != null)
            {
                string statusStr = modbus.RecvDeal();
                string modeStatus = statusStr.Substring(0, 80);
                string delayStatus = statusStr.Substring(80, 80);
                string[] modeChar = new string[20];//存放电流状态的字符数组
                string[] delayChar = new string[20];//存放ad状态的字符数组
                for (int i = 0; i < modeStatus.Length / 4; i++)
                {
                    modeChar[i] = modeStatus.Substring(i * 4, 4);
                }
                for (int i = 0; i < delayStatus.Length / 4; i++)
                {
                    delayChar[i] = delayStatus.Substring(i * 4, 4);
                }
                cbMode1.SelectedValue = modeChar[0];
                cbMode2.SelectedValue = modeChar[1];
                cbMode3.SelectedValue = modeChar[2];
                cbMode4.SelectedValue = modeChar[3];
                cbMode5.SelectedValue = modeChar[4];
                cbMode6.SelectedValue = modeChar[5];
                cbMode7.SelectedValue = modeChar[6];
                cbMode8.SelectedValue = modeChar[7];
                cbMode9.SelectedValue = modeChar[8];
                cbMode10.SelectedValue = modeChar[9];
                cbMode11.SelectedValue = modeChar[10];
                cbMode12.SelectedValue = modeChar[11];
                cbMode13.SelectedValue = modeChar[12];
                cbMode14.SelectedValue = modeChar[13];
                cbMode15.SelectedValue = modeChar[14];
                cbMode16.SelectedValue = modeChar[15];
                cbMode17.SelectedValue = modeChar[16];
                cbMode18.SelectedValue = modeChar[17];
                cbMode19.SelectedValue = modeChar[18];
                cbMode20.SelectedValue = modeChar[19];

                txtDelayTime1.Text = Int32.Parse(delayChar[0].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime2.Text = Int32.Parse(delayChar[1].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime3.Text = Int32.Parse(delayChar[2].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime4.Text = Int32.Parse(delayChar[3].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime5.Text = Int32.Parse(delayChar[4].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime6.Text = Int32.Parse(delayChar[5].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime7.Text = Int32.Parse(delayChar[6].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime8.Text = Int32.Parse(delayChar[7].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime9.Text = Int32.Parse(delayChar[8].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime10.Text = Int32.Parse(delayChar[9].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime11.Text = Int32.Parse(delayChar[10].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime12.Text = Int32.Parse(delayChar[11].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime13.Text = Int32.Parse(delayChar[12].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime14.Text = Int32.Parse(delayChar[13].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime15.Text = Int32.Parse(delayChar[14].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime16.Text = Int32.Parse(delayChar[15].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime17.Text = Int32.Parse(delayChar[16].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime18.Text = Int32.Parse(delayChar[17].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime19.Text = Int32.Parse(delayChar[18].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtDelayTime20.Text = Int32.Parse(delayChar[19].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();


            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }
        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel8_Enter(object sender, EventArgs e)
        {

            //var list = new[]{
            //    new {
            //        SelectedText = "保持",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "延迟",
            //        SelectedValue="0001"
            //    },
            //    new {
            //        SelectedText = "组合",
            //        SelectedValue="0002"
            //    }
            //};
            ////绑定数据源
            //cbMode1.DataSource = list.Clone();//防止一个改变时，其他也跟着变化
            //cbMode1.DisplayMember = "SelectedText";
            //cbMode1.ValueMember = "SelectedValue";
            //cbMode2.DataSource = list.Clone();
            //cbMode2.DisplayMember = "SelectedText";
            //cbMode2.ValueMember = "SelectedValue";
            //cbMode3.DataSource = list.Clone();
            //cbMode3.DisplayMember = "SelectedText";
            //cbMode3.ValueMember = "SelectedValue";
            //cbMode4.DataSource = list.Clone();
            //cbMode4.DisplayMember = "SelectedText";
            //cbMode4.ValueMember = "SelectedValue";
            //cbMode5.DataSource = list.Clone();
            //cbMode5.DisplayMember = "SelectedText";
            //cbMode5.ValueMember = "SelectedValue";
            //cbMode6.DataSource = list.Clone();
            //cbMode6.DisplayMember = "SelectedText";
            //cbMode6.ValueMember = "SelectedValue";
            //cbMode7.DataSource = list.Clone();
            //cbMode7.DisplayMember = "SelectedText";
            //cbMode7.ValueMember = "SelectedValue";
            //cbMode8.DataSource = list.Clone();
            //cbMode8.DisplayMember = "SelectedText";
            //cbMode8.ValueMember = "SelectedValue";
            //cbMode9.DataSource = list.Clone();
            //cbMode9.DisplayMember = "SelectedText";
            //cbMode9.ValueMember = "SelectedValue";
            //cbMode10.DataSource = list.Clone();
            //cbMode10.DisplayMember = "SelectedText";
            //cbMode10.ValueMember = "SelectedValue";
            //cbMode11.DataSource = list.Clone();
            //cbMode11.DisplayMember = "SelectedText";
            //cbMode11.ValueMember = "SelectedValue";
            //cbMode12.DataSource = list.Clone();
            //cbMode12.DisplayMember = "SelectedText";
            //cbMode12.ValueMember = "SelectedValue";
            //cbMode13.DataSource = list.Clone();
            //cbMode13.DisplayMember = "SelectedText";
            //cbMode13.ValueMember = "SelectedValue";
            //cbMode14.DataSource = list.Clone();
            //cbMode14.DisplayMember = "SelectedText";
            //cbMode14.ValueMember = "SelectedValue";
            //cbMode15.DataSource = list.Clone();
            //cbMode15.DisplayMember = "SelectedText";
            //cbMode15.ValueMember = "SelectedValue";
            //cbMode16.DataSource = list.Clone();
            //cbMode16.DisplayMember = "SelectedText";
            //cbMode16.ValueMember = "SelectedValue";
            //cbMode17.DataSource = list.Clone();
            //cbMode17.DisplayMember = "SelectedText";
            //cbMode17.ValueMember = "SelectedValue";
            //cbMode18.DataSource = list.Clone();
            //cbMode18.DisplayMember = "SelectedText";
            //cbMode18.ValueMember = "SelectedValue";
            //cbMode19.DataSource = list.Clone();
            //cbMode19.DisplayMember = "SelectedText";
            //cbMode19.ValueMember = "SelectedValue";
            //cbMode20.DataSource = list.Clone();
            //cbMode20.DisplayMember = "SelectedText";
            //cbMode20.ValueMember = "SelectedValue";
        }
        #endregion

        #region AI
        #region 设置上限
        private void btnCurrent1_Click(object sender, EventArgs e)
        {
            //System.Threading.Timer myTimer = new System.Threading.Timer(p.Display, "Processing timer event", 2000, 5000);//2秒后第一次调用，每1秒调用一次

            modbus.Communication(BaseConfig._deviceAddress, "06", "0019", this.cbCurrentMax1.SelectedValue.ToString());
        }

        private void btnCurrent2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "001A", this.cbCurrentMax2.SelectedValue.ToString());
        }

        private void btnCurrent3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "001B", this.cbCurrentMax3.SelectedValue.ToString());
        }

        private void btnCurrent4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "001C", this.cbCurrentMax4.SelectedValue.ToString());
        }

        private void btnCurrent5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "001D", this.cbCurrentMax5.SelectedValue.ToString());
        }

        private void btnCurrent6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "001E", this.cbCurrentMax6.SelectedValue.ToString());
        }

        private void btnCurrent7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "001F", this.cbCurrentMax7.SelectedValue.ToString());
        }

        private void btnCurrent8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0020", this.cbCurrentMax8.SelectedValue.ToString().ToString());
        }
        #endregion

        #region 选择采样信号量程
        private void btnADExtent1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0021", this.cbADExtent1.SelectedValue.ToString());
        }

        private void btnADExtent2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0022", this.cbADExtent2.SelectedValue.ToString());
        }

        private void btnADExtent3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0023", this.cbADExtent3.SelectedValue.ToString());
        }

        private void btnADExtent4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0024", this.cbADExtent4.SelectedValue.ToString());
        }

        private void btnADExtent5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0025", this.cbADExtent5.SelectedValue.ToString());
        }

        private void btnADExtent6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0026", this.cbADExtent6.SelectedValue.ToString());
        }

        private void btnADExtent7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0027", this.cbADExtent7.SelectedValue.ToString());
        }

        private void btnADExtent8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0028", this.cbADExtent8.SelectedValue.ToString());
        }
        #endregion

        #region 配置零点（标定AD）
        private void btnMarkAD1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002D", "0001");
        }

        private void btnMarkAD2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002E", "0001");
        }

        private void btnMarkAD3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "002F", "0001");
        }

        private void btnMarkAD4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0030", "0001");
        }

        private void btnMarkAD5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0031", "0001");
        }

        private void btnMarkAD6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0032", "0001");
        }

        private void btnMarkAD7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0033", "0001");
        }

        private void btnMarkAD8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0034", "0001");
        }
        #endregion
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "03", "0019", "0010");

                if (modbus.RecvDeal() != null)
                {
                    string statusStr = modbus.RecvDeal();
                    string currentStatus = statusStr.Substring(0, 32);
                    string adStatus = statusStr.Substring(32, 32);
                    string[] curChar = new string[8];//存放电流状态的字符数组
                    string[] adChar = new string[8];//存放ad状态的字符数组
                    for (int i = 0; i < currentStatus.Length / 4; i++)
                    {
                        curChar[i] = currentStatus.Substring(i * 4, 4);
                    }
                    for (int i = 0; i < adStatus.Length / 4; i++)
                    {
                        adChar[i] = adStatus.Substring(i * 4, 4);
                    }
                    cbCurrentMax1.SelectedValue = curChar[0];
                    cbCurrentMax2.SelectedValue = curChar[1];
                    cbCurrentMax3.SelectedValue = curChar[2];
                    cbCurrentMax4.SelectedValue = curChar[3];
                    cbCurrentMax5.SelectedValue = curChar[4];
                    cbCurrentMax6.SelectedValue = curChar[5];
                    cbCurrentMax7.SelectedValue = curChar[6];
                    cbCurrentMax8.SelectedValue = curChar[7];

                    cbADExtent1.SelectedValue = adChar[0];
                    cbADExtent2.SelectedValue = adChar[1];
                    cbADExtent3.SelectedValue = adChar[2];
                    cbADExtent4.SelectedValue = adChar[3];
                    cbADExtent5.SelectedValue = adChar[4];
                    cbADExtent6.SelectedValue = adChar[5];
                    cbADExtent7.SelectedValue = adChar[6];
                    cbADExtent8.SelectedValue = adChar[7];

                }
                else
                {
                    //MessageBox.Show("通讯异常！");
                }
            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            string[] currentAndADChar = new string[16];//存放开断状态的字符数组
            currentAndADChar[0] = cbCurrentMax1.SelectedValue.ToString();
            currentAndADChar[1] = cbCurrentMax2.SelectedValue.ToString();
            currentAndADChar[2] = cbCurrentMax3.SelectedValue.ToString();
            currentAndADChar[3] = cbCurrentMax4.SelectedValue.ToString();
            currentAndADChar[4] = cbCurrentMax5.SelectedValue.ToString();
            currentAndADChar[5] = cbCurrentMax6.SelectedValue.ToString();
            currentAndADChar[6] = cbCurrentMax7.SelectedValue.ToString();
            currentAndADChar[7] = cbCurrentMax8.SelectedValue.ToString();

            currentAndADChar[8] = cbADExtent1.SelectedValue.ToString();
            currentAndADChar[9] = cbADExtent2.SelectedValue.ToString();
            currentAndADChar[10] = cbADExtent3.SelectedValue.ToString();
            currentAndADChar[11] = cbADExtent4.SelectedValue.ToString();
            currentAndADChar[12] = cbADExtent5.SelectedValue.ToString();
            currentAndADChar[13] = cbADExtent6.SelectedValue.ToString();
            currentAndADChar[14] = cbADExtent7.SelectedValue.ToString();
            currentAndADChar[15] = cbADExtent8.SelectedValue.ToString();

            string statusStr = String.Join("", currentAndADChar);
            modbus.Communication(BaseConfig._deviceAddress, "10", "0019", "0010" + "20" + statusStr);
        }
        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel9_Enter(object sender, EventArgs e)
        {
            //var list = new[]{
            //    new {
            //        SelectedText = "4-20mA",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "0-20mA",
            //        SelectedValue="0001"
            //    }
            //};

            //var list1 = new[]{
            //    new {
            //        SelectedText = "0-2000",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "0-5000",
            //        SelectedValue="0001"
            //    },
            //    new {
            //        SelectedText = "0-10000",
            //        SelectedValue="0002"
            //    }
            //};


            //cbCurrentMax1.DataSource = list.Clone();
            //cbCurrentMax1.DisplayMember = "SelectedText";
            //cbCurrentMax1.ValueMember = "SelectedValue";
            //cbCurrentMax2.DataSource = list.Clone();
            //cbCurrentMax2.DisplayMember = "SelectedText";
            //cbCurrentMax2.ValueMember = "SelectedValue";

            //cbCurrentMax3.DataSource = list.Clone();
            //cbCurrentMax3.DisplayMember = "SelectedText";
            //cbCurrentMax3.ValueMember = "SelectedValue";
            //cbCurrentMax4.DataSource = list.Clone();
            //cbCurrentMax4.DisplayMember = "SelectedText";
            //cbCurrentMax4.ValueMember = "SelectedValue";
            //cbCurrentMax5.DataSource = list.Clone();
            //cbCurrentMax5.DisplayMember = "SelectedText";
            //cbCurrentMax5.ValueMember = "SelectedValue";
            //cbCurrentMax6.DataSource = list.Clone();
            //cbCurrentMax6.DisplayMember = "SelectedText";
            //cbCurrentMax6.ValueMember = "SelectedValue";
            //cbCurrentMax7.DataSource = list.Clone();
            //cbCurrentMax7.DisplayMember = "SelectedText";
            //cbCurrentMax7.ValueMember = "SelectedValue";
            //cbCurrentMax8.DataSource = list.Clone();
            //cbCurrentMax8.DisplayMember = "SelectedText";
            //cbCurrentMax8.ValueMember = "SelectedValue";

            //cbADExtent1.DataSource = list1.Clone();
            //cbADExtent1.DisplayMember = "SelectedText";
            //cbADExtent1.ValueMember = "SelectedValue";
            //cbADExtent2.DataSource = list1.Clone();
            //cbADExtent2.DisplayMember = "SelectedText";
            //cbADExtent2.ValueMember = "SelectedValue";
            //cbADExtent3.DataSource = list1.Clone();
            //cbADExtent3.DisplayMember = "SelectedText";
            //cbADExtent3.ValueMember = "SelectedValue";
            //cbADExtent4.DataSource = list1.Clone();
            //cbADExtent4.DisplayMember = "SelectedText";
            //cbADExtent4.ValueMember = "SelectedValue";
            //cbADExtent5.DataSource = list1.Clone();
            //cbADExtent5.DisplayMember = "SelectedText";
            //cbADExtent5.ValueMember = "SelectedValue";
            //cbADExtent6.DataSource = list1.Clone();
            //cbADExtent6.DisplayMember = "SelectedText";
            //cbADExtent6.ValueMember = "SelectedValue";
            //cbADExtent7.DataSource = list1.Clone();
            //cbADExtent7.DisplayMember = "SelectedText";
            //cbADExtent7.ValueMember = "SelectedValue";
            //cbADExtent8.DataSource = list1.Clone();
            //cbADExtent8.DisplayMember = "SelectedText";
            //cbADExtent8.ValueMember = "SelectedValue";
        }
        #endregion

        #region DI

        #region 读取计数
        private void btnReadCount1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "03", "0029", "0001");
            if (modbus.RecvDeal() != null)
            {
                this.txtCount1.Text = modbus.RecvDeal();
            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }

        }
        private void btnReadCount2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "03", "0030", "0001");
            if (modbus.RecvDeal() != null)
            {
                this.txtCount2.Text = modbus.RecvDeal();
            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }
        private void btnReadCount3_Click(object sender, EventArgs e)
        {

            modbus.Communication(BaseConfig._deviceAddress, "03", "0031", "0001");
            if (modbus.RecvDeal() != null)
            {
                this.txtCount3.Text = modbus.RecvDeal();
            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }

        private void btnReadCount4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "03", "0032", "0001");
            if (modbus.RecvDeal() != null)
            {
                this.txtCount4.Text = modbus.RecvDeal();
            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }
        #endregion


        private void metroPanel10_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "03", "0029", "0004");
                string countStr = modbus.RecvDeal();
                string[] count = new string[4];
                for (int i = 0; i < countStr.Length / 4; i++)
                {
                    count[i] = countStr.Substring(i * 4, 4);
                }
                txtCount1.Text = Int32.Parse(count[0].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtCount2.Text = Int32.Parse(count[1].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtCount3.Text = Int32.Parse(count[2].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                txtCount4.Text = Int32.Parse(count[3].ToString(), System.Globalization.NumberStyles.HexNumber).ToString();


                modbus.Communication(BaseConfig._deviceAddress, "04", "0008", "0004");
                if (modbus.RecvDeal() != null)
                {
                    string statusStr = modbus.RecvDeal();
                    string[] diChar = new string[4];//存放ad状态的字符数组
                    for (int i = 0; i < statusStr.Length / 4; i++)
                    {
                        diChar[i] = statusStr.Substring(i * 4, 4);
                    }
                    if (int.Parse(diChar[0].Substring(3, 1)) == 0)
                    {
                        this.rbOff1.Checked = true;
                    }
                    else
                    {
                        this.rbOn1.Checked = true;
                    }
                    if (int.Parse(diChar[1].Substring(3, 1)) == 0)
                    {
                        this.rbOff2.Checked = true;
                    }
                    else
                    {
                        this.rbOn2.Checked = true;
                    }
                    if (int.Parse(diChar[2].Substring(3, 1)) == 0)
                    {
                        this.rbOff3.Checked = true;
                    }
                    else
                    {
                        this.rbOn3.Checked = true;
                    }
                    if (int.Parse(diChar[3].Substring(3, 1)) == 0)
                    {
                        this.rbOff4.Checked = true;
                    }
                    else
                    {
                        this.rbOn4.Checked = true;
                    }
                }
                else
                {
                    //MessageBox.Show("通讯异常！"); 
                }



            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("通讯异常！");
            }
        }
        #region 写DI状态
        private void button14_Click(object sender, EventArgs e)
        {
            if (this.rbOn1.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "0008", "0001");//闭合
            }
            else if (this.rbOff1.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "0008", "0000");//断开
            }
            else
            {
                MessageBox.Show("请选择DI状态！");
            }
        }


        private void button13_Click(object sender, EventArgs e)
        {
            if (this.rbOn2.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "0009", "0001");//闭合
            }
            else if (this.rbOff2.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "0009", "0000");//断开
            }
            else
            {
                MessageBox.Show("请选择DI状态！");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.rbOn3.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "000A", "0001");//闭合
            }
            else if (this.rbOff3.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "000A", "0000");//断开
            }
            else
            {
                MessageBox.Show("请选择DI状态！");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.rbOn3.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "000B", "0001");//闭合
            }
            else if (this.rbOff3.Checked == true)
            {
                modbus.Communication(BaseConfig._deviceAddress, "04", "000B", "0000");//断开
            }
            else
            {
                MessageBox.Show("请选择DI状态！");
            }
        }
        #endregion
        #endregion

        #region DO
        #region 工作方式
        private void button41_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0001", this.comboBox17.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button40_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0002", this.comboBox16.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0003", this.comboBox15.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0004", this.comboBox14.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0005", this.comboBox13.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0006", this.comboBox12.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button35_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0007", this.comboBox11.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0008", this.comboBox10.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        #endregion

        #region 延迟时间
        private void button33_Click(object sender, EventArgs e)
        {
            if (!this.textBox8.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "0009", "00" + Convert.ToInt32(this.textBox8.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (!this.textBox7.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "000A", "00" + Convert.ToInt32(this.textBox7.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!this.textBox6.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "000B", "00" + Convert.ToInt32(this.textBox6.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (!this.textBox5.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "000C", "00" + Convert.ToInt32(this.textBox5.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!this.textBox4.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "000D", "00" + Convert.ToInt32(this.textBox4.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!this.textBox3.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "000E", "00" + Convert.ToInt32(this.textBox3.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (!this.textBox2.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "000F", "00" + Convert.ToInt32(this.textBox2.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "0010", "00" + Convert.ToInt32(this.textBox1.Text).ToString("X2"));
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }
        #endregion

        #region 组合方式
        private void button25_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0011", this.comboBox9.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0012", this.comboBox8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0013", this.comboBox7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0014", this.comboBox6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0015", this.comboBox5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0016", this.comboBox4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0017", this.comboBox3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0018", this.comboBox2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        #endregion
        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel11_Enter(object sender, EventArgs e)
        {
            //var list = new[]{
            //    new {
            //        SelectedText = "保持",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "延迟",
            //        SelectedValue="0001"
            //    },
            //    new {
            //        SelectedText = "组合",
            //        SelectedValue="0002"
            //    }
            //};

            //comboBox17.DataSource = list.Clone();
            //comboBox17.DisplayMember = "SelectedText";
            //comboBox17.ValueMember = "SelectedValue";
            //comboBox16.DataSource = list.Clone();
            //comboBox16.DisplayMember = "SelectedText";
            //comboBox16.ValueMember = "SelectedValue";
            //comboBox15.DataSource = list.Clone();
            //comboBox15.DisplayMember = "SelectedText";
            //comboBox15.ValueMember = "SelectedValue";
            //comboBox14.DataSource = list.Clone();
            //comboBox14.DisplayMember = "SelectedText";
            //comboBox14.ValueMember = "SelectedValue";
            //comboBox13.DataSource = list.Clone();
            //comboBox13.DisplayMember = "SelectedText";
            //comboBox13.ValueMember = "SelectedValue";
            //comboBox12.DataSource = list.Clone();
            //comboBox12.DisplayMember = "SelectedText";
            //comboBox12.ValueMember = "SelectedValue";
            //comboBox11.DataSource = list.Clone();
            //comboBox11.DisplayMember = "SelectedText";
            //comboBox11.ValueMember = "SelectedValue";
            //comboBox10.DataSource = list.Clone();
            //comboBox10.DisplayMember = "SelectedText";
            //comboBox10.ValueMember = "SelectedValue";

            //var list1 = new[]{
            //    new {
            //        SelectedText = "与第1路组合端口",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "与第2路组合端口",
            //        SelectedValue="0001"
            //    },
            //    new {
            //        SelectedText = "与第3路组合端口",
            //        SelectedValue="0002"
            //    },
            //    new {
            //        SelectedText = "与第4路组合端口",
            //        SelectedValue="0003"
            //    },
            //    new {
            //        SelectedText = "与第5路组合端口",
            //        SelectedValue="0004"
            //    },
            //    new {
            //        SelectedText = "与第6路组合端口",
            //        SelectedValue="0005"
            //    },
            //    new {
            //        SelectedText = "与第7路组合端口",
            //        SelectedValue="0006"
            //    },

            //    new {
            //        SelectedText = "与第8路组合端口",
            //        SelectedValue="0007"
            //    }
            //};
            //comboBox9.DataSource = list1.Clone();
            //comboBox9.DisplayMember = "SelectedText";
            //comboBox9.ValueMember = "SelectedValue";
            //comboBox8.DataSource = list1.Clone();
            //comboBox8.DisplayMember = "SelectedText";
            //comboBox8.ValueMember = "SelectedValue";
            //comboBox7.DataSource = list1.Clone();
            //comboBox7.DisplayMember = "SelectedText";
            //comboBox7.ValueMember = "SelectedValue";
            //comboBox6.DataSource = list1.Clone();
            //comboBox6.DisplayMember = "SelectedText";
            //comboBox6.ValueMember = "SelectedValue";
            //comboBox5.DataSource = list1.Clone();
            //comboBox5.DisplayMember = "SelectedText";
            //comboBox5.ValueMember = "SelectedValue";
            //comboBox4.DataSource = list1.Clone();
            //comboBox4.DisplayMember = "SelectedText";
            //comboBox4.ValueMember = "SelectedValue";
            //comboBox3.DataSource = list1.Clone();
            //comboBox3.DisplayMember = "SelectedText";
            //comboBox3.ValueMember = "SelectedValue";
            //comboBox2.DataSource = list1.Clone();
            //comboBox2.DisplayMember = "SelectedText";
            //comboBox2.ValueMember = "SelectedValue";
        }
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "03", "0001", "0018");
                if (modbus.RecvDeal() != null)
                {
                    string statusStr = modbus.RecvDeal();
                    string modeStatus = statusStr.Substring(0, 32);
                    string delayStatus = statusStr.Substring(32, 32);
                    string combinationStatus = statusStr.Substring(64, 32);
                    string[] modeChar = new string[8];//存放电流状态的字符数组
                    string[] delayChar = new string[8];//存放ad状态的字符数组
                    string[] combinationChar = new string[8];//存放组合状态的字符数组
                    for (int i = 0; i < modeStatus.Length / 4; i++)
                    {
                        modeChar[i] = modeStatus.Substring(i * 4, 4);
                    }
                    for (int i = 0; i < delayStatus.Length / 4; i++)
                    {
                        delayChar[i] = delayStatus.Substring(i * 4, 4);
                    }
                    for (int i = 0; i < combinationStatus.Length / 4; i++)
                    {
                        combinationChar[i] = combinationStatus.Substring(i * 4, 4);
                    }
                    //绑定工作模式
                    comboBox17.SelectedValue = modeChar[0];
                    comboBox16.SelectedValue = modeChar[1];
                    comboBox15.SelectedValue = modeChar[2];
                    comboBox14.SelectedValue = modeChar[3];
                    comboBox13.SelectedValue = modeChar[4];
                    comboBox12.SelectedValue = modeChar[5];
                    comboBox11.SelectedValue = modeChar[6];
                    comboBox10.SelectedValue = modeChar[7];
                    //cbMode1.Text = modeChar[0];
                    //cbMode2.Text = modeChar[1];
                    //cbMode3.Text = modeChar[2];
                    //cbMode4.Text = modeChar[3];
                    //cbMode5.Text = modeChar[4];
                    //cbMode6.Text = modeChar[5];
                    //cbMode7.Text = modeChar[6];
                    //cbMode8.Text = modeChar[7];
                    //绑定延迟时间
                    //txtDelayTime1.Text = Convert.ToInt32(delayChar[0]).ToString();
                    //txtDelayTime2.Text = Convert.ToInt32(delayChar[1]).ToString();
                    //txtDelayTime3.Text = Convert.ToInt32(delayChar[2]).ToString();
                    //txtDelayTime4.Text = Convert.ToInt32(delayChar[3]).ToString();
                    //txtDelayTime5.Text = Convert.ToInt32(delayChar[4]).ToString();
                    //txtDelayTime6.Text = Convert.ToInt32(delayChar[5]).ToString();
                    //txtDelayTime7.Text = Convert.ToInt32(delayChar[6]).ToString();
                    //textBox8.Text = Convert.ToInt32(delayChar[7]).ToString();
                    textBox8.Text = Convert.ToInt32(delayChar[0]).ToString();
                    textBox7.Text = Convert.ToInt32(delayChar[1]).ToString();
                    textBox6.Text = Convert.ToInt32(delayChar[2]).ToString();
                    textBox5.Text = Convert.ToInt32(delayChar[3]).ToString();
                    textBox4.Text = Convert.ToInt32(delayChar[4]).ToString();
                    textBox3.Text = Convert.ToInt32(delayChar[5]).ToString();
                    textBox2.Text = Convert.ToInt32(delayChar[6]).ToString();
                    textBox1.Text = Convert.ToInt32(delayChar[7]).ToString();
                    //绑定组合方式
                    comboBox9.SelectedValue = combinationChar[0];
                    comboBox8.SelectedValue = combinationChar[1];
                    comboBox7.SelectedValue = combinationChar[2];
                    comboBox6.SelectedValue = combinationChar[3];
                    comboBox5.SelectedValue = combinationChar[4];
                    comboBox4.SelectedValue = combinationChar[5];
                    comboBox3.SelectedValue = combinationChar[6];
                    comboBox2.SelectedValue = combinationChar[7];
                    //cbCombination1.Text = combinationChar[0];
                    //cbCombination2.Text = combinationChar[1];
                    //cbCombination3.Text = combinationChar[2];
                    //cbCombination4.Text = combinationChar[3];
                    //cbCombination5.Text = combinationChar[4];
                    //cbCombination6.Text = combinationChar[5];
                    //cbCombination7.Text = combinationChar[6];
                    //cbCombination8.Text = combinationChar[7];

                }
                else
                {
                    //MessageBox.Show("通讯异常！");
                }
            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("通讯异常！"); 
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string[] modeChar = new string[8];//存放电流状态的字符数组
                string[] delayChar = new string[8];//存放ad状态的字符数组
                string[] combinationChar = new string[8];//存放组合状态的字符数组                
                //工作模式
                modeChar[0] = cbMode1.SelectedValue.ToString();
                modeChar[1] = cbMode2.SelectedValue.ToString();
                modeChar[2] = cbMode3.SelectedValue.ToString();
                modeChar[3] = cbMode4.SelectedValue.ToString();
                modeChar[4] = cbMode5.SelectedValue.ToString();
                modeChar[5] = cbMode6.SelectedValue.ToString();
                modeChar[6] = cbMode7.SelectedValue.ToString();
                modeChar[7] = cbMode8.SelectedValue.ToString();

                //延迟时间
                delayChar[0] = "00" + Convert.ToInt32(txtDelayTime1.Text).ToString("X2");//十进制转十六进制
                delayChar[1] = "00" + Convert.ToInt32(txtDelayTime2.Text).ToString("X2");
                delayChar[2] = "00" + Convert.ToInt32(txtDelayTime3.Text).ToString("X2");
                delayChar[3] = "00" + Convert.ToInt32(txtDelayTime4.Text).ToString("X2");
                delayChar[4] = "00" + Convert.ToInt32(txtDelayTime5.Text).ToString("X2");
                delayChar[5] = "00" + Convert.ToInt32(txtDelayTime6.Text).ToString("X2");
                delayChar[6] = "00" + Convert.ToInt32(txtDelayTime7.Text).ToString("X2");
                delayChar[7] = "00" + Convert.ToInt32(txtDelayTime8.Text).ToString("X2");

                //组合方式
                combinationChar[0] = cbCombination1.SelectedValue.ToString();
                combinationChar[1] = cbCombination2.SelectedValue.ToString();
                combinationChar[2] = cbCombination3.SelectedValue.ToString();
                combinationChar[3] = cbCombination4.SelectedValue.ToString();
                combinationChar[4] = cbCombination5.SelectedValue.ToString();
                combinationChar[5] = cbCombination6.SelectedValue.ToString();
                combinationChar[6] = cbCombination7.SelectedValue.ToString();
                combinationChar[7] = cbCombination8.SelectedValue.ToString();

                string statusStr = String.Join("", modeChar) + String.Join("", delayChar) + String.Join("", combinationChar);

                modbus.Communication(BaseConfig._deviceAddress, "10", "0001", "0018" + "30" + statusStr);


            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("通讯异常！"); 
            }
        }
        #endregion

        #region  读写线圈-2
        private void button51_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0007", this.comboBox18.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button50_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0006", this.comboBox19.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0005", this.comboBox20.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        private void button48_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0004", this.comboBox21.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0003", this.comboBox22.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0002", this.comboBox23.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0001", this.comboBox24.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "05", "0000", this.comboBox25.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button42_Click(object sender, EventArgs e)
        {
            ///获取所有线圈状态
            try
            {
                modbus.Communication(BaseConfig._deviceAddress, "01", "0000", "0008"); if (modbus.RecvDeal() != null)
                {
                    string statusStr = modbus.RecvDeal();
                    string statusStr1 = statusStr.Substring(0, 1);
                    string statusStr2 = statusStr.Substring(1, 1);
                    string status1 = Convert.ToString(Int32.Parse(statusStr1, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制
                    string status2 = Convert.ToString(Int32.Parse(statusStr2, System.Globalization.NumberStyles.HexNumber), 2);//每个十六进制字符串转换为四位二进制

                    string[] coilChar = new string[8];//存放线圈状态的字符数组
                    //判断status1的情况
                    if (status1.Length == 1)
                    {
                        status1 = "000" + status1;
                    }
                    if (status1.Length == 2)
                    {
                        status1 = "00" + status1;
                    }
                    if (status1.Length == 3)
                    {
                        status1 = "0" + status1;
                    }

                    //判断status2的情况
                    if (status2.Length == 1)
                    {
                        status2 = "000" + status2;
                    }
                    if (status2.Length == 2)
                    {
                        status2 = "00" + status2;
                    }
                    if (status2.Length == 3)
                    {
                        status2 = "0" + status2;
                    }

                    string status = status1 + status2;//存放线圈状态的字符串

                    string[] coilStatus = new string[8];
                    for (int i = 0; i < status.Length; i++)
                    {
                        coilChar[i] = status.Substring(i, 1);
                        if (coilChar[i].Equals("1"))
                        {
                            coilChar[i] = "FF";
                        }
                        else
                        {
                            coilChar[i] = "00";
                        }
                    }

                    comboBox25.SelectedValue = coilChar[7] + "00";
                    comboBox24.SelectedValue = coilChar[6] + "00";
                    comboBox23.SelectedValue = coilChar[5] + "00";
                    comboBox22.SelectedValue = coilChar[4] + "00";
                    comboBox21.SelectedValue = coilChar[3] + "00";
                    comboBox20.SelectedValue = coilChar[2] + "00";
                    comboBox19.SelectedValue = coilChar[1] + "00";
                    comboBox18.SelectedValue = coilChar[0] + "00";
                }
                else
                {
                    //MessageBox.Show("通讯异常！"); 
                }
            }
            catch (Exception ex)
            {
                MainFrm frm = new MainFrm();
                MetroMessageBox.Show(frm, ex.ToString(), "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("通讯异常！");
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button43_Click(object sender, EventArgs e)
        {
            string[] onOrOffChar = new string[8];//存放线圈状态的字符数组
            //高低位反过来
            onOrOffChar[7] = cbOnOrOff1.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[6] = cbOnOrOff2.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[5] = cbOnOrOff3.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[4] = cbOnOrOff4.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[3] = cbOnOrOff5.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[2] = cbOnOrOff6.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[1] = cbOnOrOff7.SelectedValue.ToString().Substring(0, 2);
            onOrOffChar[0] = cbOnOrOff8.SelectedValue.ToString().Substring(0, 2);
            for (int i = 0; i < 8; i++)
            {
                if (onOrOffChar[i] == "FF")
                {
                    onOrOffChar[i] = "1";
                }
                else
                {
                    onOrOffChar[i] = "0";
                }
            }
            string str1 = onOrOffChar[0] + onOrOffChar[1] + onOrOffChar[2] + onOrOffChar[3];
            string str2 = onOrOffChar[4] + onOrOffChar[5] + onOrOffChar[6] + onOrOffChar[7];


            string statusStr = string.Format("{0:x}", Convert.ToInt32(str1, 2)) + string.Format("{0:x}", Convert.ToInt32(str2, 2));
            modbus.Communication(BaseConfig._deviceAddress, "0F", "0000", "000801" + statusStr);
        }
        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroPanel12_Enter(object sender, EventArgs e)
        {
            //var list = new[]{
            //    new {
            //        SelectedText = "断开",
            //        SelectedValue="0000"
            //    },
            //    new {
            //        SelectedText = "闭合",
            //        SelectedValue="FF00"
            //    }
            //};
            ////绑定自定义数据源
            //comboBox25.DataSource = list.Clone();//防止一个改变时，其他也跟着变化
            //comboBox25.DisplayMember = "SelectedText";
            //comboBox25.ValueMember = "SelectedValue";
            //comboBox24.DataSource = list.Clone();
            //comboBox24.DisplayMember = "SelectedText";
            //comboBox24.ValueMember = "SelectedValue";
            //comboBox23.DataSource = list.Clone();
            //comboBox23.DisplayMember = "SelectedText";
            //comboBox23.ValueMember = "SelectedValue";
            //comboBox22.DataSource = list.Clone();
            //comboBox22.DisplayMember = "SelectedText";
            //comboBox22.ValueMember = "SelectedValue";
            //comboBox21.DataSource = list.Clone();
            //comboBox21.DisplayMember = "SelectedText";
            //comboBox21.ValueMember = "SelectedValue";
            //comboBox20.DataSource = list.Clone();
            //comboBox20.DisplayMember = "SelectedText";
            //comboBox20.ValueMember = "SelectedValue";
            //comboBox19.DataSource = list.Clone();
            //comboBox19.DisplayMember = "SelectedText";
            //comboBox19.ValueMember = "SelectedValue";
            //comboBox18.DataSource = list.Clone();
            //comboBox18.DisplayMember = "SelectedText";
            //comboBox18.ValueMember = "SelectedValue";
        }

        #endregion

        #region 数据初始化
        /// <summary>
        /// 数据加载初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTabControl2_Enter(object sender, EventArgs e)
        {
            #region 读写线圈初始化数据
            var list = new[]{
                new {
                    SelectedText = "断开",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "闭合",
                    SelectedValue="FF00"
                }
            };
            //绑定自定义数据源
            cbOnOrOff1.DataSource = list.Clone();//防止一个改变时，其他也跟着变化
            cbOnOrOff1.DisplayMember = "SelectedText";
            cbOnOrOff1.ValueMember = "SelectedValue";
            cbOnOrOff2.DataSource = list.Clone();
            cbOnOrOff2.DisplayMember = "SelectedText";
            cbOnOrOff2.ValueMember = "SelectedValue";
            cbOnOrOff3.DataSource = list.Clone();
            cbOnOrOff3.DisplayMember = "SelectedText";
            cbOnOrOff3.ValueMember = "SelectedValue";
            cbOnOrOff4.DataSource = list.Clone();
            cbOnOrOff4.DisplayMember = "SelectedText";
            cbOnOrOff4.ValueMember = "SelectedValue";
            cbOnOrOff5.DataSource = list.Clone();
            cbOnOrOff5.DisplayMember = "SelectedText";
            cbOnOrOff5.ValueMember = "SelectedValue";
            cbOnOrOff6.DataSource = list.Clone();
            cbOnOrOff6.DisplayMember = "SelectedText";
            cbOnOrOff6.ValueMember = "SelectedValue";
            cbOnOrOff7.DataSource = list.Clone();
            cbOnOrOff7.DisplayMember = "SelectedText";
            cbOnOrOff7.ValueMember = "SelectedValue";
            cbOnOrOff8.DataSource = list.Clone();
            cbOnOrOff8.DisplayMember = "SelectedText";
            cbOnOrOff8.ValueMember = "SelectedValue";
            cbOnOrOff9.DataSource = list.Clone();
            cbOnOrOff9.DisplayMember = "SelectedText";
            cbOnOrOff9.ValueMember = "SelectedValue";
            cbOnOrOff10.DataSource = list.Clone();
            cbOnOrOff10.DisplayMember = "SelectedText";
            cbOnOrOff10.ValueMember = "SelectedValue";
            cbOnOrOff11.DataSource = list.Clone();
            cbOnOrOff11.DisplayMember = "SelectedText";
            cbOnOrOff11.ValueMember = "SelectedValue";
            cbOnOrOff12.DataSource = list.Clone();
            cbOnOrOff12.DisplayMember = "SelectedText";
            cbOnOrOff12.ValueMember = "SelectedValue";
            cbOnOrOff13.DataSource = list.Clone();
            cbOnOrOff13.DisplayMember = "SelectedText";
            cbOnOrOff13.ValueMember = "SelectedValue";
            cbOnOrOff14.DataSource = list.Clone();
            cbOnOrOff14.DisplayMember = "SelectedText";
            cbOnOrOff14.ValueMember = "SelectedValue";
            cbOnOrOff15.DataSource = list.Clone();
            cbOnOrOff15.DisplayMember = "SelectedText";
            cbOnOrOff15.ValueMember = "SelectedValue";
            cbOnOrOff16.DataSource = list.Clone();
            cbOnOrOff16.DisplayMember = "SelectedText";
            cbOnOrOff16.ValueMember = "SelectedValue";
            cbOnOrOff17.DataSource = list.Clone();
            cbOnOrOff17.DisplayMember = "SelectedText";
            cbOnOrOff17.ValueMember = "SelectedValue";
            cbOnOrOff18.DataSource = list.Clone();
            cbOnOrOff18.DisplayMember = "SelectedText";
            cbOnOrOff18.ValueMember = "SelectedValue";
            cbOnOrOff19.DataSource = list.Clone();
            cbOnOrOff19.DisplayMember = "SelectedText";
            cbOnOrOff19.ValueMember = "SelectedValue";
            cbOnOrOff20.DataSource = list.Clone();
            cbOnOrOff20.DisplayMember = "SelectedText";
            cbOnOrOff20.ValueMember = "SelectedValue";
            #endregion

            #region 设置组合初始化数据
            var list1 = new[]{
                new {
                    SelectedText = "与第1路组合端口",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "与第2路组合端口",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "与第3路组合端口",
                    SelectedValue="0002"
                },
                new {
                    SelectedText = "与第4路组合端口",
                    SelectedValue="0003"
                },
                new {
                    SelectedText = "与第5路组合端口",
                    SelectedValue="0004"
                },
                new {
                    SelectedText = "与第6路组合端口",
                    SelectedValue="0005"
                },
                new {
                    SelectedText = "与第7路组合端口",
                    SelectedValue="0006"
                },

                new {
                    SelectedText = "与第8路组合端口",
                    SelectedValue="0007"
                },
                 new {
                    SelectedText = "与第9路组合端口",
                    SelectedValue="0008"
                },
                new {
                    SelectedText = "与第10路组合端口",
                    SelectedValue="0009"
                },
                new {
                    SelectedText = "与第11路组合端口",
                    SelectedValue="000A"
                },
                new {
                    SelectedText = "与第12路组合端口",
                    SelectedValue="000B"
                },
                new {
                    SelectedText = "与第13路组合端口",
                    SelectedValue="000C"
                },
                new {
                    SelectedText = "与第14路组合端口",
                    SelectedValue="000D"
                },
                new {
                    SelectedText = "与第15路组合端口",
                    SelectedValue="000E"
                },

                new {
                    SelectedText = "与第16路组合端口",
                    SelectedValue="000F"
                },
                new {
                    SelectedText = "与第17路组合端口",
                    SelectedValue="0010"
                },
                new {
                    SelectedText = "与第18路组合端口",
                    SelectedValue="0011"
                },
                new {
                    SelectedText = "与第19路组合端口",
                    SelectedValue="0012"
                },

                new {
                    SelectedText = "与第20路组合端口",
                    SelectedValue="0013"
                }
            };
            cbCombination1.DataSource = list1.Clone();
            cbCombination1.DisplayMember = "SelectedText";
            cbCombination1.ValueMember = "SelectedValue";
            cbCombination2.DataSource = list1.Clone();
            cbCombination2.DisplayMember = "SelectedText";
            cbCombination2.ValueMember = "SelectedValue";
            cbCombination3.DataSource = list1.Clone();
            cbCombination3.DisplayMember = "SelectedText";
            cbCombination3.ValueMember = "SelectedValue";
            cbCombination4.DataSource = list1.Clone();
            cbCombination4.DisplayMember = "SelectedText";
            cbCombination4.ValueMember = "SelectedValue";
            cbCombination5.DataSource = list1.Clone();
            cbCombination5.DisplayMember = "SelectedText";
            cbCombination5.ValueMember = "SelectedValue";
            cbCombination6.DataSource = list1.Clone();
            cbCombination6.DisplayMember = "SelectedText";
            cbCombination6.ValueMember = "SelectedValue";
            cbCombination7.DataSource = list1.Clone();
            cbCombination7.DisplayMember = "SelectedText";
            cbCombination7.ValueMember = "SelectedValue";
            cbCombination8.DataSource = list1.Clone();
            cbCombination8.DisplayMember = "SelectedText";
            cbCombination8.ValueMember = "SelectedValue";
            cbCombination9.DataSource = list1.Clone();
            cbCombination9.DisplayMember = "SelectedText";
            cbCombination9.ValueMember = "SelectedValue";
            cbCombination10.DataSource = list1.Clone();
            cbCombination10.DisplayMember = "SelectedText";
            cbCombination10.ValueMember = "SelectedValue";
            cbCombination11.DataSource = list1.Clone();
            cbCombination11.DisplayMember = "SelectedText";
            cbCombination11.ValueMember = "SelectedValue";
            cbCombination12.DataSource = list1.Clone();
            cbCombination12.DisplayMember = "SelectedText";
            cbCombination12.ValueMember = "SelectedValue";
            cbCombination13.DataSource = list1.Clone();
            cbCombination13.DisplayMember = "SelectedText";
            cbCombination13.ValueMember = "SelectedValue";
            cbCombination14.DataSource = list1.Clone();
            cbCombination14.DisplayMember = "SelectedText";
            cbCombination14.ValueMember = "SelectedValue";
            cbCombination15.DataSource = list1.Clone();
            cbCombination15.DisplayMember = "SelectedText";
            cbCombination15.ValueMember = "SelectedValue";
            cbCombination16.DataSource = list1.Clone();
            cbCombination16.DisplayMember = "SelectedText";
            cbCombination16.ValueMember = "SelectedValue";
            cbCombination17.DataSource = list1.Clone();
            cbCombination17.DisplayMember = "SelectedText";
            cbCombination17.ValueMember = "SelectedValue";
            cbCombination18.DataSource = list1.Clone();
            cbCombination18.DisplayMember = "SelectedText";
            cbCombination18.ValueMember = "SelectedValue";
            cbCombination19.DataSource = list1.Clone();
            cbCombination19.DisplayMember = "SelectedText";
            cbCombination19.ValueMember = "SelectedValue";
            cbCombination20.DataSource = list1.Clone();
            cbCombination20.DisplayMember = "SelectedText";
            cbCombination20.ValueMember = "SelectedValue";
            #endregion

            #region 设置工作和延迟初始化数据
            var list3 = new[]{
                new {
                    SelectedText = "保持",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "延迟",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "组合",
                    SelectedValue="0002"
                }
            };
            //绑定数据源
            cbMode1.DataSource = list3.Clone();//防止一个改变时，其他也跟着变化
            cbMode1.DisplayMember = "SelectedText";
            cbMode1.ValueMember = "SelectedValue";
            cbMode2.DataSource = list3.Clone();
            cbMode2.DisplayMember = "SelectedText";
            cbMode2.ValueMember = "SelectedValue";
            cbMode3.DataSource = list3.Clone();
            cbMode3.DisplayMember = "SelectedText";
            cbMode3.ValueMember = "SelectedValue";
            cbMode4.DataSource = list3.Clone();
            cbMode4.DisplayMember = "SelectedText";
            cbMode4.ValueMember = "SelectedValue";
            cbMode5.DataSource = list3.Clone();
            cbMode5.DisplayMember = "SelectedText";
            cbMode5.ValueMember = "SelectedValue";
            cbMode6.DataSource = list3.Clone();
            cbMode6.DisplayMember = "SelectedText";
            cbMode6.ValueMember = "SelectedValue";
            cbMode7.DataSource = list3.Clone();
            cbMode7.DisplayMember = "SelectedText";
            cbMode7.ValueMember = "SelectedValue";
            cbMode8.DataSource = list3.Clone();
            cbMode8.DisplayMember = "SelectedText";
            cbMode8.ValueMember = "SelectedValue";
            cbMode9.DataSource = list3.Clone();
            cbMode9.DisplayMember = "SelectedText";
            cbMode9.ValueMember = "SelectedValue";
            cbMode10.DataSource = list3.Clone();
            cbMode10.DisplayMember = "SelectedText";
            cbMode10.ValueMember = "SelectedValue";
            cbMode11.DataSource = list3.Clone();
            cbMode11.DisplayMember = "SelectedText";
            cbMode11.ValueMember = "SelectedValue";
            cbMode12.DataSource = list3.Clone();
            cbMode12.DisplayMember = "SelectedText";
            cbMode12.ValueMember = "SelectedValue";
            cbMode13.DataSource = list3.Clone();
            cbMode13.DisplayMember = "SelectedText";
            cbMode13.ValueMember = "SelectedValue";
            cbMode14.DataSource = list3.Clone();
            cbMode14.DisplayMember = "SelectedText";
            cbMode14.ValueMember = "SelectedValue";
            cbMode15.DataSource = list3.Clone();
            cbMode15.DisplayMember = "SelectedText";
            cbMode15.ValueMember = "SelectedValue";
            cbMode16.DataSource = list3.Clone();
            cbMode16.DisplayMember = "SelectedText";
            cbMode16.ValueMember = "SelectedValue";
            cbMode17.DataSource = list3.Clone();
            cbMode17.DisplayMember = "SelectedText";
            cbMode17.ValueMember = "SelectedValue";
            cbMode18.DataSource = list3.Clone();
            cbMode18.DisplayMember = "SelectedText";
            cbMode18.ValueMember = "SelectedValue";
            cbMode19.DataSource = list3.Clone();
            cbMode19.DisplayMember = "SelectedText";
            cbMode19.ValueMember = "SelectedValue";
            cbMode20.DataSource = list3.Clone();
            cbMode20.DisplayMember = "SelectedText";
            cbMode20.ValueMember = "SelectedValue";
            #endregion

            #region AI初始化数据
            var list4 = new[]{
                new {
                    SelectedText = "4-20mA",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "0-20mA",
                    SelectedValue="0001"
                }
            };

            var list5 = new[]{
                new {
                    SelectedText = "0-2000",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "0-5000",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "0-10000",
                    SelectedValue="0002"
                }
            };


            cbCurrentMax1.DataSource = list4.Clone();
            cbCurrentMax1.DisplayMember = "SelectedText";
            cbCurrentMax1.ValueMember = "SelectedValue";
            cbCurrentMax2.DataSource = list4.Clone();
            cbCurrentMax2.DisplayMember = "SelectedText";
            cbCurrentMax2.ValueMember = "SelectedValue";

            cbCurrentMax3.DataSource = list4.Clone();
            cbCurrentMax3.DisplayMember = "SelectedText";
            cbCurrentMax3.ValueMember = "SelectedValue";
            cbCurrentMax4.DataSource = list4.Clone();
            cbCurrentMax4.DisplayMember = "SelectedText";
            cbCurrentMax4.ValueMember = "SelectedValue";
            cbCurrentMax5.DataSource = list4.Clone();
            cbCurrentMax5.DisplayMember = "SelectedText";
            cbCurrentMax5.ValueMember = "SelectedValue";
            cbCurrentMax6.DataSource = list4.Clone();
            cbCurrentMax6.DisplayMember = "SelectedText";
            cbCurrentMax6.ValueMember = "SelectedValue";
            cbCurrentMax7.DataSource = list4.Clone();
            cbCurrentMax7.DisplayMember = "SelectedText";
            cbCurrentMax7.ValueMember = "SelectedValue";
            cbCurrentMax8.DataSource = list4.Clone();
            cbCurrentMax8.DisplayMember = "SelectedText";
            cbCurrentMax8.ValueMember = "SelectedValue";

            cbADExtent1.DataSource = list5.Clone();
            cbADExtent1.DisplayMember = "SelectedText";
            cbADExtent1.ValueMember = "SelectedValue";
            cbADExtent2.DataSource = list5.Clone();
            cbADExtent2.DisplayMember = "SelectedText";
            cbADExtent2.ValueMember = "SelectedValue";
            cbADExtent3.DataSource = list5.Clone();
            cbADExtent3.DisplayMember = "SelectedText";
            cbADExtent3.ValueMember = "SelectedValue";
            cbADExtent4.DataSource = list5.Clone();
            cbADExtent4.DisplayMember = "SelectedText";
            cbADExtent4.ValueMember = "SelectedValue";
            cbADExtent5.DataSource = list5.Clone();
            cbADExtent5.DisplayMember = "SelectedText";
            cbADExtent5.ValueMember = "SelectedValue";
            cbADExtent6.DataSource = list5.Clone();
            cbADExtent6.DisplayMember = "SelectedText";
            cbADExtent6.ValueMember = "SelectedValue";
            cbADExtent7.DataSource = list5.Clone();
            cbADExtent7.DisplayMember = "SelectedText";
            cbADExtent7.ValueMember = "SelectedValue";
            cbADExtent8.DataSource = list5.Clone();
            cbADExtent8.DisplayMember = "SelectedText";
            cbADExtent8.ValueMember = "SelectedValue";
            #endregion

            #region DO初始化数据
            var list6 = new[]{
                new {
                    SelectedText = "保持",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "延迟",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "组合",
                    SelectedValue="0002"
                }
            };

            comboBox17.DataSource = list6.Clone();
            comboBox17.DisplayMember = "SelectedText";
            comboBox17.ValueMember = "SelectedValue";
            comboBox16.DataSource = list6.Clone();
            comboBox16.DisplayMember = "SelectedText";
            comboBox16.ValueMember = "SelectedValue";
            comboBox15.DataSource = list6.Clone();
            comboBox15.DisplayMember = "SelectedText";
            comboBox15.ValueMember = "SelectedValue";
            comboBox14.DataSource = list6.Clone();
            comboBox14.DisplayMember = "SelectedText";
            comboBox14.ValueMember = "SelectedValue";
            comboBox13.DataSource = list6.Clone();
            comboBox13.DisplayMember = "SelectedText";
            comboBox13.ValueMember = "SelectedValue";
            comboBox12.DataSource = list6.Clone();
            comboBox12.DisplayMember = "SelectedText";
            comboBox12.ValueMember = "SelectedValue";
            comboBox11.DataSource = list6.Clone();
            comboBox11.DisplayMember = "SelectedText";
            comboBox11.ValueMember = "SelectedValue";
            comboBox10.DataSource = list6.Clone();
            comboBox10.DisplayMember = "SelectedText";
            comboBox10.ValueMember = "SelectedValue";

            var list7 = new[]{
                new {
                    SelectedText = "与第1路组合端口",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "与第2路组合端口",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "与第3路组合端口",
                    SelectedValue="0002"
                },
                new {
                    SelectedText = "与第4路组合端口",
                    SelectedValue="0003"
                },
                new {
                    SelectedText = "与第5路组合端口",
                    SelectedValue="0004"
                },
                new {
                    SelectedText = "与第6路组合端口",
                    SelectedValue="0005"
                },
                new {
                    SelectedText = "与第7路组合端口",
                    SelectedValue="0006"
                },

                new {
                    SelectedText = "与第8路组合端口",
                    SelectedValue="0007"
                }
            };
            comboBox9.DataSource = list7.Clone();
            comboBox9.DisplayMember = "SelectedText";
            comboBox9.ValueMember = "SelectedValue";
            comboBox8.DataSource = list7.Clone();
            comboBox8.DisplayMember = "SelectedText";
            comboBox8.ValueMember = "SelectedValue";
            comboBox7.DataSource = list7.Clone();
            comboBox7.DisplayMember = "SelectedText";
            comboBox7.ValueMember = "SelectedValue";
            comboBox6.DataSource = list7.Clone();
            comboBox6.DisplayMember = "SelectedText";
            comboBox6.ValueMember = "SelectedValue";
            comboBox5.DataSource = list7.Clone();
            comboBox5.DisplayMember = "SelectedText";
            comboBox5.ValueMember = "SelectedValue";
            comboBox4.DataSource = list7.Clone();
            comboBox4.DisplayMember = "SelectedText";
            comboBox4.ValueMember = "SelectedValue";
            comboBox3.DataSource = list7.Clone();
            comboBox3.DisplayMember = "SelectedText";
            comboBox3.ValueMember = "SelectedValue";
            comboBox2.DataSource = list7.Clone();
            comboBox2.DisplayMember = "SelectedText";
            comboBox2.ValueMember = "SelectedValue";
            #endregion

            #region 读写线圈-2初始化数据
            var list8 = new[]{
                new {
                    SelectedText = "断开",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "闭合",
                    SelectedValue="FF00"
                }
            };
            //绑定自定义数据源
            comboBox25.DataSource = list8.Clone();//防止一个改变时，其他也跟着变化
            comboBox25.DisplayMember = "SelectedText";
            comboBox25.ValueMember = "SelectedValue";
            comboBox24.DataSource = list8.Clone();
            comboBox24.DisplayMember = "SelectedText";
            comboBox24.ValueMember = "SelectedValue";
            comboBox23.DataSource = list8.Clone();
            comboBox23.DisplayMember = "SelectedText";
            comboBox23.ValueMember = "SelectedValue";
            comboBox22.DataSource = list8.Clone();
            comboBox22.DisplayMember = "SelectedText";
            comboBox22.ValueMember = "SelectedValue";
            comboBox21.DataSource = list8.Clone();
            comboBox21.DisplayMember = "SelectedText";
            comboBox21.ValueMember = "SelectedValue";
            comboBox20.DataSource = list8.Clone();
            comboBox20.DisplayMember = "SelectedText";
            comboBox20.ValueMember = "SelectedValue";
            comboBox19.DataSource = list8.Clone();
            comboBox19.DisplayMember = "SelectedText";
            comboBox19.ValueMember = "SelectedValue";
            comboBox18.DataSource = list8.Clone();
            comboBox18.DisplayMember = "SelectedText";
            comboBox18.ValueMember = "SelectedValue";
            #endregion
        }
        #endregion

        #region SRC公共设置
        /// <summary>
        /// 设置装置地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BaseConfig._deviceAddress = this.comboBox1.Text;
        }
        /// <summary>
        /// 返回数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            txtCmd.Text = BaseConfig.cmds;//显示发送指令
            if (BaseConfig._recvData != null)
            {
                this.lstReceiveData.Items.Add(BaseConfig._recvData);
            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }
        /// <summary>
        /// 清空返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.lstReceiveData.Items.Clear();
        }










        #endregion


    }
}
