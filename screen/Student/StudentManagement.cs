using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using Library.component.Popup;
using Library.Entity.ENUM;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static Library.Entity.ENUM.EnumCode;
using Image = System.Drawing.Image;

namespace Library.screen.Student
{
    public partial class studentmg : KryptonForm
    {
        private string targetPath;
        private string sourcePath;
        SqlConnection conn = Server.Connection();
        public studentmg()
        {
            InitializeComponent();
        }

        private void studentmg_Load(object sender, EventArgs e)
        {
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            GetData();
        }

        private void GetData()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(" Select * from STUDENT", conn);
            da.Fill(dt);
            datagridstudent.DataSource = dt;
            datagridstudent.Columns[0].HeaderText = "StudentID";
            datagridstudent.Columns[1].HeaderText = "FullName";
            datagridstudent.Columns[2].HeaderText = "GENDER";
            datagridstudent.Columns[3].HeaderText = "DOB";
            datagridstudent.Columns[4].HeaderText = "PHONE";
            datagridstudent.Columns[5].HeaderText = "ADDRESS";
            datagridstudent.Columns[6].HeaderText = "DEPARTMENT";
            datagridstudent.Columns[7].HeaderText = "SCHOOL";

            datagridstudent.Columns["ID"].Width = 50;
            datagridstudent.Columns["FULLNAME"].Width = 100;
            datagridstudent.Columns["GENDER"].Width = 100;
            datagridstudent.Columns["DOB"].Width = 100;
            datagridstudent.Columns["PHONE"].Width = 100;
            datagridstudent.Columns["ADDRESS"].Width = 150;
            datagridstudent.Columns["DEPARTMENT"].Width = 100;
            datagridstudent.Columns["SCHOOL"].Width = 100;

            datagridstudent.Columns["IMAGE"].Visible = false;
            datagridstudent.Columns["PASSWORD"].Visible = false;

            datagridstudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            datagridstudent.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Romen", 7, FontStyle.Bold);
        }

        private void txtselectimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png; *.gif)|*.jpg;*.png; *.gif";
            try {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    roundedPic1.Image = Image.FromFile(opf.FileName);
                    roundedPic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    string[] split1 = opf.FileName.Split('\\');
                    string fileName = split1.Last();

                    sourcePath = opf.FileName;
                    txtpfpicname.Text = fileName;
                }
            } catch(Exception ex)
            { Console.WriteLine(ex.Message); };
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            datagridstudent.ClearSelection();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;

            txtid.Clear();
            txtfullname.Clear();
            txtgender.Clear();
            txtaddress.Clear();
            txtdepartment.Clear();  
            txtdob.Clear();
            txtpfpicname.Clear();
            txtphonenumber.Clear();
            txtschool.Clear();
            txtpfpicname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            roundedPic1.Image = Library.Properties.Resources.NUM_Logo;

            txtid.Enabled = true;
        }

        private void datagridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow SelectRow = datagridstudent.Rows[index];

            targetPath = CurrentPath.CurrentDir + "Students\\" + SelectRow.Cells[0].Value.ToString() + "\\" + SelectRow.Cells[8].Value.ToString();
            try
            {
                txtid.Enabled = false;
                lblStudentID.Focus();
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
                btnsave.Enabled = false;
                datagridstudent.ClearSelection();

                if (File.Exists(targetPath))
                {
                    roundedPic1.Image = new Bitmap(targetPath);
                }

                txtid.Text = SelectRow.Cells[0].Value.ToString();
                txtfullname.Text = SelectRow.Cells[1].Value.ToString();
                txtgender.Text = SelectRow.Cells[2].Value.ToString();
                txtdob.Text = SelectRow.Cells[3].Value.ToString();
                txtphonenumber.Text = SelectRow.Cells[4].Value.ToString();
                txtaddress.Text = SelectRow.Cells[5].Value.ToString();
                txtdepartment.Text = SelectRow.Cells[6].Value.ToString();
                txtschool.Text = SelectRow.Cells[7].Value.ToString();
                txtpfpicname.Text = SelectRow.Cells[8].Value.ToString();
                txtUsername.Text = SelectRow.Cells[9].Value.ToString();
                txtPassword.Text = SelectRow.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (checkPassword("CREATE"))
            {
                targetPath = CurrentPath.CurrentDir + "Students\\" + txtid.Text;
                if (Directory.Exists(targetPath))
                {
                    try
                    {
                        Directory.Delete(targetPath, true);
                        System.IO.Directory.CreateDirectory(targetPath);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("File already exist, or try another file.");
                    }
                }
                else
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }


                targetPath += "\\" + txtpfpicname.Text;
                File.Copy(sourcePath, targetPath, true);

                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "Insert Into STUDENT(  FULLNAME ,GENDER,DOB,PHONE,ADDRESS,DEPARTMENT,SCHOOL,IMAGE, USERNAME, PASSWORD, ROLE) " +
                        "Values (  @FULLNAME ,@GENDER, @DOB ,@PHONE,@ADDRESS,@DEPARTMENT,@SCHOOL,@IMAGE, @USERNAME , @PASSWORD, @ROLE) ", conn);

                    cmd.Parameters.AddWithValue("@FULLNAME", txtfullname.Text);
                    cmd.Parameters.AddWithValue("@GENDER", txtgender.Text);
                    cmd.Parameters.AddWithValue("@DOB", txtdob.Text);
                    cmd.Parameters.AddWithValue("@PHONE", txtphonenumber.Text);
                    cmd.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@DEPARTMENT", txtdepartment.Text);
                    cmd.Parameters.AddWithValue("@SCHOOL", txtschool.Text);
                    cmd.Parameters.AddWithValue("@IMAGE", txtpfpicname.Text);
                    cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", txtConfirmPass.Text);
                    cmd.Parameters.AddWithValue("@ROLE", EnumCode.ROLE.STUDENT.ToString());

                    cmd.ExecuteNonQuery();
                    GetData();
                    MessageBox.Show("Data Insert Successful ", " Student System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data can't insert \n\n" + ex.Message);
                }

                conn.Close();
                btnnew_Click(sender, e);
            }  
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            DialogResult Deleted = new DialogResult();
            Deleted = MessageBox.Show("Confirm if you want to delete this record?", "Delete Record",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Deleted == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete From STUDENT Where ID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", txtid.Text);
                cmd.ExecuteNonQuery();
                GetData();
                MessageBox.Show("Delete Record Successful!");

                targetPath = CurrentPath.CurrentDir + "Students\\" + txtid.Text;
                if (Directory.Exists(targetPath))
                {
                    try { Directory.Delete(targetPath, true); }
                    catch (IOException ex)
                    {
                        MessageBox.Show("File already exist, or try another file.");
                    }
                }
            }
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (checkPassword("UPDATE"))
            {
                targetPath = CurrentPath.CurrentDir + "Students\\" + txtid.Text;
                System.IO.Directory.CreateDirectory(targetPath);

                targetPath += "\\" + txtpfpicname.Text;
                File.Copy(sourcePath, targetPath, true);

                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "Update STUDENT Set FULLNAME=@FULLNAME, GENDER=@GENDER, DOB=@DOB, PHONE =@PHONE " +
                        ", ADDRESS=@ADDRESS, DEPARTMENT=@DEPARTMENT ,SCHOOL=@SCHOOL,[IMAGE]=@IMAGE " +
                        ", [USERNAME]=@USERNAME ,[PASSWORD]=@PASSWORD Where ID=@ID", conn);

                    cmd.Parameters.AddWithValue("@ID", txtid.Text);
                    cmd.Parameters.AddWithValue("@FULLNAME", txtfullname.Text);
                    cmd.Parameters.AddWithValue("@GENDER", txtgender.Text);
                    cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtdob.Text));
                    cmd.Parameters.AddWithValue("@PHONE", txtphonenumber.Text);
                    cmd.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@DEPARTMENT", txtdepartment.Text);
                    cmd.Parameters.AddWithValue("@SCHOOL", txtschool.Text);
                    cmd.Parameters.AddWithValue("@IMAGE", txtpfpicname.Text);
                    cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
                    cmd.ExecuteNonQuery();

                    GetData();
                    MessageBox.Show("Update is successfull", "STUDENT System");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Fail \n\n" + ex.Message);
                }

                conn.Close();

                btnnew_Click(sender, e);
            }
        }


        private bool checkPassword(string action)
        {
            switch (action)
            {
                case "CREATE":
                {
                    if (txtPassword.Text != txtConfirmPass.Text)
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
                                txtPassword.Text = "";
                                txtConfirmPass.Text = "";
                                txtPassword.Focus();
                            }
                        }
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                case "UPDATE":
                {
                    if(txtPassword.Text == "" || txtPassword.Text == null)
                    {
                            return false;
                    }else if (txtUsername.Text == "" || txtUsername.Text == null){
                            return false;
                    }else
                    {
                        return true;
                    }
                }
                default:
                    return false;

            }

        }

    }
}
