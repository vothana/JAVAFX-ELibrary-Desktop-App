using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Library.component.BookController;
using Library.component.Popup;
using Library.Entity.ENUM;
using Library.screen.About;
using Library.screen.Book;
using Library.screen.Home;
using Library.screen.MyBook;
using Library.screen.Profile;
using Library.screen.Student;

namespace Library.screen.Main
{
    public partial class Main : KryptonForm
    {
        bool sidebarExpand;
        bool isVisible;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Home();
            if (User.USERROLE == ROLE.ADMIN.ToString())
            {
                txtProfileName.Text = ROLE.ADMIN.ToString();
                btnGoMyProfile.Visible = false;
                panelBookMG.Visible = true;
                panelStudentsMG.Visible = true;
                panelMyBook.Visible = false;
                panelMyProfile.Visible = false;
                panelSpace.Height += 50 * 2 + 26 / 2;
            }
            else
            {
                string profilePic = CurrentPath.CurrentDir + "Students\\" + StudentInfo.ID + "\\" + StudentInfo.studentPic;
                if (File.Exists(profilePic)) {
                    btnProfilePic.Image = new Bitmap(profilePic);
                }
                txtProfileName.Text = StudentInfo.studentName;
                panelSpace.Height += 50 * 2 + 26 / 2;
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
            this.Close();
        }
        public static void OpenLoginForm()
        {
            Application.Run(new Login());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            using(ConfirmBox confirmBox = new ConfirmBox())
            {
                confirmBox.Tittle = "Are you sure ?";
                confirmBox.ButtonConfirm = "Exit";
                confirmBox.ShowDialog();
                if(confirmBox.DialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer.Stop();

                }
            }
        }
        private void isSidebarExpanded()
        {
            if (sidebarExpand)
            {
                timer.Start();
                sideBar.Width -= 10;
                if (sideBar.Width <= sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer.Stop();
                }
            }
        }

        private void btnProfilePic_Click(object sender, EventArgs e)
        {
            if (isVisible)
            {
                profileMenu.Visible = false;
                isVisible = false;
            }
            else
            {
                profileMenu.Visible = true;
                isVisible = true;
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(aboutForm);
            aboutForm.Show();
            isSidebarExpanded();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home();
        }
        private void Home()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(homeForm);
            homeForm.Show();
            isSidebarExpanded();
        }
        private void btnBookMG_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(bookManagement);
            bookManagement.Show();
            profileMenu.Visible = false;
            isSidebarExpanded();
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            MyBookForm myBookForm = new MyBookForm();
            myBookForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(myBookForm);
            myBookForm.Show();
            profileMenu.Visible = false;
            isSidebarExpanded();
        }

        private void OpenProfileForm()
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(profileForm);
            profileForm.Show();
            profileMenu.Visible = false;
            isSidebarExpanded();
        }
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            OpenProfileForm();
        }

        private void btnGoMyProfile_Click(object sender, EventArgs e)
        {
            OpenProfileForm();
        }

        private void txtProfileName_Click(object sender, EventArgs e)
        {
            OpenProfileForm();
        }

        private void btnStudentMG_Click(object sender, EventArgs e)
        {
            studentmg stumg = new studentmg();
            stumg.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(stumg);
            stumg.Show();
            profileMenu.Visible = false;
            isSidebarExpanded();
        }
    }
}
