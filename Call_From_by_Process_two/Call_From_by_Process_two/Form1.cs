using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_From_by_Process_two
{
    public partial class Program_B : Form
    {
        private Process process_B = new Process();
        private Process[] process_detect;

        public Program_B()
        {
            InitializeComponent();
        }

        private void btn_CloseProgram_A_Click(object sender, EventArgs e)
        {
            process_detect = Process.GetProcessesByName("Call_From_by_Process_one");
            if (process_detect.Length > 0)
            {
                for (int i = 0; i < process_detect.Length; i++)
                {
                    process_detect[i].CloseMainWindow();
                    Thread.Sleep(1000);
                }
            }
        }

        private void btn_RunProgram_A_Click(object sender, EventArgs e)
        {
            process_B.StartInfo.UseShellExecute = false;
            process_B.StartInfo.FileName = Path.Combine(Application.StartupPath, @"../Program_A/Call_From_by_Process_one.exe");
            process_B.StartInfo.CreateNoWindow = true;
            process_B.Start();
        }
    }
}