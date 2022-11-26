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
using Library.screen.About;
using Library.screen.Home;
using Library.screen.Profile;

namespace Library.screen.Main
{
    public partial class Main : KryptonForm
    {
        bool sidebarExpand;
        bool isVisible;
        String role = Login.username;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if(role != "")
            {
                txtProfileName.Text = role;
                if (role.Equals("admin", StringComparison.InvariantCultureIgnoreCase))
                {
                    panelBookMG.Visible = true;
                    panelStudentsMG.Visible = true;
                    panelMyBook.Visible = false;
                    panelMyProfile.Visible = false;
                    panelSpace.Height += 50 * 2 + 26 / 2;
                }
                else
                {
                    panelSpace.Height += 50 * 2 + 26 / 2;
                }
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(aboutForm);
            aboutForm.Show();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(homeForm);
            homeForm.Show();
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

        private void btnGoMyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(profileForm);
            profileForm.Show();
            profileMenu.Visible = false;
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
    }
}
