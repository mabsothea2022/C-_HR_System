using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace HR_System
{
    public partial class FrmLogIn : Form
    {
        int x = 3;
        public static FrmLogIn LI;
        public FrmLogIn()
        {
            InitializeComponent();
            LI = this;
        }
        ConnectionMB  op = new ConnectionMB();
        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "COM23001";
            txtUserName.ForeColor = System.Drawing.Color.Black;
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text =="User Name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {

            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;

                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Silver;
            }
        }
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.GetCon();

            if (lblAcctive.Text == "Active" && lblAccount.Text == "Admin")
            {
                string query = "Select * From T_User where UserName = '" + txtUserName.Text + "' and PW='" + txtPassword.Text + "'";
                da = new OleDbDataAdapter(query, con);
                da.Fill(dt);
                if (txtPassword.Text == "Password" && txtPassword.Text=="")
                    MessageBox.Show("Empty Field not allow....!");
                else
                    if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainBoard fr = new MainBoard();

                    MainBoard.MB.TMSecurrity.Enabled = true;
                    MainBoard.MB.TMReport.Enabled = true;
                    MainBoard.MB.TMTask.Enabled = true;
                    //-------------------------------
                    MainBoard.MB.lblUserName.Text = txtUserName.Text;
                    MainBoard.MB.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x--;
                    if (x == 0)
                    {
                        Hide();
                        MessageBox.Show("You have excced the limit , please Connect us");
                        Application.Exit();
                    }

                }
            }
            //c2
            else if (lblAcctive.Text == "Active" && lblAccount.Text == "DataEntry")
            {
                string query = "Select * From T_User where UserName = '" + txtUserName.Text + "' and PW='" + txtPassword.Text + "'";
                da = new OleDbDataAdapter(query, con);
                da.Fill(dt);
                if (txtPassword.Text == "Password" && txtPassword.Text == "")
                    MessageBox.Show("Empty Field not allow....!");
                else
                    if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainBoard fr = new MainBoard();
                    MainBoard.MB.TMReport.Enabled = true;
                    MainBoard.MB.TMTask.Enabled = true;
                    MainBoard.MB.TMSecurrity.Visible = false;

                    //-------------------------------
                    MainBoard.MB.lblUserName.Text = txtUserName.Text;
                    MainBoard.MB.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x--;
                    if (x == 0)
                    {
                        Hide();
                        MessageBox.Show("You have excced the limit , please Connect us");
                        Application.Exit();
                    }

                }

            }
            //c3
            else if (lblAcctive.Text == "Active" && lblAccount.Text == "Manager")
            {
                string query = "Select * From T_User where UserName = '" + txtUserName.Text + "' and PW='" + txtPassword.Text + "'";
                da = new OleDbDataAdapter(query, con);
                da.Fill(dt);
                if (txtPassword.Text == "Password" && txtPassword.Text == "")
                    MessageBox.Show("Empty Field not allow....!");
                else
                    if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainBoard fr = new MainBoard();
                    MainBoard.MB.TMReport.Enabled = true;

                    MainBoard.MB.TMTask.Enabled = true;
                    MainBoard.MB.TsmInsertEmp.Enabled = false;
                    MainBoard.MB.TMSecurrity.Visible = false;
                    //-------------------------------
                    MainBoard.MB.lblUserName.Text = txtUserName.Text;
                    MainBoard.MB.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();

                }
                else
                {
                    MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x--;
                    if (x == 0)
                    {
                        Hide();
                        MessageBox.Show("You have excced the limit , please Connect us");
                        Application.Exit();
                    }

                }

            }
            //Disable++++++++++++++++++++++++++++++++++++++++++++
            else if (lblAcctive.Text == "Disable" && lblAccount.Text == "Admin")
            {
                string query = "Select * From T_User where UserName = '" + txtUserName.Text + "' and PW='" + txtPassword.Text + "'";
                da = new OleDbDataAdapter(query, con);
                da.Fill(dt);
                if (txtPassword.Text == "Password" && txtPassword.Text == "")
                    MessageBox.Show("Empty Field not allow....!");
                else
                    if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainBoard fr = new MainBoard();
                    MainBoard.MB.TMSecurrity.Enabled = false;
                    MainBoard.MB.TMReport.Enabled = false;
                    MainBoard.MB.TMTask.Enabled = false;

                    //-------------------------------
                    MainBoard.MB.lblUserName.Text = txtUserName.Text;
                    MainBoard.MB.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();

                }
                else
                {
                    MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x--;
                    if (x == 0)
                    {
                        Hide();
                        MessageBox.Show("You have excced the limit , please Connect us");
                        Application.Exit();
                    }

                }

            }
            else if (lblAcctive.Text == "Disable" && lblAccount.Text == "Manager")
            {
                string query = "Select * From T_User where UserName = '" + txtUserName.Text + "' and PW='" + txtPassword.Text + "'";
                da = new OleDbDataAdapter(query, con);
                da.Fill(dt);
                if (txtPassword.Text == "Password" && txtPassword.Text == "")
                    MessageBox.Show("Empty Field not allow....!");
                else
                    if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainBoard fr = new MainBoard();
                    MainBoard.MB.TMSecurrity.Visible = false;
                    MainBoard.MB.TMReport.Enabled = false;
                    MainBoard.MB.TMTask.Enabled = false;

                    //-------------------------------
                    MainBoard.MB.lblUserName.Text = txtUserName.Text;
                    MainBoard.MB.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();

                }
                else
                {
                    MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x--;
                    if (x == 0)
                    {
                        Hide();
                        MessageBox.Show("You have excced the limit , please Connect us");
                        Application.Exit();
                    }

                }

            }
            else if (lblAcctive.Text == "Disable" && lblAccount.Text == "DataEntry")
            {
                string query = "Select * From T_User where UserName = '" + txtUserName.Text + "' and PW='" + txtPassword.Text + "'";
                da = new OleDbDataAdapter(query, con);
                da.Fill(dt);
                if (txtPassword.Text == "Password" && txtPassword.Text == "")
                    MessageBox.Show("Empty Field not allow....!");
                else
                    if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainBoard fr = new MainBoard();
                    MainBoard.MB.TMSecurrity.Visible = false;
                    MainBoard.MB.TMReport.Enabled = false;
                    MainBoard.MB.TMTask.Enabled = false;

                    //-------------------------------
                    MainBoard.MB.lblUserName.Text = txtUserName.Text;
                    MainBoard.MB.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();

                }
                else
                {
                    MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x--;
                    if (x == 0)
                    {
                        Hide();
                        MessageBox.Show("You have excced the limit , please Connect us");
                        Application.Exit();
                    }

                }

            }












        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = op.GetCon();
                string query = "select * from T_User where UserName ='" + txtUserName.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, op.GetCon());
                DataTable dt = new DataTable();
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lblAcctive.Text = dr["PV"].ToString();
                    lblAccount.Text = dr["AC"].ToString();
                   

                    ////----------------------
                    //byte[] photo = (byte[])dr["EImage"];
                    //MemoryStream ms = new MemoryStream(photo);
                    //PicImage.Image = Image.FromStream(ms);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
