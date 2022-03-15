namespace ParstebWhatsapp
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsappServiceSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDoctors = new System.Windows.Forms.TabPage();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSendToPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSendToDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOrgans = new System.Windows.Forms.TabPage();
            this.dgvOrgans = new System.Windows.Forms.DataGridView();
            this.colOrgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgCredited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgSendToPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgSendToAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgPhone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMonitor = new System.Windows.Forms.TabPage();
            this.chkAutoRefresh = new System.Windows.Forms.CheckBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonitor = new System.Windows.Forms.DataGridView();
            this.colPrkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRamainedFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resendMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.forceSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAdmitId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tbOrgans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgans)).BeginInit();
            this.tbMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.toolStripMenuItem3,
            this.connectionSettingsToolStripMenuItem,
            this.whatsappServiceSettingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.findNextToolStripMenuItem.Text = "Find N&ext";
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.connectionSettingsToolStripMenuItem.Text = "Con&nection Settings";
            this.connectionSettingsToolStripMenuItem.Click += new System.EventHandler(this.connectionSettingsToolStripMenuItem_Click);
            // 
            // whatsappServiceSettingsToolStripMenuItem
            // 
            this.whatsappServiceSettingsToolStripMenuItem.Name = "whatsappServiceSettingsToolStripMenuItem";
            this.whatsappServiceSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.whatsappServiceSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.whatsappServiceSettingsToolStripMenuItem.Text = "Se&ttings";
            this.whatsappServiceSettingsToolStripMenuItem.Click += new System.EventHandler(this.whatsappServiceSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbDoctors);
            this.tabControl1.Controls.Add(this.tbOrgans);
            this.tabControl1.Controls.Add(this.tbMonitor);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 562);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tbDoctors
            // 
            this.tbDoctors.Controls.Add(this.dgvDoctors);
            this.tbDoctors.Location = new System.Drawing.Point(4, 25);
            this.tbDoctors.Name = "tbDoctors";
            this.tbDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tbDoctors.Size = new System.Drawing.Size(979, 533);
            this.tbDoctors.TabIndex = 0;
            this.tbDoctors.Text = "Doctors";
            this.tbDoctors.UseVisualStyleBackColor = true;
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colLastName,
            this.colSpecialization,
            this.colMedId,
            this.colCredited,
            this.colSendToPatient,
            this.colSendToDoctor,
            this.colPhoneNumber1,
            this.colPhoneNumber2});
            this.dgvDoctors.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctors.Location = new System.Drawing.Point(3, 3);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvDoctors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.ShowCellErrors = false;
            this.dgvDoctors.ShowEditingIcon = false;
            this.dgvDoctors.ShowRowErrors = false;
            this.dgvDoctors.Size = new System.Drawing.Size(973, 527);
            this.dgvDoctors.TabIndex = 5;
            this.dgvDoctors.DoubleClick += new System.EventHandler(this.dgvDoctors_DoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Int_AutoID";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 60;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Str_DoctorFName";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 110;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "Str_DoctorLName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 120;
            // 
            // colSpecialization
            // 
            this.colSpecialization.DataPropertyName = "str_Specialization";
            this.colSpecialization.HeaderText = "Specialization";
            this.colSpecialization.Name = "colSpecialization";
            this.colSpecialization.ReadOnly = true;
            this.colSpecialization.Width = 160;
            // 
            // colMedId
            // 
            this.colMedId.DataPropertyName = "PRK_Doctors";
            this.colMedId.HeaderText = "Medical Id";
            this.colMedId.Name = "colMedId";
            this.colMedId.ReadOnly = true;
            this.colMedId.Width = 80;
            // 
            // colCredited
            // 
            this.colCredited.DataPropertyName = "credited";
            this.colCredited.HeaderText = "Credited";
            this.colCredited.Name = "colCredited";
            this.colCredited.ReadOnly = true;
            // 
            // colSendToPatient
            // 
            this.colSendToPatient.DataPropertyName = "sendToPatient";
            this.colSendToPatient.HeaderText = "Send To Patient";
            this.colSendToPatient.Name = "colSendToPatient";
            this.colSendToPatient.ReadOnly = true;
            // 
            // colSendToDoctor
            // 
            this.colSendToDoctor.DataPropertyName = "sendToDoctor";
            this.colSendToDoctor.HeaderText = "Send To Doctor";
            this.colSendToDoctor.Name = "colSendToDoctor";
            this.colSendToDoctor.ReadOnly = true;
            // 
            // colPhoneNumber1
            // 
            this.colPhoneNumber1.DataPropertyName = "phoneNumber1";
            this.colPhoneNumber1.HeaderText = "First Phone#";
            this.colPhoneNumber1.Name = "colPhoneNumber1";
            this.colPhoneNumber1.ReadOnly = true;
            this.colPhoneNumber1.Width = 110;
            // 
            // colPhoneNumber2
            // 
            this.colPhoneNumber2.DataPropertyName = "phoneNumber2";
            this.colPhoneNumber2.HeaderText = "Second Phone#";
            this.colPhoneNumber2.Name = "colPhoneNumber2";
            this.colPhoneNumber2.ReadOnly = true;
            this.colPhoneNumber2.Width = 110;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 54);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "E&dit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tbOrgans
            // 
            this.tbOrgans.Controls.Add(this.dgvOrgans);
            this.tbOrgans.Location = new System.Drawing.Point(4, 25);
            this.tbOrgans.Name = "tbOrgans";
            this.tbOrgans.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrgans.Size = new System.Drawing.Size(979, 533);
            this.tbOrgans.TabIndex = 1;
            this.tbOrgans.Text = "Organs";
            this.tbOrgans.UseVisualStyleBackColor = true;
            // 
            // dgvOrgans
            // 
            this.dgvOrgans.AllowUserToAddRows = false;
            this.dgvOrgans.AllowUserToDeleteRows = false;
            this.dgvOrgans.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrgans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrgans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrgans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrgId,
            this.colOrgName,
            this.colInCharge,
            this.colCode,
            this.colOrgCredited,
            this.colOrgSendToPatient,
            this.colOrgSendToAdmin,
            this.colOrgPhone1,
            this.colOrgPhone2});
            this.dgvOrgans.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOrgans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrgans.Location = new System.Drawing.Point(3, 3);
            this.dgvOrgans.Name = "dgvOrgans";
            this.dgvOrgans.ReadOnly = true;
            this.dgvOrgans.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvOrgans.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrgans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrgans.ShowCellErrors = false;
            this.dgvOrgans.ShowEditingIcon = false;
            this.dgvOrgans.ShowRowErrors = false;
            this.dgvOrgans.Size = new System.Drawing.Size(973, 527);
            this.dgvOrgans.TabIndex = 6;
            this.dgvOrgans.DoubleClick += new System.EventHandler(this.dgvOrgans_DoubleClick);
            // 
            // colOrgId
            // 
            this.colOrgId.DataPropertyName = "Prk_Contractors";
            this.colOrgId.HeaderText = "ID";
            this.colOrgId.Name = "colOrgId";
            this.colOrgId.ReadOnly = true;
            this.colOrgId.Width = 60;
            // 
            // colOrgName
            // 
            this.colOrgName.DataPropertyName = "Str_ContractorName";
            this.colOrgName.HeaderText = "Org Name";
            this.colOrgName.Name = "colOrgName";
            this.colOrgName.ReadOnly = true;
            this.colOrgName.Width = 110;
            // 
            // colInCharge
            // 
            this.colInCharge.DataPropertyName = "Str_AdministratorName";
            this.colInCharge.HeaderText = "In Charge";
            this.colInCharge.Name = "colInCharge";
            this.colInCharge.ReadOnly = true;
            this.colInCharge.Width = 120;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Str_InternalNumber";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 80;
            // 
            // colOrgCredited
            // 
            this.colOrgCredited.DataPropertyName = "credited";
            this.colOrgCredited.HeaderText = "Credited";
            this.colOrgCredited.Name = "colOrgCredited";
            this.colOrgCredited.ReadOnly = true;
            // 
            // colOrgSendToPatient
            // 
            this.colOrgSendToPatient.DataPropertyName = "sendToPatient";
            this.colOrgSendToPatient.HeaderText = "Send To Patient";
            this.colOrgSendToPatient.Name = "colOrgSendToPatient";
            this.colOrgSendToPatient.ReadOnly = true;
            // 
            // colOrgSendToAdmin
            // 
            this.colOrgSendToAdmin.DataPropertyName = "sendToOrganInCharge";
            this.colOrgSendToAdmin.HeaderText = "Send To Organ In Charge";
            this.colOrgSendToAdmin.Name = "colOrgSendToAdmin";
            this.colOrgSendToAdmin.ReadOnly = true;
            this.colOrgSendToAdmin.Width = 120;
            // 
            // colOrgPhone1
            // 
            this.colOrgPhone1.DataPropertyName = "phoneNumber1";
            this.colOrgPhone1.HeaderText = "First Phone#";
            this.colOrgPhone1.Name = "colOrgPhone1";
            this.colOrgPhone1.ReadOnly = true;
            this.colOrgPhone1.Width = 110;
            // 
            // colOrgPhone2
            // 
            this.colOrgPhone2.DataPropertyName = "phoneNumber2";
            this.colOrgPhone2.HeaderText = "Second Phone#";
            this.colOrgPhone2.Name = "colOrgPhone2";
            this.colOrgPhone2.ReadOnly = true;
            this.colOrgPhone2.Width = 110;
            // 
            // tbMonitor
            // 
            this.tbMonitor.Controls.Add(this.label4);
            this.tbMonitor.Controls.Add(this.groupBox2);
            this.tbMonitor.Controls.Add(this.groupBox1);
            this.tbMonitor.Controls.Add(this.chkAutoRefresh);
            this.tbMonitor.Controls.Add(this.lblRowCount);
            this.tbMonitor.Controls.Add(this.btnLoadData);
            this.tbMonitor.Controls.Add(this.dgvMonitor);
            this.tbMonitor.Location = new System.Drawing.Point(4, 25);
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tbMonitor.Size = new System.Drawing.Size(979, 533);
            this.tbMonitor.TabIndex = 2;
            this.tbMonitor.Text = "Monitor";
            this.tbMonitor.UseVisualStyleBackColor = true;
            // 
            // chkAutoRefresh
            // 
            this.chkAutoRefresh.AutoSize = true;
            this.chkAutoRefresh.Location = new System.Drawing.Point(772, 14);
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.Size = new System.Drawing.Size(88, 17);
            this.chkAutoRefresh.TabIndex = 17;
            this.chkAutoRefresh.Text = "Auto Refresh";
            this.chkAutoRefresh.UseVisualStyleBackColor = true;
            this.chkAutoRefresh.CheckedChanged += new System.EventHandler(this.chkAutoRefresh_CheckedChanged);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRowCount.Location = new System.Drawing.Point(849, 12);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(127, 23);
            this.lblRowCount.TabIndex = 16;
            this.lblRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(701, 9);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(65, 30);
            this.btnLoadData.TabIndex = 15;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(337, 11);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(117, 20);
            this.txtToDate.TabIndex = 14;
            this.txtToDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtValidating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Confirm Date To :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(106, 11);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(117, 20);
            this.txtFromDate.TabIndex = 12;
            this.txtFromDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Confirm Date From :";
            // 
            // dgvMonitor
            // 
            this.dgvMonitor.AllowUserToAddRows = false;
            this.dgvMonitor.AllowUserToDeleteRows = false;
            this.dgvMonitor.AllowUserToResizeRows = false;
            this.dgvMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrkId,
            this.colStatus,
            this.colAdmitId,
            this.colPatientName,
            this.colGender,
            this.colPatientPhoneNumber,
            this.colConfirmDate,
            this.colConfirmTime,
            this.colDoctor,
            this.colOrgan,
            this.colAdmitDate,
            this.colAdmitTime,
            this.colRamainedFee,
            this.colStartTime});
            this.dgvMonitor.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvMonitor.Location = new System.Drawing.Point(3, 45);
            this.dgvMonitor.Name = "dgvMonitor";
            this.dgvMonitor.ReadOnly = true;
            this.dgvMonitor.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvMonitor.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMonitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitor.ShowCellErrors = false;
            this.dgvMonitor.ShowEditingIcon = false;
            this.dgvMonitor.ShowRowErrors = false;
            this.dgvMonitor.Size = new System.Drawing.Size(973, 485);
            this.dgvMonitor.TabIndex = 7;
            this.dgvMonitor.DoubleClick += new System.EventHandler(this.dgvMonitor_DoubleClick);
            // 
            // colPrkId
            // 
            this.colPrkId.DataPropertyName = "Prk_Id";
            this.colPrkId.HeaderText = "ID";
            this.colPrkId.Name = "colPrkId";
            this.colPrkId.ReadOnly = true;
            this.colPrkId.Width = 60;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Title";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 110;
            // 
            // colAdmitId
            // 
            this.colAdmitId.DataPropertyName = "Frk_AdmitID";
            this.colAdmitId.HeaderText = "Admit Id";
            this.colAdmitId.Name = "colAdmitId";
            this.colAdmitId.ReadOnly = true;
            this.colAdmitId.Width = 80;
            // 
            // colPatientName
            // 
            this.colPatientName.DataPropertyName = "Str_PatientName";
            this.colPatientName.HeaderText = "Patient Name";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colPatientName.Width = 120;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Int_Sex";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 80;
            // 
            // colPatientPhoneNumber
            // 
            this.colPatientPhoneNumber.DataPropertyName = "Str_MobileNumber";
            this.colPatientPhoneNumber.HeaderText = "Patient Phone#";
            this.colPatientPhoneNumber.Name = "colPatientPhoneNumber";
            this.colPatientPhoneNumber.ReadOnly = true;
            this.colPatientPhoneNumber.Width = 110;
            // 
            // colConfirmDate
            // 
            this.colConfirmDate.DataPropertyName = "Str_Logged_Date";
            this.colConfirmDate.HeaderText = "Confirm Date";
            this.colConfirmDate.Name = "colConfirmDate";
            this.colConfirmDate.ReadOnly = true;
            this.colConfirmDate.Width = 110;
            // 
            // colConfirmTime
            // 
            this.colConfirmTime.DataPropertyName = "Str_Logged_Time";
            this.colConfirmTime.HeaderText = "Confirm Time";
            this.colConfirmTime.Name = "colConfirmTime";
            this.colConfirmTime.ReadOnly = true;
            // 
            // colDoctor
            // 
            this.colDoctor.DataPropertyName = "Str_Doctor";
            this.colDoctor.HeaderText = "Doctor";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            // 
            // colOrgan
            // 
            this.colOrgan.DataPropertyName = "Str_OrgName";
            this.colOrgan.HeaderText = "Organ";
            this.colOrgan.Name = "colOrgan";
            this.colOrgan.ReadOnly = true;
            // 
            // colAdmitDate
            // 
            this.colAdmitDate.DataPropertyName = "Str_AdmitDate";
            this.colAdmitDate.HeaderText = "Admit Date";
            this.colAdmitDate.Name = "colAdmitDate";
            this.colAdmitDate.ReadOnly = true;
            // 
            // colAdmitTime
            // 
            this.colAdmitTime.DataPropertyName = "Str_AdmitTime";
            this.colAdmitTime.HeaderText = "Admit Time";
            this.colAdmitTime.Name = "colAdmitTime";
            this.colAdmitTime.ReadOnly = true;
            this.colAdmitTime.Width = 120;
            // 
            // colRamainedFee
            // 
            this.colRamainedFee.DataPropertyName = "Int_Baghimande";
            this.colRamainedFee.HeaderText = "Remained Fee";
            this.colRamainedFee.Name = "colRamainedFee";
            this.colRamainedFee.ReadOnly = true;
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "AddedTime";
            this.colStartTime.HeaderText = "Start Sending Time";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resendMessagesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.forceSendToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(216, 76);
            // 
            // resendMessagesToolStripMenuItem
            // 
            this.resendMessagesToolStripMenuItem.Name = "resendMessagesToolStripMenuItem";
            this.resendMessagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resendMessagesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.resendMessagesToolStripMenuItem.Text = "Resend Message[s]";
            this.resendMessagesToolStripMenuItem.Click += new System.EventHandler(this.resendMessagesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(212, 6);
            // 
            // forceSendToolStripMenuItem
            // 
            this.forceSendToolStripMenuItem.Name = "forceSendToolStripMenuItem";
            this.forceSendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.forceSendToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.forceSendToolStripMenuItem.Text = "Force Send";
            this.forceSendToolStripMenuItem.Click += new System.EventHandler(this.forceSendToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAdmitId
            // 
            this.txtAdmitId.Location = new System.Drawing.Point(65, 12);
            this.txtAdmitId.Name = "txtAdmitId";
            this.txtAdmitId.Size = new System.Drawing.Size(117, 20);
            this.txtAdmitId.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Admit Id :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 36);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdmitId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(501, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 36);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Or";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parsteb Whatsapp Service";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tbOrgans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgans)).EndInit();
            this.tbMonitor.ResumeLayout(false);
            this.tbMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsappServiceSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDoctors;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.TabPage tbOrgans;
        private System.Windows.Forms.DataGridView dgvOrgans;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgCredited;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgSendToPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgSendToAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgPhone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredited;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSendToPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSendToDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.TabPage tbMonitor;
        private System.Windows.Forms.DataGridView dgvMonitor;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRamainedFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAutoRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem resendMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem forceSendToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdmitId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

