using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ZQSFP_detection
{
    class DrawlinetoRectangle2
    {
        HTuple hv_ExpDefaultWinHandle = null;                                                           //要畫的視窗

        //-----------------線的兩端點及距離----------------------
        private HTuple hv_line_Row1 = null;                                                             
        private HTuple hv_line_Column1 = null;
        private HTuple hv_line_Row2 = null;
        private HTuple hv_line_Column2 = null;
        private HTuple hv_line_Distance = null;
        //----------------線轉換成矩陣的參數----------------------
        private HTuple hv_Rectangle_Row = null;                                                         
        private HTuple hv_Rectangle_Column = null;
        private HTuple hv_Rectangle_length1 = null;
        private HTuple hv_Rectangle_length2 = 0;
        private HTuple hv_Rectangle_Angle = null;
        HObject ho_Rectangle;
        HObject ho_line;
        //-------------------------------------------------------

        private void action()
        {
            HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "yellow");                                    //設定畫線的顏色及粗細
            HOperatorSet.SetDraw(hv_ExpDefaultWinHandle, "margin");
            HOperatorSet.SetLineWidth(hv_ExpDefaultWinHandle, 2);

            HOperatorSet.GenEmptyObj(out ho_Rectangle);                                                 //清空ho_Rectangle

            HOperatorSet.DrawLine(hv_ExpDefaultWinHandle, out hv_line_Row1, out hv_line_Column1,        //畫線
                out hv_line_Row2,out hv_line_Column2);

           hv_Rectangle_Row = (hv_line_Row1 + hv_line_Row2) / 2;                                        //線段轉換成矩形(Row、colum)
            hv_Rectangle_Column = (hv_line_Column1 + hv_line_Column2) / 2;

            HOperatorSet.AngleLx(hv_line_Row1, hv_line_Column1, hv_line_Row2, hv_line_Column2,          //線段與垂直線的夾角為何  此角度也是矩形參數理的角度
                out hv_Rectangle_Angle);

            HOperatorSet.DistancePp(hv_line_Row1, hv_line_Column1, hv_line_Row2, hv_line_Column2,       //兩點之間的距離運算
                out hv_line_Distance);
            
            hv_Rectangle_length1 = hv_line_Distance / 2;                                                //線段轉換成矩形(length1)

            HOperatorSet.GenRectangle2(out ho_Rectangle, hv_Rectangle_Row, hv_Rectangle_Column,         //產生一個矩形ROI區域(ho_Rectangle)
                hv_Rectangle_Angle, hv_Rectangle_length1, hv_Rectangle_length2);

            HOperatorSet.GenRegionLine(out ho_line, hv_line_Row1, hv_line_Column1, hv_line_Row2,        //產生線段
                hv_line_Column2);

            HOperatorSet.DispObj(ho_line, hv_ExpDefaultWinHandle);                                      //顯示矩形ROI(ho_Rectangle)
        }
        
        public void draw(HTuple Window)                                                                 //畫線
        {
            hv_ExpDefaultWinHandle = Window;
            action();
        }
        public void drawROI(HTuple Window)                                                              //調整參數時重新顯示調整之後的線段                                                             
        {
            hv_ExpDefaultWinHandle = Window;

            ho_Rectangle.Dispose();                                                                     //清除ho_Rectangle

            HOperatorSet.GenRectangle2(out ho_Rectangle, hv_Rectangle_Row, hv_Rectangle_Column,         //產生ho_Rectangle ROI
                hv_Rectangle_Angle, hv_Rectangle_length1, hv_Rectangle_length2);

            HOperatorSet.GenRegionLine(out ho_line, hv_line_Row1, hv_line_Column1, hv_line_Row2,        //產生線段
                hv_line_Column2);

            HOperatorSet.DispObj(ho_line, hv_ExpDefaultWinHandle);                                      //顯示線段
        }

        //--------------------輸出-----------------------------------------------------------------------
        public HTuple get_rectangle_Row { set { hv_Rectangle_Row = value; } get { return hv_Rectangle_Row; } }
        public HTuple get_rectangle_Column { set { hv_Rectangle_Column = value; } get { return hv_Rectangle_Column; } }
        public HTuple get_line_Row1 { set { hv_line_Row1 = value; } get { return hv_line_Row1; } }
        public HTuple get_line_Column1 { set { hv_line_Column1 = value; } get { return hv_line_Column1; } }
        public HTuple get_line_Row2 { set { hv_line_Row2 = value; } get { return hv_line_Row2; } }
        public HTuple get_line_Column2 { set { hv_line_Column2 = value; } get { return hv_line_Column2; } }
        public HTuple get_rectangle_Phi { set { hv_Rectangle_Angle = value; } get { return hv_Rectangle_Angle; } }
        public HTuple get_rectangle_Length1 { set { hv_Rectangle_length1 = value; } get { return hv_Rectangle_length1; } }
        public HTuple get_rectangle_Length2 { set { hv_Rectangle_length2 = value; } get { return hv_Rectangle_length2; } }
        public HObject get_rectangle_ROI { get { return ho_Rectangle; } }
        public HObject get_line_ROI { get { return ho_line; } }
    }
}
