namespace HR_System
{
    partial class FrmCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateUser));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUserIDx = new System.Windows.Forms.Label();
            this.txtUserIDx = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.rbDective = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUserAccount = new System.Windows.Forms.Label();
            this.rbDataEntry = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.txtRePW = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.piExt = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piExt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.lblUserIDx);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.txtUserIDx);
            this.groupBox3.Controls.Add(this.lblActive);
            this.groupBox3.Controls.Add(this.rbDective);
            this.groupBox3.Controls.Add(this.rbActive);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dgvUser);
            this.groupBox3.Controls.Add(this.cbCreate);
            this.groupBox3.Controls.Add(this.txtRePW);
            this.groupBox3.Controls.Add(this.txtPW);
            this.groupBox3.Controls.Add(this.txtUserID);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Location = new System.Drawing.Point(12, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 668);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "បង្កើតគណនីបន្ថែម";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblUserIDx
            // 
            this.lblUserIDx.AutoSize = true;
            this.lblUserIDx.Location = new System.Drawing.Point(780, 623);
            this.lblUserIDx.Name = "lblUserIDx";
            this.lblUserIDx.Size = new System.Drawing.Size(64, 33);
            this.lblUserIDx.TabIndex = 13;
            this.lblUserIDx.Text = "UserID";
            // 
            // txtUserIDx
            // 
            this.txtUserIDx.Enabled = false;
            this.txtUserIDx.Location = new System.Drawing.Point(864, 620);
            this.txtUserIDx.MaxLength = 8;
            this.txtUserIDx.Name = "txtUserIDx";
            this.txtUserIDx.Size = new System.Drawing.Size(142, 41);
            this.txtUserIDx.TabIndex = 12;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(669, 62);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(24, 33);
            this.lblActive.TabIndex = 7;
            this.lblActive.Text = "0";
            // 
            // rbDective
            // 
            this.rbDective.AutoSize = true;
            this.rbDective.Location = new System.Drawing.Point(569, 54);
            this.rbDective.Name = "rbDective";
            this.rbDective.Size = new System.Drawing.Size(94, 37);
            this.rbDective.TabIndex = 10;
            this.rbDective.TabStop = true;
            this.rbDective.Text = "បញ្ចប់សិទ្ធ";
            this.rbDective.UseVisualStyleBackColor = true;
            this.rbDective.CheckedChanged += new System.EventHandler(this.rbDective_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(468, 54);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(84, 37);
            this.rbActive.TabIndex = 9;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "ផ្តល់សិទ្ធ";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUserAccount);
            this.groupBox2.Controls.Add(this.rbDataEntry);
            this.groupBox2.Controls.Add(this.rbAdmin);
            this.groupBox2.Controls.Add(this.rbManager);
            this.groupBox2.Location = new System.Drawing.Point(444, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblUserAccount
            // 
            this.lblUserAccount.AutoSize = true;
            this.lblUserAccount.Location = new System.Drawing.Point(194, 106);
            this.lblUserAccount.Name = "lblUserAccount";
            this.lblUserAccount.Size = new System.Drawing.Size(24, 33);
            this.lblUserAccount.TabIndex = 1;
            this.lblUserAccount.Text = "0";
            // 
            // rbDataEntry
            // 
            this.rbDataEntry.AutoSize = true;
            this.rbDataEntry.Location = new System.Drawing.Point(25, 102);
            this.rbDataEntry.Name = "rbDataEntry";
            this.rbDataEntry.Size = new System.Drawing.Size(137, 37);
            this.rbDataEntry.TabIndex = 0;
            this.rbDataEntry.TabStop = true;
            this.rbDataEntry.Text = "អ្នកបញ្ចូលទិន្នន័យ";
            this.rbDataEntry.UseVisualStyleBackColor = true;
            this.rbDataEntry.CheckedChanged += new System.EventHandler(this.rbDataEntry_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(25, 25);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(116, 37);
            this.rbAdmin.TabIndex = 5;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "រដ្ឋបាលកម្មវិធី";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(25, 59);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(105, 37);
            this.rbManager.TabIndex = 0;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "អ្នកគ្រប់គ្រង";
            this.rbManager.UseVisualStyleBackColor = true;
            this.rbManager.CheckedChanged += new System.EventHandler(this.rbManager_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "បញ្ជាក់";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "អាយឌី";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "គណនី";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "លេខសំងាត់";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUser.Location = new System.Drawing.Point(6, 247);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(1000, 367);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            this.dgvUser.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUser_RowPostPaint);
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Location = new System.Drawing.Point(127, 10);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(15, 14);
            this.cbCreate.TabIndex = 2;
            this.cbCreate.UseVisualStyleBackColor = true;
            this.cbCreate.CheckedChanged += new System.EventHandler(this.cbCreate_CheckedChanged);
            // 
            // txtRePW
            // 
            this.txtRePW.Enabled = false;
            this.txtRePW.Location = new System.Drawing.Point(127, 200);
            this.txtRePW.MaxLength = 8;
            this.txtRePW.Name = "txtRePW";
            this.txtRePW.Size = new System.Drawing.Size(295, 41);
            this.txtRePW.TabIndex = 1;
            // 
            // txtPW
            // 
            this.txtPW.Enabled = false;
            this.txtPW.Location = new System.Drawing.Point(127, 148);
            this.txtPW.MaxLength = 8;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(295, 41);
            this.txtPW.TabIndex = 8;
            this.txtPW.Enter += new System.EventHandler(this.txtPW_Enter);
            this.txtPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPW_KeyDown);
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(127, 54);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(295, 41);
            this.txtUserID.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(127, 101);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(295, 41);
            this.txtUserName.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Location = new System.Drawing.Point(809, 32);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 41);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "រក្សាទុក";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(809, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "សម្អាត";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.piExt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 36);
            this.panel1.TabIndex = 6;
            // 
            // piExt
            // 
            this.piExt.Image = ((System.Drawing.Image)(resources.GetObject("piExt.Image")));
            this.piExt.Location = new System.Drawing.Point(1004, 3);
            this.piExt.Name = "piExt";
            this.piExt.Size = new System.Drawing.Size(29, 29);
            this.piExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piExt.TabIndex = 7;
            this.piExt.TabStop = false;
            this.piExt.Click += new System.EventHandler(this.piExt_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(810, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 42);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "កែតម្រូវ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ល.រ";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 66;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "អាយឌី";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "គណនីប្រើប្រាស់";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "លេខសំងាត់";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "បញ្ជាក់លេខសំងាត់";
            this.Column4.Name = "Column4";
            this.Column4.Width = 152;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "សិទ្ធ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "ប្រភេទគណនី";
            this.Column6.Name = "Column6";
            this.Column6.Width = 119;
            // 
            // FrmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1045, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateUser";
            this.Load += new System.EventHandler(this.FrmCreateUser_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piExt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgvUser;
        public System.Windows.Forms.CheckBox cbCreate;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtRePW;
        public System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUserID;
        public System.Windows.Forms.Label lblActive;
        public System.Windows.Forms.RadioButton rbDective;
        public System.Windows.Forms.RadioButton rbActive;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblUserAccount;
        private System.Windows.Forms.RadioButton rbDataEntry;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbManager;
        public System.Windows.Forms.Label lblUserIDx;
        public System.Windows.Forms.TextBox txtUserIDx;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox piExt;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}