//---------建立、顯示 所建立的match model --------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;


namespace ST_Base
{
    public class MatchModel
    {       
        HObject ho_ModelImage = null;                                                               //Model的原始影像
        HObject ho_ImageROI = null;                                                                 //以ROI切割過後的影像
        HObject ho_ShapeModel = null;                                                               //Shape Model
        HObject ho_ModelAtNewPosition = null, ho_Matches = null, ho_RegionAffineTrans = null;                                                       
        HTuple hv_MovementOfObject = new HTuple();                                                  //轉到影像上的model的矩陣

        private HTuple hv_RowCheck = null, hv_ColumnCheck =null, hv_AngleCheck = null,              //找到匹配的中心和角度
            hv_Score = null , hv_ScaleR = null, hv_ScaleC= null, hv_Scale = null, hv_Error=null;
        private HTuple hv_ModelID = null;

        public MatchModel(){
            
        }

        public void Show(HTuple Window)                                                             //顯示找到的物件位置
        {
            HOperatorSet.SetColor(Window, "blue");                                       //設定顏色及型態
            HOperatorSet.SetDraw(Window, "margin");

            if (ho_ModelAtNewPosition!=null) {
                HOperatorSet.DispObj(ho_ModelAtNewPosition, Window);
            }
            if (ho_RegionAffineTrans != null)
            {
                HOperatorSet.DispObj(ho_RegionAffineTrans, Window);
            }
            
        }


        public void ShapeModel(RegionBase ROI, ImageBase modelImage)
        {
            HOperatorSet.ReduceDomain(modelImage.GetImage, ROI.GetROI, out ho_ImageROI);
            HOperatorSet.CreateShapeModel(ho_ImageROI, "auto", 0, (new HTuple(360)).TupleRad() ,"auto", "none", "use_polarity", "auto", "auto", out hv_ModelID);
            HOperatorSet.GetShapeModelContours(out ho_ShapeModel, hv_ModelID, 1);                               
            HOperatorSet.FindShapeModel(modelImage.GetImage, hv_ModelID, 0, (new HTuple(360)).TupleRad(), 0.6, 0, 0.5, "least_squares", 0, 0.7, out hv_RowCheck, out hv_ColumnCheck,out hv_AngleCheck, out hv_Score);
            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I),hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                HOperatorSet.AffineTransContourXld(ho_ShapeModel, out ho_ModelAtNewPosition,hv_MovementOfObject);
            }
        }

        public void AnisoShapeModel(RegionBase ROI, ImageBase modelImage)
        {
            HOperatorSet.ReduceDomain(modelImage.GetImage, ROI.GetROI, out ho_ImageROI);
            HOperatorSet.CreateAnisoShapeModel(ho_ImageROI, "auto", -0.39, 0.79, "auto",0.9, 1.1, "auto", 0.9, 1.1, "auto", "auto", "use_polarity", "auto", "auto",out hv_ModelID);
            HOperatorSet.GetShapeModelContours(out ho_ShapeModel, hv_ModelID, 1);                               
            HOperatorSet.FindAnisoShapeModel(modelImage.GetImage, hv_ModelID, 0, (new HTuple(360)).TupleRad(), 0.9, 1.1, 0.9, 1.1, 0.5, 1, 0.5, "least_squares", 0, 0.9, out hv_RowCheck,out hv_ColumnCheck, out hv_AngleCheck, out hv_ScaleR, out hv_ScaleC, out hv_Score);
            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I),hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                HOperatorSet.AffineTransContourXld(ho_ShapeModel, out ho_ModelAtNewPosition,hv_MovementOfObject);
            }
        }

        public void ScaledShapeModel(RegionBase ROI, ImageBase modelImage)
        {
            HOperatorSet.ReduceDomain(modelImage.GetImage, ROI.GetROI, out ho_ImageROI);
            HOperatorSet.CreateScaledShapeModel(ho_ImageROI, "auto", -0.39, 0.79, "auto",0.9, 1.1, "auto", "auto", "use_polarity", "auto", "auto", out hv_ModelID);
            HOperatorSet.GetShapeModelContours(out ho_ShapeModel, hv_ModelID, 1);                             
            HOperatorSet.FindScaledShapeModel(modelImage.GetImage, hv_ModelID, 0, (new HTuple(360)).TupleRad(), 0.9, 1.1, 0.5, 1, 0.5, "least_squares", 0, 0.9, out hv_RowCheck, out hv_ColumnCheck,out hv_AngleCheck, out hv_Scale, out hv_Score);
            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I),hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                HOperatorSet.AffineTransContourXld(ho_ShapeModel, out ho_ModelAtNewPosition,
                hv_MovementOfObject);
            }
        }


        public void NCCModel(RegionBase ROI, ImageBase modelImage)
        {
            HOperatorSet.ReduceDomain(modelImage.GetImage, ROI.GetROI, out ho_ImageROI);
            HOperatorSet.CreateNccModel(ho_ImageROI, "auto", 0, 0, "auto", "use_polarity",out hv_ModelID);
            HOperatorSet.FindNccModel(modelImage.GetImage, hv_ModelID, 0, 0, 0.5, 1, 0.5, "true", 0,out hv_RowCheck, out hv_ColumnCheck, out hv_AngleCheck, out hv_Score);
            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {              
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I),hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                HOperatorSet.AffineTransRegion(ROI.GetROI, out ho_RegionAffineTrans, hv_MovementOfObject, "nearest_neighbor");
            }
        }

        public void BestMatchRotMg(RegionBase ROI, ImageBase modelImage)
        {
            HOperatorSet.ReduceDomain(modelImage.GetImage, ROI.GetROI, out ho_ImageROI);
            HOperatorSet.CreateTemplateRot(ho_ImageROI, 4, -0.39, 0.79, 0.0982, "sort","original", out hv_ModelID);
            HOperatorSet.AdaptTemplate(modelImage.GetImage, hv_ModelID);
            HOperatorSet.BestMatchRotMg(modelImage.GetImage, hv_ModelID, -0.39, 0.79, 40, "false",3, out hv_RowCheck, out hv_ColumnCheck, out hv_AngleCheck, out hv_Error);

            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I), hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                HOperatorSet.AffineTransRegion(ROI.GetROI, out ho_RegionAffineTrans, hv_MovementOfObject, "nearest_neighbor");
            }
        }

        public void FastMatchMg(RegionBase ROI, ImageBase modelImage)
        {
            HOperatorSet.ReduceDomain(modelImage.GetImage, ROI.GetROI, out ho_ImageROI);
            HOperatorSet.CreateTemplate(ho_ImageROI, 255, 4, "sort", "original", out hv_ModelID);
            HOperatorSet.AdaptTemplate(modelImage.GetImage, hv_ModelID);
            HOperatorSet.FastMatchMg(modelImage.GetImage, out ho_Matches, hv_ModelID, 40, 3);

            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RowCheck.TupleSelect(hv_I), hv_ColumnCheck.TupleSelect(hv_I), hv_AngleCheck.TupleSelect(hv_I), out hv_MovementOfObject);
                HOperatorSet.AffineTransRegion(ROI.GetROI, out ho_RegionAffineTrans, hv_MovementOfObject, "nearest_neighbor");
            }
        }


        //--------------------輸出---------------------------------------
        public HTuple get_RowCheck { get { return hv_RowCheck; } }
        public HTuple get_ColumnCheck { get { return hv_ColumnCheck; } }
        public HTuple get_AngleCheck { get { return hv_AngleCheck; } }
        public HTuple get_Score { get { return hv_Score; } }
        public HTuple get_ModelID { get { return hv_ModelID; } }
        public HObject get_ShapeModel { get { return ho_ShapeModel; } }



    }
}

