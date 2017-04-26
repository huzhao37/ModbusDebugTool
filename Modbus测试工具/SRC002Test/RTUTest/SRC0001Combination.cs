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

namespace ModbusDebugTool
{
    public partial class SRC0001Combination : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public SRC0001Combination()
        {
            InitializeComponent();

        }

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
        #endregion

        private void SRC0001Combination_Load(object sender, EventArgs e)
        {
            var list = new[]{ 
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
                },
                 new {
                    SelectedText = "与第9路组合端口",
                    SelectedValue="0009"
                },
                new {
                    SelectedText = "与第10路组合端口",
                    SelectedValue="000A"
                },
                new {
                    SelectedText = "与第11路组合端口",
                    SelectedValue="000B"
                },
                new {
                    SelectedText = "与第12路组合端口",
                    SelectedValue="000C"
                },
                new {
                    SelectedText = "与第13路组合端口",
                    SelectedValue="000D"
                },
                new {
                    SelectedText = "与第14路组合端口",
                    SelectedValue="000E"
                },
                new {
                    SelectedText = "与第15路组合端口",
                    SelectedValue="000F"
                },

                new {
                    SelectedText = "与第16路组合端口",
                    SelectedValue="0010"
                },
                new {
                    SelectedText = "与第17路组合端口",
                    SelectedValue="0011"
                },
                new {
                    SelectedText = "与第18路组合端口",
                    SelectedValue="0012"
                },
                new {
                    SelectedText = "与第19路组合端口",
                    SelectedValue="0013"
                },

                new {
                    SelectedText = "与第20路组合端口",
                    SelectedValue="0014"
                }
            };
            cbCombination1.DataSource = list.Clone();
            cbCombination1.DisplayMember = "SelectedText";
            cbCombination1.ValueMember = "SelectedValue";
            cbCombination2.DataSource = list.Clone();
            cbCombination2.DisplayMember = "SelectedText";
            cbCombination2.ValueMember = "SelectedValue";
            cbCombination3.DataSource = list.Clone();
            cbCombination3.DisplayMember = "SelectedText";
            cbCombination3.ValueMember = "SelectedValue";
            cbCombination4.DataSource = list.Clone();
            cbCombination4.DisplayMember = "SelectedText";
            cbCombination4.ValueMember = "SelectedValue";
            cbCombination5.DataSource = list.Clone();
            cbCombination5.DisplayMember = "SelectedText";
            cbCombination5.ValueMember = "SelectedValue";
            cbCombination6.DataSource = list.Clone();
            cbCombination6.DisplayMember = "SelectedText";
            cbCombination6.ValueMember = "SelectedValue";
            cbCombination7.DataSource = list.Clone();
            cbCombination7.DisplayMember = "SelectedText";
            cbCombination7.ValueMember = "SelectedValue";
            cbCombination8.DataSource = list.Clone();
            cbCombination8.DisplayMember = "SelectedText";
            cbCombination8.ValueMember = "SelectedValue";
            cbCombination9.DataSource = list.Clone();
            cbCombination9.DisplayMember = "SelectedText";
            cbCombination9.ValueMember = "SelectedValue";
            cbCombination10.DataSource = list.Clone();
            cbCombination10.DisplayMember = "SelectedText";
            cbCombination10.ValueMember = "SelectedValue";
            cbCombination11.DataSource = list.Clone();
            cbCombination11.DisplayMember = "SelectedText";
            cbCombination11.ValueMember = "SelectedValue";
            cbCombination12.DataSource = list.Clone();
            cbCombination12.DisplayMember = "SelectedText";
            cbCombination12.ValueMember = "SelectedValue";
            cbCombination13.DataSource = list.Clone();
            cbCombination13.DisplayMember = "SelectedText";
            cbCombination13.ValueMember = "SelectedValue";
            cbCombination14.DataSource = list.Clone();
            cbCombination14.DisplayMember = "SelectedText";
            cbCombination14.ValueMember = "SelectedValue";
            cbCombination15.DataSource = list.Clone();
            cbCombination15.DisplayMember = "SelectedText";
            cbCombination15.ValueMember = "SelectedValue";
            cbCombination16.DataSource = list.Clone();
            cbCombination16.DisplayMember = "SelectedText";
            cbCombination16.ValueMember = "SelectedValue";
            cbCombination17.DataSource = list.Clone();
            cbCombination17.DisplayMember = "SelectedText";
            cbCombination17.ValueMember = "SelectedValue";
            cbCombination18.DataSource = list.Clone();
            cbCombination18.DisplayMember = "SelectedText";
            cbCombination18.ValueMember = "SelectedValue";
            cbCombination19.DataSource = list.Clone();
            cbCombination19.DisplayMember = "SelectedText";
            cbCombination19.ValueMember = "SelectedValue";
            cbCombination20.DataSource = list.Clone();
            cbCombination20.DisplayMember = "SelectedText";
            cbCombination20.ValueMember = "SelectedValue";



        }

        private void btnSave_Click(object sender, EventArgs e)
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
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
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

                //throw;
            }
        }

    }
}



