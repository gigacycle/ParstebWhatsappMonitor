using System.Data;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public partial class frmMessageStatus : Form
    {
        long _admitQueueId = 0;
        long _admitId = 0;
        public frmMessageStatus(long admitQueueId, long admitId)
        {
            InitializeComponent();
            _admitQueueId = admitQueueId;
            _admitId = admitId;
            Text += " (Admit Id : " + _admitId + ")";
            loadList();
        }

        private void loadList()
        {
            if (_admitQueueId < 1)
                return;
            DataTable dt = DataAccess.GetWhatsappQueueListByAdmitQueueId(_admitQueueId);
            if (dt == null || dt.Rows.Count == 0)
                return;
            dgvWhatsappMessageQueue.DataSource = dt;
        }

        private void refreshListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            loadList();
        }
    }
}
