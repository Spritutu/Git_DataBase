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

    public struct Measure2DcircleParameter
    {
        public HObject ho_Image, ho_Circle, ho_Contours, ho_Contour;
        public HObject ho_Cross;

        // Local control variables 

        public HTuple hv_Width, hv_Height, hv_Row;
        public HTuple hv_Column, hv_Radius, hv_MetrologyHandle;
        public HTuple hv_MetrologyCircleIndices, hv_Row1;
        public HTuple hv_Column1;

        public HTuple Length1;
        public HTuple Length2;
        public HTuple Sigma;
        public HTuple Threshold;

    }

    public partial class Measure_2D_Circle : Form
    {
        private RegionBase region_circle = new RegionBase();
        //private ImageBase Measure_Image = new ImageBase();
        //public HObject MeasureImage { set { Measure_Image.SetImage = value; } }
        private Measure2DcircleParameter M2DCP;
        public bool setornot = false;
        bool ifopenformornot = false;

        public List<Object_Table> O_T = new List<Object_Table>();
        List<Measure_1D_SelectImage> SelectImage = new List<Measure_1D_SelectImage>();

        private ImageBase src_Image = new ImageBase();
        public HObject SrcImage { set { src_Image.SetImage = value; } }
        private ImageBase dst_Image = new ImageBase();
        public HObject dstImage { get { return dst_Image.GetImage; } }
        bool loadfinish = false;


        public Measure_2D_Circle()
        {
            InitializeComponent();
        }

        private void Measure_2D_Circle_Activated(object sender, EventArgs e)
        {
            if (setornot == false)
            {
                if (ifopenformornot == false)
                {
                    ifopenformornot = true;
                    SelectImage.Clear();
                    for (int i = 0; i < O_T.Count; i++)
                    {
                        for (int j = 0; j < O_T[i].OImage.Count; j++)
                        {
                            if (O_T[i].OImage[j] != null)
                            {
                                Measure_1D_SelectImage M1S = new Measure_1D_SelectImage();
                                M1S.Image = O_T[i].OImage[j];
                                M1S.ImageName = (string)O_T[i].OImageName[j];
                                SelectImage.Add(M1S);
                            }
                        }
                    }
                    whichpicture.DataSource = SelectImage;
                    whichpicture.DisplayMember = "ImageName";
                    whichpicture.ValueMember = "Image";
                    loadfinish = true;

                    src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                    toolWindow.WindowImage = src_Image;
                    toolWindow.showImage();
                }

            }
            else if (setornot == true)
            {
                if (ifopenformornot == false)
                {
                    ifopenformornot = true;
                    toolWindow.showImage();
                    toolWindow1.showImage();
                }

            }
                        
            if (ifopenformornot)
            {
                M2DCP.Length1 = 20;
                M2DCP.Length2 = 5;
                M2DCP.Sigma = 1;
                M2DCP.Threshold = 10;

                this.Length1_trackBar.Value = 20;
                this.Length2_trackBar.Value = 5;
                this.Sigma_trackBar.Value = 1;
                this.Threshold_trackBar.Value = 10;

                ifopenformornot = false;
            }
        }
        
        private void Length1_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DCP.Length1 = (int)this.Length1.Value;
            Showresult();
        }

        private void Length1_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length1.Value = (int)this.Length1_trackBar.Value;
            M2DCP.Length1 = (int)this.Length1_trackBar.Value;
        }

        private void Length2_ValueChanged(object sender, EventArgs e)
        {
            this.Length2_trackBar.Value = (int)this.Length2.Value;
            M2DCP.Length2 = (int)this.Length2.Value;
            Showresult();
        }

        private void Length2_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length2.Value = (int)this.Length2_trackBar.Value;
            M2DCP.Length2 = (int)this.Length2_trackBar.Value;
        }

        private void Sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.Sigma.Value;
            M2DCP.Sigma = (int)this.Sigma.Value;
            Showresult();
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma.Value = (int)this.Sigma_trackBar.Value;
            M2DCP.Sigma = (int)this.Sigma_trackBar.Value;
        }

        private void Threshold_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DCP.Length1 = (int)this.Length1.Value;
            Showresult();
        }
        private void Threshold_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Threshold.Value = (int)this.Threshold_trackBar.Value;
            M2DCP.Threshold = (int)this.Threshold_trackBar.Value;
        }

        public void run()
        {

        }

        private void Showresult()
        {
            if (M2DCP.hv_MetrologyHandle != null)
            {
                HOperatorSet.ClearMetrologyModel(M2DCP.hv_MetrologyHandle);
                HOperatorSet.CreateMetrologyModel(out M2DCP.hv_MetrologyHandle);
                HOperatorSet.SetMetrologyModelImageSize(M2DCP.hv_MetrologyHandle, src_Image.GetWidth, src_Image.GetHeight);

                HOperatorSet.AddMetrologyObjectCircleMeasure(M2DCP.hv_MetrologyHandle, region_circle.circle.row,
                    region_circle.circle.column, region_circle.circle.radius, M2DCP.Length1, M2DCP.Length2,
                    M2DCP.Sigma, M2DCP.Threshold, new HTuple(), new HTuple(), out M2DCP.hv_MetrologyCircleIndices);
                HOperatorSet.ApplyMetrologyModel(src_Image.GetImage, M2DCP.hv_MetrologyHandle);
                HOperatorSet.GetMetrologyObjectResultContour(out M2DCP.ho_Contours, M2DCP.hv_MetrologyHandle, "all", "all", 1.5);
                HOperatorSet.GetMetrologyObjectMeasures(out M2DCP.ho_Contour, M2DCP.hv_MetrologyHandle, "all","all", out M2DCP.hv_Row1, out M2DCP.hv_Column1);

                HOperatorSet.GenCrossContourXld(out M2DCP.ho_Cross, M2DCP.hv_Row1, M2DCP.hv_Column1, 6, 0.785398);
                HOperatorSet.DispObj(src_Image.GetImage, toolWindow1.Window.HalconWindow);

                HOperatorSet.SetColor(toolWindow1.Window.HalconWindow, "blue");
                HOperatorSet.DispObj(M2DCP.ho_Cross, toolWindow1.Window.HalconWindow);

                HOperatorSet.SetColor(toolWindow1.Window.HalconWindow, "red");
                HOperatorSet.DispObj(M2DCP.ho_Contours, toolWindow1.Window.HalconWindow);
            }

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            toolWindow1.Window.Focus();
            toolWindow1.WindowImage.ShowImage_autosize(toolWindow1.Window.HalconWindow);
            region_circle.DrawCircle(toolWindow1.Window.HalconWindow);
            region_circle.showROI(toolWindow1.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);
            HOperatorSet.CreateMetrologyModel(out M2DCP.hv_MetrologyHandle);
            Showresult();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            setornot = true;
            ifopenformornot = false;
            Hide();
        }
        
        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage = src_Image;
                if(toolWindow.WindowImage!=null)
                    toolWindow.showImage();
                toolWindow1.WindowImage = src_Image;
                if (toolWindow1.WindowImage != null)
                    toolWindow1.showImage();
            }
        }
        
    }
}
