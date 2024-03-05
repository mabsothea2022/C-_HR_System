using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HR_System
{
    internal class ConnectionMB
    {
        public OleDbConnection GetCon()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\HR-System\HR.accdb;";

            return con;
           
            
            //OleDbConnection con = new OleDbConnection
            //{
         
            //    ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\My Drive\PEC23\CECDatabase.accdb; Persist Security Info = True; Jet OLEDB:Database Password = 093782000"


            //};

            //return con;



        }
        public void UpdateData(string query)
        {
            OleDbConnection con = GetCon();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = con
            };
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully");
            con.Close();
        }
        public void DeleteData(string query)
        {
            OleDbConnection con = GetCon();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = con
            };
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}
