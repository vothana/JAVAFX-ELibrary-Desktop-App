using System.Windows.Forms;

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
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PanelMainBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainBook
            // 
            this.PanelMainBook.Controls.Add(this.panelBookShow);
            this.PanelMainBook.Controls.Add(this.btnCreateNew);
            this.PanelMainBook.Controls.Add(this.BookListPanel);
            this.PanelMainBook.Controls.Add(this.kryptonTextBox1);
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
            this.btnCreateNew.Location = new System.Drawing.Point(25, 12);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(148, 32);
            this.btnCreateNew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateNew.StateCommon.Border.Rounding = 5;
            this.btnCreateNew.StateCommon.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnCreateNew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(404, 12);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(703, 33);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 5;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 4;
            this.kryptonTextBox1.Text = "Search...";
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Panel panelBookShow;

        public Panel ShowBook
        {
            set => panelBookShow.Controls.Add(value);
        }
    }
}