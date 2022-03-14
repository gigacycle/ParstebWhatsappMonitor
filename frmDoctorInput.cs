using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmDoctorInput : Form
    {
        bool _formEdited = false;
        DataRowView _dr = null;

        public frmDoctorInput(DataTable dt, int rowIndex)
        {
            InitializeComponent();
            bnDoctorsList.BindingSource = new BindingSource();
            bnDoctorsList.BindingSource.DataSource = dt;
            bnDoctorsList.BindingSource.Position = rowIndex;
            bnDoctorsList.BindingSource.PositionChanged += BindingSource_PositionChanged;
            reloadFormData();
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (_formEdited) saveCurrentForm();
            reloadFormData();
        }

        private void reloadFormData()
        {
            if (bnDoctorsList.BindingSource == null) return;

            _dr = (DataRowView)bnDoctorsList.BindingSource.Current;

            if (_dr == null) return;

            lblId.Text = _dr["Int_AutoId"].ToString();
            lblName.Text = _dr["Str_DoctorFName"].ToString() + " " + _dr["Str_DoctorLName"].ToString();
            lblSpec.Text = _dr["str_Specialization"].ToString();
            lblMedId.Text = _dr["PRK_Doctors"].ToString();

            chkCredited.Checked = _dr["credited"] == DBNull.Value ? false : (bool)_dr["credited"];
            chkSendToPatient.Checked = _dr["sendToPatient"] == DBNull.Value ? false : (bool)_dr["sendToPatient"];
            chkSendToDoctor.Checked = _dr["sendToDoctor"] == DBNull.Value ? false : (bool)_dr["sendToDoctor"];
            txtPhone1.Text = _dr["phoneNumber1"] == DBNull.Value ? "" : _dr["phoneNumber1"].ToString();
            txtPhone2.Text = _dr["phoneNumber2"] == DBNull.Value ? "" : _dr["phoneNumber2"].ToString();

            _formEdited = false;
        }

        private bool saveCurrentForm()
        {
            long id = _dr["PRK_Id"] == DBNull.Value ? -1 : (long)_dr["PRK_Id"];
            int doctorId = (int)_dr["Int_AutoID"];
            bool credited = chkCredited.Checked;
            bool sendToPatient = chkSendToPatient.Checked;
            bool sendToDoctor = chkSendToDoctor.Checked;
            string phone1 = txtPhone1.Text;
            string phone2 = txtPhone2.Text;

            long newId = DataAccess.InsertIntoDoctorCrmSettings(id, doctorId, credited, sendToPatient, sendToDoctor, phone1, phone2);

            if (newId > 0)
                id = newId;

            _dr.BeginEdit();
            _dr["PRK_Id"] = id;
            _dr["credited"] = credited;
            _dr["sendToPatient"] = sendToPatient;
            _dr["sendToDoctor"] = sendToDoctor;
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
                chkSendToDoctor.Focus();
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
                    if (bnDoctorsList.BindingSource != null)
                        bnDoctorsList.BindingSource.MoveNext();
                    break;
                case Keys.PageUp:
                    if (bnDoctorsList.BindingSource != null)
                        bnDoctorsList.BindingSource.MovePrevious();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            using (frmMoreNumbers moreNumberForm = new frmMoreNumbers(false, lblName.Text, id))
                moreNumberForm.ShowDialog();

        }
    }
}
