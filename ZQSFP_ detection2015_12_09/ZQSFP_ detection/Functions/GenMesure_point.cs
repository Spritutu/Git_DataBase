using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ZQSFP_detection
{
    class GenMesure_point
    {
        private HObject ho_Cross;
        private HObject ho_Cross1;
        private HTuple hv_ExpDefaultWinHandle;
        private HTuple hv_Width = null;
        private HTuple hv_Height = null;
        private HTuple hv_MeasureHandle = null;
        private HTuple hv_RowEdge = null;
        private HTuple hv_ColumnEdge = null;
        private HTuple hv_Amplitude = null;
        private HTuple hv_Distance = null;

        private HTuple hv_RowEdgeFirst = null;
        private HTuple hv_ColumnEdgeFirst = null;
        private HTuple hv_AmplitudeFirst = null;
        private HTuple hv_DistanceFirst = null;

        private HTuple hv_RowEdgeSecond = null;
        private HTuple hv_ColumnEdgeSecond = null;
        private HTuple hv_AmplitudeSecond = null;
        private HTuple hv_DistanceSecond = null;

        private HTuple hv_PinWidth = null;
        private HTuple hv_PinDistance = null;

        // Main procedure 
        private void action(DrawlinetoRectangle2 Rectangle2, int Sigma, int threshold, HObject hv_image)
        {
            HObject hv_image_c;                                                                         //複製一份主圖進來運算
            hv_image_c = hv_image.Clone();

            //Initialize local and output iconic variables
            HOperatorSet.GenEmptyObj(out ho_Cross);
            HOperatorSet.GenEmptyObj(out ho_Cross1); 
            HOperatorSet.GetImageSize(hv_image_c, out hv_Width, out hv_Height);                         //得到影像大小(2448*2048)

            HOperatorSet.GenMeasureRectangle2(Rectangle2.get_rectangle_Row,                             //產生測量矩形
                Rectangle2.get_rectangle_Column, Rectangle2.get_rectangle_Phi, 
                Rectangle2.get_rectangle_Length1,Rectangle2.get_rectangle_Length2, 
                hv_Width, hv_Height, "nearest_neighbor", out hv_MeasureHandle);

            



            //---------------------------------------------------------------------------------
            //HOperatorSet.MeasurePairs(hv_image_c, hv_MeasureHandle, 1.5, 30, "negative", "all",
            //out hv_RowEdgeFirst, out hv_ColumnEdgeFirst, out hv_AmplitudeFirst, out hv_RowEdgeSecond,
            //out hv_ColumnEdgeSecond, out hv_AmplitudeSecond, out hv_PinWidth, out hv_PinDistance);
            ////Delete the measure object

            
            //ho_Cross.Dispose();
            //HOperatorSet.GenCrossContourXld(out ho_Cross, hv_RowEdgeFirst, hv_ColumnEdgeFirst,
            //    Rectangle2.get_rectangle_Length2 * 2, Rectangle2.get_rectangle_Phi);
            
            //ho_Cross1.Dispose();
            //HOperatorSet.GenCrossContourXld(out ho_Cross1, hv_RowEdgeSecond, hv_ColumnEdgeSecond,
            //    Rectangle2.get_rectangle_Length2 * 2, Rectangle2.get_rectangle_Phi);

            //HOperatorSet.DispObj(hv_image_c, hv_ExpDefaultWinHandle);
            //HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "red");
            //HOperatorSet.DispObj(ho_Cross, hv_ExpDefaultWinHandle);
            //HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "blue");
            //HOperatorSet.DispObj(ho_Cross1, hv_ExpDefaultWinHandle);
            //HOperatorSet.CloseMeasure(hv_MeasureHandle);                                                //關閉測量控制器 hv_MeasureHandle
            //hv_image_c.Dispose();
            //-------------------------------------------------------------------------------------

            HOperatorSet.MeasurePos(hv_image_c, hv_MeasureHandle, Sigma, threshold,                     //設定測量參數  並且輸出測量錨點
                "all", "all", out hv_RowEdge, out hv_ColumnEdge, out hv_Amplitude, out hv_Distance);
            ho_Cross.Dispose();
            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "blue");                                       //設定顏色及型態
            HOperatorSet.SetDraw(hv_ExpDefaultWinHandle, "margin");
            HOperatorSet.GenCrossContourXld(out ho_Cross, hv_RowEdge, hv_ColumnEdge,                    //產生錨點標記十字
                Rectangle2.get_rectangle_Length2 * 2, Rectangle2.get_rectangle_Phi);
            HOperatorSet.DispObj(hv_image_c, hv_ExpDefaultWinHandle);
            HOperatorSet.DispObj(ho_Cross, hv_ExpDefaultWinHandle);
            HOperatorSet.CloseMeasure(hv_MeasureHandle);                                                //關閉測量控制器 hv_MeasureHandle
            hv_image_c.Dispose();
        }

        public void dowork(DrawlinetoRectangle2 Rectangle2, HTuple Window, int Sigma, int threshold, HObject hv_image)
        {
            hv_ExpDefaultWinHandle = Window;
            action(Rectangle2, Sigma, threshold, hv_image);

        }
        //-------------------------------輸出十字----------------------------------------------------
        public HObject get_Cross { get { return ho_Cross; } }
        public HTuple get_RowEdge { get { return hv_RowEdge; } }
        public HTuple get_ColumnEdge { get { return hv_ColumnEdge; } }
        public HTuple get_Amplitude { get { return hv_Amplitude; } }
        public HTuple get_Distance { get { return hv_Distance; } }
    }
        
}
