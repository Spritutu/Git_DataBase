//---------建立、顯示 所建立的match model --------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace ZQSFP_detection
{
    class MatchModel
    {

        public HTuple hv_ExpDefaultWinHandle;
        DrawRectangle2 DR2 = new DrawRectangle2();
        int NUM;

        HObject ho_ModelImage = null;                                                               //Model的原始影像
        HObject ho_ImageROI = null;                                                                 //以ROI切割過後的影像
        //----------------------------------------------------------------------------------------------------------------------
        //HObject ho_ShapeModelImages = null;                                                       //由ROI建立的Model影像
        //HObject ho_ShapeModelRegions = null;                                                      //由ROI建立的Model Regions
        //HTuple hv_AreaModelRegions = null, hv_RowModelRegions = null;
        //HTuple hv_ColumnModelRegions = null, hv_HeightPyramid = null;
        //HObject ho_SearchImage = null;                                                            //要匹配的影像
        //----------------------------------------------------------------------------------------------------------------------
        HObject ho_ShapeModel = null;                                                               //Shape Model
        HObject ho_ModelAtNewPosition = null;                                                       
        HTuple hv_MovementOfObject = new HTuple();                                                  //轉到影像上的model的矩陣

        private HTuple hv_RowCheck = null, hv_ColumnCheck =null, hv_AngleCheck = null,              //找到匹配的中心和角度
            hv_Score = null;
        private HTuple hv_ModelID = null;                                                           //建立出的model ID

        private void action(HObject ho_ROI, HObject modelImage, int num)                                     //輸入 ROI區域以及要model的原始影像
        {
            HOperatorSet.GenEmptyObj(out ho_ModelImage);                                            
            HOperatorSet.GenEmptyObj(out ho_ImageROI);
            HOperatorSet.GenEmptyObj(out ho_ShapeModel);
            HOperatorSet.GenEmptyObj(out ho_ModelAtNewPosition);

            NUM = num;
            HOperatorSet.ReduceDomain(modelImage, ho_ROI, out ho_ImageROI);
            //------------------金字塔-------------------------------------------
            //HOperatorSet.GenEmptyObj(out ho_ShapeModelImages);
            //HOperatorSet.GenEmptyObj(out ho_ShapeModelRegions);
            //HOperatorSet.InspectShapeModel(ho_ImageROI, out ho_ShapeModelImages, 
            //    out ho_ShapeModelRegions,8, 30);
            //HOperatorSet.AreaCenter(ho_ShapeModelRegions, out hv_AreaModelRegions, 
            //    out hv_RowModelRegions,out hv_ColumnModelRegions);
            //HOperatorSet.CountObj(ho_ShapeModelRegions, out hv_HeightPyramid);
            //------------------金字塔-------------------------------------------
            ho_ShapeModel.Dispose();
            if (num == 1){
                HOperatorSet.CreateShapeModel(ho_ImageROI, "auto", 0, (new HTuple(360)).TupleRad()      //CreateShapeModel
                    , "auto", "none", "use_polarity", "auto", "auto", out hv_ModelID);
                HOperatorSet.GetShapeModelContours(out ho_ShapeModel, hv_ModelID, 1);                   //GetShapeModelContours
            }

            else if(num == 2)
            {
                HOperatorSet.CreateNccModel(ho_ImageROI, "auto", 0, 0, "auto", "use_polarity",
                    out hv_ModelID);
            }
            



            

            if (num == 1)
            {
                HOperatorSet.FindShapeModel(modelImage, hv_ModelID, 0, (new HTuple(360)).TupleRad()     //FindShapeModel
                , 0.6, 0, 0.5, "least_squares", 0, 0.7, out hv_RowCheck, out hv_ColumnCheck,
                out hv_AngleCheck, out hv_Score);
            }
            else if (num == 2)
            {
                HOperatorSet.FindNccModel(modelImage, hv_ModelID, 0, 0, 0.5, 1, 0.5, "true", 0,
                out hv_RowCheck, out hv_ColumnCheck, out hv_AngleCheck, out hv_Score);
            }

            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I), 
                    hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                ho_ModelAtNewPosition.Dispose();
                if (num == 1)
                {
                    HOperatorSet.AffineTransContourXld(ho_ShapeModel, out ho_ModelAtNewPosition,
                    hv_MovementOfObject);
                }
            }
        }
        
        public void match(HObject ho_ROI, HObject machtingImage, int num)                                    //開始匹配
        {
            action(ho_ROI, machtingImage, num);
        }

        public void Show(HTuple Window)                                                             //顯示找到的物件位置
        {
            hv_ExpDefaultWinHandle = Window;
            if (NUM == 1)
            {
                HOperatorSet.DispObj(ho_ModelAtNewPosition, hv_ExpDefaultWinHandle);
            }

        }


        //--------------------輸出---------------------------------------
        public HTuple get_Row { get { return hv_RowCheck; } }
        public HTuple get_Column { get { return hv_ColumnCheck; } }
        public HTuple get_Angle { get { return hv_AngleCheck; } }
        public HTuple get_Score { get { return hv_Score; } }
        public HTuple get_ModelID { get { return hv_ModelID; } }
        public HObject get_ShapeModel { get { return ho_ShapeModel; } }
    }
}

