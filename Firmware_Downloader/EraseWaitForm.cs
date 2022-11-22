using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Firmware_Downloader
{
    public partial class EraseWaitForm : Form
    {
        public string[] waitText =
        {
            "Erase 진행 중 입니다.",
            "Erase 진행 중 입니다..",
            "Erase 진행 중 입니다...",
        };

        public int waitTextIdx = 0;

        public System.Threading.Timer waitTimer;

        public EraseWaitForm()
        {
            InitializeComponent();
            
        }

        private void EraseWaitForm_Load(object sender, EventArgs e)
        {
            waitTimer = new System.Threading.Timer(new TimerCallback(MyCallBack), null, 0, 500);
        }

        private void EraseWaitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerClose();
        }

        public void TimerClose()
        {
            waitTimer.Dispose();
        }

        public void MyCallBack(object o)
        {
            waitTextIdx += 1;
            waitTextIdx %= 3;

            Invoke(new Action(() => { 
                lbl_wait.Text = waitText[waitTextIdx]; 
            }));

            /*lbl_wait.Invoke((MethodInvoker)delegate ()
            {
                lbl_wait.Text = waitText[waitTextIdx];
            });*/
        }

    }
}
