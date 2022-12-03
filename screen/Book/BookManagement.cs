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
            SingleBookMGForm frm = new SingleBookMGForm();
            frm.BookID = dataSql.GetMinID(Server.TABLE.BOOK.ToString());
            frm.TopLevel = false;
            panelBookShow.Controls.Clear();
            panelBookShow.Controls.Add(frm);
            frm.Show();
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

    }
}
