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

namespace Library.component.BookController
{
    public partial class SingleBookList : KryptonForm
    {
        public SingleBookList()
        {
            InitializeComponent();
        }

        private void SingleBookList_Load(object sender, EventArgs e)
        {
            int c = 1, r = 0;
            for(int i = 0; i < 20; i++)
            {
                SingleBook singleBook = new SingleBook();
                singleBook.BookButton = "READ";
                TableBook.Controls.Add(singleBook, c, r);
                c++;
                if(c > 4)
                {
                    c = 1;
                    r++;
                }
            }
        }
    }
}
