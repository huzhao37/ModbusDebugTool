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

namespace ModbusDebugTool
{
    public partial class DIManageWindow : DevComponents.DotNetBar.Office2007Form
    {

        ModbusProtocol modbus = new ModbusProtocol();
        public DIManageWindow()
        {
            InitializeComponent();

        }
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

        #region 写DI状态
        private void btnReadStatus1_Click(object sender, EventArgs e)
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

        private void btnReadStatus2_Click(object sender, EventArgs e)
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

        private void btnReadStatus3_Click(object sender, EventArgs e)
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

        private void btnReadStatus4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void DIManageWindow_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] count = new string[4];
                //DI状态
                count[0] = "00" + Convert.ToInt32(txtCount1.Text).ToString("X2");
                count[1] = "00" + Convert.ToInt32(txtCount2.Text).ToString("X2");
                count[2] = "00" + Convert.ToInt32(txtCount3.Text).ToString("X2");
                count[3] = "00" + Convert.ToInt32(txtCount4.Text).ToString("X2");
                string statusStr = String.Join("", count);
                modbus.Communication(BaseConfig._deviceAddress, "10", "0001", "0004" + "08" + statusStr);
            }
            catch (Exception ex) {
                //MessageBox.Show("通讯异常！");
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
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
                //MessageBox.Show("通讯异常！");
            }
        }
    }
}
