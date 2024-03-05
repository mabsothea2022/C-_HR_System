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
using System.Drawing.Drawing2D;
using System.IO;

namespace HR_System
{
    public partial class FrmCreateUser : Form
    {
        OleDbDataReader dr;
        public FrmCreateUser()
        {
            InitializeComponent();
        }
        ConnectionMB op = new ConnectionMB();
        private void FrmCreateUser_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {

            OleDbCommand cmd;
            //Call Data
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            dgvUser.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from T_User order by UserID", con);
            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvUser.RowTemplate.Height = 40;
                dgvUser.Rows.Add(i, dr["UserID"].ToString(), dr["UserName"].ToString(), dr["PW"].ToString(), dr["RePW"].ToString(), dr["PV"].ToString(), dr["AC"].ToString());
               


            }
            dr.Close();
            con.Close();



        }
        void Clear()
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtPW.Text = "";
            txtRePW.Text = "";
            rbActive.Checked = true;
            rbAdmin.Checked = true;
            GetUserID();
            GetUser();
            this.ActiveControl = txtPW;
        }
        //void GetUserName()
        //{
        //    try
        //    {
        //        OleDbConnection con = op.GetCon();
        //        OleDbDataAdapter query1 = new OleDbDataAdapter("select UserName From T_User order by UserName Desc", con);
        //        DataSet Bumrah = new DataSet();
        //        query1.Fill(Bumrah);
        //        if (Bumrah.Tables[0].Rows.Count > 0)
        //        {
        //            txtUserNamex.Text = Bumrah.Tables[0].Rows[0]["UserName"].ToString();

        //        }
        //        else
        //        {
        //            txtUserNamex.Text = "COM23000T001";
        //        }
        //        if (!String.IsNullOrEmpty(txtUserNamex.Text))

        //        {
        //            txtUserNamex.SelectionStart = 5;
        //            txtUserNamex.SelectionLength = 5;
        //            lblUserNamex.Text = txtUserNamex.SelectedText;
        //        }
        //        if (!String.IsNullOrEmpty(lblUserNamex.Text))
        //        {
        //            int ID = int.Parse(lblUserNamex.Text.ToString()) + 1;
        //            txtUserName.Text = ID.ToString("COM23000T001");
        //        }

        //    }
        //    catch (Exception ab)
        //    {
        //        MessageBox.Show(ab.Message);
        //    }
        //}
        void GetUserID()
        {
            try
            {
                OleDbConnection con = op.GetCon();
                OleDbDataAdapter query1 = new OleDbDataAdapter("select UserID From T_User order by UserID Desc", con);
                DataSet Bumrah = new DataSet();
                query1.Fill(Bumrah);
                if (Bumrah.Tables[0].Rows.Count > 0)
                {
                    txtUserIDx.Text = Bumrah.Tables[0].Rows[0]["UserID"].ToString();

                }
                else
                {
                    txtUserIDx.Text = "COM23000";
                }
                if (!String.IsNullOrEmpty(txtUserIDx.Text))

                {
                    txtUserIDx.SelectionStart = 5;
                    txtUserIDx.SelectionLength = 5;
                    lblUserIDx.Text = txtUserIDx.SelectedText;
                }
                if (!String.IsNullOrEmpty(lblUserIDx.Text))
                {
                    int ID = int.Parse(lblUserIDx.Text.ToString()) + 1;
                    txtUserID.Text = ID.ToString("COM23000");
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }
        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActive.Checked)
            {
                lblActive.Text = "Active";
            }
        }

        private void rbDective_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDective.Checked)
            {
                lblActive.Text = "Disable";
            }
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                lblUserAccount.Text = "Admin";
            }
        }

        private void rbManager_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManager.Checked)
            {
                lblUserAccount.Text = "Manager";
            }
        }

        private void rbDataEntry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDataEntry.Checked)
            {
                lblUserAccount.Text = "DataEntry";
            }
        }

        private void cbCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCreate.Checked)
            {
               
                txtPW.Enabled = true;
                txtRePW.Enabled = true;
               // GetUserName();
                GetUserID();
                this.ActiveControl = txtPW;
                rbActive.Checked = true;
                rbAdmin.Checked = true;
                GetUser();


            }
            else
            {
                
                txtPW.Enabled = false;
                txtRePW.Enabled = false;

                
            }
        }
        void GetUser()
        {
            string a = txtUserID.Text;
            string b = a + "T001";
            txtUserName.Text = b;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InputUser();
        }
        void InputUser()
        {
            OleDbConnection con = op.GetCon();
            string query1 = "Insert into T_User (UserID,UserName,PW,RePW,PV,AC) Values(?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(query1, con);

            cmd.Parameters.AddWithValue("@UserID", OleDbType.VarChar).Value = txtUserID.Text;
            cmd.Parameters.AddWithValue("@UserName", OleDbType.VarChar).Value = txtUserName.Text;
            cmd.Parameters.AddWithValue("@PW", OleDbType.VarChar).Value = txtPW.Text;
            cmd.Parameters.AddWithValue("@RePW", OleDbType.VarChar).Value = txtRePW.Text;
            cmd.Parameters.AddWithValue("@PV", OleDbType.VarChar).Value = lblActive.Text;
            cmd.Parameters.AddWithValue("@AC", OleDbType.VarChar).Value = lblUserAccount.Text;


            //Opening Access Database Connection
            con.Open();
            int insertDataToAccessDatabase = cmd.ExecuteNonQuery();
            con.Close();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Data Inserted Susccessfully.........");
            }
            Clear();
            ShowData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                txtRePW.Focus();
            }
        }

        private void piExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerformat = new StringFormat()
            {
                //set number align to center
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerbounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerbounds, centerformat);
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPW.Enabled = true;
            txtRePW.Enabled = true;



            txtUserID.Text= dgvUser.CurrentRow.Cells[1].Value.ToString();
            txtUserName.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            txtPW.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            txtRePW.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();



           if (dgvUser.CurrentRow.Cells[5].Value.ToString()== "Active")
            {
                rbActive.Checked = true;
            }
           else
            {
                rbDective.Checked = true;
            }


            if (dgvUser.CurrentRow.Cells[6].Value.ToString() == "Admin")
            {
                rbAdmin.Checked = true;
            }
           else if (dgvUser.CurrentRow.Cells[6].Value.ToString() == "Manager")
            {
                rbManager.Checked = true;
            }
            else
            {
                rbDataEntry.Checked = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateI();
        }
        void UpdateI()
        {
            if (MessageBox.Show("Data Update Successfully", "Do you want to Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection con = op.GetCon();
                try
                {
                   


                    //....................................
                    OleDbCommand cmd = new OleDbCommand("Update T_User set  UserID='" + txtUserID.Text + "',UserName='" + txtUserName.Text + "',PW='" + txtPW.Text + "',RePW='" + txtRePW.Text + "', PV='" + lblActive.Text + "',AC='" + lblUserAccount.Text + "' Where UserID='" + txtUserID.Text + "'", con);
                    //,@photo)", con);
                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successfull!");

                    Clear();
                    ShowData();

                    //.....................................


                }
                catch (Exception x)
                {
                    MessageBox.Show(x + "");
                }
            }
            else
            {
                MessageBox.Show("Data not Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
