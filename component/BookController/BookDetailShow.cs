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
        public BookDetailShow()
        {
            InitializeComponent();
        }

        private void BookDetailShow_Load(object sender, EventArgs e)
        {

        }
    }
}
