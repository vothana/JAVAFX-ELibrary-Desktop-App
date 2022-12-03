using Library.Database;
using Library.Entity.ENUM;
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

namespace Library.component.BookController
{
    public partial class SingleBookMG : UserControl
    {
        int BookID;
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        public SingleBookMG(int id)
        {
            InitializeComponent();
            BookID = id;
        }

        private void SingleBookMG_Load(object sender, EventArgs e)
        {
            SqlDataReader data = dataSql.QueryBy(Server.TABLE.BOOK.ToString(), "ID", BookID.ToString());

            while (data.Read())
            {
                string image = data["Image"].ToString();
                string dir = CurrentPath.CurrentDir + "Books\\" + BookID + "\\" + image;

                if (File.Exists(dir))
                {
                    Picthure.Image = new Bitmap(dir);
                }
                Tittle.Text = data["Title"].ToString();
                MessageBox.Show(Tittle.Text);
                Author.Text = data["Author"].ToString();
                Year.Text = data["Year"].ToString();
            }
            data.Close();
            conn.Close();
        }
    }
}
