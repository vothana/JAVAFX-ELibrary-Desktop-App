using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;

namespace Library.screen.Student
{
    public partial class studentmg : KryptonForm
    {
        public studentmg()
        {
            InitializeComponent();
        }

        private void kryptonLabel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentmg_Load(object sender, EventArgs e)
        {

        }

        private void txtselectimage_Click(object sender, EventArgs e)
        {
            try {
             
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All File(*.*)|*.*|";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    
                        roundedPic1.Load(dialog.FileName);
                    
                }

            } catch (Exception){ 
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
                txtpfpicname.Text = SelectRow.Cells[7].Value.ToString();


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
                iExit = MessageBox.Show(" Confirm if you want to Exit ", " Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    this.Close();
                }


            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message, "Student System", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
