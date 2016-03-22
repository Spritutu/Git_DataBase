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
    //測量模式
    enum MeasureType { pos,pair }
    //測量結果模式_pair
    enum MeasureTransition_pair { all, all_strongest, negative, negative_strongest, positive, positive_strongest }
    //測量結果模式_pos
    enum MeasureTransition_pos { all, negative, positive }
    //測量結果選擇
    enum MeasureSelect { all, first, last }
    
    public partial class Measure_1D : Form
    {
        public Measure1DParameter_in M1DP_in = new Measure1DParameter_in();
        public Measure1DParameter_out M1DP_out = new Measure1DParameter_out();
        public Measure1DParameter_form M1DP_form = new Measure1DParameter_form();
        
        public Measure_1D()
        {
            InitializeComponent();
        }
        
        private void Measure_Activated(object sender, EventArgs e)
        {
            if (!M1DP_form.ifopenformornot)
            {
                M1DP_form.ifopenformornot = true;
                
                //表格參數預載
                this.MaxEdge.Value = 40;
                this.sigma.Value = 1;
                this.ROIWeight.Value = 30;
                this.MaxEage_trackBar.Value = 40;
                this.Sigma_trackBar.Value = 1;
                this.ROIWeight_trackBar.Value = 30;


                M1DP_form.transition_pair = MeasureTransition_pair.all.ToString();
                M1DP_form.transition_pos = MeasureTransition_pos.all.ToString();
                M1DP_form.select = MeasureSelect.all.ToString();
                M1DP_form.sigma = 1;
                M1DP_form.threshold = 40;

                M1DP_form.TransitionData_pair.Clear();
                M1DP_form.TransitionData_pair.Add(MeasureTransition_pair.all.ToString());
                M1DP_form.TransitionData_pair.Add(MeasureTransition_pair.all_strongest.ToString());
                M1DP_form.TransitionData_pair.Add(MeasureTransition_pair.negative.ToString());
                M1DP_form.TransitionData_pair.Add(MeasureTransition_pair.negative_strongest.ToString());
                M1DP_form.TransitionData_pair.Add(MeasureTransition_pair.positive.ToString());
                M1DP_form.TransitionData_pair.Add(MeasureTransition_pair.positive_strongest.ToString());

                M1DP_form.TransitionData_pos.Clear();
                M1DP_form.TransitionData_pos.Add(MeasureTransition_pos.all.ToString());
                M1DP_form.TransitionData_pos.Add(MeasureTransition_pos.negative.ToString());
                M1DP_form.TransitionData_pos.Add(MeasureTransition_pos.positive.ToString());

                M1DP_form.SelectData.Clear();
                M1DP_form.SelectData.Add(MeasureSelect.all.ToString());
                M1DP_form.SelectData.Add(MeasureSelect.first.ToString());
                M1DP_form.SelectData.Add(MeasureSelect.last.ToString());

                M1DP_form.SelectImage.Clear();
                for (int i = 0; i < M1DP_in.O_T.Count; i++)
                {
                    for (int j = 0; j < M1DP_in.O_T[i].OImage.Count; j++)
                    {
                        if (M1DP_in.O_T[i].OImage[j] != null)
                        {
                            SelectImageNName M1S = new SelectImageNName();
                            M1S.Image = M1DP_in.O_T[i].OImage[j];
                            M1S.ImageName = (string)M1DP_in.O_T[i].OImageName[j];
                            M1DP_form.SelectImage.Add(M1S);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            M1DP_form.index_img.Add(ij_temp);
                        }
                    }
                }
                result_list.Clear();

                result_list.View = View.Details;
                result_list.Columns.Add("編號");
                result_list.Columns.Add("行");
                result_list.Columns.Add("列");
                result_list.Columns.Add("振幅");
                result_list.Columns.Add("距離");
                this.result_list.EndUpdate();


                whichpicture.DataSource = null;
                whichpicture.DataSource = M1DP_form.SelectImage;
                whichpicture.DisplayMember = "ImageName";
                whichpicture.ValueMember = "Image";

                
                SelectBox.DataSource = null;
                SelectBox.DataSource = M1DP_form.SelectData;
                posButton.Checked = true;
                M1DP_form.ifopenformornot = true;
                M1DP_form.loadfinish = true;

                M1DP_form.Measure_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage.CopyImagetoThis(M1DP_form.Measure_Image.GetImage);
            }

            if (toolWindow.WindowImage.GetImage != null)
                toolWindow.showImage();
        }


        public void run()
        {
            M1DP_form.Measure_Image.SetImage = M1DP_in.O_T[M1DP_form.index_img[whichpicture.SelectedIndex].i].OImage[M1DP_form.index_img[whichpicture.SelectedIndex].j];
            switch (M1DP_form.measuretype)
            {
                case (int)MeasureType.pos:
                    //如果toolWindow視窗裡有影像才執行
                    if (M1DP_form.Measure_Image.GetImage != null)
                    {
                        HOperatorSet.GenEmptyObj(out M1DP_form.ho_CrossFirst);
                        HOperatorSet.GenMeasureRectangle2(M1DP_in.region_line.line_rec.row,
                            M1DP_in.region_line.line_rec.column, M1DP_in.region_line.line_rec.phi,
                            M1DP_in.region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP_form.hv_MeasureHandle);
                        HOperatorSet.MeasurePos(M1DP_form.Measure_Image.GetImage, M1DP_form.hv_MeasureHandle, M1DP_form.sigma, M1DP_form.threshold,
                          M1DP_form.transition_pos, M1DP_form.select, out M1DP_form.hv_RowEdgeFirst, out M1DP_form.hv_ColumnEdgeFirst, out M1DP_form.hv_AmplitudeFirst, out M1DP_form.hv_Distance);
                        M1DP_form.ho_CrossFirst.Dispose();
                        HOperatorSet.CloseMeasure(M1DP_form.hv_MeasureHandle);
                        M1DP_out.dstfirstpoint.Clear();
                        for (int i = 0; i < M1DP_form.hv_RowEdgeFirst.Length; i++)
                        {
                            PointBase PB_temp = new PointBase();
                            PB_temp.row = M1DP_form.hv_RowEdgeFirst[i];
                            PB_temp.col = M1DP_form.hv_ColumnEdgeFirst[i];
                            M1DP_out.dstfirstpoint.Add(PB_temp);
                        }
                    }
                    break;

                case (int)MeasureType.pair:

                    if (M1DP_form.Measure_Image.GetImage != null)
                    {
                        HOperatorSet.GenEmptyObj(out M1DP_form.ho_CrossFirst);
                        HOperatorSet.GenEmptyObj(out M1DP_form.ho_CrossSecond);
                        HOperatorSet.GenMeasureRectangle2(M1DP_in.region_line.line_rec.row,
                            M1DP_in.region_line.line_rec.column, M1DP_in.region_line.line_rec.phi,
                            M1DP_in.region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP_form.hv_MeasureHandle);

                        HOperatorSet.MeasurePairs(M1DP_form.Measure_Image.GetImage, M1DP_form.hv_MeasureHandle, M1DP_form.sigma, M1DP_form.threshold, M1DP_form.transition_pair, M1DP_form.select,
                            out M1DP_form.hv_RowEdgeFirst, out M1DP_form.hv_ColumnEdgeFirst, out M1DP_form.hv_AmplitudeFirst, out M1DP_form.hv_RowEdgeSecond,
                            out M1DP_form.hv_ColumnEdgeSecond, out M1DP_form.hv_AmplitudeSecond, out M1DP_form.hv_PinWidth, out M1DP_form.hv_PinDistance);
                        HOperatorSet.CloseMeasure(M1DP_form.hv_MeasureHandle);
                        M1DP_out.dstfirstpoint.Clear();
                        M1DP_out.dstsecondpoint.Clear();
                        for (int i = 0; i < M1DP_form.hv_RowEdgeFirst.Length; i++)
                        {
                            PointBase PB1_temp = new PointBase();
                            PointBase PB2_temp = new PointBase();
                            PB1_temp.row = M1DP_form.hv_RowEdgeFirst[i];
                            PB1_temp.col = M1DP_form.hv_ColumnEdgeFirst[i];
                            PB2_temp.row = M1DP_form.hv_RowEdgeFirst[i];
                            PB2_temp.col = M1DP_form.hv_ColumnEdgeFirst[i];
                            M1DP_out.dstfirstpoint.Add(PB1_temp);
                            M1DP_out.dstsecondpoint.Add(PB2_temp);
                        }
                    }
                    break;

            }

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            HOperatorSet.ClearWindow(EageWindow.HalconWindow);
            toolWindow.Clear_Object_disp();
            
            switch (M1DP_form.measuretype) {
                case (int)MeasureType.pos:
                    //如果toolWindow視窗裡有影像才執行
                    if (toolWindow.WindowImage.GetImage != null)
                    {
                        toolWindow.Window.Focus();

                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

                        M1DP_in.region_line.DrawLine(toolWindow.Window.HalconWindow);
                        M1DP_in.region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenEmptyObj(out M1DP_form.ho_CrossFirst);
                        HOperatorSet.GenMeasureRectangle2(M1DP_in.region_line.line_rec.row,
                            M1DP_in.region_line.line_rec.column, M1DP_in.region_line.line_rec.phi,
                            M1DP_in.region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP_form.hv_MeasureHandle);
                        HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, M1DP_form.hv_MeasureHandle, M1DP_form.sigma, M1DP_form.threshold,
                          M1DP_form.transition_pos, M1DP_form.select, out M1DP_form.hv_RowEdgeFirst, out M1DP_form.hv_ColumnEdgeFirst, out M1DP_form.hv_AmplitudeFirst, out M1DP_form.hv_Distance);
                        M1DP_form.ho_CrossFirst.Dispose();

                        HOperatorSet.ClearWindow(toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        M1DP_in.region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenCrossContourXld(out M1DP_form.ho_CrossFirst, M1DP_form.hv_RowEdgeFirst, M1DP_form.hv_ColumnEdgeFirst,
                            ROIWeight_trackBar.Value * 2, M1DP_in.region_line.line_rec.phi);
                        HOperatorSet.DispObj(M1DP_form.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.CloseMeasure(M1DP_form.hv_MeasureHandle);

                        M1DP_form.temp1 = M1DP_in.region_line.line_rec.ROI.Clone();
                        M1DP_form.temp2 = M1DP_form.ho_CrossFirst.Clone();
                        toolWindow.Add_Object_disp(M1DP_form.temp1, "yellow", "margin", 1);
                        toolWindow.Add_Object_disp(M1DP_form.temp2, "yellow", "margin", 1);

                        set_list(M1DP_form.hv_RowEdgeFirst, M1DP_form.hv_ColumnEdgeFirst, M1DP_form.hv_AmplitudeFirst, M1DP_form.hv_Distance, result_list);
                    }
                    else
                    {
                        MessageBox.Show("toolWindow.WindowImage是空的!");
                    }
                    break;

                case (int)MeasureType.pair:

                    if (toolWindow.WindowImage.GetImage != null)
                    {
                        toolWindow.Window.Focus();
                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

                        M1DP_in.region_line.DrawLine(toolWindow.Window.HalconWindow);
                        M1DP_in.region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenEmptyObj(out M1DP_form.ho_CrossFirst);
                        HOperatorSet.GenEmptyObj(out M1DP_form.ho_CrossSecond);
                        HOperatorSet.GenMeasureRectangle2(M1DP_in.region_line.line_rec.row,
                            M1DP_in.region_line.line_rec.column, M1DP_in.region_line.line_rec.phi,
                            M1DP_in.region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP_form.hv_MeasureHandle);

                        HOperatorSet.MeasurePairs(toolWindow.WindowImage.GetImage, M1DP_form.hv_MeasureHandle, M1DP_form.sigma, M1DP_form.threshold, M1DP_form.transition_pair, M1DP_form.select,
                            out M1DP_form.hv_RowEdgeFirst, out M1DP_form.hv_ColumnEdgeFirst, out M1DP_form.hv_AmplitudeFirst, out M1DP_form.hv_RowEdgeSecond,
                            out M1DP_form.hv_ColumnEdgeSecond, out M1DP_form.hv_AmplitudeSecond, out M1DP_form.hv_PinWidth, out M1DP_form.hv_PinDistance);

                        M1DP_form.ho_CrossFirst.Dispose();
                        M1DP_form.ho_CrossSecond.Dispose();

                        HOperatorSet.ClearWindow(toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        M1DP_in.region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenCrossContourXld(out M1DP_form.ho_CrossFirst, M1DP_form.hv_RowEdgeFirst, M1DP_form.hv_ColumnEdgeFirst,
                            ROIWeight_trackBar.Value * 2, M1DP_in.region_line.line_rec.phi);
                        HOperatorSet.GenCrossContourXld(out M1DP_form.ho_CrossSecond, M1DP_form.hv_RowEdgeSecond, M1DP_form.hv_ColumnEdgeSecond,
                            ROIWeight_trackBar.Value * 2, M1DP_in.region_line.line_rec.phi);

                        M1DP_form.temp1 = M1DP_in.region_line.line_rec.ROI.Clone();
                        M1DP_form.temp2 = M1DP_form.ho_CrossFirst.Clone();
                        M1DP_form.temp3 = M1DP_form.ho_CrossSecond.Clone();

                        toolWindow.Add_Object_disp(M1DP_form.temp1, "yellow", "margin", 1);
                        toolWindow.Add_Object_disp(M1DP_form.temp2, "yellow", "margin", 1);
                        toolWindow.Add_Object_disp(M1DP_form.temp3, "yellow", "margin", 1);

                        HOperatorSet.DispObj(M1DP_form.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP_form.ho_CrossSecond, toolWindow.Window.HalconWindow);

                        HOperatorSet.CloseMeasure(M1DP_form.hv_MeasureHandle);
                    }
                    else
                    {
                        MessageBox.Show("toolWindow.WindowImage是空的!");
                    }

                    break;

            }

            Eage_num.Value = 2;
            Eage_num.Value = 1;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            M1DP_form.setornot = true;
            switch (M1DP_form.measuretype)
            {
                case (int)MeasureType.pos:
                    M1DP_out.dstfirstpoint.Clear();
                    for (int i = 0; i < M1DP_form.hv_RowEdgeFirst.Length; i++)
                    {                        
                        PointBase PB_temp = new PointBase();
                        PB_temp.row = M1DP_form.hv_RowEdgeFirst[i];
                        PB_temp.col = M1DP_form.hv_ColumnEdgeFirst[i];
                        M1DP_out.dstfirstpoint.Add(PB_temp);
                    }
                    break;

                case (int)MeasureType.pair:
                    M1DP_out.dstfirstpoint.Clear();
                    M1DP_out.dstsecondpoint.Clear();
                    for (int i = 0; i < M1DP_form.hv_RowEdgeFirst.Length; i++)
                    {
                        PointBase PB1_temp = new PointBase();
                        PointBase PB2_temp = new PointBase();
                        PB1_temp.row = M1DP_form.hv_RowEdgeFirst[i];
                        PB1_temp.col = M1DP_form.hv_ColumnEdgeFirst[i];
                        PB2_temp.row = M1DP_form.hv_RowEdgeFirst[i];
                        PB2_temp.col = M1DP_form.hv_ColumnEdgeFirst[i];
                        M1DP_out.dstfirstpoint.Add(PB1_temp);
                        M1DP_out.dstsecondpoint.Add(PB2_temp);
                    }

                    break;

            }
            Hide();
        }

        private void MaxEage_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.MaxEdge.Value = this.MaxEage_trackBar.Value;
            M1DP_form.threshold = (int)this.MaxEage_trackBar.Value;
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.sigma.Value = this.Sigma_trackBar.Value;
            M1DP_form.sigma = (int)this.Sigma_trackBar.Value;
        }

        private void ROIWeight_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.ROIWeight.Value = this.ROIWeight_trackBar.Value;
            M1DP_form.ROIweight = (int)this.ROIWeight_trackBar.Value;
        }

        private void MaxEdge_ValueChanged(object sender, EventArgs e)
        {
            this.MaxEage_trackBar.Value = (int)this.MaxEdge.Value;
            M1DP_form.threshold = (int)this.MaxEdge.Value;
            Showresult();

        }

        private void sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.sigma.Value;
            M1DP_form.sigma = (int)this.sigma.Value;
            Showresult();
        }

        private void ROIWeight_ValueChanged(object sender, EventArgs e)
        {
            this.ROIWeight_trackBar.Value = (int)this.ROIWeight.Value;
            M1DP_form.ROIweight = (int)this.ROIWeight.Value;
            Showresult();
        }

        private void posButton_CheckedChanged(object sender, EventArgs e)
        {
            M1DP_form.measuretype = 0;
            M1DP_in.region_line.ClearALL();
            TransitionBox.DataSource = M1DP_form.TransitionData_pos;
            if(toolWindow.WindowImage.GetImage != null)
                HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
        }

        private void pairButton_CheckedChanged(object sender, EventArgs e)
        {
            M1DP_form.measuretype = 1;
            M1DP_in.region_line.ClearALL();
            TransitionBox.DataSource = M1DP_form.TransitionData_pair;
            if (toolWindow.WindowImage.GetImage != null)
                HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
        }

        private void TransitionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (M1DP_form.measuretype == (int)MeasureType.pos)
                M1DP_form.transition_pos = (string)TransitionBox.SelectedValue;
            else if (M1DP_form.measuretype == (int)MeasureType.pair)
                M1DP_form.transition_pair = (string)TransitionBox.SelectedValue;

            Showresult();

        }

        private void SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            M1DP_form.select = (string)SelectBox.SelectedValue;
            if(M1DP_form.loadfinish)
                Showresult();
        }



        private void Showresult() {

            toolWindow.Clear_Object_disp();
            switch (M1DP_form.measuretype)
            {
                case (int)MeasureType.pos:
                    if (M1DP_in.region_line.line_rec.ROI != null)
                    {
                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
                        HOperatorSet.GenMeasureRectangle2(M1DP_in.region_line.line_rec.row, M1DP_in.region_line.line_rec.column, M1DP_in.region_line.line_rec.phi, M1DP_in.region_line.line_rec.length1, M1DP_form.ROIweight,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP_form.hv_MeasureHandle);
                        HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, M1DP_form.hv_MeasureHandle, M1DP_form.sigma, M1DP_form.threshold,
                          M1DP_form.transition_pos, M1DP_form.select, out M1DP_form.hv_RowEdgeFirst, out M1DP_form.hv_ColumnEdgeFirst, out M1DP_form.hv_AmplitudeFirst, out M1DP_form.hv_Distance);
                        HOperatorSet.GenCrossContourXld(out M1DP_form.ho_CrossFirst, M1DP_form.hv_RowEdgeFirst, M1DP_form.hv_ColumnEdgeFirst, M1DP_form.ROIweight * 2, M1DP_in.region_line.line_rec.phi);
                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP_form.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.CloseMeasure(M1DP_form.hv_MeasureHandle);
                        set_list(M1DP_form.hv_RowEdgeFirst, M1DP_form.hv_ColumnEdgeFirst, M1DP_form.hv_AmplitudeFirst, M1DP_form.hv_Distance, result_list);
                    }
                    break;

                case (int)MeasureType.pair:

                    if (M1DP_in.region_line.line_rec.ROI != null)
                    {
                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
                        HOperatorSet.GenMeasureRectangle2(M1DP_in.region_line.line_rec.row, M1DP_in.region_line.line_rec.column, M1DP_in.region_line.line_rec.phi, M1DP_in.region_line.line_rec.length1, M1DP_form.ROIweight,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP_form.hv_MeasureHandle);
                        HOperatorSet.MeasurePairs(toolWindow.WindowImage.GetImage, M1DP_form.hv_MeasureHandle, M1DP_form.sigma, M1DP_form.threshold, M1DP_form.transition_pair, M1DP_form.select,
                            out M1DP_form.hv_RowEdgeFirst, out M1DP_form.hv_ColumnEdgeFirst, out M1DP_form.hv_AmplitudeFirst, out M1DP_form.hv_RowEdgeSecond,
                            out M1DP_form.hv_ColumnEdgeSecond, out M1DP_form.hv_AmplitudeSecond, out M1DP_form.hv_PinWidth, out M1DP_form.hv_PinDistance);

                        HOperatorSet.GenCrossContourXld(out M1DP_form.ho_CrossFirst, M1DP_form.hv_RowEdgeFirst, M1DP_form.hv_ColumnEdgeFirst, M1DP_form.ROIweight * 2, M1DP_in.region_line.line_rec.phi);
                        HOperatorSet.GenCrossContourXld(out M1DP_form.ho_CrossSecond, M1DP_form.hv_RowEdgeSecond, M1DP_form.hv_ColumnEdgeSecond, M1DP_form.ROIweight * 2, M1DP_in.region_line.line_rec.phi);

                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP_form.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP_form.ho_CrossSecond, toolWindow.Window.HalconWindow);
                        HOperatorSet.CloseMeasure(M1DP_form.hv_MeasureHandle);
                    }
                    break;
            }
            if (M1DP_in.region_line.line_rec.ROI!=null && M1DP_form.ho_CrossFirst != null) {
                M1DP_form.temp1 = M1DP_in.region_line.line_rec.ROI.Clone();
                M1DP_form.temp2 = M1DP_form.ho_CrossFirst.Clone();
                toolWindow.Add_Object_disp(M1DP_form.temp1, "yellow", "margin", 1);
                toolWindow.Add_Object_disp(M1DP_form.temp2, "yellow", "margin", 1);
                if (Eage_num.Maximum > 1)
                {
                    Eage_num.Value = 2;
                    Eage_num.Value = 1;
                }
            }
            if (M1DP_form.ho_CrossSecond != null)
            {
                M1DP_form.temp3 = M1DP_form.ho_CrossSecond.Clone();
                toolWindow.Add_Object_disp(M1DP_form.temp3, "yellow", "margin", 1);
                if (Eage_num.Maximum > 1)
                {
                    Eage_num.Value = 2;
                    Eage_num.Value = 1;
                }
            }
        }

        private void set_list(HTuple hv_RowEdge, HTuple hv_ColumnEdge, HTuple hv_Amplitude, HTuple hv_Distance, System.Windows.Forms.ListView listView)
        {
            listView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            listView.Items.Clear();
            for (int i = 0; i < hv_RowEdge.Length; i++)
            {

                string i_string = Convert.ToString(i);

                HTuple hv_RowEdge_string;
                HTuple hv_ColumnEdge_string;
                HTuple hv_Amplitude_string;
                HTuple hv_Distance_string;

                HOperatorSet.TupleString(hv_RowEdge, ".7f", out hv_RowEdge_string);
                HOperatorSet.TupleString(hv_ColumnEdge, ".7f", out hv_ColumnEdge_string);
                HOperatorSet.TupleString(hv_Amplitude, ".7f", out hv_Amplitude_string);
                HOperatorSet.TupleString(hv_Distance, ".7f", out hv_Distance_string);

                listView.Items.Add(i_string, i_string, 0);
                listView.Items[i_string].SubItems.Add(hv_RowEdge_string[i]);
                listView.Items[i_string].SubItems.Add(hv_ColumnEdge_string[i]);
                listView.Items[i_string].SubItems.Add(hv_Amplitude_string[i]);

                if (i != hv_RowEdge.Length - 1)
                    listView.Items[i_string].SubItems.Add(hv_Distance_string[i]);

            }
            listView.EndUpdate();  //结束数据处理，UI界面一次性绘制。  
        }

                

        private void Eage_num_ValueChanged(object sender, EventArgs e)
        {
            if (M1DP_form.hv_RowEdgeFirst.Length != 0)
                Eage_num.Maximum = M1DP_form.hv_RowEdgeFirst.Length ;
            else
                Eage_num.Maximum = 2;

            HTuple hv_Width, hv_Height;
            HObject Temp;

            HOperatorSet.GetImageSize(M1DP_form.Measure_Image.GetImage, out hv_Width, out hv_Height);
            HOperatorSet.SetSystem("width", hv_Width);
            HOperatorSet.SetSystem("height", hv_Height);

            if ((int)Eage_num.Value < M1DP_form.hv_RowEdgeFirst.Length+1)
            {
                hv_Height = M1DP_form.hv_RowEdgeFirst[(int)Eage_num.Value-1];
                hv_Width = M1DP_form.hv_ColumnEdgeFirst[(int)Eage_num.Value-1];
                HOperatorSet.SetPart(EageWindow.HalconWindow, hv_Height - 100, hv_Width - 100, hv_Height + 100, hv_Width + 100);
                HOperatorSet.ClearWindow(EageWindow.HalconWindow);

                HOperatorSet.GenCrossContourXld(out Temp, hv_Height, hv_Width, ROIWeight_trackBar.Value * 2, M1DP_in.region_line.line_rec.phi);

                HOperatorSet.SetColor(EageWindow.HalconWindow, "yellow");
                HOperatorSet.SetDraw(EageWindow.HalconWindow, "margin");
                HOperatorSet.SetLineWidth(EageWindow.HalconWindow, 1);

                HOperatorSet.DispObj(M1DP_form.Measure_Image.GetImage, EageWindow.HalconWindow);
                HOperatorSet.DispObj(Temp, EageWindow.HalconWindow);
            }
            else
            {
                hv_Height = 0;
                hv_Width = 0;
                HOperatorSet.ClearWindow(EageWindow.HalconWindow);
            }
        }
        
        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (M1DP_form.loadfinish)
            {
                M1DP_form.Measure_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage.CopyImagetoThis(M1DP_form.Measure_Image.GetImage);
                toolWindow.showImage();
                Showresult();
            }
        }

        private void Measure_1D_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果已經設定過了則不要清除資訊
            if (!M1DP_form.setornot)
            {
                EageWindow.HalconWindow.ClearWindow();
                toolWindow.ClearAll();
                result_list.Clear();

            }
            M1DP_form.loadfinish = false;
            M1DP_form.ifopenformornot = false;
            Hide();
        }
    }
}
