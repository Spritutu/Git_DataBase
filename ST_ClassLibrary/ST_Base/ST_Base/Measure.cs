using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
namespace ST_Base
{
    public class Measure
    {
        private HObject ho_Cross;
        private HTuple hv_MeasureHandle;

        private HTuple hv_RowEdge = null;
        private HTuple hv_ColumnEdge = null;
        private HTuple hv_Amplitude = null;
        private HTuple hv_Distance = null;
        private HTuple Measure_retangle2;
        private HTuple Measure_Phi;


        public void Measure_rectangle2(RegionBase ROI,ImageBase image,HTuple Sigma, HTuple threshold) {

            //Initialize local and output iconic variables
            HOperatorSet.GenEmptyObj(out ho_Cross);                                                     //清空ho_Cross

            HOperatorSet.GenMeasureRectangle2(ROI.GetRow,                                               //產生測量矩形
                ROI.GetColumn, ROI.GetPhi,
                ROI.GetLength1Rectangle, ROI.GetLength2Rectangle,
                image.GetWidth, image.GetHeight, "nearest_neighbor", out hv_MeasureHandle);

            HOperatorSet.MeasurePos(image.GetImage, hv_MeasureHandle, Sigma, threshold,                 //設定測量參數  並且輸出測量錨點
                "all", "all", out hv_RowEdge, out hv_ColumnEdge, out hv_Amplitude, out hv_Distance);
            Measure_retangle2 = ROI.GetLength2Rectangle;
            Measure_Phi = ROI.GetPhi;
                HOperatorSet.CloseMeasure(hv_MeasureHandle);


        }
        public void disp_Measure_rectangle2(HTuple Window) {

                ho_Cross.Dispose();
            HOperatorSet.SetColor(Window, "blue");                                       //設定顏色及型態
            HOperatorSet.SetDraw(Window, "margin");
            HOperatorSet.GenCrossContourXld(out ho_Cross, hv_RowEdge, hv_ColumnEdge,                    //產生錨點標記十字
                Measure_retangle2 * 2, Measure_Phi);
            
            HOperatorSet.DispObj(ho_Cross, Window);
        }


        public HObject get_Cross { get { return ho_Cross; } }
        public HTuple get_RowEdge { get { return hv_RowEdge; } }
        public HTuple get_ColumnEdge { get { return hv_ColumnEdge; } }
        public HTuple get_Amplitude { get { return hv_Amplitude; } }
        public HTuple get_Distance { get { return hv_Distance; } }
    }
}
