namespace ParstebWhatsapp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.loginInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FailedMessage = new System.Windows.Forms.GroupBox();
            this.lblRedMessage = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SucceedMessage = new System.Windows.Forms.GroupBox();
            this.lblGreenMessage = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.loginInfoGroupBox.SuspendLayout();
            this.FailedMessage.SuspendLayout();
            this.SucceedMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(16, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(204, 396);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 32);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // loginInfoGroupBox
            // 
            this.loginInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInfoGroupBox.Controls.Add(this.FailedMessage);
            this.loginInfoGroupBox.Controls.Add(this.txtPassword);
            this.loginInfoGroupBox.Controls.Add(this.txtUserName);
            this.loginInfoGroupBox.Controls.Add(this.label22);
            this.loginInfoGroupBox.Controls.Add(this.label23);
            this.loginInfoGroupBox.Controls.Add(this.SucceedMessage);
            this.loginInfoGroupBox.ForeColor = System.Drawing.Color.Black;
            this.loginInfoGroupBox.Location = new System.Drawing.Point(9, 154);
            this.loginInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginInfoGroupBox.Name = "loginInfoGroupBox";
            this.loginInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginInfoGroupBox.Size = new System.Drawing.Size(340, 228);
            this.loginInfoGroupBox.TabIndex = 22;
            this.loginInfoGroupBox.TabStop = false;
            this.loginInfoGroupBox.Text = "Connecting to server :";
            // 
            // FailedMessage
            // 
            this.FailedMessage.Controls.Add(this.lblRedMessage);
            this.FailedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FailedMessage.Location = new System.Drawing.Point(26, 146);
            this.FailedMessage.Margin = new System.Windows.Forms.Padding(0);
            this.FailedMessage.Name = "FailedMessage";
            this.FailedMessage.Size = new System.Drawing.Size(278, 62);
            this.FailedMessage.TabIndex = 7;
            this.FailedMessage.TabStop = false;
            this.FailedMessage.Visible = false;
            // 
            // lblRedMessage
            // 
            this.lblRedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRedMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRedMessage.Location = new System.Drawing.Point(6, 10);
            this.lblRedMessage.Name = "lblRedMessage";
            this.lblRedMessage.Size = new System.Drawing.Size(266, 49);
            this.lblRedMessage.TabIndex = 5;
            this.lblRedMessage.Text = "Connection Failed";
            this.lblRedMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.Location = new System.Drawing.Point(82, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserName.Location = new System.Drawing.Point(82, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Password :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Username :";
            // 
            // SucceedMessage
            // 
            this.SucceedMessage.Controls.Add(this.lblGreenMessage);
            this.SucceedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SucceedMessage.Location = new System.Drawing.Point(26, 146);
            this.SucceedMessage.Margin = new System.Windows.Forms.Padding(0);
            this.SucceedMessage.Name = "SucceedMessage";
            this.SucceedMessage.Size = new System.Drawing.Size(278, 62);
            this.SucceedMessage.TabIndex = 6;
            this.SucceedMessage.TabStop = false;
            this.SucceedMessage.Visible = false;
            // 
            // lblGreenMessage
            // 
            this.lblGreenMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreenMessage.ForeColor = System.Drawing.Color.Green;
            this.lblGreenMessage.Location = new System.Drawing.Point(6, 10);
            this.lblGreenMessage.Name = "lblGreenMessage";
            this.lblGreenMessage.Size = new System.Drawing.Size(266, 49);
            this.lblGreenMessage.TabIndex = 5;
            this.lblGreenMessage.Text = "Username is exist!";
            this.lblGreenMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbProfilePic.Image = global::ParstebWhatsapp.Properties.Resources.usr_login1;
            this.pbProfilePic.Location = new System.Drawing.Point(117, 12);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(124, 135);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePic.TabIndex = 25;
            this.pbProfilePic.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 438);
            this.Controls.Add(this.pbProfilePic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.loginInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginInfoGroupBox.ResumeLayout(false);
            this.loginInfoGroupBox.PerformLayout();
            this.FailedMessage.ResumeLayout(false);
            this.SucceedMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox loginInfoGroupBox;
        private System.Windows.Forms.GroupBox FailedMessage;
        private System.Windows.Forms.Label lblRedMessage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox SucceedMessage;
        private System.Windows.Forms.Label lblGreenMessage;
    }
}