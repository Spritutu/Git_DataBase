using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZQSFP_detection
{
    public partial class LoadImage : Form
    {
        public LoadImage()
        {
            InitializeComponent();
        }

        private void Load_Image_Click(object sender, EventArgs e)
        {
            LoadImage_path loadImage_path = new LoadImage_path();
            loadImage_path.ShowDialog();
            this.Close();
        }

        private void Load_Camera_Click(object sender, EventArgs e)
        {
            CameraWindow camera = new CameraWindow();
            camera.ShowDialog();
            this.Close();
        }
    }
}
