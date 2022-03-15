using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmMain : Form
    {
        private string _apiBaseUrl, _debtorMessage, _organMessage, _doctorMessage, _patientMessage, _organExceptions;
        private int _reloadInterval, _retryInterval, _maxAttempts;
        private bool _dontSendToPatients;
        string _lastFindKey = "";
        long _maxDebtAmount;
        public static PcrUser User = null;

        public frmMain()
        {
            InitializeComponent();
            GetSettingsFromDB();
            dgvMonitor.AutoGenerateColumns = false;
            dgvDoctors.AutoGenerateColumns = false;
            dgvOrgans.AutoGenerateColumns = false;
            txtFromDate.Text = PersianCalendarTools.toPersianDate(DateTime.Now);
            txtToDate.Text = PersianCalendarTools.toPersianDate(DateTime.Now);
            if (User.UserType > 1) whatsappServiceSettingsToolStripMenuItem.Visible = false;
            loadData(false);
        }

        private void GetSettingsFromDB()
        {
            DataAccess.SqlConnectionString = SecureText.Decrypt(Properties.Settings.Default.SqlServerConnectionString);
            _apiBaseUrl = DataAccess.GetSettingValue("wpApiBaseUrl", "http:\\\\172.19.0.2\\");
            int.TryParse(DataAccess.GetSettingValue("wpReloadInterval", "10"), out int reloadInterval);
            int.TryParse(DataAccess.GetSettingValue("wpRetryInterval", "5"), out int retryInterval);
            int.TryParse(DataAccess.GetSettingValue("wpMaxAttempts", "3"), out int maxAttempts);
            _debtorMessage = DataAccess.GetSettingValue("wpDebtorMessage", "مراجعه کننده عزیز @N \nجواب آزمایش شما آماده است و پس از تسویه حساب میتوانید جواب را از وبسایت آزمایشگاه پارس طب به نشانی\nhttps://parsteblab.com/ \nدریافت نمایید.");
            _organMessage = DataAccess.GetSettingValue("wpOrganMessage", "جواب آزمایش @N آماده شده و تقدیم شما میگردد:");
            _doctorMessage = DataAccess.GetSettingValue("wpDoctorMessage", "جواب آزمایش @N آماده شده و تقدیم شما میگردد:");
            _patientMessage = DataAccess.GetSettingValue("wpPatientGreetingMessage", "مراجعه کننده محترم @N\nجواب آزمایش شما توسط آزمایشگاه پارس طب آماده شده و تقدیم شما میگردد");
            bool.TryParse(DataAccess.GetSettingValue("wpDontSentToPatientsByDefault", "False"), out bool dontSendToPatients);
            long.TryParse(DataAccess.GetSettingValue("wpMaxDebtAmount", "100000"), out long maxDebtAmount);
            _organExceptions = DataAccess.GetSettingValue("wpOrganExceptions", "1131, 1173, 1156");

            _reloadInterval = reloadInterval;
            _retryInterval = retryInterval;
            _maxAttempts = maxAttempts;
            _dontSendToPatients = dontSendToPatients;
            _maxDebtAmount = maxDebtAmount;
        }

        private void loadData(bool forceLoad)
        {
            if (tabControl1.SelectedTab == tbDoctors)
            {
                if (dgvDoctors.DataSource == null || forceLoad)
                {
                    frmWait waitDialog = new frmWait("Loading data from database!", "Please wait...");
                    waitDialog.Show();

                    new Thread(() =>
                    {
                        DataTable dt = DataAccess.GetDoctorsCrmSettingsList();
                        try
                        {
                            BeginInvoke(new MethodInvoker(delegate
                            {
                                dgvDoctors.DataSource = dt;
                                waitDialog.Invoke(new Action(() => { waitDialog.Close(); }));
                            }));
                        }
                        catch { }
                    }).Start();
                }
            }
            else if (tabControl1.SelectedTab == tbOrgans)
            {
                if (dgvOrgans.DataSource == null || forceLoad)
                {
                    frmWait waitDialog = new frmWait("Loading data from database!", "Please wait...");
                    waitDialog.Show();

                    new Thread(() =>
                    {
                        DataTable dt = DataAccess.GetOrgansCrmSettingsList();
                        try
                        {
                            BeginInvoke(new MethodInvoker(delegate
                            {
                                dgvOrgans.DataSource = dt;
                                waitDialog.Invoke(new Action(() => { waitDialog.Close(); }));
                            }));
                        }
                        catch { }
                    }).Start();
                }
            }
            else if (tabControl1.SelectedTab == tbMonitor)
            {
                if (dgvMonitor.DataSource == null || forceLoad)
                {
                    if (string.IsNullOrEmpty(txtFromDate.Text) || string.IsNullOrEmpty(txtToDate.Text))
                        return;

                    DateTime from = PersianCalendarTools.toGregorianDate(txtFromDate.Text);
                    DateTime to = PersianCalendarTools.toGregorianDate(txtToDate.Text);
                    int.TryParse(txtAdmitId.Text, out int admitId);

                    if (admitId > 0)
                    {
                        frmWait waitDialog = new frmWait("Loading data from database!", "Please wait...");
                        waitDialog.Show();

                        new Thread(() =>
                        {
                            DataTable dt = DataAccess.GetWhatsappAdmitQueueItem(-1, admitId);
                            try
                            {
                                BeginInvoke(new MethodInvoker(delegate
                                {
                                    dgvMonitor.DataSource = dt;
                                    if (dgvMonitor.RowCount > 0)
                                        lblRowCount.Text = dgvMonitor.RowCount + " Items";
                                    else
                                        lblRowCount.Text = "";
                                    waitDialog.Invoke(new Action(() => { waitDialog.Close(); }));
                                }));
                            }
                            catch { }
                        }).Start();
                    }
                    else
                    {
                        if (to.CompareTo(from) < 0)
                        {
                            MessageBox.Show("Start date is greater than end date! please fix it.", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        frmWait waitDialog = new frmWait("Loading data from database!", "Please wait...");
                        waitDialog.Show();

                        new Thread(() =>
                        {
                            DataTable dt = DataAccess.GetWhatsappAdmitQueueList(from, to);
                            try
                            {
                                BeginInvoke(new MethodInvoker(delegate
                                {
                                    dgvMonitor.DataSource = dt;
                                    if (dgvMonitor.RowCount > 0)
                                        lblRowCount.Text = dgvMonitor.RowCount + " Items";
                                    else
                                        lblRowCount.Text = "";
                                    waitDialog.Invoke(new Action(() => { waitDialog.Close(); }));
                                }));
                            }
                            catch { }
                        }).Start();
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.UserType > 2) return;

            if (tabControl1.SelectedTab == tbDoctors)
            {
                if (dgvDoctors.SelectedRows.Count > 1 || dgvDoctors.SelectedRows.Count < 1)
                    return;

                using (frmDoctorInput editForm = new frmDoctorInput((DataTable)dgvDoctors.DataSource, dgvDoctors.SelectedRows[0].Index))
                {
                    editForm.ShowDialog();
                }
            }
            else if (tabControl1.SelectedTab == tbOrgans)
            {
                if (dgvOrgans.SelectedRows.Count > 1 || dgvOrgans.SelectedRows.Count < 1)
                    return;

                using (frmOrganInput editForm = new frmOrganInput((DataTable)dgvOrgans.DataSource, dgvOrgans.SelectedRows[0].Index))
                {
                    editForm.ShowDialog();
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(false);
        }

        private void dgvDoctors_DoubleClick(object sender, EventArgs e)
        {
            var p = dgvDoctors.PointToClient(MousePosition);
            var hti = dgvDoctors.HitTest(p.X, p.Y);
            if (hti.Type == DataGridViewHitTestType.ColumnHeader)
                return;

            editToolStripMenuItem_Click(sender, e);
        }

        private void dgvOrgans_DoubleClick(object sender, EventArgs e)
        {
            var p = dgvOrgans.PointToClient(MousePosition);
            var hti = dgvOrgans.HitTest(p.X, p.Y);
            if (hti.Type == DataGridViewHitTestType.ColumnHeader)
                return;

            editToolStripMenuItem_Click(sender, e);
        }

        private void dgvMonitor_DoubleClick(object sender, EventArgs e)
        {
            var p = dgvOrgans.PointToClient(MousePosition);
            var hti = dgvOrgans.HitTest(p.X, p.Y);
            if (hti.Type == DataGridViewHitTestType.ColumnHeader)
                return;

            if (dgvMonitor.SelectedRows.Count > 1 || dgvMonitor.SelectedRows.Count < 1 || !DataAccess.HasValue(dgvMonitor.SelectedRows[0].Cells["colPrkId"].Value))
                return;

            long id = (long)dgvMonitor.SelectedRows[0].Cells["colPrkId"].Value;
            long admitId = Convert.ToInt32(dgvMonitor.SelectedRows[0].Cells["colAdmitId"].Value);

            using (var frmMessageStatus = new frmMessageStatus(id, admitId))
                frmMessageStatus.ShowDialog();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData(true);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadData(true);
        }

        private void txtValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txtDate = (TextBox)sender;
            if (txtDate == null) return;
            e.Cancel = !PersianCalendarTools.Validate(txtDate.Text.Trim());
            if (e.Cancel)
            {
                txtDate.ForeColor = Color.Red;
                toolTip1.IsBalloon = true;
                toolTip1.Show("Please enter date in currect format (E.g. 1398/12/29)", this, txtDate.Left + txtDate.Width - 40, txtDate.Top, 4000);
            }
            else
            {
                txtDate.ForeColor = Color.Black;
                toolTip1.Hide(this);
                toolTip1.IsBalloon = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tbMonitor)
                loadData(true);
        }

        private void chkAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = ((CheckBox)sender).Checked;
        }

        private void forceSendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMonitor.SelectedRows.Count != 1)
            {
                MessageBox.Show("More than one row selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /*
            if (User.UserType > 2)
            {
                MessageBox.Show("You are not permitted to use this option!", "Resend Message[s]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            */

            if (MessageBox.Show("Do you want to force send selected items?", "Force Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvMonitor.SelectedRows.Count; i++)
                {
                    WhatsappAdmitQueueItem wpReq = null;

                    if (!DataAccess.HasValue(dgvMonitor.SelectedRows[i].Cells["colAdmitId"].Value))
                        continue;
                    int admitId = (int)dgvMonitor.SelectedRows[i].Cells["colAdmitId"].Value;
                    DataTable dt = DataAccess.GetWhatsappAdmitQueueItem(-1, admitId);
                    if (dt.Rows.Count > 0)
                        wpReq = new WhatsappAdmitQueueItem(dt.Rows[0]);
                    if (wpReq == null) continue;
                    WhatsappAPI.BaseUrl = _apiBaseUrl;
                    SendMessage.Send(wpReq, _organExceptions, _maxDebtAmount, _dontSendToPatients, _patientMessage, _debtorMessage, _organMessage, _doctorMessage);

                }
            }
        }

        private void resendMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMonitor.SelectedRows.Count < 1)
                return;

            /*
            if (User.UserType > 2)
            {
                MessageBox.Show("You are not permitted to use this option!", "Resend Message[s]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            */

            if (MessageBox.Show("Do you want to resend selected rows?", "Resend Message[s]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvMonitor.SelectedRows.Count; i++)
                {
                    if (!DataAccess.HasValue(dgvMonitor.SelectedRows[i].Cells["colPrkId"].Value)) continue;
                    long id = (long)dgvMonitor.SelectedRows[i].Cells["colPrkId"].Value;
                    DataAccess.DeleteAdmitQueueItem(id);
                }
                loadData(true);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDbConnectionSetting();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var sqlConnectionString = SecureText.Decrypt(Properties.Settings.Default.SqlServerConnectionString);
                if (!frmDbConnectionSetting.SqlConnectionCheck(sqlConnectionString))
                {
                    MessageBox.Show("Sql Server Connection Error!", "Connection String Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sql Server is Connected!", "Connection String", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void whatsappServiceSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSettings(_apiBaseUrl, _reloadInterval, _retryInterval, _maxAttempts, _debtorMessage, _organMessage, _doctorMessage, _patientMessage, _dontSendToPatients, _organExceptions, _maxDebtAmount);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _reloadInterval = frm.ReloadInterval;
                _retryInterval = frm.RetryInterval;
                _maxAttempts = frm.MaxAttempts;
                _debtorMessage = frm.DebtorMessage;
                _organMessage = frm.OrganMessage;
                _doctorMessage = frm.DoctorMessage;
                _patientMessage = frm.PatientMessage;
                _apiBaseUrl = frm.BaseUrl;
                _dontSendToPatients = frm.DontSendToPatients;
                _maxDebtAmount = frm.MaxDebtAmount;
                _organExceptions = frm.OrganExceptions;

                DataAccess.UpdateSetting("wpApiBaseUrl", frm.BaseUrl);
                DataAccess.UpdateSetting("wpReloadInterval", frm.ReloadInterval.ToString());
                DataAccess.UpdateSetting("wpRetryInterval", frm.RetryInterval.ToString());
                DataAccess.UpdateSetting("wpMaxAttempts", frm.MaxAttempts.ToString());
                DataAccess.UpdateSetting("wpDebtorMessage", frm.DebtorMessage);
                DataAccess.UpdateSetting("wpOrganMessage", frm.OrganMessage);
                DataAccess.UpdateSetting("wpDoctorMessage", frm.DoctorMessage);
                DataAccess.UpdateSetting("wpPatientGreetingMessage", frm.PatientMessage);
                DataAccess.UpdateSetting("wpDontSentToPatientsByDefault", frm.DontSendToPatients.ToString());
                DataAccess.UpdateSetting("wpMaxDebtAmount", frm.MaxDebtAmount.ToString());
                DataAccess.UpdateSetting("wpOrganExceptions", frm.OrganExceptions);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmInput(_lastFindKey);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _lastFindKey = frm.Key;
                if (tabControl1.SelectedTab == tbDoctors)
                    lookFor(frm.Key, dgvDoctors, 0);
                else if (tabControl1.SelectedTab == tbOrgans)
                    lookFor(frm.Key, dgvOrgans, 0);
                else if (tabControl1.SelectedTab == tbMonitor)
                    lookFor(frm.Key, dgvMonitor, 0);
            }
        }

        private void lookFor(string key, DataGridView dgv, int startIndex)
        {
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("No rows exist!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter somthing to find!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startIndex > 0) startIndex++;

            bool found = false;
            for (int i = startIndex; i < dgv.RowCount; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var value = cell.Value.ToString();
                    if (value.ToLower().Contains(key.ToLower()))
                    {
                        foreach (DataGridViewRow item in dgv.SelectedRows)
                            item.Selected = false;
                        row.Selected = true;
                        dgv.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        return;
                    }
                }
            }

            if (!found)
                MessageBox.Show("Nothing found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_lastFindKey))
                return;

            if (tabControl1.SelectedTab == tbDoctors)
                lookFor(_lastFindKey, dgvDoctors, dgvDoctors.SelectedRows[0].Index);
            else if (tabControl1.SelectedTab == tbOrgans)
                lookFor(_lastFindKey, dgvOrgans, dgvOrgans.SelectedRows[0].Index);
            else if (tabControl1.SelectedTab == tbMonitor)
                lookFor(_lastFindKey, dgvMonitor, dgvMonitor.SelectedRows[0].Index);
        }
    }
}
