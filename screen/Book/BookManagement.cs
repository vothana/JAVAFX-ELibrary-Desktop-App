using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Library.component.BookController;
using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Home;

namespace Library.screen.Book
{
    public partial class BookManagement : KryptonForm
    {

        public int BookID;
        public static BookManagement BID;
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        private SqlDataReader data;
        public BookManagement()
        {
            InitializeComponent();
            BID = this;
            
            if(User.USERROLE == ROLE.STUDENT.ToString())
            {
                btnCreateNew.Visible = false;
            }
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            loader();
        }

        public void loader()
        {
            BookList bookList = new BookList();
            bookList.TopLevel = false;
            BookListPanel.Controls.Clear();
            BookListPanel.Controls.Add(bookList);
            bookList.Show();
            showBook();
        }

        public void showBook()
        {
            if(BookID == 0)
            {
                if (User.USERROLE == ROLE.STUDENT.ToString())
                {
                    BookID = dataSql.GetFirstBookLoan(StudentInfo.ID.ToString());
                }
                else
                {
                    BookID = dataSql.GetMinID(Server.TABLE.BOOK.ToString(), "ID");
                }
            }

            if(BookID > 0)
            {
                BookShow bookShow = new BookShow();
                panelBookShow.Controls.Clear();
                data = dataSql.QueryBy(Server.TABLE.BOOK.ToString(), "ID", BookID.ToString());

                while (data.Read())
                {
                    string image = data["Image"].ToString();
                    string dir = CurrentPath.CurrentDir + "Books\\" + BookID + "\\" + image;

                    if (File.Exists(dir))
                    {
                        bookShow.BookPic = new Bitmap(dir);
                    }
                    if (User.USERROLE == ROLE.ADMIN.ToString())
                    {
                        bookShow.BookButton = "EDIT";
                    }
                    bookShow.BookTittle = data["Title"].ToString();
                    bookShow.BookAuthor = data["Author"].ToString();
                    bookShow.BookYear   = data["Year"].ToString();
                    bookShow.BookDescription = data["Desc"].ToString();

                    if(Boolean.Parse(data["STATUS"].ToString()) == true)
                    {
                        bookShow.Freee = true;
                    }

                }
                bookShow.BookID = BookID;
                bookShow.TopLevel = false;
                panelBookShow.Controls.Add(bookShow);
                bookShow.Show();
                data.Close();
                conn.Close();
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            using (CreateBook createBook = new CreateBook())
            {
                createBook.TopLevel = true;
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

    }
}
