using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmInput : Form
    {
        private string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public frmInput(string key)
        {
            InitializeComponent();
            _key = key;
            txtKey.Text = key;
            txtKey.Focus();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            _key = txtKey.Text;
            DialogResult = DialogResult.OK;
        }

        private void frmInput_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    btnOk_Click(btnOk, new System.EventArgs());
                    break;
            }
        }

        private void frmInput_Shown(object sender, System.EventArgs e)
        {
            txtKey.Focus();
        }
    }
}
