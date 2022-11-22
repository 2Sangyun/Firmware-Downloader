using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firmware_Downloader
{

    public partial class Form1 : Form
    {
        private void btn_open_Click(object sender, EventArgs e)
        {
            //txt_debug.Text += cmb_port.Text;
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = cmb_port.Text;
                serialPort1.BaudRate = int.Parse(cmb_baud_rate.Text);
                serialPort1.DataBits = (int)(cmb_data.Text[0] - '0');
                serialPort1.Parity = (Parity)cmb_parity.SelectedIndex;
                serialPort1.Handshake = Handshake.None;
                serialPort1.StopBits = StopBits.One;

                try
                {
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    //txt_debug.Text += "연결 되었습니다.";

                    btn_open.Enabled = false;
                    btn_close.Enabled = true;
                    btn_device_connect.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                //txt_debug.Text += "끊어졌습니다.";

                btn_open.Enabled = true;
                btn_close.Enabled = false;
                btn_device_connect.Enabled = false;
            }
        }
    }
}
