using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_LoadImage
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void ImgaeFromFile_Click(object sender, EventArgs e)
        {

            ST_LoadImage.loadimage.ImagefromFile();
            this.Close();
        }

        private void ImageFromCamera_Click(object sender, EventArgs e)
        {
            ImageFromCamera imagefromcamera = new ImageFromCamera();
            imagefromcamera.ShowDialog();
            this.Close();
        }


    }
}
