using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    public partial class Setting : Form
    {
        public Setting()
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
    }
}
