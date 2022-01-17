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

        private void AccessTokenPasswordShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AccessTokenPasswordShowCheckbox.Checked)
            {
                AccessTokenInput.PasswordChar = '\0';
            }
            else
            {
                AccessTokenInput.PasswordChar = '*';
            }
        }

        private void SecretKeyPasswordShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SecretKeyPasswordShowCheckbox.Checked)
            {
                SecretKeyInput.PasswordChar = '\0';
            }
            else
            {
                SecretKeyInput.PasswordChar = '*';
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
                    }
                }
            }
            this.AccessTokenInput.Text = GlobalConfig.BaiduCloud.access_token;
            this.APIKeyInput.Text = GlobalConfig.BaiduCloud.client_id;
            this.SecretKeyInput.Text = GlobalConfig.BaiduCloud.client_secret;
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

        private void AccessTokenInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduCloud.access_token = this.AccessTokenInput.Text;
        }

        private void APIKeyInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduCloud.client_id = this.APIKeyInput.Text;
        }

        private void SecretKeyInput_TextChanged(object sender, EventArgs e)
        {
            GlobalConfig.BaiduCloud.client_secret = this.SecretKeyInput.Text;
        }

    }
}
