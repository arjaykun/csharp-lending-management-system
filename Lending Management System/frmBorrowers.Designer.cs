namespace Lending_Management_System
{
    partial class frmBorrowers
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBorrower = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.cboCivilStatus = new System.Windows.Forms.ComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.optFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.optMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBday = new System.Windows.Forms.MaskedTextBox();
            this.txtMonthlySalary = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtOccupation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContacts = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMiddlename = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 80);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lending_Management_System.Properties.Resources.appbar_people;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBorrower
            // 
            this.pnlBorrower.BackColor = System.Drawing.Color.White;
            this.pnlBorrower.Controls.Add(this.picImage);
            this.pnlBorrower.Controls.Add(this.btnBrowse);
            this.pnlBorrower.Controls.Add(this.cboCivilStatus);
            this.pnlBorrower.Controls.Add(this.materialLabel11);
            this.pnlBorrower.Controls.Add(this.optFemale);
            this.pnlBorrower.Controls.Add(this.optMale);
            this.pnlBorrower.Controls.Add(this.materialLabel1);
            this.pnlBorrower.Controls.Add(this.txtBday);
            this.pnlBorrower.Controls.Add(this.txtMonthlySalary);
            this.pnlBorrower.Controls.Add(this.materialLabel10);
            this.pnlBorrower.Controls.Add(this.txtAge);
            this.pnlBorrower.Controls.Add(this.materialLabel9);
            this.pnlBorrower.Controls.Add(this.materialLabel8);
            this.pnlBorrower.Controls.Add(this.txtOccupation);
            this.pnlBorrower.Controls.Add(this.materialLabel7);
            this.pnlBorrower.Controls.Add(this.txtContacts);
            this.pnlBorrower.Controls.Add(this.materialLabel6);
            this.pnlBorrower.Controls.Add(this.txtAddress);
            this.pnlBorrower.Controls.Add(this.materialLabel5);
            this.pnlBorrower.Controls.Add(this.txtMiddlename);
            this.pnlBorrower.Controls.Add(this.materialLabel4);
            this.pnlBorrower.Controls.Add(this.txtLastname);
            this.pnlBorrower.Controls.Add(this.materialLabel3);
            this.pnlBorrower.Controls.Add(this.txtFirstName);
            this.pnlBorrower.Controls.Add(this.materialLabel2);
            this.pnlBorrower.Location = new System.Drawing.Point(32, 105);
            this.pnlBorrower.Name = "pnlBorrower";
            this.pnlBorrower.Size = new System.Drawing.Size(712, 415);
            this.pnlBorrower.TabIndex = 2;
            // 
            // picImage
            // 
            this.picImage.Image = global::Lending_Management_System.Properties.Resources.default2;
            this.picImage.Location = new System.Drawing.Point(282, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(148, 107);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 29;
            this.picImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(282, 116);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(148, 23);
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cboCivilStatus
            // 
            this.cboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCivilStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCivilStatus.FormattingEnabled = true;
            this.cboCivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Annuled",
            "Separated"});
            this.cboCivilStatus.Location = new System.Drawing.Point(476, 364);
            this.cboCivilStatus.Name = "cboCivilStatus";
            this.cboCivilStatus.Size = new System.Drawing.Size(216, 25);
            this.cboCivilStatus.TabIndex = 11;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(472, 342);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(85, 19);
            this.materialLabel11.TabIndex = 23;
            this.materialLabel11.Text = "Civil Status";
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Depth = 0;
            this.optFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.optFemale.Location = new System.Drawing.Point(553, 236);
            this.optFemale.Margin = new System.Windows.Forms.Padding(0);
            this.optFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.optFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.optFemale.Name = "optFemale";
            this.optFemale.Ripple = true;
            this.optFemale.Size = new System.Drawing.Size(74, 30);
            this.optFemale.TabIndex = 5;
            this.optFemale.Text = "Female";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Checked = true;
            this.optMale.Depth = 0;
            this.optMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.optMale.Location = new System.Drawing.Point(476, 236);
            this.optMale.Margin = new System.Windows.Forms.Padding(0);
            this.optMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.optMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.optMale.Name = "optMale";
            this.optMale.Ripple = true;
            this.optMale.Size = new System.Drawing.Size(59, 30);
            this.optMale.TabIndex = 4;
            this.optMale.TabStop = true;
            this.optMale.Text = "Male";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(472, 214);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Gender";
            // 
            // txtBday
            // 
            this.txtBday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBday.Location = new System.Drawing.Point(247, 301);
            this.txtBday.Mask = "##/##/####";
            this.txtBday.Name = "txtBday";
            this.txtBday.RejectInputOnFirstFailure = true;
            this.txtBday.Size = new System.Drawing.Size(211, 23);
            this.txtBday.TabIndex = 7;
            this.txtBday.Leave += new System.EventHandler(this.txtBday_Leave);
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Depth = 0;
            this.txtMonthlySalary.Hint = "";
            this.txtMonthlySalary.Location = new System.Drawing.Point(250, 366);
            this.txtMonthlySalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.PasswordChar = '\0';
            this.txtMonthlySalary.SelectedText = "";
            this.txtMonthlySalary.SelectionLength = 0;
            this.txtMonthlySalary.SelectionStart = 0;
            this.txtMonthlySalary.Size = new System.Drawing.Size(208, 23);
            this.txtMonthlySalary.TabIndex = 10;
            this.txtMonthlySalary.UseSystemPasswordChar = false;
            this.txtMonthlySalary.Leave += new System.EventHandler(this.txtMonthlySalary_Leave);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(246, 344);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(108, 19);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Monthly Salary";
            // 
            // txtAge
            // 
            this.txtAge.Depth = 0;
            this.txtAge.Enabled = false;
            this.txtAge.Hint = "";
            this.txtAge.Location = new System.Drawing.Point(476, 301);
            this.txtAge.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.Size = new System.Drawing.Size(216, 23);
            this.txtAge.TabIndex = 8;
            this.txtAge.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(472, 279);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(35, 19);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "Age";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(246, 279);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(159, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Birthday (mm/dd/yyyy)";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Depth = 0;
            this.txtOccupation.Hint = "";
            this.txtOccupation.Location = new System.Drawing.Point(25, 366);
            this.txtOccupation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.PasswordChar = '\0';
            this.txtOccupation.SelectedText = "";
            this.txtOccupation.SelectionLength = 0;
            this.txtOccupation.SelectionStart = 0;
            this.txtOccupation.Size = new System.Drawing.Size(216, 23);
            this.txtOccupation.TabIndex = 9;
            this.txtOccupation.UseSystemPasswordChar = false;
            this.txtOccupation.Leave += new System.EventHandler(this.txtOccupation_Leave);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(21, 344);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(85, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Occupation";
            // 
            // txtContacts
            // 
            this.txtContacts.Depth = 0;
            this.txtContacts.Hint = "";
            this.txtContacts.Location = new System.Drawing.Point(25, 302);
            this.txtContacts.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.PasswordChar = '\0';
            this.txtContacts.SelectedText = "";
            this.txtContacts.SelectionLength = 0;
            this.txtContacts.SelectionStart = 0;
            this.txtContacts.Size = new System.Drawing.Size(216, 23);
            this.txtContacts.TabIndex = 6;
            this.txtContacts.UseSystemPasswordChar = false;
            this.txtContacts.Leave += new System.EventHandler(this.txtContacts_Leave);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(21, 279);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Contact #";
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(24, 236);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(442, 23);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(20, 214);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Address";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Depth = 0;
            this.txtMiddlename.Hint = "";
            this.txtMiddlename.Location = new System.Drawing.Point(476, 177);
            this.txtMiddlename.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.PasswordChar = '\0';
            this.txtMiddlename.SelectedText = "";
            this.txtMiddlename.SelectionLength = 0;
            this.txtMiddlename.SelectionStart = 0;
            this.txtMiddlename.Size = new System.Drawing.Size(216, 23);
            this.txtMiddlename.TabIndex = 2;
            this.txtMiddlename.UseSystemPasswordChar = false;
            this.txtMiddlename.Leave += new System.EventHandler(this.txtMiddlename_Leave);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(472, 155);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Middle Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Depth = 0;
            this.txtLastname.Hint = "";
            this.txtLastname.Location = new System.Drawing.Point(250, 177);
            this.txtLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.Size = new System.Drawing.Size(216, 23);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.UseSystemPasswordChar = false;
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(246, 155);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Lastname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(24, 177);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(216, 23);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(20, 155);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Firstname";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.btnSave.Location = new System.Drawing.Point(503, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TileImage = global::Lending_Management_System.Properties.Resources.appbar_save;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(627, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TileImage = global::Lending_Management_System.Properties.Resources.appbar_close;
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.Location = new System.Drawing.Point(235, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TileImage = global::Lending_Management_System.Properties.Resources.appbar_delete;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseTileImage = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.btnUpdate.Location = new System.Drawing.Point(369, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TileImage = global::Lending_Management_System.Properties.Resources.appbar_edit_box;
            this.btnUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseTileImage = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmBorrowers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(770, 587);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlBorrower);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBorrowers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBorrower.ResumeLayout(false);
            this.pnlBorrower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBorrower;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMonthlySalary;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAge;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOccupation;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMiddlename;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastname;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnClose;
        private System.Windows.Forms.MaskedTextBox txtBday;
        private System.Windows.Forms.PictureBox picImage;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.ComboBox cboCivilStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialRadioButton optFemale;
        private MaterialSkin.Controls.MaterialRadioButton optMale;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContacts;
    }
}