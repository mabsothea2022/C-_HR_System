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
using System.Runtime.Remoting.Messaging;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace HR_System
{
    public partial class FrmListEmp : Form
    {
        public static FrmListEmp LE;
        OleDbDataReader dr;
        OleDbCommand cmd;
        public FrmListEmp()
        {
            InitializeComponent();
            LE = this;
        }
        ConnectionMB op = new ConnectionMB();

        private void FrmListEmp_Load(object sender, EventArgs e)
        {

           
            LoadOG();
            cmbPost.Enabled = false;
        }
        void LoadPost()
        {
            DataTable tb = new DataTable("tblPostJob");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,PostJobName from tblPostJob", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbPost.DisplayMember = "PostJobName";
            cmbPost.ValueMember = "id";
            cmbPost.DataSource = tb;
            cmbPost.Text = " ";
            con.Close();
        }
        void LoadOG()
        {
            DataTable tb = new DataTable("TblOG");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,OGName from TblOG", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbOG.DisplayMember = "OGName";
            cmbOG.ValueMember = "id";
            cmbOG.DataSource = tb;
            cmbOG.Text = " ";
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ShowEmpAll();
        }
        void ShowEmpAll()
        {

            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVShowCard.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from QListEmp  order by EmpID", con);

            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVShowCard.RowTemplate.Height = 20;
                DGVShowCard.Rows.Add(i, dr["EmpID"].ToString(), dr["FullNameKH"].ToString(), dr["FullNameEN"].ToString(), dr["ESex"].ToString(),
                Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
               dr["OGID"].ToString(), dr["OGName"].ToString(), dr["PTID"].ToString(),dr["PTName"].ToString(), dr["Address"].ToString(), dr["PVJ"].ToString());
                DGVShowCard.Sort(DGVShowCard.Columns[6], ListSortDirection.Ascending);
               

            }
            dr.Close();
            con.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbCheck.Checked == true)
            {
                ShowPT(); 
            }
            else
            {
                ShowOG();
            }
            


            //
           
        }
        void ShowOG()
        {
            int i = 0;
            DGVShowCard.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from QListEmp  where OGID='" + cmbOG.SelectedValue + "'", con);

            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVShowCard.RowTemplate.Height = 20;
                DGVShowCard.Rows.Add(i, dr["EmpID"].ToString(), dr["FullNameKH"].ToString(), dr["FullNameEN"].ToString(), dr["ESex"].ToString(),
                Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
               dr["OGID"].ToString(), dr["OGName"].ToString(), dr["PTID"].ToString(), dr["PTName"].ToString(), dr["Address"].ToString(), dr["PVJ"].ToString());
                DGVShowCard.Sort(DGVShowCard.Columns[6], ListSortDirection.Ascending);

            }
            dr.Close();
            con.Close();
        }
        void ShowPT()
        {
            int i = 0;
            DGVShowCard.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from QListEmp  where OGID='" + cmbOG.SelectedValue + "' and PTID='" + cmbPost.SelectedValue + "'", con);

            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVShowCard.RowTemplate.Height = 20;
                DGVShowCard.Rows.Add(i, dr["EmpID"].ToString(), dr["FullNameKH"].ToString(), dr["FullNameEN"].ToString(), dr["ESex"].ToString(),
                Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
               dr["OGID"].ToString(), dr["OGName"].ToString(), dr["PTID"].ToString(), dr["PTName"].ToString(), dr["Address"].ToString(), dr["PVJ"].ToString());
                DGVShowCard.Sort(DGVShowCard.Columns[6], ListSortDirection.Ascending);

            }
            dr.Close();
            con.Close();
        }

        private void cbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheck.Checked == true)
            {
                cmbPost.Enabled = true;
                LoadPost();
            }
            else
            { 
                cmbPost.Enabled = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta.Columns.Add("EmpID",typeof (string));
            dta.Columns.Add("FullnameKH", typeof(string));
            dta.Columns.Add("FullnameEN", typeof(string));
            dta.Columns.Add("ESex", typeof(string));
            dta.Columns.Add("EDOB", typeof(string));
            dta.Columns.Add("OGName", typeof(string));
            dta.Columns.Add("PTName", typeof(string));
            foreach (DataGridViewRow r in DGVShowCard.Rows)
            {
                dta.Rows.Add(r.Cells[1].Value, r.Cells[2].Value, r.Cells[3].Value, r.Cells[4].Value, r.Cells[5].Value, r.Cells[7].Value, r.Cells[9].Value);
            }
            rListEmp Dos = new rListEmp();
            Dos.SetDataSource(dta);
            ReportEmp VR = new ReportEmp();
            TextObject NID = (TextObject)Dos.ReportDefinition.Sections["Section1"].ReportObjects["rTxtNID"];
            NID.Text = txtNID.Text.ToString();




            VR.crystalReportViewer1.ReportSource = Dos;
            VR.Show();
        }
    }
}
