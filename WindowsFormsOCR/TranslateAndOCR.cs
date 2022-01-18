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
    public partial class TranslateAndOcrForm : Form
    {
        public TranslateAndOcrForm()
        {
            InitializeComponent();
        }

        public void translate()
        {
            translateTextBox.Text = "翻译结果";
        }

        public void ocr()
        {
            ocrTextBox.Text = "文本识别结果";
        }

    }
}
