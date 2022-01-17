using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    public partial class GetWords
    {
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public static String Get()
        {
            SendCtrlC();
            return GetDataFromClipboard();
        }

        public static void SendCtrlC()
        {
            IntPtr hWnd = GetForegroundWindow();
            uint KEYEVENTF_KEYUP = 2;
            byte VK_CONTROL = 0x11;
            SetForegroundWindow(hWnd);
            keybd_event(VK_CONTROL, 0, 0, 0);
            keybd_event(0x43, 0, 0, 0);
            //Send the C key (43 is "C")
            keybd_event(0x43, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);// 'Left Control Up
        }

        public static String GetDataFromClipboard()
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (null != iData)
            {
                if (iData.GetDataPresent(DataFormats.Text)) //检查是否存在文本
                {
                    for (int i = 0; i < 6; i++)
                    {
                        Thread.Sleep(500);
                        string res = (String)iData.GetData(DataFormats.Text);
                        if (!string.IsNullOrWhiteSpace(res))
                        {
                            return res;
                        }
                    }
                }
            }
            return null;
        }

    }
}
