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
    public class GetWords
    {
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern void keybd_event(Keys vk, byte bScan, uint dwFlags, uint dwExtraInfo);

        public static String Get()
        {
            String beforeText = GetDataFromClipboard();
            SendCtrlC();
            Thread.Sleep(200);
            String text = GetDataFromClipboard();
            if (beforeText != null && beforeText.Equals(text))
            {
                return null;
            }
            return text;
        }

        private static void SendCtrlC()
        {
            //IntPtr hWnd = GetForegroundWindow();
            //SetForegroundWindow(hWnd);
            uint KEYEVENTF_KEYUP = 2;
            keybd_event(Keys.ControlKey, 0, 0, 0);
            keybd_event(Keys.C, 0, 0, 0);
            keybd_event(Keys.C, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);// 'Left Control Up
        }

        private static String GetDataFromClipboard()
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
