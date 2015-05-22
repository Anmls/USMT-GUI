using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USMT_GUI
{
    public partial class USMT : Form
    {
        private string _path = "User State Migration Tool\\{0}\\{1}";
        private Process _process;
        private StreamWriter _output;

        public USMT()
        {
            InitializeComponent();
        }

        private void ButtonSelectUser_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLocalDriveBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                TextBoxLocalDrive.Text = folderBrowserDialog1.SelectedPath;
            }
            
            TextBoxLocalDrive.Text = folderBrowserDialog1.SelectedPath;
        }

        private void RadioButtonSpecificUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            _process = new Process();
            _process.StartInfo = new ProcessStartInfo();

            _process.StartInfo.CreateNoWindow = true;
            _process.StartInfo.UseShellExecute = false;
            _process.StartInfo.RedirectStandardOutput = true;
            _process.StartInfo.RedirectStandardError = true;

            _process.OutputDataReceived += _process_OutputDataReceived;
            _process.Exited += _process_Exited;

            if(RadioButtonBackup.Checked == true)
            {
                if (Environment.Is64BitOperatingSystem == true)
                {
                    _process.StartInfo.FileName = string.Format(_path, "amd64", "scanstate.exe");
                }
                else
                {
                    _process.StartInfo.FileName = string.Format(_path, "x86", "scanstate.exe");
                }
            }
            else if(RadioButtonRestore.Checked == true)
            {
                if (Environment.Is64BitOperatingSystem == true)
                {
                    _process.StartInfo.FileName = string.Format(_path, "amd64", "loadstate.exe");
                }
                else
                {
                    _process.StartInfo.FileName = string.Format(_path, "x86", "loadstate.exe");
                }
            }

            _process.Start();
            _process.BeginErrorReadLine();
            _process.BeginOutputReadLine();
            ButtonStart.Enabled = false;
        }

        void _process_Exited(object sender, EventArgs e)
        {
            ButtonStart.Enabled = true;
        }

        void _process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            //_output.Append(e.Data);
        }

    }
}
