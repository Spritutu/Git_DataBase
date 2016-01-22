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
    public partial class EnhanceImageWindow : Form
    {
        public HObject SRC;
        public HObject DST;

        ImageBase src_Image = new ImageBase();

        ImageBase dst_Image = new ImageBase();

        public EnhanceImageWindow()
        {
            
            InitializeComponent();
        }

        private void CoherenceEnhancingDiff_button_Click(object sender, EventArgs e)
        {
            Enhancenment.CoherenceEnhancingDiff(src_Image, dst_Image);
            ZQSFP_Form.Temp = dst_Image.GetImage;
            this.Close();

        }

        private void Emphasize_button_Click(object sender, EventArgs e)
        {
            Enhancenment.Emphasize(src_Image, dst_Image);
            ZQSFP_Form.Temp = dst_Image.GetImage;
            this.Close();
        }

        private void EquHistoImage_button_Click(object sender, EventArgs e)
        {
            Enhancenment.EquHistoImage(src_Image,dst_Image);
            ZQSFP_Form.Temp = dst_Image.GetImage;
            this.Close();
        }

        private void Illuminate_button_Click(object sender, EventArgs e)
        {
            Enhancenment.Illuminate(src_Image, dst_Image);
            ZQSFP_Form.Temp = dst_Image.GetImage;
            this.Close();
        }

        private void ScaleImageMax_button_Click(object sender, EventArgs e)
        {
            Enhancenment.ScaleImageMax(src_Image,dst_Image);
            ZQSFP_Form.Temp = dst_Image.GetImage;
            this.Close();
        }

        private void ShockFilter_button_Click(object sender, EventArgs e)
        {
            Enhancenment.ShockFilter(src_Image,dst_Image);
            ZQSFP_Form.Temp = dst_Image.GetImage;
            this.Close();
        }

        private void EnhanceImageWindow_Load(object sender, EventArgs e)
        {
            src_Image.SetImage = SRC;
        }
    }
}
