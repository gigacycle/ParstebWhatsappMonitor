using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = SecureText.Decrypt(Properties.Settings.Default.SqlServerConnectionString);

            #region First time connection string
            if (!frmDbConnectionSetting.SqlConnectionCheck(sqlConnectionString))
            {
                var frm = new frmDbConnectionSetting();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sqlConnectionString = SecureText.Decrypt(Properties.Settings.Default.SqlServerConnectionString);
                    if (!frmDbConnectionSetting.SqlConnectionCheck(sqlConnectionString))
                    {
                        MessageBox.Show("Unfortunately, we can't continue without the right SQL server connection setting!", "Connection String Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Unfortunately, we can't continue without the SQL server connection setting!", "Connection String Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion

            frmLogin loginForm = new frmLogin(sqlConnectionString);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                frmMain.User = loginForm.User;
                Application.Run(new frmMain());
            }
        }
    }
}
