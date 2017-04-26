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
    public partial class AIManageWindow : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public AIManageWindow()
        {
            InitializeComponent();

        }

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

        private void AIManageWindow_Load(object sender, EventArgs e)
        {
            var list = new[]{ 
                new {
                    SelectedText = "4-20mA",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "0-20mA",
                    SelectedValue="0001"
                }
            };

            var list1 = new[]{ 
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


            cbCurrentMax1.DataSource = list.Clone();
            cbCurrentMax1.DisplayMember = "SelectedText";
            cbCurrentMax1.ValueMember = "SelectedValue";
            cbCurrentMax2.DataSource = list.Clone();
            cbCurrentMax2.DisplayMember = "SelectedText";
            cbCurrentMax2.ValueMember = "SelectedValue";

            cbCurrentMax3.DataSource = list.Clone();
            cbCurrentMax3.DisplayMember = "SelectedText";
            cbCurrentMax3.ValueMember = "SelectedValue";
            cbCurrentMax4.DataSource = list.Clone();
            cbCurrentMax4.DisplayMember = "SelectedText";
            cbCurrentMax4.ValueMember = "SelectedValue";
            cbCurrentMax5.DataSource = list.Clone();
            cbCurrentMax5.DisplayMember = "SelectedText";
            cbCurrentMax5.ValueMember = "SelectedValue";
            cbCurrentMax6.DataSource = list.Clone();
            cbCurrentMax6.DisplayMember = "SelectedText";
            cbCurrentMax6.ValueMember = "SelectedValue";
            cbCurrentMax7.DataSource = list.Clone();
            cbCurrentMax7.DisplayMember = "SelectedText";
            cbCurrentMax7.ValueMember = "SelectedValue";
            cbCurrentMax8.DataSource = list.Clone();
            cbCurrentMax8.DisplayMember = "SelectedText";
            cbCurrentMax8.ValueMember = "SelectedValue";

            cbADExtent1.DataSource = list1.Clone();
            cbADExtent1.DisplayMember = "SelectedText";
            cbADExtent1.ValueMember = "SelectedValue";
            cbADExtent2.DataSource = list1.Clone();
            cbADExtent2.DisplayMember = "SelectedText";
            cbADExtent2.ValueMember = "SelectedValue";
            cbADExtent3.DataSource = list1.Clone();
            cbADExtent3.DisplayMember = "SelectedText";
            cbADExtent3.ValueMember = "SelectedValue";
            cbADExtent4.DataSource = list1.Clone();
            cbADExtent4.DisplayMember = "SelectedText";
            cbADExtent4.ValueMember = "SelectedValue";
            cbADExtent5.DataSource = list1.Clone();
            cbADExtent5.DisplayMember = "SelectedText";
            cbADExtent5.ValueMember = "SelectedValue";
            cbADExtent6.DataSource = list1.Clone();
            cbADExtent6.DisplayMember = "SelectedText";
            cbADExtent6.ValueMember = "SelectedValue";
            cbADExtent7.DataSource = list1.Clone();
            cbADExtent7.DisplayMember = "SelectedText";
            cbADExtent7.ValueMember = "SelectedValue";
            cbADExtent8.DataSource = list1.Clone();
            cbADExtent8.DisplayMember = "SelectedText";
            cbADExtent8.ValueMember = "SelectedValue";

        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnGetAll_Click(object sender, EventArgs e)
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

                //throw;
            }
        }
    }
}
