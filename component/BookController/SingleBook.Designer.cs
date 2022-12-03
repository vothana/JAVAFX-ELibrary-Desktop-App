namespace Library.component.BookController
{
    partial class SingleBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookPic = new System.Windows.Forms.PictureBox();
            this.ButtonRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BookPic
            // 
            this.BookPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookPic.Image = global::Library.Properties.Resources.SampleBook;
            this.BookPic.Location = new System.Drawing.Point(0, 0);
            this.BookPic.Name = "BookPic";
            this.BookPic.Size = new System.Drawing.Size(260, 310);
            this.BookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookPic.TabIndex = 0;
            this.BookPic.TabStop = false;
            // 
            // ButtonRead
            // 
            this.ButtonRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ButtonRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRead.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.ButtonRead.ForeColor = System.Drawing.Color.White;
            this.ButtonRead.Location = new System.Drawing.Point(0, 307);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(260, 65);
            this.ButtonRead.TabIndex = 1;
            this.ButtonRead.Text = "button1";
            this.ButtonRead.UseVisualStyleBackColor = false;
            // 
            // SingleBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.BookPic);
            this.Name = "SingleBook";
            this.Size = new System.Drawing.Size(260, 372);
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BookPic;
        private System.Windows.Forms.Button ButtonRead;
    }
}
