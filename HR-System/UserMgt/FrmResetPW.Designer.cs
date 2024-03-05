namespace HR_System
{
    partial class FrmResetPW
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReNewPW = new System.Windows.Forms.TextBox();
            this.txtNewPW = new System.Windows.Forms.TextBox();
            this.txtCurrentPW = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPWAdmin = new System.Windows.Forms.TextBox();
            this.cbTick = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReNewPW);
            this.groupBox1.Controls.Add(this.txtNewPW);
            this.groupBox1.Controls.Add(this.txtCurrentPW);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "សូមបំពេញព័ត៌មាន";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "លេខសម្ងាត់ថ្មីម្តងទៀត";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "លេខសំងាត់ថ្មី សូមបញ្ចូល 8 ខ្ទង់";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "លេខសំងាត់កំពុងប្រើប្រាស់";
            // 
            // txtReNewPW
            // 
            this.txtReNewPW.Enabled = false;
            this.txtReNewPW.Location = new System.Drawing.Point(131, 315);
            this.txtReNewPW.MaxLength = 8;
            this.txtReNewPW.Name = "txtReNewPW";
            this.txtReNewPW.Size = new System.Drawing.Size(349, 41);
            this.txtReNewPW.TabIndex = 9;
            this.txtReNewPW.Click += new System.EventHandler(this.txtReNewPW_Click);
            // 
            // txtNewPW
            // 
            this.txtNewPW.Enabled = false;
            this.txtNewPW.Location = new System.Drawing.Point(131, 235);
            this.txtNewPW.MaxLength = 8;
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.Size = new System.Drawing.Size(349, 41);
            this.txtNewPW.TabIndex = 9;
            this.txtNewPW.Click += new System.EventHandler(this.txtNewPW_Click);
            this.txtNewPW.TextChanged += new System.EventHandler(this.txtNewPW_TextChanged);
            this.txtNewPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPW_KeyDown);
            // 
            // txtCurrentPW
            // 
            this.txtCurrentPW.Location = new System.Drawing.Point(131, 155);
            this.txtCurrentPW.MaxLength = 8;
            this.txtCurrentPW.Name = "txtCurrentPW";
            this.txtCurrentPW.Size = new System.Drawing.Size(349, 41);
            this.txtCurrentPW.TabIndex = 12;
            this.txtCurrentPW.Click += new System.EventHandler(this.txtCurrentPW_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(131, 73);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 41);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "អត្តលេខ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(551, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPWAdmin
            // 
            this.txtPWAdmin.Enabled = false;
            this.txtPWAdmin.Location = new System.Drawing.Point(551, 130);
            this.txtPWAdmin.Name = "txtPWAdmin";
            this.txtPWAdmin.Size = new System.Drawing.Size(229, 41);
            this.txtPWAdmin.TabIndex = 2;
            this.txtPWAdmin.Click += new System.EventHandler(this.txtPWAdmin_Click);
            // 
            // cbTick
            // 
            this.cbTick.AutoSize = true;
            this.cbTick.Location = new System.Drawing.Point(551, 87);
            this.cbTick.Name = "cbTick";
            this.cbTick.Size = new System.Drawing.Size(286, 37);
            this.cbTick.TabIndex = 3;
            this.cbTick.Text = "បញ្ចូលលេខសំងាត់ដែលផ្តល់ដោយ Admin";
            this.cbTick.UseVisualStyleBackColor = true;
            this.cbTick.CheckedChanged += new System.EventHandler(this.cbTick_CheckedChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(681, 204);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 46);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "សម្អាត";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 48);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer M1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "ទម្រង់ផ្លាស់ប្តូរលេខសម្ងាត់";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(371, 79);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(24, 33);
            this.lblAccount.TabIndex = 14;
            this.lblAccount.Text = "0";
            this.lblAccount.Visible = false;
            // 
            // FrmResetPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(927, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTick);
            this.Controls.Add(this.txtPWAdmin);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmResetPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResetPW";
            this.Load += new System.EventHandler(this.FrmResetPW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtReNewPW;
        public System.Windows.Forms.TextBox txtNewPW;
        public System.Windows.Forms.TextBox txtCurrentPW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPWAdmin;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.CheckBox cbTick;
        public System.Windows.Forms.Label lblAccount;
    }
}