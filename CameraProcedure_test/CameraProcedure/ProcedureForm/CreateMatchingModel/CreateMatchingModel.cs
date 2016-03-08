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


        public HTuple Template_rot_matrix;

        public HObject CreatShapeModel;
        public HObject Reduce_Image;

        public HTuple MovementOfObject;
        public HTuple MovementOfObject1;
        public HObject ModelAtNewPosition;
        public HObject ModelAtNewPosition_temp;
        public HObject ImageAtNewPosition;
        public HObject Template_Image_rot;
        public HObject ROI_rot;


    }

    public partial class CreateMatchingModel : Form
    {

        public List<Object_Table> O_T = new List<Object_Table>();
        List<SelectImageNName> SelectImage = new List<SelectImageNName>();

        private RegionBase region_rec = new RegionBase();
        private ImageBase Template_Image = new ImageBase();
        public HObject TemplateImage { set { Template_Image.SetImage = value; } }
        private ImageBase src_Image = new ImageBase();
        public HObject SrcImage { set { src_Image.SetImage = value; } }
        private ImageBase dst_Image = new ImageBase();
        public HObject dstImage { get { return dst_Image.GetImage;  } }

        public bool setornot = false;
        bool ifopenformornot = false;
        private CreateMatchingModelParameter CMMP;


        bool loadfinish = false;

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
            if (setornot == false)
            {
                if (ifopenformornot == false)
                {
                    ifopenformornot = true;
                    SelectImage.Clear();
                    for (int i = 0; i < O_T.Count; i++)
                    {
                        for (int j = 0; j < O_T[i].OImage.Count; j++)
                        {
                            if (O_T[i].OImage[j] != null)
                            {
                                
                                SelectImageNName M1S = new SelectImageNName();
                                M1S.Image = O_T[i].OImage[j];
                                M1S.ImageName = (string)O_T[i].OImageName[j];
                                SelectImage.Add(M1S);
                            }
                        }
                    }
                    whichpicture.DataSource = null;
                    whichpicture.DataSource = SelectImage;
                    whichpicture.DisplayMember = "ImageName";
                    whichpicture.ValueMember = "Image";
                    loadfinish = true;

                    src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                    toolWindow.WindowImage = src_Image;
                    toolWindow.showImage();
                }

            }
            else if (setornot == true)
            {
                if (ifopenformornot == false)
                {
                    ifopenformornot = true;
                    toolWindow.showImage();
                    toolWindow1.showImage();
                    toolWindow2.showImage();
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
            setSystem.SetPen(toolWindow1.Window.HalconWindow,"red", "margin", 3);
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

            ImageBase show_temp = new ImageBase();

            HOperatorSet.VectorAngleToRigid(region_rec.rectangle.row, region_rec.rectangle.column, region_rec.rectangle.phi,
                Template_Image.GetHeight / 2, Template_Image.GetWidth / 2, 0, out CMMP.Template_rot_matrix);

            HOperatorSet.AffineTransImage(Template_Image.GetImage, out CMMP.Template_Image_rot,
                CMMP.Template_rot_matrix,"constant", "false");

            HOperatorSet.AffineTransRegion(region_rec.rectangle.ROI, out CMMP.ROI_rot,
                CMMP.Template_rot_matrix, "nearest_neighbor");
            
            HOperatorSet.ReduceDomain(CMMP.Template_Image_rot, CMMP.ROI_rot, out CMMP.Reduce_Image);

            HOperatorSet.ClearWindow(toolWindow1.Window.HalconWindow);
            toolWindow1.WindowImage.SetImage = CMMP.Template_Image_rot;
            toolWindow1.Add_Object_disp(CMMP.ROI_rot, "red", "margin", 3);
            toolWindow1.showImage();

            if (CMMP.CreatShapeModel != null)
            {
                CMMP.CreatModelID.TupleRemove(CMMP.CreatModelID);
                CMMP.CreatShapeModel.Dispose();
            }


            toolWindow2.Window.HalconWindow.ClearWindow();
            HOperatorSet.CreateShapeModel(CMMP.Reduce_Image, CMMP.Create_NumLevels, (CMMP.Create_AngleStart).TupleRad()
                ,(CMMP.Create_AngleExtent).TupleRad(), "auto", "none","use_polarity", CMMP.Create_Contrast, CMMP.Create_MinContrast
                ,out CMMP.CreatModelID);
            HOperatorSet.GetShapeModelContours(out CMMP.CreatShapeModel, CMMP.CreatModelID, 1);


            HOperatorSet.FindShapeModel(src_Image.GetImage, CMMP.CreatModelID, (CMMP.Find_AngleStart).TupleRad()
                , (CMMP.Find_AngleExtent).TupleRad() ,CMMP.Find_MinScore, CMMP.Find_NumMatch, CMMP.Find_MaxOverLap, "least_squares", 
                CMMP.Find_NumLevels, CMMP.Find_Greediness, out CMMP.Find_RowCheck, out CMMP.Find_ColumnCheck, 
                out CMMP.Find_AngleCheck, out CMMP.Find_Score);

            HTuple hv_I = null;


            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(CMMP.Find_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, CMMP.Find_RowCheck.TupleSelect(hv_I),
                    CMMP.Find_ColumnCheck.TupleSelect(hv_I), CMMP.Find_AngleCheck.TupleSelect(hv_I),
                    out CMMP.MovementOfObject);

                HOperatorSet.VectorAngleToRigid(CMMP.Find_RowCheck.TupleSelect(hv_I), CMMP.Find_ColumnCheck.TupleSelect(hv_I),
                    0, src_Image.GetHeight / 2 , src_Image.GetWidth / 2, -CMMP.Find_AngleCheck.TupleSelect(hv_I), out CMMP.MovementOfObject1);
                
                HOperatorSet.AffineTransContourXld(CMMP.CreatShapeModel, out CMMP.ModelAtNewPosition_temp,
                     CMMP.MovementOfObject);
                HOperatorSet.AffineTransContourXld(CMMP.ModelAtNewPosition_temp, out CMMP.ModelAtNewPosition,
                    CMMP.MovementOfObject1);

                HOperatorSet.AffineTransImage(src_Image.GetImage, out CMMP.ImageAtNewPosition,
                    CMMP.MovementOfObject1, "constant", "false");
            }

            HOperatorSet.ReduceDomain(CMMP.ImageAtNewPosition, src_Image.GetImage, out CMMP.ImageAtNewPosition);
            toolWindow2.WindowImage.SetImage = CMMP.ImageAtNewPosition;
            toolWindow2.Add_Object_disp(CMMP.ModelAtNewPosition, "yellow", "margin", 1);
            toolWindow2.Add_Object_disp(CMMP.ROI_rot, "red", "margin", 3);
            toolWindow2.showImage();
            ADDCreatDataGridView(dataGridView1);


        }

        private void ADDCreatDataGridView(DataGridView DataGridView)
        {
            DataGridView.Rows.Clear();
            DataGridViewRowCollection rows = DataGridView.Rows;
            for (int i = 0; i <= (int)((new HTuple(CMMP.Find_Score.TupleLength())) - 1); i = i + 1)
            {
                rows.Add(new Object[] { CMMP.Find_RowCheck.TupleSelect(i), CMMP.Find_ColumnCheck.TupleSelect(i),
                    CMMP.Find_AngleCheck.TupleSelect(i), CMMP.Find_Score.TupleSelect(i) });
            }
        }

        private void ShapeModel_Click(object sender, EventArgs e)
        {
            Template_Image.ImagefromFile();
            toolWindow1.WindowImage = Template_Image;
            toolWindow1.WindowImage.ShowImage_autosize(toolWindow1.Window.HalconWindow);
        }

        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage = src_Image;
                toolWindow.showImage();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            setornot = true;
            ifopenformornot = false;
            dst_Image = toolWindow2.WindowImage;
            Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setornot == true)
            {
                toolWindow.showImage();
                toolWindow1.showImage();
                toolWindow2.showImage();
            }
        }

        private void CreateMatchingModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            ifopenformornot = false;
            Hide();
        }
    }
}
