using LMSLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending_Management_System
{
    public partial class frmDashboard : Form
    {
        public static string username;
        public Users users = new Users();
        public static UserModel user = new UserModel();
        public frmDashboard()
        {
            InitializeComponent();
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmLogin frm = new frmLogin())
            {
                frm.ShowDialog();
            }
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            using (frmViewBorrowers frm = new frmViewBorrowers())
            {
                frm.ShowDialog();
            }
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            using (frmNewLoan frm = new frmNewLoan())
            {
                frm.ShowDialog();
            }
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            using (frmCollections frm = new frmCollections())
            {
                frm.ShowDialog();
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmSummary frm = new frmSummary())
            {
                frm.ShowDialog();
            }
        }

        private void btnCollectibles_Click(object sender, EventArgs e)
        {
            using (frmCollectables frm = new frmCollectables())
            {
                frm.ShowDialog();
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            user = users.GetSingle(username);
            if (user.UserType != "admin")
            {
                btnConfig.Enabled = false;
                btnSummary.Enabled = false;
            }
            lblToday.Text = DateTime.Today.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblName.Text = user.Name + $"({user.Username})";
            lblUsertype.Text = user.UserType;
            timer1.Start();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            using (frmConfig frm = new frmConfig())
            {
                frm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
