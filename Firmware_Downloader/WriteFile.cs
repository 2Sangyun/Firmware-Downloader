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
        Boolean IsErased = false;
        public delegate void DelegatePercent(int a, int b);
        public DelegatePercent delegatePercent;

        Form eraseWaitForm;

        private void btn_write_Click(object sender, EventArgs e)
        {
            EraseThread = new Thread(new ThreadStart(EraseThreadStart));
            WriteThread = new Thread(new ThreadStart(WriteThreadStart));

            IsErased = false;
            
            while(rcvBuffer.Count > 0)
            {
                rcvBuffer.Dequeue();
            }

            EraseThread.Start();

            eraseWaitForm = new EraseWaitForm();
            eraseWaitForm.ShowDialog();

            WriteThread.Start();
            //WriteThread.Join();

            //txt_debug.Text += "write finish";

            //eraseWaitForm.Show();
        }

        private void EraseThreadStart()
        {

            byte[] extendeErase =
            {
                commandSet[(int)CommandType.ExtendedErase, 0],
                commandSet[(int)CommandType.ExtendedErase, 1]
            };

            serialPort1.Write(extendeErase, 0, 1);
            serialPort1.Write(extendeErase, 1, 1);

            Thread.Sleep(300);

            while (rcvBuffer.Count == 0)
            {
                Thread.Sleep(10);
            }

            if (rcvBuffer.Dequeue() == (byte)(0x79))
            {
                //MessageBox.Show("GET ID ACK.");
                //IsConnect = true;
                rcvBuffer.Clear();
            }
            else
            {
                MessageBox.Show("EXTEND ERASE NACK.");
                EraseThread.Abort();
                return;
            }


            // Bank1(0xFFEE) + CheckSum(0x01)
            byte[] specialErase = { 0xFF, 0xFE, 0x01 };

            serialPort1.Write(specialErase, 0, 1);
            serialPort1.Write(specialErase, 1, 1);
            serialPort1.Write(specialErase, 2, 1);

            Thread.Sleep(200);

            while (rcvBuffer.Count == 0)
            {
                Thread.Sleep(10);
            }

            if (rcvBuffer.Dequeue() == (byte)(0x79))
            {
                rcvBuffer.Clear();
                IsErased = true;
            }
            else
            {
                MessageBox.Show("SPECIAL ERASE NACK.");
            }

            Invoke(new Action(() => {
                eraseWaitForm.Close();
            }));
        }


        private void WriteThreadStart()
        {
            EraseThread.Join();

            if (IsErased == false)
            {
                MessageBox.Show("Erased Failed");
                return;
            }

            //MessageBox.Show("Write Start.");

            byte[] writeMemory =
            {
                commandSet[(int)CommandType.WriteMemory, 0],
                commandSet[(int)CommandType.WriteMemory, 1]
            };

            string result = string.Empty;
            int total_count = selectedFile.fileContent.Count;
            int cur_count = -1;


            foreach (string fileLine in selectedFile.fileContent)
            {
                cur_count += 1;

                delegatePercent = new DelegatePercent(ShowPercent);
                Invoke(delegatePercent, new object[] { cur_count, total_count });

                serialPort1.Write(writeMemory, 0, 1);
                serialPort1.Write(writeMemory, 1, 1);

                byte ByteLength = byte.Parse(fileLine.Substring(0, 2), System.Globalization.NumberStyles.HexNumber); // -1
                WriteAddress(fileLine, 4);

                Thread.Sleep(1);

                WriteData(fileLine, ByteLength);
                
                Thread.Sleep(1);

            }

            MessageBox.Show("write succ");
            return;
        }

        private void WriteAddress(string fileLine, int length)
        {
            if (fileLine.Substring(6, 2).Equals("04"))
            {
                selectedFile.baseAddress = fileLine.Substring(8, 4);
            }
            string startAddress = selectedFile.baseAddress + fileLine.Substring(2, 4);
            byte checkSum = 0x00;
            byte[] SendBuffer = new byte[length + 1];


            for (int i = 0; i < length; ++i)
            {
                byte subAddress = Convert.ToByte(startAddress.Substring(2 * i, 2), 16);
                SendBuffer[i] = subAddress;
                checkSum ^= subAddress;
            }

            SendBuffer[length] = checkSum;
            serialPort1.Write(SendBuffer, 0, length + 1);

            /*for (int i = 0; i < length + 1; ++i)
            {
                serialPort1.Write(SendBuffer, i, 1);
                //Thread.Sleep(30);
            }*/

            //Thread.Sleep(100);
        }

        private void WriteData(string fileLine, byte ByteLength)
        {
            int length = (int)(ByteLength);
            byte one = 0x01;
            byte checkSum = (byte)(ByteLength - one);
            byte[] SendBuffer = new byte[length + 2];

            SendBuffer[0] = checkSum;

            for (int i = 1; i <= length; ++i)
            {
                byte subData = Convert.ToByte(fileLine.Substring((8 + (2 * (i - 1))), 2), 16);
                SendBuffer[i] = subData;
                //serialPort1.Write(new byte[] { subData }, 0, 1);
                //result += subData.ToString("X2") + " ";
                checkSum ^= subData;
            }
            SendBuffer[length + 1] = checkSum;
            serialPort1.Write(SendBuffer, 0, length + 2);
            //serialPort1.Write(SendBuffer, 0, (length + 2) / 2);
            //serialPort1.Write(SendBuffer, (length + 2) / 2, length + 2);

            /*for(int i = 0; i < length + 2; ++i)
            {
                serialPort1.Write(SendBuffer, i, 1);
                //Thread.Sleep(30);
            }*/
        }

        private void ShowPercent(int a, int b)
        {
            //txt_debug.Text = a.ToString() + "/" + b.ToString() + "\r\n";
        }
    }
}
