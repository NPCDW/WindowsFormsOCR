using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOCR
{
    internal class WinApiClipboard
    {
        [DllImport("User32")]
        internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("User32")]
        internal static extern bool CloseClipboard();

        [DllImport("User32")]
        internal static extern bool EmptyClipboard();

        [DllImport("User32")]
        internal static extern bool IsClipboardFormatAvailable(int format);

        [DllImport("User32")]
        internal static extern IntPtr GetClipboardData(int uFormat);

        [DllImport("User32", CharSet = CharSet.Unicode)]
        internal static extern IntPtr SetClipboardData(int uFormat, IntPtr hMem);

        internal static void SetText(string text)
        {
            if (!OpenClipboard(IntPtr.Zero)) 
            {
                SetText(text);
                return;
            }
            EmptyClipboard();
            SetClipboardData(13, Marshal.StringToHGlobalUni(text));
            CloseClipboard();
        }

        internal static string GetText()
        {
            string value = string.Empty;
            OpenClipboard(IntPtr.Zero);
            if (IsClipboardFormatAvailable(13))
            {
                IntPtr ptr = GetClipboardData(13);
                if (ptr != IntPtr.Zero)
                {
                    value = Marshal.PtrToStringUni(ptr);
                }
            }
            CloseClipboard();
            return value;
        }
    }
}
