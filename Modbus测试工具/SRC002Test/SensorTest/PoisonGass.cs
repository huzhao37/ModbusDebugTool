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
    public partial class PoisonGass : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public PoisonGass()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {

                modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0065", "0001");
                this.txtCO2Concentration.Text = modbus.RecvDeal();
            }
            catch (Exception ex)
            {

            }
        }

        private void PoisonGass_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    modbus.Communication("00", "03", "0000", "0001");
            //    this.txtPreDeviceAddress.Text = modbus.RecvDeal();

            //    modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0000", "0001");
            //    this.txtPreBaudRate.Text = modbus.RecvDeal();


            //}
            //catch (Exception ex)
            //{

            //}
        }
    }
}
