using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static WindowsFormsOCR.GlobalConfig;

namespace WindowsFormsOCR
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            this.ocrHotKeyTextBox.GotFocus += new System.EventHandler(this.HotKeyTextBox_GotFocus);
            this.ocrHotKeyTextBox.LostFocus += new System.EventHandler(this.HotKeyTextBox_LostFocus);
            this.GetWordsTranslateHotKeyTextBox.GotFocus += new System.EventHandler(this.HotKeyTextBox_GotFocus);
            this.GetWordsTranslateHotKeyTextBox.LostFocus += new System.EventHandler(this.HotKeyTextBox_LostFocus);
            this.ScreenshotTranslateHotKeyTextBox.GotFocus += new System.EventHandler(this.HotKeyTextBox_GotFocus);
            this.ScreenshotTranslateHotKeyTextBox.LostFocus += new System.EventHandler(this.HotKeyTextBox_LostFocus);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            String defaultOcrType = GlobalConfig.Common.defaultOcrType;
            String defaultTranslateSourceLanguage = GlobalConfig.Common.defaultTranslateSourceLanguage;
            String defaultTranslateTargetLanguage = GlobalConfig.Common.defaultTranslateTargetLanguage;
            this.autoStartButton.Checked = GlobalConfig.Common.autoStart;
            foreach (Control control in this.defaultOcrProvideGroupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.Common.defaultOcrProvide.ToString()))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
            foreach (Control control in this.defaultTranslateProvide.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.Common.defaultTranslateProvide.ToString()))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
            foreach (String text in this.defaultOcrTypeComboBox.Items)
            {
                if (text.Split('#')[1].Equals(defaultOcrType))
                {
                    defaultOcrTypeComboBox.Text = text;
                    break;
                }
            }

            foreach (String text in this.sourceLanguageComboBox.Items)
            {
                if (text.Split('#')[1].Equals(defaultTranslateSourceLanguage))
                {
                    sourceLanguageComboBox.Text = text;
                    break;
                }
            }

            foreach (String text in this.targetLanguageComboBox.Items)
            {
                if (text.Split('#')[1].Equals(defaultTranslateTargetLanguage))
                {
                    targetLanguageComboBox.Text = text;
                    break;
                }
            }

            this.BaiduCloud_APIKeyInput.Text = GlobalConfig.BaiduCloud.client_id;
            this.BaiduCloud_SecretKeyInput.Text = GlobalConfig.BaiduCloud.client_secret;
            this.BaiduAI_APPIDInput.Text = GlobalConfig.BaiduAI.app_id;
            this.BaiduAI_APPSecretInput.Text = GlobalConfig.BaiduAI.app_secret;

            this.TencentCloud_SecretIdInput.Text = GlobalConfig.TencentCloud.secret_id;
            this.TencentCloud_SecretKeyInput.Text = GlobalConfig.TencentCloud.secret_key;

            this.TencentCloudTranslate_SecretIdInput.Text = GlobalConfig.TencentCloudTranslate.secret_id;
            this.TencentCloudTranslate_SecretKeyInput.Text = GlobalConfig.TencentCloudTranslate.secret_key;

            this.ocrHotKeyTextBox.Text = GlobalConfig.HotKeys.Ocr.Text;
            this.GetWordsTranslateHotKeyTextBox.Text = GlobalConfig.HotKeys.GetWordsTranslate.Text;
            this.ScreenshotTranslateHotKeyTextBox.Text = GlobalConfig.HotKeys.ScreenshotTranslate.Text;
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalConfig.SaveConfig();
        }

        private void commonDefaultOcrProvideType_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultOcrBaiduCloudRadio.Checked)
            {
                GlobalConfig.Common.defaultOcrProvide = (OcrProvideEnum)Enum.Parse(typeof(OcrProvideEnum), defaultOcrBaiduCloudRadio.Tag.ToString());
                defaultOcrTypeComboBox.Items.Clear();
                defaultOcrTypeComboBox.Items.Add("通用#" + GlobalConfig.BaiduCloud.OcrTypeEnum.general_basic.ToString());
                defaultOcrTypeComboBox.Items.Add("高精度#" + GlobalConfig.BaiduCloud.OcrTypeEnum.accurate_basic.ToString());
                defaultOcrTypeComboBox.Items.Add("手写体#" + GlobalConfig.BaiduCloud.OcrTypeEnum.handwriting.ToString());
                defaultOcrTypeComboBox.SelectedIndex = 0;
            }
            else if (defaultOcrTencentCloudRadio.Checked)
            {
                GlobalConfig.Common.defaultOcrProvide = (OcrProvideEnum)Enum.Parse(typeof(OcrProvideEnum), defaultOcrTencentCloudRadio.Tag.ToString());
                defaultOcrTypeComboBox.Items.Clear();
                defaultOcrTypeComboBox.Items.Add("通用#" + GlobalConfig.TencentCloud.OcrTypeEnum.GeneralBasicOCR.ToString());
                defaultOcrTypeComboBox.Items.Add("高精度#" + GlobalConfig.TencentCloud.OcrTypeEnum.GeneralAccurateOCR.ToString());
                defaultOcrTypeComboBox.Items.Add("手写体#" + GlobalConfig.TencentCloud.OcrTypeEnum.GeneralHandwritingOCR.ToString());
                defaultOcrTypeComboBox.SelectedIndex = 0;
            }
        }

        private void commonDefaultTranslateProvideType_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultTranslateBaiduAIRadio.Checked)
            {
                GlobalConfig.Common.defaultTranslateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), defaultTranslateBaiduAIRadio.Tag.ToString());
                sourceLanguageComboBox.Items.Clear();
                targetLanguageComboBox.Items.Clear();
                foreach (TranslateLanguageAttribute item in TranslateLanguageExtension.TranslateLanguageAttributeList)
                {
                    if (!string.IsNullOrWhiteSpace(item.getBaiduAiCode()))
                    {
                        sourceLanguageComboBox.Items.Add(item.getName() + "#" + item.getBaiduAiCode());
                        targetLanguageComboBox.Items.Add(item.getName() + "#" + item.getBaiduAiCode());
                    }
                }
                targetLanguageComboBox.Items.RemoveAt(0);
                sourceLanguageComboBox.SelectedIndex = 0;
                targetLanguageComboBox.SelectedIndex = 0;
                GlobalConfig.Common.defaultTranslateSourceLanguage = TranslateLanguageExtension.TranslateLanguageAttributeList[0].getBaiduAiCode();
                GlobalConfig.Common.defaultTranslateTargetLanguage = TranslateLanguageExtension.TranslateLanguageAttributeList[1].getBaiduAiCode();
            }
            else if (defaultTranslateTencentCloudRadio.Checked)
            {
                GlobalConfig.Common.defaultTranslateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), defaultTranslateTencentCloudRadio.Tag.ToString());
                sourceLanguageComboBox.Items.Clear();
                targetLanguageComboBox.Items.Clear();
                foreach (TranslateLanguageAttribute item in TranslateLanguageExtension.TranslateLanguageAttributeList)
                {
                    if (!string.IsNullOrWhiteSpace(item.getTencentCloudCode()))
                    {
                        sourceLanguageComboBox.Items.Add(item.getName() + "#" + item.getTencentCloudCode());
                        targetLanguageComboBox.Items.Add(item.getName() + "#" + item.getTencentCloudCode());
                    }
                }
                targetLanguageComboBox.Items.RemoveAt(0);
                sourceLanguageComboBox.SelectedIndex = 0;
                targetLanguageComboBox.SelectedIndex = 0;
                GlobalConfig.Common.defaultTranslateSourceLanguage = TranslateLanguageExtension.TranslateLanguageAttributeList[0].getTencentCloudCode();
                GlobalConfig.Common.defaultTranslateTargetLanguage = TranslateLanguageExtension.TranslateLanguageAttributeList[1].getTencentCloudCode();
            }
        }

        private void BaiduCloud_SecretKeyPasswordShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BaiduCloud_SecretKeyPasswordShowCheckbox.Checked)
            {
                BaiduCloud_SecretKeyInput.PasswordChar = '\0';
            }
            else
            {
                BaiduCloud_SecretKeyInput.PasswordChar = '*';
            }
        }

        private void BaiduCloud_APIKeyInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduCloud.client_id = this.BaiduCloud_APIKeyInput.Text;
        }

        private void BaiduCloud_SecretKeyInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduCloud.client_secret = this.BaiduCloud_SecretKeyInput.Text;
        }

        private void TencentCloud_SecretKeyPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (TencentCloud_SecretKeyPasswordShow.Checked)
            {
                TencentCloud_SecretKeyInput.PasswordChar = '\0';
            }
            else
            {
                TencentCloud_SecretKeyInput.PasswordChar = '*';
            }
        }

        private void TencentCloud_SecretIdInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.TencentCloud.secret_id = this.TencentCloud_SecretIdInput.Text;
        }

        private void TencentCloud_SecretKeyInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.TencentCloud.secret_key = this.TencentCloud_SecretKeyInput.Text;
        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject("chenyongli0520@qq.com");
            MessageBox.Show("已复制邮件地址");
        }

        private void AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            bool isAuto = this.autoStartButton.Checked;
            if (isAuto)
            {
                AutoStart.Enable();
            }
            else
            {
                AutoStart.Disable();
            }
            GlobalConfig.Common.autoStart = isAuto;
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Tag.ToString());
        }

        private void BaiduAI_APPSecretPasswordShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BaiduAI_APPSecretPasswordShowCheckbox.Checked)
            {
                BaiduAI_APPSecretInput.PasswordChar = '\0';
            }
            else
            {
                BaiduAI_APPSecretInput.PasswordChar = '*';
            }
        }

        private void BaiduAI_APPIDInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduAI.app_id = this.BaiduAI_APPIDInput.Text;
        }

        private void BaiduAI_APPSecretInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduAI.app_secret = this.BaiduAI_APPSecretInput.Text;
        }

        private void TencentCloudTranslate_SecretKeyPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (TencentCloudTranslate_SecretKeyPasswordShow.Checked)
            {
                TencentCloudTranslate_SecretKeyInput.PasswordChar = '\0';
            }
            else
            {
                TencentCloudTranslate_SecretKeyInput.PasswordChar = '*';
            }
        }

        private void TencentCloudTranslate_SecretIdInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.TencentCloudTranslate.secret_id = this.TencentCloudTranslate_SecretIdInput.Text;
        }

        private void TencentCloudTranslate_SecretKeyInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.TencentCloudTranslate.secret_key = this.TencentCloudTranslate_SecretKeyInput.Text;
        }

        private void defaultOcrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = defaultOcrTypeComboBox.Text;
            if (!string.IsNullOrWhiteSpace(text) && text.Contains("#"))
            {
                GlobalConfig.Common.defaultOcrType = text.Split('#')[1];
            }
        }

        private void sourceLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sourceLanguageText = sourceLanguageComboBox.Text;
            if (!string.IsNullOrWhiteSpace(sourceLanguageText) && sourceLanguageText.Contains("#"))
            {
                GlobalConfig.Common.defaultTranslateSourceLanguage = sourceLanguageText.Split('#')[1];
            }
        }

        private void targetLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String targetLanguageText = targetLanguageComboBox.Text;
            if (!string.IsNullOrWhiteSpace(targetLanguageText) && targetLanguageText.Contains("#"))
            {
                GlobalConfig.Common.defaultTranslateTargetLanguage = targetLanguageText.Split('#')[1];
            }
        }

        byte hotkeysModifiers;
        int hotkeysKey;
        string hotkeysText;

        private void HotKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            hotkeysModifiers = 0;
            hotkeysKey = 0;
            StringBuilder text = new StringBuilder();
            if (e.Modifiers != 0)
            {
                if (e.Control)
                {
                    text.Append("Ctrl + ");
                    hotkeysModifiers += 2;
                }
                if (e.Alt)
                {
                    text.Append("Alt + ");
                    hotkeysModifiers += 1;
                }
                if (e.Shift)
                {
                    text.Append("Shift + ");
                    hotkeysModifiers += 4;
                }
            }
            if ((e.KeyValue >= 33 && e.KeyValue <= 40) ||
                (e.KeyValue >= 65 && e.KeyValue <= 90) ||   //a-z/A-Z
                (e.KeyValue >= 112 && e.KeyValue <= 123))   //F1-F12
            {
                text.Append(e.KeyCode);
                hotkeysKey = e.KeyValue;
            }
            else if ((e.KeyValue >= 48 && e.KeyValue <= 57))    //0-9
            {
                text.Append(e.KeyCode.ToString().Substring(1));
                hotkeysKey = e.KeyValue;
            }
            hotkeysText = text.ToString();
            ((TextBox)sender).Text = text.ToString();
        }

        private Boolean HotKeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string str = textBox.Text.TrimEnd();
            int len = str.Length;
            if (len >= 1 && str.Substring(str.Length - 1) == "+")
            {
                textBox.Text = "";
                return false;
            }
            if (!str.Contains("+") && !str.Contains("F"))
            {
                textBox.Text = "";
                return false;
            }
            return true;
        }

        private void HotKeyTextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            NativeMethod.HideCaret((textBox).Handle);
            textBox.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void HotKeyTextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
            HotKeysUtil.ReRegisterHotKey();
        }

        private void defaultHotKeysButton_Click(object sender, EventArgs e)
        {
            GetWordsTranslateHotKeyTextBox.Text = "F2";
            ocrHotKeyTextBox.Text = "F4";
            ScreenshotTranslateHotKeyTextBox.Text = "Ctrl + F2";

            GlobalConfig.HotKeys.GetWordsTranslate.Modifiers = 0;
            GlobalConfig.HotKeys.GetWordsTranslate.Key = 113;
            GlobalConfig.HotKeys.GetWordsTranslate.Text = "F2";
            GlobalConfig.HotKeys.Ocr.Modifiers = 0;
            GlobalConfig.HotKeys.Ocr.Key = 115;
            GlobalConfig.HotKeys.Ocr.Text = "F4";
            GlobalConfig.HotKeys.ScreenshotTranslate.Modifiers = 2;
            GlobalConfig.HotKeys.ScreenshotTranslate.Key = 113;
            GlobalConfig.HotKeys.ScreenshotTranslate.Text = "Ctrl + F2";

            MainForm.mainForm.translateButton.ShortcutKeyDisplayString = GetWordsTranslateHotKeyTextBox.Text.Replace(" ", "");
            MainForm.mainForm.ocrButton.ShortcutKeyDisplayString = ocrHotKeyTextBox.Text.Replace(" ", "");
            MainForm.mainForm.ScreenshotTranslationButton.ShortcutKeyDisplayString = ScreenshotTranslateHotKeyTextBox.Text.Replace(" ", "");

            HotKeysUtil.ReRegisterHotKey();
        }

        private void ocrHotKeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool verify = HotKeyTextBox_KeyUp(sender, e);
            if (verify)
            {
                GlobalConfig.HotKeys.Ocr.Modifiers = hotkeysModifiers;
                GlobalConfig.HotKeys.Ocr.Key = hotkeysKey;
                GlobalConfig.HotKeys.Ocr.Text = hotkeysText;
                MainForm.mainForm.ocrButton.ShortcutKeyDisplayString = hotkeysText.Replace(" ", "");
            }
        }

        private void GetWordsTranslateHotKeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool verify = HotKeyTextBox_KeyUp(sender, e);
            if (verify)
            {
                GlobalConfig.HotKeys.GetWordsTranslate.Modifiers = hotkeysModifiers;
                GlobalConfig.HotKeys.GetWordsTranslate.Key = hotkeysKey;
                GlobalConfig.HotKeys.GetWordsTranslate.Text = hotkeysText;
                MainForm.mainForm.translateButton.ShortcutKeyDisplayString = hotkeysText.Replace(" ", "");
            }
        }

        private void ScreenshotTranslateHotKeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool verify = HotKeyTextBox_KeyUp(sender, e);
            if (verify)
            {
                GlobalConfig.HotKeys.ScreenshotTranslate.Modifiers = hotkeysModifiers;
                GlobalConfig.HotKeys.ScreenshotTranslate.Key = hotkeysKey;
                GlobalConfig.HotKeys.ScreenshotTranslate.Text = hotkeysText;
                MainForm.mainForm.ScreenshotTranslationButton.ShortcutKeyDisplayString = hotkeysText.Replace(" ", "");
            }
        }
    }
}
