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
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Image = System.Drawing.Image;

namespace Library.screen.Student
{
    public partial class studentmg : KryptonForm
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-2V73A0TT\\SQLEXPRESS;Initial Catalog=ELibrary;Integrated Security=True");

        public studentmg()
        {
            InitializeComponent();
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
            datagridstudent.Columns[7].HeaderText = "SHCOOL";
            datagridstudent.Columns[8].HeaderText = "PicName";

            datagridstudent.Columns["ID"].Width = 100;
            datagridstudent.Columns["FULLNAME"].Width = 100;
            datagridstudent.Columns["GENDER"].Width = 50;
            datagridstudent.Columns["DOB"].Width = 100;
            datagridstudent.Columns["PHONE"].Width = 100;
            datagridstudent.Columns["ADDRESS"].Width = 100;
            datagridstudent.Columns["DEPARTMENT"].Width = 100;
            datagridstudent.Columns["SHCOOL"].Width = 100;
            datagridstudent.Columns["IMAGE"].Width = 100;

            datagridstudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            datagridstudent.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Romen", 7, FontStyle.Bold);
        }

        private void kryptonLabel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentmg_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtselectimage_Click(object sender, EventArgs e)
        {
           OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png; *.gif)|*.jpg;*.png; *.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                roundedPic1.Image = Image.FromFile(opf.FileName);
                roundedPic1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
           
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtfullname.Clear();
            txtgender.Clear();
            txtaddress.Clear();
            txtdepartment.Clear();  
            txtdob.Clear();
            txtpfpicname.Clear();
            txtphonenumber.Clear();
            txtschool.Clear();
        }

        private void datagridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                DataGridViewRow SelectRow = datagridstudent.Rows[index];

                txtid.Text = SelectRow.Cells[0].Value.ToString();
                txtfullname.Text = SelectRow.Cells[1].Value.ToString();
                txtgender.Text = SelectRow.Cells[2].Value.ToString();
                txtdob.Text = SelectRow.Cells[3].Value.ToString();
                txtphonenumber.Text = SelectRow.Cells[4].Value.ToString();
                txtaddress.Text = SelectRow.Cells[5].Value.ToString();
                txtdepartment.Text = SelectRow.Cells[6].Value.ToString();
                txtschool.Text = SelectRow.Cells[7].Value.ToString();
                txtpfpicname.Text = SelectRow.Cells[8].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = new DialogResult();
                iExit = MessageBox.Show(" Confirm if you want to Exit ", " Student System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    this.Close();
                }


            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message, "Student System", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void roundedPic1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into STUDENT(  FULLNAME ,GENDER,DOB,PHONE,ADDRESS,DEPARTMENT,SHCOOL,IMAGE)" +
                                       " Values (  @FULLNAME ,@GENDER, @DOB ,@PHONE,@ADDRESS,@DEPARTMENT,@SCHOOL,@IMAGE )", conn);

            
            cmd.Parameters.AddWithValue("@FULLNAME", txtfullname.Text);
            cmd.Parameters.AddWithValue("@GENDER", txtgender.Text);
            cmd.Parameters.AddWithValue("@DOB", txtdob.Text);
            cmd.Parameters.AddWithValue("@PHONE", txtphonenumber.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
            cmd.Parameters.AddWithValue("@DEPARTMENT", txtdepartment.Text);
            cmd.Parameters.AddWithValue("@SCHOOL", txtschool.Text);
            cmd.Parameters.AddWithValue("@IMAGE", txtpfpicname.Text);
            cmd.ExecuteNonQuery();
            GetData();
            MessageBox.Show("Data Insert Successful ", " Student System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void kryptonLabel9_Paint(object sender, PaintEventArgs e)
        {

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
            }
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*try
            {*/
                SqlCommand cmd = new SqlCommand("Update STUDENT Set FULLNAME=@FULLNAME, GENDER=@GENDER, DOB=@DOB, PHONE =@PHONE , ADDRESS=@ADDRESS, DEPARTMENT=@DEPARTMENT ,SHCOOL=@SCHOOL, " +
                            "[IMAGE]=@IMAGE Where ID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", txtid.Text);
                cmd.Parameters.AddWithValue("@FULLNAME", txtfullname.Text);
                cmd.Parameters.AddWithValue("@GENDER", txtgender.Text);    
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtdob.Text));
                cmd.Parameters.AddWithValue("@PHONE", txtphonenumber.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);
                cmd.Parameters.AddWithValue("@DEPARTMENT", txtdepartment.Text);
                cmd.Parameters.AddWithValue("@SCHOOL", txtschool.Text);
                cmd.Parameters.AddWithValue("@IMAGE", txtpfpicname.Text);
                cmd.ExecuteNonQuery();
                GetData();
                MessageBox.Show("Update is successfull", "STUDENT System");
            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            conn.Close();

            btnnew_Click(sender , e);
        }
    }
}
