using LMSLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending_Management_System
{
    public partial class frmRemittance : Form
    {

        private Collectables collectables = new Collectables();
        private Collections collections = new Collections();
        private CollectionModel collection = new CollectionModel();
        public int loanId, collectableId;
        public decimal totalBalance;
        public bool isError = false;
        public delegate void DoEvent();
        public event DoEvent refresh;
        private string random = "ABCDEFGHIJKL1234567890";
        public frmRemittance()
        {
            InitializeComponent();
        }

        public async void LoadFields()
        {
            CollectablesModel collectable = await collectables.GetSingle(loanId);
            

            picImage.Image = Image.FromFile(collectable.Borrower.Image);
            txtBorrowerId.Text = collectable.Borrower.BorrowerID;
            txtBorrowerName.Text = collectable.Borrower.FullName;
            txtMaturity.Text = collectable.Loan.MaturityValue.ToString("c");
            txtPerRemit.Text = collectable.Loan.PerRemittance.ToString("c");
            txtCollector.Text = collectable.Loan.Collector;
            txtLoanId.Text = collectable.Loan.LoanId;
            txtDueDate.Text = $"{collectable.DueDate.Month}/{collectable.DueDate.Day}/{collectable.DueDate.Year}";
            txtDueAmount.Text = collectable.Loan.PerRemittance.ToString("c");
            txtBalance.Text = (collectable.Loan.TotalBalance - collectable.Loan.PerRemittance).ToString("c");
            totalBalance = collectable.Loan.TotalBalance;
            txtAmount.Text = collectable.Loan.PerRemittance.ToString("c");
            txtTotalBal.Text = collectable.Loan.TotalBalance.ToString("c");
            collectableId = collectable.Id;

            txtTO.Text = frmDashboard.user.Name;
            txtPaidBy.Text = collectable.Borrower.FullName;
            collection.Amount = collectable.Loan.PerRemittance;
            collection.Date = DateTime.Now;
            collection.LoanId = loanId;
            collection.BorrowerId = collectable.Borrower.Id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRemittance_Load(object sender, EventArgs e)
        {
            string rand = "";
            Random r = new Random();
            for (int i = 0; i < 9; i++)
            {
                rand += "" + random[r.Next(random.Length)];
            }
            lblOR.Text += rand;
            lblDate.Text = DateTime.Today.ToString("MM/dd/yyyy");
            LoadFields();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            isError = false;
            Match match = Regex.Match(txtAmount.Text, @"^([0-9])+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                isError = true;
                return;
            }
            else
            {
                decimal newBalance = totalBalance - Convert.ToDecimal(txtAmount.Text.Substring(1));
                if (newBalance < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Amount to pay could not be greater than the balance! try again.","Remittance",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtBalance.Text = newBalance.ToString("c");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Bitmap memoryImage = new System.Drawing.Bitmap(this.Width, panel3.Height);
            panel3.DrawToBitmap(memoryImage, new Rectangle(0, 0, panel3.Width, panel3.Height));
            e.Graphics.DrawImage(memoryImage, 120, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (PrintPreviewDialog ppd = new PrintPreviewDialog())
            {
                ppd.Document = printDocument1;
                ppd.PrintPreviewControl.Zoom = 1;
                ppd.Width = this.Width;
                ppd.Height = this.Height;
                ppd.ShowDialog();
            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            Loans l = new Loans();

            decimal balance = Convert.ToDecimal(txtBalance.Text.Substring(1));
            if (await collectables.Delete(collectableId))
            {
                if (await l.UpdateBalance(loanId, balance))
                {
                    if (await collections.Add(collection))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Remittance is Successfully Submitted. New Balance is Updated.", "Remittance",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                        btnPrint.Visible = true;
                        refresh();
                    }
                }
            }
        }
        
    }
}
