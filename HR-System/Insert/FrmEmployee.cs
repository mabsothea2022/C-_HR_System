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
    public partial class FrmEmployee : Form
    {
        OleDbDataReader dr;
        public static FrmEmployee E;
        public FrmEmployee()
        {
            InitializeComponent();
            E = this;
        }
        ConnectionMB op = new ConnectionMB();
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            TabEmp.TabPages.Remove(tabPage2);
            TabEmp.TabPages.Remove(tabPage3);
            TabEmp.TabPages.Remove(tabPage4);
            //GetEmpID();
            // txtEmpID.Enabled = false;
            loadProvince();


            //------------
            LoadSL();
            LoadCV();
            LoadSchool();
            loadCountryA();
            LoadCT();
            //--------
            LoadPost();
            LoadOG();
            //----------
            LoadDoc();
        }
        void LoadDoc()
        {
            DataTable tb = new DataTable("tblDoc");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,DocName from tblDoc", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbDoc.DisplayMember = "DocName";
            cmbDoc.ValueMember = "id";
            cmbDoc.DataSource = tb;
            cmbDoc.Text = "-ជ្រើសរើស ឬ បញ្ចូលបន្ថែម-";
            con.Close();
        }
        void LoadPost()
        {
            DataTable tb = new DataTable("tblPostJob");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,PostJobName from tblPostJob", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbPostion.DisplayMember = "PostJobName";
            cmbPostion.ValueMember = "id";
            cmbPostion.DataSource = tb;
            cmbPostion.Text = "-ជ្រើសរើស ឬ បញ្ចូលបន្ថែម-";
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
            cmbOG.Text = "-ជ្រើសរើស ឬ បញ្ចូលបន្ថែម-";
            con.Close();
        }
        void LoadCT()
        {
            DataTable tb = new DataTable("tblCT");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,CTName from tblCT", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbProviceCity.DisplayMember = "CTName";
            cmbProviceCity.ValueMember = "id";
            cmbProviceCity.DataSource = tb;
            cmbProviceCity.Text = "-ជ្រើសរើស ឬ បញ្ចូលបន្ថែម-";
            con.Close();
        }
        void loadCountryA()
        {
            DataTable tb = new DataTable("tblCountryPA");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,CountriesPA from tblCountryPA", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbCountryAdd.DisplayMember = "CountriesPA";
            cmbCountryAdd.ValueMember = "id";
            cmbCountryAdd.DataSource = tb;
            cmbCountryAdd.Text = "-ជ្រើសរើស ឬ បញ្ចូលបន្ថែម-";
            con.Close();
        }
        void loadProvince()
        {
            DataTable tb = new DataTable("tblprovince");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select ProvinceID ,ProvinceNameKH from tblprovince", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbProvince.DisplayMember = "ProvinceNameKH";
            cmbProvince.ValueMember = "ProvinceID";
            cmbProvince.DataSource = tb;
            cmbProvince.Text = " ";
            con.Close();
        }
        void GetEmpID()
        {
            try
            {
                OleDbConnection con = op.GetCon();
                OleDbDataAdapter query1 = new OleDbDataAdapter("select EmpID From tblEmployee order by EmpID Desc", con);
                DataSet Bumrah = new DataSet();
                query1.Fill(Bumrah);
                if (Bumrah.Tables[0].Rows.Count > 0)
                {
                    txtEmpIDx.Text = Bumrah.Tables[0].Rows[0]["EmpID"].ToString();

                }
                else
                {
                    txtEmpIDx.Text = "C02300001000";
                }
                if (!String.IsNullOrEmpty(txtEmpIDx.Text))

                {
                    txtEmpIDx.SelectionStart = 9;
                    txtEmpIDx.SelectionLength = 9;
                    lblEmpIDx.Text = txtEmpIDx.SelectedText;
                }
                if (!String.IsNullOrEmpty(lblEmpIDx.Text))
                {
                    int ID = int.Parse(lblEmpIDx.Text.ToString()) + 1;
                    txtEmpID.Text = ID.ToString("C02300001000");
                }

            }
            catch (Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }
       public void AddTab()
        {
            TabEmp.TabPages.Add(tabPage2);
            TabEmp.TabPages.Add(tabPage3);
            TabEmp.TabPages.Add(tabPage4);
        }
        void LoadSchool()//គ្រឹះស្ថានអប់រំ
        {
            DataTable tb = new DataTable("tblSchool");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select id ,SchoolName from tblSchool", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbSchool.DisplayMember = "SchoolName";
            cmbSchool.ValueMember = "id";
            cmbSchool.DataSource = tb;
            cmbSchool.Text = "-ជ្រើសរើស ឬ បញ្ចូលបន្ថែម-";
            con.Close();
        }
        void LoadSL()//កម្រិតវប្បធម៌
        {
            DataTable tb = new DataTable("tblStudyLevel");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select SL_ID ,StudyLevel from tblStudyLevel", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbSL.DisplayMember = "StudyLevel";
            cmbSL.ValueMember = "SL_ID";
            cmbSL.DataSource = tb;
            cmbSL.Text = " ";
            con.Close();
        }
        void LoadCV()//សញ្ញាបត្រទទួលបាន
        {
            DataTable tb = new DataTable("tblCertivicate");
            OleDbConnection con = op.GetCon();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select CV_ID ,Certivicate from tblCertivicate", con);
            dr = cmd.ExecuteReader();
            tb.Load(dr);
            cmbCV.DisplayMember = "Certivicate";
            cmbCV.ValueMember = "CV_ID";
            cmbCV.DataSource = tb;
            cmbCV.Text = " ";
            con.Close();
        }


        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File |*.jpg;*.bmp;*gif;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(dlg.FileName);
                    picName.Image = image;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Choose Image", "Error Image File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvince.SelectedValue.ToString() != null)
            {
                //DGVFull.Rows.Clear();
                //lblAmount.Text = "0";
                OleDbConnection con = op.GetCon();
                string query = "select * from tblDistrict where ProvinceID =@ProvinceID";
                OleDbCommand cmd = new OleDbCommand(query, op.GetCon());
                con.Open();
                cmd.Parameters.AddWithValue("@ProvinceID", cmbProvince.SelectedValue.ToString());
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cmbDistrict.DisplayMember = "DistrictNameKH";
                cmbDistrict.ValueMember = "DistrictID";
                cmbDistrict.DataSource = dt;
                cmbDistrict.Text = " ";
                con.Close();
            }
        }

        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDistrict.SelectedValue.ToString() != null)
            {
                //DGVFull.Rows.Clear();
                //lblAmount.Text = "0";
                OleDbConnection con = op.GetCon();
                string query = "select * from tblcommune where DistrictID =@DistrictID";
                OleDbCommand cmd = new OleDbCommand(query, op.GetCon());
                con.Open();
                cmd.Parameters.AddWithValue("@DistrictID", cmbDistrict.SelectedValue.ToString());
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cmbCommune.DisplayMember = "CommuneNameKH";
                cmbCommune.ValueMember = "CommuneID";
                cmbCommune.DataSource = dt;
                cmbCommune.Text = " ";
                con.Close();
            }
        }

        private void cmbCommune_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCommune.SelectedValue.ToString() != null)
            {
                //DGVFull.Rows.Clear();
                //lblAmount.Text = "0";
                OleDbConnection con = op.GetCon();
                string query = "select * from tblvillage where CommuneID =@CommuneID";
                OleDbCommand cmd = new OleDbCommand(query, op.GetCon());
                con.Open();
                cmd.Parameters.AddWithValue("@CommuneID", cmbCommune.SelectedValue.ToString());
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cmbVillage.DisplayMember = "villagenamekh";
                cmbVillage.ValueMember = "villageID";
                cmbVillage.DataSource = dt;
                cmbVillage.Text = " ";
                con.Close();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblInsert.Text=="0")//Insert
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    Insert0();
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                    Insert1();
                    ShowDataStudy();
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                    Insert2();
                    ShowDataJob();
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    Insert3();
                    ShowDataDoc();
                }

            }
            else//Edit  
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    //++++++++++++++++
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                    Insert1();
                    ShowDataStudy();
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                    Insert2();
                    ShowDataJob();
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    Insert3();
                    ShowDataDoc();
                }

            }
        }

        void Insert0()//ព័ត៌មាន
        {
            try
            {
                //Check If One Or More Fields Are Empty
                if (txtCardID.Text == String.Empty || txtFNameKH.Text == String.Empty)
                //    //|| txtPhone.Text == string.Empty)
                {
                    MessageBox.Show("One Or More Empty Field ............");
                    //MsNoBlank fr = new MsNoBlank();
                    //fr.ShowDialog();

                }
                else
                {
                   
                        OleDbConnection con = op.GetCon();
                        //.........................
                        MemoryStream ms = new MemoryStream();
                        picName.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] photo = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo, 0, photo.Length);

                        //....................................
                        OleDbCommand cmd = new OleDbCommand("Insert into TblEmployee(EImage,EmpID,CardID,FNameKH,LNameKH,FNameEN,LNameEN,ESex,EDOB,PV_ID,PV,DS_ID,DS,CM_ID,CM,VL_ID,VL,Dissue,NPhone,EMail) Values(@photo,'" + txtEmpID.Text + "','" + txtCardID.Text + "','" + txtFNameKH.Text + "','" + txtLNameKH.Text + "','" + txtFNamEN.Text + "','" + txtLNameEN.Text + "','" + cmbSex.Text + "'" +
                    ",'" + DtpDOB.Text + "','" + cmbProvince.SelectedValue + "','" + cmbProvince.Text + "','" + cmbDistrict.SelectedValue + "','" + cmbDistrict.Text + "','" + cmbCommune.SelectedValue + "','" + cmbCommune.Text + "','" + cmbVillage.SelectedValue + "','" + cmbVillage.Text + "'" +
                        ",'" + DtpStartJob.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "')", con);

                        cmd.Parameters.AddWithValue("@photo", photo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Saved Successfull!");
                    //MsAdd fr = new MsAdd();
                    //fr.Show();
                    //Clear0();
                    AddTab();


                        //.....................................

                 }
                

            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }
        void Insert1()//សិក្សា
        {
            try
            {
                //Check If One Or More Fields Are Empty
                if (txtEmpID.Text == String.Empty)
                //    //|| txtPhone.Text == string.Empty)
                {
                     MessageBox.Show("One Or More Empty Field ............");
                    //MsNoBlank fr = new MsNoBlank();
                    //fr.ShowDialog();

                }
                else
                {

                    OleDbConnection con = op.GetCon();
                    string query1 = "Insert into TblInfoEmpStudy (EmpID,DS,DE,SLID,SLName,CID,CName,SKID,SKName,SCName,COverea,CTY,IDNote,PV) Values(?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
                    OleDbCommand cmd = new OleDbCommand(query1, con);

                    cmd.Parameters.AddWithValue("@EmpID", OleDbType.VarChar).Value = txtEmpID.Text;
                    cmd.Parameters.AddWithValue("@DS", OleDbType.VarChar).Value = dtpStudyIssue.Text;
                    cmd.Parameters.AddWithValue("@DE", OleDbType.VarChar).Value = dtpStudyEnd.Text;
                    cmd.Parameters.AddWithValue("@SLID", OleDbType.VarChar).Value = cmbSL.SelectedValue;
                    cmd.Parameters.AddWithValue("@SLName", OleDbType.VarChar).Value = cmbSL.Text;
                    cmd.Parameters.AddWithValue("@CID", OleDbType.VarChar).Value = cmbCV.SelectedValue;
                    cmd.Parameters.AddWithValue("@CName", OleDbType.VarChar).Value = cmbCV.Text;
                    cmd.Parameters.AddWithValue("@SKID", OleDbType.VarChar).Value = txtSkillID.Text;
                    cmd.Parameters.AddWithValue("@SKName", OleDbType.VarChar).Value = txtSkillName.Text;
                    cmd.Parameters.AddWithValue("@SCName", OleDbType.VarChar).Value = cmbSchool.Text;
                    cmd.Parameters.AddWithValue("@COverea", OleDbType.VarChar).Value = cmbCountryAdd.Text;
                    cmd.Parameters.AddWithValue("@CTY", OleDbType.VarChar).Value = cmbProviceCity.Text;
                    cmd.Parameters.AddWithValue("@IDNote", OleDbType.VarChar).Value = txtNoteStudy.Text;
                    cmd.Parameters.AddWithValue("@PV", OleDbType.VarChar).Value = lblPro.Text;

                    //Opening Access Database Connection
                    con.Open();
                    int insertDataToAccessDatabase = cmd.ExecuteNonQuery();
                    con.Close();
                    //If data Has been inserted to the database output the following message
                    if (insertDataToAccessDatabase > 0)
                    {
                        MessageBox.Show("Data Inserted Susccessfully.........");
                        //MsAdd fr = new MsAdd();
                        //fr.Show();
                    }
                    //clear();
                    //ShowData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Insert2()//ការងារ
        {
            try
            {
                //Check If One Or More Fields Are Empty
                if (txtEmpID.Text == String.Empty)
                //    //|| txtPhone.Text == string.Empty)
                {
                    MessageBox.Show("One Or More Empty Field ............");
                    //MsNoBlank fr = new MsNoBlank();
                    //fr.ShowDialog();

                }
                else
                {

                    OleDbConnection con = op.GetCon();
                    string query1 = "Insert into TblInfoEmpJob (EmpID,DSJ,DEJ,OGID,OGName,PTID,PTName,NoteJ,PVJ) Values(?,?,?,?,?,?,?,?,?)";
                    OleDbCommand cmd = new OleDbCommand(query1, con);

                    cmd.Parameters.AddWithValue("@EmpID", OleDbType.VarChar).Value = txtEmpID.Text;
                    cmd.Parameters.AddWithValue("@DSJ", OleDbType.VarChar).Value = dtpStudyIssue.Text;
                    cmd.Parameters.AddWithValue("@DEJ", OleDbType.VarChar).Value = dtpStudyEnd.Text;
                    cmd.Parameters.AddWithValue("@OGID", OleDbType.VarChar).Value = cmbOG.SelectedValue;
                    cmd.Parameters.AddWithValue("@OGName", OleDbType.VarChar).Value = cmbOG.Text;
                    cmd.Parameters.AddWithValue("@PTID", OleDbType.VarChar).Value = cmbPostion.SelectedValue;
                    cmd.Parameters.AddWithValue("@PTName", OleDbType.VarChar).Value = cmbPostion.Text;
                    cmd.Parameters.AddWithValue("@NoteJ", OleDbType.VarChar).Value = txtNoteJob.Text;
                    cmd.Parameters.AddWithValue("@PVJ", OleDbType.VarChar).Value = lblJobActive.Text;
                   
                    //Opening Access Database Connection
                    con.Open();
                    int insertDataToAccessDatabase = cmd.ExecuteNonQuery();
                    con.Close();
                    //If data Has been inserted to the database output the following message
                    if (insertDataToAccessDatabase > 0)
                    {
                        MessageBox.Show("Data Inserted Susccessfully.........");
                        //MsAdd fr = new MsAdd();
                        //fr.Show();
                    }
                    //clear();
                    //ShowData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Insert3()//ឯកសារយោង
        {

            try
            {
                //Check If One Or More Fields Are Empty
                if (txtEmpID.Text == String.Empty)
                //    //|| txtPhone.Text == string.Empty)
                {
                    MessageBox.Show("One Or More Empty Field ............");
                    //MsNoBlank fr = new MsNoBlank();
                    //fr.ShowDialog();

                }
                else
                {

                    OleDbConnection con = op.GetCon();
                    //.........................
                    MemoryStream ms = new MemoryStream();
                    PImageDoc.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] photo = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo, 0, photo.Length);

                    //....................................
                    OleDbCommand cmd = new OleDbCommand("Insert into tblDocFile(EmpID,DocLocation,DocName,DocTitle,NPage,PDFFile) Values('" + txtEmpID.Text + "','" + txtDocLocation.Text + "','" + cmbDoc.Text + "','" + txtDocTitle.Text + "','" + txtNPage.Text + "',@photo)", con);

                    cmd.Parameters.AddWithValue("@photo", photo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                     MessageBox.Show("Saved Successfull!");
                    //MsAdd fr = new MsAdd();
                    //fr.Show();

                    PImageDoc.Image = null;
                    //.....................................

                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }
        private void btnShowSkill_Click(object sender, EventArgs e)
        {
            FrmSkill skill = new FrmSkill();
            skill.ShowDialog();
        }

        private void txtSkillID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //DGVFull.Rows.Clear();
                //lblAmount.Text = "0";
                OleDbConnection con = op.GetCon();
                string query = "select * from tblSkill where Skill_ID ='" + txtSkillID.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, op.GetCon());
                DataTable dt = new DataTable();
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtSkillName.Text = dr["Skill_Name"].ToString();

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.GetCon();

            try
            {

                if (cmbSchool.Text == "")
                {
                    MessageBox.Show("Please Enter Faculty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                string query1 = "Insert into tblSchool (SchoolName) Values(?)";
                OleDbCommand cmd = new OleDbCommand(query1, con);

                cmd.Parameters.AddWithValue("@SchoolName", OleDbType.VarChar).Value = cmbSchool.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Has Been Successfully!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchool();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReduceSchool_Click(object sender, EventArgs e)
        {
            OleDbConnection con = op.GetCon();

            try
            {

                if (cmbSchool.Text == "")
                {
                    MessageBox.Show("Please Enter Category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                string query1 = "delete from tblSchool where id=@id";
                OleDbCommand cmd = new OleDbCommand(query1, con);

                cmd.Parameters.AddWithValue("@id", OleDbType.VarChar).Value = cmbSchool.SelectedValue;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Has Been Successfully!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchool();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActive.Checked)
            {
                lblPro.Text= "Active";
            }
        }

        private void rbDeactive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeactive.Checked)
            {
                lblPro.Text = "Disable";
            }
        }

        private void rbActiveJob_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActiveJob.Checked)
            {
                lblJobActive.Text = "Active";
            }
        }

        private void rbDeactiveJob_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeactiveJob.Checked)
            {
                lblJobActive.Text = "Disable";
            }
        }

        private void btnLoadPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string mypicture = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Choose Image";
                ofd.Filter = "Picture(*.jpg;*.png;*.gif;*.pdf)|*.jpg;*.png;*.gif;*.pdf";
                ofd.AddExtension = true;
                ofd.FilterIndex = 1;
                ofd.Multiselect = false;
                ofd.ValidateNames = true;
                ofd.InitialDirectory = mypicture;
                ofd.RestoreDirectory = true;
                DialogResult ChooseImageDialog = ofd.ShowDialog();
                if (ChooseImageDialog == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    PImageDoc.Image = Image.FromFile(ofd.FileName);
                    txtDocLocation.Text = ofd.FileName.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Clear0()
        {
            txtEmpID.Text = "";
            txtCardID.Text = "";
            txtFNameKH.Text = "";
            txtLNameKH.Text = "";
            txtFNamEN.Text = "";
            txtLNameEN.Text = "";
            cmbSex.Text="";

            DtpDOB.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            DtpStartJob.Text = "";

            //cmbProvince.SelectedIndex = -1;
            //cmbVillage.SelectedIndex = -1;
            //cmbCommune.SelectedIndex = -1;
            //cmbDistrict.SelectedIndex = -1;
            cmbProvince.Text = "";
            cmbVillage.Text = "";
            cmbCommune.Text = "";
            cmbDistrict.Text = "";
            picName.Image= null;
            txtEmpID.Focus();
            lblEmpID.Text = "";

        }
        void Clear1()
        {
            dtpStudyIssue.Text = string.Empty;
            dtpStudyEnd.Text = string.Empty;
            cmbSL.Text = "";
            cmbCV.Text = "";
            txtSkillID.Text= string.Empty;
            txtSkillName.Text= string.Empty;
            cmbSchool.Text = string.Empty;
            cmbCountryAdd.Text = string.Empty;
            cmbProviceCity.Text = string.Empty;
            rbActive.Checked = true;
            txtNoteStudy.Text = string.Empty;
        }

        private void TabEmp_Click(object sender, EventArgs e)
        {
            if (lblInsert.Text == "0")//Insert
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                   
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                   
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    
                }

            }
            else//Edit  
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                   
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                    ShowDataStudy();
                   
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                    ShowDataJob();
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    ShowDataDoc();
                }

            }


        }
        void ShowDataStudy()
        {
            OleDbCommand cmd;
          
            int i = 0;
            DGVStudy.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
           
            cmd = new OleDbCommand("Select * from TblInfoEmpStudy  where EmpID='" + txtEmpID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVStudy.RowTemplate.Height = 40;
                DGVStudy.Rows.Add(i, dr["ID"].ToString(), dr["EmpID"].ToString(), Convert.ToDateTime(dr["DS"]).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr["DE"]).ToString("dd/MM/yyyy"), dr["SLID"].ToString(), dr["SLName"].ToString(), dr["CID"].ToString(), dr["CName"].ToString(), dr["SKID"].ToString(), dr["SKName"].ToString(), dr["SCName"].ToString(), dr["COverea"].ToString(), dr["CTY"].ToString()
                         , dr["IDNote"].ToString(), dr["PV"].ToString());
                //Convert.ToDateTime(dr["DIssue"]).ToString("dd/MM/yyyy")
            }
            dr.Close();
            con.Close();


        }
        void ShowDataJob()
        {
            OleDbCommand cmd;
          
            int i = 0;
            DGVShowJob.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
            
            cmd = new OleDbCommand("Select * from TblInfoEmpJob  where EmpID='" + txtEmpID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVShowJob.RowTemplate.Height = 40;
                DGVShowJob.Rows.Add(i, dr["ID"].ToString(), dr["EmpID"].ToString(), Convert.ToDateTime(dr["DSJ"]).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr["DEJ"]).ToString("dd/MM/yyyy"), dr["OGID"].ToString(),dr["OGName"].ToString(), dr["PTID"].ToString(), dr["PTName"].ToString(), dr["NoteJ"].ToString(), dr["PVJ"].ToString());

            }
            dr.Close();
            con.Close();
        }
        void ShowDataDoc()//DocFile
        {
            OleDbCommand cmd;
           
            int i = 0;
            DGVFile.Rows.Clear();
            OleDbConnection con = op.GetCon();
            con.Open();
          
            cmd = new OleDbCommand("Select * from tblDocFile  where EmpID='" + txtEmpID.Text + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                DGVFile.RowTemplate.Height = 40;
                DGVFile.Rows.Add(i, dr["ID"].ToString(), dr["EmpID"].ToString(), dr["DocLocation"].ToString(), dr["DocName"].ToString(), dr["DocTitle"].ToString(), dr["NPage"].ToString(), (byte[])dr["PDFFile"]);
                // (byte[])dr["EImage"]
            }
            dr.Close();
            con.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (lblInsert.Text == "0")//Insert
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    Clear0();
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                    Clear1();
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                   // Clear3();
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    //Clear3();
                }

            }
            else//Edit  
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    Clear0();
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                    Clear1();
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                    //Clear2();
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    //Clear3();
                }

            }
        }

        private void DGVStudy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVStudy.Columns[e.ColumnIndex].Name;
            if (colname =="EditStudy")
            {
                lblIDStudy.Text= DGVStudy.CurrentRow.Cells[1].Value.ToString();
                dtpStudyIssue.Text = DGVStudy.CurrentRow.Cells[3].Value.ToString();
                dtpStudyEnd.Text = DGVStudy.CurrentRow.Cells[4].Value.ToString();
                cmbSL.SelectedValue = DGVStudy.CurrentRow.Cells[5].Value.ToString();//SID
                cmbSL.Text = DGVStudy.CurrentRow.Cells[6].Value.ToString();
                cmbCV.SelectedValue = DGVStudy.CurrentRow.Cells[7].Value.ToString();//CID
                cmbCV.Text = DGVStudy.CurrentRow.Cells[8].Value.ToString();
                txtSkillID.Text = DGVStudy.CurrentRow.Cells[9].Value.ToString();
                txtSkillName.Text = DGVStudy.CurrentRow.Cells[10].Value.ToString();
                cmbSchool.Text = DGVStudy.CurrentRow.Cells[11].Value.ToString();
                cmbCountryAdd.Text = DGVStudy.CurrentRow.Cells[12].Value.ToString();
                cmbProviceCity.Text = DGVStudy.CurrentRow.Cells[13].Value.ToString();
                txtNoteStudy.Text = DGVStudy.CurrentRow.Cells[14].Value.ToString();

                if (DGVStudy.CurrentRow.Cells[15].Value.ToString()== "Active")
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbDeactive.Checked = true;
                }
                
               


            }


        }

        private void DGVShowJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVShowJob.Columns[e.ColumnIndex].Name;
            if (colname == "EditJob")
            {
                lblIDJob.Text = DGVShowJob.CurrentRow.Cells[1].Value.ToString();
                dtpJobIssue.Text = DGVShowJob.CurrentRow.Cells[3].Value.ToString();
                dtpJobEnd.Text = DGVShowJob.CurrentRow.Cells[4].Value.ToString();
                cmbOG.SelectedValue = DGVShowJob.CurrentRow.Cells[5].Value.ToString();
                cmbOG.Text = DGVShowJob.CurrentRow.Cells[6].Value.ToString();
                cmbPostion.SelectedValue = DGVShowJob.CurrentRow.Cells[7].Value.ToString();
                cmbPostion.Text = DGVShowJob.CurrentRow.Cells[8].Value.ToString();
                txtNoteJob.Text= DGVShowJob.CurrentRow.Cells[9].Value.ToString();


                if (DGVShowJob.CurrentRow.Cells[10].Value.ToString() == "Active")
                {
                    rbActiveJob.Checked = true;
                }
                else
                {
                    rbDeactiveJob.Checked = true;
                }




            }
        }

        private void DGVFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DGVFile.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                lblDoc.Text = DGVFile.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtDocLocation.Text = DGVFile.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbDoc.Text = DGVFile.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDocTitle.Text = DGVFile.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNPage.Text = DGVFile.Rows[e.RowIndex].Cells[6].Value.ToString();
                byte[] photo = (byte[])DGVFile.CurrentRow.Cells[7].Value;
                MemoryStream ms = new MemoryStream(photo);
                PImageDoc.Image = Image.FromStream(ms);
            }

            else
            if (colname == "Delete")
            {
                if (MessageBox.Show("Product Delete Successfully", "Do you want to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        string query = "Delete From tblDocFile where ID=" + DGVFile.Rows[e.RowIndex].Cells[1].Value.ToString() + "";
                        op.DeleteData(query);
                        ShowDataDoc();


                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Data not deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            if (colname == "View")
            {
               ShowFile fr = new ShowFile();
                fr.Show();

                //---------
                byte[] photo = (byte[])DGVFile.CurrentRow.Cells[7].Value;
                MemoryStream ms = new MemoryStream(photo);
                ShowFile.S.picFile.Image= Image.FromStream(ms);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblInsert.Text == "0")//Insert
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                   
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                    
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                   
                }

            }
            else//Edit  
            {
                if (TabEmp.SelectedIndex == 0)//ព័ត៌មានផ្ទាល់
                {
                    Edit0();
                }
                if (TabEmp.SelectedIndex == 1)//សិក្សា
                {
                    Edit1();
                }
                if (TabEmp.SelectedIndex == 2)//ការងារ
                {
                   // Edit2();
                }
                if (TabEmp.SelectedIndex == 3)//ឯកសារយោង
                {
                    Edit3();
                }

            }
        }
        void Edit0()
        {
            if (MessageBox.Show("Data Update Successfully", "Do you want to Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection con = op.GetCon();
                try
                {

                    //.........................
                    MemoryStream ms = new MemoryStream();
                    picName.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] photo = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo, 0, photo.Length);

                    //....................................
                    OleDbCommand cmd = new OleDbCommand("Update TblEmployee set EImage=@photo, EmpID='" + txtEmpID.Text + "',CardID='" + txtCardID.Text + "',FNameKH='" + txtFNameKH.Text + "',LNameKH='" + txtLNameKH.Text + "',FNameEN='" + txtFNamEN.Text + "',LNameEN='" + txtLNameEN.Text + "',ESex='" + cmbSex.Text + "',EDOB='" + DtpDOB.Text + "'," +
                        "PV_ID='" + cmbProvince.SelectedValue + "',PV='" + cmbProvince.Text + "',DS_ID='" + cmbDistrict.SelectedValue + "',DS='" + cmbDistrict.Text + "',CM_ID='" + cmbCommune.SelectedValue + "',CM='" + cmbCommune.Text + "',VL_ID='" + cmbVillage.SelectedValue + "',VL='" + cmbVillage.Text + "',DIssue='" + DtpStartJob.Text + "'," +
                        "NPhone='" + txtPhone.Text + "',EMail='" + txtEmail.Text + "' Where ID=" + lblEmpID.Text + "", con);
                    //,@photo)", con);
                    cmd.Parameters.AddWithValue("@photo", photo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successfull!");
                    //MsUpdate fr = new MsUpdate();
                    //fr.Show();

                   // Clear0();
                    lblEmpID.Text = "";
                    picName.Image = null;
                    ////.....................................
                   

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
        void Edit1()//Study
        {
            if (MessageBox.Show("Data Update Successfully", "Do you want to Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection con = op.GetCon();
                try
                {

                    //....................................
                    OleDbCommand cmd = new OleDbCommand("Update TblInfoEmpStudy set EmpID='" + txtEmpID.Text + "',DS='" + dtpStudyIssue.Text + "',DE='" + dtpStudyEnd.Text + "',SLID='" + cmbSL.SelectedValue + "',SLName='" + cmbSL.Text + "',CID='" + cmbCV.SelectedValue + "',CName='" + cmbCV.Text + "',SKID='" + txtSkillID.Text + "',SKName='" + txtSkillName.Text + "',SCName='" + cmbSchool.Text + "',COverea='" + cmbCountryAdd.Text + "'" +
                        ",CTY='" + cmbProviceCity.Text + "',IDNote='" + txtNoteStudy.Text + "',PV='" + lblPro.Text + "' Where ID=" + lblIDStudy.Text + "", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successfull!");
                    //MsUpdate fr = new MsUpdate();
                    //fr.Show();
                    lblIDStudy.Text = "";
                    ShowDataStudy();
                    Clear1();

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
        void Edit3()//Doc
        {
            if (MessageBox.Show("Data Update Successfully", "Do you want to Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection con = op.GetCon();
                try
                {
                    //.........................
                    MemoryStream ms = new MemoryStream();
                    PImageDoc.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] photo = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo, 0, photo.Length);


                    //....................................
                    OleDbCommand cmd = new OleDbCommand("Update tblDocFile set PDFFile=@photo, DocLocation='" + txtDocLocation.Text + "',DocName='" + cmbDoc.Text + "',DocTitle='" + txtDocTitle.Text + "',NPage='" + txtNPage.Text + "'  Where ID=" + lblDoc.Text + "", con);
                    //,@photo)", con);
                    cmd.Parameters.AddWithValue("@photo", photo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                     MessageBox.Show("Update Successfull!");
                    //MsUpdate fr = new MsUpdate();
                    //fr.Show();
                   // Clear3();  ធ្វើខ្លួនឯង
                    ShowDataDoc();

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
