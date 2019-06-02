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
    public partial class frmViewBorrowers : Form
    {
        private Borrowers borrowers = new Borrowers();
        public frmViewBorrowers()
        {
            InitializeComponent();
            LoadBorrowers();
        }

        private void LoadBorrowers()
        {
            IEnumerable<BorrowerModel> borrower = borrowers.GetAll();
            FillListView(borrower);
        }

        private void FillListView(IEnumerable<BorrowerModel> borrower)
        {
            lstBorrowers.Items.Clear();
            foreach (BorrowerModel b in borrower)
            {
                ListViewItem item = new ListViewItem(b.BorrowerID);
                ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, b.FullName);
                ListViewItem.ListViewSubItem address = new ListViewItem.ListViewSubItem(item, b.Address);
                ListViewItem.ListViewSubItem contacts = new ListViewItem.ListViewSubItem(item, b.ContactNumber);
                ListViewItem.ListViewSubItem occupation = new ListViewItem.ListViewSubItem(item, b.Occupation);
                ListViewItem.ListViewSubItem salary = new ListViewItem.ListViewSubItem(item, b.MonthlySalary.ToString("c"));
                ListViewItem.ListViewSubItem gender = new ListViewItem.ListViewSubItem(item, b.Gender);
                item.SubItems.Add(name);
                item.SubItems.Add(address);
                item.SubItems.Add(contacts);
                item.SubItems.Add(occupation);
                item.SubItems.Add(salary);
                item.SubItems.Add(gender);
                lstBorrowers.Items.Add(item);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBorrowers frm = new frmBorrowers())
            {
                frm.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lstBorrowers.SelectedItems.Count > 0)
            {
                string token = lstBorrowers.SelectedItems[0].Text.Substring(4);
                int id = int.Parse(token);

                this.Hide();
                using (frmBorrowers frm = new frmBorrowers())
                {
                    frm.id = id;
                    frm.operation = "view";
                    frm.ShowDialog();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select An Item to Continue", "View", MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height/ 2);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToLower();
            List<BorrowerModel> borrower = borrowers.GetAll().ToList();
            borrower = borrower.Where( b=> b.FullName.ToLower().Contains(txt) || b.BorrowerID.ToLower().Contains(txt) ).ToList();
            FillListView(borrower);
        }

        private void frmViewBorrowers_Load(object sender, EventArgs e)
        {

        }
    }
}
