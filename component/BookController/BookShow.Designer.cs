using System.Drawing;

namespace Library.component.BookController
{
    partial class BookShow
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
            this.Button = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.freee = new Library.component.RoundedPic();
            this.Picthure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.freee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picthure)).BeginInit();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.Color.White;
            this.Button.Location = new System.Drawing.Point(0, 561);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(351, 40);
            this.Button.TabIndex = 11;
            this.Button.Text = "READ";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Year
            // 
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year.Font = new System.Drawing.Font("KS Bontey Kro 01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(3, 493);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(344, 23);
            this.Year.TabIndex = 8;
            this.Year.Text = "Book\'s year";
            // 
            // Author
            // 
            this.Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author.Font = new System.Drawing.Font("KS Bontey Kro 01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(3, 472);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(344, 23);
            this.Author.TabIndex = 9;
            this.Author.Text = "Book\'s author";
            // 
            // Tittle
            // 
            this.Tittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tittle.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.Tittle.Location = new System.Drawing.Point(3, 447);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(347, 23);
            this.Tittle.TabIndex = 10;
            this.Tittle.Text = "Book\'s tittle";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(0, 514);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(350, 44);
            this.Description.TabIndex = 7;
            this.Description.Text = "  Book\'s description";
            // 
            // freee
            // 
            this.freee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.freee.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.freee.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.freee.BorderRadius = 40;
            this.freee.BorderSize = 0;
            this.freee.GradientAngle = 90F;
            this.freee.Image = global::Library.Properties.Resources.Frreee;
            this.freee.Location = new System.Drawing.Point(0, 0);
            this.freee.Name = "freee";
            this.freee.Size = new System.Drawing.Size(39, 39);
            this.freee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.freee.TabIndex = 12;
            this.freee.TabStop = false;
            this.freee.Visible = false;
            // 
            // Picthure
            // 
            this.Picthure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picthure.Dock = System.Windows.Forms.DockStyle.Top;
            this.Picthure.Image = global::Library.Properties.Resources.NoBookImage;
            this.Picthure.Location = new System.Drawing.Point(0, 0);
            this.Picthure.Name = "Picthure";
            this.Picthure.Size = new System.Drawing.Size(351, 444);
            this.Picthure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picthure.TabIndex = 6;
            this.Picthure.TabStop = false;
            this.Picthure.Click += new System.EventHandler(this.Picthure_Click);
            // 
            // BookShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(351, 601);
            this.Controls.Add(this.freee);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Picthure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookShow";
            this.Load += new System.EventHandler(this.BookShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.freee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picthure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox Picthure;
        private RoundedPic freee;

        public bool Freee
        {
            set => freee.Visible = value;
        }

        public Image BookPic
        {
            get => Picthure.Image;
            set => Picthure.Image = value;
        }

        public string BookTittle
        {
            get => Tittle.Text;
            set => Tittle.Text = value;
        }

        public string BookAuthor
        {
            get => Author.Text;
            set => Author.Text = value;
        }

        public string BookYear
        {
            get => Year.Text;
            set => Year.Text = value;
        }

        public string BookDescription
        {
            get => Description.Text;
            set => Description.Text = value;
        }

        public string BookButton
        {
            get => Button.Text;
            set => Button.Text = value;
        }

        public bool BookButtonVisible
        {
            set => Button.Visible = value;
        }


    }
}