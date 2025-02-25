using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace p1k1w2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "powershell.exe";
            processStartInfo.Arguments = "Clear-RecycleBin -Force Start-Sleep \r\n-Seconds 2 \r\nClear-RecycleBin -Force";
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(processStartInfo);
            await Task.Delay(2000);
            MessageBox.Show("Recycle Bin has been cleared.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
