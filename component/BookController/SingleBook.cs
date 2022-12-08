using Library.screen.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.component.BookController
{
    public partial class SingleBook : UserControl
    {
        public SingleBook()
        {
            InitializeComponent();
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            using(BookDetail bookDetail = new BookDetail())
            {
                bookDetail.TopLevel = true;
                bookDetail.BookID = BookID;
                bookDetail.ShowDialog();
            }
        }
    }
}
