﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    internal class NativeMethod
    {
        /// <summary>
        /// 设置窗口在最前端
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 获取最前端的窗口
        /// </summary>
        /// <returns>窗口句柄</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 模拟触发键盘的按键
        /// </summary>
        /// <param name="vk">按下的键</param>
        /// <param name="bScan"></param>
        /// <param name="dwFlags">触发的方式，0按下，2抬起</param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("user32.dll")]
        public static extern void keybd_event(Keys vk, byte bScan, uint dwFlags, uint dwExtraInfo);

        /// <summary>
        /// 注册全局热键
        /// </summary>
        /// <param name="hWnd">要定义热键的窗口的句柄</param>
        /// <param name="id">定义热键ID（不能与其它ID重复，全局唯一）</param>
        /// <param name="fsModifiers">标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效</param>
        /// <param name="vk">定义热键的内容</param>
        /// <returns>成功，返回值不为0，失败，返回值为0。要得到扩展错误信息，调用GetLastError</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, byte fsModifiers, int vk);

        /// <summary>
        /// 取消注册全局热键
        /// </summary>
        /// <param name="hWnd">要取消热键的窗口的句柄</param>
        /// <param name="id">要取消热键的ID</param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// 加载鼠标样式从文件中
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);

        /// <summary>
        /// 设置鼠标样式
        /// </summary>
        /// <param name="cursorHandle"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr cursorHandle);

        /// <summary>
        /// 销毁鼠标样式
        /// </summary>
        /// <param name="cursorHandle"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern uint DestroyCursor(IntPtr cursorHandle);

        /// <summary>
        /// 隐藏焦点，隐藏光标闪烁
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32", EntryPoint = "HideCaret")]
        public static extern bool HideCaret(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        /// <summary>
        /// 打开剪切板
        /// </summary>
        /// <param name="hWndNewOwner"></param>
        /// <returns></returns>
        [DllImport("User32")]
        internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

        /// <summary>
        /// 关闭剪切板
        /// </summary>
        /// <returns></returns>
        [DllImport("User32")]
        internal static extern bool CloseClipboard();

        /// <summary>
        /// 清空剪切板
        /// </summary>
        /// <returns></returns>
        [DllImport("User32")]
        internal static extern bool EmptyClipboard();

        /// <summary>
        /// 剪切板格式化的数据是否可用
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        [DllImport("User32")]
        internal static extern bool IsClipboardFormatAvailable(int format);

        /// <summary>
        /// 获取剪切板数据
        /// </summary>
        /// <param name="uFormat"></param>
        /// <returns></returns>
        [DllImport("User32")]
        internal static extern IntPtr GetClipboardData(int uFormat);

        /// <summary>
        /// 设置剪切板数据
        /// </summary>
        /// <param name="uFormat"></param>
        /// <param name="hMem"></param>
        /// <returns></returns>
        [DllImport("User32", CharSet = CharSet.Unicode)]
        internal static extern IntPtr SetClipboardData(int uFormat, IntPtr hMem);

        /// <summary>
        /// 兼容Windows缩放情况
        /// </summary>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        /// <summary>
        /// 定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        /// </summary>
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
    }
}
