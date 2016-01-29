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

namespace CameraProcedure
{
    public partial class Measure : Form
    {

        private ImageBase Measure_Image = new ImageBase();
        public HObject MeasureImage { set { Measure_Image.SetImage = value; } }

        public bool setornot = false;
        public Measure()
        {
            InitializeComponent();
        }
        
        private void Measure_Activated(object sender, EventArgs e)
        {
            toolWindow1.WindowImage = Measure_Image;
            if (Measure_Image.GetImage != null)                                                                  //如果有圖片則載入圖片至halcon視窗裡
            {
                toolWindow1.showImage();
            }
        }
    }
}
