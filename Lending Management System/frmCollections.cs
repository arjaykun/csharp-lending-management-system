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
    public partial class frmCollections : Form
    {
        private Collections collections = new Collections();
        private IEnumerable<CollectionModel> c;
        public frmCollections()
        {
            InitializeComponent();
            FillFilters();
        }
        private async Task FillCollections()
        {
            lstCollectables.Items.Clear();
            c = await collections.GetAll();
            if (cboYear.SelectedIndex != -1 || cboMonth.SelectedIndex != -1 || cboCollector.SelectedIndex != -1)
            {
                if (cboYear.SelectedIndex != -1)
                {
                    int year = int.Parse(cboYear.SelectedItem.ToString());
                    c = c.Where(col => col.Date.Year == year);
                }
                if (cboMonth.SelectedIndex != -1)
                {
                    int month = cboMonth.SelectedIndex + 1;
                    c = c.Where(col => col.Date.Month == month);
                }
                if (cboCollector.SelectedIndex != -1)
                {
                    UserModel user = (UserModel)cboCollector.SelectedItem;
                    c = c.Where(col => col.Loan.CollectorId == user.Id);
                }   
            }
            decimal totalCollections = 0;
            decimal totalInterest = 0;

            foreach (CollectionModel collection in c)
            {
                totalCollections += collection.Amount;
                totalInterest += (collection.Loan.Interest / collection.Loan.Duration);
            }

            lblInterest.Text = totalInterest.ToString("c");
            lblTotal.Text = totalCollections.ToString("c");
            FillListView(c);

        }
        public void FillListView(IEnumerable<CollectionModel> collections)
        {
            foreach (CollectionModel c in collections)
            {
                ListViewItem id = new ListViewItem(c.Loan.LoanId);
                ListViewItem.ListViewSubItem[] subitems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem() { Text = $"{c.Date.Month}/{c.Date.Day}/{c.Date.Year}   " + c.Date.ToShortTimeString()},
                    new ListViewItem.ListViewSubItem() { Text = c.Borrower.FullName},
                    new ListViewItem.ListViewSubItem() { Text = c.Amount.ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = (c.Loan.Interest / c.Loan.Duration).ToString("c")},
                    new ListViewItem.ListViewSubItem() { Text = c.Loan.Collector },
                };
                id.SubItems.AddRange(subitems);
                lstCollectables.Items.Add(id);
            }
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
            
            Users user = new Users();
            cboCollector.DataSource = await user.GetAll();
            cboCollector.ValueMember = "Id";
            cboCollector.DisplayMember = "Name";

            cboYear.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboCollector.SelectedIndex = -1;
        }

        private async void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FillCollections();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string totalC = lblTotal.Text;
            string totalI = lblInterest.Text;
            string date = $"{DateTime.Now.Month}/{DateTime.Now.Day}/{DateTime.Now.Year}";
            using (frmPrintCollections frm = new frmPrintCollections(totalC, totalI, date))
            {
                frm.collections = c;
                frm.ShowDialog();
            }
        }

        private async void metroTile4_Click(object sender, EventArgs e)
        {
            cboYear.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboCollector.SelectedIndex = -1;

            await FillCollections();
        }

        private async void frmCollections_Load(object sender, EventArgs e)
        {
            await FillCollections();
        }
    }
}
