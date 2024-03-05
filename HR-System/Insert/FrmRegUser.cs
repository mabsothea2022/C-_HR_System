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
    public partial class FrmRegUser : Form
    {
        public static FrmRegUser RU;
        public FrmRegUser()
        {
            InitializeComponent();
            RU = this;
        }
        ConnectionMB op = new ConnectionMB();
        private void FrmRegUser_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }
        void Insert()//ព័ត៌មានមុខ
        {

            try
            {
                //Check If One Or More Fields Are Empty
                if (txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty || txtNPhone.Text == String.Empty)
                    //    //|| txtPhone.Text == string.Empty)
                    {
                        MessageBox.Show("One Or More Empty Field ............");
                        //MsNoBlank fr = new MsNoBlank();
                        //fr.ShowDialog();
                    }
                    else
                    {
                       
                            OleDbConnection con = op.GetCon();
                            MemoryStream ms = new MemoryStream();
                            picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] photo = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(photo, 0, photo.Length);


                            //....................................
                            OleDbCommand cmd = new OleDbCommand("Insert into T_UserBIO(EImage,UserName,FirstNameKH,LastNameKH,Sex,Phone)" +
                                " values (@photo,'" + lbUsername.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cmbSex.Text + "','" + txtNPhone.Text + "')", con);

                            cmd.Parameters.AddWithValue("@photo", photo);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                    MessageBox.Show("Saved Successfull!");
                    //MsAdd fr = new MsAdd();
                    //fr.ShowDialog();
                   
                    if (lblAccount.Text=="Admin")
                    {
                        string query;
                        query = "update T_User set PV='" + lblActive.Text + "' where UserName = '" + lbUsername.Text + "'";
                        op.UpdateData(query);
                        MainBoard.MB.TMTask.Enabled = true;
                        MainBoard.MB.TMReport.Enabled = true;
                        MainBoard.MB.TMSecurrity.Enabled = true;


                    }
                    else if (lblAccount.Text=="Manager")
                    {
                        string query;
                        query = "update T_User set PV='" + lblActive.Text + "' where UserName = '" + lbUsername.Text + "'";
                        op.UpdateData(query);
                        MainBoard.MB.TMTask.Enabled = true;
                        MainBoard.MB.TMReport.Enabled = true;
                        MainBoard.MB.TsmInsertEmp.Enabled = false;
                        MainBoard.MB.TMSecurrity.Visible = false;



                    }
                    else
                    {
                        string query;
                        query = "update T_User set PV='" + lblActive.Text + "' where UserName = '" + lbUsername.Text + "'";
                        op.UpdateData(query);
                        MainBoard.MB.TMTask.Enabled = true;
                        MainBoard.MB.TMReport.Enabled = true;
                        MainBoard.MB.TMSecurrity.Visible = false;

                    }

                   Hide();
                    
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x + "");
                }
            

        }
        void Clear()
        {
            txtNPhone.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            cmbSex.Text = String.Empty;
            lbUsername.Text = String.Empty;
            picImage.Image = null;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FrmCapture fr = new FrmCapture();
            fr.ShowDialog();
        }
    }
}
