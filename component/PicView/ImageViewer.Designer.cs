namespace Library.component.PicView
{
    partial class ImageViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPic2 = new Library.component.RoundedPic();
            this.roundedPic1 = new Library.component.RoundedPic();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelView = new System.Windows.Forms.Panel();
            this.pictureBx = new System.Windows.Forms.PictureBox();
            this.miniBack = new Library.component.RoundedPic();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPic1)).BeginInit();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedPic2);
            this.panel1.Controls.Add(this.roundedPic1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 757);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 43);
            this.panel1.TabIndex = 1;
            // 
            // roundedPic2
            // 
            this.roundedPic2.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.roundedPic2.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.roundedPic2.BorderRadius = 40;
            this.roundedPic2.BorderSize = 0;
            this.roundedPic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPic2.GradientAngle = 90F;
            this.roundedPic2.Image = global::Library.Properties.Resources.full_screen_icon_3;
            this.roundedPic2.Location = new System.Drawing.Point(609, 7);
            this.roundedPic2.Name = "roundedPic2";
            this.roundedPic2.Size = new System.Drawing.Size(30, 30);
            this.roundedPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPic2.TabIndex = 0;
            this.roundedPic2.TabStop = false;
            this.roundedPic2.Click += new System.EventHandler(this.btnFullView_Click);
            // 
            // roundedPic1
            // 
            this.roundedPic1.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.roundedPic1.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.roundedPic1.BorderRadius = 40;
            this.roundedPic1.BorderSize = 0;
            this.roundedPic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedPic1.GradientAngle = 90F;
            this.roundedPic1.Image = global::Library.Properties.Resources.Back;
            this.roundedPic1.Location = new System.Drawing.Point(573, 7);
            this.roundedPic1.Name = "roundedPic1";
            this.roundedPic1.Size = new System.Drawing.Size(30, 30);
            this.roundedPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPic1.TabIndex = 0;
            this.roundedPic1.TabStop = false;
            this.roundedPic1.Click += new System.EventHandler(this.kryptonButton1_Click);
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
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.pictureBx);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 24);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1200, 727);
            this.panelView.TabIndex = 4;
            // 
            // pictureBx
            // 
            this.pictureBx.Location = new System.Drawing.Point(0, 3);
            this.pictureBx.Name = "pictureBx";
            this.pictureBx.Size = new System.Drawing.Size(1200, 724);
            this.pictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBx.TabIndex = 0;
            this.pictureBx.TabStop = false;
            // 
            // miniBack
            // 
            this.miniBack.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.miniBack.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.miniBack.BorderRadius = 40;
            this.miniBack.BorderSize = 0;
            this.miniBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniBack.GradientAngle = 90F;
            this.miniBack.Image = global::Library.Properties.Resources.Minus;
            this.miniBack.Location = new System.Drawing.Point(1168, 0);
            this.miniBack.Name = "miniBack";
            this.miniBack.Size = new System.Drawing.Size(25, 25);
            this.miniBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.miniBack.TabIndex = 3;
            this.miniBack.TabStop = false;
            this.miniBack.Click += new System.EventHandler(this.miniBack_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.miniBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageViewer";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPic1)).EndInit();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBx;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private RoundedPic miniBack;
        private System.Windows.Forms.Panel panelView;
        private RoundedPic roundedPic1;
        private RoundedPic roundedPic2;
    }
}