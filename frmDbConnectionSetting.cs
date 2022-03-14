using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmDbConnectionSetting : Form
    {
        private SqlConnection _sqlConnection;

        public frmDbConnectionSetting()
        {
            InitializeComponent();
            txtDbServerAddress.Text = Properties.Settings.Default.txtSqlServerAddress;
            txtDbCatalog.Text = Properties.Settings.Default.txtSqlCatalog;
            txtDbUserName.Text = Properties.Settings.Default.txtUsername;
            txtDbPassword.Text = SecureText.Decrypt(Properties.Settings.Default.txtPassword);
        }

        public static bool SqlConnectionCheck(string sqlConnectionString)
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

        public bool ConnectionCheck(string databaseName, string hostName, string userName, string password)
        {
            try
            {
                string connectionString = string.Format(@"Data Source= {0} ;Initial Catalog={1}; Persist Security Info=True;User ID={2};Password={3}", hostName, databaseName, userName, password);

                _sqlConnection = new SqlConnection
                {
                    ConnectionString = connectionString
                };
                _sqlConnection.Open();
                _sqlConnection.Close();

                DataAccess.SqlConnectionString = connectionString;

                return true;
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, "Save Setting Error : " + e.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (!ConnectionCheck(txtDbCatalog.Text, txtDbServerAddress.Text, txtDbUserName.Text, txtDbPassword.Text))
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Please check database settings.", "Invalid setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Cursor = Cursors.Default;
            Properties.Settings.Default.SqlServerConnectionString = SecureText.Encrypt(DataAccess.SqlConnectionString);
            Properties.Settings.Default.txtSqlServerAddress = txtDbServerAddress.Text;
            Properties.Settings.Default.txtUsername = txtDbUserName.Text;
            Properties.Settings.Default.txtPassword = SecureText.Encrypt(txtDbPassword.Text);
            Properties.Settings.Default.txtSqlCatalog = txtDbCatalog.Text;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
