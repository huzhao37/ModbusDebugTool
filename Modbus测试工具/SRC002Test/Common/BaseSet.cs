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

namespace ModbusDebugTool
{
    public partial class BaseSet : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public BaseSet()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.rbtN.Checked == true)
            {
                BaseConfig._ip = this.txtIP.Text;
                BaseConfig._port = this.txtPort.Value.ToString();
                BaseConfig._baudRate = Convert.ToInt32(this.cbBaudRate.SelectedItem);
                BaseConfig._serialName = this.cbSerialName.SelectedItem.ToString();
                this.Close();
                BaseConfig._communicationMethod = 0;
            }
            else if (this.rbtS.Checked == true)
            {
                BaseConfig._baudRate = Convert.ToInt32(this.cbBaudRate.SelectedItem);
                BaseConfig._serialName = this.cbSerialName.SelectedItem.ToString();
                this.Close();
                BaseConfig._communicationMethod = 1;
            }
            else
            {
                //MessageBox.Show("请选择通信方式！");
                BaseConfig._communicationMethod = 2;
            }
            this.Close();
            DeviceDebugTool tool = new DeviceDebugTool();
            tool.Refresh();
        }

       /// <summary>
        /// esc退出窗体
       /// </summary>
       /// <param name="msg"></param>
       /// <param name="keyData"></param>
       /// <returns></returns>
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) //激活回车键
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;
            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        if(MessageBox.Show("确定要退出么？","信息提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Close();//csc关闭窗体
                        }                        
                        break;
                    case Keys.Enter:
                        MessageBox.Show("设置成功！");
                        break;
                }

            }
            return false;
        }

        private void BaseSet_Load(object sender, EventArgs e)
        {
            this.txtIP.Text = BaseConfig._ip;
            this.txtPort.Value = Convert.ToInt32(BaseConfig._port);
            this.cbBaudRate.SelectedItem = BaseConfig._baudRate;
            this.cbSerialName.SelectedItem = BaseConfig._serialName;
            if (BaseConfig._communicationMethod == 0)
            {
                this.rbtN.Checked = true;
            }
            if (BaseConfig._communicationMethod == 1)
            {
                this.rbtS.Checked = true;
            }
        }


        //private void BaseSet_Load(object sender, EventArgs e)
        //{
        //    Modbus管理工具 modbus = new Modbus管理工具();
        //    modbus.Refresh();
        //}
    }
}
