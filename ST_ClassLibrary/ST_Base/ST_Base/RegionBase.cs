using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    public enum Shape { Rectangle, Circle, Line, Ellipse, Line_rec }
    public class Rectangle
    {
        public HTuple row;
        public HTuple column;
        public HTuple phi;
        public HTuple length1;
        public HTuple length2;
        public HObject ROI;

    }
    public class Circle
    {
        public HTuple row;
        public HTuple column;
        public HTuple radius;
        public HObject ROI;
    }
    public class Line
    {
        public HTuple row_start;
        public HTuple column_start;
        public HTuple row_end;
        public HTuple column_end;
        public HTuple distance;
        public HObject ROI;

    }
    public class Ellipse
    {
        public HTuple row;
        public HTuple column;
        public HTuple phi;
        public HTuple radius1;
        public HTuple radius2;
        public HObject ROI;
    }
    public class RegionBase
    {
        public Rectangle rectangle = new Rectangle();
        public Circle circle = new Circle();
        public Line line= new Line();
        public Rectangle line_rec = new Rectangle();
        public Ellipse ellipse = new Ellipse();


        public void ClearALL()
        {
            rectangle.column = null;
            rectangle.row = null;
            rectangle.phi = null;
            rectangle.length1 = null;
            rectangle.length2 = null;
            rectangle.ROI = null;

            circle.column = null;
            circle.row = null;
            circle.radius= null;
            circle.ROI = null;

            ellipse.column = null;
            ellipse.row = null;
            ellipse.radius1 = null;
            ellipse.radius2 = null;
            ellipse.ROI = null;

            line.row_start = null;
            line.column_start = null;
            line.row_end = null;
            line.column_end = null;
            line.ROI = null;

            line_rec.column = null;
            line_rec.row = null;
            line_rec.phi = null;
            line_rec.length1 = null;
            line_rec.length2 = null;
            line_rec.ROI = null;


        }
        public void SetPen(HTuple hwindows, HTuple color, HTuple Draw, HTuple LineWidth)//線條參數
        {
            HOperatorSet.SetColor(hwindows, color);
            HOperatorSet.SetDraw(hwindows, Draw);
            HOperatorSet.SetLineWidth(hwindows, LineWidth);
        }

        public void DrawLine(HTuple hwindows)//方形
        {
            ClearALL();
            HOperatorSet.GenEmptyObj(out line.ROI);
            
            //畫線
            HOperatorSet.DrawLine(hwindows, out line.row_start, out line.column_start, out line.row_end, out line.column_end);
            //線段轉換成矩形(Row、colum)
            line_rec.row = (line.row_start + line.row_end) / 2;                                              
            line_rec.column = (line.column_start + line.column_end) / 2;
            //線段與垂直線的夾角為何  此角度也是矩形參數理的角度
            HOperatorSet.AngleLx(line.row_start, line.column_start, line.row_end, line.column_end,          
                out line_rec.phi);
            //兩點之間的距離運算
            HOperatorSet.DistancePp(line.row_start, line.column_start, line.row_end, line.column_end,       
                out line.distance);
            //線段轉換成矩形(length1)
            line_rec.length1 = line.distance / 2;
            //產生一個矩形ROI區域(ho_Rectangle)
            HOperatorSet.GenRectangle2(out line_rec.ROI, line_rec.row, line_rec.column,
                line_rec.phi, line_rec.length1, 0);
            
        }
        public void SetLine(HTuple hwindows, HTuple row_start, HTuple column_start, HTuple row_end, HTuple column_end)//方形
        {
            ClearALL();
            line.row_start = row_start;
            line.column_start = column_end;
            line.row_start = column_start;
            line.column_end = column_end; 




            HOperatorSet.GenEmptyObj(out line.ROI);
            //線段轉換成矩形(Row、colum)
            line_rec.row = (line.row_start + line.row_end) / 2;
            line_rec.column = (line.column_start + line.column_end) / 2;
            //線段與垂直線的夾角為何  此角度也是矩形參數理的角度
            HOperatorSet.AngleLx(line.row_start, line.column_start, line.row_end, line.column_end,
                out line_rec.phi);
            //兩點之間的距離運算
            HOperatorSet.DistancePp(line.row_start, line.column_start, line.row_end, line.column_end,
                out line.distance);
            //線段轉換成矩形(length1)
            line_rec.length1 = line.distance / 2;
            //產生一個矩形ROI區域(ho_Rectangle)
            HOperatorSet.GenRectangle2(out line_rec.ROI, line_rec.row, line_rec.column,
                line_rec.phi, line_rec.length1, 0);
        }

        public void DrawCircle(HTuple hwindows)//圓形
        {
            ClearALL();
            HOperatorSet.GenEmptyObj(out circle.ROI);
            HOperatorSet.DrawCircle(hwindows,out circle.row, out circle.column, out circle.radius);
            HOperatorSet.GenCircle(out circle.ROI, circle.row, circle.column, circle.radius);
        }
        public void SetCircle(HTuple hwindows, HTuple Row, HTuple Column, HTuple RadiusCircle)//圓形
        {
            ClearALL();
            circle.row = Row;
            circle.column = Column;
            circle.radius = RadiusCircle;
            HOperatorSet.GenEmptyObj(out circle.ROI);
            HOperatorSet.GenCircle(out circle.ROI, circle.row, circle.column , circle.radius);
        }

        public void DrawRectangle(HTuple hwindows)//圓形
        {
            ClearALL();
            HOperatorSet.GenEmptyObj(out circle.ROI);
            HOperatorSet.DrawRectangle2(hwindows,out rectangle.row,out rectangle.column,out rectangle.phi,out rectangle.length1,out rectangle.length2);
            HOperatorSet.GenRectangle2(out rectangle.ROI, rectangle.row, rectangle.column,  rectangle.phi,  rectangle.length1,  rectangle.length2);
        }
        public void SetRectangle(HTuple hwindows, HTuple Row, HTuple Column, HTuple Phi, HTuple Length1 , HTuple Length2)//圓形
        {
            ClearALL();
            rectangle.row = Row;
            rectangle.column = Column;
            rectangle.phi = Phi;
            rectangle.length1 = Length1;
            rectangle.length2 = Length2;
            HOperatorSet.GenEmptyObj(out circle.ROI);
            HOperatorSet.GenRectangle2(out rectangle.ROI, rectangle.row, rectangle.column, rectangle.phi, rectangle.length1, rectangle.length2);
        }

        public void DrawEllipse(HTuple hwindows)//圓形
        {
            ClearALL();
            HOperatorSet.GenEmptyObj(out circle.ROI);
            HOperatorSet.DrawEllipse(hwindows, out ellipse.row, out ellipse.column,out ellipse.phi, out ellipse.radius1,out ellipse.radius2);
            HOperatorSet.GenEllipse(out circle.ROI,  ellipse.row,  ellipse.column,  ellipse.phi,  ellipse.radius1,  ellipse.radius2);
        }
        public void SetEillipse(HTuple hwindows, HTuple Row, HTuple Column, HTuple RadiusCircle)//圓形
        {
            ClearALL();
            circle.row = Row;
            circle.column = Column;
            circle.radius = RadiusCircle;
            HOperatorSet.GenEmptyObj(out circle.ROI);
            HOperatorSet.GenEllipse(out circle.ROI, ellipse.row, ellipse.column, ellipse.phi, ellipse.radius1, ellipse.radius2);
        }



        public void showROI(HTuple hwindows, int choose, HTuple color, HTuple Draw, HTuple LineWidth)
        {
            SetPen(hwindows, color, Draw, LineWidth);
            switch (choose) {
                case (int)Shape.Rectangle:
                    if (rectangle.ROI != null)
                        HOperatorSet.DispObj(rectangle.ROI, hwindows);
                    break;
                case (int)Shape.Circle:
                    if (circle.ROI != null)
                        HOperatorSet.DispObj(circle.ROI, hwindows);
                    break;
                case (int)Shape.Ellipse:
                    if (ellipse.ROI != null)
                        HOperatorSet.DispObj(ellipse.ROI, hwindows);
                    break;
                case (int)Shape.Line:
                    if (line.ROI != null)
                        HOperatorSet.DispObj(line.ROI, hwindows);
                    break;
                case (int)Shape.Line_rec:
                    if (line_rec.ROI != null)
                        HOperatorSet.DispObj(line_rec.ROI, hwindows);
                    break;

            }
        }




    }
}
