using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SettingForm)
                {
                    form.Focus();
                    return;
                }
            }
            new SettingForm().Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 热键的功能
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312: //这个是window消息定义的 注册的热键消息
                    if (m.WParam.ToString().Equals("845")) //如果是我们注册的那个热键
                    {
                        this.Translate_Click(null, null);
                    }
                    if (m.WParam.ToString().Equals("846")) //如果是我们注册的那个热键
                    {
                        this.OcrButton_Click(null, null);
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        private void Translate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetWords.Get());
        }

        private void OcrButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("截图文字识别");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GlobalConfig.GetConfig();

            HotKey.RegisterHotKey(this.Handle, 845, HotKey.KeyModifiers.None, Keys.F2);
            HotKey.RegisterHotKey(this.Handle, 846, HotKey.KeyModifiers.None, Keys.F4);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HotKey.UnregisterHotKey(this.Handle, 845);
            HotKey.UnregisterHotKey(this.Handle, 846);
        }

    }
}
