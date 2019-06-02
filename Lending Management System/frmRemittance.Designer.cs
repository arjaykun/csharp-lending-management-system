namespace Lending_Management_System
{
    partial class frmRemittance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBorrowerId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtCollector = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPerRemit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaturity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBorrowerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPaidBy = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.txtTotalBal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLoanId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDueAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDueDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 80);
            this.panel2.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(748, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TileImage = global::Lending_Management_System.Properties.Resources.appbar_close;
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remittance";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lending_Management_System.Properties.Resources.appbar_money;
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtBorrowerId);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Controls.Add(this.txtCollector);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.txtPerRemit);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txtMaturity);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.txtBorrowerName);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 458);
            this.panel1.TabIndex = 26;
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.Depth = 0;
            this.txtBorrowerId.Enabled = false;
            this.txtBorrowerId.ForeColor = System.Drawing.Color.White;
            this.txtBorrowerId.Hint = "";
            this.txtBorrowerId.Location = new System.Drawing.Point(26, 166);
            this.txtBorrowerId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.PasswordChar = '\0';
            this.txtBorrowerId.SelectedText = "";
            this.txtBorrowerId.SelectionLength = 0;
            this.txtBorrowerId.SelectionStart = 0;
            this.txtBorrowerId.Size = new System.Drawing.Size(216, 23);
            this.txtBorrowerId.TabIndex = 36;
            this.txtBorrowerId.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(26, 192);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(114, 19);
            this.materialLabel9.TabIndex = 37;
            this.materialLabel9.Text = "Borrower Name";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(62, 24);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(146, 105);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 35;
            this.picImage.TabStop = false;
            // 
            // txtCollector
            // 
            this.txtCollector.Depth = 0;
            this.txtCollector.Enabled = false;
            this.txtCollector.ForeColor = System.Drawing.Color.White;
            this.txtCollector.Hint = "";
            this.txtCollector.Location = new System.Drawing.Point(26, 358);
            this.txtCollector.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCollector.Name = "txtCollector";
            this.txtCollector.PasswordChar = '\0';
            this.txtCollector.SelectedText = "";
            this.txtCollector.SelectionLength = 0;
            this.txtCollector.SelectionStart = 0;
            this.txtCollector.Size = new System.Drawing.Size(216, 23);
            this.txtCollector.TabIndex = 33;
            this.txtCollector.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(26, 336);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 34;
            this.materialLabel5.Text = "Collector";
            // 
            // txtPerRemit
            // 
            this.txtPerRemit.Depth = 0;
            this.txtPerRemit.Enabled = false;
            this.txtPerRemit.ForeColor = System.Drawing.Color.White;
            this.txtPerRemit.Hint = "";
            this.txtPerRemit.Location = new System.Drawing.Point(26, 310);
            this.txtPerRemit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPerRemit.Name = "txtPerRemit";
            this.txtPerRemit.PasswordChar = '\0';
            this.txtPerRemit.SelectedText = "";
            this.txtPerRemit.SelectionLength = 0;
            this.txtPerRemit.SelectionStart = 0;
            this.txtPerRemit.Size = new System.Drawing.Size(216, 23);
            this.txtPerRemit.TabIndex = 31;
            this.txtPerRemit.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(26, 288);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 19);
            this.materialLabel3.TabIndex = 32;
            this.materialLabel3.Text = "Per Remittance";
            // 
            // txtMaturity
            // 
            this.txtMaturity.Depth = 0;
            this.txtMaturity.Enabled = false;
            this.txtMaturity.ForeColor = System.Drawing.Color.White;
            this.txtMaturity.Hint = "";
            this.txtMaturity.Location = new System.Drawing.Point(26, 262);
            this.txtMaturity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaturity.Name = "txtMaturity";
            this.txtMaturity.PasswordChar = '\0';
            this.txtMaturity.SelectedText = "";
            this.txtMaturity.SelectionLength = 0;
            this.txtMaturity.SelectionStart = 0;
            this.txtMaturity.Size = new System.Drawing.Size(216, 23);
            this.txtMaturity.TabIndex = 29;
            this.txtMaturity.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 240);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Maturity Loan";
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Depth = 0;
            this.txtBorrowerName.Enabled = false;
            this.txtBorrowerName.ForeColor = System.Drawing.Color.White;
            this.txtBorrowerName.Hint = "";
            this.txtBorrowerName.Location = new System.Drawing.Point(26, 214);
            this.txtBorrowerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.PasswordChar = '\0';
            this.txtBorrowerName.SelectedText = "";
            this.txtBorrowerName.SelectionLength = 0;
            this.txtBorrowerName.SelectionStart = 0;
            this.txtBorrowerName.Size = new System.Drawing.Size(216, 23);
            this.txtBorrowerName.TabIndex = 27;
            this.txtBorrowerName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(26, 144);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Borrower ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialLabel13);
            this.panel3.Controls.Add(this.txtTO);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblOR);
            this.panel3.Controls.Add(this.materialLabel12);
            this.panel3.Controls.Add(this.txtPaidBy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBalance);
            this.panel3.Controls.Add(this.materialLabel8);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.materialLabel7);
            this.panel3.Location = new System.Drawing.Point(281, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 300);
            this.panel3.TabIndex = 27;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(309, 242);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(31, 19);
            this.materialLabel13.TabIndex = 42;
            this.materialLabel13.Text = "To:";
            // 
            // txtTO
            // 
            this.txtTO.Depth = 0;
            this.txtTO.Enabled = false;
            this.txtTO.ForeColor = System.Drawing.Color.White;
            this.txtTO.Hint = "";
            this.txtTO.Location = new System.Drawing.Point(346, 238);
            this.txtTO.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTO.Name = "txtTO";
            this.txtTO.PasswordChar = '\0';
            this.txtTO.SelectedText = "";
            this.txtTO.SelectionLength = 0;
            this.txtTO.SelectionStart = 0;
            this.txtTO.Size = new System.Drawing.Size(161, 23);
            this.txtTO.TabIndex = 41;
            this.txtTO.UseSystemPasswordChar = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(387, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 19);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "DATE";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.Location = new System.Drawing.Point(17, 57);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(42, 21);
            this.lblOR.TabIndex = 39;
            this.lblOR.Text = "OR#";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(34, 242);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(62, 19);
            this.materialLabel12.TabIndex = 38;
            this.materialLabel12.Text = "Paid By:";
            // 
            // txtPaidBy
            // 
            this.txtPaidBy.Depth = 0;
            this.txtPaidBy.Enabled = false;
            this.txtPaidBy.ForeColor = System.Drawing.Color.White;
            this.txtPaidBy.Hint = "";
            this.txtPaidBy.Location = new System.Drawing.Point(102, 238);
            this.txtPaidBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPaidBy.Name = "txtPaidBy";
            this.txtPaidBy.PasswordChar = '\0';
            this.txtPaidBy.SelectedText = "";
            this.txtPaidBy.SelectionLength = 0;
            this.txtPaidBy.SelectionStart = 0;
            this.txtPaidBy.Size = new System.Drawing.Size(167, 23);
            this.txtPaidBy.TabIndex = 36;
            this.txtPaidBy.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 47);
            this.label3.TabIndex = 35;
            this.label3.Text = "KASAPI LENDING ANTIPOLO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Official Receipt";
            // 
            // txtBalance
            // 
            this.txtBalance.Depth = 0;
            this.txtBalance.Enabled = false;
            this.txtBalance.Hint = "";
            this.txtBalance.Location = new System.Drawing.Point(253, 164);
            this.txtBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.Size = new System.Drawing.Size(194, 23);
            this.txtBalance.TabIndex = 32;
            this.txtBalance.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(82, 166);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(165, 19);
            this.materialLabel8.TabIndex = 33;
            this.materialLabel8.Text = "Balance After Payment:";
            // 
            // txtAmount
            // 
            this.txtAmount.Depth = 0;
            this.txtAmount.Enabled = false;
            this.txtAmount.Hint = "";
            this.txtAmount.Location = new System.Drawing.Point(253, 135);
            this.txtAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.Size = new System.Drawing.Size(194, 23);
            this.txtAmount.TabIndex = 30;
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(148, 139);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(99, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Amount Paid:";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.btnSave.Location = new System.Drawing.Point(701, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 50);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "&SUBMIT";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TileImage = global::Lending_Management_System.Properties.Resources.appbar_save;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtTotalBal
            // 
            this.txtTotalBal.Depth = 0;
            this.txtTotalBal.Enabled = false;
            this.txtTotalBal.Hint = "";
            this.txtTotalBal.Location = new System.Drawing.Point(644, 125);
            this.txtTotalBal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalBal.Name = "txtTotalBal";
            this.txtTotalBal.PasswordChar = '\0';
            this.txtTotalBal.SelectedText = "";
            this.txtTotalBal.SelectionLength = 0;
            this.txtTotalBal.SelectionStart = 0;
            this.txtTotalBal.Size = new System.Drawing.Size(179, 23);
            this.txtTotalBal.TabIndex = 67;
            this.txtTotalBal.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(542, 129);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(73, 19);
            this.materialLabel11.TabIndex = 68;
            this.materialLabel11.Text = "Total Bal:";
            // 
            // txtLoanId
            // 
            this.txtLoanId.Depth = 0;
            this.txtLoanId.Enabled = false;
            this.txtLoanId.Hint = "";
            this.txtLoanId.Location = new System.Drawing.Point(357, 97);
            this.txtLoanId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.PasswordChar = '\0';
            this.txtLoanId.SelectedText = "";
            this.txtLoanId.SelectionLength = 0;
            this.txtLoanId.SelectionStart = 0;
            this.txtLoanId.Size = new System.Drawing.Size(179, 23);
            this.txtLoanId.TabIndex = 65;
            this.txtLoanId.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(277, 95);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(64, 19);
            this.materialLabel10.TabIndex = 66;
            this.materialLabel10.Text = "Loan ID:";
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Depth = 0;
            this.txtDueAmount.Enabled = false;
            this.txtDueAmount.Hint = "";
            this.txtDueAmount.Location = new System.Drawing.Point(644, 93);
            this.txtDueAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.PasswordChar = '\0';
            this.txtDueAmount.SelectedText = "";
            this.txtDueAmount.SelectionLength = 0;
            this.txtDueAmount.SelectionStart = 0;
            this.txtDueAmount.Size = new System.Drawing.Size(179, 23);
            this.txtDueAmount.TabIndex = 63;
            this.txtDueAmount.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(542, 97);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(96, 19);
            this.materialLabel4.TabIndex = 64;
            this.materialLabel4.Text = "Due Amount:";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Depth = 0;
            this.txtDueDate.Enabled = false;
            this.txtDueDate.Hint = "";
            this.txtDueDate.Location = new System.Drawing.Point(357, 126);
            this.txtDueDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.PasswordChar = '\0';
            this.txtDueDate.SelectedText = "";
            this.txtDueDate.SelectionLength = 0;
            this.txtDueDate.SelectionStart = 0;
            this.txtDueDate.Size = new System.Drawing.Size(179, 23);
            this.txtDueDate.TabIndex = 61;
            this.txtDueDate.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(277, 126);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(74, 19);
            this.materialLabel6.TabIndex = 62;
            this.materialLabel6.Text = "Due Date:";
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(98)))), ((int)(((byte)(48)))));
            this.btnPrint.Location = new System.Drawing.Point(567, 467);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 50);
            this.btnPrint.TabIndex = 69;
            this.btnPrint.Text = "&PRINT";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.TileImage = global::Lending_Management_System.Properties.Resources.appbar_printer;
            this.btnPrint.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPrint.UseCustomBackColor = true;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.UseTileImage = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmRemittance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(837, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalBal);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtLoanId);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtDueAmount);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRemittance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRemittance";
            this.Load += new System.EventHandler(this.frmRemittance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCollector;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaturity;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBorrowerName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox picImage;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPerRemit;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroTile btnClose;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBorrowerId;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBalance;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MetroFramework.Controls.MetroTile btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalBal;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLoanId;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDueAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDueDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTO;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOR;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPaidBy;
        private MetroFramework.Controls.MetroTile btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}