using System.Linq;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmSettings : Form
    {
        private int _reloadInterval, _retryInterval, _maxAttempts, _daysBeforeToday;
        private string _baseUrl, _debtorMessage, _organMessage, _doctorMessage, _patientMessage, _organExceptions;
        private bool _dontSendToPatients;
        private long _maxDebtAmount;

        public bool DontSendToPatients
        {
            get { return _dontSendToPatients; }
            set { _dontSendToPatients = value; }
        }

        public int ReloadInterval
        {
            get { return _reloadInterval; }
            set { _reloadInterval = value; }
        }

        public int RetryInterval
        {
            get { return _retryInterval; }
            set { _retryInterval = value; }
        }

        public int MaxAttempts
        {
            get { return _maxAttempts; }
            set { _maxAttempts = value; }
        }

        public long MaxDebtAmount
        {
            get { return _maxDebtAmount; }
            set { _maxDebtAmount = value; }
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        public string DebtorMessage
        {
            get { return _debtorMessage; }
            set { _debtorMessage = value; }
        }

        public string OrganMessage
        {
            get { return _organMessage; }
            set { _organMessage = value; }
        }

        public string DoctorMessage
        {
            get { return _doctorMessage; }
            set { _doctorMessage = value; }
        }

        public string OrganExceptions
        {
            get { return _organExceptions; }
            set { _organExceptions = value; }
        }

        public int DaysBeforeToday
        {
            get { return _daysBeforeToday; }
            set { _daysBeforeToday = value; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textLimitation(sender, e);
        }

        private void textLimitation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') == 0))
            {
                e.Handled = true;
            }
        }

        public string PatientMessage
        {
            get { return _patientMessage; }
            set { _patientMessage = value; }
        }

        public frmSettings(string baseUrl, int reloadInterval, int retryInterval, int maxAttempts, int daysBeforeToday, string debtorMessage, string organMessage, string doctorMessage, string patientMessage, bool dontSendToPatients, string organExceptions, long maxDebtAmount)
        {
            InitializeComponent();
            _reloadInterval = reloadInterval;
            _retryInterval = retryInterval;
            _maxAttempts = maxAttempts;
            _baseUrl = baseUrl;
            _debtorMessage = debtorMessage;
            _organMessage = organMessage;
            _doctorMessage = doctorMessage;
            _patientMessage = patientMessage;
            _dontSendToPatients = dontSendToPatients;
            _maxDebtAmount = maxDebtAmount;
            _organExceptions = organExceptions;
            _daysBeforeToday = daysBeforeToday;

            checkBox1.Checked = _dontSendToPatients;
            txtBaseUrl.Text = baseUrl;
            txtDebtorMessage.Text = debtorMessage;
            txtOrganMessage.Text = organMessage;
            txtDoctorMessage.Text = doctorMessage;
            txtPatientMessage.Text = patientMessage;
            txtOrganExceptions.Text = organExceptions;

            txtMaxDebtAmount.Text = maxDebtAmount.ToString();
            txtReloadInterval.Text = reloadInterval.ToString();
            txtRetryInterval.Text = retryInterval.ToString();
            txtMaxAttempts.Text = maxAttempts.ToString();
            txtDaysBeforeToday.Text = daysBeforeToday.ToString();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            int.TryParse(txtReloadInterval.Text, out _reloadInterval);
            int.TryParse(txtRetryInterval.Text, out _retryInterval);
            int.TryParse(txtMaxAttempts.Text, out _maxAttempts);
            int.TryParse(txtDaysBeforeToday.Text, out _daysBeforeToday);
            long.TryParse(txtMaxDebtAmount.Text, out _maxDebtAmount);
            _baseUrl = txtBaseUrl.Text;
            _debtorMessage = txtDebtorMessage.Text;
            _organMessage = txtOrganMessage.Text;
            _doctorMessage = txtDoctorMessage.Text;
            _patientMessage = txtPatientMessage.Text;
            _dontSendToPatients = checkBox1.Checked;
            _organExceptions = txtOrganExceptions.Text;
            DialogResult = DialogResult.OK;
        }

        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            bool isUnicode = ContainsUnicodeCharacter(tb.Text);

            if (isUnicode)
                tb.RightToLeft = RightToLeft.Yes;
            else
                tb.RightToLeft = RightToLeft.No;
        }

        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.Any(c => c > MaxAnsiCode);
        }
    }
}
