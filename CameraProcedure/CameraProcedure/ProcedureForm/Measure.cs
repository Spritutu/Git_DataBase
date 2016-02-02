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
    public struct MeasureParameter
    {
        public HObject ho_Cross;
        public HTuple hv_MeasureHandle;
        public HTuple sigma;
        public HTuple threshold;
        public HTuple transition;
        public HTuple select;
        public HTuple hv_RowEdge;
        public HTuple hv_ColumnEdge;
        public HTuple hv_Amplitude;
        public HTuple hv_Distance;
        public HTuple ROIweight;
    }

    public partial class Measure : Form
    {
        private MeasureParameter MP;

        private ImageBase Measure_Image = new ImageBase();
        public HObject MeasureImage { set { Measure_Image.SetImage = value; } }

        private PointBase mousePosition = new PointBase();
        private RegionBase region_line = new RegionBase();
        private RegionBase region_rec = new RegionBase();

        public bool setornot = false;
        public Measure()
        {
            InitializeComponent();
        }
        
        private void Measure_Activated(object sender, EventArgs e)
        {
            //如果有圖片則載入圖片至toolWindow視窗裡
            if (Measure_Image.GetImage != null)
            {
                toolWindow.WindowImage = Measure_Image;
                toolWindow.Window.Focus();
                toolWindow.showImage();
            }

            //表格參數預載
            this.MaxEdge.Value = 40;
            this.sigma.Value = 1;
            this.ROIWeight.Value = 30;
            this.MaxEage_trackBar.Value = 40;
            this.Sigma_trackBar.Value = 1;
            this.ROIWeight_trackBar.Value = 30;
            MP.transition = "all";
            MP.select = "all";
            MP.sigma = 1;
            MP.threshold = 40;

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            //如果toolWindow視窗裡有影像才執行
            if (toolWindow.WindowImage.GetImage != null)
            {
                toolWindow.Window.Focus();
                toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

                region_line.DrawLine(toolWindow.Window.HalconWindow);
                region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 2);



                HOperatorSet.GenEmptyObj(out MP.ho_Cross);
                HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row,
                    region_line.line_rec.column, region_line.line_rec.phi,
                    region_line.line_rec.length1, ROIWeight_trackBar.Value,
                    toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out MP.hv_MeasureHandle);
                HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, MP.hv_MeasureHandle, MP.sigma, MP.threshold,
                  MP.transition, MP.select, out MP.hv_RowEdge, out MP.hv_ColumnEdge, out MP.hv_Amplitude, out MP.hv_Distance);
                MP.ho_Cross.Dispose();


                HOperatorSet.ClearWindow(toolWindow.Window.HalconWindow);
                HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 2);
                HOperatorSet.GenCrossContourXld(out MP.ho_Cross, MP.hv_RowEdge, MP.hv_ColumnEdge,
                    ROIWeight_trackBar.Value * 2, region_line.line_rec.phi);
                HOperatorSet.DispObj(MP.ho_Cross, toolWindow.Window.HalconWindow);
                HOperatorSet.CloseMeasure(MP.hv_MeasureHandle);


            }
            else
            {
                MessageBox.Show("toolWindow.WindowImage是空的!");
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            
        }

        private void MaxEage_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.MaxEdge.Value = this.MaxEage_trackBar.Value;
            MP.threshold = (int)this.MaxEage_trackBar.Value;
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.sigma.Value = this.Sigma_trackBar.Value;
            MP.sigma = (int)this.Sigma_trackBar.Value;
        }

        private void ROIWeight_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.ROIWeight.Value = this.ROIWeight_trackBar.Value;
            MP.ROIweight = (int)this.ROIWeight_trackBar.Value;
        }

        private void MaxEdge_ValueChanged(object sender, EventArgs e)
        {
            this.MaxEage_trackBar.Value = (int)this.MaxEdge.Value;
            MP.threshold = (int)this.MaxEdge.Value;

            //if (region_rec.GetROI != null)
            //{
            //    toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

            //    HOperatorSet.GenMeasureRectangle2(region_rec.GetRow, region_rec.GetColumn, region_rec.GetPhi, region_rec.GetLength1Rectangle, MP.ROIweight,
            //        toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out MP.hv_MeasureHandle);
            //    HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, MP.hv_MeasureHandle, MP.sigma, MP.threshold,
            //      MP.transition, MP.select, out MP.hv_RowEdge, out MP.hv_ColumnEdge, out MP.hv_Amplitude, out MP.hv_Distance);


            //    region_line.SetLine(toolWindow.Window.HalconWindow, "yellow", "margin", 3);
            //    HOperatorSet.GenCrossContourXld(out MP.ho_Cross, MP.hv_RowEdge, MP.hv_ColumnEdge, MP.ROIweight * 2, region_rec.GetPhi);
            //    HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
            //    HOperatorSet.DispObj(MP.ho_Cross, toolWindow.Window.HalconWindow);
            //    HOperatorSet.CloseMeasure(MP.hv_MeasureHandle);

            //    region_line.setROIline_rec(toolWindow.Window.HalconWindow, region_rec.GetRow, region_rec.GetColumn, region_rec.GetPhi,
            //        region_rec.GetLength1Rectangle);
            //}
        }

        private void sigma_ValueChanged(object sender, EventArgs e)
        {

            this.Sigma_trackBar.Value = (int)this.sigma.Value;
            MP.sigma = (int)this.sigma.Value;
            //if (region_rec.GetROI != null)
            //{
            //    toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

            //    HOperatorSet.GenMeasureRectangle2(region_rec.GetRow, region_rec.GetColumn, region_rec.GetPhi, region_rec.GetLength1Rectangle, MP.ROIweight,
            //        toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out MP.hv_MeasureHandle);
            //    HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, MP.hv_MeasureHandle, MP.sigma, MP.threshold,
            //      MP.transition, MP.select, out MP.hv_RowEdge, out MP.hv_ColumnEdge, out MP.hv_Amplitude, out MP.hv_Distance);


            //    region_line.SetLine(toolWindow.Window.HalconWindow, "yellow", "margin", 3);
            //    HOperatorSet.GenCrossContourXld(out MP.ho_Cross, MP.hv_RowEdge, MP.hv_ColumnEdge,MP.ROIweight * 2, region_rec.GetPhi);
            //    HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
            //    HOperatorSet.DispObj(MP.ho_Cross, toolWindow.Window.HalconWindow);
            //    HOperatorSet.CloseMeasure(MP.hv_MeasureHandle);

            //    region_line.setROIline_rec(toolWindow.Window.HalconWindow, region_rec.GetRow, region_rec.GetColumn, region_rec.GetPhi,
            //        region_rec.GetLength1Rectangle);
            //}
        }

        private void ROIWeight_ValueChanged(object sender, EventArgs e)
        {

            this.ROIWeight_trackBar.Value = (int)this.ROIWeight.Value;
            MP.ROIweight = (int)this.ROIWeight.Value;
            //if (region_rec.GetROI != null)
            //{
            //    toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

            //    HOperatorSet.GenMeasureRectangle2(region_rec.GetRow, region_rec.GetColumn, region_rec.GetPhi, region_rec.GetLength1Rectangle, MP.ROIweight,
            //        toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out MP.hv_MeasureHandle);
            //    HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, MP.hv_MeasureHandle, MP.sigma, MP.threshold,
            //      MP.transition, MP.select, out MP.hv_RowEdge, out MP.hv_ColumnEdge, out MP.hv_Amplitude, out MP.hv_Distance);

            //    region_line.SetLine(toolWindow.Window.HalconWindow, "yellow", "margin", 3);
            //    HOperatorSet.GenCrossContourXld(out MP.ho_Cross, MP.hv_RowEdge, MP.hv_ColumnEdge,
            //        MP.ROIweight * 2, region_rec.GetPhi);
            //    HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
            //    HOperatorSet.DispObj(MP.ho_Cross, toolWindow.Window.HalconWindow);
            //    HOperatorSet.CloseMeasure(MP.hv_MeasureHandle);

                
            //    region_line.setROIline_rec(toolWindow.Window.HalconWindow, region_rec.GetRow, region_rec.GetColumn, region_rec.GetPhi,
            //        region_rec.GetLength1Rectangle);
            //}
        }
    }
}
