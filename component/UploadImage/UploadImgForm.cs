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
using Library.Entity.ENUM;
using PdfiumViewer;

namespace Library.component.UploadImage
{
    public partial class UploadImgForm : KryptonForm
    {
        EnumCode enums = new EnumCode();
        private string theID;
        private string upload;
        private string sourcePath;
        private string targetPath;
        private string filter;
        public string TheID { set => theID = value; }
        public string Upload { set => upload = value; }

        public UploadImgForm()
        {
            InitializeComponent();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = filter;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if(open.FileName != null)
                {
                    pictureBox.Image = new Bitmap(open.FileName);
                    sourcePath = open.FileName;
                    pictureBox.BringToFront();
                }
                else
                {
                    pictureBox.SendToBack();
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            targetPath = targetPath + theID;
            if (Directory.Exists(targetPath))
            {
                try { Directory.Delete(targetPath, true); }
                catch (IOException ex)
                {
                    MessageBox.Show("File already exist, or try another file.");
                } //delete folder if exists
                //avoid has alot of file in a directory
            }

            System.IO.Directory.CreateDirectory(targetPath);

            if (sourcePath != "")
            {
                string[] split1 = sourcePath.Split('\\');
                string fileName = split1.Last(); // will put into database

                string destFile = targetPath + "\\" + fileName;
                System.IO.File.Copy(sourcePath, destFile, true);
                if (File.Exists(destFile))
                {
                    MessageBox.Show("File uploaded");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("File uploading fail");
                    pictureBox.Image = null;
                    pictureBox.SendToBack();
                }
            }
            else
            {
                MessageBox.Show("Cannot upload file ! Please choose different file");
            }
        }

        private void UploadImgForm_Load(object sender, EventArgs e)
        {
            if (upload == EnumCode.UPLOAD.STUDENT.ToString())
            {
                filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                targetPath = CurrentPath.CurrentDir + "Students\\";
            }
            else if(upload == EnumCode.UPLOAD.BOOK.ToString())
            {
                filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                targetPath = CurrentPath.CurrentDir + "Books\\";
            }else if(upload == EnumCode.UPLOAD.PDF.ToString())
            {
                filter = "Pdf File(*.pdf;)|*.pdf";
                targetPath = CurrentPath.CurrentDir + "PDF\\";
                pdfViewer.Visible = true;
                uploadPDF.Visible = true;
                label.Visible = false;
                pictureBox.Visible = false;
                btnUpload.Visible = false;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadPDF_Click(object sender, EventArgs e)
        {
            if( uploadPDF.Text == "Choose PDF")
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = filter;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.FileName != null)
                    {
                        byte[] bytes = System.IO.File.ReadAllBytes(open.FileName);
                        sourcePath = open.FileName;
                        var stream = new System.IO.MemoryStream(bytes);
                        PdfDocument pdfDocument = PdfDocument.Load(stream);
                        pdfViewer.Document = pdfDocument;
                        uploadPDF.Text = "Upload";
                    }
                }
            }
            else
            {
                btnUpload_Click(sender, e);
            }
            
        }
    }
}
