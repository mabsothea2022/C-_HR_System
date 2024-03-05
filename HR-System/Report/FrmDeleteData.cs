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
    public partial class FrmDeleteData : Form
    {
        public static FrmDeleteData DL;
        public FrmDeleteData()
        {
            InitializeComponent();
            DL = this;
        }
        ConnectionMB op = new ConnectionMB();
        private void FrmDeleteData_Load(object sender, EventArgs e)
        {

        }
        public void DeleteAll()
        {
            try
            {
                string query = "Delete From TblEmployee where EmpID='" + DGVshowEmpDel.CurrentRow.Cells[2].Value.ToString() + "'";
                op.DeleteData(query);
               

                DGVshowEmpDel.Rows.Clear();
               


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtEmpID.Enabled = false;
            ShowbyEmpID();
        }
        void ShowbyEmpID()
        {
            OleDbCommand cmd;
            OleDbDataReader dr;
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVshowEmpDel.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from TblEmployee  where EmpID='" + txtEmpID.Text + "'", con);
            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVshowEmpDel.RowTemplate.Height = 60;
                DGVshowEmpDel.Rows.Add(i, dr["ID"].ToString(), dr["EmpID"].ToString(), dr["FNameKH"].ToString(), dr["LNameKH"].ToString(), dr["ESex"].ToString(),
                Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
                dr["VL"].ToString(), dr["CM"].ToString(), dr["DS"].ToString(), dr["PV"].ToString(),
                Convert.ToDateTime(dr["DIssue"]).ToString("dd/MM/yyyy"), dr["NPhone"].ToString());
                DGVshowEmpDel.ClearSelection();
            }
            dr.Close();
            con.Close();
        }

        private void DGVshowEmpDel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVshowEmpDel.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                FDel fr = new FDel();
                FDel.D.lblEmpID.Text = DGVshowEmpDel.CurrentRow.Cells[2].Value.ToString();
                FDel.D.lblUserAccount.Text = MainBoard.MB.lblUserName.Text;
                FDel.D.lblFNameKH.Text = DGVshowEmpDel.CurrentRow.Cells[3].Value.ToString();
                FDel.D.lblLNameKH.Text = DGVshowEmpDel.CurrentRow.Cells[4].Value.ToString(); ;
                FDel.D.lblSex.Text = DGVshowEmpDel.CurrentRow.Cells[5].Value.ToString();
                FDel.D.lblDOB.Text = DGVshowEmpDel.CurrentRow.Cells[6].Value.ToString();
                FDel.D.lblNPhone.Text = DGVshowEmpDel.CurrentRow.Cells[12].Value.ToString();
                fr.ShowDialog();


            }
        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked == true)
            {
                txtEmpID.Enabled = true;
            }
            else
            {
                txtEmpID.Enabled=false;
            }
        }
    }
}
