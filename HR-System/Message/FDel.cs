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
namespace HR_System
{
    public partial class FDel : Form
    {
        int x = 3;
        public static FDel D;
        public FDel()
        {
            InitializeComponent();
            D = this;
            timer1.Start();
        }
        ConnectionMB op = new ConnectionMB();
        private void FDel_Load(object sender, EventArgs e)
        {
            txtPasswordUnlock.UseSystemPasswordChar = true;
            this.ActiveControl = txtPasswordUnlock;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.lblTime.Text = time.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.GetCon();
            OleDbDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From T_User where UserName = '" + lblUserAccount.Text + "' and PW='" + txtPasswordUnlock.Text + "'";
           
            da = new OleDbDataAdapter(query, con);
            da.Fill(dt);
            if (txtPasswordUnlock.Text == "")
                MessageBox.Show("Empty Field not allow....!");
            else
                if (dt.Rows.Count > 0)
            {
                Hide();
                FrmDeleteData.DL.DeleteAll();
            }
           else
            {
                MessageBox.Show("UserName or Password is incorrect", "MS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // x -= 1;
                //x = x-1;
                x--;
                if (x == 0)
                {
                    Hide();
                    MessageBox.Show("You Have Exceed the limit , please try again later");
                    //this.Hide();
                    
                   
                }
            }





        }
    }
}
