using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST_Base;
using HalconDotNet;

namespace CameraProcedure
{
    public struct Measure2DlineParameter
    {
        public HObject ho_Cross;
        public HObject ho_MeasureConts;
        public HObject ho_line;
               
        public HTuple hv_MetrologyHandle;
        public HTuple hv_Index;
        public HTuple hv_Par;
        public HTuple hv_Rtmp;
        public HTuple hv_Ctmp;

        public HTuple Length1;
        public HTuple Length2;
        public HTuple Sigma;
        public HTuple Threshold;

    }

    public partial class Measure_2D_Line : Form
    {
        private RegionBase region_line = new RegionBase();
        private ImageBase Measure_Image = new ImageBase();
        public HObject MeasureImage { set { Measure_Image.SetImage = value; } }
        private Measure2DlineParameter M2DP;

        public bool setornot = false;
        bool ifopenformornot = true;

        public Measure_2D_Line()
        {
            InitializeComponent();
        }
        private void Measure_2D_Activated(object sender, EventArgs e)
        {
            toolWindow.WindowImage.CopyImagetoThis(Measure_Image.GetImage);

            if (toolWindow.WindowImage != null)
            {
                toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
            }
            if (ifopenformornot)
            {
                M2DP.Length1 = 20;
                M2DP.Length2 = 5;
                M2DP.Sigma = 1;
                M2DP.Threshold = 10;

                this.Length1_trackBar.Value = 20;
                this.Length2_trackBar.Value = 5;
                this.Sigma_trackBar.Value = 1;
                this.Threshold_trackBar.Value = 10;

                ifopenformornot = false;
            }
        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            toolWindow.Window.Focus();
            toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
            region_line.DrawLine(toolWindow.Window.HalconWindow);
            region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);
            HOperatorSet.CreateMetrologyModel(out M2DP.hv_MetrologyHandle);
            Showresult();
        }
        public void run()
        {
            
        }


        private void Showresult()
        {

            if (M2DP.hv_MetrologyHandle != null)
            {
                HOperatorSet.ClearMetrologyModel(M2DP.hv_MetrologyHandle);
                HOperatorSet.CreateMetrologyModel(out M2DP.hv_MetrologyHandle);
                HOperatorSet.SetMetrologyModelImageSize(M2DP.hv_MetrologyHandle, Measure_Image.GetWidth, Measure_Image.GetHeight);

                HOperatorSet.AddMetrologyObjectLineMeasure(M2DP.hv_MetrologyHandle, region_line.line.row_start,
                    region_line.line.column_start, region_line.line.row_end, region_line.line.column_end, M2DP.Length1, M2DP.Length2, M2DP.Sigma, M2DP.Threshold, "measure_transition", "all", out M2DP.hv_Index);
                HOperatorSet.ApplyMetrologyModel(Measure_Image.GetImage, M2DP.hv_MetrologyHandle);
                HOperatorSet.GetMetrologyObjectResult(M2DP.hv_MetrologyHandle, "all", "all", "result_type", "all_param", out M2DP.hv_Par);
                //M2DP.ho_MeasureConts.Dispose();
                HOperatorSet.GetMetrologyObjectMeasures(out M2DP.ho_MeasureConts, M2DP.hv_MetrologyHandle, "all", "all", out M2DP.hv_Rtmp, out M2DP.hv_Ctmp);
                if (M2DP.ho_Cross != null)
                {
                    M2DP.ho_Cross.Dispose();
                }

                HOperatorSet.GenCrossContourXld(out M2DP.ho_Cross, M2DP.hv_Rtmp, M2DP.hv_Ctmp, 6, (new HTuple(45)).TupleRad());

                HOperatorSet.DispObj(Measure_Image.GetImage, toolWindow.Window.HalconWindow);

                HOperatorSet.SetColor(toolWindow.Window.HalconWindow, "blue");
                HOperatorSet.DispObj(M2DP.ho_Cross, toolWindow.Window.HalconWindow);

                HOperatorSet.SetColor(toolWindow.Window.HalconWindow, "red");
                if (M2DP.hv_Par.Length != 0)
                {
                    HOperatorSet.GenRegionLine(out M2DP.ho_line, M2DP.hv_Par.TupleSelect(0), M2DP.hv_Par.TupleSelect(1), M2DP.hv_Par.TupleSelect(2), M2DP.hv_Par.TupleSelect(3));
                    HOperatorSet.DispObj(M2DP.ho_line, toolWindow.Window.HalconWindow);
                }
            }
                
            
        }




        private void Length1_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int) this.Length1.Value ;
            M2DP.Length1 = (int)this.Length1.Value;
            Showresult();
        }

        private void Length1_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length1.Value = (int)this.Length1_trackBar.Value;
            M2DP.Length1 = (int)this.Length1_trackBar.Value;
        }

        private void Length2_ValueChanged(object sender, EventArgs e)
        {
            this.Length2_trackBar.Value = (int)this.Length2.Value;
            M2DP.Length2 = (int)this.Length2.Value;
            Showresult();
        }

        private void Length2_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length2.Value = (int)this.Length2_trackBar.Value;
            M2DP.Length2 = (int)this.Length2_trackBar.Value;
        }

        private void Sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.Sigma.Value;
            M2DP.Sigma = (int)this.Sigma.Value;
            Showresult();
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma.Value = (int)this.Sigma_trackBar.Value;
            M2DP.Sigma = (int)this.Sigma_trackBar.Value;
        }

        private void Threshold_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DP.Length1 = (int)this.Length1.Value;
            Showresult();
        }
        private void Threshold_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Threshold.Value = (int)this.Threshold_trackBar.Value;
            M2DP.Threshold = (int)this.Threshold_trackBar.Value;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            setornot = true;
            ifopenformornot = false;
            Hide();
        }
    }
}
