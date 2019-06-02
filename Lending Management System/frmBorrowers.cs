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
    public partial class frmBorrowers : Form
    {
        Borrowers borrower = new Borrowers();
        ImageFunction img = new ImageFunction();
        string _image = "default.png";
        public string operation = "";
        public int id;
        public bool bdayValidation = false;
        public frmBorrowers()
        {
            InitializeComponent();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmViewBorrowers frm = new frmViewBorrowers())
            {
                frm.ShowDialog();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlBorrower.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (this.ValidateInputs(txtFirstName.Text, txtLastname.Text, txtMiddlename.Text, txtAddress.Text, txtContacts.Text, txtBday.Text,
                txtOccupation.Text, txtMonthlySalary.Text))
            {
                this.Message("Warning! Please Fill Up All Fields.", "Input Validation", true);
                return;
            }

            if (ValidateAlpha(txtFirstName.Text) || ValidateAlpha(txtLastname.Text) || ValidateAlpha(txtOccupation.Text) 
                || ValidateNumeric(txtContacts.Text) || ValidateNumeric(txtMonthlySalary.Text))
            {
                this.Message("Warning! Invalid Characters are Detected. Please use letters and spaces only.", "Input Validation", true);
                return;
            }

            if (bdayValidation)
            {
                this.Message("Warning! Please input correct birthday.", "Input Validation", true);
                return;
            }

            string[] dob = txtBday.Text.Split('/');
            DateTime birthday = new DateTime(int.Parse(dob[2]), int.Parse(dob[0]), int.Parse(dob[1]));
            BorrowerModel b = new BorrowerModel()
            {
                Id = id,
                FirstName = txtFirstName.Text.ToUpper(),
                LastName = txtLastname.Text.ToUpper(),
                MiddleName = txtMiddlename.Text.ToUpper(),
                Address = txtAddress.Text.ToUpper(),
                ContactNumber = txtContacts.Text,
                Birthday = birthday,
                Occupation = txtOccupation.Text.ToUpper(),
                MonthlySalary = Convert.ToDecimal(txtMonthlySalary.Text),
                Gender = optMale.Checked == true ? "MALE" : "FEMALE",
                CivilStatus = cboCivilStatus.SelectedItem.ToString(),
            };

            if (operation == "update")
            {
                b.Image = _image;
                if (await borrower.Update(b))
                {
                    if (b.Image.Contains("default") && b.Image != _image)
                    {
                        img.CopyImage(_image, b.Image);
                    }
                    this.Message(borrower.msg, "Borrower", false);
                    this.Hide();
                    using (frmViewBorrowers frm = new frmViewBorrowers())
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    this.Message(borrower.msg, "Borrower", true);
                }
            }
            else
            {
                b.Image = _image == "default.png" ? "images/" + _image : "images/" + img.RenameImage(_image);
                if (await borrower.Add(b))
                {
                    if (_image != "default.png")
                    {
                        MessageBox.Show(_image);
                        img.CopyImage(_image, b.Image);
                    }
                    this.Message(borrower.msg, "Borrower", false);
                    this.Hide();
                    using (frmViewBorrowers frm = new frmViewBorrowers())
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    this.Message(borrower.msg, "Borrower", true);
                }
            }

        }

        private void txtBday_Leave(object sender, EventArgs e)
        {
            try
            {
                string[] dob = txtBday.Text.Split('/');
                DateTime birthday = new DateTime(int.Parse(dob[2]), int.Parse(dob[0]), int.Parse(dob[1]));
                int age = borrower.ComputeAge(birthday);
                txtAge.Text = age.ToString();
                if (age < 18 )
                {
                    MetroFramework.MetroMessageBox.Show(this, "Age must be 18 years old and above!", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
                    bdayValidation = true;
                    return;
                }
                if (age > 100)
                {
                    MetroFramework.MetroMessageBox.Show(this, "WTF! Are you dracula?", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height / 2);
                    bdayValidation = true;
                    return;
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Input a Valid Birthday", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning, this.Height/ 2);
                bdayValidation = true;
                return;
            }
            bdayValidation = false;
        }

        private bool ValidateInputs(params string[] inputs)
        {
            foreach (string input in inputs)
            {
                if (input == "")
                {
                    return true;
                }
            }

            return false;
        }

        private bool ValidateAlpha(string input)
        {
            Match match = Regex.Match(input, @"^([a-zA-Z- ])+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return true;
            }
            return false;
        }

        private bool ValidateNumeric(string input)
        {
            Match match = Regex.Match(input, @"^([0-9-])+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return true;
            }
            return false;
        }

        private void Message(string msg, string title, bool isError)
        {
            MetroFramework.MetroMessageBox.Show(this, msg, title , MessageBoxButtons.OK, isError ? MessageBoxIcon.Error : MessageBoxIcon.Question , this.Height / 2);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);
                    _image = ofd.FileName;
                }
            }
        }

        private async void frmBorrowers_Load(object sender, EventArgs e)
        {
            if (operation == "view")
            {
                BorrowerModel b =  await borrower.GetSingle(id);
                txtFirstName.Text = b.FirstName;
                txtLastname.Text = b.LastName;
                txtMiddlename.Text = b.MiddleName;
                txtAddress.Text = b.Address;
                txtContacts.Text = b.ContactNumber;
                cboCivilStatus.Text = b.CivilStatus;
                optFemale.Checked = (b.Gender == "FEMALE");
                optMale.Checked = (b.Gender == "MALE");
                txtBday.Text = $"{b.Birthday.Month:00}/{b.Birthday.Day:00}/{b.Birthday.Year}";


                txtMonthlySalary.Text = b.MonthlySalary.ToString();
                txtOccupation.Text = b.Occupation;
                txtAge.Text = borrower.ComputeAge(b.Birthday).ToString();
                picImage.Image = Image.FromFile(b.Image);
                _image = b.Image;
                pnlBorrower.Enabled = false;
                btnSave.Enabled = false;
                if (frmDashboard.user.UserType == "admin")
                {
                    btnDelete.Visible = true;
                }
                btnUpdate.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlBorrower.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            operation = "update";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Loans loans = new Loans();
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this borrower?", "Borrower", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, this.Height/ 2) == DialogResult.Yes)
            {
                if (loans.IfHasLoan(id) == 0)
                {
                    if (await borrower.Delete(id))
                    {
                        this.Message(borrower.msg, "Borrower", false);
                        this.Hide();
                        using (frmViewBorrowers frm = new frmViewBorrowers())
                        {
                            frm.ShowDialog();
                        }
                    }
                    else
                        this.Message(borrower.msg, "Borrower", true);
                }
                else
                    this.Message("Warning! Borrower has an active loan, you can't delete him.", "Borrower", true);
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (ValidateAlpha(txtFirstName.Text))
            {
                this.Message("Warning! Invalid Characters on First Name.", "Input Validation", true);
            }
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (ValidateAlpha(txtLastname.Text))
            {
                this.Message("Warning! Invalid Characters on Last Name.", "Input Validation", true);
            }
        }

        private void txtMiddlename_Leave(object sender, EventArgs e)
        {
            if (ValidateAlpha(txtMiddlename.Text))
            {
                this.Message("Warning! Invalid Characters on Middle Name.", "Input Validation", true);
            }
        }

        private void txtOccupation_Leave(object sender, EventArgs e)
        {
            if (ValidateAlpha(txtOccupation.Text))
            {
                this.Message("Warning! Invalid Characters on Occupation.", "Input Validation", true);
            }
        }

        private void txtContacts_Leave(object sender, EventArgs e)
        {
            if (ValidateNumeric(txtContacts.Text))
            {
                this.Message("Warning! Invalid Characters on Contacts. example 09369206075 or 2131316", "Input Validation", true);
            }
        }

        private void txtMonthlySalary_Leave(object sender, EventArgs e)
        {
            if (ValidateNumeric(txtMonthlySalary.Text))
            {
                this.Message("Warning! Invalid Characters on Monthly Salary.", "Input Validation", true);
            }
        }
    }
}
