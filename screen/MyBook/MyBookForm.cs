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
using Library.screen.Book;

namespace Library.screen.MyBook
{
    public partial class MyBookForm : KryptonForm
    {
        public MyBookForm()
        {
            InitializeComponent();
        }

        private void MyBookForm_Load(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(bookManagement);
            bookManagement.Show();
        }
    }
}
