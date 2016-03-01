using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using ST_Base;

namespace CameraProcedure
{

    public struct CreateMatchingModelParameter
    {
        public HTuple Create_NumLevels;
        public HTuple Create_AngleStart;
        public HTuple Create_AngleExtent;
        public HTuple Create_Contrast;
        public HTuple Create_MinContrast;

        public HTuple Find_AngleStart;
        public HTuple Find_AngleExtent;
        public HTuple Find_MinScore;
        public HTuple Find_NumMatch;
        public HTuple Find_MaxOverLap;
        public HTuple Find_NumLevels;
        public HTuple Find_Greediness;
        public HTuple CreatModelID;

        public HTuple Find_RowCheck;
        public HTuple Find_ColumnCheck;
        public HTuple Find_AngleCheck;
        public HTuple Find_Score;
        

        public HObject CreatShapeModel;
        public HObject Reduce_Image;

        public HTuple MovementOfObject;
        public HObject ModelAtNewPosition;


    }

    public partial class CreateMatchingModel : Form
    {

        private RegionBase region_rec = new RegionBase();
        private ImageBase Template_Image = new ImageBase();
        public HObject TemplateImage { set { Template_Image.SetImage = value; } }
        
        public bool setornot = false;
        bool ifopenfromornot = true;
        private CreateMatchingModelParameter CMMP;

        public CreateMatchingModel()
        {
            InitializeComponent();
            Create_NumLevels.Text = "0";
            Create_AngleStart.Text = "0";
            Create_AngleExtent.Text = "360";
            Create_Contrast.Text = "30";
            Create_MinContrast.Text = "10";

            Find_AngleStart.Text = "0";
            Find_AngleExtent.Text = "360";
            Find_MinScore.Text = "0.6";
            Find_MaxOverLap.Text = "0";
            Find_NumMatch.Text = "3";
            Find_NumLevels.Text = "0";
            Find_Greediness.Text = "0.7";
        }

        public void run()
        {

        }

        private void CreateMatchingModel_Activated(object sender, EventArgs e)
        {
            if (ifopenfromornot)
            {
                toolWindow.WindowImage = Template_Image;
                toolWindow1.WindowImage = Template_Image;

                if (toolWindow.WindowImage != null)
                {
                    toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
                    toolWindow1.WindowImage.ShowImage_autosize(toolWindow1.Window.HalconWindow);
                }
                if (ifopenfromornot)
                {
                    ifopenfromornot = false;
                }
            }
        }

        private void Create_Default_Click(object sender, EventArgs e)
        {

            Create_NumLevels.Text = "0";
            Create_AngleStart.Text = "0";
            Create_AngleExtent.Text = "360";
            Create_Contrast.Text = "30";
            Create_MinContrast.Text = "10";
        }

        private void Find_Default_Click(object sender, EventArgs e)
        {

            Find_AngleStart.Text = "0";
            Find_AngleExtent.Text = "360";
            Find_MinScore.Text = "0.6";
            Find_NumMatch.Text = "3";
            Find_NumLevels.Text = "0";
            Find_MaxOverLap.Text = "0";
            Find_Greediness.Text = "0.7";
        }

       
        private void setROI_Click(object sender, EventArgs e)
        {
            toolWindow1.Window.Focus();
            toolWindow1.Window.HalconWindow.ClearWindow();
            toolWindow1.WindowImage.ShowImage_autosize(toolWindow1.Window.HalconWindow);
            region_rec.DrawRectangle(toolWindow1.Window.HalconWindow);
            region_rec.showROI(toolWindow1.Window.HalconWindow, (int)Shape.Rectangle, "red", "margin", 3);
        }

        private void Test_Click(object sender, EventArgs e)
        {

            HOperatorSet.GenEmptyObj(out CMMP.ModelAtNewPosition);
            CMMP.Create_NumLevels = Convert.ToInt32(Create_NumLevels.Text);
            CMMP.Create_AngleStart = Convert.ToInt32(Create_AngleStart.Text);
            CMMP.Create_AngleExtent = Convert.ToInt32(Create_AngleExtent.Text);
            CMMP.Create_Contrast = Convert.ToDouble(Create_Contrast.Text);
            CMMP.Create_MinContrast = Convert.ToDouble(Create_MinContrast.Text);

            CMMP.Find_AngleStart = Convert.ToInt32(Find_AngleStart.Text);
            CMMP.Find_AngleExtent = Convert.ToInt32(Find_AngleExtent.Text);
            CMMP.Find_MinScore = Convert.ToDouble(Find_MinScore.Text);
            CMMP.Find_MaxOverLap = Convert.ToInt32(Find_MaxOverLap.Text);
            CMMP.Find_NumMatch = Convert.ToDouble(Find_NumMatch.Text);
            CMMP.Find_NumLevels = Convert.ToInt32(Find_NumLevels.Text);
            CMMP.Find_Greediness = Convert.ToDouble(Find_Greediness.Text);

            HOperatorSet.ReduceDomain(Template_Image.GetImage, region_rec.rectangle.ROI, out CMMP.Reduce_Image);
            if (CMMP.CreatShapeModel != null)
            {
                CMMP.CreatModelID.TupleRemove(CMMP.CreatModelID);
                CMMP.CreatShapeModel.Dispose();
            }
            toolWindow1.Window.HalconWindow.ClearWindow();
            HOperatorSet.CreateShapeModel(CMMP.Reduce_Image, CMMP.Create_NumLevels, (CMMP.Create_AngleStart).TupleRad()
                ,(CMMP.Create_AngleExtent).TupleRad(), "auto", "none","use_polarity", CMMP.Create_Contrast, CMMP.Create_MinContrast
                ,out CMMP.CreatModelID);
            HOperatorSet.GetShapeModelContours(out CMMP.CreatShapeModel, CMMP.CreatModelID, 1);


            HOperatorSet.FindShapeModel(Template_Image.GetImage, CMMP.CreatModelID, (CMMP.Find_AngleStart).TupleRad()
                , (CMMP.Find_AngleExtent).TupleRad() ,CMMP.Find_MinScore, CMMP.Find_NumMatch, CMMP.Find_MaxOverLap, "least_squares", 
                CMMP.Find_NumLevels, CMMP.Find_Greediness, out CMMP.Find_RowCheck, out CMMP.Find_ColumnCheck, 
                out CMMP.Find_AngleCheck, out CMMP.Find_Score);

            HTuple hv_I = null;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(CMMP.Find_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, CMMP.Find_RowCheck.TupleSelect(hv_I),
                    CMMP.Find_ColumnCheck.TupleSelect(hv_I), CMMP.Find_AngleCheck.TupleSelect(hv_I), out CMMP.MovementOfObject);
                    CMMP.ModelAtNewPosition.Dispose();
                
                HOperatorSet.AffineTransContourXld(CMMP.CreatShapeModel, out CMMP.ModelAtNewPosition,
                    CMMP.MovementOfObject);
            }


            HOperatorSet.DispObj(Template_Image.GetImage, toolWindow1.Window.HalconWindow);
            HOperatorSet.DispObj(CMMP.ModelAtNewPosition, toolWindow1.Window.HalconWindow);
            
        }



    }
}
