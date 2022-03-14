namespace ParstebWhatsapp
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxAttempts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRetryInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReloadInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPatientMessage = new System.Windows.Forms.TextBox();
            this.txtDoctorMessage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrganMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDebtorMessage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaxDebtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOrganExceptions = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(381, 423);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 41);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "O&K";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(244, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 41);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtBaseUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(289, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Whatsapp Service Handler Server";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(9, 49);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBaseUrl.Size = new System.Drawing.Size(274, 20);
            this.txtBaseUrl.TabIndex = 1;
            this.txtBaseUrl.Text = "http:\\\\172.19.0.4\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "WhatsApp Api Base Url :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMaxAttempts);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtRetryInterval);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReloadInterval);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(289, 173);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 146);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "iterations";
            // 
            // txtMaxAttempts
            // 
            this.txtMaxAttempts.Location = new System.Drawing.Point(139, 143);
            this.txtMaxAttempts.Name = "txtMaxAttempts";
            this.txtMaxAttempts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaxAttempts.Size = new System.Drawing.Size(67, 20);
            this.txtMaxAttempts.TabIndex = 4;
            this.txtMaxAttempts.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(265, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Maximum number of sending failed messages attempts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 94);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "minutes";
            // 
            // txtRetryInterval
            // 
            this.txtRetryInterval.Location = new System.Drawing.Point(139, 91);
            this.txtRetryInterval.Name = "txtRetryInterval";
            this.txtRetryInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRetryInterval.Size = new System.Drawing.Size(67, 20);
            this.txtRetryInterval.TabIndex = 3;
            this.txtRetryInterval.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Retry failed messages every :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 45);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "minutes";
            // 
            // txtReloadInterval
            // 
            this.txtReloadInterval.Location = new System.Drawing.Point(139, 42);
            this.txtReloadInterval.Name = "txtReloadInterval";
            this.txtReloadInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReloadInterval.Size = new System.Drawing.Size(67, 20);
            this.txtReloadInterval.TabIndex = 2;
            this.txtReloadInterval.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check for new ready answers every :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtPatientMessage);
            this.groupBox2.Controls.Add(this.txtDoctorMessage);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOrganMessage);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDebtorMessage);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(307, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(404, 398);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Templates";
            // 
            // txtPatientMessage
            // 
            this.txtPatientMessage.Location = new System.Drawing.Point(9, 321);
            this.txtPatientMessage.Multiline = true;
            this.txtPatientMessage.Name = "txtPatientMessage";
            this.txtPatientMessage.Size = new System.Drawing.Size(389, 69);
            this.txtPatientMessage.TabIndex = 11;
            this.txtPatientMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // txtDoctorMessage
            // 
            this.txtDoctorMessage.Location = new System.Drawing.Point(9, 227);
            this.txtDoctorMessage.Multiline = true;
            this.txtDoctorMessage.Name = "txtDoctorMessage";
            this.txtDoctorMessage.Size = new System.Drawing.Size(389, 69);
            this.txtDoctorMessage.TabIndex = 10;
            this.txtDoctorMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 305);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(162, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "To normal patients (not debtors) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 211);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To doctors :";
            // 
            // txtOrganMessage
            // 
            this.txtOrganMessage.Location = new System.Drawing.Point(9, 135);
            this.txtOrganMessage.Multiline = true;
            this.txtOrganMessage.Name = "txtOrganMessage";
            this.txtOrganMessage.Size = new System.Drawing.Size(389, 69);
            this.txtOrganMessage.TabIndex = 9;
            this.txtOrganMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "To organ recievers :";
            // 
            // txtDebtorMessage
            // 
            this.txtDebtorMessage.Location = new System.Drawing.Point(9, 44);
            this.txtDebtorMessage.Multiline = true;
            this.txtDebtorMessage.Name = "txtDebtorMessage";
            this.txtDebtorMessage.Size = new System.Drawing.Size(389, 69);
            this.txtDebtorMessage.TabIndex = 8;
            this.txtDebtorMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "To debtor patients :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOrganExceptions);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtMaxDebtAmount);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 129);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Don\'t send result to patients by default";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Maximum Debt Amount :";
            // 
            // txtMaxDebtAmount
            // 
            this.txtMaxDebtAmount.Location = new System.Drawing.Point(136, 49);
            this.txtMaxDebtAmount.Name = "txtMaxDebtAmount";
            this.txtMaxDebtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaxDebtAmount.Size = new System.Drawing.Size(105, 20);
            this.txtMaxDebtAmount.TabIndex = 6;
            this.txtMaxDebtAmount.Text = "3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Rials";
            // 
            // txtOrganExceptions
            // 
            this.txtOrganExceptions.Location = new System.Drawing.Point(9, 96);
            this.txtOrganExceptions.Name = "txtOrganExceptions";
            this.txtOrganExceptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOrganExceptions.Size = new System.Drawing.Size(268, 20);
            this.txtOrganExceptions.TabIndex = 7;
            this.txtOrganExceptions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Organ Exceptions (E.g. 1131, 1173, ...) :";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReloadInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRetryInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDoctorMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrganMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDebtorMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPatientMessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxAttempts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtOrganExceptions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaxDebtAmount;
        private System.Windows.Forms.Label label12;
    }
}