using NewLife.Net;
using ModbusDebugTool.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ModbusDebugTool
{
    public partial class CO2 : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();

        public CO2()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {

            int index = this.cbFunction.SelectedIndex;
            switch (index)
            {
                case 0: if (DialogResult.OK == MessageBox.Show("你确定要用此功能？（慎用！）","警告",MessageBoxButtons.OKCancel))
                    {
                        modbus.Communication("00", "03", "0000", "0001");
                        this.txtPreDeviceAddress.Text = modbus.RecvDeal();
                        break;
                    }
                    else
                    {
                        break;
                    }
                    
                case 1: if (!this.txtPreDeviceAddress.Text.Equals(""))
                    {
                        modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "06", "0000", "00" + Convert.ToInt32(this.txtFolDeviceAddress.Text).ToString("X2"));
                    }
                else
                    {
                        MessageBox.Show("请输入当前设备地址！"); 
                    }
                    break;
                case 2: if (!this.txtPreDeviceAddress.Text.Equals(""))
                    {
                        modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0000", "0001");
                        this.txtPreBaudRate.Text = modbus.RecvDeal();
                    }
                    else { MessageBox.Show("请输入当前设备地址！"); }          
                    break;
                case 3: if (!this.txtPreDeviceAddress.Text.Equals("") && !this.txtPreBaudRate.Text.Equals(""))
                {
                    modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "06", "0001", "00" + Convert.ToInt32(this.txtFolBaudRate.Text).ToString("X2"));
                }
                    
                    else { MessageBox.Show("请输入当前设备地址或波特率！"); }   
                    break;
                case 4: if (!this.txtPreDeviceAddress.Text.Equals(""))
                    {
                        modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "04", "0000", "0001");
                        this.txtCO2Concentration.Text = modbus.RecvDeal();
                    }
                    else
                    {
                        MessageBox.Show("请输入当前设备地址！");
                }
                    break;
                case 5: if (!this.txtPreDeviceAddress.Text.Equals(""))
                    {
                        modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0000", "0002");
                        string baudRateAndAddesss = modbus.RecvDeal();
                        this.txtPreDeviceAddress.Text = Int32.Parse(baudRateAndAddesss.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                        this.txtPreBaudRate.Text = Int32.Parse(baudRateAndAddesss.Substring(4, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                    }else
                    {
                        MessageBox.Show("请输入当前设备地址！");
                    }
                    break;
            }
        }

        private void CO2_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    modbus.Communication("00", "03", "0000", "0001");
            //    this.txtPreDeviceAddress.Text = modbus.RecvDeal();

            //    modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0000", "0001");
            //    this.txtPreBaudRate.Text = modbus.RecvDeal();


            //}
            //catch(Exception ex)
            //{

            //}
            
        }

    }
}
