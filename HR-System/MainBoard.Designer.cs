namespace HR_System
{
    partial class MainBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.MS = new System.Windows.Forms.MenuStrip();
            this.TMHome = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TMTask = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmInsertEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSearchEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TMReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStatis = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSecurrity = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUserControl = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUserEval = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PMain = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.MS.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.MS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1355, 50);
            this.panel2.TabIndex = 1;
            // 
            // MS
            // 
            this.MS.Font = new System.Drawing.Font("Khmer Kep", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMHome,
            this.TMTask,
            this.TMReport,
            this.TMSecurrity});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MS.Size = new System.Drawing.Size(1355, 41);
            this.MS.TabIndex = 0;
            this.MS.Text = "menuStrip1";
            // 
            // TMHome
            // 
            this.TMHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAccount,
            this.TsmUser,
            this.TsmExit});
            this.TMHome.Image = ((System.Drawing.Image)(resources.GetObject("TMHome.Image")));
            this.TMHome.Name = "TMHome";
            this.TMHome.Size = new System.Drawing.Size(98, 37);
            this.TMHome.Text = "គ្រប់គ្រង";
            // 
            // TsmAccount
            // 
            this.TsmAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmRegistration,
            this.TsmChangePassword});
            this.TsmAccount.Image = ((System.Drawing.Image)(resources.GetObject("TsmAccount.Image")));
            this.TsmAccount.Name = "TsmAccount";
            this.TsmAccount.Size = new System.Drawing.Size(197, 38);
            this.TsmAccount.Text = "គណនី";
            this.TsmAccount.Click += new System.EventHandler(this.TsmAccount_Click);
            // 
            // TsmRegistration
            // 
            this.TsmRegistration.Name = "TsmRegistration";
            this.TsmRegistration.Size = new System.Drawing.Size(208, 38);
            this.TsmRegistration.Text = "ប្រវត្តិរូប";
            this.TsmRegistration.Click += new System.EventHandler(this.TsmRegistration_Click);
            // 
            // TsmChangePassword
            // 
            this.TsmChangePassword.Name = "TsmChangePassword";
            this.TsmChangePassword.Size = new System.Drawing.Size(208, 38);
            this.TsmChangePassword.Text = "ផ្លាស់ប្តូរលេខសម្ងាត់";
            this.TsmChangePassword.Click += new System.EventHandler(this.TsmChangePassword_Click);
            // 
            // TsmUser
            // 
            this.TsmUser.Name = "TsmUser";
            this.TsmUser.Size = new System.Drawing.Size(197, 38);
            this.TsmUser.Text = "ចាកចេញពីគណនី";
            this.TsmUser.Click += new System.EventHandler(this.TsmUser_Click);
            // 
            // TsmExit
            // 
            this.TsmExit.Image = ((System.Drawing.Image)(resources.GetObject("TsmExit.Image")));
            this.TsmExit.Name = "TsmExit";
            this.TsmExit.Size = new System.Drawing.Size(197, 38);
            this.TsmExit.Text = "បិទកម្មវិធី";
            this.TsmExit.Click += new System.EventHandler(this.TsmExit_Click);
            // 
            // TMTask
            // 
            this.TMTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmInsertEmp,
            this.TsmSearchEmp,
            this.TsmDelete});
            this.TMTask.Name = "TMTask";
            this.TMTask.Size = new System.Drawing.Size(68, 37);
            this.TMTask.Text = "កិច្ចការ";
            // 
            // TsmInsertEmp
            // 
            this.TsmInsertEmp.Name = "TsmInsertEmp";
            this.TsmInsertEmp.Size = new System.Drawing.Size(187, 38);
            this.TsmInsertEmp.Text = "បញ្ចូលបុគ្គលិកថ្មី";
            this.TsmInsertEmp.Click += new System.EventHandler(this.TsmInsertEmp_Click);
            // 
            // TsmSearchEmp
            // 
            this.TsmSearchEmp.Name = "TsmSearchEmp";
            this.TsmSearchEmp.Size = new System.Drawing.Size(187, 38);
            this.TsmSearchEmp.Text = "ស្វែងរកបុគ្គលិក";
            this.TsmSearchEmp.Click += new System.EventHandler(this.TsmSearchEmp_Click);
            // 
            // TsmDelete
            // 
            this.TsmDelete.Name = "TsmDelete";
            this.TsmDelete.Size = new System.Drawing.Size(187, 38);
            this.TsmDelete.Text = "បញ្ចប់កិច្ចសន្យា";
            this.TsmDelete.Click += new System.EventHandler(this.TsmDelete_Click);
            // 
            // TMReport
            // 
            this.TMReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStatis});
            this.TMReport.Name = "TMReport";
            this.TMReport.Size = new System.Drawing.Size(104, 37);
            this.TMReport.Text = "របាយការណ៍";
            // 
            // tsmStatis
            // 
            this.tsmStatis.Name = "tsmStatis";
            this.tsmStatis.Size = new System.Drawing.Size(180, 38);
            this.tsmStatis.Text = "ស្ថិតិបុគ្គលិក";
            this.tsmStatis.Click += new System.EventHandler(this.tsmStatis_Click);
            // 
            // TMSecurrity
            // 
            this.TMSecurrity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmCreateUser,
            this.TsmUserControl,
            this.TsmUserEval});
            this.TMSecurrity.Name = "TMSecurrity";
            this.TMSecurrity.Size = new System.Drawing.Size(84, 37);
            this.TMSecurrity.Text = "សុវត្ថិភាព";
            // 
            // TsmCreateUser
            // 
            this.TsmCreateUser.Name = "TsmCreateUser";
            this.TsmCreateUser.Size = new System.Drawing.Size(221, 38);
            this.TsmCreateUser.Text = "បង្កើតគណនីប្រើប្រាស់";
            this.TsmCreateUser.Click += new System.EventHandler(this.TsmCreateUser_Click);
            // 
            // TsmUserControl
            // 
            this.TsmUserControl.Name = "TsmUserControl";
            this.TsmUserControl.Size = new System.Drawing.Size(221, 38);
            this.TsmUserControl.Text = "គ្រប់គ្រងអ្នកប្រើប្រាស់";
            this.TsmUserControl.Click += new System.EventHandler(this.TsmUserControl_Click);
            // 
            // TsmUserEval
            // 
            this.TsmUserEval.Name = "TsmUserEval";
            this.TsmUserEval.Size = new System.Drawing.Size(221, 38);
            this.TsmUserEval.Text = "តាមដានអ្នកប្រើប្រាស់";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lblAccount);
            this.panel4.Controls.Add(this.lblUserName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 680);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1355, 37);
            this.panel4.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Khmer Kep", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(178, 3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(21, 29);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer Kep", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "គណនីកំពុងប្រើប្រាស់៖";
            // 
            // PMain
            // 
            this.PMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMain.Location = new System.Drawing.Point(0, 50);
            this.PMain.Name = "PMain";
            this.PMain.Size = new System.Drawing.Size(1355, 630);
            this.PMain.TabIndex = 4;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Khmer Kep", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(372, 8);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(21, 29);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "0";
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1355, 717);
            this.Controls.Add(this.PMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Khmer Kep", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MS;
            this.Name = "MainBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "កម្មវិធីគ្រប់គ្រងទិន្នន័យ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainBoard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.MenuStrip MS;
        public System.Windows.Forms.Panel PMain;
        public System.Windows.Forms.ToolStripMenuItem TMHome;
        public System.Windows.Forms.ToolStripMenuItem TMTask;
        public System.Windows.Forms.ToolStripMenuItem TMReport;
        public System.Windows.Forms.ToolStripMenuItem TsmAccount;
        public System.Windows.Forms.ToolStripMenuItem TsmExit;
        public System.Windows.Forms.ToolStripMenuItem TsmInsertEmp;
        public System.Windows.Forms.ToolStripMenuItem TsmSearchEmp;
        public System.Windows.Forms.ToolStripMenuItem tsmStatis;
        public System.Windows.Forms.ToolStripMenuItem TsmCreateUser;
        public System.Windows.Forms.ToolStripMenuItem TsmUserControl;
        public System.Windows.Forms.ToolStripMenuItem TsmUserEval;
        public System.Windows.Forms.ToolStripMenuItem TsmRegistration;
        public System.Windows.Forms.ToolStripMenuItem TsmChangePassword;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolStripMenuItem TsmDelete;
        public System.Windows.Forms.ToolStripMenuItem TsmUser;
        public System.Windows.Forms.ToolStripMenuItem TMSecurrity;
        public System.Windows.Forms.Label lblAccount;
    }
}