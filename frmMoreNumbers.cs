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
    public partial class frmMoreNumbers : Form
    {
        long _crmSettingId;
        bool _isOrgan;
        bool _editmode = false;
        string _name;
        Contact _selectedContact = null;

        public frmMoreNumbers(bool isOrgan, string name, long crmSettingId)
        {
            InitializeComponent();
            _isOrgan = isOrgan;
            _crmSettingId = crmSettingId;
            _name = name;
            lblName.Text = name;
            refereshList();
        }

        private void refereshList()
        {
            listBox1.Items.Clear();
            DataTable dt = null;
            if (_isOrgan)
                dt = DataAccess.GetOrganExtraPhoneNumbers(_crmSettingId);
            else
                dt = DataAccess.GetDoctorExtraPhoneNumbers(_crmSettingId);

            if (dt == null)
                return;

            foreach (DataRow row in dt.Rows)
            {
                var contact = new Contact(row, _isOrgan);
                listBox1.Items.Add(contact);
            }
            textBox1.Focus();
        }

        class Contact
        {
            public long Id;
            public long CrmSettingId;
            public string Name;
            public string PhoneNumber;
            public Contact()
            {

            }

            public Contact(DataRow row, bool isOrgan)
            {
                string crmIdColName = isOrgan ? "Frk_organCrmSettingId" : "Frk_doctorCrmSettingId";
                Id = DataAccess.HasValue(row["id"]) ? (long)row["id"] : -1;
                CrmSettingId = DataAccess.HasValue(row[crmIdColName]) ? (long)row[crmIdColName] : -1;
                Name = DataAccess.HasValue(row["Name"]) ? (string)row["Name"] : "";
                PhoneNumber = DataAccess.HasValue(row["PhoneNumber"]) ? (string)row["PhoneNumber"] : "";
            }
            public override string ToString()
            {
                return PhoneNumber + " (" + Name + ")";
            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            if (!_editmode) //Add
            {
                var contact = new Contact();
                contact.CrmSettingId = _crmSettingId;
                contact.Name = textBox1.Text;
                contact.PhoneNumber = textBox2.Text;
                if (_isOrgan)
                    contact.Id = DataAccess.InsertUpdateOrganExtraPhoneNumber(-1, contact.CrmSettingId, contact.Name, contact.PhoneNumber);
                else
                    contact.Id = DataAccess.InsertUpdateDoctorExtraPhoneNumber(-1, contact.CrmSettingId, contact.Name, contact.PhoneNumber);
                textBox1.Text = "";
                textBox2.Text = "";
                refereshList();
            }
            else //Edit
            {
                _selectedContact.Name = textBox1.Text;
                _selectedContact.PhoneNumber = textBox2.Text;
                if (_isOrgan)
                    DataAccess.InsertUpdateOrganExtraPhoneNumber(_selectedContact.Id, _selectedContact.CrmSettingId, _selectedContact.Name, _selectedContact.PhoneNumber);
                else
                    DataAccess.InsertUpdateDoctorExtraPhoneNumber(_selectedContact.Id, _selectedContact.CrmSettingId, _selectedContact.Name, _selectedContact.PhoneNumber);
                textBox1.Text = "";
                textBox2.Text = "";
                btnAddSave.Text = "Add";
                btnCancelClose.Text = "Close";
                _editmode = false;
                refereshList();
            }
        }

        private bool Validate()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Phone Number is Empty!");
                return false;
            }
            return true;
        }

        private void frmMoreNumbers_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnCancelClose_Click(btnCancelClose, new EventArgs());
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                textBox2.Focus();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            if (_editmode)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                btnAddSave.Text = "Add";
                btnCancelClose.Text = "Close";
                _editmode = false;
                refereshList();
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAddSave.Focus();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex < 0)
                return;
            _selectedContact = (Contact)listBox1.Items[listBox1.SelectedIndex];
            _editmode = true;
            textBox1.Text = _selectedContact.Name;
            textBox2.Text = _selectedContact.PhoneNumber;
            btnAddSave.Text = "Save";
            btnCancelClose.Text = "Cancel";
            textBox1.Focus();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex < 0)
                return;
            _selectedContact = (Contact)listBox1.Items[listBox1.SelectedIndex];
            if (_isOrgan)
                DataAccess.DeleteOrganExtraNumber(_selectedContact.Id);
            else
                DataAccess.DeleteDoctorExtraNumber(_selectedContact.Id);
            refereshList();
        }
    }
}
