using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ModbusDebugTool.Core;
using IWshRuntimeLibrary;
using System.IO;
namespace ModbusDebugTool
{
    public partial class DeviceDebugTool : DevComponents.DotNetBar.Office2007Form
    {
        public DeviceDebugTool()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void DeviceDebugTool_Load(object sender, EventArgs e)
        {
            this.dockContainerItem1.Text = "&基本设置";
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString();
            if (BaseConfig._communicationMethod == 0)
            {
                this.toolStripStatusLabel3.Text = "参数配置信息(" + BaseConfig._ip + "  " + BaseConfig._port + ")";
                this.toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            }
            if (BaseConfig._communicationMethod == 1)
            {
                this.toolStripStatusLabel3.Text = "参数配置信息(" + BaseConfig._serialName + "  " + BaseConfig._baudRate + ")";
                this.toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            }
            else
            {
                this.toolStripStatusLabel3.Text = "参数配置信息" + "(" + "通讯异常" + ")";
                this.toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            }


            #region 创建桌面快捷方式并开机启动的方法

            //获取当前系统用户启动目录
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            //获取当前系统用户桌面目录
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            FileInfo fileStartup = new FileInfo(startupPath + "\\ModbusDebugTool.exe.lnk");
            FileInfo fileDesktop = new FileInfo(desktopPath + "\\ModbusDebugTool.exe.lnk");

            if (!fileDesktop.Exists)
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(
                      Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
                       "\\" + "ModbusDebugTool.exe.lnk"
                       );
                shortcut.TargetPath = Application.StartupPath + "\\" + "ModbusDebugTool.exe";//启动更新程序★
                shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                shortcut.WindowStyle = 1;
                shortcut.Description = "设备调试工具";
                shortcut.IconLocation = Application.ExecutablePath;
                shortcut.Save();
            }

            if (!fileStartup.Exists)
            {
                //获取可执行文件快捷方式的全部路径
                string exeDir = desktopPath + "\\ModbusDebugTool.exe.lnk";
                //把程序快捷方式复制到启动目录
                System.IO.File.Copy(exeDir, startupPath + "\\ModbusDebugTool.exe.lnk", true);
            }
            #endregion

        }
        /// <summary>
        /// CO2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem5_Click(object sender, EventArgs e)
        {

            CO2 cO2 = new CO2();
            cO2.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            cO2.Parent = this.panel3; // 子窗体的父容器
            cO2.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            cO2.Dock = DockStyle.Fill; // 填充
            cO2.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(cO2);
        }
        /// <summary>
        /// 读线圈
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem10_Click(object sender, EventArgs e)
        {
            ReadAndWriteCoilStatus readAndWriteCoilStatus = new ReadAndWriteCoilStatus();
            readAndWriteCoilStatus.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            readAndWriteCoilStatus.Parent = this.panel3; // 子窗体的父容器
            readAndWriteCoilStatus.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            readAndWriteCoilStatus.Dock = DockStyle.Fill; // 填充
            readAndWriteCoilStatus.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(readAndWriteCoilStatus);//加载控件
        }

        /// <summary>
        /// 设置工作模式和延迟时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem11_Click(object sender, EventArgs e)
        {
            SRC0001 sRC0001 = new SRC0001();
            sRC0001.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRC0001.Parent = this.panel3; // 子窗体的父容器
            sRC0001.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRC0001.Dock = DockStyle.Fill; // 填充
            sRC0001.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(sRC0001);//加载控件
        }
        /// <summary>
        /// DO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem17_Click(object sender, EventArgs e)
        {
            DOManageWindow dO = new DOManageWindow();
            dO.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            dO.Parent = this.panel3; // 子窗体的父容器
            dO.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            dO.Dock = DockStyle.Fill; // 填充
            dO.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(dO);
        }
        /// <summary>
        /// DI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem18_Click(object sender, EventArgs e)
        {
            DIManageWindow dI = new DIManageWindow();
            dI.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            dI.Parent = this.panel3; // 子窗体的父容器
            dI.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            dI.Dock = DockStyle.Fill; // 填充
            dI.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(dI);
        }
        /// <summary>
        /// 读线圈2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem20_Click(object sender, EventArgs e)
        {
            ReadAndWriteCoilStatus0002 readAndWriteCoilStatus0002 = new ReadAndWriteCoilStatus0002();
            readAndWriteCoilStatus0002.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            readAndWriteCoilStatus0002.Parent = this.panel3; // 子窗体的父容器
            readAndWriteCoilStatus0002.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            readAndWriteCoilStatus0002.Dock = DockStyle.Fill; // 填充
            readAndWriteCoilStatus0002.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(readAndWriteCoilStatus0002);//加载控件
        }
        /// <summary>
        /// AI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem19_Click(object sender, EventArgs e)
        {
            AIManageWindow aI = new AIManageWindow();
            aI.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            aI.Parent = this.panel3; // 子窗体的父容器
            aI.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            aI.Dock = DockStyle.Fill; // 填充
            aI.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(aI);
        }
        /// <summary>
        /// 设置组合方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem16_Click_1(object sender, EventArgs e)
        {
            SRC0001Combination sRC0001Combination = new SRC0001Combination();
            sRC0001Combination.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRC0001Combination.Parent = this.panel3; // 子窗体的父容器
            sRC0001Combination.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRC0001Combination.Dock = DockStyle.Fill; // 填充
            sRC0001Combination.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(sRC0001Combination);//加载控件

        }
        /// <summary>
        /// 气象站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem7_Click(object sender, EventArgs e)
        {
            WeatherStation weatherStation = new WeatherStation();
            weatherStation.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            weatherStation.Parent = this.panel3; // 子窗体的父容器
            weatherStation.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            weatherStation.Dock = DockStyle.Fill; // 填充
            weatherStation.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(weatherStation);//加载控件
        }
        /// <summary>
        /// 有毒气体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem6_Click(object sender, EventArgs e)
        {
            PoisonGass poisonGass = new PoisonGass();
            poisonGass.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            poisonGass.Parent = this.panel3; // 子窗体的父容器
            poisonGass.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            poisonGass.Dock = DockStyle.Fill; // 填充
            poisonGass.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(poisonGass);//加载控件
        }
        /// <summary>
        /// 设施农业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem8_Click(object sender, EventArgs e)
        {
            TempHumi tempHumi = new TempHumi();
            tempHumi.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            tempHumi.Parent = this.panel3; // 子窗体的父容器
            tempHumi.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            tempHumi.Dock = DockStyle.Fill; // 填充
            tempHumi.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(tempHumi);//加载控件
        }
        /// <summary>
        /// 4-20mA采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem9_Click(object sender, EventArgs e)
        {
            RTUCollectSensor rTUCollectSensor = new RTUCollectSensor();
            rTUCollectSensor.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            rTUCollectSensor.Parent = this.panel3; // 子窗体的父容器
            rTUCollectSensor.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            rTUCollectSensor.Dock = DockStyle.Fill; // 填充
            rTUCollectSensor.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(rTUCollectSensor);//加载控件
        }
        /// <summary>
        /// LED
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem14_Click(object sender, EventArgs e)
        {
            LED.Led led = new LED.Led();
            led.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            led.Parent = this.panel3; // 子窗体的父容器
            led.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            led.Dock = DockStyle.Fill; // 填充
            led.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(led);//加载控件
        }
        /// <summary>
        /// 手动测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem12_Click(object sender, EventArgs e)
        {
            HandTest handTest = new HandTest();
            handTest.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            handTest.Parent = this.panel3; // 子窗体的父容器
            handTest.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            handTest.Dock = DockStyle.Fill; // 填充
            handTest.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(handTest);//加载控件
        }
        /// <summary>
        /// 通讯设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            BaseSet baseSet = new BaseSet();
            baseSet.TopLevel = true; // 这一步最重要, 去除子窗体的顶级窗体设置
            //baseSet.Parent = this.panel3; // 子窗体的父容器
            //baseSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            //baseSet.Dock = DockStyle.Fill; // 填充

            baseSet.ShowDialog();
            //this.panel3.Controls.Clear();//清理控件
            //this.panel3.Controls.Add(baseSet);//加载控件
        }
        /// <summary>
        /// TTS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem15_Click(object sender, EventArgs e)
        {
            TTS.Tts tts = new TTS.Tts();
            tts.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            tts.Parent = this.panel3; // 子窗体的父容器
            tts.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            tts.Dock = DockStyle.Fill; // 填充
            tts.Show();
            this.panel3.Controls.Clear();//清理控件
            this.panel3.Controls.Add(tts);//加载控件
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BaseConfig._recvData != null)
            {
                this.lstReceiveData.Items.Add(BaseConfig._recvData);
            }
            else
            {
                //MessageBox.Show("通讯异常！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lstReceiveData.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseConfig._deviceAddress = this.cbDeviceAddress.SelectedItem.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString();
            if (BaseConfig._communicationMethod == 0)
            {
                this.toolStripStatusLabel3.Text = "参数配置信息(" + BaseConfig._ip + "  " + BaseConfig._port + ")";
                this.toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            }
            else if (BaseConfig._communicationMethod == 1)
            {
                this.toolStripStatusLabel3.Text = "参数配置信息(" + BaseConfig._serialName + "  " + BaseConfig._baudRate + ")";
                this.toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            }
            else
            {
                this.toolStripStatusLabel3.Text = "参数配置信息" + "(" + "通讯异常" + ")";
                this.toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            }
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {

        }

      
 


    }
}
