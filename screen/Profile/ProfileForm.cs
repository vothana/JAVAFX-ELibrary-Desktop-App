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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using Library.component;
using Library.component.PicView;
using Library.component.Popup;
using Library.component.UploadImage;
using Library.Database;
using Library.Entity.ENUM;
using Library.screen.Book;

namespace Library.screen.Profile
{
    public partial class ProfileForm : KryptonForm
    {
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        private SqlDataReader data;
        private string profilePic;
        private string currentPass;
        Boolean show;
        public ProfileForm()
        {
            InitializeComponent();
            profilePic = CurrentPath.CurrentDir + "Students\\" + StudentInfo.ID + "\\" + StudentInfo.studentPic;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            studentInfo();
        }

        private void studentInfo()
        {
            data = dataSql.QueryBy(Server.TABLE.STUDENT.ToString(), "ID", StudentInfo.ID.ToString());
            if (data.HasRows)
            {
                if (data.Read())
                {
                    txtFullName.Text = data["FULLNAME"].ToString();
                    txtFemale.Checked = (data["GENDER"].ToString() == "Female") ? true : false;
                    txtMale.Checked = (data["GENDER"].ToString() == "Male") ? true : false;
                    DOB = data["DOB"].ToString();
                    txtPhonNumber.Text = data["PHONE"].ToString();
                    txtDepartment.Text = data["DEPARTMENT"].ToString();
                    txtSchoolName.Text = data["SCHOOL"].ToString();
                    txtAddress.Text = data["ADDRESS"].ToString();

                    txtUsername.Text = data["USERNAME"].ToString();
                    currentPass = data["PASSWORD"].ToString();

                    if (File.Exists(profilePic))
                    {
                        profileImage.Image = new Bitmap(profilePic);
                    }
                }
            }
            data.Close();
            conn.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            profileImage.Image = null;
            using (UploadImgForm uploadImgForm = new UploadImgForm())
            {
                uploadImgForm.TheID = StudentInfo.ID.ToString();
                uploadImgForm.Upload = EnumCode.UPLOAD.STUDENT.ToString();
                uploadImgForm.ShowDialog();
                if(uploadImgForm.ImageName() == null)
                {
                    try
                    {
                        profileImage.Image = new Bitmap(profilePic);
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    profilePic = CurrentPath.CurrentDir + "Students\\" + StudentInfo.ID + "\\" + uploadImgForm.ImageName();
                    if (File.Exists(profilePic))
                    {
                        profileImage.Image = new Bitmap(profilePic);
                        update();
                    }
                }
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            slider();
        }

        private void slider()
        {
            int xAxis = 450;
            int xAxisMax = 490;

            if (btnSwitch.Location.X == xAxis)
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

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Contains(" "))
            {
                using (ConfirmBox confirmBox = new ConfirmBox())
                {
                    confirmBox.Tittle = "Username cannot contain space";
                    confirmBox.ButtonConfirm = "OK";
                    confirmBox.ButtonCancelVisible = false;
                    confirmBox.ShowDialog();
                    if (confirmBox.DialogResult == DialogResult.Yes)
                    {
                        txtUsername.SelectAll();
                        txtUsername.Focus();
                    }
                }
            }
            else
            {
                if (checkPassword())
                {
                    update();
                    slider();
                }
            }
        }


        private void btnSaveData_Click(object sender, EventArgs e)
        {
            update();
            slider();
        }

        private void update()
        {
            IDictionary<string, object> data = formData();
            bool result = dataSql.mutaion("PUT", Server.TABLE.STUDENT.ToString(), data, "ID", StudentInfo.ID.ToString());
            if (result)
            {
                MessageBox.Show("Success update");
                studentInfo();

                txtCurrentPassword.Text = "";
                txtnewPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
                MessageBox.Show("Cannot update");
        }

        private IDictionary<string, object> formData()
        {
            IDictionary<string, object> data = new Dictionary<string, object>();
            data["FULLNAME"] = txtFullName.Text;
            data["GENDER"] = txtFemale.Checked ? "Female" : "Male";
            data["DOB"] = txtDob.Text;
            data["PHONE"] = txtPhonNumber.Text;
            data["ADDRESS"] = txtAddress.Text;
            data["DEPARTMENT"] = txtDepartment.Text;
            data["SCHOOL"] = txtSchoolName.Text;
            data["IMAGE"] = profilePic.Split('\\').Last();
            data["USERNAME"] = txtUsername.Text;
            data["PASSWORD"] = (txtnewPassword.Text == "") ? currentPass : txtnewPassword.Text;
            data["ROLE"] = EnumCode.ROLE.STUDENT.ToString();

            return data;
        }

        private bool checkPassword()
        {
            if(txtCurrentPassword.Text != currentPass)
            {
                using (ConfirmBox confirmBox = new ConfirmBox())
                {
                    confirmBox.Tittle = "Wrong password";
                    confirmBox.ButtonConfirm = "OK";
                    confirmBox.ButtonCancelVisible = false;
                    confirmBox.FontColor = Color.Red;
                    confirmBox.ShowDialog();
                    if (confirmBox.DialogResult == DialogResult.Yes)
                    {
                        txtCurrentPassword.Text = "";
                        txtCurrentPassword.Focus();
                    }
                }
                return false;
            }
            else
            {
                if(txtnewPassword.Text == currentPass || txtnewPassword == txtUsername)
                {
                    using (ConfirmBox confirmBox = new ConfirmBox())
                    {
                        confirmBox.Tittle = "Password cannot the same to username or old !";
                        confirmBox.ButtonConfirm = "OK";
                        confirmBox.ButtonCancelVisible = false;
                        confirmBox.ShowDialog();
                        if (confirmBox.DialogResult == DialogResult.Yes)
                        {
                            txtnewPassword.Text = "";
                            txtConfirmPassword.Text = "";
                            txtnewPassword.Focus();
                        }
                    }
                    return false;
                }
                else
                {
                    if(txtnewPassword.Text != txtConfirmPassword.Text)
                    {
                        using (ConfirmBox confirmBox = new ConfirmBox())
                        {
                            confirmBox.Tittle = "Wrong password";
                            confirmBox.ButtonConfirm = "OK";
                            confirmBox.ButtonCancelVisible = false;
                            confirmBox.FontColor = Color.Red;
                            confirmBox.ShowDialog();
                            if (confirmBox.DialogResult == DialogResult.Yes)
                            {
                                txtnewPassword.Text = "";
                                txtConfirmPassword.Text = "";
                                txtnewPassword.Focus();
                            }
                        }
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
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

                txtUsername.Enabled = true;
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

                txtUsername.Enabled = false;
                txtCurrentPassword.Enabled = false;
                txtnewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
        }

        private void profilePic_Click(object sender, EventArgs e)
        {
/*            using (ImageViewer imageViewer = new ImageViewer())
            {
                imageViewer.ImagePath = txtImagePath.Text;
                imageViewer.ShowDialog();
            }*/
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (show)
            {
                txtCurrentPassword.PasswordChar = '\0';
                txtnewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
                show = false;
            }
            else
            {
                txtCurrentPassword.PasswordChar = '*';
                txtnewPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                show = true;
            }
            
        }
    }
}
