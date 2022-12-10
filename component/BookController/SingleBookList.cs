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
    public partial class SingleBookList : KryptonForm
    {
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        public string SearchText;
        public SingleBookList()
        {
            InitializeComponent();
        }

        private void SingleBookList_Load(object sender, EventArgs e)
        {


            SqlDataReader data, loan;

            if (SearchText == null)
            {
                data = dataSql.QueryAll(Server.TABLE.BOOK.ToString());
               // hasData(data);
            }
            else
            {
                data = dataSql.Search(Server.TABLE.BOOK.ToString(), "TITLE", SearchText);
                //hasData(data);
            }

            int colunm = 1, row = 0;
            while (data.Read())
            {
                SingleBook singleBook = new SingleBook();
                int id = data.GetInt32(0);

                singleBook.BookID = id;
                string image = data["Image"].ToString();
                string dir = CurrentPath.CurrentDir + "Books\\" + id + "\\" + image;
                if (File.Exists(dir))
                {
                    singleBook.BookImage = new Bitmap(dir);
                }

                if (User.USERROLE == ROLE.ADMIN.ToString())
                {
                    singleBook.BookButton = "READ";
                }
                else
                {
                    //an = dataSql.QueryBy(Server.TABLE.LOANLIST.ToString(), "ID", id.ToString());
                    singleBook.BookButton = "BORROW";
                }
                TableBook.Controls.Add(singleBook, colunm, row);
                colunm++;
                if (colunm > 4)
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
