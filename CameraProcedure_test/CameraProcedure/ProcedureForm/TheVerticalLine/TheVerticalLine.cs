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
    public partial class TheVerticalLine : Form
    {
        public TheVerticalLineParameter_out TVL_out = new TheVerticalLineParameter_out();
        public TheVerticalLineParameter_form TVL_form = new TheVerticalLineParameter_form();
        public TheVerticalLineParameter_in TVL_in = new TheVerticalLineParameter_in();

        public TheVerticalLine()
        {
            InitializeComponent();
        }

        private void TheVerticalLine_Activated(object sender, EventArgs e)
        {
            if (TVL_form.ifopenformornot == false)
            {
                TVL_form.ifopenformornot = true;

                TVL_form.SelectImage.Clear();
                for (int i = 0; i < TVL_in.O_T.Count; i++)
                {
                    for (int j = 0; j < TVL_in.O_T[i].OImage.Count; j++)
                    {
                        if (TVL_in.O_T[i].OImage[j] != null)
                        {
                            SelectImageNName M1S = new SelectImageNName();
                            M1S.Image = TVL_in.O_T[i].OImage[j];
                            M1S.ImageName = (string)TVL_in.O_T[i].OImageName[j];
                            TVL_form.SelectImage.Add(M1S);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            TVL_form.index_img.Add(ij_temp);
                        }
                    }
                }
                whichpicture.DataSource = null;
                whichpicture.DataSource = TVL_form.SelectImage;
                whichpicture.DisplayMember = "ImageName";
                whichpicture.ValueMember = "Image";


                for (int i = 0; i < TVL_in.O_T.Count; i++)
                {
                    for (int j = 0; j < TVL_in.O_T[i].OPoint.Count; j++)
                    {
                        if (TVL_in.O_T[i].OPoint[j]!=null)
                        {
                            SelectPointNName SPNN = new SelectPointNName();
                            SPNN.Point = TVL_in.O_T[i].OPoint[j];
                            SPNN.PointName = (string)TVL_in.O_T[i].OPointName[j];
                            SPNN.circleorpoint = 0;
                            TVL_form.SelectPoint1.Add(SPNN);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            TVL_form.index_P1.Add(ij_temp);
                        }
                    }
                }

                for (int i = 0; i < TVL_in.O_T.Count; i++)
                {
                    for (int j = 0; j < TVL_in.O_T[i].OCircle.Count; j++)
                    {
                        if (TVL_in.O_T[i].OCircle[j] != null)
                        {
                            SelectPointNName SPNN = new SelectPointNName();
                            PointBase P_temp = new PointBase();
                            P_temp.row = TVL_in.O_T[i].OCircle[j].row;
                            P_temp.col = TVL_in.O_T[i].OCircle[j].column;
                            SPNN.Point = P_temp;
                            SPNN.PointName = TVL_in.O_T[i].OCircleName[j];
                            SPNN.circleorpoint = 1;
                            TVL_form.SelectPoint1.Add(SPNN);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            TVL_form.index_C1.Add(ij_temp);
                        }
                    }
                }
                whichpoint1.DataSource = null;
                whichpoint1.DataSource = TVL_form.SelectPoint1;
                whichpoint1.DisplayMember = "PointName";
                whichpoint1.ValueMember = "Point";



                for (int i = 0; i < TVL_in.O_T.Count; i++)
                {
                    for (int j = 0; j < TVL_in.O_T[i].OPoint.Count; j++)
                    {
                        if (TVL_in.O_T[i].OPoint[j] != null)
                        {
                            SelectPointNName SPNN = new SelectPointNName();
                            SPNN.Point = TVL_in.O_T[i].OPoint[j];
                            SPNN.PointName = (string)TVL_in.O_T[i].OPointName[j];
                            SPNN.circleorpoint = 0;
                            TVL_form.SelectPoint2.Add(SPNN);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            TVL_form.index_P2.Add(ij_temp);
                        }
                    }
                }

                for (int i = 0; i < TVL_in.O_T.Count; i++)
                {
                    for (int j = 0; j < TVL_in.O_T[i].OCircle.Count; j++)
                    {
                        if (TVL_in.O_T[i].OCircle[j] != null)
                        {
                            SelectPointNName SPNN = new SelectPointNName();
                            PointBase P_temp = new PointBase();
                            P_temp.row = TVL_in.O_T[i].OCircle[j].row;
                            P_temp.col = TVL_in.O_T[i].OCircle[j].column;
                            SPNN.Point = P_temp;
                            SPNN.PointName = TVL_in.O_T[i].OCircleName[j];
                            SPNN.circleorpoint = 1;
                            TVL_form.SelectPoint2.Add(SPNN);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            TVL_form.index_C2.Add(ij_temp);
                        }
                    }
                }
                whichpoint2.DataSource = null;
                whichpoint2.DataSource = TVL_form.SelectPoint2;
                whichpoint2.DisplayMember = "PointName";
                whichpoint2.ValueMember = "Point";

                TVL_form.loadfinish = true;

                toolWindow.Clear_Object_disp();

                TVL_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                PointBase temp2 = (PointBase)whichpoint2.SelectedValue;
                TVL_form.hv_first_row = temp1.row;
                TVL_form.hv_first_col = temp1.col;
                TVL_form.hv_Second_row = temp2.row;
                TVL_form.hv_Second_col = temp2.col;
                HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_firstpoint, TVL_form.hv_first_row, TVL_form.hv_first_col, 10, 0);
                HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_secondpoint, TVL_form.hv_Second_row, TVL_form.hv_Second_col, 10, 0);
                
                toolWindow.Add_Object_disp(TVL_form.ho_Cross_firstpoint, "red", "margin", 3);
                toolWindow.Add_Object_disp(TVL_form.ho_Cross_secondpoint, "blue", "margin", 3);
                toolWindow.WindowImage.SetImage = TVL_form.src_Image.GetImage;
                toolWindow.WindowImage.GetImageSize();
                toolWindow.showImage();
                toolWindow1.WindowImage.SetImage = TVL_form.src_Image.GetImage;
                toolWindow1.WindowImage.GetImageSize();
                toolWindow1.showImage();
            }
            
            if (TVL_form.ifopenformornot == false)
            {
                TVL_form.ifopenformornot = true;
                toolWindow.showImage();
                toolWindow1.showImage();
            }
            
            
        }

        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TVL_form.loadfinish)
            {
                TVL_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage.SetImage = TVL_form.src_Image.GetImage;
                toolWindow1.WindowImage.SetImage = TVL_form.src_Image.GetImage;
                toolWindow.showImage();
            }
        }

        private void whichpoint_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TVL_form.loadfinish)
            {
                toolWindow.Clear_Object_disp();
                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                TVL_form.hv_first_row = temp1.row;
                TVL_form.hv_first_col = temp1.col;
                HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_firstpoint, TVL_form.hv_first_row, TVL_form.hv_first_col, 10, 0);
                toolWindow.Add_Object_disp(TVL_form.ho_Cross_firstpoint, "red", "margin", 3);



                PointBase temp2 = (PointBase)whichpoint2.SelectedValue;
                TVL_form.hv_Second_row = temp2.row;
                TVL_form.hv_Second_col = temp2.col;

                HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_secondpoint, TVL_form.hv_Second_row, TVL_form.hv_Second_col, 10, 0);
                toolWindow.Add_Object_disp(TVL_form.ho_Cross_secondpoint, "blue", "margin", 3);


                toolWindow.showImage();
            }
        }

        private void whichpoint2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TVL_form.loadfinish)
            {
                toolWindow.Clear_Object_disp();


                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                TVL_form.hv_first_row = temp1.row;
                TVL_form.hv_first_col = temp1.col;
                HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_firstpoint, TVL_form.hv_first_row, TVL_form.hv_first_col, 10, 0);
                toolWindow.Add_Object_disp(TVL_form.ho_Cross_firstpoint, "red", "margin", 3);



                PointBase temp2 = (PointBase)whichpoint2.SelectedValue;
                TVL_form.hv_Second_row = temp2.row;
                TVL_form.hv_Second_col = temp2.col;

                HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_secondpoint, TVL_form.hv_Second_row, TVL_form.hv_Second_col, 10, 0);
                toolWindow.Add_Object_disp(TVL_form.ho_Cross_secondpoint, "blue", "margin", 3);
                toolWindow.showImage();
            }
        }



        private void OK_Click(object sender, EventArgs e)
        {
            TVL_out.setornot = true;
            TVL_form.ifopenformornot = false;
            TVL_out.dst_Line.row_start = TVL_form.hv_row1;
            TVL_out.dst_Line.column_start = TVL_form.hv_col1;
            TVL_out.dst_Line.row_end = TVL_form.hv_row2;
            TVL_out.dst_Line.column_end = TVL_form.hv_col2;
            Hide();
        }

        private void TheVerticalLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            TVL_form.ifopenformornot = false;
            Hide();
        }
        public void run()
        {
            if (TVL_form.SelectPoint1[whichpoint1.SelectedIndex].circleorpoint == 0) {

                TVL_form.hv_first_row = TVL_in.O_T[TVL_form.index_P1[whichpoint1.SelectedIndex].i].OPoint[TVL_form.index_P1[whichpoint1.SelectedIndex].j].row;
                TVL_form.hv_first_col = TVL_in.O_T[TVL_form.index_P1[whichpoint1.SelectedIndex].i].OPoint[TVL_form.index_P1[whichpoint1.SelectedIndex].j].col;

            }
            if (TVL_form.SelectPoint1[whichpoint1.SelectedIndex].circleorpoint == 1)
            {

                TVL_form.hv_first_row = TVL_in.O_T[TVL_form.index_C1[whichpoint1.SelectedIndex].i].OCircle[TVL_form.index_C1[whichpoint1.SelectedIndex].j].row;
                TVL_form.hv_first_col = TVL_in.O_T[TVL_form.index_C1[whichpoint1.SelectedIndex].i].OCircle[TVL_form.index_C1[whichpoint1.SelectedIndex].j].column;

            }
            if (TVL_form.SelectPoint2[whichpoint2.SelectedIndex].circleorpoint == 0)
            {

                TVL_form.hv_Second_row = TVL_in.O_T[TVL_form.index_P2[whichpoint2.SelectedIndex].i].OPoint[TVL_form.index_P2[whichpoint2.SelectedIndex].j].row;
                TVL_form.hv_Second_col = TVL_in.O_T[TVL_form.index_P2[whichpoint2.SelectedIndex].i].OPoint[TVL_form.index_P2[whichpoint2.SelectedIndex].j].col;

            }
            if (TVL_form.SelectPoint2[whichpoint2.SelectedIndex].circleorpoint == 1)
            {
                TVL_form.hv_Second_row = TVL_in.O_T[TVL_form.index_C2[whichpoint2.SelectedIndex].i].OCircle[TVL_form.index_C2[whichpoint2.SelectedIndex].j].row;
                TVL_form.hv_Second_col = TVL_in.O_T[TVL_form.index_C2[whichpoint2.SelectedIndex].i].OCircle[TVL_form.index_C2[whichpoint2.SelectedIndex].j].column;
            }


            TVL_form.hv_Center_row = (TVL_form.hv_first_row + TVL_form.hv_Second_row) / 2;
            TVL_form.hv_Center_col = (TVL_form.hv_first_col + TVL_form.hv_Second_col) / 2;

            TVL_form.hv_m = (TVL_form.hv_first_row - TVL_form.hv_Second_row) / (TVL_form.hv_first_col - TVL_form.hv_Second_col);

            TVL_form.hv_row1 = 0;
            TVL_form.hv_col1 = ((-TVL_form.hv_m) * (TVL_form.hv_row1 - TVL_form.hv_Center_row)) + TVL_form.hv_Center_col;

            TVL_form.hv_row2 = toolWindow.WindowImage.GetHeight;
            TVL_form.hv_col2 = ((-TVL_form.hv_m) * (TVL_form.hv_row2 - TVL_form.hv_Center_row)) + TVL_form.hv_Center_col;

            HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_center, TVL_form.hv_Center_row, TVL_form.hv_Center_col, 10, 0);
            HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_firstpoint, TVL_form.hv_first_row, TVL_form.hv_first_col, 10, 6);
            HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_secondpoint, TVL_form.hv_Second_row, TVL_form.hv_Second_col, 10, 6);
            HOperatorSet.GenRegionLine(out TVL_form.ho_RegionLines, TVL_form.hv_row1, TVL_form.hv_col1, TVL_form.hv_row2, TVL_form.hv_col2);

            TVL_out.dst_Line.row_start = TVL_form.hv_row1;
            TVL_out.dst_Line.column_start = TVL_form.hv_col1;
            TVL_out.dst_Line.row_end = TVL_form.hv_row2;
            TVL_out.dst_Line.column_end = TVL_form.hv_col2;
        }

        private void gen_result_Click(object sender, EventArgs e)
        {
            TVL_form.hv_Center_row = (TVL_form.hv_first_row + TVL_form.hv_Second_row) / 2;
            TVL_form.hv_Center_col = (TVL_form.hv_first_col + TVL_form.hv_Second_col) / 2;

            TVL_form.hv_m = (TVL_form.hv_first_row - TVL_form.hv_Second_row) / (TVL_form.hv_first_col - TVL_form.hv_Second_col);

            TVL_form.hv_row1 = 0;
            TVL_form.hv_col1 = ((-TVL_form.hv_m) * (TVL_form.hv_row1 - TVL_form.hv_Center_row)) + TVL_form.hv_Center_col;

            TVL_form.hv_row2 = toolWindow.WindowImage.GetHeight;
            TVL_form.hv_col2 = ((-TVL_form.hv_m) * (TVL_form.hv_row2 - TVL_form.hv_Center_row)) + TVL_form.hv_Center_col;
            
            HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_center, TVL_form.hv_Center_row, TVL_form.hv_Center_col,10, 0);
            HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_firstpoint, TVL_form.hv_first_row, TVL_form.hv_first_col, 10,6);
            HOperatorSet.GenCrossContourXld(out TVL_form.ho_Cross_secondpoint, TVL_form.hv_Second_row, TVL_form.hv_Second_col,10, 6);
            HOperatorSet.GenRegionLine(out TVL_form.ho_RegionLines, TVL_form.hv_row1, TVL_form.hv_col1, TVL_form.hv_row2, TVL_form.hv_col2);

            toolWindow1.Add_Object_disp(TVL_form.ho_Cross_center, "yellow", "margin", 3);
            toolWindow1.Add_Object_disp(TVL_form.ho_Cross_firstpoint, "red", "margin", 3);
            toolWindow1.Add_Object_disp(TVL_form.ho_Cross_secondpoint, "blue", "margin", 3);
            toolWindow1.Add_Object_disp(TVL_form.ho_RegionLines, "green", "margin", 3);
            toolWindow1.showImage();
        }
    }
}
