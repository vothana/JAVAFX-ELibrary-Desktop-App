﻿using System;
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
using Library.Database;
using Library.Entity.ENUM;

namespace Library.component.BookController
{
    public partial class BookList : KryptonForm
    {
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        public string SearchText;
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            SqlDataReader data;

            if(SearchText == null)
            {
                if (User.USERROLE == ROLE.STUDENT.ToString())
                {
                    data = dataSql.QueryLoan("STUDENTID", StudentInfo.ID.ToString());
                    hasData(data);
                }
                else
                {
                    data = dataSql.QueryAll(Server.TABLE.BOOK.ToString());
                    hasData(data);
                }
            }
            else
            {
                if(User.USERROLE == ROLE.STUDENT.ToString())
                {
                    data = dataSql.SearchLoan("TITLE", SearchText);
                    hasData(data);
                }
                else
                {
                    data = dataSql.Search(Server.TABLE.BOOK.ToString(), "TITLE", SearchText);
                    hasData(data);
                }
            }

            int colunm = 1, row = 0;
            while (data.Read())
            {
                BookAsList book = new BookAsList();
                int bookId;
                if (User.USERROLE == ROLE.STUDENT.ToString())
                {
                    bookId = data.GetInt32(1); //BookID
                }
                else
                {
                    bookId = data.GetInt32(0);
                }

                book.BookID = bookId;
                string image = data["Image"].ToString();
                string dir = CurrentPath.CurrentDir + "Books\\" + bookId + "\\" + image;
                if (File.Exists(dir))
                {
                    book.BookImage = new Bitmap(dir);
                }
                book.BookTittle = data["Title"].ToString();
                book.BookAuthor = data["Author"].ToString();
                book.BookYear = data["Year"].ToString();
                TablePanel.Controls.Add(book, colunm, row);
                colunm++;
                if(colunm > 2)
                {
                    colunm = 1;
                    row++;
                }
            }

            data.Close();
            conn.Close();
        }

        private void hasData(SqlDataReader data)
        {
            if (!data.HasRows)
            {
                noData.Visible = true;
            }
            else
            {
                noData.Visible = false;
            }
        }



    }
}
