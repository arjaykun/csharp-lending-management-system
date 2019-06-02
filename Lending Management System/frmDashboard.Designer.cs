namespace Lending_Management_System
{
    partial class frmDashboard
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
            this.btnLogout = new MetroFramework.Controls.MetroTile();
            this.btnBorrowers = new MetroFramework.Controls.MetroTile();
            this.btnConfig = new MetroFramework.Controls.MetroTile();
            this.btnLoans = new MetroFramework.Controls.MetroTile();
            this.btnSummary = new MetroFramework.Controls.MetroTile();
            this.btnCollection = new MetroFramework.Controls.MetroTile();
            this.btnCollectibles = new MetroFramework.Controls.MetroTile();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBorrowers);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnLoans);
            this.panel1.Controls.Add(this.btnSummary);
            this.panel1.Controls.Add(this.btnCollection);
            this.panel1.Controls.Add(this.btnCollectibles);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblUsertype);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(-1, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 99);
            this.panel1.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveControl = null;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Location = new System.Drawing.Point(780, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 99);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG O&UT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TileImage = global::Lending_Management_System.Properties.Resources.appbar_power;
            this.btnLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseTileImage = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBorrowers
            // 
            this.btnBorrowers.ActiveControl = null;
            this.btnBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btnBorrowers.Location = new System.Drawing.Point(130, 0);
            this.btnBorrowers.Name = "btnBorrowers";
            this.btnBorrowers.Size = new System.Drawing.Size(130, 99);
            this.btnBorrowers.TabIndex = 1;
            this.btnBorrowers.Text = "&BORROWERS";
            this.btnBorrowers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrowers.TileImage = global::Lending_Management_System.Properties.Resources.appbar_group;
            this.btnBorrowers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrowers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBorrowers.UseCustomBackColor = true;
            this.btnBorrowers.UseSelectable = true;
            this.btnBorrowers.UseTileImage = true;
            this.btnBorrowers.Click += new System.EventHandler(this.btnBorrowers_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.ActiveControl = null;
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(83)))));
            this.btnConfig.Location = new System.Drawing.Point(650, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(130, 99);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "CON&FIGURATION";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.TileImage = global::Lending_Management_System.Properties.Resources.appbar_settings;
            this.btnConfig.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfig.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfig.UseCustomBackColor = true;
            this.btnConfig.UseSelectable = true;
            this.btnConfig.UseTileImage = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.ActiveControl = null;
            this.btnLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(58)))));
            this.btnLoans.Location = new System.Drawing.Point(0, 0);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(130, 99);
            this.btnLoans.TabIndex = 2;
            this.btnLoans.Text = "&LOANS";
            this.btnLoans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoans.TileImage = global::Lending_Management_System.Properties.Resources.appbar_money;
            this.btnLoans.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoans.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnLoans.UseCustomBackColor = true;
            this.btnLoans.UseSelectable = true;
            this.btnLoans.UseTileImage = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.ActiveControl = null;
            this.btnSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(58)))));
            this.btnSummary.Location = new System.Drawing.Point(520, 0);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(130, 99);
            this.btnSummary.TabIndex = 6;
            this.btnSummary.Text = "&SUMMARY";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSummary.TileImage = global::Lending_Management_System.Properties.Resources.appbar_book_list;
            this.btnSummary.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSummary.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSummary.UseCustomBackColor = true;
            this.btnSummary.UseSelectable = true;
            this.btnSummary.UseTileImage = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.ActiveControl = null;
            this.btnCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(58)))));
            this.btnCollection.Location = new System.Drawing.Point(260, 0);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(130, 99);
            this.btnCollection.TabIndex = 3;
            this.btnCollection.Text = "&COLLECTION";
            this.btnCollection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCollection.TileImage = global::Lending_Management_System.Properties.Resources.appbar_layer1;
            this.btnCollection.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCollection.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCollection.UseCustomBackColor = true;
            this.btnCollection.UseSelectable = true;
            this.btnCollection.UseTileImage = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnCollectibles
            // 
            this.btnCollectibles.ActiveControl = null;
            this.btnCollectibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollectibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btnCollectibles.Location = new System.Drawing.Point(390, 0);
            this.btnCollectibles.Name = "btnCollectibles";
            this.btnCollectibles.Size = new System.Drawing.Size(130, 99);
            this.btnCollectibles.TabIndex = 4;
            this.btnCollectibles.Text = "C&OLLECTABLES";
            this.btnCollectibles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCollectibles.TileImage = global::Lending_Management_System.Properties.Resources.appbar_layer_up;
            this.btnCollectibles.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCollectibles.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCollectibles.UseCustomBackColor = true;
            this.btnCollectibles.UseSelectable = true;
            this.btnCollectibles.UseTileImage = true;
            this.btnCollectibles.Click += new System.EventHandler(this.btnCollectibles_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(748, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(385, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Time";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsertype
            // 
            this.lblUsertype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsertype.BackColor = System.Drawing.Color.Transparent;
            this.lblUsertype.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsertype.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUsertype.Location = new System.Drawing.Point(742, 21);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(391, 23);
            this.lblUsertype.TabIndex = 7;
            this.lblUsertype.Text = "Time";
            this.lblUsertype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::Lending_Management_System.Properties.Resources.appbar_people;
            this.pictureBox5.Location = new System.Drawing.Point(1114, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(117)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.lblToday);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 80);
            this.panel2.TabIndex = 11;
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToday.Location = new System.Drawing.Point(840, 40);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(67, 23);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Today";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(1035, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Lending_Management_System.Properties.Resources.appbar_calendar;
            this.pictureBox3.Location = new System.Drawing.Point(770, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lending_Management_System.Properties.Resources.appbar_gauge_50;
            this.pictureBox2.Location = new System.Drawing.Point(0, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::Lending_Management_System.Properties.Resources.appbar_clock;
            this.pictureBox4.Location = new System.Drawing.Point(965, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Lending_Management_System.Properties.Resources._53657255_262625554690736_7683626321368317952_n;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1213, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 564);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnBorrowers;
        private MetroFramework.Controls.MetroTile btnLoans;
        private MetroFramework.Controls.MetroTile btnCollection;
        private MetroFramework.Controls.MetroTile btnCollectibles;
        private MetroFramework.Controls.MetroTile btnSummary;
        private MetroFramework.Controls.MetroTile btnConfig;
        private MetroFramework.Controls.MetroTile btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}