using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Book;

namespace Library.component.BookController
{
    public partial class BookShow : KryptonForm
    {
        public int BookID;
        public BookShow()
        {
            InitializeComponent();
        }

        private void BookShow_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            onclicked();
        }

        private void Picthure_Click(object sender, EventArgs e)
        {
            onclicked();
        }

        private void onclicked()
        {
            if (Button.Text == "EDIT")
            {
                using (CreateBook createBook = new CreateBook())
                {
                    createBook.TopLevel = true;
                    createBook.BookID = BookID;
                    createBook.ShowDialog();
                }
            }
            else
            {
                BookDetail bookDetail = new BookDetail();
                bookDetail.BookID = BookID;
                bookDetail.TopLevel = true;
                bookDetail.ShowDialog();
            }
        }
    }
}
