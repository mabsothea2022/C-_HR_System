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
    public partial class FrmSkill : Form
    {
        OleDbDataReader dr;
        public static FrmSkill S;
        public FrmSkill()
        {
            InitializeComponent();
            S = this;
        }
        ConnectionMB op = new ConnectionMB();   
        private void FrmSkill_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            OleDbCommand cmd;
            //Call Data
            //FrmReportFullOption.instance.dataGridView.Rows.Clear();
            int i = 0;
            DGVSkill.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            cmd = new OleDbCommand("Select * from tblSkill order by Skill_ID", con);
            // cmd = new OleDbCommand("Select * from TEmpJob  where EID='" + txtEID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVSkill.RowTemplate.Height = 40;
                DGVSkill.Rows.Add(i, dr["Skill_ID"].ToString(), dr["Skill_Name"].ToString());


            }
            dr.Close();
            con.Close();

        }

        private void DGVSkill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEmployee.E.txtSkillID.Text = DGVSkill.CurrentRow.Cells[1].Value.ToString();
            FrmEmployee.E.txtSkillName.Text = DGVSkill.CurrentRow.Cells[2].Value.ToString();
            Hide();
        }
    }
}
