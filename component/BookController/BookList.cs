using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            
            SqlDataReader data = dataSql.QueryAll(Server.TABLE.BOOK.ToString());

            int colunm = 1, row = 0;
            while (data.Read())
            {
                BookAsList book = new BookAsList();
                int id = data.GetInt32(0);

                book.BookID = id;
                string image = data["Image"].ToString();
                string dir = CurrentPath.CurrentDir + "Books\\" + id + "\\" + image;
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
    }
}
