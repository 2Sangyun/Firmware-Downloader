using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firmware_Downloader
{
    public class SelectedFile : Form
    {
        public List<string> fileContent = new List<string>();
        public List<string[]> decomposedFileContent = new List<string[]>();
        public string baseAddress = null;
    }

    public partial class Form1 : Form
    {
        public delegate void DelegateAddFileData();
        public DelegateAddFileData delegateAddFileData;

        SelectedFile selectedFile = new SelectedFile();

        private void txt_file_name_MouseDown(object sender, MouseEventArgs e)
        {
            openFileToolStripMenuItem_Click(sender, e);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread readThread;
            string file_name, file_path;
            DialogResult dialogResult = ofd_file_explorer.ShowDialog();


            if (dialogResult == DialogResult.OK)
            {
                file_name = ofd_file_explorer.SafeFileName;
                file_path = ofd_file_explorer.FileName.Replace(file_name, "");

                txt_file_name.Text += file_name;
                ofd_file_explorer.InitialDirectory = file_path;

                lvwFileData.BeginUpdate();
                
                readThread = new Thread(ReadHexFile);
                readThread.Start(file_path + file_name);
            }
            else
            {
                ;
            }

        }



        private void ReadHexFileOneLine(string file_one_line)
        {
            // Intel hex format 기준으로 "Start code"에 해당하는 ":"을 없앤다.
            file_one_line = file_one_line.Replace(":", "");
            selectedFile.fileContent.Add(file_one_line);
        }

        private void ReadHexFile(object arg_full_file_path)
        {
            string full_file_path = (string)arg_full_file_path;
            string file_line;

            StreamReader sr = new StreamReader(full_file_path);

            try
            {
                file_line = sr.ReadLine();
                selectedFile.baseAddress = file_line.Substring(9, 4);

                while ((file_line = sr.ReadLine()) != null)
                {
                    ReadHexFileOneLine(file_line);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sr.Close();

                delegateAddFileData = new DelegateAddFileData(WriteFileContent);
                Invoke(delegateAddFileData);
            }
        }

        private void WriteFileContent()
        {
            string[] strLvi;
            int byteLength;
            byte curByte;

            foreach (string fileContentLine in selectedFile.fileContent)
            {
                strLvi = new string[18];
                byteLength = int.Parse(fileContentLine.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                strLvi[0] = selectedFile.baseAddress + fileContentLine.Substring(2, 4);

                for (int i = 0; i < byteLength; ++i)
                {
                    strLvi[i + 1] = fileContentLine.Substring(8 + i * 2, 2);
                    curByte = Convert.ToByte(strLvi[i + 1], 16);
                    if (curByte <= 0x20)
                    {
                        strLvi[17] += ".";
                    }
                    else if (curByte > 0x7F)
                    {
                        strLvi[17] += "?";
                    }
                    else
                    {
                        strLvi[17] += (char)curByte;
                    }
                }
                lvwFileData.Items.Add(new ListViewItem(strLvi));
                selectedFile.decomposedFileContent.Add(strLvi);
            }
            lvwFileData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwFileData.EndUpdate();
            //txt_debug.Text += "read finished.";
            txt_base_address.Text += "0x"+ selectedFile.baseAddress + " 0000";
        }
    }
}
