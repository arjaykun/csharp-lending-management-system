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
    public partial class frmNewLoan : Form
    {
        private Interests interests = new Interests();
        private Users users = new Users();
        private UserModel user = new UserModel();
        private Loans loans = new Loans();
        private Borrowers borrowers = new Borrowers();
        private ILoanModel loan = new LoanModel();
        public int collectorId;
        public bool isLoad = false, isGenerated = false;
        public int loanId;
        public string operation;

        public frmNewLoan()
        {
            InitializeComponent();
            LoadInterests();
        }

        private void frmNewLoan_Load(object sender, EventArgs e)
        {
            user = users.GetSingle(frmDashboard.username);

            if (operation == "view")
            {
                if (user.UserType != "admin")
                {
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                }
                else
                {
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                }
                btnSearch.Visible = false;
                btnSave.Enabled = false;
                lblLoanId.Visible = true;
                txtLoanId.Visible = true;
                btnPrint.Visible = true;
                LoadLoan();
            }
            else
            {
                DateTime today = DateTime.Today;
                txtEffectiveDate.Text = $"{today.Month:00}/{today.Day:00}/{today.Year:0000}";
                cboPaymentTerm.SelectedIndex = -1;
                txtCollector.Text = user.Name;
            }
            
            isLoad = true;
        }

        private async void LoadLoan()
        {
            LoanModel l = await loans.GetSingle(loanId);
            BorrowerModel b = await borrowers.GetSingle(l.BorrowerId);
            txtId.Text = b.BorrowerID;
            txtName.Text = b.FirstName + " "+ b.MiddleName[0] + ". " + b.LastName;
            txtLoanId.Text = l.LoanId;
            txtDuration.Text = l.Duration.ToString();
            txtEffectiveDate.Text = ConvertDate(l.EffectiveDate);
            txtInterest.Text = l.Interest.ToString();
            txtMaturityDate.Text = ConvertDate(l.MaturityDate);
            txtPerRemittance.Text = l.PerRemittance.ToString();
            txtPrincipal.Text = l.PrincipalLoan.ToString();
            txtMaturityValue.Text = l.MaturityValue.ToString();
            txtTotalBalance.Text = l.TotalBalance.ToString();
            cboPaymentTerm.SelectedValue = l.InterestId;
            txtCollector.Text = users.GetSingle(" ", l.CollectorId).Name;
            gName.Text = l.Guarantor.Name;
            gAddress.Text = l.Guarantor.Address;
            gContacts.Text = l.Guarantor.ContactNumber;
            gRelation.Text = l.Guarantor.Relationship;
            cValue.Text = l.Collateral.Value.ToString();
            cItem.Text = l.Collateral.Item;
            cDescription.Text = l.Collateral.Description;
            btnPrint.Visible = true;
            int _id = int.Parse(cboPaymentTerm.SelectedValue.ToString());
            double interest = interests.getInterest(_id);

            txtInterestRate.Text = $"{interest: ##.##}%";

            Generate();
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (frmChooseBorrower frm = new frmChooseBorrower())
            {
                frm.borrower += chooseBorrower;
                frm.ShowDialog();
            }
        }

        private void LoadInterests()
        {
            cboPaymentTerm.DataSource = interests.Get();
            cboPaymentTerm.ValueMember = "Id";
            cboPaymentTerm.DisplayMember = "Description";         }

        private void chooseBorrower(string id, string name)
        {
            txtId.Text = id;
            txtName.Text = name;

            string token = id.Substring(4);
            int borrowerId = int.Parse(token);
            int result = loans.IfHasLoan(borrowerId);
            if (result != 0)
            {
                operation = "view";
                if (user.UserType != "admin")
                {
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                }
                else
                {
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                }
                lblLoanId.Visible = true;
                txtLoanId.Visible = true;
                btnSave.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                loanId = result;
                LoadLoan();
            } 
            else
            {
                loanId = 0;

                btnSave.Enabled = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;

                txtCollector.Text = user.Name;
                txtPrincipal.Text = "";
                txtDuration.Text = "";
                txtInterestRate.Text = "";
                cboPaymentTerm.SelectedIndex = 0;
                DateTime today = DateTime.Today;
                txtEffectiveDate.Text = $"{today.Month:00}/{today.Day:00}/{today.Year:0000}";

                gName.Text = "";
                gAddress.Text = "";
                gContacts.Text = "";
                gRelation.Text = "";

                cDescription.Text = "";
                cValue.Text = "";
                cItem.Text = "";

                lstLedger.Items.Clear();
                txtMaturityDate.Text = "";
                txtPerRemittance.Text = "";
                txtMaturityValue.Text = "";
                txtInterest.Text = "";
                txtTotalBalance.Text = "";
                txtLoanId.Visible = false;
                lblLoanId.Visible = false;
            
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;

                operation = "";
            }
        }

        private void cboPaymentTerm_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoad == true)
            {
                int id = int.Parse(cboPaymentTerm.SelectedValue.ToString());
                double interest = interests.getInterest(id);

                txtInterestRate.Text = $"{interest: ##.##}%";
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Delete Loan", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string token = txtLoanId.Text.Substring(4);
                int _id = int.Parse(token);
                await loans.Delete(_id);
                Collectables c = new Collectables();
                Collections c2 = new Collections();
                c.DeleteCollectables(_id);
                c2.DeleteCollections(_id);
                MetroFramework.MetroMessageBox.Show(this, loans.msg, "Delete Loan", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDuration.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Please Fill-up All Required Fields.", "Loan", MessageBoxButtons.OK,
                      MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            if (!isGenerated)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Invalid Loan Details", "Loan", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            if (int.Parse(txtDuration.Text) > 100)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Duration exceeds the limit", "Loan", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            if (!ValidateLoan())
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Invalid Loan Details", "Loan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            if (ifEmpty(gName.Text, gAddress.Text, gContacts.Text, gRelation.Text, cValue.Text, cItem.Text, cDescription.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Please Fill Up All Fields.", "Loan",
                MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            if (!ValidateNumeric(cValue.Text))
            {
                MetroFramework.MetroMessageBox.Show(this,"Warning! Collateral Value Must Be a Number.", "Loan",
                MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
                return;
            }
            
            GuarantorModel guarantor = new GuarantorModel()
            {
                    Name = gName.Text.ToUpper(),
                    Address = gAddress.Text.ToUpper(),
                    ContactNumber = gContacts.Text,
                    Relationship = gRelation.Text.ToUpper()
            };

            CollateralModel collateral = new CollateralModel()
            {
                Item = cItem.Text.ToUpper(),
                Description = cDescription.Text.ToUpper(),
                Value = int.Parse(cValue.Text)
            };

            if (operation != "edit" && operation != "view")
            {
                if (await loans.Add(loan, guarantor, collateral))
                {
                    await SaveLedger(loans.loanId);
                    MetroFramework.MetroMessageBox.Show(this, loans.msg, "Loan", MessageBoxButtons.OK, MessageBoxIcon.Question, this.Height / 2);
                    btnSave.Enabled = false;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, loans.msg, "Loan", MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
                }
            }
            else
            {
                string token = txtLoanId.Text.Substring(4);
                loan.Id = int.Parse(token);
                if (await loans.Update(loan, guarantor, collateral))
                {
                    string token2 = txtLoanId.Text.Substring(4);
                    int id = int.Parse(token2);
                    
                    MetroFramework.MetroMessageBox.Show(this, loans.msg, "Loan", MessageBoxButtons.OK, MessageBoxIcon.Question, this.Height / 2);
                    btnSave.Enabled = false;
                    
                    groupBox1.Enabled = false;
                    groupBox3.Enabled = false;
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                    operation = "view";
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, loans.msg, "Loan", MessageBoxButtons.OK, MessageBoxIcon.Error, this.Height / 2);
                }
            }  
        }
        
        private async Task<bool> SaveLedger(int loanId)
        {
            Collectables c = new Collectables();
            List<CollectablesModel> collectables = new List<CollectablesModel>();
           
            foreach (ListViewItem items in lstLedger.Items)
            {
                LoanModel _loan = new LoanModel() {
                    Id = loanId,
                    PerRemittance = loan.PerRemittance,
                    EffectiveDate = loan.EffectiveDate
                };

                BorrowerModel _borrower = new BorrowerModel()
                {
                    Id = loan.BorrowerId
                };
                string[] tokens = items.Text.Split('/');
                DateTime dueDate = new DateTime(int.Parse(tokens[2]), int.Parse(tokens[0]), int.Parse(tokens[1]));
                collectables.Add( new CollectablesModel() {
                   Loan = _loan,
                   Borrower = _borrower,
                   DueDate = dueDate
                });
            }
            if (operation != "edit")
            {
                if (await c.Add(collectables))
                {
                    return true;
                }
            }
            MessageBox.Show(c.msg);
            return false;
        }

        private bool ifEmpty(params string[] texts)
        {
            foreach (string txt in texts)
            {
                if (txt == "")
                {
                    return true;
                }
            }

            return false;
        }


        private void Generate()
        {
            InterestModel i = (InterestModel)cboPaymentTerm.SelectedItem;
            string term = i.Description;
            int duration = int.Parse(txtDuration.Text);
            double interestRate = i.Rate;
            decimal principal = decimal.Parse(txtPrincipal.Text);
            double rate = interestRate / 100;
            decimal interest = principal * (decimal)rate;
            decimal amount = principal / duration;
            decimal maturityValue = interest + principal;
            decimal perRemit = maturityValue / duration;
            string[] tokens = txtEffectiveDate.Text.Split('/');
            DateTime date = new DateTime(int.Parse(tokens[2]), int.Parse(tokens[0]), int.Parse(tokens[1]));
            string token = txtId.Text.Substring(4);
            string maturityDate = ConvertDate(generateMaturityDate(term, date, duration));
            loan.BorrowerId = int.Parse(token);
            loan.CollectorId = user.Id;
            loan.PrincipalLoan = principal;
            loan.InterestId = i.Id;
            loan.Interest = interest;
            loan.MaturityValue = maturityValue;
            loan.PerRemittance = perRemit;
            loan.Duration = duration;
            loan.EffectiveDate = date;
            loan.TotalBalance = maturityValue;

            string[] tokens2 = maturityDate.Split('/');
            DateTime date2 = new DateTime(int.Parse(tokens2[2]), int.Parse(tokens2[0]), int.Parse(tokens[1]));
            loan.MaturityDate = date2;

            txtInterest.Text = interest.ToString("c");
            txtPerRemittance.Text = perRemit.ToString("c");
            txtMaturityValue.Text = maturityValue.ToString("c");
            decimal balance = 0;
            if (operation != "view")
            {
                txtTotalBalance.Text = maturityValue.ToString();
                balance = maturityValue;
            }
            else
                balance = Convert.ToDecimal(txtTotalBalance.Text.Substring(0));
            txtMaturityDate.Text = maturityDate;
            GenerateLedger(term, date, duration, amount, perRemit - amount, maturityValue, balance);

            isGenerated = true;
        }
        
        private string ConvertDate(DateTime date)
        {
            string output = $"{date.Month:00}/{date.Day:00}/{date.Year}";
            return output;
        }

        private void GenerateLedger(string term, DateTime date, int duration, decimal amount, 
            decimal interest, decimal maturity, decimal balance)
        {
            lstLedger.Items.Clear();
            for (int i = 0; i < duration; i++)
            {
                string newDate = "";
                switch (term)
                {
                    case "Daily":
                        newDate = ConvertDate(date.AddDays(i + 1));
                        break;
                    case "Monthly":
                        newDate = ConvertDate(date.AddMonths(i + 1));
                        break;
                    case "Weekly":
                        newDate = ConvertDate(date.AddDays(7 * (i + 1)));
                        break;
                    case "Semi-Monthly":
                        newDate = ConvertDate(date.AddDays(14 * (i +1)));
                        break;
                    default:
                        break;
                }
                decimal perRemit = (amount + interest);
                ListViewItem item = new ListViewItem(newDate);
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, amount.ToString("c"));
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, interest.ToString("c"));
                ListViewItem.ListViewSubItem subitem3 = new ListViewItem.ListViewSubItem(item, perRemit.ToString("c"));
                ListViewItem.ListViewSubItem subitem4 = new ListViewItem.ListViewSubItem(item, GetStatus(maturity - ( perRemit * i),
                    balance));
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);
                item.SubItems.Add(subitem3);
                item.SubItems.Add(subitem4);
                lstLedger.Items.Add(item);
            }
        }

        private string GetStatus(decimal maturity, decimal balance)
        {
            if (balance >= maturity)
            {
                return "UNPAID";
            }
            return "PAID";
        }

        private DateTime generateMaturityDate(string term, DateTime date, int duration)
        {
            DateTime output = date;
            switch (term)
            {
                case "Monthly":
                    output = date.AddMonths(duration);
                    break;
                case "Weekly":
                    output = date.AddDays(7 * duration);
                    break;
                case "Semi-Monthly":
                    output = date.AddDays(14 * duration);
                    break;
                case "Daily":
                    output = date.AddDays(1 * duration);
                    break;
                default:
                    break;
            }

            return output;
        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {
            if (ValidateLoan())
            {
                Generate();
            }
            
        }

        public bool ValidateLoan()
        {
            DateTime date = DateTime.Now;
            if (txtEffectiveDate.Text != "")
            {
                try
                {
                    string[] tokens = txtEffectiveDate.Text.Split('/');
                    date = new DateTime(int.Parse(tokens[2]), int.Parse(tokens[0]), int.Parse(tokens[1]));
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Warning! You provided an invalid date.", "Loan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
                    return false;
                }
            }
            if (!ValidateNumeric(txtPrincipal.Text, txtDuration.Text))
            {
                return false;
            }

            if (txtDuration.Text == "" && txtPrincipal.Text == "" && cboPaymentTerm.SelectedIndex == -1 && !ValidateDate(date))
            {
                return false;
            }

            if (int.Parse(txtDuration.Text) > 100)
            {
                return false;
            }
            return true;
        }

        private bool ValidateDate(DateTime date)
        {
            try
            {
                DateTime now = DateTime.Today;

                if (operation != "edit")
                {
                    if (date.Date < now)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Date is invalid! It should not be less than today.", "Loan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
                        return false;
                    }
                    TimeSpan diff = date.Subtract(date.AddMonths(1));
                    if (diff.Days > 31)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Date is invalid! It should not be more than a month than today.", "Loan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Date is invalid.", "Loan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
                return false;
            }

            return true;
        }

        private bool ValidateNumeric(params string[] inputs)
        {
            foreach (string input in inputs)
            {
                Match match = Regex.Match(input, @"^([0-9])+$", RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    return false;
                }
            }
            return true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (operation == "view")
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
            }
            else
            {
                if (txtId.Text != "")
                {
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox3.Enabled = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            operation = "edit";
        }

        private List<LedgerModel> GetLedger()
        {
            List<LedgerModel> ledger = new List<LedgerModel>();
            foreach (ListViewItem item in lstLedger.Items)
            {
                ledger.Add(new LedgerModel() {
                    DueDate = item.Text,
                    Amount = item.SubItems[1].Text,
                    Interest = item.SubItems[2].Text,
                    TotalAmount = item.SubItems[3].Text,
                    Status = item.SubItems[4].Text
                });
            }

            return ledger;
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text == "" && txtTotalBalance.Text == "" && txtDuration.Text == "")
            {
                return;
            }
            decimal principal = Convert.ToDecimal(txtPrincipal.Text);
            decimal balance = Convert.ToDecimal(txtTotalBalance.Text);
            this.Hide();
            using (frmPrintReceipt frm = new frmPrintReceipt())
            {
                frm.Ledger = GetLedger();
                frm.principalLoan = principal.ToString("c");
                frm.loanId = txtLoanId.Text;
                frm.borrower = txtName.Text;
                frm.collector = txtCollector.Text;
                frm.maturityValue = txtMaturityValue.Text;
                frm.maturityDate = txtMaturityDate.Text;
                frm.effectiveDate = txtEffectiveDate.Text;
                frm.totalBalance = balance.ToString("c");

                frm.ShowDialog();
            }
        }

        private void txtNew_Click(object sender, EventArgs e)
        {
           pnlBorrower.Enabled = true;
        }
    }
}
