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
    public partial class RTUCollectSensor : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public RTUCollectSensor()
        {
            InitializeComponent();
        }

        private void RTUCollectSensor_Load(object sender, EventArgs e)
        {
            var list = new[]{ 
                new {
                    SelectedText = "第1路",
                    SelectedValue="0000"
                },
                new {
                    SelectedText = "第2路",
                    SelectedValue="0001"
                },
                new {
                    SelectedText = "第3路",
                    SelectedValue="0002"
                }
                ,
                new {
                    SelectedText = "第4路",
                    SelectedValue="0003"
                
                } ,
                new {
                    SelectedText = "第5路",
                    SelectedValue="0004"
                
                } ,
                new {
                    SelectedText = "第6路",
                    SelectedValue="0005"
                
                },
                new {
                    SelectedText = "第7路",
                    SelectedValue="0006"
                
                },
                new {
                    SelectedText = "第8路",
                    SelectedValue="0007"
                }
            };

            this.cbRegisterAddress.DataSource = list.Clone();
            this.cbRegisterAddress.DisplayMember = "SelectedText";
            this.cbRegisterAddress.ValueMember = "SelectedValue";
       
            //try
            //{
            //    //modbus.Communication("00", "03", "0000", "0001");
            //    //this.txtPreDeviceAddress.Text = modbus.RecvDeal();             
            //    modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0000", "0001");
            //    this.txtPreBaudRate.Text = modbus.RecvDeal();


            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            modbus.Communication(Convert.ToInt32(this.cbDeviceAddress.Text).ToString("X2"), "04", "0000", this.cbRegisterAddress.SelectedValue.ToString());
            this.txtCO2Concentration.Text = modbus.RecvDeal();
        }
    }
}
