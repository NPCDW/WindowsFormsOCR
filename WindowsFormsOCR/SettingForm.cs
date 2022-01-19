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

        private void BaiduCloud_AccessTokenPasswordShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BaiduCloud_AccessTokenPasswordShowCheckbox.Checked)
            {
                BaiduCloud_AccessTokenInput.PasswordChar = '\0';
            }
            else
            {
                BaiduCloud_AccessTokenInput.PasswordChar = '*';
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

        private void Setting_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.baiduTypePanel.Controls) {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.BaiduCloud.type))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
            this.BaiduCloud_AccessTokenInput.Text = GlobalConfig.BaiduCloud.access_token;
            this.BaiduCloud_APIKeyInput.Text = GlobalConfig.BaiduCloud.client_id;
            this.BaiduCloud_SecretKeyInput.Text = GlobalConfig.BaiduCloud.client_secret;

            foreach (Control control in this.tencentTypePanel.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Tag.Equals(GlobalConfig.TencentCloud.type))
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

        private void baiduCloudType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GlobalConfig.BaiduCloud.type = radioButton1.Tag.ToString();
            }
            else if (radioButton2.Checked)
            {
                GlobalConfig.BaiduCloud.type = radioButton2.Tag.ToString();
            }
            else if (radioButton3.Checked)
            {
                GlobalConfig.BaiduCloud.type = radioButton3.Tag.ToString();
            }
        }

        private void BaiduCloud_AccessTokenInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduCloud.access_token = this.BaiduCloud_AccessTokenInput.Text;
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
                GlobalConfig.TencentCloud.type = radioButton4.Tag.ToString();
            }
            else if (radioButton5.Checked)
            {
                GlobalConfig.TencentCloud.type = radioButton5.Tag.ToString();
            }
            else if (radioButton6.Checked)
            {
                GlobalConfig.TencentCloud.type = radioButton6.Tag.ToString();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NPCDW/WindowsFormsOCR");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject("chenyongli0520@qq.com");
            MessageBox.Show("已复制邮件地址");
        }
    }
}
