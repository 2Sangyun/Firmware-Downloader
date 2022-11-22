using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firmware_Downloader
{
    

    public partial class Form1 : Form
    {
        int time = 5000;
        int ElapsedTime = 0;

        private void ConnectTimerStart()
        {
            time = 3000;
            ElapsedTime = 0;
            tim_Connect.Interval = 10;
            tim_Connect.Start();
        }

        private void ConnectTimerTick(object sender, EventArgs e)
        {
            ElapsedTime += 10;

            if(IsConnect == true)
            {
                tim_Connect.Stop();
            }

            if(time <= ElapsedTime)
            {
                tim_Connect.Stop();

                if (UsartBootThread.ThreadState == System.Threading.ThreadState.Running)
                {
                    UsartBootThread.Abort();
                }
                if (GetVersionThread.ThreadState == System.Threading.ThreadState.Running)
                {
                    GetVersionThread.Abort();
                }
                if (GetIdThread.ThreadState == System.Threading.ThreadState.Running)
                {
                    GetIdThread.Abort();
                }

                IsConnect = false;

                MessageBox.Show("Failed To Connect(TIMER)");
            }
            
        }

    }
}
