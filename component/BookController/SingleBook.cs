using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Book;
using Library.screen.Loan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                string booksID = "";

                if (User.USERROLE == ROLE.STUDENT.ToString())
                {
                    DataSql dataSql = new DataSql();
                    SqlDataReader loanList = dataSql.QueryLoan("STUDENTID", StudentInfo.ID.ToString());
                    if (loanList.HasRows)
                    {
                        int i = 0;
                        while (loanList.Read())
                        {
                            booksID += " [" + loanList["BOOKID"].ToString() + "] ";
                            i++;
                        }
                        loanList.Close();
                    }

                    if(!booksID.Contains(BookID.ToString()))
                    {
                        DateTime now = DateTime.Now;

                        IDictionary<string, object> data_ = new Dictionary<string, object>();
                        data_["BOOKID"] = BookID;
                        data_["STUDENTID"] = StudentInfo.ID;
                        data_["DATE"] = now;

                        bool result = dataSql.mutaion("POST", Server.TABLE.LOANLIST.ToString(), data_, "", "");
                        if (result)
                        {
                            MessageBox.Show("Successfull added this book to your book list");
                        }
                    }
                }

                using (BookDetail bookDetail = new BookDetail())
                {
                    bookDetail.TopLevel = true;
                    bookDetail.BookID = BookID;
                    bookDetail.BookPDF = BookPDF;
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
