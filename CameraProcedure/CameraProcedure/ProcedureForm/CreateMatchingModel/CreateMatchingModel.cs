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
    public struct CreateMatchingModelParameter
    {
        
    }
    public partial class CreateMatchingModel : Form
    {
        private RegionBase region = new RegionBase();
        private ImageBase Measure_Image = new ImageBase();
        public HObject MeasureImage { set { Measure_Image.SetImage = value; } }
        private CreateMatchingModelParameter CMMP;

        public bool setornot = false;
        bool ifopenfromornot = true;

        public CreateMatchingModel()
        {
            InitializeComponent();
        }
        public void run()
        {

        }

      
    }
}
