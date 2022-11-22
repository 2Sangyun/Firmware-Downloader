using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Firmware_Downloader
{
    public partial class Form1 : Form
    {
        /*private Object thisLock = new Object();
        const char _02 = (char)0x02;
        const char _0D = (char)0x0D;
        const char _0A = (char)0x0A;
        string inStream = "";*/

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmb_port.Items.AddRange(ports);
            cmb_baud_rate.Items.AddRange(baud_rate);
            cmb_data.Items.AddRange(data);
            cmb_parity.Items.AddRange(parity);
            cmb_stop_bits.Items.AddRange(stop_bits);
            cmb_flow_control.Items.AddRange(flow_control);

            cmb_port.SelectedIndex = 0;
            cmb_baud_rate.SelectedIndex = 6;
            cmb_data.SelectedIndex = 1;
            cmb_parity.SelectedIndex = 2;
            cmb_stop_bits.SelectedIndex = 0;
            cmb_flow_control.SelectedIndex = 3;

            for(int i = 0; i < 16; ++i)
            {
                lvwFileData.Columns.Add("Column" + i.ToString(), i.ToString("X"));
            }
            lvwFileData.Columns.Add("Ascii", "Ascii");
            lvwFileData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                UsartBootThread.Abort();
                GetVersionThread.Abort();
                GetIdThread.Abort();
                serialPort1.Close();
            }
        }

        private void tim_Connect_Tick(object sender, EventArgs e)
        {

        }

    }
}
