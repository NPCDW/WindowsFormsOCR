using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    public partial class ScreenshotForm : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        private Graphics MainPainter;   //主画面
        private Image baseImage;        //基本图形(原来的画面)
        private Rectangle Rect = new Rectangle();         //就是要保存的矩形
        private Point downPoint;        //鼠标按下的点
        private bool down = false;         //鼠标是否被按下

        public ScreenshotForm()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            InitializeComponent();

            Image img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(img);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.PrimaryScreen.Bounds.Size);
            baseImage = (Image)img.Clone();

            g.FillRectangle(new SolidBrush(Color.FromArgb(125, Color.DarkGray)), 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g.Dispose();
            this.BackgroundImage = img;

            MainPainter = this.CreateGraphics();
        }

        private void Screenshot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                FlushMemory();
            }
        }

        //刷新存储器
        private static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        private void Screenshot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Close();
                FlushMemory();
                return;
            }
            Rect.X = e.X;
            Rect.Y = e.Y;
            downPoint = new Point(e.X, e.Y);
            down = true;
        }

        private void Screenshot_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;

            Bitmap bmpOut = new Bitmap(Rect.Width, Rect.Height, PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(bmpOut);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.PrimaryScreen.Bounds.Size);
            g.DrawImage(baseImage, new Rectangle(0, 0, Rect.Width, Rect.Height), Rect, GraphicsUnit.Pixel);
            //Clipboard.SetImage(bmpOut);
        }

        private void Screenshot_MouseMove(object sender, MouseEventArgs e)
        {
            if (down)
            {
                Image NewImage = DrawRect(e.X, e.Y);
                MainPainter.DrawImage(NewImage, 0, 0);
                NewImage.Dispose();
                FlushMemory();
            }
        }

        //画矩形
        private Image DrawRect(int Mouse_x, int Mouse_y)
        {
            if (Mouse_y < Rect.Y)
            {
                Rect.Y = Mouse_y;
            }
            if (Mouse_x < Rect.X)
            {
                Rect.X = Mouse_x;
            }
            int heigth = Math.Abs(Mouse_y - downPoint.Y);
            int width = Math.Abs(Mouse_x - downPoint.X);
            Rect.Size = new Size(width, heigth);

            Image NewImage = (Image)baseImage.Clone();
            Graphics Painter = Graphics.FromImage(NewImage);
            //Painter.FillRectangle(new SolidBrush(Color.FromArgb(125, Color.DarkGray)), Rect);
            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            gp.AddRectangle(Rect);
            Painter.FillPath(new SolidBrush(Color.FromArgb(125, Color.DarkGray)), gp);
            gp.Dispose();
            Painter.Dispose();
            return NewImage;
        }
    }
}
