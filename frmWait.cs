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
    public partial class frmWait : Form
    {
        public frmWait(string title, string message)
        {
            InitializeComponent();
            lblHeader.Text = title;
            lblMessage.Text = message;
        }

        private void frmWait_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1 != null)
                pictureBox1.Dispose();
        }
    }
}
