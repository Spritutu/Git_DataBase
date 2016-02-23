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
    public struct Measure2DEllipseParameter
    {
        public HObject ho_Image, ho_Ellipse, ho_Contours;
        public HObject ho_Contour, ho_Cross;

        // Local control variables 

        public HTuple hv_Width , hv_Height  , hv_Row  ;
        public HTuple hv_Column , hv_Phi  , hv_Radius1  ;
        public HTuple hv_Radius2  , hv_MetrologyHandle  , hv_Index  ;
        public HTuple hv_Row1  , hv_Column1  ;

        public HTuple Length1;
        public HTuple Length2;
        public HTuple Sigma;
        public HTuple Threshold;

    }
    public partial class Measure_2D_Ellipse : Form
    {

        private RegionBase region_Ellipse = new RegionBase();
        private ImageBase Measure_Image = new ImageBase();
        public HObject MeasureImage { set { Measure_Image.SetImage = value; } }
        private Measure2DEllipseParameter M2DEP;

        public bool setornot = false;
        bool ifopenfromornot = true;

        public Measure_2D_Ellipse()
        {
            InitializeComponent();
        }

        public void run()
        {

        }

        private void Measure_2D_Ellipse_Activated(object sender, EventArgs e)
        {
            toolWindow.WindowImage = Measure_Image;

            if (toolWindow.WindowImage != null)
            {
                toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
            }
            if (ifopenfromornot)
            {
                M2DEP.Length1 = 20;
                M2DEP.Length2 = 5;
                M2DEP.Sigma = 1;
                M2DEP.Threshold = 10;

                this.Length1_trackBar.Value = 20;
                this.Length2_trackBar.Value = 5;
                this.Sigma_trackBar.Value = 1;
                this.Threshold_trackBar.Value = 10;

                ifopenfromornot = false;
            }
        }
        private void Length1_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DEP.Length1 = (int)this.Length1.Value;
            Showresult();
        }

        private void Length1_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length1.Value = (int)this.Length1_trackBar.Value;
            M2DEP.Length1 = (int)this.Length1_trackBar.Value;
        }

        private void Length2_ValueChanged(object sender, EventArgs e)
        {
            this.Length2_trackBar.Value = (int)this.Length2.Value;
            M2DEP.Length2 = (int)this.Length2.Value;
            Showresult();
        }

        private void Length2_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length2.Value = (int)this.Length2_trackBar.Value;
            M2DEP.Length2 = (int)this.Length2_trackBar.Value;
        }

        private void Sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.Sigma.Value;
            M2DEP.Sigma = (int)this.Sigma.Value;
            Showresult();
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma.Value = (int)this.Sigma_trackBar.Value;
            M2DEP.Sigma = (int)this.Sigma_trackBar.Value;
        }

        private void Threshold_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DEP.Length1 = (int)this.Length1.Value;
            Showresult();
        }
        private void Threshold_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Threshold.Value = (int)this.Threshold_trackBar.Value;
            M2DEP.Threshold = (int)this.Threshold_trackBar.Value;
        }

        private void Showresult()
        {
            if (M2DEP.hv_MetrologyHandle != null)
            {
                HOperatorSet.ClearMetrologyModel(M2DEP.hv_MetrologyHandle);
                HOperatorSet.CreateMetrologyModel(out M2DEP.hv_MetrologyHandle);
                HOperatorSet.SetMetrologyModelImageSize(M2DEP.hv_MetrologyHandle, Measure_Image.GetWidth, Measure_Image.GetHeight);

                HOperatorSet.AddMetrologyObjectEllipseMeasure(M2DEP.hv_MetrologyHandle, region_Ellipse.ellipse.row, region_Ellipse.ellipse.column, region_Ellipse.ellipse.phi,
                    region_Ellipse.ellipse.radius1, region_Ellipse.ellipse.radius2, M2DEP.Length1, M2DEP.Length2,
                    M2DEP.Sigma, M2DEP.Threshold, new HTuple(), new HTuple(), out M2DEP.hv_Index);
                HOperatorSet.ApplyMetrologyModel(Measure_Image.GetImage, M2DEP.hv_MetrologyHandle);
                HOperatorSet.GetMetrologyObjectResultContour(out M2DEP.ho_Contours, M2DEP.hv_MetrologyHandle, "all", "all", 1.5);
                HOperatorSet.GetMetrologyObjectMeasures(out M2DEP.ho_Contour, M2DEP.hv_MetrologyHandle, "all", "all", out M2DEP.hv_Row1, out M2DEP.hv_Column1);
                HOperatorSet.GenCrossContourXld(out M2DEP.ho_Cross, M2DEP.hv_Row1, M2DEP.hv_Column1, 6, 0.785398);
                HOperatorSet.DispObj(Measure_Image.GetImage, toolWindow.Window.HalconWindow);
                HOperatorSet.SetColor(toolWindow.Window.HalconWindow, "blue");
                HOperatorSet.DispObj(M2DEP.ho_Cross, toolWindow.Window.HalconWindow);
                HOperatorSet.SetColor(toolWindow.Window.HalconWindow, "red");
                HOperatorSet.DispObj(M2DEP.ho_Contours, toolWindow.Window.HalconWindow);
            }

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            toolWindow.Window.Focus();
            toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
            region_Ellipse.DrawEllipse(toolWindow.Window.HalconWindow);
            region_Ellipse.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);
            HOperatorSet.CreateMetrologyModel(out M2DEP.hv_MetrologyHandle);
            Showresult();
        }


    }
}
