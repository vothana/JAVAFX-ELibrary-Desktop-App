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
using ComponentFactory.Krypton.Toolkit;
using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Main;

namespace Library
{
    public partial class Login : KryptonForm
    {
        public static string username;
        Boolean show;
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

            String currectDir = this.GetType().Assembly.Location; //get working derectory excecute file
            string[] currectDirSplit = currectDir.Split('\\');
            string dir = string.Join("\\", currectDirSplit.Take(currectDirSplit.Length - 3)); //take out last file

            CurrentPath.CurrentDir = dir + "\\Assets\\"; //Initailize current path

            //This code only for development mode
            txtUsername.Text = "admin";
           // txtUsername.Text = "student";
            txtPassword.Text = "123";
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (show)
            {
                txtPassword.PasswordChar = '\0';
                show = true;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                show = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (
                txtUsername.Text.Equals("admin", StringComparison.InvariantCultureIgnoreCase) || 
                txtUsername.Text.Equals("student", StringComparison.InvariantCultureIgnoreCase)
                )
            {
                if (txtPassword.Text == "admin" || txtPassword.Text == "123")
                {
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
    }
}
