﻿using System;
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
    public struct PL_distanceParameter
    {
        public HTuple hv_Center_row, hv_Center_col, hv_first_row, hv_Second_row, hv_first_col, hv_Second_col;
        public HTuple hv_m, hv_row1, hv_col1, hv_row2, hv_col2, hv_Distance;

        public HObject ho_Cross_center, ho_Cross_firstpoint, ho_Cross_Line, ho_RegionLines;
    }
    public partial class PL_distance : Form
    {

        public bool setornot = false;
        bool ifopenformornot = false;
        public List<Object_Table> O_T = new List<Object_Table>();
        List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        List<SelectPointNName> SelectPoint1 = new List<SelectPointNName>();
        List<SelectLineNName> SelectLine = new List<SelectLineNName>();

        PL_distanceParameter PLD = new PL_distanceParameter();

        private ImageBase src_Image = new ImageBase();
        public HObject SrcImage { set { src_Image.SetImage = value; } }
        private PointBase src_Point1 = new PointBase();
        public PointBase SrcPoint1 { set { src_Point1 = value; } }
        private PointBase src_Point2 = new PointBase();
        public PointBase SrcPoint2 { set { src_Point2 = value; } }

        private string dst_distance ;
        public string DstDistance { get {return dst_distance ; } }

        List<index_ij> index_img = new List<index_ij>();
        List<index_ij> index_P1 = new List<index_ij>();
        List<index_ij> index_C1 = new List<index_ij>();
        List<index_ij> index_L1 = new List<index_ij>();

        bool loadfinish = false;

        public PL_distance()
        {
            InitializeComponent();
        }

        private void PL_distance_Activated(object sender, EventArgs e)
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
                            if (O_T[i].OPoint[j] != null)
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
                        for (int j = 0; j < O_T[i].OLine.Count; j++)
                        {
                            if (O_T[i].OLine[j] != null)
                            {
                                SelectLineNName SPNN = new SelectLineNName();
                                SPNN.Line = O_T[i].OLine[j];
                                SPNN.LineName = (string)O_T[i].OLineName[j];
                                SelectLine.Add(SPNN);
                                index_ij ij_temp = new index_ij();
                                ij_temp.i = i;
                                ij_temp.j = j;
                                index_L1.Add(ij_temp);
                            }
                        }
                    }
                    whichLline.DataSource = null;
                    whichLline.DataSource = SelectLine;
                    whichLline.DisplayMember = "LineName";
                    whichLline.ValueMember = "Line";

                    loadfinish = true;

                    toolWindow.Clear_Object_disp();

                    src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                    PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                    Line temp2 = (Line)whichLline.SelectedValue;
                    PLD.hv_first_row = temp1.row;
                    PLD.hv_first_col = temp1.col;

                    PLD.hv_row1 = temp2.row_start;
                    PLD.hv_col1 = temp2.column_start;
                    PLD.hv_row2 = temp2.row_end;
                    PLD.hv_col2 = temp2.column_end;
                    HOperatorSet.GenCrossContourXld(out PLD.ho_Cross_firstpoint, PLD.hv_first_row, PLD.hv_first_col, 10, 0);

                    HOperatorSet.GenRegionLine(out PLD.ho_RegionLines, PLD.hv_row1, PLD.hv_col1, PLD.hv_row2, PLD.hv_col2);


                    toolWindow.Add_Object_disp(PLD.ho_Cross_firstpoint, "red", "margin", 3);
                    toolWindow.Add_Object_disp(PLD.ho_RegionLines, "green", "margin", 3);
                    toolWindow.WindowImage.CopyImagetoThis(src_Image.GetImage);
                    toolWindow.showImage();
                }

            }
            else if (setornot == true)
            {
                if (ifopenformornot == false)
                {
                    ifopenformornot = true;
                    toolWindow.showImage();
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

        private void whichpoint1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                toolWindow.Clear_Object_disp();
                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                PLD.hv_first_row = temp1.row;
                PLD.hv_first_col = temp1.col;

                HOperatorSet.GenCrossContourXld(out PLD.ho_Cross_firstpoint, PLD.hv_first_row, PLD.hv_first_col, 10, 0);
                toolWindow.Add_Object_disp(PLD.ho_Cross_firstpoint, "red", "margin", 3);


                Line temp2 = (Line)whichLline.SelectedValue;

                PLD.hv_row1 = temp2.row_start;
                PLD.hv_col1 = temp2.column_start;
                PLD.hv_row2 = temp2.row_end;
                PLD.hv_col2 = temp2.column_end;
                HOperatorSet.GenRegionLine(out PLD.ho_RegionLines, PLD.hv_row1, PLD.hv_col1, PLD.hv_row2, PLD.hv_col2);
                toolWindow.Add_Object_disp(PLD.ho_RegionLines, "green", "margin", 3);

                toolWindow.showImage();
            }
        }

        private void whichLine_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loadfinish)
            {
                toolWindow.Clear_Object_disp();
                Line temp2 = (Line)whichLline.SelectedValue;

                PLD.hv_row1 = temp2.row_start;
                PLD.hv_col1 = temp2.column_start;
                PLD.hv_row2 = temp2.row_end;
                PLD.hv_col2 = temp2.column_end;
                HOperatorSet.GenRegionLine(out PLD.ho_RegionLines, PLD.hv_row1, PLD.hv_col1, PLD.hv_row2, PLD.hv_col2);
                toolWindow.Add_Object_disp(PLD.ho_RegionLines, "green", "margin", 3);


                PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
                PLD.hv_first_row = temp1.row;
                PLD.hv_first_col = temp1.col;

                HOperatorSet.GenCrossContourXld(out PLD.ho_Cross_firstpoint, PLD.hv_first_row, PLD.hv_first_col, 10, 0);
                toolWindow.Add_Object_disp(PLD.ho_Cross_firstpoint, "red", "margin", 3);


                toolWindow.showImage();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            setornot = true;
            ifopenformornot = false;
            Hide();
        }

        private void gen_result_Click(object sender, EventArgs e)
        {
            PointBase temp1 = (PointBase)whichpoint1.SelectedValue;
            Line temp2 = (Line)whichLline.SelectedValue;
            HOperatorSet.DistancePl(temp1.row, temp1.col, temp2.row_start, temp2.column_start, temp2.row_end, temp2.column_end, out PLD.hv_Distance);
            distance_pl.Text = PLD.hv_Distance.D.ToString();
        }
        public void run()
        {
            
            if (SelectPoint1[whichpoint1.SelectedIndex].circleorpoint == 0)
            {

                PLD.hv_first_row = O_T[index_P1[whichpoint1.SelectedIndex].i].OPoint[index_P1[whichpoint1.SelectedIndex].j].row;
                PLD.hv_first_col = O_T[index_P1[whichpoint1.SelectedIndex].i].OPoint[index_P1[whichpoint1.SelectedIndex].j].col;

            }
            if (SelectPoint1[whichpoint1.SelectedIndex].circleorpoint == 1)
            {

                PLD.hv_first_row = O_T[index_C1[whichpoint1.SelectedIndex].i].OCircle[index_C1[whichpoint1.SelectedIndex].j].row;
                PLD.hv_first_col = O_T[index_C1[whichpoint1.SelectedIndex].i].OCircle[index_C1[whichpoint1.SelectedIndex].j].column;

            }

            PLD.hv_row1 = O_T[index_L1[whichLline.SelectedIndex].i].OLine[index_L1[whichLline.SelectedIndex].j].row_start;
            PLD.hv_col1 = O_T[index_L1[whichLline.SelectedIndex].i].OLine[index_L1[whichLline.SelectedIndex].j].column_start;
            PLD.hv_row2 = O_T[index_L1[whichLline.SelectedIndex].i].OLine[index_L1[whichLline.SelectedIndex].j].row_end;
            PLD.hv_col2 = O_T[index_L1[whichLline.SelectedIndex].i].OLine[index_L1[whichLline.SelectedIndex].j].column_end;

            HOperatorSet.DistancePl(PLD.hv_first_row, PLD.hv_first_col, PLD.hv_row1, PLD.hv_col1, PLD.hv_row2, PLD.hv_col2, out PLD.hv_Distance);
            dst_distance = PLD.hv_Distance.D.ToString();
        }


        private void PL_distance_FormClosing(object sender, FormClosingEventArgs e)
        {
            ifopenformornot = false;
            Hide();
        }
    }
}
