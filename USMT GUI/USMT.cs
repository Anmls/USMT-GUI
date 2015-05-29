using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USMT_GUI
{
	public partial class USMT : Form
	{
		private string _path = "User State Migration Tool\\{0}\\{1}";
		private Process _process;
		//private FileSystemWatcher _fileWatcher;

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
			
			_process.EnableRaisingEvents = true;

			_process.OutputDataReceived += _process_OutputDataReceived;
			_process.Exited += _process_Exited;

			if (RadioButtonBackup.Checked == true)
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
			else if (RadioButtonRestore.Checked == true)
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

			//_fileWatcher = new FileSystemWatcher(Environment.CurrentDirectory);
			//_fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
			//_fileWatcher.Filter = "*.log";
			//_fileWatcher.Changed += _fileWatcher_Changed;
			//_fileWatcher.Changed += _fileWatcher_Changed;

			//_fileWatcher.EnableRaisingEvents = true;

			_process.Start();

			WriteOutputLine(string.Format("=== {0} started at {1} ===" + Environment.NewLine, Path.GetFileName(_process.StartInfo.FileName), DateTime.Now));

			_process.BeginErrorReadLine();
			_process.BeginOutputReadLine();

			startButton.Enabled = false;
		}

		//void _fileWatcher_Changed(object sender, FileSystemEventArgs e)
		//{
		//	string logPath = Path.Combine(Environment.CurrentDirectory, "logs");

		//	if(Directory.Exists(logPath) == false)
		//	{
		//		Directory.CreateDirectory(logPath);
		//	}

		//	File.Copy(e.FullPath, Path.Combine(logPath, string.Format("{0}_{1}", DateTime.Now.ToString("yyyyMMddhhmmssfff"), e.Name)), true);



		//	//_logFiles.Add(e.FullPath);
		//}

		void _process_Exited(object sender, EventArgs e)
		{
			WriteOutputLine(string.Format("=== {0} exited at {1} ===" + Environment.NewLine, Path.GetFileName(_process.StartInfo.FileName), DateTime.Now));

			MethodInvoker methodInvoker = new MethodInvoker(() =>
			{
				startButton.Enabled = true;
			});

			this.Invoke(methodInvoker);
		}

		void WriteOutput(string output)
		{
			MethodInvoker methodInvoker = new MethodInvoker(() =>
			{
				if (string.IsNullOrEmpty(output) == false)
				{
					outputTextBox2.AppendText(output);
				}
			});

			this.Invoke(methodInvoker);
		}

		void WriteOutputLine(string output)
		{
			if (string.IsNullOrWhiteSpace(output) == false)
			{
				WriteOutput(output + Environment.NewLine);
			}
		}

		void _process_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			string output = e.Data;

			if (string.IsNullOrEmpty(output) == false)
			{
				output = output.Replace("\0", "");

				output = Regex.Replace(output, @"'(.*?.log)'", "file://$1");
			}

			WriteOutputLine(output);
		}
	}
}
