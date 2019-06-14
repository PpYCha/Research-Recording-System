using ResearchRecordingSystemInCollegeOfScience;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ResearchRecordingSystemInCollegeOfScience.Properties
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool LoginAsGuest = false;
        public bool LoginAsClerk = false;

        private void bt_Login_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void ValidateUser()
        {
            using (RRSContext ctx = new RRSContext())
            {
                var user = ctx.UserAccounts.Where(u => u.Username.Equals(tb_Username.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.UserPassword != tb_UserPassword.Text)
                    {
                        MessageBox.Show("Invalid Password.");
                    }
                    else if (user.IsActive == false)
                    {
                        MessageBox.Show("Your Account is suspended. Please contact the administraor");


                    }
                    else if (user.UserRole == "Clerk")
                    {
                        LoginAsClerk = true;
                        this.Close();
                        this.Dispose();
                    }

                    else
                    {

                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("No (" + tb_Username.Text + ") user found");
                }
            }
        }

        private void bt_LoginGuest_Click(object sender, EventArgs e)
        {
            LoginAsGuest = true;
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
