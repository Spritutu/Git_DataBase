using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;

namespace CameraProcedure
{
    public class CreateMatchingModelParameter_form
    {
        public HTuple CreatModelID;
        public HTuple Find_RowCheck;
        public HTuple Find_ColumnCheck;
        public HTuple Find_AngleCheck;
        public HTuple Find_Score;
        public HTuple Template_rot_matrix;
        public HTuple matrix_OtoObject;
        public HTuple matrix_ObjecttoCenter;

        public HObject Reduce_Image;
        public HObject CreatShapeModel;
        public HObject ModelAtNewPosition;
        public HObject ModelAtNewPosition_temp;
        public HObject ImageAtNewPosition;
        public HObject Template_Image_rot;
        public HObject ROI_rot;

        public List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        public ImageBase src_Image = new ImageBase();
        public List<index_ij> index = new List<index_ij>();
        public bool ifopenformornot = false;
        public bool loadfinish = false;

        public void ClearAll() {

            CreatModelID = null; 
            Find_RowCheck = null;
            Find_ColumnCheck = null;
            Find_AngleCheck = null;
            Find_Score = null;
            Template_rot_matrix = null;
            matrix_OtoObject = null;
            matrix_ObjecttoCenter = null;

            Reduce_Image.Dispose() ;
            CreatShapeModel.Dispose();
            ModelAtNewPosition.Dispose();
            ModelAtNewPosition_temp.Dispose();
            ImageAtNewPosition.Dispose();
            Template_Image_rot.Dispose();
            ROI_rot.Dispose();

            SelectImage.Clear();
            index.Clear();
            src_Image.SetImage = null;

        }
    }
}
