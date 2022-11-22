using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firmware_Downloader
{
    public partial class Form1 : Form
    {
        Queue<byte> rcvBuffer = new Queue<byte>();

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new EventHandler(serialPort1_DataReceived_In_Main_Thread));
            }
            catch { }
        }

        private void serialPort1_DataReceived_In_Main_Thread(object sender, EventArgs e)
        {
            /*int nData = serialPort1.BytesToRead;

            if(nData > 0)
            {
                string received_data = serialPort1.ReadExisting();
                byte[] bytes = Encoding.Default.GetBytes(received_data);
                string hex_string = BitConverter.ToString(bytes).Replace("-", "");

                for (int i = 0; i < hex_string.Length; ++i)
                {
                    if ((i & 1) == 0)
                    {
                        txt_debug.Text += "[";
                    }
                    txt_debug.Text += hex_string[i];
                    if ((i & 1) != 0)
                    {
                        txt_debug.Text += "]";
                    }
                }

                txt_debug.Text += "\r\n";
            }*/

            string received_data = serialPort1.ReadExisting();
            byte[] bytes = Encoding.Default.GetBytes(received_data);

            for(int i = 0; i < bytes.Length; ++i)
            {
                rcvBuffer.Enqueue(bytes[i]);
            }
            //string hex_string = BitConverter.ToString(bytes).Replace("-", "");

            
            /*for (int i = 0; i < hex_string.Length; ++i)
            {
                if ((i & 1) == 0)
                {
                    txt_debug.Text += "[";
                }
                txt_debug.Text += hex_string[i];
                if ((i & 1) != 0)
                {
                    txt_debug.Text += "]";
                }
            }

            txt_debug.Text += "\r\n";*/
        }
    }
}
