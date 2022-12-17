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
using Library.component.BookController;
using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Book;
using Library.screen.Main;

namespace Library.screen.Loan
{
    public partial class LoanForm : KryptonForm
    {
        public int BookID;
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        private SqlDataReader data;
        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            showBook();
            studentInfo();
        }

        private void studentInfo()
        {
            data = dataSql.QueryBy(Server.TABLE.STUDENT.ToString(), "ID", StudentInfo.ID.ToString());
            if (data.HasRows)
            {
                if (data.Read())
                {
                    txtName.Text = data["FULLNAME"].ToString();
                    txtPhoneNumber.Text = data["PHONE"].ToString();
                    txtDepartMent.Text = data["DEPARTMENT"].ToString();
                    txtSchool.Text = data["SCHOOL"].ToString();
                    txtAddress.Text = data["ADDRESS"].ToString();

                    string profilePic = CurrentPath.CurrentDir + "Students\\" + StudentInfo.ID + "\\" + StudentInfo.studentPic;
                    if (File.Exists(profilePic))
                    {
                        profileImage.Image = new Bitmap(profilePic);
                    }
                }
            }
            data.Close();
            conn.Close();
        }

        private void showBook()
        {
            string Pic = CurrentPath.CurrentDir + "Students\\" + StudentInfo.ID + "\\" + StudentInfo.studentPic;
            if (File.Exists(Pic))
            {
                profileImage.Image = new Bitmap(Pic);
            }

            if (BookID > 0)
            {
                BookShow bookShow = new BookShow();
                panelBookShow.Controls.Clear();
                data = dataSql.QueryBy(Server.TABLE.BOOK.ToString(), "ID", BookID.ToString());

                while (data.Read())
                {
                    string image = data["IMAGE"].ToString();
                    string dir = CurrentPath.CurrentDir + "Books\\" + BookID + "\\" + image;

                    if (File.Exists(dir))
                    {
                        bookShow.BookPic = new Bitmap(dir);
                    }
                    bookShow.BookButtonVisible = false;
                    bookShow.BookTittle = data["TITLE"].ToString();
                    bookShow.BookAuthor = data["AUTHOR"].ToString();
                    bookShow.BookYear = data["YEAR"].ToString();
                    bookShow.BookDescription = data["DESC"].ToString();

                    if (Boolean.Parse(data["STATUS"].ToString()) == true)
                    {
                        bookShow.Freee = true;
                    }

                }
                bookShow.BookID = BookID;
                bookShow.TopLevel = false;
                panelBookShow.Controls.Add(bookShow);
                bookShow.Show();
                data.Close();
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            IDictionary<string, object> data = new Dictionary<string, object>();
            data["BOOKID"] = BookID;
            data["STUDENTID"] = StudentInfo.ID;
            data["DATE"] = now;

            bool result = dataSql.mutaion("POST", Server.TABLE.LOANLIST.ToString(), data, "", "");
            if (result)
            {
                MessageBox.Show("Successfull you can read this book");
                this.Close();
            }
            else
                MessageBox.Show("Sorry ! Please try again later");
        }
    }
}
