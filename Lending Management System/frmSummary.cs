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
    public partial class frmSummary : Form
    {

        private Loans loanObj = new Loans();
        public frmSummary()
        {
            InitializeComponent();
            FillSummary();
            FillFilters();
        }

        public async void FillSummary()
        {
            lstSummary.Items.Clear();
            IEnumerable<ILoanModel> loans = await loanObj.GetAll();
            if (cboYear.SelectedIndex != -1 || cboMonth.SelectedIndex != -1 || cboPaymentTerm.SelectedIndex != -1 
                || cboCollector.SelectedIndex != -1)
            {
                loans = await loanObj.GetAll();
                if (cboYear.SelectedIndex != -1 )
                {
                    int year = int.Parse(cboYear.SelectedItem.ToString());
                    loans = loans.Where( l => l.EffectiveDate.Year == year);
                }
                if (cboMonth.SelectedIndex != -1)
                {
                    int month = cboMonth.SelectedIndex + 1;
                    loans = loans.Where(l => l.EffectiveDate.Month == month);
                }
                if (cboCollector.SelectedIndex != - 1)
                {
                    UserModel user = (UserModel)cboCollector.SelectedItem;
                    loans = loans.Where(l => l.Collector.ToLower() == user.Name.ToLower());
                }
                if (cboPaymentTerm.SelectedIndex != -1)
                {
                    InterestModel _i = (InterestModel)cboPaymentTerm.SelectedItem;
                    loans = loans.Where(l => l.PaymentTerm.ToLower() == _i.Description.ToLower());
                }
            }

            FillListView(loans);

            //add to statuses
            decimal totalPrincipal = 0;
            decimal totalInterest = 0;
            int numOfLoans = 0;
            foreach (LoanModel l in loans)
            {
                totalPrincipal += l.PrincipalLoan;
                totalInterest += l.Interest;
                numOfLoans += 1;
            }
            lblTotalPrincipal.Text =  totalPrincipal.ToString("c");
            lblTotalInterest.Text =  totalInterest.ToString("c");
            lblNumOfLoans.Text =  numOfLoans.ToString();
        }

        public void FillListView(IEnumerable<ILoanModel> loans)
        {
            foreach (LoanModel l in loans)
            {
                ListViewItem id = new ListViewItem(l.LoanId);
                ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem() { Text = l.BorrowerName},
                    new ListViewItem.ListViewSubItem() { Text = l.PrincipalLoan.ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = l.Interest.ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = l.MaturityValue.ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = l.PaymentTerm },
                    new ListViewItem.ListViewSubItem() { Text = l.PerRemittance.ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = l.Duration.ToString()},
                    new ListViewItem.ListViewSubItem() { Text = l.TotalBalance.ToString("c") },
                    new ListViewItem.ListViewSubItem() { Text = ConvertDate(l.EffectiveDate)},
                    new ListViewItem.ListViewSubItem() { Text = ConvertDate(l.MaturityDate)},
                    new ListViewItem.ListViewSubItem() { Text = l.Collector},
                    new ListViewItem.ListViewSubItem() { Text = (l.TotalBalance == 0) ? "PAID" : "ONGOING" }

                };
                id.SubItems.AddRange(subitems);
                lstSummary.Items.Add(id);
            }
        }  
        
        public string ConvertDate(DateTime date)
        {
            return $"{date.Month}/{date.Day}/{date.Year}";
        }
        public async void FillFilters()
        {
            for (int i = 0; i < DateTime.Now.Year - 2017; i++)
            {
                cboYear.Items.Add((2018 + i).ToString());
            }
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August",
                "September", "October", "November", "December"};
            cboMonth.Items.AddRange(months);

            Interests interest = new Interests();
            cboPaymentTerm.DataSource = interest.Get();
            cboPaymentTerm.ValueMember = "Id";
            cboPaymentTerm.DisplayMember = "Description";

            Users user = new Users();
            cboCollector.DataSource = await user.GetAll();
            cboCollector.ValueMember = "Id";
            cboCollector.DisplayMember = "Name";

            cboYear.SelectedIndex =  - 1;
            cboMonth.SelectedIndex = -1;
            cboPaymentTerm.SelectedIndex = -1;
            cboCollector.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmDashboard frm = new frmDashboard())
            {
                frm.ShowDialog();
            }

        }
        
        private void cboYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillSummary();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            cboYear.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboPaymentTerm.SelectedIndex = -1;
            cboCollector.SelectedIndex = -1;

            FillSummary();
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lstSummary.SelectedItems.Count > 0)
            {
                string token = lstSummary.SelectedItems[0].Text.Substring(4);
                int id = int.Parse(token);
                
                using (frmNewLoan frm = new frmNewLoan())
                {
                    frm.loanId = id;
                    frm.operation = "view";
                    frm.ShowDialog();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select An Item to Continue", "View", MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
            }

        }
    }
}
