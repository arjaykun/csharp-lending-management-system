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
    public partial class frmConfig : Form
    {
        private Interests interests = new Interests();
        private Users users = new Users();
        private bool isLoad = false, isShow = false;
        private string operation = "", tempUsername = "";
        private int userId = 0;
        //operation = add / edit
        public frmConfig()
        {
            InitializeComponent();
            LoadInterest();
            LoadUsers();

            isLoad = true;
        }

        private void LoadInterest()
        {
            cboPaymentTerm.DataSource = interests.Get();
            cboPaymentTerm.ValueMember = "Id";
            cboPaymentTerm.DisplayMember = "Description";

            cboPaymentTerm.SelectedIndex = -1;
        }

        private void LoadUsers()
        {
            cboUserType.Items.Add("admin");
            cboUserType.Items.Add("collector");

            LoadUserList();

            lstUsers.SelectedIndex = -1;
        }

        private async void LoadUserList()
        {
            lstUsers.DataSource = await users.GetAll();
            lstUsers.ValueMember = "Id";
            lstUsers.DisplayMember = "Name2";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPaymentTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad)
            {
                double rate = interests.getInterest(int.Parse(cboPaymentTerm.SelectedValue.ToString()));
                txtInterest.Text = rate.ToString();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            pnlInterests.Visible = true;
            pnlUsers.Visible = false;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            pnlInterests.Dock = DockStyle.Fill;
            pnlUsers.Dock = DockStyle.Fill;

            pnlInterests.Visible = true;
        }

      
        private void panel4_Click(object sender, EventArgs e)
        {
            pnlUsers.Visible = true;
            pnlInterests.Visible = false;
        }

        private void lstUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoad)
            {
                if (lstUsers.SelectedIndex == -1)
                {
                    return;
                }
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                FillFields();
            }
        }

        private void FillFields()
        {
            UserModel user = (UserModel)lstUsers.SelectedItem;
            txtName.Text = user.Name;
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            cboUserType.SelectedItem = user.UserType;
            tempUsername = user.Username;
            userId = user.Id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnabledDisabled(true);
            ClearFields();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            lstUsers.Enabled = false;
            btnSaveUser.Enabled = true;
            operation = "add";
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboUserType.SelectedIndex = -1;
        }

        private void EnabledDisabled(bool status)
        {
            txtName.Enabled = status;
            txtUsername.Enabled = status;
            txtPassword.Enabled = status;
            cboUserType.Enabled = status;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledDisabled(true);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            lstUsers.Enabled = false;
            btnSaveUser.Enabled = true;
            operation = "edit";
        }

        private async void metroTile1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || cboUserType.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Fill up all fields.", "Add User",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAlpha(txtName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Name must be letters and spaces only.", "Add User",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            UserModel user = new UserModel()
            {
                Name = txtName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                UserType = cboUserType.SelectedItem.ToString()
            };
           
            if (operation == "add")
            {
                if (users.IfUsernameExist(user.Username))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username already exists!", "Add User",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                else
                {
                    if (await users.Add(user))
                    {
                        MetroFramework.MetroMessageBox.Show(this, users.msg, "Add User",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                        LoadUserList();
                        Reset();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, users.msg, "Add User",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (operation == "edit")
            {
                if (tempUsername != user.Username)
                {
                    if (users.IfUsernameExist(user.Username))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Username already exists!", "Update User",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                UpdateUser(user);
            }
            
        }

        private async void UpdateUser(UserModel user)
        {
            if (await users.Update(user, userId))
            {
                MetroFramework.MetroMessageBox.Show(this, users.msg, "Update User",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadUserList();
                Reset();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, users.msg, "Update User",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void Reset()
        {
            ClearFields();
            lstUsers.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveUser.Enabled = false;
            EnabledDisabled(false);
            operation = "";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Delete User", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isAdmin = cboUserType.SelectedItem.ToString().ToLower() == "admin" ? true : false;
                if (await users.Delete(userId, isAdmin))
                {
                    MetroFramework.MetroMessageBox.Show(this, users.msg, "Delete User",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    LoadUserList();
                    Reset();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, users.msg, "Delete User",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool IsNumeric(string input)
        {
            Match match = Regex.Match(input, @"^([0-9.])+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
               return false;
            }
            
            return true;
        }

        private bool IsAlpha(string input)
        {
            Match match = Regex.Match(input, @"^([a-zA-Z ])+$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return false;
            }

            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInterest.Text == "" || cboPaymentTerm.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Interest rate must have a value.", "Interest",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumeric(txtInterest.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Interest rate must be a number.", "Interest",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.Parse(txtInterest.Text) <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warning! Interest rate must have a valid value not 0 or negative.", "Interest",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            decimal rate = Convert.ToDecimal(txtInterest.Text);
            int id = int.Parse(cboPaymentTerm.SelectedValue.ToString());

            if (await interests.Update(rate, id))
            {
                MetroFramework.MetroMessageBox.Show(this, interests.msg, "Interest",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, interests.msg, "Interest",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel4_Click_1(object sender, EventArgs e)
        {
            pnlUsers.Visible = true;
            pnlInterests.Visible = false;
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
