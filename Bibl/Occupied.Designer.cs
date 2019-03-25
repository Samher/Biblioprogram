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
            this.occClsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OccpdLbl
            // 
            this.OccpdLbl.AutoSize = true;
            this.OccpdLbl.Location = new System.Drawing.Point(25, 22);
            this.OccpdLbl.Name = "OccpdLbl";
            this.OccpdLbl.Size = new System.Drawing.Size(96, 13);
            this.OccpdLbl.TabIndex = 0;
            this.OccpdLbl.Text = "Någonting gick fel.";
            // 
            // occClsBtn
            // 
            this.occClsBtn.Location = new System.Drawing.Point(37, 51);
            this.occClsBtn.Name = "occClsBtn";
            this.occClsBtn.Size = new System.Drawing.Size(75, 23);
            this.occClsBtn.TabIndex = 1;
            this.occClsBtn.Text = "Ok";
            this.occClsBtn.UseVisualStyleBackColor = true;
            this.occClsBtn.Click += new System.EventHandler(this.occClsBtn_Click);
            // 
            // Occupied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 96);
            this.Controls.Add(this.occClsBtn);
            this.Controls.Add(this.OccpdLbl);
            this.Name = "Occupied";
            this.Text = "Fel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OccpdLbl;
        private System.Windows.Forms.Button occClsBtn;
    }
}