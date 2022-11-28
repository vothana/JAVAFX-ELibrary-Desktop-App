using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Library.component;
using Library.component.PicView;
using Library.component.UploadImage;
using Library.Entity.ENUM;

namespace Library.screen.Profile
{
    public partial class ProfileForm : KryptonForm
    {
        Rounded rounded = new Rounded();
        RoundImageCorner round = new RoundImageCorner();
        string dir = CurrentPath.CurrentDir + "\\Assets\\Students\\";
        string fileName = "AAA.jpg";
        public ProfileForm()
        {
            InitializeComponent();
            txtID.Text = "12"; //Testing
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            setProfilePic();
        }

        private void setProfilePic()
        {
            string imagePath = dir + txtID.Text + "\\" + fileName;
            if (File.Exists(imagePath))
            {
                Bitmap bmp = new Bitmap(imagePath);
                profilePic.Image = bmp;
            }
            else
            {
                profilePic.Image = null;
                profilePic.BackColor = Color.Beige;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (UploadImgForm uploadImgForm = new UploadImgForm())
            {
                uploadImgForm.TheID = txtID.Text;
                uploadImgForm.Upload = EnumCode.UPLOAD.PDF.ToString();
                uploadImgForm.ShowDialog();
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int xAxis = 450;
            int xAxisMax = 490;

            if(btnSwitch.Location.X == xAxis)
            {
                for (int i = 0; i <= 8; i++)
                {
                    xAxis += 5;
                    btnSwitch.Location = new Point(xAxis, 164);
                    Thread.Sleep(10);
                    if (xAxis == xAxisMax)
                        break;
                }
                EnableEdit();
            }
            else
            {
                for (int i = 0; i <= 8; i++)
                {
                    xAxisMax -= 5;
                    btnSwitch.Location = new Point(xAxisMax, 164);
                    Thread.Sleep(10);
                    if (xAxisMax == xAxis)
                        break;
                }
                EnableEdit();
            }
                
        }

        private void EnableEdit()
        {
            if (btnSwitch.Location.X == 490)
            {
                btnSaveData.Enabled = true;
                btnUpdatePassword.Enabled = true;

                txtFullName.Enabled = true;
                groubGender.Enabled = true;
                txtDob.Enabled = true;
                txtPhonNumber.Enabled = true;
                txtDepartment.Enabled = true;
                txtSchoolName.Enabled = true;
                txtAddress.Enabled = true;

                txtCurrentPassword.Enabled = true;
                txtnewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                btnSaveData.Enabled = false;
                btnUpdatePassword.Enabled = false;

                txtFullName.Enabled = false;
                groubGender.Enabled = false;
                txtDob.Enabled = false;
                txtPhonNumber.Enabled = false;
                txtDepartment.Enabled = false;
                txtSchoolName.Enabled = false;
                txtAddress.Enabled = false;

                txtCurrentPassword.Enabled = false;
                txtnewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
        }

        private void profilePic_Click(object sender, EventArgs e)
        {
            using (ImageViewer imageViewer = new ImageViewer())
            {
                imageViewer.ImagePath = txtImagePath.Text;
                imageViewer.ShowDialog();
            }
        }
    }
}
