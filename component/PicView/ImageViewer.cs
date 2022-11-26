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

namespace Library.component.PicView
{
    public partial class ImageViewer : KryptonForm
    {
        private string imagePath;

        public string ImagePath { set => imagePath = value; }

        public ImageViewer()
        {
            InitializeComponent();
        }

        private void btnFullView_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;

            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
            panelView.Dock = DockStyle.Fill;
        }

        private void miniBack_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            panelView.Dock = DockStyle.None;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            MessageBox.Show(imagePath);
            pictureBx.Image = new Bitmap(imagePath);
        }

    }
}
