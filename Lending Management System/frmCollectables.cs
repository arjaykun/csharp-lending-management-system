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
    public partial class frmCollectables : Form
    {
        private Loans loans = new Loans();
        private Collectables cols = new Collectables();
        private Interests interests = new Interests();
        private Users users = new Users();
        private bool isLoad = false;
        public frmCollectables()
        {
            InitializeComponent();
        }

        private async void frmCollectables_Load(object sender, EventArgs e)
        {

            cboCollector.SelectedIndex = -1;
            await FillCollectables();
            await FillFilters();

            isLoad = true;
        }


        private async Task FillCollectables()
        {
            lstCollectables.Items.Clear();
            IEnumerable<ILoanModel> _loans = await loans.GetAll();
            IEnumerable<CollectablesModel> _collectables = await cols.GetAll();

            var collectables = _loans.Join(_collectables, l => l.LoanId, b => b.Loan.LoanId, 
                                            (l, b) => new {
                                                l.LoanId, b.Borrower.FullName, l.PerRemittance, l.PaymentTerm, b.Loan.Collector, l.TotalBalance
                                            }).Distinct();


            if (cboCollector.SelectedIndex != -1)
            {
                UserModel user = (UserModel)cboCollector.SelectedItem;
                collectables = collectables.Where(col => col.Collector == user.Name);
            }

            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    collectables = collectables.Where(col => col.FullName.ToUpper().Contains(textBox1.Text.ToUpper()));
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to find the borrower! Please Try Again.");
                }
            }
            

            lblTotal.Text = CalculateCollectibles(collectables).ToString("c");
            FillListView(collectables);

        }

        public decimal CalculateCollectibles(IEnumerable<dynamic> collectables)
        {
            decimal output = 0;
            foreach (dynamic c in collectables)
            {
                output += c.TotalBalance;
            }

            return output;
        }

        public async Task FillFilters()
        {
            
            Users user = new Users();
            cboCollector.DataSource = await user.GetAll();
            cboCollector.ValueMember = "Id";
            cboCollector.DisplayMember = "Name";

        }

        public void FillListView(IEnumerable<dynamic> collectables)
        {
            foreach (dynamic c in collectables)
            {
                ListViewItem id = new ListViewItem(c.LoanId);
                ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem() { Text = c.TotalBalance.ToString("c") },
                    new ListViewItem.ListViewSubItem() { Text = c.FullName},
                    new ListViewItem.ListViewSubItem() { Text = c.PerRemittance.ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = c.PaymentTerm},
                    new ListViewItem.ListViewSubItem() { Text = c.Collector },
                    new ListViewItem.ListViewSubItem() { Text = c.LoanId.ToString() }
                };
                id.SubItems.AddRange(subitems);
                lstCollectables.Items.Add(id);
            }
        }
        

        private async void metroTile4_Click(object sender, EventArgs e)
        {
            cboCollector.SelectedIndex = -1;
            textBox1.Text = "";
            await FillCollectables();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstCollectables.SelectedItems.Count > 0)
            {
                string token = lstCollectables.SelectedItems[0].Text.Substring(4);
                int id = int.Parse(token);

                using (frmRemittance frm = new frmRemittance())
                {
                    frm.refresh += Frm_refresh;
                    frm.loanId = id;
                    frm.ShowDialog();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this,"Please select a row to remit.", "Remit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void Frm_refresh()
        {
            await FillCollectables();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            cboCollector.SelectedIndex = -1;
        }

        private async void cboCollector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad)
            {
                await FillCollectables();
            }
        }

        private async void textBox1_Leave(object sender, EventArgs e)
        {
            await FillCollectables();
        }

        private async void metroTile1_Click(object sender, EventArgs e)
        {
            await FillCollectables();
        }
    }
}
