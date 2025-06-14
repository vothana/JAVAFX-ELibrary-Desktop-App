﻿using System;
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
using Library.screen.Book;

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
            loadData();
        }

        public void loadData()
        {

            SqlDataReader data;
            SqlDataReader loanList;

            IDictionary<int, int> bookLoaned = new Dictionary<int, int>();

            if (User.USERROLE == ROLE.STUDENT.ToString())
            {
                loanList = dataSql.QueryLoan("STUDENTID", StudentInfo.ID.ToString());
                if (loanList.HasRows)
                {
                    int i = 0;
                    while (loanList.Read())
                    {
                        bookLoaned[i] = Int32.Parse(loanList["BOOKID"].ToString());
                        i++;
                    }
                    loanList.Close();
                }
            }

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
                singleBook.BookPDF = data["PDF"].ToString();

                string image = data["Image"].ToString();
                string imagePath = CurrentPath.CurrentDir + "Books\\" + id + "\\" + image;
                string dir = CurrentPath.CurrentDir + "Books\\" + id + "\\";

                //We try to search image in the directory
                //if image presented, we will asign image to book
                //if image not presented, we will delete the directory
                //if image presented, but has two or more file in the same derectory
                //we will delete another image which didn't match with our database

                if (File.Exists(imagePath))
                {
                    singleBook.BookImage = new Bitmap(imagePath);
                    string[] files = Directory.GetFiles(dir);
                    if (files.Length > 0)
                    {
                        foreach (string img in files)
                        {
                            if(img != imagePath)
                            {
                                try { File.Delete(img); } //Somtime image not being deleted during go to home page . Until youopen the program again
                                catch (IOException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }
                    }
                }
                else if (Directory.Exists(dir))
                {
                    try { Directory.Delete(dir, true); }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (User.USERROLE == ROLE.STUDENT.ToString())
                {
                    if (!Boolean.Parse(data["STATUS"].ToString()))
                    {
                        if(bookLoaned.Count > 0)
                        {
                            foreach (KeyValuePair<int, int> item in bookLoaned)
                            {
                                if (item.Value == id)
                                {
                                    singleBook.BookButton = "READ";
                                    break;
                                }
                                else
                                {
                                    singleBook.BookButton = "BORROW"; //this will loop [Bad Performance]
                                }
                            }
                        }
                        else
                        {
                            singleBook.BookButton = "BORROW";
                        }
                    }
                    else
                    {
                        singleBook.BookButton = "READ";
                    }
                }
                else
                {
                    singleBook.BookButton = "READ";
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
