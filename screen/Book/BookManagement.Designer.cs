﻿using System.Windows.Forms;

namespace Library.screen.Book
{
    partial class BookManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMainBook = new System.Windows.Forms.Panel();
            this.panelBookShow = new System.Windows.Forms.Panel();
            this.btnCreateNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BookListPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PanelMainBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainBook
            // 
            this.PanelMainBook.Controls.Add(this.panelBookShow);
            this.PanelMainBook.Controls.Add(this.btnCreateNew);
            this.PanelMainBook.Controls.Add(this.BookListPanel);
            this.PanelMainBook.Controls.Add(this.txtSearch);
            this.PanelMainBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainBook.Location = new System.Drawing.Point(0, 0);
            this.PanelMainBook.Name = "PanelMainBook";
            this.PanelMainBook.Size = new System.Drawing.Size(1120, 720);
            this.PanelMainBook.TabIndex = 0;
            // 
            // panelBookShow
            // 
            this.panelBookShow.Location = new System.Drawing.Point(12, 65);
            this.panelBookShow.Name = "panelBookShow";
            this.panelBookShow.Size = new System.Drawing.Size(377, 643);
            this.panelBookShow.TabIndex = 8;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNew.Location = new System.Drawing.Point(24, 12);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(112, 33);
            this.btnCreateNew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateNew.StateCommon.Border.Rounding = 5;
            this.btnCreateNew.StateCommon.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnCreateNew.StateCommon.Content.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnCreateNew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnCreateNew.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnCreateNew.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Values.Text = "Create New";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // BookListPanel
            // 
            this.BookListPanel.Location = new System.Drawing.Point(404, 65);
            this.BookListPanel.Name = "BookListPanel";
            this.BookListPanel.Size = new System.Drawing.Size(705, 643);
            this.BookListPanel.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(404, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(703, 33);
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 5;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.MouseHover += new System.EventHandler(this.txtSearch_Click);
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.PanelMainBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookManagement";
            this.Load += new System.EventHandler(this.BookManagement_Load);
            this.PanelMainBook.ResumeLayout(false);
            this.PanelMainBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMainBook;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateNew;
        private System.Windows.Forms.Panel BookListPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.Panel panelBookShow;

        public Panel ShowBook
        {
            set => panelBookShow.Controls.Add(value);
        }
    }
}