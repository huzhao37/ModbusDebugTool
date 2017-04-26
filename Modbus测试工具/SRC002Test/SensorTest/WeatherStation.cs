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
    public partial class WeatherStation : DevComponents.DotNetBar.Office2007Form
    {
        ModbusProtocol modbus = new ModbusProtocol();
        public WeatherStation()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0008", "0001");
                this.txtTemp.Text = modbus.RecvDeal();//温度

                modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "000E", "0001");
                this.txtHumity.Text = modbus.RecvDeal();//湿度

                modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0001", "0001");
                this.txtAirPress.Text = modbus.RecvDeal();//气压

                modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "0000", "0001");
                this.txtWinSpeed.Text = modbus.RecvDeal();//风速

                modbus.Communication(Convert.ToInt32(this.txtPreDeviceAddress.Text).ToString("X2"), "03", "000D", "0001");
                this.txtWindirection.Text = modbus.RecvDeal();//风向
            }
            catch (Exception ex)
            {
                

            }
           

        }

        private void WeatherStation_Load(object sender, EventArgs e)
        {
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
    }
}
