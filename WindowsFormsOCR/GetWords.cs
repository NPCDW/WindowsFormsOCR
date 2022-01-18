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
            Thread.Sleep(200);
            String text = GetDataFromClipboard();
            return text;
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
            if (Clipboard.ContainsText()) //检查是否存在文本
            {
                string res = Clipboard.GetText();
                if (!string.IsNullOrWhiteSpace(res))
                {
                    return res;
                }
            }
            return null;
        }

    }
}
