namespace Bibl
{
    partial class Occupied
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
            this.OccpdLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OccpdLbl
            // 
            this.OccpdLbl.AutoSize = true;
            this.OccpdLbl.Location = new System.Drawing.Point(45, 36);
            this.OccpdLbl.Name = "OccpdLbl";
            this.OccpdLbl.Size = new System.Drawing.Size(177, 13);
            this.OccpdLbl.TabIndex = 0;
            this.OccpdLbl.Text = "Ett verk med denna titel finns redan.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Occupied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OccpdLbl);
            this.Name = "Occupied";
            this.Text = "Occupied";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OccpdLbl;
        private System.Windows.Forms.Button button1;
    }
}