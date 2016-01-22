using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
 
namespace ZQSFP_detection
{
    class findobjectNmesure
    {
        HObject ho_SearchImage;
        HTuple hv_ExpDefaultWinHandle;
        HTuple hv_RowCheck = null;
        HTuple hv_ColumnCheck = null;
        HTuple hv_AngleCheck = null;
        HTuple hv_Score = null;
        HTuple hv_MovementOfObject_contour = null;
        HObject ho_ShapeModelAtNewPosition = null;
        HObject ho_Measure_ROI_Search = null;
        HObject ho_Cross = null;
        HTuple hv_Row_Measure_Search = new HTuple();
        HTuple hv_Column_Measure_Search = new HTuple();
        HTuple hv_MeasureHandle = new HTuple();
        HTuple hv_RowEdge = new HTuple();
        HTuple hv_ColumnEdge = new HTuple();
        HTuple hv_Amplitude = new HTuple();
        HTuple hv_Distance = new HTuple();

        HTuple ho_width = null;
        HTuple ho_hight = null;
        HTuple hv_Row_Measure_O = null;
        HTuple hv_Column_Measure_O = null;
        HTuple hv_MovementOfObject_O = null;
        

        HObject ho_line_show = null;

        private void action(MatchModel matching, Measure measureWindow, DrawRectangle2 drawRectangle,int num_picture,int num)
        {
            HOperatorSet.ReadImage(out ho_SearchImage, "C:/Users/User/Desktop/ZQSFP_ detection_編輯中/ZQSFP_ detection/" + num_picture);             //載入圖片

            //HOperatorSet.FindShapeModel(ho_SearchImage, matching.get_ModelID, 0, (new HTuple(360)).TupleRad()                               //找尋模型物件
            //, 0.7, 1, 0.5, "least_squares", 0, 0.7, out hv_RowCheck, out hv_ColumnCheck,
            //out hv_AngleCheck, out hv_Score);




            if (num == 1)
            {
                HOperatorSet.FindShapeModel(ho_SearchImage, matching.get_ModelID, 0, (new HTuple(360)).TupleRad()     //FindShapeModel
                , 0.6, 0, 0.5, "least_squares", 0, 0.7, out hv_RowCheck, out hv_ColumnCheck,
                out hv_AngleCheck, out hv_Score);
            }
            else if (num == 2)
            {
                HOperatorSet.FindNccModel(ho_SearchImage, matching.get_ModelID, 0, 0, 0.5, 1, 0.5, "true", 0,
                out hv_RowCheck, out hv_ColumnCheck, out hv_AngleCheck, out hv_Score);
            }


            HOperatorSet.GetImageSize(ho_SearchImage, out ho_width, out ho_hight);                                                          //取得測量影像長寬

            HOperatorSet.VectorAngleToRigid(drawRectangle.get_Row, drawRectangle.get_Column, 0, 0, 0, 0, out hv_MovementOfObject_O);        //計算元件ROI原點轉換到影像座標原點的矩陣為何
            HOperatorSet.AffineTransPoint2d(hv_MovementOfObject_O, measureWindow.get_rectangle_Row, measureWindow.get_rectangle_Column,     //依照上面的旋轉矩陣去計算測量的矩形轉換到原點做標後的中心
                out hv_Row_Measure_O, out hv_Column_Measure_O);
            
            if ((int)(new HTuple((new HTuple(hv_Score.TupleLength())).TupleGreater(0.9))) != 0)                                         
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck, hv_ColumnCheck, hv_AngleCheck,out hv_MovementOfObject_contour);       //產生旋轉矩陣(原點到匹配位置)
                if(num==1)
                    HOperatorSet.AffineTransContourXld(matching.get_ShapeModel, out ho_ShapeModelAtNewPosition,hv_MovementOfObject_contour);    //轉換Contour到匹配位置

                HOperatorSet.AffineTransPoint2d(hv_MovementOfObject_contour, hv_Row_Measure_O,hv_Column_Measure_O,                          //使用上面得到的旋轉矩陣去轉換測量矩形的中心從原點到匹配位置
                    out hv_Row_Measure_Search, out hv_Column_Measure_Search);

                HOperatorSet.GenRectangle2(out ho_Measure_ROI_Search, hv_Row_Measure_Search, hv_Column_Measure_Search,                      //產生測量ROI區域
                    hv_AngleCheck + measureWindow.get_rectangle_Phi, measureWindow.get_rectangle_Length1, 
                    measureWindow.get_rectangle_Length2);

                HOperatorSet.GenRectangle2(out ho_line_show, hv_Row_Measure_Search, hv_Column_Measure_Search,                               //為了顯示而產生的Length2為零區域
                    hv_AngleCheck + measureWindow.get_rectangle_Phi, measureWindow.get_rectangle_Length1, 0);

                HOperatorSet.GenMeasureRectangle2(hv_Row_Measure_Search, hv_Column_Measure_Search,hv_AngleCheck +                           //產生測量矩形
                    measureWindow.get_rectangle_Phi, measureWindow.get_rectangle_Length1, measureWindow.get_rectangle_Length2, 
                    ho_width, ho_hight, "nearest_neighbor", out hv_MeasureHandle);


                HOperatorSet.MeasurePos(ho_SearchImage, hv_MeasureHandle, 1, 25, "all","all", out hv_RowEdge, out hv_ColumnEdge,            //設定測量伐值  輸出測量錨點
                    out hv_Amplitude, out hv_Distance);

                HOperatorSet.GenCrossContourXld(out ho_Cross, hv_RowEdge, hv_ColumnEdge,2* measureWindow.get_rectangle_Length2,             //產生十字點
                    hv_AngleCheck); 

                HOperatorSet.DispObj(ho_SearchImage, hv_ExpDefaultWinHandle);

                HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "red");

                if(num==1)
                    HOperatorSet.DispObj(ho_ShapeModelAtNewPosition, hv_ExpDefaultWinHandle);

                HOperatorSet.SetColor(hv_ExpDefaultWinHandle, "blue");
                HOperatorSet.DispObj(ho_Cross, hv_ExpDefaultWinHandle);
                HOperatorSet.DispObj(ho_line_show, hv_ExpDefaultWinHandle);
                HOperatorSet.CloseMeasure(hv_MeasureHandle);       
            }
        }

        public void RunHalcon(HTuple Window, MatchModel matching,Measure measureWindow,DrawRectangle2 drawRectangle,int num_picture, int num)
        {
            hv_ExpDefaultWinHandle = Window;
            action(matching,  measureWindow,  drawRectangle, num_picture, num);
        }



    }
}
