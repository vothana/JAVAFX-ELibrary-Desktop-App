using System.Drawing;

namespace Library.component.BookController
{
    partial class SingleBookMG
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
            this.Picthure = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picthure)).BeginInit();
            this.SuspendLayout();
            // 
            // Picthure
            // 
            this.Picthure.Dock = System.Windows.Forms.DockStyle.Top;
            this.Picthure.Image = global::Library.Properties.Resources.SampleBook;
            this.Picthure.Location = new System.Drawing.Point(0, 0);
            this.Picthure.Name = "Picthure";
            this.Picthure.Size = new System.Drawing.Size(350, 444);
            this.Picthure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picthure.TabIndex = 0;
            this.Picthure.TabStop = false;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(0, 514);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(350, 43);
            this.Description.TabIndex = 1;
            this.Description.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sit amet diam " +
    "ultricies eros condimentum maximus sed at purus. Donec posuere ex sit amet diam " +
    "tempor feugiat.";
            // 
            // Author
            // 
            this.Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author.Font = new System.Drawing.Font("KS Bontey Kro 01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(3, 472);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(344, 23);
            this.Author.TabIndex = 3;
            this.Author.Text = "Nicholas S. William";
            // 
            // Tittle
            // 
            this.Tittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tittle.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.Tittle.Location = new System.Drawing.Point(3, 447);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(347, 23);
            this.Tittle.TabIndex = 4;
            this.Tittle.Text = "Java For Web Application";
            // 
            // Year
            // 
            this.Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year.Font = new System.Drawing.Font("KS Bontey Kro 01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(3, 493);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(344, 23);
            this.Year.TabIndex = 3;
            this.Year.Text = "2018";
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.Color.White;
            this.Button.Location = new System.Drawing.Point(0, 560);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(350, 40);
            this.Button.TabIndex = 5;
            this.Button.Text = "button1";
            this.Button.UseVisualStyleBackColor = false;
            // 
            // SingleBookMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Picthure);
            this.Name = "SingleBookMG";
            this.Size = new System.Drawing.Size(350, 600);
            this.Load += new System.EventHandler(this.SingleBookMG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picthure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picthure;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button Button;

        public Image pic
        {
            get => Picthure.Image;
            set => Picthure.Image = value;
        }
        public string BookTittle
        {
            get => Tittle.Text;
            set => Tittle.Text = value;
        }
    }
}
