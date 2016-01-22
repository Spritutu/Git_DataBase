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

namespace ZQSFP_detection
{
    public partial class LoadImage_path : Form
    {
        public LoadImage_path()
        {
            InitializeComponent();
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PicturePath.Text = openFileDialog1.FileName;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (PicturePath.Text == "")
                this.Close();
            else
            {

                HOperatorSet.ReadImage(out ZQSFP_Form.Mainpicture, PicturePath.Text);
                this.Close();
            }
        }
    }
}
