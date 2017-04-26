using ModbusDebugTool.LED;
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
using SRC0002Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevComponents.UI;

namespace ModbusDebugTool
{
    public partial class Modbus管理工具 :Form
    {
        Sunisoft.IrisSkin.SkinEngine se = null;
        public Modbus管理工具()
        {
            InitializeComponent();
            //se = new Sunisoft.IrisSkin.SkinEngine();
            //se.SkinAllForm = true;//所有窗体均应用此皮肤
            //se.SkinFile = "skin/MP10.ssk";
            this.IsMdiContainer = true;
            this.Text = "Modbus管理工具";
           
       
        }
    
        private void sRC0001ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRCCommonSet sRCCommonSet = new SRCCommonSet();
            sRCCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRCCommonSet.Parent = this.panel3; // 子窗体的父容器
            sRCCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRCCommonSet.Dock = DockStyle.Fill; // 填充
            sRCCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sRCCommonSet);

            //SRC0001 sRC0001 = new SRC0001();
            //sRC0001.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            //sRC0001.Parent = this.panel1; // 子窗体的父容器
            //sRC0001.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            //sRC0001.Dock = DockStyle.Fill; // 填充
            //sRC0001.Show();
            //this.panel1.Controls.Clear();//清理控件
            //this.panel1.Controls.Add(sRC0001);//加载控件
        }



        private void cO2传感器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorCommonSet sensorCommonSet = new SensorCommonSet();
            sensorCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sensorCommonSet.Parent = this.panel3; // 子窗体的父容器
            sensorCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sensorCommonSet.Dock = DockStyle.Fill; // 填充
            sensorCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sensorCommonSet);

            CO2 cO2 = new CO2();
            cO2.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            cO2.Parent = this.panel1; // 子窗体的父容器
            cO2.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            cO2.Dock = DockStyle.Fill; // 填充
            cO2.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(cO2);
        }

        private void dOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOManageWindow dO = new DOManageWindow();
            dO.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            dO.Parent = this.panel1; // 子窗体的父容器
            dO.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            dO.Dock = DockStyle.Fill; // 填充
            dO.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(dO);
        }

        private void dIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIManageWindow dI = new DIManageWindow();
            dI.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            dI.Parent = this.panel1; // 子窗体的父容器
            dI.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            dI.Dock = DockStyle.Fill; // 填充
            dI.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(dI);
        }

        private void aIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AIManageWindow aI = new AIManageWindow();
            aI.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            aI.Parent = this.panel1; // 子窗体的父容器
            aI.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            aI.Dock = DockStyle.Fill; // 填充
            aI.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(aI);
        }

        private void sRC0002ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRCCommonSet sRCCommonSet = new SRCCommonSet();
            sRCCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRCCommonSet.Parent = this.panel3; // 子窗体的父容器
            sRCCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRCCommonSet.Dock = DockStyle.Fill; // 填充
            sRCCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sRCCommonSet);
        }

        private void 空气温湿度传感器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorCommonSet sensorCommonSet = new SensorCommonSet();
            sensorCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sensorCommonSet.Parent = this.panel3; // 子窗体的父容器
            sensorCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sensorCommonSet.Dock = DockStyle.Fill; // 填充
            sensorCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sensorCommonSet);

            TempHumi tempHumi = new TempHumi();
            tempHumi.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            tempHumi.Parent = this.panel1; // 子窗体的父容器
            tempHumi.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            tempHumi.Dock = DockStyle.Fill; // 填充
            tempHumi.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(tempHumi);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
            SRCCommonSet sRCCommonSet = new SRCCommonSet();
            sRCCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRCCommonSet.Parent = this.panel3; // 子窗体的父容器
            sRCCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRCCommonSet.Dock = DockStyle.Fill; // 填充
            sRCCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sRCCommonSet);

            //SRC0001 sRC0001 = new SRC0001();
            ////sRC0001.Opacity = 0;
            //sRC0001.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            //sRC0001.Parent = this.panel1; // 子窗体的父容器
            //sRC0001.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            //sRC0001.Dock = DockStyle.Fill; // 填充
            //sRC0001.Show();
            //this.panel1.Controls.Clear();//清理控件
            //this.panel1.Controls.Add(sRC0001);//加载控件
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SkinClass.AddSkinMenu(更换皮肤ToolStripMenuItem); 
            BaseSet set = new BaseSet();
            set.ShowDialog();
            toolStripStatusLabel1.Text = "当前系统时间：" + DateTime.Now;
        }

        private void 设置组合方式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRCCommonSet sRCCommonSet = new SRCCommonSet();
            sRCCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRCCommonSet.Parent = this.panel3; // 子窗体的父容器
            sRCCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRCCommonSet.Dock = DockStyle.Fill; // 填充
            sRCCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sRCCommonSet);

            SRC0001Combination sRC0001Combination = new SRC0001Combination();
            sRC0001Combination.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRC0001Combination.Parent = this.panel1; // 子窗体的父容器
            sRC0001Combination.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRC0001Combination.Dock = DockStyle.Fill; // 填充
            sRC0001Combination.Show();
            this.panel1.Controls.Clear();//清理控件
            this.panel1.Controls.Add(sRC0001Combination);//加载控件
        }

        private void 读写线圈状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRCCommonSet sRCCommonSet = new SRCCommonSet();
            sRCCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRCCommonSet.Parent = this.panel3; // 子窗体的父容器
            sRCCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRCCommonSet.Dock = DockStyle.Fill; // 填充
            sRCCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sRCCommonSet);

            ReadAndWriteCoilStatus readAndWriteCoilStatus = new ReadAndWriteCoilStatus();
            readAndWriteCoilStatus.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            readAndWriteCoilStatus.Parent = this.panel1; // 子窗体的父容器
            readAndWriteCoilStatus.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            readAndWriteCoilStatus.Dock = DockStyle.Fill; // 填充
            readAndWriteCoilStatus.Show();
            this.panel1.Controls.Clear();//清理控件
            this.panel1.Controls.Add(readAndWriteCoilStatus);//加载控件
        }

        private void 设置工作和延迟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRC0001 sRC0001 = new SRC0001();
            sRC0001.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRC0001.Parent = this.panel1; // 子窗体的父容器
            sRC0001.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRC0001.Dock = DockStyle.Fill; // 填充
            sRC0001.Show();
            this.panel1.Controls.Clear();//清理控件
            this.panel1.Controls.Add(sRC0001);//加载控件
        }

        private void 读写线圈状态ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SRCCommonSet sRCCommonSet = new SRCCommonSet();
            sRCCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sRCCommonSet.Parent = this.panel3; // 子窗体的父容器
            sRCCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sRCCommonSet.Dock = DockStyle.Fill; // 填充
            sRCCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sRCCommonSet);

            ReadAndWriteCoilStatus0002 readAndWriteCoilStatus0002 = new ReadAndWriteCoilStatus0002();
            readAndWriteCoilStatus0002.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            readAndWriteCoilStatus0002.Parent = this.panel1; // 子窗体的父容器
            readAndWriteCoilStatus0002.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            readAndWriteCoilStatus0002.Dock = DockStyle.Fill; // 填充
            readAndWriteCoilStatus0002.Show();
            this.panel1.Controls.Clear();//清理控件
            this.panel1.Controls.Add(readAndWriteCoilStatus0002);//加载控件
        }

        private void 更换皮肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 土壤湿度传感器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorCommonSet sensorCommonSet = new SensorCommonSet();
            sensorCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sensorCommonSet.Parent = this.panel3; // 子窗体的父容器
            sensorCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sensorCommonSet.Dock = DockStyle.Fill; // 填充
            sensorCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sensorCommonSet);

            RTUCollectSensor rtu = new RTUCollectSensor();
            rtu.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            rtu.Parent = this.panel1; // 子窗体的父容器
            rtu.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            rtu.Dock = DockStyle.Fill; // 填充
            rtu.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(rtu);
        }

        private void 有毒气体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorCommonSet sensorCommonSet = new SensorCommonSet();
            sensorCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sensorCommonSet.Parent = this.panel3; // 子窗体的父容器
            sensorCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sensorCommonSet.Dock = DockStyle.Fill; // 填充
            sensorCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sensorCommonSet);

            PoisonGass poi = new PoisonGass();
            poi.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            poi.Parent = this.panel1; // 子窗体的父容器
            poi.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            poi.Dock = DockStyle.Fill; // 填充
            poi.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(poi);
        }

        private void 气象站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorCommonSet sensorCommonSet = new SensorCommonSet();
            sensorCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sensorCommonSet.Parent = this.panel3; // 子窗体的父容器
            sensorCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sensorCommonSet.Dock = DockStyle.Fill; // 填充
            sensorCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sensorCommonSet);

            WeatherStation weather = new WeatherStation();
            weather.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            weather.Parent = this.panel1; // 子窗体的父容器
            weather.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            weather.Dock = DockStyle.Fill; // 填充
            weather.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(weather);
        }

        private void 手动测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorCommonSet sensorCommonSet = new SensorCommonSet();
            sensorCommonSet.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            sensorCommonSet.Parent = this.panel3; // 子窗体的父容器
            sensorCommonSet.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            sensorCommonSet.Dock = DockStyle.Fill; // 填充
            sensorCommonSet.Show();
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(sensorCommonSet);

            HandTest handTest = new HandTest();
            handTest.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            handTest.Parent = this.panel1; // 子窗体的父容器
            handTest.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            handTest.Dock = DockStyle.Fill; // 填充
            handTest.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(handTest);
        }

        private void 圆心LEDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Led led = new Led();
            led.TopLevel = false; // 这一步最重要, 去除子窗体的顶级窗体设置
            led.Parent = this.panel1; // 子窗体的父容器
            led.FormBorderStyle = FormBorderStyle.None; // 去边框标题栏等
            led.Dock = DockStyle.Fill; // 填充
            led.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(led);
        }

  
  



    }
}
