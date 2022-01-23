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

namespace WindowsFormsOCR
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
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

        private void Setting_Load(object sender, EventArgs e)
        {
            this.autoStartButton.Checked = GlobalConfig.Common.autoStart;
            foreach (Control control in this.defaultOcrProvideGroupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.Common.defaultOcrProvide))
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
                    if (radioButton.Tag.Equals(GlobalConfig.Common.defaultTranslateProvide))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }

            foreach (Control control in this.baiduOcrGroupBox.Controls) {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.BaiduCloud.ocr_type))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
            this.BaiduCloud_APIKeyInput.Text = GlobalConfig.BaiduCloud.client_id;
            this.BaiduCloud_SecretKeyInput.Text = GlobalConfig.BaiduCloud.client_secret;
            this.BaiduAI_APPIDInput.Text = GlobalConfig.BaiduAI.app_id;
            this.BaiduAI_APPSecretInput.Text = GlobalConfig.BaiduAI.app_secret;

            foreach (Control control in this.tencentOcrGroupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.TencentCloud.ocr_type))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
            this.TencentCloud_SecretIdInput.Text = GlobalConfig.TencentCloud.secret_id;
            this.TencentCloud_SecretKeyInput.Text = GlobalConfig.TencentCloud.secret_key;
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalConfig.SaveConfig();
        }

        private void commonDefaultOcrProvideType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                GlobalConfig.Common.defaultOcrProvide = radioButton7.Tag.ToString();
            }
            else if (radioButton8.Checked)
            {
                GlobalConfig.Common.defaultOcrProvide = radioButton8.Tag.ToString();
            }
        }

        private void commonDefaultTranslateProvideType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                GlobalConfig.Common.defaultTranslateProvide = radioButton9.Tag.ToString();
            }
            else if (radioButton10.Checked)
            {
                GlobalConfig.Common.defaultTranslateProvide = radioButton10.Tag.ToString();
            }
        }

        private void baiduCloudType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GlobalConfig.BaiduCloud.ocr_type = radioButton1.Tag.ToString();
            }
            else if (radioButton2.Checked)
            {
                GlobalConfig.BaiduCloud.ocr_type = radioButton2.Tag.ToString();
            }
            else if (radioButton3.Checked)
            {
                GlobalConfig.BaiduCloud.ocr_type = radioButton3.Tag.ToString();
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

        private void TencentCloudType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                GlobalConfig.TencentCloud.ocr_type = radioButton4.Tag.ToString();
            }
            else if (radioButton5.Checked)
            {
                GlobalConfig.TencentCloud.ocr_type = radioButton5.Tag.ToString();
            }
            else if (radioButton6.Checked)
            {
                GlobalConfig.TencentCloud.ocr_type = radioButton6.Tag.ToString();
            }
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject("chenyongli0520@qq.com");
            MessageBox.Show("已复制邮件地址");
        }

        private void AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            bool isAuto = this.autoStartButton.Checked;
            try
            {
                if (isAuto)
                {
                    RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("WindowsFormsOCR", Application.ExecutablePath);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue("WindowsFormsOCR", false);
                    R_run.Close();
                    R_local.Close();
                }
                GlobalConfig.Common.autoStart = isAuto;
            }
            catch (Exception)
            {
                MessageBox.Show("您需要管理员权限修改");
            }
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
    }
}
