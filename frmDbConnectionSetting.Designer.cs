namespace ParstebWhatsapp
{
    partial class frmDbConnectionSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDbConnectionSetting));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.connectionInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSQLTest = new System.Windows.Forms.Button();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.txtDbUserName = new System.Windows.Forms.TextBox();
            this.txtDbServerAddress = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.SucceedMessage = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.FailedMessage = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.selectHostGroupBox = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbHosts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelServerSelection = new System.Windows.Forms.Button();
            this.btnSelectServer = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbDbCatalog = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectionInfoGroupBox.SuspendLayout();
            this.SucceedMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.FailedMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.selectHostGroupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(199, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 41);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "O&K";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(62, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 41);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // connectionInfoGroupBox
            // 
            this.connectionInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionInfoGroupBox.Controls.Add(this.btnBrowse);
            this.connectionInfoGroupBox.Controls.Add(this.btnSQLTest);
            this.connectionInfoGroupBox.Controls.Add(this.txtDbPassword);
            this.connectionInfoGroupBox.Controls.Add(this.txtDbUserName);
            this.connectionInfoGroupBox.Controls.Add(this.txtDbServerAddress);
            this.connectionInfoGroupBox.Controls.Add(this.label22);
            this.connectionInfoGroupBox.Controls.Add(this.label23);
            this.connectionInfoGroupBox.Controls.Add(this.label24);
            this.connectionInfoGroupBox.Controls.Add(this.SucceedMessage);
            this.connectionInfoGroupBox.Controls.Add(this.FailedMessage);
            this.connectionInfoGroupBox.ForeColor = System.Drawing.Color.Black;
            this.connectionInfoGroupBox.Location = new System.Drawing.Point(8, 63);
            this.connectionInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectionInfoGroupBox.Name = "connectionInfoGroupBox";
            this.connectionInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectionInfoGroupBox.Size = new System.Drawing.Size(342, 201);
            this.connectionInfoGroupBox.TabIndex = 23;
            this.connectionInfoGroupBox.TabStop = false;
            this.connectionInfoGroupBox.Text = "Connecting to server :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(289, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSQLTest
            // 
            this.btnSQLTest.ForeColor = System.Drawing.Color.Black;
            this.btnSQLTest.Location = new System.Drawing.Point(225, 153);
            this.btnSQLTest.Name = "btnSQLTest";
            this.btnSQLTest.Size = new System.Drawing.Size(96, 33);
            this.btnSQLTest.TabIndex = 3;
            this.btnSQLTest.Text = "Test Connection";
            this.btnSQLTest.UseVisualStyleBackColor = true;
            this.btnSQLTest.Click += new System.EventHandler(this.btnSQLTest_Click);
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDbPassword.Location = new System.Drawing.Point(99, 106);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.PasswordChar = '*';
            this.txtDbPassword.Size = new System.Drawing.Size(222, 20);
            this.txtDbPassword.TabIndex = 2;
            // 
            // txtDbUserName
            // 
            this.txtDbUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDbUserName.Location = new System.Drawing.Point(99, 75);
            this.txtDbUserName.Name = "txtDbUserName";
            this.txtDbUserName.Size = new System.Drawing.Size(222, 20);
            this.txtDbUserName.TabIndex = 1;
            // 
            // txtDbServerAddress
            // 
            this.txtDbServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDbServerAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDbServerAddress.Location = new System.Drawing.Point(102, 42);
            this.txtDbServerAddress.Name = "txtDbServerAddress";
            this.txtDbServerAddress.Size = new System.Drawing.Size(187, 20);
            this.txtDbServerAddress.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(40, 109);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Password :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Username :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Server Address :";
            // 
            // SucceedMessage
            // 
            this.SucceedMessage.Controls.Add(this.pictureBox2);
            this.SucceedMessage.Controls.Add(this.label21);
            this.SucceedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SucceedMessage.Location = new System.Drawing.Point(15, 135);
            this.SucceedMessage.Margin = new System.Windows.Forms.Padding(0);
            this.SucceedMessage.Name = "SucceedMessage";
            this.SucceedMessage.Size = new System.Drawing.Size(202, 62);
            this.SucceedMessage.TabIndex = 6;
            this.SucceedMessage.TabStop = false;
            this.SucceedMessage.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::ParstebWhatsapp.Properties.Resources.checked_shield_green;
            this.pictureBox2.Location = new System.Drawing.Point(148, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.ForeColor = System.Drawing.Color.Green;
            this.label21.Location = new System.Drawing.Point(38, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 49);
            this.label21.TabIndex = 5;
            this.label21.Text = "Connected Successfully";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FailedMessage
            // 
            this.FailedMessage.Controls.Add(this.pictureBox3);
            this.FailedMessage.Controls.Add(this.label25);
            this.FailedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FailedMessage.Location = new System.Drawing.Point(15, 135);
            this.FailedMessage.Margin = new System.Windows.Forms.Padding(0);
            this.FailedMessage.Name = "FailedMessage";
            this.FailedMessage.Size = new System.Drawing.Size(202, 62);
            this.FailedMessage.TabIndex = 7;
            this.FailedMessage.TabStop = false;
            this.FailedMessage.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::ParstebWhatsapp.Properties.Resources.shield_red;
            this.pictureBox3.Location = new System.Drawing.Point(148, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(38, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 49);
            this.label25.TabIndex = 5;
            this.label25.Text = "Connection Failed";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectHostGroupBox
            // 
            this.selectHostGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectHostGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.selectHostGroupBox.Controls.Add(this.btnReload);
            this.selectHostGroupBox.Controls.Add(this.cbHosts);
            this.selectHostGroupBox.Controls.Add(this.label1);
            this.selectHostGroupBox.Controls.Add(this.btnCancelServerSelection);
            this.selectHostGroupBox.Controls.Add(this.btnSelectServer);
            this.selectHostGroupBox.ForeColor = System.Drawing.Color.Black;
            this.selectHostGroupBox.Location = new System.Drawing.Point(8, 62);
            this.selectHostGroupBox.Name = "selectHostGroupBox";
            this.selectHostGroupBox.Size = new System.Drawing.Size(342, 141);
            this.selectHostGroupBox.TabIndex = 11;
            this.selectHostGroupBox.TabStop = false;
            this.selectHostGroupBox.Text = "Select Server";
            this.selectHostGroupBox.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(276, 39);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(58, 24);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbHosts
            // 
            this.cbHosts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHosts.FormattingEnabled = true;
            this.cbHosts.Location = new System.Drawing.Point(53, 40);
            this.cbHosts.Name = "cbHosts";
            this.cbHosts.Size = new System.Drawing.Size(219, 21);
            this.cbHosts.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server :";
            // 
            // btnCancelServerSelection
            // 
            this.btnCancelServerSelection.ForeColor = System.Drawing.Color.Black;
            this.btnCancelServerSelection.Location = new System.Drawing.Point(53, 93);
            this.btnCancelServerSelection.Name = "btnCancelServerSelection";
            this.btnCancelServerSelection.Size = new System.Drawing.Size(93, 33);
            this.btnCancelServerSelection.TabIndex = 8;
            this.btnCancelServerSelection.Text = "Cancel";
            this.btnCancelServerSelection.UseVisualStyleBackColor = true;
            this.btnCancelServerSelection.Click += new System.EventHandler(this.btnCancelServerSelection_Click);
            // 
            // btnSelectServer
            // 
            this.btnSelectServer.ForeColor = System.Drawing.Color.Black;
            this.btnSelectServer.Location = new System.Drawing.Point(190, 93);
            this.btnSelectServer.Name = "btnSelectServer";
            this.btnSelectServer.Size = new System.Drawing.Size(93, 33);
            this.btnSelectServer.TabIndex = 7;
            this.btnSelectServer.Text = "Select";
            this.btnSelectServer.UseVisualStyleBackColor = true;
            this.btnSelectServer.Click += new System.EventHandler(this.btnSelectServer_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.cbDbCatalog);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(8, 272);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(342, 103);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select Database :";
            // 
            // cbDbCatalog
            // 
            this.cbDbCatalog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbDbCatalog.FormattingEnabled = true;
            this.cbDbCatalog.Location = new System.Drawing.Point(86, 43);
            this.cbDbCatalog.Name = "cbDbCatalog";
            this.cbDbCatalog.Size = new System.Drawing.Size(222, 21);
            this.cbDbCatalog.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Database :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ParstebWhatsapp.Properties.Resources.sqlServer;
            this.pictureBox1.Location = new System.Drawing.Point(116, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmDbConnectionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.selectHostGroupBox);
            this.Controls.Add(this.connectionInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDbConnectionSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.connectionInfoGroupBox.ResumeLayout(false);
            this.connectionInfoGroupBox.PerformLayout();
            this.SucceedMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.FailedMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.selectHostGroupBox.ResumeLayout(false);
            this.selectHostGroupBox.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox connectionInfoGroupBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSQLTest;
        private System.Windows.Forms.GroupBox SucceedMessage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.TextBox txtDbUserName;
        private System.Windows.Forms.TextBox txtDbServerAddress;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox FailedMessage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox selectHostGroupBox;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbHosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelServerSelection;
        private System.Windows.Forms.Button btnSelectServer;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbDbCatalog;
        private System.Windows.Forms.Label label17;
    }
}