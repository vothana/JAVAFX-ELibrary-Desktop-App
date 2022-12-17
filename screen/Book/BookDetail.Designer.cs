namespace Library.screen.Book
{
    partial class BookDetail
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PanelDetail = new System.Windows.Forms.Panel();
            this.pdf = new PdfiumViewer.PdfViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new Library.component.RoundedPic();
            this.btnClose = new Library.component.RoundedPic();
            this.Maximize = new Library.component.RoundedPic();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PanelDetail
            // 
            this.PanelDetail.AutoSize = true;
            this.PanelDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDetail.Location = new System.Drawing.Point(0, 800);
            this.PanelDetail.Name = "PanelDetail";
            this.PanelDetail.Size = new System.Drawing.Size(1300, 0);
            this.PanelDetail.TabIndex = 6;
            // 
            // pdf
            // 
            this.pdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pdf.Location = new System.Drawing.Point(0, 24);
            this.pdf.Name = "pdf";
            this.pdf.ShowToolbar = false;
            this.pdf.Size = new System.Drawing.Size(1300, 764);
            this.pdf.TabIndex = 7;
            this.pdf.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitBest;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Location = new System.Drawing.Point(0, -12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1300, 36);
            this.panel1.TabIndex = 8;
            // 
            // Minimize
            // 
            this.Minimize.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.Minimize.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.Minimize.BorderRadius = 40;
            this.Minimize.BorderSize = 0;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.GradientAngle = 90F;
            this.Minimize.Image = global::Library.Properties.Resources.Minus;
            this.Minimize.Location = new System.Drawing.Point(1216, 13);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 23);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.btnClose.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.btnClose.BorderRadius = 40;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.GradientAngle = 90F;
            this.btnClose.Image = global::Library.Properties.Resources.icons8_power_off_button_30;
            this.btnClose.Location = new System.Drawing.Point(1274, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Maximize
            // 
            this.Maximize.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.Maximize.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.Maximize.BorderRadius = 40;
            this.Maximize.BorderSize = 0;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.GradientAngle = 90F;
            this.Maximize.Image = global::Library.Properties.Resources.full_screen_icon_3;
            this.Maximize.Location = new System.Drawing.Point(1245, 13);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(23, 23);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize.TabIndex = 3;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.PanelDetail);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookDetail";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel PanelDetail;
        private PdfiumViewer.PdfViewer pdf;
        private System.Windows.Forms.Panel panel1;
        private component.RoundedPic Minimize;
        private component.RoundedPic btnClose;
        private component.RoundedPic Maximize;
    }
}