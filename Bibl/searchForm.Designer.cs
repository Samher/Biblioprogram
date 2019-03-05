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
            this.srhBox = new System.Windows.Forms.TextBox();
            this.srhSearchBtn = new System.Windows.Forms.Button();
            this.srhResBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.srhResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srhBox
            // 
            this.srhBox.Location = new System.Drawing.Point(12, 31);
            this.srhBox.Name = "srhBox";
            this.srhBox.Size = new System.Drawing.Size(145, 20);
            this.srhBox.TabIndex = 1;
            // 
            // srhSearchBtn
            // 
            this.srhSearchBtn.Location = new System.Drawing.Point(163, 30);
            this.srhSearchBtn.Name = "srhSearchBtn";
            this.srhSearchBtn.Size = new System.Drawing.Size(45, 23);
            this.srhSearchBtn.TabIndex = 2;
            this.srhSearchBtn.Text = "Sök";
            this.srhSearchBtn.UseVisualStyleBackColor = true;
            this.srhSearchBtn.Click += new System.EventHandler(this.srhSearchBtn_Click);
            // 
            // srhResBox
            // 
            this.srhResBox.Location = new System.Drawing.Point(12, 101);
            this.srhResBox.Multiline = true;
            this.srhResBox.Name = "srhResBox";
            this.srhResBox.ReadOnly = true;
            this.srhResBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srhResBox.Size = new System.Drawing.Size(339, 263);
            this.srhResBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sök efter verk / författare";
            // 
            // srhResultLbl
            // 
            this.srhResultLbl.AutoSize = true;
            this.srhResultLbl.Location = new System.Drawing.Point(13, 82);
            this.srhResultLbl.Name = "srhResultLbl";
            this.srhResultLbl.Size = new System.Drawing.Size(60, 13);
            this.srhResultLbl.TabIndex = 5;
            this.srhResultLbl.Text = "Sökresultat";
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 376);
            this.Controls.Add(this.srhResultLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srhResBox);
            this.Controls.Add(this.srhSearchBtn);
            this.Controls.Add(this.srhBox);
            this.Name = "searchForm";
            this.Text = "searchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srhBox;
        private System.Windows.Forms.Button srhSearchBtn;
        private System.Windows.Forms.TextBox srhResBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label srhResultLbl;
    }
}