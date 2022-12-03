using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Library.component.BookController;
using Library.Database;
using Library.screen.Home;

namespace Library.screen.Book
{
    public partial class BookManagement : KryptonForm
    {
        public BookManagement()
        {
            InitializeComponent();
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            BookShow();
        }

        public void BookShow()
        {
            BookList bookList = new BookList();
            bookList.TopLevel = false;
            BookListPanel.Controls.Clear();
            BookListPanel.Controls.Add(bookList);
            bookList.Show();

            DataSql dataSql = new DataSql();
            loadShow(dataSql.GetMinID(Server.TABLE.BOOK.ToString()));
        }

        public void loadShow(int bookID)
        {
            BookShow bookShow = new BookShow();
            bookShow.BookID = bookID;
            bookShow.TopLevel = false;
            panelBookShow.Controls.Clear();
            panelBookShow.Controls.Add(bookShow);
            bookShow.Show();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            using (CreateBook createBook = new CreateBook())
            {
                createBook.TopLevel = true;
                createBook.BookID = "12";
                createBook.ShowDialog();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BookList bookList = new BookList();
                bookList.TopLevel = false;
                bookList.SearchText = txtSearch.Text;
                txtSearch.SelectAll();
                txtSearch.Focus();
                BookListPanel.Controls.Clear();
                BookListPanel.Controls.Add(bookList);
                bookList.Show();
            }
        }
    }
}
