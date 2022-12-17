using Library.screen.Book;
using Library.screen.Loan;
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
            if(ButtonRead.Text == "READ")
            {
                using (BookDetail bookDetail = new BookDetail())
                {
                    bookDetail.TopLevel = true;
                    bookDetail.BookID = BookID;
                    bookDetail.ShowDialog();
                }
            }
            else
            {
                using (LoanForm loanForm = new LoanForm())
                {
                    loanForm.TopLevel = true;
                    loanForm.BookID = BookID;
                    loanForm.ShowDialog();
                }
            }
            
        }

        private void SingleBook_Load(object sender, EventArgs e)
        {
            if (ButtonRead.Text != "READ")
            {
                ButtonRead.BackColor = Color.FromArgb(255, 0, 24, 69);
            }
        }
    }
}
