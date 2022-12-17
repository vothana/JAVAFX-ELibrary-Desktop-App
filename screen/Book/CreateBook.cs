using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Library.component.BookController;
using Library.component.Popup;
using Library.component.UploadImage;
using Library.Database;
using Library.Entity.ENUM;
using static System.Net.Mime.MediaTypeNames;

namespace Library.screen.Book
{
    public partial class CreateBook : KryptonForm
    {
        public int BookID;
        private SqlConnection conn = Server.Connection();
        private DataSql dataSql = new DataSql();
        private SqlDataReader data;
        int maxID;

        private string pdfname = "";
        public CreateBook()
        {
            InitializeComponent();
            comLangauge.Items.Add("Khmer");
            comLangauge.Items.Add("English");
            btnFree.Checked = true;
            maxID = dataSql.GetMaxID(Server.TABLE.BOOK.ToString(), "ID");
        }

        private void CreateBook_Load(object sender, EventArgs e)
        {

            if (BookID != 0)
            {
                txtID.Text = BookID.ToString();
                btnSubmit.Text = "Update";
                btnDelete.Visible = true;

                data = dataSql.QueryBy(Server.TABLE.BOOK.ToString(), "ID", BookID.ToString());
                if (data.Read())
                {
                    txtTitle.Text = data["Title"].ToString();
                    txtAuthor.Text = data["Author"].ToString();
                    txtYear.Text = data["Year"].ToString();
                    txtDescription.Text = data["Desc"].ToString();
                    comLangauge.Text = data["langauge"].ToString();
                    pdfname = data["PDF"].ToString();
                    if (data["Status"].ToString().Equals("True"))
                    {
                        btnFree.Checked = true;
                    }
                    else
                    {
                       btnNotFree.Checked = true;
                    }
                }
                data.Close();
            }
            else
            {
                txtID.Text = (maxID + 1).ToString();
            }
            conn.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (UploadImgForm uploadImgForm = new UploadImgForm())
            {
                uploadImgForm.TheID = txtID.Text;
                uploadImgForm.Upload = EnumCode.UPLOAD.BOOK.ToString();
                uploadImgForm.ShowDialog();
            }
        }

        private void btnUploadPDF_Click(object sender, EventArgs e)
        {
            using (UploadImgForm uploadImgForm = new UploadImgForm())
            {
                uploadImgForm.TheID = txtID.Text;
                uploadImgForm.Upload = EnumCode.UPLOAD.PDF.ToString();
                uploadImgForm.pdfName = pdfname;
                uploadImgForm.ShowDialog();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (formValidate())
            {
                if (btnSubmit.Text.Equals("Update"))
                {
                    updateBook();
                }
                else
                {
                    createBook();
                    BookManagement.BID.loader();
                }
            }
            else
            {
                MessageBox.Show("Please complete all the fields");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (ConfirmBox confirmBox = new ConfirmBox())
            {
                confirmBox.Tittle = "Are you sure ? \n You are about deleting book's name " + txtTitle.Text;
                confirmBox.ButtonConfirm = "Delete";
                confirmBox.Background = Color.LightCyan;
                confirmBox.FontColor = Color.Black;
                confirmBox.ShowDialog();
                if (confirmBox.DialogResult == DialogResult.Yes)
                {
                    bool result = dataSql.delete(Server.TABLE.BOOK.ToString(), "ID", BookID.ToString());
                    if (result)
                    {
                        MessageBox.Show("Success deleted");
                        BookManagement.BID.BookID = 0;
                        BookManagement.BID.loader();
                        try { Directory.Delete(CurrentPath.CurrentDir + "Books\\" + BookID, true); }
                        catch (IOException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cannot delete");
                }
            }
        }

        private void updateBook()
        {
            IDictionary<string, object> data = formData(BookID);
            bool result = dataSql.mutaion("PUT", Server.TABLE.BOOK.ToString(), data,  "ID", BookID.ToString());
            if (result)
            {
                MessageBox.Show("Success update");
                BookManagement.BID.loader();
                this.Close();
            }
              else
                MessageBox.Show("Cannot update");
        }
        private void createBook()
        {
            IDictionary<string, object> data = formData(maxID);
            bool result = dataSql.mutaion("POST", Server.TABLE.BOOK.ToString(), data, "", "");
            if (result)
            {
                MessageBox.Show("Success created");
                BookManagement.BID.loader();
                this.Close();
            }
            else
                MessageBox.Show("Cannot create");
        }

        private IDictionary<string, object> formData(int ID)
        {
            string[] files;
            string imgPath = CurrentPath.CurrentDir + "Books\\" + ID + "\\";
            string pdfPath = CurrentPath.CurrentDir + "PDF\\" + ID + "\\";
            string image = "", pdf = "";
            if (!File.Exists(imgPath) || !File.Exists(pdfPath) )
            {
                System.IO.Directory.CreateDirectory(imgPath);
                System.IO.Directory.CreateDirectory(pdfPath);
            }

            files = Directory.GetFiles(imgPath);
            if(files.Length > 0)
                image = Path.GetFileName(files[0]);


            files = Directory.GetFiles(pdfPath);
            if (files.Length > 0)
                pdf = Path.GetFileName(files[0]);

            IDictionary<string, object> data = new Dictionary<string, object>();
            data["TITLE"] = txtTitle.Text;
            data["DESC"] = txtDescription.Text;
            data["AUTHOR"] = txtAuthor.Text;
            data["YEAR"] = Int32.Parse(txtYear.Text);
            data["LANGAUGE"] = comLangauge.Text;

            if (image != null && image != "")
                data["IMAGE"] = image;
            else
                data["IMAGE"] = "no image";

            if (pdf != null && pdf != "")
                data["PDF"] = pdf;
            else
                data["PDF"] = "no pdf";

            if (btnFree.Checked)
                data["STATUS"] = true;
            else
                data["STATUS"] = false;

            return data;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool formValidate()
        {
            if (txtTitle.Text == "") { return false; }
            else if (txtAuthor.Text == "") { return false; }
            else if (txtDescription.Text == "") {  return false; }
            else if (txtYear.Text == "") {  return false; }
            else if (comLangauge.Text == "") {return false; }
           // else if (comLangauge.Text == "" || comLangauge.Text != comLangauge.Items[0].ToString() || comLangauge.Text != comLangauge.Items[1].ToString()) { MessageBox.Show("L");  return false; }

            return true;
        }
    }
}
