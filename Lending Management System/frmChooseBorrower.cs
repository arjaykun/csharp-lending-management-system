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
    public partial class frmChooseBorrower : Form
    {
        public delegate void DoEvent(string id, string name);
        public event DoEvent borrower;
        private Borrowers b = new Borrowers();
        public frmChooseBorrower()
        {
            InitializeComponent();
        }

        private void frmChooseBorrower_Load(object sender, EventArgs e)
        {
            if(txtSearch.Focused == false)
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string text = txtSearch.Text.ToUpper();
                IEnumerable<BorrowerModel> borrowers = b.GetAll().Where(b => b.FullName.ToUpper().Contains(text)).ToList();

                lstBorrowers.DataSource = null;
                lstBorrowers.DataSource = borrowers;
                lstBorrowers.DisplayMember = "FullName";
                lstBorrowers.ValueMember = "Id";
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private async void lstBorrowers_DoubleClick(object sender, EventArgs e)
        {
            await choose();
        }

        private async void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstBorrowers.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Borrower!");
                return;
            }
            await choose();
        }

        private async Task choose()
        {
            int id = int.Parse(lstBorrowers.SelectedValue.ToString());
            BorrowerModel output = await b.GetSingle(id);
            string borrowerId = output.BorrowerID;
            string name = output.FullName;

            borrower(borrowerId, name);
            this.Close();
        }
    }
}
