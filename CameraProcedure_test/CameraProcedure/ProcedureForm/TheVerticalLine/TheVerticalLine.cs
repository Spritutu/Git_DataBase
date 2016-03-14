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
    public struct TheVerticalLineParameter
    {
        public HTuple hv_Center_row, hv_Center_col, hv_first_row, hv_Second_row, hv_first_col, hv_Second_col;
        public HTuple hv_m, hv_row1, hv_col1, hv_row2, hv_col2;

        public HObject ho_Cross_center, ho_Cross_firstpoint, ho_Cross_secondpoint , ho_RegionLines;
    }
    public partial class TheVerticalLine : Form
    {

        public bool setornot = false;
        bool ifopenformornot = false;
        public List<Object_Table> O_T = new List<Object_Table>();
        List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        List<SelectPointNName> SelectPoint1 = new List<SelectPointNName>();
        List<SelectPointNName> SelectPoint2 = new List<SelectPointNName>();

        TheVerticalLineParameter TVL = new TheVerticalLineParameter();

        private ImageBase src_Image = new ImageBase();
        public HObject SrcImage { set { src_Image.SetImage = value; } }
        private PointBase src_Point1 = new PointBase();
        public PointBase SrcPoint1 { set { src_Point1 = value; } }
        private PointBase src_Point2 = new PointBase();
        public PointBase SrcPoint2 { set { src_Point2 = value; } }

        private Line dst_Line = new Line();
        public Line DstLine { get { return dst_Line; } }

        bool loadfinish = false;

        List<index_ij> index_img = new List<index_ij>();
        List<index_ij> index_P1 = new List<index_ij>();
        List<index_ij> index_C1 = new List<index_ij>();
        List<index_ij> index_P2 = new List<index_ij>();
        List<index_ij> index_C2 = new List<index_ij>();


        


        public TheVerticalLine()
        {
            InitializeComponent();
        }

        private void TheVerticalLine_Activated(object sender, EventArgs e)
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

                                index_ij ij_temp = new index_ij();
                                ij_temp.i = i;
                                ij_temp.j = j;
                                index_img.Add(ij_temp);
                            }
                        }
                    }
                    whichpicture.DataSource = null;
                    whichpicture.DataSource = SelectImage;
                    whichpicture.DisplayMember = "ImageName";
                    whichpicture.ValueMember = "Image";


                    for (int i = 0; i < O_T.Count; i++)
                    {
                        for (int j = 0; j < O_T[i].OPoint.Count; j++)
                        {
                            if (O_T[i].OPoint[j]!=null)
                            {
                                SelectPointNName SPNN = new SelectPointNName();
                                SPNN.Point = O_T[i].OPoint[j];
                                SPNN.PointName = (string)O_T[i].OPointName[j];
                                SPNN.circleorpoint = 0;
                                SelectPoint1.Add(SPNN);

                                index_ij ij_temp = new index_ij();
                                ij_temp.i = i;
                                ij_temp.j = j;
                                index_P1.Add(ij_temp);
                            }
                        }
                    }

                    for (int i = 0; i < O_T.Count; i++)
                    {
                        for (int j = 0; j < O_T[i].OCircle.Count; j++)
                        {
                            if (O_T[i].OCircle[j] != null)
                            {
                                SelectPointNName SPNN = new SelectPointNName();
                                PointBase P_temp = new PointBase();
                                P_temp.row = O_T[i].OCircle[j].row;
                                P_temp.col = O_T[i].OCircle[j].column;
                                SPNN.Point = P_temp;
                                SPNN.PointName = O_T[i].OCircleName[j];
                                SPNN.circleorpoint = 1;
                                SelectPoint1.Add(SPNN);

                                index_ij ij_temp = new index_ij();
                                ij_temp.i = i;
                                ij_temp.j = j;
                                index_C1.Add(ij_temp);
                            }
                        }
                    }
                    whichpoint1.DataSource = null;
                    whichpoint1.DataSource = SelectPoint1;
                    whichpoint1.DisplayMember = "PointName";
                    whichpoint1.ValueMember = "Point";



                    for (int i = 0; i < O_T.Count; i++)
                    {
                        for (int j = 0; j < O_T[i].OPoint.Count; j++)
                        {
                            if (O_T[i].OPoint[j] != null)
                            {
                                SelectPointNName SPNN = new SelectPointNName();
                                SPNN.Point = O_T[i].OPoint[j];
                                SPNN.PointName = (string)O_T[i].OPointName[j];
                                SPNN.circleorpoint = 0;
                                SelectPoint2.Add(SPNN);

                                index_ij ij_temp = new index_ij();
                                ij_temp.i = i;
                                ij_temp.j = j;
                                index_P2.Add(ij_temp);
                            }
                        }
                    }

                    for (int i = 0; i < O_T.Count; i++)
                    {
                        for (int j = 0; j < O_T[i].OCircle.Count; j++)
                        {
                            if (O_T[i].OCircle[j] != null)
                            {
                                SelectPointNName SPNN = new SelectPointNName();
                                PointBase P_temp = new PointBase();
                                P_temp.row = O_T[i].OCircle[j].row;
                                P_temp.col = O_T[i].OCircle[j].column;
                                SPNN.Point = P_temp;
                                SPNN.PointName = O_T[i].OCircleName[j];
                                SPNN.circleorpoint = 1;
                                SelectPoint2.Add(SPNN);

                                index_ij ij_temp = new index_ij();
                                ij_temp.i = i;
                                ij_temp.j = j;
                                index_C2.Add(ij_temp);
                            }
                        }
                    }
                    whichpoint2.DataSource = null;
                    whichpoint2.DataSource = SelectPoint2;
                    whichpoint2.DisplayMember = "PointName";
                    whichpoint2.ValueMember = "Point";

                    loadfinish = true;

                    toolWindow.Clear_Object_disp();

                    src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                    PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                    PointBase temp2 = (PointBase)whichpoint2.SelectedValue;
                    TVL.hv_first_row = temp1.row;
                    TVL.hv_first_col = temp1.col;
                    TVL.hv_Second_row = temp2.row;
                    TVL.hv_Second_col = temp2.col;
                    HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_firstpoint, TVL.hv_first_row, TVL.hv_first_col, 10, 0);
                    HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_secondpoint, TVL.hv_Second_row, TVL.hv_Second_col, 10, 0);


                    toolWindow.Add_Object_disp(TVL.ho_Cross_firstpoint, "red", "margin", 3);
                    toolWindow.Add_Object_disp(TVL.ho_Cross_secondpoint, "blue", "margin", 3);
                    toolWindow.WindowImage.CopyImagetoThis(src_Image.GetImage);
                    toolWindow1.WindowImage.CopyImagetoThis(src_Image.GetImage);

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
                }
            }
            
        }

        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage.CopyImagetoThis(src_Image.GetImage);
                toolWindow.showImage();
            }
        }

        private void whichpoint_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                toolWindow.Clear_Object_disp();
                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                TVL.hv_first_row = temp1.row;
                TVL.hv_first_col = temp1.col;
                HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_firstpoint, TVL.hv_first_row, TVL.hv_first_col, 10, 0);
                toolWindow.Add_Object_disp(TVL.ho_Cross_firstpoint, "red", "margin", 3);



                PointBase temp2 = (PointBase)whichpoint2.SelectedValue;
                TVL.hv_Second_row = temp2.row;
                TVL.hv_Second_col = temp2.col;

                HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_secondpoint, TVL.hv_Second_row, TVL.hv_Second_col, 10, 0);
                toolWindow.Add_Object_disp(TVL.ho_Cross_secondpoint, "blue", "margin", 3);


                toolWindow.showImage();
            }
        }

        private void whichpoint2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                toolWindow.Clear_Object_disp();


                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                TVL.hv_first_row = temp1.row;
                TVL.hv_first_col = temp1.col;
                HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_firstpoint, TVL.hv_first_row, TVL.hv_first_col, 10, 0);
                toolWindow.Add_Object_disp(TVL.ho_Cross_firstpoint, "red", "margin", 3);



                PointBase temp2 = (PointBase)whichpoint2.SelectedValue;
                TVL.hv_Second_row = temp2.row;
                TVL.hv_Second_col = temp2.col;

                HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_secondpoint, TVL.hv_Second_row, TVL.hv_Second_col, 10, 0);
                toolWindow.Add_Object_disp(TVL.ho_Cross_secondpoint, "blue", "margin", 3);
                toolWindow.showImage();
            }
        }



        private void OK_Click(object sender, EventArgs e)
        {
            setornot = true;
            ifopenformornot = false;
            dst_Line.row_start = TVL.hv_row1;
            dst_Line.column_start = TVL.hv_col1;
            dst_Line.row_end = TVL.hv_row2;
            dst_Line.column_end = TVL.hv_col2;
            Hide();
        }

        private void TheVerticalLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            ifopenformornot = false;
            Hide();
        }
        public void run()
        {
            if (SelectPoint1[whichpoint1.SelectedIndex].circleorpoint == 0) {

                TVL.hv_first_row = O_T[index_P1[whichpoint1.SelectedIndex].i].OPoint[index_P1[whichpoint1.SelectedIndex].j].row;
                TVL.hv_first_col = O_T[index_P1[whichpoint1.SelectedIndex].i].OPoint[index_P1[whichpoint1.SelectedIndex].j].col;

            }
            if (SelectPoint1[whichpoint1.SelectedIndex].circleorpoint == 1)
            {

                TVL.hv_first_row = O_T[index_C1[whichpoint1.SelectedIndex].i].OCircle[index_C1[whichpoint1.SelectedIndex].j].row;
                TVL.hv_first_col = O_T[index_C1[whichpoint1.SelectedIndex].i].OCircle[index_C1[whichpoint1.SelectedIndex].j].column;

            }
            if (SelectPoint2[whichpoint2.SelectedIndex].circleorpoint == 0)
            {

                TVL.hv_Second_row = O_T[index_P2[whichpoint2.SelectedIndex].i].OPoint[index_P2[whichpoint2.SelectedIndex].j].row;
                TVL.hv_Second_col = O_T[index_P2[whichpoint2.SelectedIndex].i].OPoint[index_P2[whichpoint2.SelectedIndex].j].col;

            }
            if (SelectPoint2[whichpoint2.SelectedIndex].circleorpoint == 1)
            {
                TVL.hv_Second_row = O_T[index_C2[whichpoint2.SelectedIndex].i].OCircle[index_C2[whichpoint2.SelectedIndex].j].row;
                TVL.hv_Second_col = O_T[index_C2[whichpoint2.SelectedIndex].i].OCircle[index_C2[whichpoint2.SelectedIndex].j].column;
            }
           

            TVL.hv_Center_row = (TVL.hv_first_row + TVL.hv_Second_row) / 2;
            TVL.hv_Center_col = (TVL.hv_first_col + TVL.hv_Second_col) / 2;

            TVL.hv_m = (TVL.hv_first_row - TVL.hv_Second_row) / (TVL.hv_first_col - TVL.hv_Second_col);

            TVL.hv_row1 = 0;
            TVL.hv_col1 = ((-TVL.hv_m) * (TVL.hv_row1 - TVL.hv_Center_row)) + TVL.hv_Center_col;

            TVL.hv_row2 = toolWindow.WindowImage.GetHeight;
            TVL.hv_col2 = ((-TVL.hv_m) * (TVL.hv_row2 - TVL.hv_Center_row)) + TVL.hv_Center_col;

            HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_center, TVL.hv_Center_row, TVL.hv_Center_col, 10, 0);
            HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_firstpoint, TVL.hv_first_row, TVL.hv_first_col, 10, 6);
            HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_secondpoint, TVL.hv_Second_row, TVL.hv_Second_col, 10, 6);
            HOperatorSet.GenRegionLine(out TVL.ho_RegionLines, TVL.hv_row1, TVL.hv_col1, TVL.hv_row2, TVL.hv_col2);

            dst_Line.row_start = TVL.hv_row1;
            dst_Line.column_start = TVL.hv_col1;
            dst_Line.row_end = TVL.hv_row2;
            dst_Line.column_end = TVL.hv_col2;
        }

        private void gen_result_Click(object sender, EventArgs e)
        {
            TVL.hv_Center_row = (TVL.hv_first_row + TVL.hv_Second_row) / 2;
            TVL.hv_Center_col = (TVL.hv_first_col + TVL.hv_Second_col) / 2;

            TVL.hv_m = (TVL.hv_first_row - TVL.hv_Second_row) / (TVL.hv_first_col - TVL.hv_Second_col);

            TVL.hv_row1 = 0;
            TVL.hv_col1 = ((-TVL.hv_m) * (TVL.hv_row1 - TVL.hv_Center_row)) + TVL.hv_Center_col;

            TVL.hv_row2 = toolWindow.WindowImage.GetHeight;
            TVL.hv_col2 = ((-TVL.hv_m) * (TVL.hv_row2 - TVL.hv_Center_row)) + TVL.hv_Center_col;
            
            HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_center, TVL.hv_Center_row, TVL.hv_Center_col,10, 0);
            HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_firstpoint, TVL.hv_first_row, TVL.hv_first_col, 10,6);
            HOperatorSet.GenCrossContourXld(out TVL.ho_Cross_secondpoint, TVL.hv_Second_row, TVL.hv_Second_col,10, 6);
            HOperatorSet.GenRegionLine(out TVL.ho_RegionLines, TVL.hv_row1, TVL.hv_col1, TVL.hv_row2, TVL.hv_col2);

            toolWindow1.Add_Object_disp(TVL.ho_Cross_center, "yellow", "margin", 3);
            toolWindow1.Add_Object_disp(TVL.ho_Cross_firstpoint, "red", "margin", 3);
            toolWindow1.Add_Object_disp(TVL.ho_Cross_secondpoint, "blue", "margin", 3);
            toolWindow1.Add_Object_disp(TVL.ho_RegionLines, "green", "margin", 3);
            toolWindow1.showImage();
        }
    }
}
