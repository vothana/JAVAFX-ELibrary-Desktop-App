using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Book;
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

namespace Library.component.BookController
{
    public partial class BookDetailShow : Form
    {
        public int BookID;
        public static BookManagement BID;
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        private SqlDataReader data;
        public BookDetailShow()
        {
            InitializeComponent();
        }

        private void BookDetailShow_Load(object sender, EventArgs e)
        {
            if (BookID > 0)
            {
                BookShow bookShow = new BookShow();
                PanelBookShow.Controls.Clear();
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
                        bookShow.BookButton = "Edit";
                    }
                    bookShow.BookTittle = data["Title"].ToString();
                    bookShow.BookAuthor = data["Author"].ToString();
                    bookShow.BookYear = data["Year"].ToString();

                }
                bookShow.BookID = BookID;
                bookShow.TopLevel = false;
                PanelBookShow.Controls.Add(bookShow);
                bookShow.Show();
                data.Close();
                conn.Close();
            }

        }
    }
}
