namespace ParstebWhatsapp
{
    partial class frmMessageStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWhatsappMessageQueue = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSendStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWhatsappNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveredTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChangingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmitQueueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhatsappMessageQueue)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWhatsappMessageQueue
            // 
            this.dgvWhatsappMessageQueue.AllowUserToAddRows = false;
            this.dgvWhatsappMessageQueue.AllowUserToDeleteRows = false;
            this.dgvWhatsappMessageQueue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWhatsappMessageQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWhatsappMessageQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWhatsappMessageQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colSendStatus,
            this.colAttempt,
            this.colMessageStatus,
            this.colMessage,
            this.colFileName,
            this.colWhatsappNumber,
            this.colSentTime,
            this.colDeliveredTime,
            this.colSeenTime,
            this.colCreateTime,
            this.colChangingTime,
            this.colAdmitQueueId});
            this.dgvWhatsappMessageQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWhatsappMessageQueue.Location = new System.Drawing.Point(0, 0);
            this.dgvWhatsappMessageQueue.Name = "dgvWhatsappMessageQueue";
            this.dgvWhatsappMessageQueue.ReadOnly = true;
            this.dgvWhatsappMessageQueue.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvWhatsappMessageQueue.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWhatsappMessageQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWhatsappMessageQueue.ShowCellErrors = false;
            this.dgvWhatsappMessageQueue.ShowEditingIcon = false;
            this.dgvWhatsappMessageQueue.ShowRowErrors = false;
            this.dgvWhatsappMessageQueue.Size = new System.Drawing.Size(800, 450);
            this.dgvWhatsappMessageQueue.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 26);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 60;
            // 
            // colSendStatus
            // 
            this.colSendStatus.DataPropertyName = "sendStatus";
            this.colSendStatus.HeaderText = "Send Status";
            this.colSendStatus.Name = "colSendStatus";
            this.colSendStatus.ReadOnly = true;
            this.colSendStatus.Width = 110;
            // 
            // colAttempt
            // 
            this.colAttempt.DataPropertyName = "attempt";
            this.colAttempt.HeaderText = "Attempt";
            this.colAttempt.Name = "colAttempt";
            this.colAttempt.ReadOnly = true;
            // 
            // colMessageStatus
            // 
            this.colMessageStatus.DataPropertyName = "status";
            this.colMessageStatus.HeaderText = "Message Status";
            this.colMessageStatus.Name = "colMessageStatus";
            this.colMessageStatus.ReadOnly = true;
            this.colMessageStatus.Width = 110;
            // 
            // colMessage
            // 
            this.colMessage.DataPropertyName = "message";
            this.colMessage.HeaderText = "Message Body";
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            this.colMessage.Width = 120;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "fileName";
            this.colFileName.HeaderText = "File Name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 80;
            // 
            // colWhatsappNumber
            // 
            this.colWhatsappNumber.DataPropertyName = "whatsappNumber";
            this.colWhatsappNumber.HeaderText = "WhatsApp Number";
            this.colWhatsappNumber.Name = "colWhatsappNumber";
            this.colWhatsappNumber.ReadOnly = true;
            // 
            // colSentTime
            // 
            this.colSentTime.DataPropertyName = "sent";
            this.colSentTime.HeaderText = "Sent Time";
            this.colSentTime.Name = "colSentTime";
            this.colSentTime.ReadOnly = true;
            this.colSentTime.Width = 110;
            // 
            // colDeliveredTime
            // 
            this.colDeliveredTime.DataPropertyName = "delivered";
            this.colDeliveredTime.HeaderText = "Delivered Time";
            this.colDeliveredTime.Name = "colDeliveredTime";
            this.colDeliveredTime.ReadOnly = true;
            // 
            // colSeenTime
            // 
            this.colSeenTime.DataPropertyName = "seen";
            this.colSeenTime.HeaderText = "Seen Time";
            this.colSeenTime.Name = "colSeenTime";
            this.colSeenTime.ReadOnly = true;
            // 
            // colCreateTime
            // 
            this.colCreateTime.DataPropertyName = "createTime";
            this.colCreateTime.HeaderText = "Creating Time";
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.ReadOnly = true;
            // 
            // colChangingTime
            // 
            this.colChangingTime.DataPropertyName = "modifiedTime";
            this.colChangingTime.HeaderText = "Changing Time";
            this.colChangingTime.Name = "colChangingTime";
            this.colChangingTime.ReadOnly = true;
            this.colChangingTime.Width = 120;
            // 
            // colAdmitQueueId
            // 
            this.colAdmitQueueId.DataPropertyName = "whatsAppAdmitQueueId";
            this.colAdmitQueueId.HeaderText = "Admit Queue Id";
            this.colAdmitQueueId.Name = "colAdmitQueueId";
            this.colAdmitQueueId.ReadOnly = true;
            // 
            // frmMessageStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvWhatsappMessageQueue);
            this.Name = "frmMessageStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WhatsApp Sending Message Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhatsappMessageQueue)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWhatsappMessageQueue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSendStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhatsappNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveredTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeenTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChangingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitQueueId;
    }
}