using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.component.BookController;
using Library.Entity.ENUM;
using PdfiumViewer;

namespace Library.screen.Book
{
    public partial class BookDetail : Form
    {
        public int BookID;
        public string BookPDF;
        public BookDetail()
        {
            InitializeComponent();
            btnClose.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pdf.Dock = DockStyle.Fill;
            PanelDetail.Dock = DockStyle.None;
            PanelDetail.Visible = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            pdf.Dock = DockStyle.Top;
            PanelDetail.Dock = DockStyle.Bottom;
            PanelDetail.Visible = true;
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            String filePDF = CurrentPath.CurrentDir + "PDF\\" + BookID + "\\" + BookPDF;

            if (File.Exists(filePDF))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(filePDF);
                var stream = new System.IO.MemoryStream(bytes);
                PdfDocument pdfDocument = PdfDocument.Load(stream);
                pdf.Document = pdfDocument;
            }
            else
            {
                MessageBox.Show("This book has no PDF");
                pdf.Visible = false;
            }

            BookDetailShow bookDetailShow = new BookDetailShow();
            bookDetailShow.TopLevel = false;
            bookDetailShow.BookID = BookID;
            PanelDetail.Controls.Clear();
            PanelDetail.Controls.Add(bookDetailShow);
            bookDetailShow.Show();
        }
    }
}
