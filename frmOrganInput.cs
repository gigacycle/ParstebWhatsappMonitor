using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmOrganInput : Form
    {
        bool _formEdited = false;
        DataRowView _dr = null;

        public frmOrganInput(DataTable dt, int rowIndex)
        {
            InitializeComponent();
            bnOrgansList.BindingSource = new BindingSource();
            bnOrgansList.BindingSource.DataSource = dt;
            bnOrgansList.BindingSource.Position = rowIndex;
            bnOrgansList.BindingSource.PositionChanged += BindingSource_PositionChanged;
            reloadFormData();
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (_formEdited) saveCurrentForm();
            reloadFormData();
        }

        private void reloadFormData()
        {
            if (bnOrgansList.BindingSource == null) return;

            _dr = (DataRowView)bnOrgansList.BindingSource.Current;

            if (_dr == null) return;

            lblId.Text = _dr["Prk_Contractors"].ToString();
            lblCode.Text = _dr["Str_InternalNumber"].ToString();
            lblName.Text = _dr["Str_ContractorName"].ToString();
            lblInCharge.Text = _dr["Str_AdministratorName"].ToString();

            chkCredited.Checked = _dr["credited"] == DBNull.Value ? false : (bool)_dr["credited"];
            chkSendToPatient.Checked = _dr["sendToPatient"] == DBNull.Value ? false : (bool)_dr["sendToPatient"];
            chksendToOrganInCharge.Checked = _dr["sendToOrganInCharge"] == DBNull.Value ? false : (bool)_dr["sendToOrganInCharge"];
            txtPhone1.Text = _dr["phoneNumber1"] == DBNull.Value ? "" : _dr["phoneNumber1"].ToString();
            txtPhone2.Text = _dr["phoneNumber2"] == DBNull.Value ? "" : _dr["phoneNumber2"].ToString();

            _formEdited = false;
        }

        private bool saveCurrentForm()
        {
            long id = _dr["PRK_Id"] == DBNull.Value ? -1 : (long)_dr["PRK_Id"];
            int organId = (int)_dr["Prk_Contractors"];
            bool credited = chkCredited.Checked;
            bool sendToPatient = chkSendToPatient.Checked;
            bool sendToOrganInCharge = chksendToOrganInCharge.Checked;
            string phone1 = txtPhone1.Text;
            string phone2 = txtPhone2.Text;

            long newId = DataAccess.InsertIntoOrganCrmSettings(id, organId, credited, sendToPatient, sendToOrganInCharge, phone1, phone2);

            if (newId > 0)
                id = newId;

            _dr.BeginEdit();
            _dr["PRK_Id"] = id;
            _dr["credited"] = credited;
            _dr["sendToPatient"] = sendToPatient;
            _dr["sendToOrganInCharge"] = sendToOrganInCharge;
            _dr["phoneNumber1"] = phone1;
            _dr["phoneNumber2"] = phone2;
            _dr.EndEdit();

            return id < 0 ? false : true;  
        }

        private void chkCredited_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                chkSendToPatient.Focus();
        }

        private void chkSendToPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                chksendToOrganInCharge.Focus();
        }

        private void chkSendToDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPhone1.Focus();
        }

        private void txtPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPhone2.Focus();

            textLimitation(sender, e);
        }

        private void txtPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnOK.Focus();

            textLimitation(sender, e);
        }

        private void textLimitation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') == 0))
            {
                e.Handled = true;
            }
        }

        private void CheckBox_Enter(object sender, EventArgs e)
        {
            ((CheckBox)sender).ForeColor = Color.Blue;
        }

        private void CheckBox_Leave(object sender, EventArgs e)
        {
            ((CheckBox)sender).ForeColor = Color.Black;
        }

        private void frmDoctorInput_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnCancel_Click(btnCancel, new EventArgs());
                    break;
                case Keys.PageDown:
                    if (bnOrgansList.BindingSource != null)
                        bnOrgansList.BindingSource.MoveNext();
                    break;
                case Keys.PageUp:
                    if (bnOrgansList.BindingSource != null)
                        bnOrgansList.BindingSource.MovePrevious();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            saveCurrentForm();
            DialogResult = DialogResult.OK;
        }

        private void txtPhone1_Enter(object sender, EventArgs e)
        {
            lblPhone1.ForeColor = Color.Blue;
        }

        private void txtPhone1_Leave(object sender, EventArgs e)
        {
            lblPhone1.ForeColor = Color.Black;
        }

        private void txtPhone2_Enter(object sender, EventArgs e)
        {
            lblPhone2.ForeColor = Color.Blue;
        }

        private void txtPhone2_Leave(object sender, EventArgs e)
        {
            lblPhone2.ForeColor = Color.Black;
        }

        private void frmDoctorInput_Shown(object sender, EventArgs e)
        {
            chkCredited.Focus();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _formEdited = true;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            _formEdited = true;
        }

        private void btnMoreNumbers_Click(object sender, EventArgs e)
        {
            var id = _dr["PRK_Id"] == DBNull.Value ? -1 : (long)_dr["PRK_Id"];
            if (id < 1)
            {
                MessageBox.Show("Please save this setting before using this button!");
                return;
            }
            using (frmMoreNumbers moreNumberForm = new frmMoreNumbers(true, lblName.Text, id))
                moreNumberForm.ShowDialog();
        }
    }
}
