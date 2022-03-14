using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmLogin : Form
    {

        public PcrUser User = null;

        public frmLogin(string sqlConnectionString)
        {
            InitializeComponent();
            DataAccess.SqlConnectionString = sqlConnectionString;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (DataAccess.IsUsernameExist(((TextBox)sender).Text))
            {
                FailedMessage.Visible = false;
                lblGreenMessage.Text = "The '" + ((TextBox)sender).Text + "' is exist! please enter the password.";
                SucceedMessage.Visible = true;
            }
            else
            {
                FailedMessage.Visible = true;
                lblRedMessage.Text = "The '" + ((TextBox)sender).Text + "' is NOT exist! please enter a valid username.";
                SucceedMessage.Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PcrUser userInfo = DataAccess.GetUserInfo(txtUserName.Text);
            if (userInfo == null)
            {
                if (FailedMessage.Visible)
                    MessageBox.Show("The user not found!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (!SqlConnectionCheck(DataAccess.SqlConnectionString))
                        MessageBox.Show("Cannot connect to the database!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }
            if (userInfo.Authenticate(txtUserName.Text, txtPassword.Text))
            {
                if (userInfo.UserType > 1 && userInfo.IncorrectPasswordAttempts > 4)
                {
                    MessageBox.Show(
                        "Your username is locked from too many incorrect login attempts!\nPlease call your administrator to unlock it!",
                        "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataAccess.UpdateUserIncorrectPassword(userInfo.Username, 0);
                DataAccess.InsertIntoPcrLog(userInfo, userInfo.Username + " logged in successfully!");
                User = userInfo;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DataAccess.UpdateUserIncorrectPassword(userInfo.Username, userInfo.IncorrectPasswordAttempts + 1);
                FailedMessage.Visible = true;
                lblRedMessage.Text = "You've entered an invalid password. Please try again!";
                SucceedMessage.Visible = false;
                MessageBox.Show("Incorrect password!", "Incorrect login attempt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        static bool SqlConnectionCheck(string sqlConnectionString)
        {
            try
            {
                var sqlConnection = new SqlConnection
                {
                    ConnectionString = sqlConnectionString
                };
                sqlConnection.Open();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(btnOK, new EventArgs());
        }
    }
}
