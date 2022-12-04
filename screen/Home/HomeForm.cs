using Library.component.BookController;
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

namespace Library.screen.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            SingleBookList singleBookList = new SingleBookList();
            singleBookList.TopLevel = false;
            PanelBook.Controls.Clear();
            PanelBook.Controls.Add(singleBookList);
            singleBookList.Show();
        }
    }
}
