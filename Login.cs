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
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Main;

namespace Library
{
    public partial class Login : KryptonForm
    {
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        private SqlDataReader data;
        public static string username;
        Boolean show;
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();

            //Development MODE
            //txtUsername.Text = "vothana";
            //txtPassword.Text = "123";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

            String currectDir = this.GetType().Assembly.Location; //get working derectory excecute file
            string[] currectDirSplit = currectDir.Split('\\');
            string dir = string.Join("\\", currectDirSplit.Take(currectDirSplit.Length - 3)); //take out last file

            CurrentPath.CurrentDir = dir + "\\Assets\\"; //Initailize current path
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (show)
            {
                txtPassword.PasswordChar = '\0';
                show = false;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                show = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            data = dataSql.QueryBy(Server.TABLE.STUDENT.ToString(), "USERNAME", txtUsername.Text);
            if (hasData(data))
            {
                if (data.Read())
                {
                    if (data["PASSWORD"].ToString() == txtPassword.Text)
                    {
                        if (data["ROLE"].ToString() == ROLE.ADMIN.ToString())
                        {
                            User.USERROLE = ROLE.ADMIN.ToString();
                        }
                        else
                        {
                            User.USERROLE = ROLE.STUDENT.ToString();
                            StudentInfo.ID = data.GetInt32(0);
                            StudentInfo.studentName = data["FULLNAME"].ToString();
                            StudentInfo.studentPic = data["IMAGE"].ToString();
                            clearDoubleImage();
                        }

                        this.Hide();
                        username = txtUsername.Text;
                        Main main = new Main();
                        main.TopLevel = true;
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        labelWrong.Visible = true;
                    }
                }
            }
            else
            {
                labelWrong.Visible = true;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            labelWrong.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private bool hasData(SqlDataReader data)
        {
            if (data.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clearDoubleImage()
        {
            try
            {
                string profilePic = CurrentPath.CurrentDir + "Students\\" + StudentInfo.ID + "\\";
                string[] filePaths = Directory.GetFiles(profilePic);
                foreach (string filePath in filePaths)
                {
                    if (filePath.Split('\\').Last() != StudentInfo.studentPic)
                    {
                       File.Delete(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
