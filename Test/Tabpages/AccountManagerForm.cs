using ResearchRecordingSystem;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Test
{
    public partial class AccountManagerForm : Form
    {
        public AccountManagerForm()
        {
            InitializeComponent();
        }

        private void bt_SaveUser_Click(object sender, EventArgs e)
        {

            SaveUser();

        }

        private void SaveUser()
        {
            if (dataGridView_User.SelectedRows.Count > 0)
            {
                using (RRSContext ctx = new RRSContext())
                {
                    foreach (var item in userAccountBindingSource.List)
                    {
                        var account = (UserAccount)item;
                        if (account.UserId <= 0)
                            ctx.UserAccounts.Add(account);
                        else
                        {
                            ctx.UserAccounts.Attach(account);
                            ctx.Entry(account).State = System.Data.Entity.EntityState.Modified;
                        }
                    }

                    ctx.SaveChanges();
                    MessageBox.Show(this, "Update Successfull");
                    LoadData();
                }
            }
            else
            {
                if (!(string.IsNullOrEmpty(tb_FirstName.Text) || string.IsNullOrEmpty(tb_LastName.Text) || (String.IsNullOrEmpty(tb_UserName.Text) ||
                             string.IsNullOrEmpty(tb_UserPassword.Text))))
                {

                    try
                    {
                        using (var ctx = new RRSContext())
                        {
                            if (ctx.UserAccounts.Any(o => o.Username == tb_UserName.Text))
                            {
                                MessageBox.Show("Use different username");
                            }

                            else
                            {
                                var user = new UserAccount()
                                {


                                    FirstName = tb_FirstName.Text,
                                    MiddleName = tb_MiddleName.Text,
                                    LastName = tb_LastName.Text,
                                    Username = tb_UserName.Text,
                                    UserPassword = tb_UserPassword.Text,
                                    UserRole = cb_Role.SelectedItem.ToString(),
                                    IsActive = true,

                                };

                                ctx.UserAccounts.Add(user);
                                ctx.SaveChanges();
                                LoadData();
                                MessageBox.Show(this, "Save Successfull");
                            }

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Select Role");
                    }
                }
                else
                {
                    MessageBox.Show("Please filled up all field)");
                }
            }



            ClearText();
            AccountManagerForm_Load(null, null);

        }

        private void AccountManagerForm_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        private void LoadData()
        {
            using (RRSContext ctx = new RRSContext())
            {
                userAccountBindingSource.DataSource = ctx.UserAccounts.ToList();
            }
            dataGridView_User.ClearSelection();
        }

        private void ClearText()
        {
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_MiddleName.Clear();
            tb_UserName.Clear();
            tb_UserPassword.Clear();
            cb_Role.SelectedIndex = -1;

        }

        private void bt_DeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView_User.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_User.SelectedRows)
                {
                    DeleteUser(row.DataBoundItem);
                    userAccountBindingSource.Remove(row.DataBoundItem);
                }
            }
        }

        private void DeleteUser(object dataBoundItem)
        {
            if (dataBoundItem == null)

                return;

            var account = (UserAccount)dataBoundItem;

            using (RRSContext ctx = new RRSContext())
            {
                var toBeDeleted = ctx.UserAccounts.Where(u => u.UserId == account.UserId).FirstOrDefault();
                if (toBeDeleted == null)
                    return;

                ctx.UserAccounts.Remove(toBeDeleted);
                ctx.SaveChanges();
                MessageBox.Show(this, "Delete Successfull");
            }
        }

        private void bt_EditUser_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void EditUser()
        {
            using (RRSContext ctx = new RRSContext())
            {
                foreach (var item in userAccountBindingSource.List)
                {
                    var account = (UserAccount)item;
                    if (account.UserId <= 0)
                        ctx.UserAccounts.Add(account);
                    else
                    {
                        ctx.UserAccounts.Attach(account);
                        ctx.Entry(account).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                ctx.SaveChanges();
                MessageBox.Show(this, "Save Successfull");
            }
        }

        private void dataGridView_User_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView_User.CurrentRow.Tag != null)
                e.Control.Text = dataGridView_User.CurrentRow.Tag.ToString();
        }

        private void dataGridView_User_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_User.Columns[e.ColumnIndex].Name == "userPasswordDataGridViewTextBoxColumn" && e.Value != null)
            {
                dataGridView_User.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
