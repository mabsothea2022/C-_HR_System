using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace HR_System
{
    public partial class FrmSearchem : Form
    {
        OleDbDataReader dr;
        OleDbCommand cmd;
        public FrmSearchem()
        {
            InitializeComponent();
        }
        ConnectionMB op = new ConnectionMB();
        private void FrmSearchem_Load(object sender, EventArgs e)
        {
          
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFNameKH_CheckedChanged(object sender, EventArgs e)
        {

            if (cbFNameKH.Checked)
            {
                txtFNameKH.Enabled = true;
                lbCB.Text = "A";
                cbLNameKH.Checked = false;
                cbCID.Checked = false;
                cbID.Checked = false;
                DGVshowEmp.Rows.Clear();
            }
            else
            {
                txtFNameKH.Enabled = false;
                txtFNameKH.Clear();
            }
        }

        private void cbLNameKH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLNameKH.Checked)
            {
                txtLNameKH.Enabled = true;
                lbCB.Text = "B";
                cbFNameKH.Checked = false;
                cbCID.Checked = false;
                cbID.Checked = false;
                DGVshowEmp.Rows.Clear();
            }
            else
            {
                txtLNameKH.Enabled = false;
                txtLNameKH.Clear();
            }
        }

        private void cbID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbID.Checked)
            {
                txtEmpID.Enabled = true;
                lbCB.Text = "C";
                cbLNameKH.Checked = false;
                cbCID.Checked = false;
                cbFNameKH.Checked = false;
                DGVshowEmp.Rows.Clear();
            }
            else
            {
                txtEmpID.Enabled = false;
                txtEmpID.Clear();
            }
        }

        private void cbCID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCID.Checked)
            {
                txtCID.Enabled = true;
                lbCB.Text = "D";
                cbLNameKH.Checked = false;
                cbID.Checked = false;
                cbFNameKH.Checked = false;
                DGVshowEmp.Rows.Clear();
            }
            else
            {
                txtCID.Enabled = false;
                txtCID.Clear();
            }
        }

        private void TSearchAllE_Click(object sender, EventArgs e)
        {
            ShowData();
            DGVshowEmp.ClearSelection();
        }
        void ShowData()
        {
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVshowEmp.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();

            cmd = new OleDbCommand("Select * from TblEmployee  order by EmpID", con);
            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVshowEmp.RowTemplate.Height = 60;
                DGVshowEmp.Rows.Add(i, dr["ID"].ToString(), (byte[])dr["EImage"], dr["EmpID"].ToString(), dr["CardID"].ToString(), dr["FNameKH"].ToString(), dr["LNameKH"].ToString(), dr["FNameEN"].ToString(), dr["LNameEN"].ToString(), dr["ESex"].ToString()
                , Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
                dr["VL_ID"].ToString(), dr["VL"].ToString(), dr["CM_ID"].ToString(), dr["CM"].ToString(), dr["DS_ID"].ToString(), dr["DS"].ToString(), dr["PV_ID"].ToString(), dr["PV"].ToString()
                ,Convert.ToDateTime(dr["DIssue"]).ToString("dd/MM/yyyy"), dr["NPhone"].ToString(), dr["Email"].ToString());

            }
            dr.Close();
            con.Close();

        }

        private void cbAddressCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddressCurrent.Checked)
            {
                DGVshowEmp.Columns[11].Visible = false;//VlID
                DGVshowEmp.Columns[12].Visible = true;//VL
                DGVshowEmp.Columns[13].Visible = false;//CMID
                DGVshowEmp.Columns[14].Visible = true;//CM
                DGVshowEmp.Columns[15].Visible = false;//DSID
                DGVshowEmp.Columns[16].Visible = true;//DS
                DGVshowEmp.Columns[17].Visible = false;//PVID
                DGVshowEmp.Columns[18].Visible = true;//PV
            }
            else
            {
                DGVshowEmp.Columns[11].Visible = false;//VlID
                DGVshowEmp.Columns[12].Visible = false;//VL
                DGVshowEmp.Columns[13].Visible = false;//CMID
                DGVshowEmp.Columns[14].Visible = false;//CM
                DGVshowEmp.Columns[15].Visible = false;//DSID
                DGVshowEmp.Columns[16].Visible = false;//DS
                DGVshowEmp.Columns[17].Visible = false;//PVID
                DGVshowEmp.Columns[18].Visible = false;//PV
            }
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked == true) 
            {
                DGVshowEmp.Columns[21].Visible = true;//EM
            }
            else
            {
                DGVshowEmp.Columns[21].Visible = false;//EM
            }
        }

        private void TSearchE_Click(object sender, EventArgs e)
        {
            if (lbCB.Text=="A")
            {
                DGVshowEmp.Rows.Clear();
                ShowA();
                DGVshowEmp.ClearSelection();
            }
            if (lbCB.Text == "B")
            {
                DGVshowEmp.Rows.Clear();
               ShowB();
                DGVshowEmp.ClearSelection();
            }
            if (lbCB.Text == "C")
            {
                DGVshowEmp.Rows.Clear();
                // ShowC();
                DGVshowEmp.ClearSelection();
            }
            if (lbCB.Text == "D")
            {
                DGVshowEmp.Rows.Clear();
                // ShowD();
                DGVshowEmp.ClearSelection();
            }
        }
        void ShowA()
        {
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVshowEmp.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();

            cmd = new OleDbCommand("Select * from TblEmployee  where FNameKH like'%" + txtFNameKH.Text + "%'", con);
            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVshowEmp.RowTemplate.Height = 60;
                DGVshowEmp.Rows.Add(i, dr["ID"].ToString(), (byte[])dr["EImage"], dr["EmpID"].ToString(), dr["CardID"].ToString(), dr["FNameKH"].ToString(), dr["LNameKH"].ToString(), dr["FNameEN"].ToString(), dr["LNameEN"].ToString(), dr["ESex"].ToString()
                , Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
                dr["VL_ID"].ToString(), dr["VL"].ToString(), dr["CM_ID"].ToString(), dr["CM"].ToString(), dr["DS_ID"].ToString(), dr["DS"].ToString(), dr["PV_ID"].ToString(), dr["PV"].ToString()
                , Convert.ToDateTime(dr["DIssue"]).ToString("dd/MM/yyyy"), dr["NPhone"].ToString(), dr["Email"].ToString());
            }
            dr.Close();
            con.Close();
        }
        void ShowB()
        {
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVshowEmp.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from TblEmployee  where LNameKH like'%" + txtLNameKH.Text + "%'", con);

            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVshowEmp.RowTemplate.Height = 60;
                DGVshowEmp.Rows.Add(i, dr["ID"].ToString(), (byte[])dr["EImage"], dr["EmpID"].ToString(), dr["CardID"].ToString(), dr["FNameKH"].ToString(), dr["LNameKH"].ToString(), dr["FNameEN"].ToString(), dr["LNameEN"].ToString(), dr["ESex"].ToString()
                , Convert.ToDateTime(dr["EDOB"]).ToString("dd/MM/yyyy"),
                dr["VL_ID"].ToString(), dr["VL"].ToString(), dr["CM_ID"].ToString(), dr["CM"].ToString(), dr["DS_ID"].ToString(), dr["DS"].ToString(), dr["PV_ID"].ToString(), dr["PV"].ToString()
                , Convert.ToDateTime(dr["DIssue"]).ToString("dd/MM/yyyy"), dr["NPhone"].ToString(), dr["Email"].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void txtLNameKH_TextChanged(object sender, EventArgs e)
        {
            ShowB();
        }

        private void txtFNameKH_TextChanged(object sender, EventArgs e)
        {
            ShowA();
        }

        private void DGVshowEmp_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void DGVshowEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVshowEmp.Columns[e.ColumnIndex].Name;
            if (colname =="view")
            {
                FrmEmployee fr = new FrmEmployee();
                fr.Show();
                FrmEmployee.E.lblInsert.Text = "Edit";
                FrmEmployee.E.AddTab();

                FrmEmployee.E.lblEmpID.Text = DGVshowEmp.CurrentRow.Cells[1].Value.ToString();
                byte[] photo = (byte[])DGVshowEmp.CurrentRow.Cells[2].Value;
                MemoryStream ms =new MemoryStream(photo);
                FrmEmployee.E.picName.Image=Image.FromStream(ms);

                FrmEmployee.E.txtEmpID.Text = DGVshowEmp.CurrentRow.Cells[3].Value.ToString();
                FrmEmployee.E.txtCardID.Text = DGVshowEmp.CurrentRow.Cells[4].Value.ToString();
                FrmEmployee.E.txtFNameKH.Text = DGVshowEmp.CurrentRow.Cells[5].Value.ToString();
                FrmEmployee.E.txtLNameKH.Text = DGVshowEmp.CurrentRow.Cells[6].Value.ToString();

                FrmEmployee.E.txtFNamEN.Text = DGVshowEmp.CurrentRow.Cells[7].Value.ToString();
                FrmEmployee.E.txtLNameEN.Text = DGVshowEmp.CurrentRow.Cells[8].Value.ToString();
                FrmEmployee.E.cmbSex.Text = DGVshowEmp.CurrentRow.Cells[9].Value.ToString();
                FrmEmployee.E.DtpDOB.Text = DGVshowEmp.CurrentRow.Cells[10].Value.ToString();

                //អាសយដ្ឋាន
                FrmEmployee.E.cmbProvince.SelectedValue = DGVshowEmp.CurrentRow.Cells[17].Value.ToString();
                FrmEmployee.E.cmbProvince.Text = DGVshowEmp.CurrentRow.Cells[18].Value.ToString();
                FrmEmployee.E.cmbDistrict.SelectedValue = DGVshowEmp.CurrentRow.Cells[15].Value.ToString();
                FrmEmployee.E.cmbDistrict.Text = DGVshowEmp.CurrentRow.Cells[16].Value.ToString();
                FrmEmployee.E.cmbCommune.SelectedValue = DGVshowEmp.CurrentRow.Cells[13].Value.ToString();
                FrmEmployee.E.cmbCommune.Text = DGVshowEmp.CurrentRow.Cells[14].Value.ToString();
                FrmEmployee.E.cmbVillage.SelectedValue = DGVshowEmp.CurrentRow.Cells[11].Value.ToString();
                FrmEmployee.E.cmbVillage.Text = DGVshowEmp.CurrentRow.Cells[12].Value.ToString();

                FrmEmployee.E.DtpStartJob.Text = DGVshowEmp.CurrentRow.Cells[19].Value.ToString();
                FrmEmployee.E.txtPhone.Text = DGVshowEmp.CurrentRow.Cells[20].Value.ToString();
                FrmEmployee.E.txtEmail.Text = DGVshowEmp.CurrentRow.Cells[21].Value.ToString();




            }
        }
    }
}
