using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                NativeMethod.SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RunningInstance();
        }

        private static void RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id == current.Id)
                {
                    continue;
                }
                if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                {
                    MessageBox.Show("已经有一个程序实例在运行了，请看右下角通知区域图标" + System.Environment.NewLine
                        + "F2: 划词翻译" + System.Environment.NewLine
                        + "F4: 截图文本识别" + System.Environment.NewLine
                        + "Ctrl + F2: 截图翻译");
                    return;
                }
            }
            using (MainForm mainForm = new MainForm())
            {
                Application.Run();
            }
        }
    }
}
