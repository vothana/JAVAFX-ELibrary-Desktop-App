﻿using Library.screen.Book;
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
    public partial class BookAsList : UserControl
    {
        public BookAsList()
        {
            InitializeComponent();
        }

        private void Box_MouseHover(object sender, EventArgs e)
        {
            Box.BackColor = Color.FromArgb(100, 0, 24, 69);
        }

        private void Box_MouseLeave(object sender, EventArgs e)
        {
            Box.BackColor = Color.LightBlue;
        }

        private void BookAsList_Click(object sender, EventArgs e)
        {
            BookManagement.BID.BookID = BookID;
            BookManagement.BID.showBook();
        }
    }
}