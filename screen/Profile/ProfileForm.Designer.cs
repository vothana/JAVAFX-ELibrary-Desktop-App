namespace Library.screen.Profile
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFullName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groubGender = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.txtMale = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtFemale = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhonNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartment = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSchoolName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSaveData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnewPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnUpdatePassword = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtImagePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSwitch = new Library.component.RoundedPic();
            this.btnUploadImage = new Library.component.RoundedPic();
            this.profileImage = new Library.component.RoundedPic();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowPassword = new System.Windows.Forms.PictureBox();
            this.txtDob = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groubGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groubGender.Panel)).BeginInit();
            this.groubGender.Panel.SuspendLayout();
            this.groubGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(201, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(552, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 504);
            this.panel1.TabIndex = 13;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(204, 211);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(316, 31);
            this.txtFullName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFullName.StateCommon.Border.Rounding = 5;
            this.txtFullName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.TabIndex = 15;
            // 
            // groubGender
            // 
            this.groubGender.Enabled = false;
            this.groubGender.Location = new System.Drawing.Point(205, 255);
            this.groubGender.Name = "groubGender";
            // 
            // groubGender.Panel
            // 
            this.groubGender.Panel.Controls.Add(this.txtMale);
            this.groubGender.Panel.Controls.Add(this.txtFemale);
            this.groubGender.Size = new System.Drawing.Size(316, 25);
            this.groubGender.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.groubGender.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.groubGender.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.groubGender.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.groubGender.TabIndex = 16;
            // 
            // txtMale
            // 
            this.txtMale.Location = new System.Drawing.Point(121, -1);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(65, 27);
            this.txtMale.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.txtMale.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMale.TabIndex = 0;
            this.txtMale.Values.Text = "Male";
            // 
            // txtFemale
            // 
            this.txtFemale.Location = new System.Drawing.Point(3, -1);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(87, 27);
            this.txtFemale.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.txtFemale.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFemale.TabIndex = 0;
            this.txtFemale.Values.Text = "Female";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(200, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Full Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(202, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhonNumber
            // 
            this.txtPhonNumber.Enabled = false;
            this.txtPhonNumber.Location = new System.Drawing.Point(205, 364);
            this.txtPhonNumber.Name = "txtPhonNumber";
            this.txtPhonNumber.Size = new System.Drawing.Size(316, 31);
            this.txtPhonNumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhonNumber.StateCommon.Border.Rounding = 5;
            this.txtPhonNumber.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonNumber.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(201, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Department";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Location = new System.Drawing.Point(204, 427);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(316, 31);
            this.txtDepartment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDepartment.StateCommon.Border.Rounding = 5;
            this.txtDepartment.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(201, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "School\'s Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Enabled = false;
            this.txtSchoolName.Location = new System.Drawing.Point(204, 490);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(316, 31);
            this.txtSchoolName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSchoolName.StateCommon.Border.Rounding = 5;
            this.txtSchoolName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(202, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(205, 553);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(316, 31);
            this.txtAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 5;
            this.txtAddress.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.TabIndex = 15;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Enabled = false;
            this.btnSaveData.Location = new System.Drawing.Point(414, 605);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(106, 30);
            this.btnSaveData.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveData.StateCommon.Border.Rounding = 5;
            this.btnSaveData.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.TabIndex = 18;
            this.btnSaveData.Values.Text = "Save";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(577, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Current Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Enabled = false;
            this.txtCurrentPassword.Location = new System.Drawing.Point(580, 300);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(316, 31);
            this.txtCurrentPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrentPassword.StateCommon.Border.Rounding = 5;
            this.txtCurrentPassword.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(577, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "New Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnewPassword
            // 
            this.txtnewPassword.Enabled = false;
            this.txtnewPassword.Location = new System.Drawing.Point(580, 363);
            this.txtnewPassword.Name = "txtnewPassword";
            this.txtnewPassword.PasswordChar = '*';
            this.txtnewPassword.Size = new System.Drawing.Size(316, 31);
            this.txtnewPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtnewPassword.StateCommon.Border.Rounding = 5;
            this.txtnewPassword.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewPassword.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(576, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Confirm New Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(579, 426);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(316, 31);
            this.txtConfirmPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmPassword.StateCommon.Border.Rounding = 5;
            this.txtConfirmPassword.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.TabIndex = 15;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePassword.Enabled = false;
            this.btnUpdatePassword.Location = new System.Drawing.Point(789, 479);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(106, 30);
            this.btnUpdatePassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdatePassword.StateCommon.Border.Rounding = 5;
            this.btnUpdatePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.TabIndex = 18;
            this.btnUpdatePassword.Values.Text = "Update";
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Enabled = false;
            this.kryptonButton3.Location = new System.Drawing.Point(451, 165);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(70, 30);
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 15;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 18;
            this.kryptonButton3.Values.Text = "Save";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Enabled = false;
            this.txtImagePath.Location = new System.Drawing.Point(803, 704);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(316, 13);
            this.txtImagePath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtImagePath.StateCommon.Border.Rounding = 5;
            this.txtImagePath.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.TabIndex = 15;
            this.txtImagePath.Visible = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Red;
            this.btnSwitch.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.btnSwitch.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.btnSwitch.BorderRadius = 40;
            this.btnSwitch.BorderSize = 0;
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.GradientAngle = 90F;
            this.btnSwitch.Location = new System.Drawing.Point(450, 164);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(30, 30);
            this.btnSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSwitch.TabIndex = 19;
            this.btnSwitch.TabStop = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnUploadImage.BorderGradientBottom = System.Drawing.Color.DodgerBlue;
            this.btnUploadImage.BorderGradientTop = System.Drawing.Color.DodgerBlue;
            this.btnUploadImage.BorderRadius = 40;
            this.btnUploadImage.BorderSize = 0;
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImage.GradientAngle = 90F;
            this.btnUploadImage.Image = global::Library.Properties.Resources.icons8_pencil_52_jpg;
            this.btnUploadImage.Location = new System.Drawing.Point(579, 122);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(36, 36);
            this.btnUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUploadImage.TabIndex = 12;
            this.btnUploadImage.TabStop = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // profileImage
            // 
            this.profileImage.BackColor = System.Drawing.Color.Transparent;
            this.profileImage.BorderGradientBottom = System.Drawing.Color.Red;
            this.profileImage.BorderGradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileImage.BorderRadius = 40;
            this.profileImage.BorderSize = 1;
            this.profileImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileImage.GradientAngle = 90F;
            this.profileImage.Image = global::Library.Properties.Resources.B__126_;
            this.profileImage.Location = new System.Drawing.Point(478, 12);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(146, 146);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 11;
            this.profileImage.TabStop = false;
            this.profileImage.Click += new System.EventHandler(this.profilePic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(576, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(579, 211);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 31);
            this.txtUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 5;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(638, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 20;
            // 
            // ShowPassword
            // 
            this.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassword.Image = global::Library.Properties.Resources.icons8_eye_50;
            this.ShowPassword.Location = new System.Drawing.Point(864, 275);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(30, 30);
            this.ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPassword.TabIndex = 21;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // txtDob
            // 
            this.txtDob.Enabled = false;
            this.txtDob.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDob.Location = new System.Drawing.Point(204, 300);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(317, 27);
            this.txtDob.TabIndex = 22;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.groubGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtPhonNumber);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtnewPassword);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groubGender.Panel)).EndInit();
            this.groubGender.Panel.ResumeLayout(false);
            this.groubGender.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groubGender)).EndInit();
            this.groubGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private component.RoundedPic profileImage;
        private component.RoundedPic btnUploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFullName;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup groubGender;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton txtFemale;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton txtMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhonNumber;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDepartment;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSchoolName;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveData;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrentPassword;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtnewPassword;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdatePassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private component.RoundedPic btnSwitch;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtImagePath;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ShowPassword;
        private System.Windows.Forms.DateTimePicker txtDob;

        public string DOB
        {
            get => txtDob.Text;
            set => txtDob.Text = value; 
        }
    }
}