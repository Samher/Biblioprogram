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
            this.label1 = new System.Windows.Forms.Label();
            this.srhResultLbl = new System.Windows.Forms.Label();
            this.srhLstBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // srhLstBox
            // 
            this.srhLstBox.FormattingEnabled = true;
            this.srhLstBox.Location = new System.Drawing.Point(12, 97);
            this.srhLstBox.Name = "srhLstBox";
            this.srhLstBox.Size = new System.Drawing.Size(339, 264);
            this.srhLstBox.TabIndex = 6;
            this.srhLstBox.DoubleClick += new System.EventHandler(this.srhLstBox_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Låna";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Lämna";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(363, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.srhLstBox);
            this.Controls.Add(this.srhResultLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srhSearchBtn);
            this.Controls.Add(this.srhBox);
            this.HelpButton = true;
            this.Name = "searchForm";
            this.Text = "searchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srhBox;
        private System.Windows.Forms.Button srhSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label srhResultLbl;
        private System.Windows.Forms.ListBox srhLstBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}