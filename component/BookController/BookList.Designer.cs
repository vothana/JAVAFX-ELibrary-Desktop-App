namespace Library.component.BookController
{
    partial class BookList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bookAsList1 = new Library.component.BookController.BookAsList();
            this.bookAsList2 = new Library.component.BookController.BookAsList();
            this.bookAsList3 = new Library.component.BookController.BookAsList();
            this.bookAsList4 = new Library.component.BookController.BookAsList();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bookAsList1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bookAsList2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bookAsList3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bookAsList4, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 164);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bookAsList1
            // 
            this.bookAsList1.Location = new System.Drawing.Point(15, 3);
            this.bookAsList1.Name = "bookAsList1";
            this.bookAsList1.Size = new System.Drawing.Size(334, 71);
            this.bookAsList1.TabIndex = 0;
            // 
            // bookAsList2
            // 
            this.bookAsList2.Location = new System.Drawing.Point(355, 3);
            this.bookAsList2.Name = "bookAsList2";
            this.bookAsList2.Size = new System.Drawing.Size(334, 71);
            this.bookAsList2.TabIndex = 1;
            // 
            // bookAsList3
            // 
            this.bookAsList3.Location = new System.Drawing.Point(15, 80);
            this.bookAsList3.Name = "bookAsList3";
            this.bookAsList3.Size = new System.Drawing.Size(334, 77);
            this.bookAsList3.TabIndex = 2;
            // 
            // bookAsList4
            // 
            this.bookAsList4.Location = new System.Drawing.Point(355, 80);
            this.bookAsList4.Name = "bookAsList4";
            this.bookAsList4.Size = new System.Drawing.Size(334, 77);
            this.bookAsList4.TabIndex = 3;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(705, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookList";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BookAsList bookAsList1;
        private BookAsList bookAsList2;
        private BookAsList bookAsList3;
        private BookAsList bookAsList4;
    }
}