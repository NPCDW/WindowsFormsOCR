using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            String defaultOcrType = GlobalConfig.Common.defaultOcrType;
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

            this.BaiduCloud_APIKeyInput.Text = GlobalConfig.BaiduCloud.client_id;
            this.BaiduCloud_SecretKeyInput.Text = GlobalConfig.BaiduCloud.client_secret;
            this.BaiduAI_APPIDInput.Text = GlobalConfig.BaiduAI.app_id;
            this.BaiduAI_APPSecretInput.Text = GlobalConfig.BaiduAI.app_secret;

            this.TencentCloud_SecretIdInput.Text = GlobalConfig.TencentCloud.secret_id;
            this.TencentCloud_SecretKeyInput.Text = GlobalConfig.TencentCloud.secret_key;

            this.TencentCloudTranslate_SecretIdInput.Text = GlobalConfig.TencentCloudTranslate.secret_id;
            this.TencentCloudTranslate_SecretKeyInput.Text = GlobalConfig.TencentCloudTranslate.secret_key;
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
            if (defaultTranslateTencentCloudRadio.Checked)
            {
                GlobalConfig.Common.defaultTranslateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), defaultTranslateTencentCloudRadio.Tag.ToString());
            }
            else if (defaultTranslateBaiduAIRadio.Checked)
            {
                GlobalConfig.Common.defaultTranslateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), defaultTranslateBaiduAIRadio.Tag.ToString());
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
    }
}
