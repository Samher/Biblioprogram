namespace Bibl
{
    partial class registerForm
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
            this.regTtlBox = new System.Windows.Forms.TextBox();
            this.regTtlLbl = new System.Windows.Forms.Label();
            this.regAuthBox = new System.Windows.Forms.TextBox();
            this.regAuthLbl = new System.Windows.Forms.Label();
            this.regInsertBtn = new System.Windows.Forms.Button();
            this.regRemoveBBtn = new System.Windows.Forms.Button();
            this.regRemoveABtn = new System.Windows.Forms.Button();
            this.regRegBox = new System.Windows.Forms.TextBox();
            this.regRegLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regTtlBox
            // 
            this.regTtlBox.Location = new System.Drawing.Point(12, 35);
            this.regTtlBox.Name = "regTtlBox";
            this.regTtlBox.Size = new System.Drawing.Size(174, 20);
            this.regTtlBox.TabIndex = 0;
            // 
            // regTtlLbl
            // 
            this.regTtlLbl.AutoSize = true;
            this.regTtlLbl.Location = new System.Drawing.Point(9, 19);
            this.regTtlLbl.Name = "regTtlLbl";
            this.regTtlLbl.Size = new System.Drawing.Size(30, 13);
            this.regTtlLbl.TabIndex = 1;
            this.regTtlLbl.Text = "Titel:";
            // 
            // regAuthBox
            // 
            this.regAuthBox.Location = new System.Drawing.Point(12, 92);
            this.regAuthBox.Name = "regAuthBox";
            this.regAuthBox.Size = new System.Drawing.Size(174, 20);
            this.regAuthBox.TabIndex = 2;
            // 
            // regAuthLbl
            // 
            this.regAuthLbl.AutoSize = true;
            this.regAuthLbl.Location = new System.Drawing.Point(9, 76);
            this.regAuthLbl.Name = "regAuthLbl";
            this.regAuthLbl.Size = new System.Drawing.Size(55, 13);
            this.regAuthLbl.TabIndex = 3;
            this.regAuthLbl.Text = "Författare:";
            // 
            // regInsertBtn
            // 
            this.regInsertBtn.Location = new System.Drawing.Point(12, 136);
            this.regInsertBtn.Name = "regInsertBtn";
            this.regInsertBtn.Size = new System.Drawing.Size(84, 26);
            this.regInsertBtn.TabIndex = 4;
            this.regInsertBtn.Text = "Mata in verk";
            this.regInsertBtn.UseVisualStyleBackColor = true;
            this.regInsertBtn.Click += new System.EventHandler(this.regInsertBtn_Click);
            // 
            // regRemoveBBtn
            // 
            this.regRemoveBBtn.Location = new System.Drawing.Point(102, 136);
            this.regRemoveBBtn.Name = "regRemoveBBtn";
            this.regRemoveBBtn.Size = new System.Drawing.Size(84, 26);
            this.regRemoveBBtn.TabIndex = 5;
            this.regRemoveBBtn.Text = "Ta bort verk";
            this.regRemoveBBtn.UseVisualStyleBackColor = true;
            // 
            // regRemoveABtn
            // 
            this.regRemoveABtn.Location = new System.Drawing.Point(102, 168);
            this.regRemoveABtn.Name = "regRemoveABtn";
            this.regRemoveABtn.Size = new System.Drawing.Size(84, 41);
            this.regRemoveABtn.TabIndex = 6;
            this.regRemoveABtn.Text = "Ta bort författare";
            this.regRemoveABtn.UseVisualStyleBackColor = true;
            // 
            // regRegBox
            // 
            this.regRegBox.Location = new System.Drawing.Point(213, 35);
            this.regRegBox.Multiline = true;
            this.regRegBox.Name = "regRegBox";
            this.regRegBox.ReadOnly = true;
            this.regRegBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.regRegBox.Size = new System.Drawing.Size(209, 235);
            this.regRegBox.TabIndex = 7;
            // 
            // regRegLbl
            // 
            this.regRegLbl.AutoSize = true;
            this.regRegLbl.Location = new System.Drawing.Point(210, 19);
            this.regRegLbl.Name = "regRegLbl";
            this.regRegLbl.Size = new System.Drawing.Size(46, 13);
            this.regRegLbl.TabIndex = 8;
            this.regRegLbl.Text = "Register";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 282);
            this.Controls.Add(this.regRegLbl);
            this.Controls.Add(this.regRegBox);
            this.Controls.Add(this.regRemoveABtn);
            this.Controls.Add(this.regRemoveBBtn);
            this.Controls.Add(this.regInsertBtn);
            this.Controls.Add(this.regAuthLbl);
            this.Controls.Add(this.regAuthBox);
            this.Controls.Add(this.regTtlLbl);
            this.Controls.Add(this.regTtlBox);
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regTtlBox;
        private System.Windows.Forms.Label regTtlLbl;
        private System.Windows.Forms.TextBox regAuthBox;
        private System.Windows.Forms.Label regAuthLbl;
        private System.Windows.Forms.Button regInsertBtn;
        private System.Windows.Forms.Button regRemoveBBtn;
        private System.Windows.Forms.Button regRemoveABtn;
        private System.Windows.Forms.TextBox regRegBox;
        private System.Windows.Forms.Label regRegLbl;
    }
}