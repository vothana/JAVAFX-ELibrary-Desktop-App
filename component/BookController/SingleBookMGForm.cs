using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.component.BookController
{
    public partial class SingleBookMGForm : Form
    {
        public int BookID;
        public SingleBookMGForm()
        {
            InitializeComponent();
        }

        private void SingleBookMGForm_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        public void loadForm()
        {
            if(BookID != 0)
            {
                SingleBookMG singleBookMG = new SingleBookMG(BookID);
                Panel.Controls.Clear();
                Panel.Controls.Add(singleBookMG);
                singleBookMG.Show();
            }
        }
    }
}
