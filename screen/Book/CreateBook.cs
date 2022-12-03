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
using Library.component.UploadImage;
using Library.Entity.ENUM;

namespace Library.screen.Book
{
    public partial class CreateBook : KryptonForm
    {
        public string BookID;
        public CreateBook()
        {
            InitializeComponent();
        }

        private void CreateBook_Load(object sender, EventArgs e)
        {
            if (BookID != null)
            {
                txtID.Text = BookID;
                btnSubmit.Text = "Update";
            }
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
                uploadImgForm.ShowDialog();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
