namespace Bibl
{
    partial class searchForm
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
            this.srh = new System.Windows.Forms.TextBox();
            this.srhSearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // srh
            // 
            this.srh.Location = new System.Drawing.Point(12, 30);
            this.srh.Name = "srh";
            this.srh.Size = new System.Drawing.Size(145, 20);
            this.srh.TabIndex = 1;
            // 
            // srhSearchBtn
            // 
            this.srhSearchBtn.Location = new System.Drawing.Point(163, 28);
            this.srhSearchBtn.Name = "srhSearchBtn";
            this.srhSearchBtn.Size = new System.Drawing.Size(45, 23);
            this.srhSearchBtn.TabIndex = 2;
            this.srhSearchBtn.Text = "Sök";
            this.srhSearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(339, 263);
            this.textBox1.TabIndex = 3;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 376);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.srhSearchBtn);
            this.Controls.Add(this.srh);
            this.Name = "searchForm";
            this.Text = "searchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srh;
        private System.Windows.Forms.Button srhSearchBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}