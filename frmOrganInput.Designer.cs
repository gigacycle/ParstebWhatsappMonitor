namespace ParstebWhatsapp
{
    partial class frmOrganInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganInput));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMoreNumbers = new System.Windows.Forms.Button();
            this.chksendToOrganInCharge = new System.Windows.Forms.CheckBox();
            this.chkCredited = new System.Windows.Forms.CheckBox();
            this.chkSendToPatient = new System.Windows.Forms.CheckBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInCharge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnOrgansList = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrgansList)).BeginInit();
            this.bnOrgansList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(150, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Can&cel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(308, 251);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "O&K";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMoreNumbers);
            this.groupBox2.Controls.Add(this.chksendToOrganInCharge);
            this.groupBox2.Controls.Add(this.chkCredited);
            this.groupBox2.Controls.Add(this.chkSendToPatient);
            this.groupBox2.Controls.Add(this.txtPhone2);
            this.groupBox2.Controls.Add(this.lblPhone2);
            this.groupBox2.Controls.Add(this.txtPhone1);
            this.groupBox2.Controls.Add(this.lblPhone1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(292, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 215);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRM Settings";
            // 
            // btnMoreNumbers
            // 
            this.btnMoreNumbers.Location = new System.Drawing.Point(15, 180);
            this.btnMoreNumbers.Name = "btnMoreNumbers";
            this.btnMoreNumbers.Size = new System.Drawing.Size(236, 25);
            this.btnMoreNumbers.TabIndex = 16;
            this.btnMoreNumbers.Text = "+ More Phone Nummbers";
            this.btnMoreNumbers.UseVisualStyleBackColor = true;
            this.btnMoreNumbers.Click += new System.EventHandler(this.btnMoreNumbers_Click);
            // 
            // chksendToOrganInCharge
            // 
            this.chksendToOrganInCharge.AutoSize = true;
            this.chksendToOrganInCharge.Location = new System.Drawing.Point(19, 90);
            this.chksendToOrganInCharge.Name = "chksendToOrganInCharge";
            this.chksendToOrganInCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chksendToOrganInCharge.Size = new System.Drawing.Size(123, 20);
            this.chksendToOrganInCharge.TabIndex = 3;
            this.chksendToOrganInCharge.Text = ": Send To Organ";
            this.chksendToOrganInCharge.UseVisualStyleBackColor = true;
            this.chksendToOrganInCharge.TextChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            this.chksendToOrganInCharge.Enter += new System.EventHandler(this.CheckBox_Enter);
            this.chksendToOrganInCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkSendToDoctor_KeyPress);
            this.chksendToOrganInCharge.Leave += new System.EventHandler(this.CheckBox_Leave);
            // 
            // chkCredited
            // 
            this.chkCredited.AutoSize = true;
            this.chkCredited.Location = new System.Drawing.Point(58, 30);
            this.chkCredited.Name = "chkCredited";
            this.chkCredited.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCredited.Size = new System.Drawing.Size(84, 20);
            this.chkCredited.TabIndex = 1;
            this.chkCredited.Text = ": Credited";
            this.chkCredited.UseVisualStyleBackColor = true;
            this.chkCredited.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            this.chkCredited.TextChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            this.chkCredited.Enter += new System.EventHandler(this.CheckBox_Enter);
            this.chkCredited.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkCredited_KeyPress);
            this.chkCredited.Leave += new System.EventHandler(this.CheckBox_Leave);
            // 
            // chkSendToPatient
            // 
            this.chkSendToPatient.AutoSize = true;
            this.chkSendToPatient.Location = new System.Drawing.Point(15, 60);
            this.chkSendToPatient.Name = "chkSendToPatient";
            this.chkSendToPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSendToPatient.Size = new System.Drawing.Size(127, 20);
            this.chkSendToPatient.TabIndex = 2;
            this.chkSendToPatient.Text = ": Send To Patient";
            this.chkSendToPatient.UseVisualStyleBackColor = true;
            this.chkSendToPatient.TextChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            this.chkSendToPatient.Enter += new System.EventHandler(this.CheckBox_Enter);
            this.chkSendToPatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkSendToPatient_KeyPress);
            this.chkSendToPatient.Leave += new System.EventHandler(this.CheckBox_Leave);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(124, 150);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(127, 23);
            this.txtPhone2.TabIndex = 5;
            this.txtPhone2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtPhone2.Enter += new System.EventHandler(this.txtPhone2_Enter);
            this.txtPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone2_KeyPress);
            this.txtPhone2.Leave += new System.EventHandler(this.txtPhone2_Leave);
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(12, 150);
            this.lblPhone2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(111, 16);
            this.lblPhone2.TabIndex = 15;
            this.lblPhone2.Text = "Second Phone # :";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(124, 120);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(127, 23);
            this.txtPhone1.TabIndex = 4;
            this.txtPhone1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtPhone1.Enter += new System.EventHandler(this.txtPhone1_Enter);
            this.txtPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone1_KeyPress);
            this.txtPhone1.Leave += new System.EventHandler(this.txtPhone1_Leave);
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Location = new System.Drawing.Point(30, 120);
            this.lblPhone1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(94, 16);
            this.lblPhone1.TabIndex = 5;
            this.lblPhone1.Text = "First Phone # :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInCharge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 215);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // lblInCharge
            // 
            this.lblInCharge.AutoSize = true;
            this.lblInCharge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInCharge.Location = new System.Drawing.Point(100, 110);
            this.lblInCharge.Name = "lblInCharge";
            this.lblInCharge.Size = new System.Drawing.Size(0, 16);
            this.lblInCharge.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(100, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 8;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(100, 60);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 16);
            this.lblCode.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(100, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "In Charge :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // bnOrgansList
            // 
            this.bnOrgansList.AddNewItem = null;
            this.bnOrgansList.BackColor = System.Drawing.SystemColors.Control;
            this.bnOrgansList.CountItem = this.bindingNavigatorCountItem;
            this.bnOrgansList.DeleteItem = null;
            this.bnOrgansList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripLabel1});
            this.bnOrgansList.Location = new System.Drawing.Point(0, 0);
            this.bnOrgansList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnOrgansList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnOrgansList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnOrgansList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnOrgansList.Name = "bnOrgansList";
            this.bnOrgansList.PositionItem = this.bindingNavigatorPositionItem;
            this.bnOrgansList.Size = new System.Drawing.Size(566, 25);
            this.bnOrgansList.TabIndex = 15;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(199, 22);
            this.toolStripLabel1.Text = "Next : PageDown, Previous : PageUp";
            // 
            // frmOrganInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnOrgansList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmOrganInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Organ CRM Settings";
            this.Shown += new System.EventHandler(this.frmDoctorInput_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDoctorInput_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrgansList)).EndInit();
            this.bnOrgansList.ResumeLayout(false);
            this.bnOrgansList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInCharge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bnOrgansList;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.CheckBox chksendToOrganInCharge;
        private System.Windows.Forms.CheckBox chkCredited;
        private System.Windows.Forms.CheckBox chkSendToPatient;
        private System.Windows.Forms.Button btnMoreNumbers;
    }
}