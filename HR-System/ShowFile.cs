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
    public partial class ShowFile : Form
    {
        public static ShowFile S;
        public ShowFile()
        {
            InitializeComponent();
            S = this;
        }

        private void ShowFile_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picFile.Image != null)
            {
                SaveFileDialog saveImg = new SaveFileDialog();
                saveImg.Filter = "Image File(*.jpg)|*.jpg";
                if (saveImg.ShowDialog() == DialogResult.OK)
                {

                    picFile.Image.Save(saveImg.FileName);
                    MessageBox.Show("Image to save");
                }
            }
            else
            {
                MessageBox.Show("No Image to save");
            }
        }
    }
}
