using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_System
{
    public partial class MainBoard : Form
    {
        public static MainBoard MB;
        public MainBoard()
        {
            InitializeComponent();
            MB = this;
        }

        private void MainBoard_Load(object sender, EventArgs e)
        {
           
        }

        private void TsmExit_Click(object sender, EventArgs e)
        {
            MsExit exit = new MsExit();
            exit.ShowDialog();
        }
        public void Exit()
        {
            Application.Exit();
        }

        private void TsmReg_Click(object sender, EventArgs e)
        {
          
        }

       
        private void TsmClearMain_Click(object sender, EventArgs e)
        {
            PMain.Controls.Clear();
        }

        private void TsmRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Change Password first");
            FrmResetPW fr = new FrmResetPW();
            fr.txtUserName.Text = lblUserName.Text;
            fr.lblAccount.Text = lblAccount.Text;
            fr.ShowDialog();

        }

        private void TsmAccount_Click(object sender, EventArgs e)
        {
          
        }

        private void TsmCreateUser_Click(object sender, EventArgs e)
        {
            PMain.Controls.Clear();
            FrmCreateUser fr = new FrmCreateUser();
            
            fr.ShowDialog();
        }

        private void TsmChangePassword_Click(object sender, EventArgs e)
        {
            PMain.Controls.Clear();
            FrmResetPW fr = new FrmResetPW();
            fr.txtUserName.Text=lblUserName.Text;
            fr.lblAccount.Text = lblAccount.Text;
            fr.ShowDialog();
        }

        private void TsmUserControl_Click(object sender, EventArgs e)
        {
            PMain.Controls.Clear();
            FrmUserMgt fr = new FrmUserMgt();
           
            fr.ShowDialog();
        }

        private void TsmInsertEmp_Click(object sender, EventArgs e)
        {
            FrmEmployee fr = new FrmEmployee();
            fr.ShowDialog();
        }

        private void TsmSearchEmp_Click(object sender, EventArgs e)
        {
            FrmSearchem fr = new FrmSearchem();
            fr.ShowDialog();
        }

        private void TsmDelete_Click(object sender, EventArgs e)
        {
            FrmDeleteData fr = new FrmDeleteData();
            fr.ShowDialog();
        }

        private void tsmStatis_Click(object sender, EventArgs e)
        {
            FrmListEmp fr = new FrmListEmp();
            fr.ShowDialog();
        }

        private void TsmListEmp_Click(object sender, EventArgs e)
        {

        }

        private void TsmUser_Click(object sender, EventArgs e)
        {
            Hide();   
            FrmLogIn fr = new FrmLogIn();
            fr.ShowDialog();
        }
    }
}
