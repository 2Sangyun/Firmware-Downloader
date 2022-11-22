using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firmware_Downloader
{
    public partial class Form1 : Form
    {
        Thread UsartBootThread, GetVersionThread, GetIdThread;
        Thread EraseThread, WriteThread;
        object semaphore = new object();
        Boolean IsConnect = false;

        public delegate void DelegateShowDeviceData(Queue<byte> rcv);
        public DelegateShowDeviceData delegateShowDeviceIdData;
        public DelegateShowDeviceData delegateShowBootLoaderVersionData;

        private void btn_device_connect_Click(object sender, EventArgs e)
        {
            UsartBootThread = new Thread(new ThreadStart(UsartBootThreadStart));
            GetVersionThread = new Thread(new ThreadStart(GetVersionThreadStart));
            GetIdThread = new Thread(new ThreadStart(GetIdThreadStart));

            IsConnect = false;

            while(rcvBuffer.Count > 0)
            {
                rcvBuffer.Dequeue();
            }

            ConnectTimerStart();
            UsartBootThread.Start();

            //GetThread.Start();
            //GetThread.Join();

            GetVersionThread.Start();
            //GetVersionThread.Join();

            GetIdThread.Start();
            //GetIdThread.Join();
            

            //serialPort1.Write(getVersion, 0, 2);
            //serialPort1.Write(getVersion, 1, 1);

            
            //serialPort1.Write(getID, 1, 1);

        }

        private void UsartBootThreadStart()
        {
            byte[] buffer = { 0x7F };
            serialPort1.Write(buffer, 0, 1);

            while(rcvBuffer.Count == 0)
            {
                Thread.Sleep(100);
            }

            if (rcvBuffer.Count > 0 && rcvBuffer.Dequeue() == (byte)(0x79))
            {
                //MessageBox.Show("ACK");
                IsConnect = true;
            }
            else
            {
                MessageBox.Show("USART BOOTLOADER NACK.");
            }

            rcvBuffer.Clear();
            
        }

        private void GetVersionThreadStart()
        {
            UsartBootThread.Join();
            
            if(IsConnect == false)
            {
                return;
            }

            byte[] getVersion =
            {
            commandSet[(int)CommandType.GetVersion, 0],
            commandSet[(int)CommandType.GetVersion, 1]
            };

            serialPort1.Write(getVersion, 0, 1);
            serialPort1.Write(getVersion, 1, 1);
            Thread.Sleep(300);

            while (rcvBuffer.Count == 0)
            {
                Thread.Sleep(10);
            }

            if (rcvBuffer.Dequeue() == (byte)(0x79))
            {
                //MessageBox.Show("GET VERSION ACK.");
                //IsConnect = true;
            }
            else
            {
                MessageBox.Show("GET VERSION NACK.");
            }

            delegateShowBootLoaderVersionData = new DelegateShowDeviceData(ShowVersion);
            Invoke(delegateShowBootLoaderVersionData, new Object[] { rcvBuffer });

            /*try
            {
                string ack = string.Empty;
                while (serialPort1.BytesToRead == 0)
                {
                    Thread.Sleep(10);
                }

                ack = serialPort1.ReadExisting();

                if (ack.Equals(string.Empty))
                {
                    MessageBox.Show("GetVersion Failed!");
                }
                else
                {
                    DelegateShowDataInstance = new DelegateShowData(this.ShowData);
                    
            .Invoke(DelegateShowDataInstance, new object[] { txt_bl_version, ConvertData(ack) });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

        }

        private void GetIdThreadStart()
        {
            GetVersionThread.Join();

            if (IsConnect == false)
            {
                return;
            }

            byte[] getID =
            {
                commandSet[(int)CommandType.GetId, 0],
                commandSet[(int)CommandType.GetId, 1]
            };

            serialPort1.Write(getID, 0, 1);
            serialPort1.Write(getID, 1, 1);
            Thread.Sleep(300);

            while (rcvBuffer.Count == 0)
            {
                Thread.Sleep(10);
            }

            if (rcvBuffer.Dequeue() == (byte)(0x79))
            {
                //MessageBox.Show("GET ID ACK.");
                //IsConnect = true;
            }
            else
            {
                MessageBox.Show("GET ID NACK.");
            }

            delegateShowDeviceIdData = new DelegateShowDeviceData(ShowId);
            Invoke(delegateShowDeviceIdData, new Object[] { rcvBuffer });

            /*try
            {
                string ack = string.Empty;

                while (serialPort1.BytesToRead != 5)
                {
                    Thread.Sleep(10);
                }
                ack = serialPort1.ReadExisting();

                if (ack.Equals(string.Empty))
                {
                    MessageBox.Show("Connection Failed!");
                }
                else
                {
                    DelegateShowDataInstance = new DelegateShowData(this.ShowData);
                    Invoke(DelegateShowDataInstance, new Object[] { txt_device_id, ConvertData(ack) });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }


        private void ShowVersion(Queue<byte> rcv)
        {
            string hexString;
            if (rcv.Count != 0)
            {
                hexString = rcv.Dequeue().ToString("X2");
                txt_bl_version.Text = "Ver ";
                txt_bl_version.Text += hexString[0] + "." + hexString[1];
            }
            
            rcv.Clear();
        }

        private void ShowId(Queue<byte> rcv)
        {
            rcv.Dequeue();
            string hexString;
            if (rcv.Count != 0)
            {
                hexString = rcv.Dequeue().ToString("X2") + rcv.Dequeue().ToString("X2");
                txt_device_id.Text = "0x" + hexString.Substring(1, 3);
            }

            rcv.Clear();
        }


        private void ShowData(object sender, string hexString)
        {
            lock (this)
            {
                TextBox txtBox = sender as TextBox;

                if (txtBox.Equals(txt_device_id))
                {
                    txtBox.Text = "0x";
                    txtBox.Text += hexString.Substring(5, 3);
                }
                else if (txtBox.Equals(txt_bl_version))
                {
                    txtBox.Text = "Ver ";
                    txtBox.Text += hexString[2] + "." + hexString[3];

                }
                else
                {
                    ;
                }
            }
            /*
            lock (this)
            {
                for (int i = 0; i < hexString.Length; ++i)
                {
                    if ((i & 1) == 0)
                    {
                        txt_debug.Text += "{";
                    }
                    txt_debug.Text += hexString[i];
                    if ((i & 1) != 0)
                    {
                        txt_debug.Text += "}";
                    }
                }
            }*/
        }

        private string ConvertData(string rcvData)
        {
            byte[] bytes = Encoding.Default.GetBytes(rcvData);
            string hexString = BitConverter.ToString(bytes).Replace("-", "");

            return hexString;
        }
    }
}
