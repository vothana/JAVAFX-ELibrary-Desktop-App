namespace Library.screen.Main
{
    partial class Main
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
            this.MainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMyProfile = new System.Windows.Forms.Panel();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.panelMyBook = new System.Windows.Forms.Panel();
            this.btnMyBooks = new System.Windows.Forms.Button();
            this.panelBookMG = new System.Windows.Forms.Panel();
            this.btnBookMG = new System.Windows.Forms.Button();
            this.panelStudentsMG = new System.Windows.Forms.Panel();
            this.btnStudentMG = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProfileName = new System.Windows.Forms.Label();
            this.btnProfilePic = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGoMyProfile = new System.Windows.Forms.Button();
            this.profileMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelMyProfile.SuspendLayout();
            this.panelMyBook.SuspendLayout();
            this.panelBookMG.SuspendLayout();
            this.panelStudentsMG.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.profileMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPalette
            // 
            this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panelHome);
            this.sideBar.Controls.Add(this.panelMyProfile);
            this.sideBar.Controls.Add(this.panelMyBook);
            this.sideBar.Controls.Add(this.panelBookMG);
            this.sideBar.Controls.Add(this.panelStudentsMG);
            this.sideBar.Controls.Add(this.panelAbout);
            this.sideBar.Controls.Add(this.panelSpace);
            this.sideBar.Controls.Add(this.panelExit);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(270, 800);
            this.sideBar.MinimumSize = new System.Drawing.Size(62, 800);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(62, 800);
            this.sideBar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(267, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Library.Properties.Resources.icons8_menu_48;
            this.btnMenu.Location = new System.Drawing.Point(9, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 38);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelHome.Location = new System.Drawing.Point(3, 59);
            this.panelHome.Name = "panelHome";
            this.panelHome.Padding = new System.Windows.Forms.Padding(5);
            this.panelHome.Size = new System.Drawing.Size(277, 50);
            this.panelHome.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Image = global::Library.Properties.Resources.icons8_home_page_30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-8, -6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(285, 63);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "               Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMyProfile
            // 
            this.panelMyProfile.Controls.Add(this.btnMyProfile);
            this.panelMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMyProfile.Location = new System.Drawing.Point(3, 115);
            this.panelMyProfile.Name = "panelMyProfile";
            this.panelMyProfile.Padding = new System.Windows.Forms.Padding(5);
            this.panelMyProfile.Size = new System.Drawing.Size(277, 50);
            this.panelMyProfile.TabIndex = 3;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.Silver;
            this.btnMyProfile.Image = global::Library.Properties.Resources.icons8_male_user_30;
            this.btnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.Location = new System.Drawing.Point(-8, -6);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMyProfile.Size = new System.Drawing.Size(285, 63);
            this.btnMyProfile.TabIndex = 4;
            this.btnMyProfile.Text = "               My Profile";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // panelMyBook
            // 
            this.panelMyBook.Controls.Add(this.btnMyBooks);
            this.panelMyBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMyBook.Location = new System.Drawing.Point(3, 171);
            this.panelMyBook.Name = "panelMyBook";
            this.panelMyBook.Padding = new System.Windows.Forms.Padding(5);
            this.panelMyBook.Size = new System.Drawing.Size(277, 50);
            this.panelMyBook.TabIndex = 3;
            // 
            // btnMyBooks
            // 
            this.btnMyBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnMyBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBooks.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnMyBooks.ForeColor = System.Drawing.Color.Silver;
            this.btnMyBooks.Image = global::Library.Properties.Resources.icons8_books_30;
            this.btnMyBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyBooks.Location = new System.Drawing.Point(-8, -6);
            this.btnMyBooks.Name = "btnMyBooks";
            this.btnMyBooks.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMyBooks.Size = new System.Drawing.Size(285, 63);
            this.btnMyBooks.TabIndex = 4;
            this.btnMyBooks.Text = "               My Books";
            this.btnMyBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyBooks.UseVisualStyleBackColor = false;
            this.btnMyBooks.Click += new System.EventHandler(this.btnMyBooks_Click);
            // 
            // panelBookMG
            // 
            this.panelBookMG.Controls.Add(this.btnBookMG);
            this.panelBookMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBookMG.Location = new System.Drawing.Point(3, 227);
            this.panelBookMG.Name = "panelBookMG";
            this.panelBookMG.Padding = new System.Windows.Forms.Padding(5);
            this.panelBookMG.Size = new System.Drawing.Size(300, 50);
            this.panelBookMG.TabIndex = 3;
            this.panelBookMG.Visible = false;
            // 
            // btnBookMG
            // 
            this.btnBookMG.BackColor = System.Drawing.Color.Transparent;
            this.btnBookMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBookMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMG.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnBookMG.ForeColor = System.Drawing.Color.Silver;
            this.btnBookMG.Image = global::Library.Properties.Resources.icons8_books_30;
            this.btnBookMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookMG.Location = new System.Drawing.Point(-8, -6);
            this.btnBookMG.Name = "btnBookMG";
            this.btnBookMG.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookMG.Size = new System.Drawing.Size(319, 63);
            this.btnBookMG.TabIndex = 4;
            this.btnBookMG.Text = "               Books Management";
            this.btnBookMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookMG.UseVisualStyleBackColor = false;
            this.btnBookMG.Click += new System.EventHandler(this.btnBookMG_Click);
            // 
            // panelStudentsMG
            // 
            this.panelStudentsMG.Controls.Add(this.btnStudentMG);
            this.panelStudentsMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelStudentsMG.Location = new System.Drawing.Point(3, 283);
            this.panelStudentsMG.Name = "panelStudentsMG";
            this.panelStudentsMG.Padding = new System.Windows.Forms.Padding(5);
            this.panelStudentsMG.Size = new System.Drawing.Size(300, 50);
            this.panelStudentsMG.TabIndex = 3;
            this.panelStudentsMG.Visible = false;
            // 
            // btnStudentMG
            // 
            this.btnStudentMG.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStudentMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMG.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnStudentMG.ForeColor = System.Drawing.Color.Silver;
            this.btnStudentMG.Image = global::Library.Properties.Resources.icons8_graduate_30;
            this.btnStudentMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentMG.Location = new System.Drawing.Point(-8, -6);
            this.btnStudentMG.Name = "btnStudentMG";
            this.btnStudentMG.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStudentMG.Size = new System.Drawing.Size(319, 63);
            this.btnStudentMG.TabIndex = 4;
            this.btnStudentMG.Text = "               Students Management";
            this.btnStudentMG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentMG.UseVisualStyleBackColor = false;
            this.btnStudentMG.Click += new System.EventHandler(this.btnStudentMG_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.btnAbout);
            this.panelAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAbout.Location = new System.Drawing.Point(3, 339);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Padding = new System.Windows.Forms.Padding(5);
            this.panelAbout.Size = new System.Drawing.Size(277, 50);
            this.panelAbout.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnAbout.ForeColor = System.Drawing.Color.Silver;
            this.btnAbout.Image = global::Library.Properties.Resources.icons8_info_30;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-8, -6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(285, 63);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "               About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panelSpace
            // 
            this.panelSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSpace.Location = new System.Drawing.Point(3, 395);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Padding = new System.Windows.Forms.Padding(5);
            this.panelSpace.Size = new System.Drawing.Size(47, 352);
            this.panelSpace.TabIndex = 3;
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.btnExit);
            this.panelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelExit.Location = new System.Drawing.Point(3, 753);
            this.panelExit.Name = "panelExit";
            this.panelExit.Padding = new System.Windows.Forms.Padding(5);
            this.panelExit.Size = new System.Drawing.Size(277, 50);
            this.panelExit.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = global::Library.Properties.Resources.icons8_power_off_button_30;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-8, -6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(285, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "               Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtProfileName);
            this.panel2.Controls.Add(this.btnProfilePic);
            this.panel2.Location = new System.Drawing.Point(62, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 53);
            this.panel2.TabIndex = 3;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.txtProfileName.Location = new System.Drawing.Point(907, 17);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(172, 25);
            this.txtProfileName.TabIndex = 5;
            this.txtProfileName.Text = "Yomiko Yano";
            this.txtProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtProfileName.Click += new System.EventHandler(this.txtProfileName_Click);
            // 
            // btnProfilePic
            // 
            this.btnProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilePic.Location = new System.Drawing.Point(1085, 5);
            this.btnProfilePic.MaximumSize = new System.Drawing.Size(45, 45);
            this.btnProfilePic.MinimumSize = new System.Drawing.Size(45, 45);
            this.btnProfilePic.Name = "btnProfilePic";
            this.btnProfilePic.Size = new System.Drawing.Size(45, 45);
            this.btnProfilePic.StateCommon.Back.Image = global::Library.Properties.Resources.Girl__12_;
            this.btnProfilePic.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btnProfilePic.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfilePic.StateCommon.Border.Rounding = 100;
            this.btnProfilePic.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.GrayScale;
            this.btnProfilePic.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnProfilePic.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnProfilePic.TabIndex = 4;
            this.btnProfilePic.Values.Text = "kryptonButton1";
            this.btnProfilePic.Click += new System.EventHandler(this.btnProfilePic_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.MainPanel.BackColor = System.Drawing.Color.LightCyan;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(62, 53);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1138, 747);
            this.MainPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGoMyProfile);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(277, 50);
            this.panel3.TabIndex = 3;
            // 
            // btnGoMyProfile
            // 
            this.btnGoMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnGoMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGoMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMyProfile.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnGoMyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGoMyProfile.Image = global::Library.Properties.Resources.icons8_male_user_30__1_;
            this.btnGoMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoMyProfile.Location = new System.Drawing.Point(-8, -6);
            this.btnGoMyProfile.Name = "btnGoMyProfile";
            this.btnGoMyProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGoMyProfile.Size = new System.Drawing.Size(285, 63);
            this.btnGoMyProfile.TabIndex = 4;
            this.btnGoMyProfile.Text = "               My Profile";
            this.btnGoMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoMyProfile.UseVisualStyleBackColor = false;
            this.btnGoMyProfile.Click += new System.EventHandler(this.btnGoMyProfile_Click);
            // 
            // profileMenu
            // 
            this.profileMenu.Controls.Add(this.panel3);
            this.profileMenu.Controls.Add(this.panel4);
            this.profileMenu.Location = new System.Drawing.Point(1000, 53);
            this.profileMenu.Name = "profileMenu";
            this.profileMenu.Size = new System.Drawing.Size(200, 112);
            this.profileMenu.TabIndex = 5;
            this.profileMenu.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(3, 59);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(277, 50);
            this.panel4.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Image = global::Library.Properties.Resources.icons8_logout_rounded_left_30;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(-8, -6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(285, 63);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "               Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.profileMenu);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Palette = this.MainPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelMyProfile.ResumeLayout(false);
            this.panelMyBook.ResumeLayout(false);
            this.panelBookMG.ResumeLayout(false);
            this.panelStudentsMG.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.profileMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPalette;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelMyProfile;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Panel panelMyBook;
        private System.Windows.Forms.Button btnMyBooks;
        private System.Windows.Forms.Panel panelBookMG;
        private System.Windows.Forms.Button btnBookMG;
        private System.Windows.Forms.Panel panelStudentsMG;
        private System.Windows.Forms.Button btnStudentMG;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProfilePic;
        private System.Windows.Forms.Label txtProfileName;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGoMyProfile;
        private System.Windows.Forms.FlowLayoutPanel profileMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogOut;
    }
}