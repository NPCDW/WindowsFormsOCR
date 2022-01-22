namespace WindowsFormsOCR
{
    partial class TranslateAndOcrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslateAndOcrForm));
            this.ocrTextBox = new System.Windows.Forms.TextBox();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ocrTextBox
            // 
            this.ocrTextBox.AccessibleName = "";
            this.ocrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ocrTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ocrTextBox.Location = new System.Drawing.Point(12, 13);
            this.ocrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ocrTextBox.Multiline = true;
            this.ocrTextBox.Name = "ocrTextBox";
            this.ocrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ocrTextBox.Size = new System.Drawing.Size(611, 255);
            this.ocrTextBox.TabIndex = 1;
            this.ocrTextBox.Text = "OCR 文字识别";
            // 
            // translateTextBox
            // 
            this.translateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.translateTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.translateTextBox.Location = new System.Drawing.Point(12, 297);
            this.translateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.translateTextBox.Multiline = true;
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translateTextBox.Size = new System.Drawing.Size(611, 255);
            this.translateTextBox.TabIndex = 2;
            this.translateTextBox.Text = "截图/划词翻译";
            // 
            // TranslateAndOcrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 565);
            this.Controls.Add(this.translateTextBox);
            this.Controls.Add(this.ocrTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TranslateAndOcrForm";
            this.Text = "文字识别和翻译";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ocrTextBox;
        public System.Windows.Forms.TextBox translateTextBox;
    }
}