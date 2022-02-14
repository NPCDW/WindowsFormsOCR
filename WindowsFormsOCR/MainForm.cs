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

            GlobalConfig.GetConfig();

            HotKeysUtil.RegisterHotKey(this.Handle);
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SettingForm)
                {
                    form.Activate();
                    return;
                }
            }
            new SettingForm().Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            HotKeysUtil.UnRegisterHotKey();
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
                        this.Translate_HotKey_Click(null, null);
                    }
                    if (m.WParam.ToString().Equals("846")) //如果是我们注册的那个热键
                    {
                        this.OcrButton_Click(null, null);
                    }
                    if (m.WParam.ToString().Equals("847")) //如果是我们注册的那个热键
                    {
                        this.ScreenshotTranslation_Click(null, null);
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("先用鼠标选出需要翻译的文本，然后按F2即可");
        }

        private void Translate_HotKey_Click(object sender, EventArgs e)
        {
            String getWordsResult = GetWords.Get();
            TranslateAndOcrForm form = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item is TranslateAndOcrForm)
                {
                    form = (TranslateAndOcrForm)item;
                    form.Activate();
                    break;
                }
            }
            if (form == null)
            {
                form = new TranslateAndOcrForm();
                form.Show();
                form.Activate();
            }
            if (string.IsNullOrEmpty(getWordsResult))
            {
                return;
            }
            form.ocrTextBox.Text = getWordsResult;
            form.translate();
        }

        private void ScreenshotTranslation_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ScreenshotForm)
                {
                    form.Activate();
                    return;
                }
            }
            ScreenshotForm body = new ScreenshotForm("translate");
            body.Size = Screen.PrimaryScreen.Bounds.Size;
            body.Show();
        }

        private void OcrButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ScreenshotForm)
                {
                    form.Activate();
                    return;
                }
            }
            ScreenshotForm body = new ScreenshotForm();
            body.Size = Screen.PrimaryScreen.Bounds.Size;
            body.Show();
        }

    }
}
