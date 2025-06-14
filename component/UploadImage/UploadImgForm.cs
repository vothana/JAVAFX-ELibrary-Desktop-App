﻿using System;
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
using Library.screen.Book;
using PdfiumViewer;

namespace Library.component.UploadImage
{
    public partial class UploadImgForm : KryptonForm
    {
        private string theID;
        private string upload;
        private string sourcePath;
        private string targetPath;
        private string filter;
        private string imageName = null;
        public  string pdfName = "";
        public string TheID { set => theID = value; }
        public string Upload { set => upload = value; }

        private bool isUpdatingBook;
        public bool IsUpdatingBook { set => isUpdatingBook = value; }
        public UploadImgForm()
        {
            InitializeComponent();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = filter;
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.FileName != null)
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
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (sourcePath != "" && sourcePath != null)
            {
                try
                {
                    targetPath = targetPath + theID;
                    if (Directory.Exists(targetPath))
                    {
                        try { Directory.Delete(targetPath, true); }
                        catch (IOException ex)
                        {
                           // MessageBox.Show("File already exist, or try another file. \n");
                            Console.WriteLine(ex.Message);
                        } //delete folder if exists
                          //avoid has alot of file in a directory
                    }

                    System.IO.Directory.CreateDirectory(targetPath);
                    string[] split1 = sourcePath.Split('\\');
                    string fileName = split1.Last(); // will put into database

                    string destFile = "";

                    //we will add .update to the end of the file
                    //because we cannot delete the old opening image
                    //we will delete .update, when user click update the book
                    if (isUpdatingBook)
                    {
                        destFile = targetPath + "\\" + fileName + ".update";
                    }
                    else
                        destFile = targetPath + "\\" + fileName;

                    System.IO.File.Copy(sourcePath, destFile, true);
                    if (File.Exists(destFile))
                    {
                        MessageBox.Show("File uploaded");
                        if (upload == EnumCode.UPLOAD.BOOK.ToString())
                        {
                            BookManagement.BID.loader();
                        }
                        imageName = fileName;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("File uploading fail");
                        pictureBox.Image = null;
                        pictureBox.SendToBack();
                    }
                }catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
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
                filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                targetPath = CurrentPath.CurrentDir + "Students\\";
            }
            else if(upload == EnumCode.UPLOAD.BOOK.ToString())
            {
                filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
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

                String filePDF = CurrentPath.CurrentDir + "PDF\\" + theID + "\\" + pdfName;
                if (File.Exists(filePDF))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(filePDF);
                    var stream = new System.IO.MemoryStream(bytes);
                    PdfDocument pdfDocument = PdfDocument.Load(stream);
                    pdfViewer.Document = pdfDocument;
                    pdfViewer.BringToFront();
                }
                else
                {
                    if (upload == EnumCode.UPLOAD.PDF.ToString())
                    {
                        labelNoPdf.Visible = true;
                        labelNoPdf.Text += "ID :" + theID;
                    }
                }
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
                        pdfViewer.BringToFront();
                        uploadPDF.Text = "Upload";
                    }
                }
            }
            else
            {
                btnUpload_Click(sender, e);
            }
            
        }

        public string ImageName()
        {
            return imageName;
        }
    }
}
