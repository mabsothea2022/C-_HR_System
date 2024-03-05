using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Data.OleDb;
using System.Drawing.Imaging;

namespace HR_System
{
    public partial class FrmCapture : Form
    {
        public static FrmCapture CP;
        public FrmCapture()
        {
            InitializeComponent();
            CP = this;
        }
        ConnectionMB op = new ConnectionMB();
        private FilterInfoCollection CaptureDevices;
        public VideoCaptureDevice VideoSource;
        private void FrmCapture_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Divces in CaptureDevices)
            {
                cmbWeb.Items.Add(Divces.Name);
            }
            cmbWeb.SelectedIndex = 0;
            VideoSource = new VideoCaptureDevice();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            VideoSource = new VideoCaptureDevice(CaptureDevices[cmbWeb.SelectedIndex].MonikerString);
            VideoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            VideoSource.Start();
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PicImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            VideoSource.Stop();
            PicImage.Image = null;
            PicImage.Invalidate();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (PicImage.Image == null)
            {
                MessageBox.Show("Please Have Image First");
            }
            else
            {
                PicImage.Image = (Bitmap)PicImage.Image.Clone();
                VideoSource.Stop();
            }
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          FrmRegUser.RU.picImage.Image = (Bitmap)PicImage.Image.Clone();
            FrmRegUser.RU.btnSave.Enabled = true;
            this.Hide();
        }

        
    }
}
