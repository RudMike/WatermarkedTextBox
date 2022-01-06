using System.ComponentModel;

namespace WatermarkedTextBox
{
    partial class WatermarkedTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.watermark = new NoPaddingLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 2;
            this.textBox.SizeChanged += new System.EventHandler(this.textBox_SizeChanged);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // watermark
            // 
            this.watermark.BackColor = System.Drawing.SystemColors.Window;
            this.watermark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.watermark.ForeColor = System.Drawing.Color.Gray;
            this.watermark.Location = new System.Drawing.Point(2, 1);
            this.watermark.Margin = new System.Windows.Forms.Padding(0);
            this.watermark.Name = "watermark";
            this.watermark.Size = new System.Drawing.Size(96, 16);
            this.watermark.TabIndex = 3;
            this.watermark.Text = "Watermark";
            this.watermark.Click += new System.EventHandler(this.watermark_Click);
            // 
            // WatermarkedTextBox
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.textBox);
            this.Name = "WatermarkedTextBox";
            this.Size = new System.Drawing.Size(100, 20);
            this.FontChanged += new System.EventHandler(this.WatermarkedTextBox_FontChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private NoPaddingLabel watermark;
    }
}
