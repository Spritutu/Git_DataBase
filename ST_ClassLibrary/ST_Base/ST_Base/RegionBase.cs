using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    public class RegionBase
    {
        //--------------Image物件，讀寫函式---------------
        //Row X軸高度 , Column Y軸高度 , Phi 角度
        protected HTuple Row = null, Column = null;
        protected HTuple Phi = null;

        //Rectangle 邊長
        protected HTuple Length1Rectangle = null;
        protected HTuple Length2Rectangle = null;

        //Circle 半徑
        protected HTuple RadiusCircle = null;

        //Ellipse 半徑
        protected HTuple Radius1Ellipse = null, Radius2Ellipse = null;

        //line 起始點 中止點
        protected HTuple line_Row1 = null, line_Column1 = null, line_Row2 = null, line_Column2 = null, line_Distance = null;

        //ROI 範圍  
        protected HObject ROI = null;

        public void CopyRegiontoThis(HObject setRegion)//取得圖片的mean跟deviation
        {
            ROI = setRegion.Clone();
        }

        //--------------讀寫函式---------------

        //Row Column Phi
        public HTuple GetRow { get { return Row; } }
        public HTuple GetColumn { get { return Column; } }
        public HTuple GetPhi { get { return Phi; } }

        //ROIRectangle
        public HTuple GetLength1Rectangle { get { return Length1Rectangle; } }
        public HTuple GetLength2Rectangle { get { return Length2Rectangle; } }

        //ROICircle
        public HTuple GetRadiusCircle { get { return RadiusCircle; } }

        //ROIEllipse
        public HTuple GetRadius1Ellipse { get { return Radius1Ellipse; } }
        public HTuple GetRadius2Ellipse { get { return Radius2Ellipse; } }

        //ROI
        public HObject GetROI { get { return ROI; } }

        public void DrawROIline(HTuple hwindows)//方形
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);

            HOperatorSet.DrawLine(hwindows, out line_Row1, out line_Column1,                //畫線
                out line_Row2, out line_Column2);

            Row = (line_Row1 + line_Row2) / 2;                                              //線段轉換成矩形(Row、colum)
            Column = (line_Column1 + line_Column2) / 2;

            HOperatorSet.AngleLx(line_Row1, line_Column1, line_Row2, line_Column2,          //線段與垂直線的夾角為何  此角度也是矩形參數理的角度
                out Phi);

            HOperatorSet.DistancePp(line_Row1, line_Column1, line_Row2, line_Column2,       //兩點之間的距離運算
                out line_Distance);

            Length1Rectangle = line_Distance / 2;                                           //線段轉換成矩形(length1)

            HOperatorSet.GenRectangle2(out ROI, Row, Column,                                //產生一個矩形ROI區域(ho_Rectangle)
                Phi, Length1Rectangle, 0);

            HOperatorSet.DispObj(ROI, hwindows);
        }


        public void DrawROIRectangle(HTuple hwindows)//方形
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.DrawRectangle2(hwindows,
                                        out Row,
                                        out Column,
                                        out Phi,
                                        out Length1Rectangle,
                                        out Length2Rectangle);
            HOperatorSet.GenRectangle2(out ROI,
                                       Row,
                                       Column,
                                       Phi,
                                       Length1Rectangle,
                                       Length2Rectangle);
            HOperatorSet.DispObj(ROI, hwindows);
        }

        public void DrawROICircle(HTuple hwindows)//圓形
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.DrawCircle(hwindows,
                                    out Row,
                                    out Column,
                                    out RadiusCircle);
            HOperatorSet.GenCircle(out ROI,
                                   Row,
                                   Column,
                                   RadiusCircle);
            HOperatorSet.DispObj(ROI, hwindows);
        }

        public void DrawROIEllipse(HTuple hwindows)//橢圓
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.DrawEllipse(hwindows,
                                     out Row,
                                     out Column,
                                     out Phi,
                                     out Radius1Ellipse,
                                     out Radius2Ellipse);
            HOperatorSet.GenEllipse(out ROI,
                                    Row,
                                    Column,
                                    Phi,
                                    Radius1Ellipse,
                                    Radius2Ellipse);
            HOperatorSet.DispObj(ROI, hwindows);
        }


        public void setROIRectangle(HTuple hwindows, HTuple Row, HTuple Column, HTuple Phi, HTuple Length1Rectangle, HTuple Length2Rectangle)//方形
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.GenRectangle2(out ROI,
                                       Row,
                                       Column,
                                       Phi,
                                       Length1Rectangle,
                                       Length2Rectangle);
            HOperatorSet.DispObj(ROI, hwindows);
        }

        public void setROICircle(HTuple hwindows, HTuple Row, HTuple Column, HTuple RadiusCircle)//圓形
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.GenCircle(out ROI,
                                   Row,
                                   Column,
                                   RadiusCircle);
            HOperatorSet.DispObj(ROI, hwindows);
        }

        public void setROIEllipse(HTuple hwindows, HTuple Row, HTuple Column, HTuple Phi, HTuple Radius1Ellipse, HTuple Radius2Ellipse)//橢圓
        {

            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.GenEllipse(out ROI,
                                    Row,
                                    Column,
                                    Phi,
                                    Radius1Ellipse,
                                    Radius2Ellipse);
            HOperatorSet.DispObj(ROI, hwindows);
        }
        public void setROIline(HTuple hwindows, HTuple line_Row1, HTuple line_Column1, HTuple line_Row2, HTuple line_Column2)//方形
        {
            emptyallparameter();
            HOperatorSet.GenEmptyObj(out ROI);
            SetLine(hwindows, "yellow", "margin", 2);


            Row = (line_Row1 + line_Row2) / 2;                                        //線段轉換成矩形(Row、colum)
            Column = (line_Column1 + line_Column2) / 2;

            HOperatorSet.AngleLx(line_Row1, line_Column1, line_Row2, line_Column2,          //線段與垂直線的夾角為何  此角度也是矩形參數理的角度
                out Phi);

            HOperatorSet.DistancePp(line_Row1, line_Column1, line_Row2, line_Column2,       //兩點之間的距離運算
                out line_Distance);

            Length1Rectangle = line_Distance / 2;                                                //線段轉換成矩形(length1)

            HOperatorSet.GenRectangle2(out ROI, Row, Column,         //產生一個矩形ROI區域(ho_Rectangle)
                Phi, Length1Rectangle, 0);

            HOperatorSet.DispObj(ROI, hwindows);
        }

        private void SetLine(HTuple hwindows, HTuple color, HTuple Draw, HTuple LineWidth)//線條參數
        {
            HOperatorSet.SetColor(hwindows, color);
            HOperatorSet.SetDraw(hwindows, Draw);
            HOperatorSet.SetLineWidth(hwindows, LineWidth);
        }

        public void emptyallparameter()
        {
            if (ROI != null)
            {
                Row = null;
                Column = null;
                Phi = null;
                Length1Rectangle = null;
                Length2Rectangle = null;
                RadiusCircle = null;
                Radius1Ellipse = null;
                Radius2Ellipse = null;
                ROI = null;
            }
        }

        public void showROI(HTuple hwindows)
        {
            if (ROI != null)
                HOperatorSet.DispObj(ROI, hwindows);
        }
    }
}
