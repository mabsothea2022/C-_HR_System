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
using System.Collections;


namespace HR_System
{
    public partial class FrmResetPW : Form
    {
        public static FrmResetPW RP;
        public FrmResetPW()
        {
            InitializeComponent();
            RP = this;
        }
        ConnectionMB op = new ConnectionMB();
        string query;
        private void FrmResetPW_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCurrentPW;
            txtCurrentPW.UseSystemPasswordChar = true;
            txtNewPW.UseSystemPasswordChar = true;
            txtReNewPW.UseSystemPasswordChar = true;
            btnSave.Enabled = false;
            btnSave.BackColor = System.Drawing.Color.Red;
            txtPWAdmin.UseSystemPasswordChar = true;
        }

        private void txtCurrentPW_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.GetCon();

            query = "select * from T_User where UserName = '" + txtUserName.Text + "'and  PW='" + txtCurrentPW.Text + "'";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                txtCurrentPW.Enabled = false;
                MessageBox.Show("Your Password is True Please Go On");
                txtNewPW.Enabled = true;
                txtNewPW.Focus();
               
            }
            else
            {
                MessageBox.Show("Your Have Entered the wrong password...!");
                txtCurrentPW.Text = "";
                txtCurrentPW.Focus();
            }

            con.Close();
        }

        private void txtNewPW_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNewPW_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtNewPW_Click(object sender, EventArgs e)
        {
            if (txtNewPW.Text == txtCurrentPW.Text)
            {
                MessageBox.Show("Your Password Is Ready Using In you System");
                txtNewPW.Text = "";
                txtNewPW.Focus();
            }
            else
            {
                MessageBox.Show("Your is Pass ");
                txtNewPW.Enabled = false;
                txtReNewPW.Enabled = true;
                txtReNewPW.Focus();
            }
        }

        private void txtReNewPW_Click(object sender, EventArgs e)
        {
            if (txtNewPW.Text == txtReNewPW.Text)
            {
                MessageBox.Show("Your Password is True");
               
                txtReNewPW.Enabled = false;
                cbTick.Checked=true;
            }
            else
            {
                MessageBox.Show("Your Password not Match ");
                txtReNewPW.Text = "";
                
                txtReNewPW.Focus();
            }
        }

        private void txtPWAdmin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.GetCon();

            query = "select * from T_Admin where UserAdmin = '" + txtPWAdmin.Text + "'";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                txtPWAdmin.Enabled = false;
                btnSave.Enabled = true;
                btnSave.BackColor=System.Drawing.Color.Blue;
            }
            else
            {
                txtPWAdmin.Enabled = true;
                txtPWAdmin.Text = "";
                txtPWAdmin.Focus();
            }

            con.Close();
        }

        private void cbTick_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTick.Checked)
            {
                txtPWAdmin.Enabled = true;
            }
            else
            {
                txtPWAdmin.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtPWAdmin.Text = "";
            txtCurrentPW.Text = "";
            txtNewPW.Text = "";
            
            txtReNewPW.Text = "";
            txtCurrentPW.Enabled = true;
            txtCurrentPW.Focus();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPW.Text != "" && txtReNewPW.Text != "")
            {
                try

                {

                    query = "update T_User set PW='" + txtNewPW.Text + "',RePW ='" + txtReNewPW.Text + "' where UserName = '" + txtUserName.Text + "'";
                    op.UpdateData(query);



                    Clear();

                    this.Hide();
                    FrmRegUser fr = new FrmRegUser();
                    fr.lbUsername.Text= txtUserName.Text;
                    fr.lblAccount.Text = lblAccount.Text;
                    fr.ShowDialog();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Your Data is empty Please Check Again", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
