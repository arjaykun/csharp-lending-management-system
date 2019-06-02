using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSLibrary.Classes;
using MetroFramework;
using MaterialSkin;

namespace Lending_Management_System
{
    public partial class frmLogin : Form
    {
        private bool isShow = false;
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green700,
                Accent.LightGreen400, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            UserModel user = new UserModel();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;

           
            if (user.Username == "" && user.Password == "")
            {
                MetroMessageBox.Show(this, "Warning! Please Fill Up all Fieds.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            if (login.login(user))
            { 
                MetroMessageBox.Show(this, login.msg, "Login", MessageBoxButtons.OK , MessageBoxIcon.Question, this.Height/2);

                this.Hide();
                using (frmDashboard frm = new frmDashboard())
                {
                    frmDashboard.username = user.Username;
                    frm.ShowDialog();
                }
            }
            else
                MetroMessageBox.Show(this, login.msg, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!isShow)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShow.Image = Properties.Resources.appbar_eye_hide;
                isShow = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShow.Image = Properties.Resources.appbar_eye;
                isShow = false;
            }
        }
    }
}
