using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
 
namespace ST_Base
{
    public class Matching
    {
        HObject ho_SearchImage;
        HTuple hv_RowCheck = null;
        HTuple hv_ColumnCheck = null;
        HTuple hv_AngleCheck = null;
        HTuple hv_Score = null;
        HTuple hv_MovementOfObject_contour = null;
        HObject ho_Measure_ROI_Search = null;
        HObject ho_Cross = null;
        HTuple hv_Row_Measure_Search = new HTuple();
        HTuple hv_Column_Measure_Search = new HTuple();
        HTuple hv_MeasureHandle = new HTuple();
        HTuple hv_RowEdge = new HTuple();
        HTuple hv_ColumnEdge = new HTuple();
        HTuple hv_Amplitude = new HTuple();
        HTuple hv_Distance = new HTuple();
        HTuple hv_Row_Measure_O = null;
        HTuple hv_Column_Measure_O = null;
        HTuple hv_MovementOfObject_O = null;
        HObject ho_line_show = null;
        HObject ho_ShapeModel = null;
        HObject ho_ShapeModelAtNewPosition = null;

        public void matchingNmeasure(MatchModel Model , Measure measure,ImageBase image_matchingNmeasure,RegionBase region_matchingNmeasure, RegionBase region_measure,HTuple window) {

           
            HOperatorSet.FindShapeModel(image_matchingNmeasure.GetImage, Model.get_ModelID, 0, (new HTuple(360)).TupleRad(), 0.6, 0, 0.5, "least_squares", 0, 0.7, out hv_RowCheck, out hv_ColumnCheck, out hv_AngleCheck, out hv_Score);

            HOperatorSet.GetShapeModelContours(out ho_ShapeModel, Model.get_ModelID, 1);

            HOperatorSet.VectorAngleToRigid(region_matchingNmeasure.GetRow, region_matchingNmeasure.GetColumn, 0, 0, 0, 0, out hv_MovementOfObject_O);          //計算元件ROI原點轉換到影像座標原點的矩陣為何
            HOperatorSet.AffineTransPoint2d(hv_MovementOfObject_O, region_measure.GetRow, region_measure.GetColumn,                                             //依照上面的旋轉矩陣去計算測量的矩形轉換到原點做標後的中心
                out hv_Row_Measure_O, out hv_Column_Measure_O);

            if ((int)(new HTuple((new HTuple(hv_Score.TupleLength())).TupleGreater(0.9))) != 0)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck, hv_ColumnCheck, hv_AngleCheck, out hv_MovementOfObject_contour);                          //產生旋轉矩陣(原點到匹配位置)

                HOperatorSet.AffineTransContourXld(Model.get_ShapeModel, out ho_ShapeModelAtNewPosition, hv_MovementOfObject_contour);                          //轉換Contour到匹配位置

                HOperatorSet.AffineTransPoint2d(hv_MovementOfObject_contour, hv_Row_Measure_O, hv_Column_Measure_O,                          //使用上面得到的旋轉矩陣去轉換測量矩形的中心從原點到匹配位置
                    out hv_Row_Measure_Search, out hv_Column_Measure_Search);



                HOperatorSet.GenRectangle2(out ho_Measure_ROI_Search, hv_Row_Measure_Search, hv_Column_Measure_Search,                      //產生測量ROI區域
                    hv_AngleCheck + region_measure.GetPhi, region_measure.GetLength1Rectangle,
                    region_measure.GetLength2Rectangle);

                HOperatorSet.GenRectangle2(out ho_line_show, hv_Row_Measure_Search, hv_Column_Measure_Search,                               //為了顯示而產生的Length2為零區域
                    hv_AngleCheck + region_measure.GetPhi, region_measure.GetLength1Rectangle, 0);

                HOperatorSet.GenMeasureRectangle2(hv_Row_Measure_Search, hv_Column_Measure_Search, hv_AngleCheck +                           //產生測量矩形
                    region_measure.GetPhi, region_measure.GetLength1Rectangle,region_measure.GetLength2Rectangle,
                    image_matchingNmeasure.GetWidth, image_matchingNmeasure.GetHeight, "nearest_neighbor", out hv_MeasureHandle);


                HOperatorSet.MeasurePos(image_matchingNmeasure.GetImage, hv_MeasureHandle, 1, 25, "all", "all", out hv_RowEdge, out hv_ColumnEdge,            //設定測量伐值  輸出測量錨點
                    out hv_Amplitude, out hv_Distance);

                HOperatorSet.GenCrossContourXld(out ho_Cross, hv_RowEdge, hv_ColumnEdge, 2 * region_measure.GetLength2Rectangle,             //產生十字點
                    hv_AngleCheck);

                HOperatorSet.DispObj(image_matchingNmeasure.GetImage, window); 
                HOperatorSet.DispObj(ho_ShapeModelAtNewPosition, window);
                HOperatorSet.SetColor(window, "blue");
                HOperatorSet.DispObj(ho_Cross, window);
                HOperatorSet.SetColor(window, "red");
                HOperatorSet.DispObj(ho_line_show, window);
                HOperatorSet.CloseMeasure(hv_MeasureHandle);
            }

        }


    }
}
