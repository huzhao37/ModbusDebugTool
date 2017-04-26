using ModbusDebugTool.Core;
using ModbusDebugTool.Core.TTSProtocal;
using NewLife.Threading;
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

namespace ModbusDebugTool.TTS
{
    public partial class Tts : DevComponents.DotNetBar.Office2007Form
    {
        /// <summary>
        /// send TTS timer.
        /// </summary>
        private TimerX _ttsSendTimer;
        public Tts()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            if (_ttsSendTimer != null)
            {
                _ttsSendTimer.Dispose();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(this.cbTimer.Checked==false)
            {
                SendTts();
            }
            else
            {
                if(!this.txtTime.Value.ToString().IsNullOrWhiteSpace())
                {
                    var sendtime =Convert.ToInt32(this.txtTime.Value);
                    if (_ttsSendTimer == null)
                        //  this._ttsSendTimer = new TimerX(this.SendTts, null, 5000, sendtime * 1000 * 60);
                        _ttsSendTimer = new TimerX(obj => SendTts(), null, 5000, sendtime * 1000 * 60);
                }
            }
        }

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
                            this.lblMessage.Text = "语音合成失败";
                        }
                        else
                        {
                            are.Reset();
                            var playResult = are.WaitOne(10 * 1000, true);
                            if (playResult)
                            {
                                //WsnServerConfig.WriteLog("语音播放成功");
                                this.lblMessage.Text = "语音播放成功";
                            }
                            else
                            {
                                //WsnServerConfig.WriteLog("语音播放失败");
                                this.lblMessage.Text = "语音播放失败";
                            }

                            Thread.Sleep(50);
                        }

                    if (serial.IsOpen)
                        serial.Close();
                }
                catch (Exception ex)
                {
                    this.lblMessage.Text = "通讯异常";
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
                this.lblMessage.Text = "语音发送失败";
            }
        }

       private Dictionary<string, AutoResetEvent> _dicTtsAutoResetEvents = new Dictionary<string, AutoResetEvent>();
    }
}
