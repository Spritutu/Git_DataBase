using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using ST_Base;

namespace ST_LoadImage
{
    public partial class ImageFromCamera : Form
    {
        
        public ImageBase captureimage_camera = new ImageBase();
        public Camera Camera_one = new Camera();

        public ImageFromCamera()
        {
            InitializeComponent();
                       
        }
        
        private void CameraCaptrue_Click(object sender, EventArgs e)
        {
            ST_LoadImage.loadimage.ImagefromCameraandshow(Camera_one,this.Camera_capture.HalconWindow);
        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            Camera_one.Close();
            this.Close();
        }

        private void exposure_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.exposure_domainUpDown.Value = this.exposure_trackBar.Value;
            Camera_one.exposure = exposure_trackBar.Value;
            Camera_one.setexposure();
        }
        
        private void ImageFromCamera_Load(object sender, EventArgs e)
        {
            OK.Enabled = false;
            CameraCaptrue.Enabled = false;
            Camera_one.Open();
            Camera_one.exposure = 15;
            OK.Enabled = true;
            CameraCaptrue.Enabled = true;
        }
        
        private void exposure_domainUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.exposure_trackBar.Value = (int)this.exposure_domainUpDown.Value;
        }
                
    }
}

