using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Call_From_by_Process_one
{
    public partial class Program_A : Form
    {
        //建立Process_A的物件
        private Process process_A = new Process();

        //建立Processes_A的Array，蒐集目前"程式B"的執行序
        private Process[] processes_A;

        public Program_A()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 關閉"程式B"的觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CloseProgram_B_Click(object sender, EventArgs e)
        {
            //取的"程式B"的執行序
            processes_A = Process.GetProcessesByName("Call_From_by_Process_two");
            if (processes_A.Length > 0)
            {
                //依序關閉"程式B"
                for (int i = 0; i < processes_A.Length; i++)
                {
                    processes_A[i].CloseMainWindow();
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// 啟動"程式B"的觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RunProgram_B_Click(object sender, EventArgs e)
        {
            //設定是否用是否要使用作業系統 Shell 來啟動處理序
            process_A.StartInfo.UseShellExecute = false;
            //設定開啟檔案了路徑
            process_A.StartInfo.FileName = Path.Combine(Application.StartupPath, @"../Program_B/Call_From_by_Process_two.exe");
            //設定是否開啟新視窗
            process_A.StartInfo.CreateNoWindow = true;
            //開始執行
            process_A.Start();
        }
    }
}