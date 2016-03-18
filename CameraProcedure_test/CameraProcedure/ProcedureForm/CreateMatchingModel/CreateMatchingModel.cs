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

    public partial class CreateMatchingModel : Form
    {        
        public CreateMatchingModelParameter_in CMMP_in = new CreateMatchingModelParameter_in();
        public CreateMatchingModelParameter_out CMMP_out = new CreateMatchingModelParameter_out();
        private CreateMatchingModelParameter_form CMMP_form = new CreateMatchingModelParameter_form();
        

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

            CMMP_in.Create_NumLevels = Convert.ToInt32(Create_NumLevels.Text);
            CMMP_in.Create_AngleStart = Convert.ToInt32(Create_AngleStart.Text);
            CMMP_in.Create_AngleExtent = Convert.ToInt32(Create_AngleExtent.Text);
            CMMP_in.Create_Contrast = Convert.ToDouble(Create_Contrast.Text);
            CMMP_in.Create_MinContrast = Convert.ToDouble(Create_MinContrast.Text);

            CMMP_in.Find_AngleStart = Convert.ToInt32(Find_AngleStart.Text);
            CMMP_in.Find_AngleExtent = Convert.ToInt32(Find_AngleExtent.Text);
            CMMP_in.Find_MinScore = Convert.ToDouble(Find_MinScore.Text);
            CMMP_in.Find_MaxOverLap = Convert.ToInt32(Find_MaxOverLap.Text);
            CMMP_in.Find_NumMatch = Convert.ToDouble(Find_NumMatch.Text);
            CMMP_in.Find_NumLevels = Convert.ToInt32(Find_NumLevels.Text);
            CMMP_in.Find_Greediness = Convert.ToDouble(Find_Greediness.Text);
        }

        private void CreateMatchingModel_Activated(object sender, EventArgs e)
        {
            //判斷是否已經開啟視窗
            if (CMMP_form.ifopenformornot == false)
            {
                //進來表示已經開啟，並且更改狀態。
                CMMP_form.ifopenformornot = true;
                //清除SelectImage表單。
                CMMP_form.SelectImage.Clear();
                //載入O_T至表單裡(OImage)
                for (int i = 0; i < CMMP_in.O_T.Count - 1; i++)
                {
                    for (int j = 0; j < CMMP_in.O_T[i].OImage.Count; j++)
                    {
                        if (CMMP_in.O_T[i].OImage[j] != null)
                        {
                            SelectImageNName M1S = new SelectImageNName();
                            M1S.Image = CMMP_in.O_T[i].OImage[j];
                            M1S.ImageName = (string)CMMP_in.O_T[i].OImageName[j];
                            CMMP_form.SelectImage.Add(M1S);
                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            CMMP_form.index.Add(ij_temp);
                        }
                    }
                }
                whichpicture.DataSource = null;
                whichpicture.DataSource = CMMP_form.SelectImage;
                whichpicture.DisplayMember = "ImageName";
                whichpicture.ValueMember = "Image";
                CMMP_form.loadfinish = true;

                CMMP_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage = CMMP_form.src_Image;
                tabControl1.SelectedTab = tabPage1;
            }
            if (toolWindow.WindowImage.GetImage != null)
                toolWindow.showImage();
            if (toolWindow1.WindowImage.GetImage != null)
                toolWindow1.showImage();
            if (toolWindow2.WindowImage.GetImage != null)
                toolWindow2.showImage();
        }

        public void run()
        {
            CMMP_form.src_Image.SetImage = CMMP_in.O_T[CMMP_form.index[whichpicture.SelectedIndex].i].OImage[CMMP_form.index[whichpicture.SelectedIndex].j];

            HOperatorSet.FindShapeModel(CMMP_form.src_Image.GetImage, CMMP_form.CreatModelID, (CMMP_in.Find_AngleStart).TupleRad()
                , (CMMP_in.Find_AngleExtent).TupleRad(), CMMP_in.Find_MinScore, CMMP_in.Find_NumMatch, CMMP_in.Find_MaxOverLap, "least_squares",
                CMMP_in.Find_NumLevels, CMMP_in.Find_Greediness, out CMMP_form.Find_RowCheck, out CMMP_form.Find_ColumnCheck,
                out CMMP_form.Find_AngleCheck, out CMMP_form.Find_Score);

           for (HTuple hv_I = 0; (int)hv_I <= (int)((new HTuple(CMMP_form.Find_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
           {
                HOperatorSet.VectorAngleToRigid(0, 0, 0, CMMP_form.Find_RowCheck.TupleSelect(hv_I),
                    CMMP_form.Find_ColumnCheck.TupleSelect(hv_I), CMMP_form.Find_AngleCheck.TupleSelect(hv_I),
                    out CMMP_form.matrix_OtoObject);

                HOperatorSet.VectorAngleToRigid(CMMP_form.Find_RowCheck.TupleSelect(hv_I), CMMP_form.Find_ColumnCheck.TupleSelect(hv_I),
                    0, CMMP_form.src_Image.GetHeight / 2, CMMP_form.src_Image.GetWidth / 2, -CMMP_form.Find_AngleCheck.TupleSelect(hv_I), out CMMP_form.matrix_ObjecttoCenter);

                HOperatorSet.AffineTransContourXld(CMMP_form.CreatShapeModel, out CMMP_form.ModelAtNewPosition_temp,
                     CMMP_form.matrix_OtoObject);
                HOperatorSet.AffineTransContourXld(CMMP_form.ModelAtNewPosition_temp, out CMMP_form.ModelAtNewPosition,
                    CMMP_form.matrix_ObjecttoCenter);

                HOperatorSet.AffineTransImage(CMMP_form.src_Image.GetImage, out CMMP_form.ImageAtNewPosition,
                    CMMP_form.matrix_ObjecttoCenter, "constant", "false");
            }

            HOperatorSet.ReduceDomain(CMMP_form.ImageAtNewPosition, CMMP_form.src_Image.GetImage, out CMMP_form.ImageAtNewPosition);
            CMMP_out.dst_Image.SetImage = CMMP_form.ImageAtNewPosition;
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
            CMMP_in.region_rec.DrawRectangle(toolWindow1.Window.HalconWindow);
            CMMP_in.region_rec.showROI(toolWindow1.Window.HalconWindow, (int)Shape.Rectangle, "red", "margin", 3);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //HOperatorSet.GenEmptyObj();

            CMMP_in.Create_NumLevels = Convert.ToInt32(Create_NumLevels.Text);
            CMMP_in.Create_AngleStart = Convert.ToInt32(Create_AngleStart.Text);
            CMMP_in.Create_AngleExtent = Convert.ToInt32(Create_AngleExtent.Text);
            CMMP_in.Create_Contrast = Convert.ToDouble(Create_Contrast.Text);
            CMMP_in.Create_MinContrast = Convert.ToDouble(Create_MinContrast.Text);

            CMMP_in.Find_AngleStart = Convert.ToInt32(Find_AngleStart.Text);
            CMMP_in.Find_AngleExtent = Convert.ToInt32(Find_AngleExtent.Text);
            CMMP_in.Find_MinScore = Convert.ToDouble(Find_MinScore.Text);
            CMMP_in.Find_MaxOverLap = Convert.ToInt32(Find_MaxOverLap.Text);
            CMMP_in.Find_NumMatch = Convert.ToDouble(Find_NumMatch.Text);
            CMMP_in.Find_NumLevels = Convert.ToInt32(Find_NumLevels.Text);
            CMMP_in.Find_Greediness = Convert.ToDouble(Find_Greediness.Text);

            //產生轉換矩陣(畫的ROI轉換至Template_Image中央)
            HOperatorSet.VectorAngleToRigid(CMMP_in.region_rec.rectangle.row, CMMP_in.region_rec.rectangle.column, CMMP_in.region_rec.rectangle.phi,
                CMMP_in.Template_Image.GetHeight / 2, CMMP_in.Template_Image.GetWidth / 2, 0, out CMMP_form.Template_rot_matrix);
            //以轉換矩陣轉換(Template_Image->Template_Image_rot)
            HOperatorSet.AffineTransImage(CMMP_in.Template_Image.GetImage, out CMMP_form.Template_Image_rot,
                CMMP_form.Template_rot_matrix,"constant", "false");
            //以轉換矩陣轉換(ROI->ROI_rot)
            HOperatorSet.AffineTransRegion(CMMP_in.region_rec.rectangle.ROI, out CMMP_form.ROI_rot,
                CMMP_form.Template_rot_matrix, "nearest_neighbor");
            //以ROI_rot切割Template_Image_rot
            HOperatorSet.ReduceDomain(CMMP_form.Template_Image_rot, CMMP_form.ROI_rot, out CMMP_form.Reduce_Image);
            //HOperatorSet.ReduceDomain(CMMP_form.Template_Image_rot, CMMP_in.Template_Image.GetImage, out CMMP_form.Template_Image_rot);

            //顯示在toolWindow1 (Template_Image_rot、ROI_rot)
            toolWindow1.Window.HalconWindow.ClearWindow();
            toolWindow1.WindowImage.SetImage = CMMP_form.Template_Image_rot;
            toolWindow1.Add_Object_disp(CMMP_form.ROI_rot, "red", "margin", 3);
            toolWindow1.showImage();

            //清空CreatShapeModel和CreatModelID  (除了第一次)
            if (CMMP_form.CreatShapeModel != null)
            {
                CMMP_form.CreatModelID.TupleRemove(CMMP_form.CreatModelID);
                CMMP_form.CreatShapeModel.Dispose();
            }


            //創建CreatModelID
            HOperatorSet.CreateShapeModel(CMMP_form.Reduce_Image, CMMP_in.Create_NumLevels, (CMMP_in.Create_AngleStart).TupleRad()
                ,(CMMP_in.Create_AngleExtent).TupleRad(), "auto", "none","use_polarity", CMMP_in.Create_Contrast, CMMP_in.Create_MinContrast
                ,out CMMP_form.CreatModelID);
            //產生Contours (CreatShapeModel)
            HOperatorSet.GetShapeModelContours(out CMMP_form.CreatShapeModel, CMMP_form.CreatModelID, 1);

            //尋找src_Image裡的匹配物件
            HOperatorSet.FindShapeModel(CMMP_form.src_Image.GetImage, CMMP_form.CreatModelID, (CMMP_in.Find_AngleStart).TupleRad()
                , (CMMP_in.Find_AngleExtent).TupleRad() , CMMP_in.Find_MinScore, CMMP_in.Find_NumMatch, CMMP_in.Find_MaxOverLap, "least_squares",
                CMMP_in.Find_NumLevels, CMMP_in.Find_Greediness, out CMMP_form.Find_RowCheck, out CMMP_form.Find_ColumnCheck, 
                out CMMP_form.Find_AngleCheck, out CMMP_form.Find_Score);

            //hv_I 代表有幾個物件被找到 
            for (HTuple hv_I = 0; (int)hv_I <= (int)((new HTuple(CMMP_form.Find_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                //產生轉換原點的Contour到他對應的物件位置的矩陣
                HOperatorSet.VectorAngleToRigid(0, 0, 0, CMMP_form.Find_RowCheck.TupleSelect(hv_I),
                    CMMP_form.Find_ColumnCheck.TupleSelect(hv_I), CMMP_form.Find_AngleCheck.TupleSelect(hv_I),
                    out CMMP_form.matrix_OtoObject); 
                //物件位置轉換至影像視窗中心
                HOperatorSet.VectorAngleToRigid(CMMP_form.Find_RowCheck.TupleSelect(hv_I), CMMP_form.Find_ColumnCheck.TupleSelect(hv_I),
                    0, CMMP_form.src_Image.GetHeight / 2 , CMMP_form.src_Image.GetWidth / 2, -CMMP_form.Find_AngleCheck.TupleSelect(hv_I), out CMMP_form.matrix_ObjecttoCenter);
                //從原點轉換Contour到對應物件位置
                HOperatorSet.AffineTransContourXld(CMMP_form.CreatShapeModel, out CMMP_form.ModelAtNewPosition_temp,
                     CMMP_form.matrix_OtoObject);
                //從物件位置轉換Contour到影像視窗中心
                HOperatorSet.AffineTransContourXld(CMMP_form.ModelAtNewPosition_temp, out CMMP_form.ModelAtNewPosition,
                    CMMP_form.matrix_ObjecttoCenter);
                //轉換影像(物件)至影像視窗中心
                HOperatorSet.AffineTransImage(CMMP_form.src_Image.GetImage, out CMMP_form.ImageAtNewPosition,
                    CMMP_form.matrix_ObjecttoCenter, "constant", "false");
            }
            
            //顯示ImageAtNewPosition、ModelAtNewPosition和ROI_rot 至toolWindow2視窗
            toolWindow2.Window.HalconWindow.ClearWindow();
            toolWindow2.WindowImage.SetImage = CMMP_form.ImageAtNewPosition;
            toolWindow2.Add_Object_disp(CMMP_form.ModelAtNewPosition, "yellow", "margin", 1);
            toolWindow2.Add_Object_disp(CMMP_form.ROI_rot, "red", "margin", 3);
            toolWindow2.showImage();
            ADDCreatDataGridView(dataGridView1);

        }

        private void ADDCreatDataGridView(DataGridView DataGridView)
        {
            DataGridView.Rows.Clear();
            DataGridViewRowCollection rows = DataGridView.Rows;
            for (int i = 0; i <= (int)((new HTuple(CMMP_form.Find_Score.TupleLength())) - 1); i = i + 1)
            {
                rows.Add(new Object[] { CMMP_form.Find_RowCheck.TupleSelect(i), CMMP_form.Find_ColumnCheck.TupleSelect(i),
                    CMMP_form.Find_AngleCheck.TupleSelect(i), CMMP_form.Find_Score.TupleSelect(i) });
            }
        }

        private void ShapeModel_Click(object sender, EventArgs e)
        {
            CMMP_in.Template_Image.ImagefromFile();
            toolWindow1.WindowImage.SetImage = CMMP_in.Template_Image.GetImage;
            toolWindow1.showImage();
        }

        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CMMP_form.loadfinish)
            {
                CMMP_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                CMMP_form.src_Image.GetImageSize();
                toolWindow.WindowImage.SetImage = CMMP_form.src_Image.GetImage;
                toolWindow.showImage();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            CMMP_out.setornot = true;
            CMMP_form.ifopenformornot = false;
            CMMP_form.loadfinish = false;
            CMMP_out.dst_Image.SetImage = toolWindow2.WindowImage.GetImage;
            Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMMP_out.setornot == true)
            {
                toolWindow.showImage();
                toolWindow1.showImage();
                toolWindow2.showImage();
            }
        }
        private void ClearAllToolWindow()
        {
            toolWindow.ClearAll();
            toolWindow1.ClearAll();
            toolWindow2.ClearAll();
        }
        private void CreateMatchingModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CMMP_out.setornot)
            {
                CMMP_form.ClearAll();
                ClearAllToolWindow();
                dataGridView1.Rows.Clear();
            }

            CMMP_form.ifopenformornot = false;
            CMMP_form.loadfinish = false;
            Hide();
        }
    }
}
