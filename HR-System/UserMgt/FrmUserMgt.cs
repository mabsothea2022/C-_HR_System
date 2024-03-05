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
    public partial class FrmUserMgt : Form
    {
        public FrmUserMgt()
        {
            InitializeComponent();
        }
        ConnectionMB op = new ConnectionMB();   
        private void FrmUserMgt_Load(object sender, EventArgs e)
        {
            DGVShowData.AllowUserToAddRows = false;
        }
        void showdata()
        {
            OleDbCommand cmd;
            OleDbDataReader dr;
            //Call Data
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVShowData.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from QUserMgt order by UserID", con);
           
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                
                DGVShowData.RowTemplate.Height = 60;
                DGVShowData.Rows.Add(i, dr["UserID"].ToString(), dr["UserName"].ToString(), (byte[])dr["EImage"],  dr["FullNameKh"].ToString(), dr["Sex"].ToString(), dr["Phone"].ToString(), dr["PW"].ToString(), dr["RePW"].ToString(), dr["PV"].ToString());
                //, Convert.ToDateTime(dr["EDateStart"]).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr["EDateEnd"]).ToString("dd/MM/yyyy"), dr["OGName"].ToString(), dr["ENote"].ToString(), dr["EStatus"].ToString());
                //DGVSkill.ColumnHeadersHeight = 60;

            }
            dr.Close();
            con.Close();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void DGVShowData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            DGVShowData.Rows.Clear();
        }
    }
}
