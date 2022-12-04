using System.Drawing;
using System.Windows.Forms;

namespace Library.component.BookController
{
    partial class BookAsList
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
            this.Box = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Year = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Box.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Controls.Add(this.panel1);
            this.Box.Controls.Add(this.Image);
            this.Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(345, 77);
            this.Box.TabIndex = 1;
            this.Box.Click += new System.EventHandler(this.BookAsList_Click);
            this.Box.MouseLeave += new System.EventHandler(this.Box_MouseLeave);
            this.Box.MouseHover += new System.EventHandler(this.Box_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Author);
            this.panel1.Controls.Add(this.Tittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(77, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 77);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.BookAsList_Click);
            this.panel1.MouseLeave += new System.EventHandler(this.Box_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.Box_MouseHover);
            // 
            // Year
            // 
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year.Font = new System.Drawing.Font("Rayuth HD T2", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(3, 46);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(262, 31);
            this.Year.TabIndex = 3;
            this.Year.Text = "BookYear";
            this.Year.Click += new System.EventHandler(this.BookAsList_Click);
            this.Year.MouseLeave += new System.EventHandler(this.Box_MouseLeave);
            this.Year.MouseHover += new System.EventHandler(this.Box_MouseHover);
            // 
            // Author
            // 
            this.Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author.Font = new System.Drawing.Font("KS Bontey Kro 01", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(3, 23);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(262, 23);
            this.Author.TabIndex = 4;
            this.Author.Text = "BookAuthor";
            this.Author.Click += new System.EventHandler(this.BookAsList_Click);
            this.Author.MouseLeave += new System.EventHandler(this.Box_MouseLeave);
            this.Author.MouseHover += new System.EventHandler(this.Box_MouseHover);
            // 
            // Tittle
            // 
            this.Tittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tittle.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.Tittle.Location = new System.Drawing.Point(3, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(262, 23);
            this.Tittle.TabIndex = 5;
            this.Tittle.Text = "BookTittle";
            this.Tittle.Click += new System.EventHandler(this.BookAsList_Click);
            this.Tittle.MouseLeave += new System.EventHandler(this.Box_MouseLeave);
            this.Tittle.MouseHover += new System.EventHandler(this.Box_MouseHover);
            // 
            // Image
            // 
            this.Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image.Image = global::Library.Properties.Resources.NoBookImage;
            this.Image.Location = new System.Drawing.Point(0, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(77, 77);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 1;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.BookAsList_Click);
            this.Image.MouseLeave += new System.EventHandler(this.Box_MouseLeave);
            this.Image.MouseHover += new System.EventHandler(this.Box_MouseHover);
            // 
            // BookAsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.Box);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BookAsList";
            this.Size = new System.Drawing.Size(345, 77);
            this.Click += new System.EventHandler(this.BookAsList_Click);
            this.Box.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Tittle;


        public int BookID
        {
            set;
            get;
        }

        public Image BookImage
        {
            get => Image.Image;
            set => Image.Image = value;
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
        public string BookTittle
        {
            get => Tittle.Text;
            set => Tittle.Text = value;
        }
    }
}
