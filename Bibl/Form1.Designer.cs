namespace Bibl
{
    partial class Form1
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
            this.insertBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.lendBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(12, 193);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(239, 47);
            this.insertBtn.TabIndex = 0;
            this.insertBtn.Text = "Mata in / Ta bort";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 140);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(239, 47);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Sök";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // lendBtn
            // 
            this.lendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendBtn.Location = new System.Drawing.Point(12, 246);
            this.lendBtn.Name = "lendBtn";
            this.lendBtn.Size = new System.Drawing.Size(239, 47);
            this.lendBtn.TabIndex = 3;
            this.lendBtn.Text = "Låna / Lämna";
            this.lendBtn.UseVisualStyleBackColor = true;
            this.lendBtn.Click += new System.EventHandler(this.lendBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(176, 12);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 4;
            this.importBtn.Text = "Importera";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 306);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.lendBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.insertBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button lendBtn;
        private System.Windows.Forms.Button importBtn;
    }
}

