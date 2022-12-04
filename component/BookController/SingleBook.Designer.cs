using System.Drawing;

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
            this.ButtonRead = new System.Windows.Forms.Button();
            this.BookPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRead
            // 
            this.ButtonRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ButtonRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRead.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.ButtonRead.ForeColor = System.Drawing.Color.White;
            this.ButtonRead.Location = new System.Drawing.Point(8, 316);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(243, 48);
            this.ButtonRead.TabIndex = 1;
            this.ButtonRead.Text = "READ";
            this.ButtonRead.UseVisualStyleBackColor = false;
            // 
            // BookPic
            // 
            this.BookPic.Image = global::Library.Properties.Resources.NoBookImage;
            this.BookPic.Location = new System.Drawing.Point(8, 9);
            this.BookPic.Name = "BookPic";
            this.BookPic.Size = new System.Drawing.Size(243, 301);
            this.BookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookPic.TabIndex = 0;
            this.BookPic.TabStop = false;
            // 
            // SingleBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.BookPic);
            this.Name = "SingleBook";
            this.Size = new System.Drawing.Size(260, 370);
            ((System.ComponentModel.ISupportInitialize)(this.BookPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BookPic;
        private System.Windows.Forms.Button ButtonRead;

        public int BookID
        {
            get;
            set;
        }

        public Image BookImage
        {
            get => BookPic.Image;
            set => BookPic.Image = value;
        }

        public string BookButton
        {
            get => ButtonRead.Text;
            set => ButtonRead.Text = value;
        }
    }
}
