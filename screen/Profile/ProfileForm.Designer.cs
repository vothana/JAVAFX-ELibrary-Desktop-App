namespace Library.screen.Profile
{
    partial class ProfileForm
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
            this.txtProfileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProfileName
            // 
            this.txtProfileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProfileName.Font = new System.Drawing.Font("Poppins", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.txtProfileName.Location = new System.Drawing.Point(361, 172);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(401, 120);
            this.txtProfileName.TabIndex = 8;
            this.txtProfileName.Text = "Profile Form";
            this.txtProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 747);
            this.Controls.Add(this.txtProfileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtProfileName;
    }
}