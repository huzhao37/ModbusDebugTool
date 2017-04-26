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
    public partial class DOManageWindow : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public DOManageWindow()
        {
            InitializeComponent();
           

        }

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
        #endregion

        #region 设置延迟时间
        private void btnDelay1_Click(object sender, EventArgs e)
        {
            if (!this.txtDelayTime1.Text.Equals(""))
            {
                modbus.Communication(BaseConfig._deviceAddress, "06", "0009", "000" + this.txtDelayTime1.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "000A", "000" + this.txtDelayTime2.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "000B", "000" + this.txtDelayTime3.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "000C", "000" + this.txtDelayTime4.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "000D", "000" + this.txtDelayTime5.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "000E", "000" + this.txtDelayTime6.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "000F", "000" + this.txtDelayTime7.Text);
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

                modbus.Communication(BaseConfig._deviceAddress, "06", "0010", "000" + this.txtDelayTime8.Text);
                BaseConfig._recvData = ModbusProtocol.recv;
            }
            else
            {
                MessageBox.Show("请输入延迟时间！");
            }
        }
        #endregion

        #region 组合方式
        private void btnCombination1_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0011", this.cbCombination1.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination2_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0012", this.cbCombination2.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination3_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0013", this.cbCombination3.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination4_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0014", this.cbCombination4.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination5_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0015", this.cbCombination5.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination6_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0016", this.cbCombination6.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination7_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0017", this.cbCombination7.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }

        private void btnCombination8_Click(object sender, EventArgs e)
        {
            modbus.Communication(BaseConfig._deviceAddress, "06", "0018", this.cbCombination8.SelectedValue.ToString());
            BaseConfig._recvData = ModbusProtocol.recv;
        }
        #endregion

        private void DOManageWindow_Load(object sender, EventArgs e)
        {

            var list = new[]{ 
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

            cbMode1.DataSource = list.Clone();
            cbMode1.DisplayMember = "SelectedText";
            cbMode1.ValueMember = "SelectedValue";
            cbMode2.DataSource = list.Clone();
            cbMode2.DisplayMember = "SelectedText";
            cbMode2.ValueMember = "SelectedValue";
            cbMode3.DataSource = list.Clone();
            cbMode3.DisplayMember = "SelectedText";
            cbMode3.ValueMember = "SelectedValue";
            cbMode4.DataSource = list.Clone();
            cbMode4.DisplayMember = "SelectedText";
            cbMode4.ValueMember = "SelectedValue";
            cbMode5.DataSource = list.Clone();
            cbMode5.DisplayMember = "SelectedText";
            cbMode5.ValueMember = "SelectedValue";
            cbMode6.DataSource = list.Clone();
            cbMode6.DisplayMember = "SelectedText";
            cbMode6.ValueMember = "SelectedValue";
            cbMode7.DataSource = list.Clone();
            cbMode7.DisplayMember = "SelectedText";
            cbMode7.ValueMember = "SelectedValue";
            cbMode8.DataSource = list.Clone();
            cbMode8.DisplayMember = "SelectedText";
            cbMode8.ValueMember = "SelectedValue";

            var list1 = new[]{ 
                new {
                    SelectedText = "与第1路组合端口",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "与第2路组合端口",
                    SelectedValue="0002"
                },
                new {
                    SelectedText = "与第3路组合端口",
                    SelectedValue="0003"
                },
                new {
                    SelectedText = "与第4路组合端口",
                    SelectedValue="0004"
                },
                new {
                    SelectedText = "与第5路组合端口",
                    SelectedValue="0005"
                },
                new {
                    SelectedText = "与第6路组合端口",
                    SelectedValue="0006"
                },
                new {
                    SelectedText = "与第7路组合端口",
                    SelectedValue="0007"
                },

                new {
                    SelectedText = "与第8路组合端口",
                    SelectedValue="0008"
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


        }

        private void btnSave_Click(object sender, EventArgs e)
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
            catch (Exception ex) { 
                //MessageBox.Show("通讯异常！"); 
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
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
                    cbMode1.SelectedValue = modeChar[0];
                    cbMode2.SelectedValue = modeChar[1];
                    cbMode3.SelectedValue = modeChar[2];
                    cbMode4.SelectedValue = modeChar[3];
                    cbMode5.SelectedValue = modeChar[4];
                    cbMode6.SelectedValue = modeChar[5];
                    cbMode7.SelectedValue = modeChar[6];
                    cbMode8.SelectedValue = modeChar[7];
                    //绑定延迟时间
                    txtDelayTime1.Text = Convert.ToInt32(delayChar[0]).ToString();
                    txtDelayTime2.Text = Convert.ToInt32(delayChar[1]).ToString();
                    txtDelayTime3.Text = Convert.ToInt32(delayChar[2]).ToString();
                    txtDelayTime4.Text = Convert.ToInt32(delayChar[3]).ToString();
                    txtDelayTime5.Text = Convert.ToInt32(delayChar[4]).ToString();
                    txtDelayTime6.Text = Convert.ToInt32(delayChar[5]).ToString();
                    txtDelayTime7.Text = Convert.ToInt32(delayChar[6]).ToString();
                    txtDelayTime8.Text = Convert.ToInt32(delayChar[7]).ToString();
                    //绑定组合方式
                    cbCombination1.SelectedValue = combinationChar[0];
                    cbCombination2.SelectedValue = combinationChar[1];
                    cbCombination3.SelectedValue = combinationChar[2];
                    cbCombination4.SelectedValue = combinationChar[3];
                    cbCombination5.SelectedValue = combinationChar[4];
                    cbCombination6.SelectedValue = combinationChar[5];
                    cbCombination7.SelectedValue = combinationChar[6];
                    cbCombination8.SelectedValue = combinationChar[7];

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
