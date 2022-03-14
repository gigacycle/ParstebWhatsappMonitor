using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
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
            cbDbCatalog.Text = Properties.Settings.Default.txtSqlCatalog;
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (!ConnectionCheck(cbDbCatalog.Text, txtDbServerAddress.Text, txtDbUserName.Text, txtDbPassword.Text))
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
            Properties.Settings.Default.txtSqlCatalog = cbDbCatalog.Text;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSQLTest_Click(object sender, EventArgs e)
        {
            if (ConnectionCheck("", txtDbServerAddress.Text, txtDbUserName.Text, txtDbPassword.Text))
            {
                FailedMessage.Visible = false;
                SucceedMessage.Visible = true;

                _sqlConnection.Open();
                DataTable databases = _sqlConnection.GetSchema("Databases");
                cbDbCatalog.Items.Clear();
                foreach (DataRow database in databases.Rows) //Filling Data Bases ComboBox
                {
                    string databaseName = database.Field<String>("database_name");
                    cbDbCatalog.Items.Add(databaseName);
                }
                cbDbCatalog.Text = "";

                #region Select Default Item in ComboBox
                var dbName = (from string item in cbDbCatalog.Items
                              where item.Contains("DB_ParsicExtraTools")
                              select item).FirstOrDefault();
                if (dbName != null)
                {
                    if (cbDbCatalog.Items.Count > 0) cbDbCatalog.SelectedText = (string)dbName;
                }
                else
                {
                    dbName = (from string item in cbDbCatalog.Items
                              where item.Contains("DB_ParsicExtraTools")
                              select item).FirstOrDefault();
                    if (dbName != null)
                    {
                        if (cbDbCatalog.Items.Count > 0) cbDbCatalog.SelectedText = (string)dbName;
                    }
                    else
                    {
                        if (cbDbCatalog.Items.Count > 0) cbDbCatalog.SelectedIndex = 0;
                    }
                }
                #endregion

                cbDbCatalog.Focus();
            }
            else
            {
                FailedMessage.Visible = true;
                SucceedMessage.Visible = false;
            }
        }

        private void btnCancelServerSelection_Click(object sender, EventArgs e)
        {
            selectHostGroupBox.Visible = false;
        }

        private void btnSelectServer_Click(object sender, EventArgs e)
        {
            txtDbServerAddress.Text = cbHosts.Text;
            selectHostGroupBox.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            selectHostGroupBox.Visible = true;
            if (cbHosts.Items.Count <= 0)
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
                    DataTable table = instance.GetDataSources();
                    foreach (DataRow row in table.Rows)
                    {
                        string hostName = row[0].ToString();
                        string instanceName = row[1].ToString();
                        string fullName = (instanceName == "" || instanceName == null) ? hostName : hostName + "\\" + instanceName;
                        cbHosts.Items.Add(fullName);
                    }
                }
                catch { }
                this.Cursor = Cursors.Default;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //reload server list
        }
    }
}
