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


    /// <summary>
    /// MeasureParameter
    /// </summary>
    public struct Measure1DParameter
    {
        //pair的前標點(ho_CrossFirst)and後標點(ho_CrossSecond)  其中ho_CrossFirst與pos模式下的標點共用
        public HObject ho_CrossFirst;
        public HObject ho_CrossSecond;
        //測量控制器
        public HTuple hv_MeasureHandle;

        //********測量參數(in)**********
        public HTuple sigma;
        public HTuple threshold;
        public HTuple transition_pair;
        public HTuple transition_pos;
        public HTuple select;
        //********測量參數(out)**********
        public HTuple hv_RowEdgeFirst;
        public HTuple hv_ColumnEdgeFirst;
        public HTuple hv_AmplitudeFirst;
        public HTuple hv_RowEdgeSecond;
        public HTuple hv_ColumnEdgeSecond;
        public HTuple hv_AmplitudeSecond;
        public HTuple hv_Distance;
        public HTuple hv_PinWidth;
        public HTuple hv_PinDistance;
        public HTuple ROIweight;
    }



    public partial class Measure_1D : Form
    {

        //***********暫存未整理區域***********
        HObject temp1;
        HObject temp2;
        HObject temp3;
        //***********暫存未整理區域***********

        /// <summary>
        /// MeasureParameter 測量參數
        /// </summary>
        private Measure1DParameter M1DP;
        /// <summary>
        /// TransitionData_pair下拉式表單參數
        /// </summary>
        List<string> TransitionData_pair = new List<string>();
        /// <summary>
        /// TransitionData_pos下拉式表單參數
        /// </summary>
        List<string> TransitionData_pos = new List<string>();
        /// <summary>
        /// SelectData下拉式表單參數
        /// </summary>
        List<string> SelectData = new List<string>();
        /// <summary>
        /// SelectImage下拉式表單參數
        /// </summary>
        List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        /// <summary>
        /// 待測圖片
        /// </summary>
        private ImageBase Measure_Image = new ImageBase();
        public HObject MeasureImage { set { Measure_Image.SetImage = value; } }
        /// <summary>
        /// line的ROI
        /// </summary>
        private RegionBase region_line = new RegionBase();


        public List<Object_Table> O_T = new List<Object_Table>();

        public List<PointBase> dstfirstpoint = new List<PointBase>();
        public List<PointBase> dstsecondpoint = new List<PointBase>();

        /// <summary>
        /// 測量模式
        /// </summary>
        int measuretype = 0;
        /// <summary>
        /// 是否設定完成->按下OK鈕
        /// </summary>
        public bool setornot = false;

        List<index_ij> index_img = new List<index_ij>();



        public Measure_1D()
        {
            InitializeComponent();
        }

        bool ifopenformornot = false;
        bool loadfinish = false;
        private void Measure_Activated(object sender, EventArgs e)
        {
            if (!ifopenformornot)
            {
                //如果有圖片則載入圖片至toolWindow視窗裡
                if (Measure_Image.GetImage != null)
                {
                    toolWindow.WindowImage.CopyImagetoThis(Measure_Image.GetImage);
                    toolWindow.Window.Focus();
                    toolWindow.showImage();
                }
                //表格參數預載
                this.MaxEdge.Value = 40;
                this.sigma.Value = 1;
                this.ROIWeight.Value = 30;
                this.MaxEage_trackBar.Value = 40;
                this.Sigma_trackBar.Value = 1;
                this.ROIWeight_trackBar.Value = 30;


                M1DP.transition_pair = MeasureTransition_pair.all.ToString();
                M1DP.transition_pos = MeasureTransition_pos.all.ToString();
                M1DP.select = MeasureSelect.all.ToString();
                M1DP.sigma = 1;
                M1DP.threshold = 40;

                TransitionData_pair.Add(MeasureTransition_pair.all.ToString());
                TransitionData_pair.Add(MeasureTransition_pair.all_strongest.ToString());
                TransitionData_pair.Add(MeasureTransition_pair.negative.ToString());
                TransitionData_pair.Add(MeasureTransition_pair.negative_strongest.ToString());
                TransitionData_pair.Add(MeasureTransition_pair.positive.ToString());
                TransitionData_pair.Add(MeasureTransition_pair.positive_strongest.ToString());

                TransitionData_pos.Add(MeasureTransition_pos.all.ToString());
                TransitionData_pos.Add(MeasureTransition_pos.negative.ToString());
                TransitionData_pos.Add(MeasureTransition_pos.positive.ToString());

                SelectData.Add(MeasureSelect.all.ToString());
                SelectData.Add(MeasureSelect.first.ToString());
                SelectData.Add(MeasureSelect.last.ToString());

                
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
                result_list.Clear();

                result_list.View = View.Details;
                result_list.Columns.Add("編號");
                result_list.Columns.Add("行");
                result_list.Columns.Add("列");
                result_list.Columns.Add("振幅");
                result_list.Columns.Add("距離");
                this.result_list.EndUpdate();


                whichpicture.DataSource = null;
                whichpicture.DataSource = SelectImage;
                whichpicture.DisplayMember = "ImageName";
                whichpicture.ValueMember = "Image";
                loadfinish = true;
                SelectBox.DataSource = null;
                SelectBox.DataSource = SelectData;
                posButton.Checked = true;
                ifopenformornot = true;

                Measure_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage.CopyImagetoThis(Measure_Image.GetImage);
                toolWindow.showImage();
            }
            else
                Showresult();
        }


        public void run()
        {
            Measure_Image.SetImage = O_T[index_img[whichpicture.SelectedIndex].i].OImage[index_img[whichpicture.SelectedIndex].j];
            switch (measuretype)
            {
                case (int)MeasureType.pos:
                    //如果toolWindow視窗裡有影像才執行
                    if (Measure_Image.GetImage != null)
                    {
                        HOperatorSet.GenEmptyObj(out M1DP.ho_CrossFirst);
                        HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row,
                            region_line.line_rec.column, region_line.line_rec.phi,
                            region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP.hv_MeasureHandle);
                        HOperatorSet.MeasurePos(Measure_Image.GetImage, M1DP.hv_MeasureHandle, M1DP.sigma, M1DP.threshold,
                          M1DP.transition_pos, M1DP.select, out M1DP.hv_RowEdgeFirst, out M1DP.hv_ColumnEdgeFirst, out M1DP.hv_AmplitudeFirst, out M1DP.hv_Distance);
                        M1DP.ho_CrossFirst.Dispose();
                        HOperatorSet.CloseMeasure(M1DP.hv_MeasureHandle);
                        dstfirstpoint.Clear();
                        for (int i = 0; i < M1DP.hv_RowEdgeFirst.Length; i++)
                        {
                            PointBase PB_temp = new PointBase();
                            PB_temp.row = M1DP.hv_RowEdgeFirst[i];
                            PB_temp.col = M1DP.hv_ColumnEdgeFirst[i];
                            dstfirstpoint.Add(PB_temp);
                        }
                    }
                    break;

                case (int)MeasureType.pair:

                    if (Measure_Image.GetImage != null)
                    {
                        HOperatorSet.GenEmptyObj(out M1DP.ho_CrossFirst);
                        HOperatorSet.GenEmptyObj(out M1DP.ho_CrossSecond);
                        HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row,
                            region_line.line_rec.column, region_line.line_rec.phi,
                            region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP.hv_MeasureHandle);

                        HOperatorSet.MeasurePairs(Measure_Image.GetImage, M1DP.hv_MeasureHandle, M1DP.sigma, M1DP.threshold, M1DP.transition_pair, M1DP.select,
                            out M1DP.hv_RowEdgeFirst, out M1DP.hv_ColumnEdgeFirst, out M1DP.hv_AmplitudeFirst, out M1DP.hv_RowEdgeSecond,
                            out M1DP.hv_ColumnEdgeSecond, out M1DP.hv_AmplitudeSecond, out M1DP.hv_PinWidth, out M1DP.hv_PinDistance);
                        HOperatorSet.CloseMeasure(M1DP.hv_MeasureHandle);
                        dstfirstpoint.Clear();
                        dstsecondpoint.Clear();
                        for (int i = 0; i < M1DP.hv_RowEdgeFirst.Length; i++)
                        {
                            PointBase PB1_temp = new PointBase();
                            PointBase PB2_temp = new PointBase();
                            PB1_temp.row = M1DP.hv_RowEdgeFirst[i];
                            PB1_temp.col = M1DP.hv_ColumnEdgeFirst[i];
                            PB2_temp.row = M1DP.hv_RowEdgeFirst[i];
                            PB2_temp.col = M1DP.hv_ColumnEdgeFirst[i];
                            dstfirstpoint.Add(PB1_temp);
                            dstsecondpoint.Add(PB2_temp);
                        }
                    }
                    break;

            }

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            HOperatorSet.ClearWindow(EageWindow.HalconWindow);
            toolWindow.Clear_Object_disp();

            switch (measuretype) {
                case (int)MeasureType.pos:
                    //如果toolWindow視窗裡有影像才執行
                    if (toolWindow.WindowImage.GetImage != null)
                    {
                        toolWindow.Window.Focus();

                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);

                        region_line.DrawLine(toolWindow.Window.HalconWindow);
                        region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenEmptyObj(out M1DP.ho_CrossFirst);
                        HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row,
                            region_line.line_rec.column, region_line.line_rec.phi,
                            region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP.hv_MeasureHandle);
                        HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, M1DP.hv_MeasureHandle, M1DP.sigma, M1DP.threshold,
                          M1DP.transition_pos, M1DP.select, out M1DP.hv_RowEdgeFirst, out M1DP.hv_ColumnEdgeFirst, out M1DP.hv_AmplitudeFirst, out M1DP.hv_Distance);
                        M1DP.ho_CrossFirst.Dispose();

                        HOperatorSet.ClearWindow(toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenCrossContourXld(out M1DP.ho_CrossFirst, M1DP.hv_RowEdgeFirst, M1DP.hv_ColumnEdgeFirst,
                            ROIWeight_trackBar.Value * 2, region_line.line_rec.phi);
                        HOperatorSet.DispObj(M1DP.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.CloseMeasure(M1DP.hv_MeasureHandle);
                                                
                        temp1 = region_line.line_rec.ROI.Clone();
                        temp2 = M1DP.ho_CrossFirst.Clone();
                        toolWindow.Add_Object_disp(temp1, "yellow", "margin", 1);
                        toolWindow.Add_Object_disp(temp2, "yellow", "margin", 1);

                        set_list(M1DP.hv_RowEdgeFirst, M1DP.hv_ColumnEdgeFirst, M1DP.hv_AmplitudeFirst, M1DP.hv_Distance, result_list);
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

                        region_line.DrawLine(toolWindow.Window.HalconWindow);
                        region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenEmptyObj(out M1DP.ho_CrossFirst);
                        HOperatorSet.GenEmptyObj(out M1DP.ho_CrossSecond);
                        HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row,
                            region_line.line_rec.column, region_line.line_rec.phi,
                            region_line.line_rec.length1, ROIWeight_trackBar.Value,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP.hv_MeasureHandle);

                        HOperatorSet.MeasurePairs(toolWindow.WindowImage.GetImage, M1DP.hv_MeasureHandle, M1DP.sigma, M1DP.threshold, M1DP.transition_pair, M1DP.select,
                            out M1DP.hv_RowEdgeFirst, out M1DP.hv_ColumnEdgeFirst, out M1DP.hv_AmplitudeFirst, out M1DP.hv_RowEdgeSecond,
                            out M1DP.hv_ColumnEdgeSecond, out M1DP.hv_AmplitudeSecond, out M1DP.hv_PinWidth, out M1DP.hv_PinDistance);

                        M1DP.ho_CrossFirst.Dispose();
                        M1DP.ho_CrossSecond.Dispose();

                        HOperatorSet.ClearWindow(toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        region_line.showROI(toolWindow.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);

                        HOperatorSet.GenCrossContourXld(out M1DP.ho_CrossFirst, M1DP.hv_RowEdgeFirst, M1DP.hv_ColumnEdgeFirst,
                            ROIWeight_trackBar.Value * 2, region_line.line_rec.phi);
                        HOperatorSet.GenCrossContourXld(out M1DP.ho_CrossSecond, M1DP.hv_RowEdgeSecond, M1DP.hv_ColumnEdgeSecond,
                            ROIWeight_trackBar.Value * 2, region_line.line_rec.phi);

                        temp1 = region_line.line_rec.ROI.Clone();
                        temp2 = M1DP.ho_CrossFirst.Clone();
                        temp3 = M1DP.ho_CrossSecond.Clone();

                        toolWindow.Add_Object_disp(temp1, "yellow", "margin", 1);
                        toolWindow.Add_Object_disp(temp2, "yellow", "margin", 1);
                        toolWindow.Add_Object_disp(temp3, "yellow", "margin", 1);

                        HOperatorSet.DispObj(M1DP.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP.ho_CrossSecond, toolWindow.Window.HalconWindow);

                        HOperatorSet.CloseMeasure(M1DP.hv_MeasureHandle);
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
            setornot = true;
            ifopenformornot = true;
            switch (measuretype)
            {
                case (int)MeasureType.pos:
                    dstfirstpoint.Clear();
                    for (int i = 0; i < M1DP.hv_RowEdgeFirst.Length; i++)
                    {                        
                        PointBase PB_temp = new PointBase();
                        PB_temp.row = M1DP.hv_RowEdgeFirst[i];
                        PB_temp.col = M1DP.hv_ColumnEdgeFirst[i];
                        dstfirstpoint.Add(PB_temp);
                    }
                    break;

                case (int)MeasureType.pair:
                    dstfirstpoint.Clear();
                    dstsecondpoint.Clear();
                    for (int i = 0; i < M1DP.hv_RowEdgeFirst.Length; i++)
                    {
                        PointBase PB1_temp = new PointBase();
                        PointBase PB2_temp = new PointBase();
                        PB1_temp.row = M1DP.hv_RowEdgeFirst[i];
                        PB1_temp.col = M1DP.hv_ColumnEdgeFirst[i];
                        PB2_temp.row = M1DP.hv_RowEdgeFirst[i];
                        PB2_temp.col = M1DP.hv_ColumnEdgeFirst[i];
                        dstfirstpoint.Add(PB1_temp);
                        dstsecondpoint.Add(PB2_temp);
                    }

                    break;

            }
            Hide();
        }

        private void MaxEage_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.MaxEdge.Value = this.MaxEage_trackBar.Value;
            M1DP.threshold = (int)this.MaxEage_trackBar.Value;
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.sigma.Value = this.Sigma_trackBar.Value;
            M1DP.sigma = (int)this.Sigma_trackBar.Value;
        }

        private void ROIWeight_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.ROIWeight.Value = this.ROIWeight_trackBar.Value;
            M1DP.ROIweight = (int)this.ROIWeight_trackBar.Value;
        }

        private void MaxEdge_ValueChanged(object sender, EventArgs e)
        {
            this.MaxEage_trackBar.Value = (int)this.MaxEdge.Value;
            M1DP.threshold = (int)this.MaxEdge.Value;
            Showresult();

        }

        private void sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.sigma.Value;
            M1DP.sigma = (int)this.sigma.Value;
            Showresult();
        }

        private void ROIWeight_ValueChanged(object sender, EventArgs e)
        {
            this.ROIWeight_trackBar.Value = (int)this.ROIWeight.Value;
            M1DP.ROIweight = (int)this.ROIWeight.Value;
            Showresult();
        }

        private void posButton_CheckedChanged(object sender, EventArgs e)
        {
            measuretype = 0;
            region_line.ClearALL();
            TransitionBox.DataSource = TransitionData_pos;
            if(toolWindow.WindowImage.GetImage != null)
                HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
        }

        private void pairButton_CheckedChanged(object sender, EventArgs e)
        {
            measuretype = 1;
            region_line.ClearALL();
            TransitionBox.DataSource = TransitionData_pair;
            if (toolWindow.WindowImage.GetImage != null)
                HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
        }

        private void TransitionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measuretype == (int)MeasureType.pos)
                M1DP.transition_pos = (string)TransitionBox.SelectedValue;
            else if (measuretype == (int)MeasureType.pair)
                M1DP.transition_pair = (string)TransitionBox.SelectedValue;

            Showresult();

        }

        private void SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            M1DP.select = (string)SelectBox.SelectedValue;
            
                Showresult();
        }



        private void Showresult() {

            toolWindow.Clear_Object_disp();
            switch (measuretype)
            {
                case (int)MeasureType.pos:
                    if (region_line.line_rec.ROI != null)
                    {
                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
                        HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row, region_line.line_rec.column, region_line.line_rec.phi, region_line.line_rec.length1, M1DP.ROIweight,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP.hv_MeasureHandle);
                        HOperatorSet.MeasurePos(toolWindow.WindowImage.GetImage, M1DP.hv_MeasureHandle, M1DP.sigma, M1DP.threshold,
                          M1DP.transition_pos, M1DP.select, out M1DP.hv_RowEdgeFirst, out M1DP.hv_ColumnEdgeFirst, out M1DP.hv_AmplitudeFirst, out M1DP.hv_Distance);
                        HOperatorSet.GenCrossContourXld(out M1DP.ho_CrossFirst, M1DP.hv_RowEdgeFirst, M1DP.hv_ColumnEdgeFirst, M1DP.ROIweight * 2, region_line.line_rec.phi);
                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.CloseMeasure(M1DP.hv_MeasureHandle);
                        set_list(M1DP.hv_RowEdgeFirst, M1DP.hv_ColumnEdgeFirst, M1DP.hv_AmplitudeFirst, M1DP.hv_Distance, result_list);
                    }
                    break;

                case (int)MeasureType.pair:

                    if (region_line.line_rec.ROI != null)
                    {
                        toolWindow.WindowImage.ShowImage_autosize(toolWindow.Window.HalconWindow);
                        HOperatorSet.GenMeasureRectangle2(region_line.line_rec.row, region_line.line_rec.column, region_line.line_rec.phi, region_line.line_rec.length1, M1DP.ROIweight,
                            toolWindow.WindowImage.GetWidth, toolWindow.WindowImage.GetHeight, "nearest_neighbor", out M1DP.hv_MeasureHandle);
                        HOperatorSet.MeasurePairs(toolWindow.WindowImage.GetImage, M1DP.hv_MeasureHandle, M1DP.sigma, M1DP.threshold, M1DP.transition_pair, M1DP.select,
                            out M1DP.hv_RowEdgeFirst, out M1DP.hv_ColumnEdgeFirst, out M1DP.hv_AmplitudeFirst, out M1DP.hv_RowEdgeSecond,
                            out M1DP.hv_ColumnEdgeSecond, out M1DP.hv_AmplitudeSecond, out M1DP.hv_PinWidth, out M1DP.hv_PinDistance);

                        HOperatorSet.GenCrossContourXld(out M1DP.ho_CrossFirst, M1DP.hv_RowEdgeFirst, M1DP.hv_ColumnEdgeFirst, M1DP.ROIweight * 2, region_line.line_rec.phi);
                        HOperatorSet.GenCrossContourXld(out M1DP.ho_CrossSecond, M1DP.hv_RowEdgeSecond, M1DP.hv_ColumnEdgeSecond, M1DP.ROIweight * 2, region_line.line_rec.phi);

                        HOperatorSet.DispObj(toolWindow.WindowImage.GetImage, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP.ho_CrossFirst, toolWindow.Window.HalconWindow);
                        HOperatorSet.DispObj(M1DP.ho_CrossSecond, toolWindow.Window.HalconWindow);
                        HOperatorSet.CloseMeasure(M1DP.hv_MeasureHandle);
                    }
                    break;
            }
            if (region_line.line_rec.ROI!=null && M1DP.ho_CrossFirst != null) {
                temp1 = region_line.line_rec.ROI.Clone();
                temp2 = M1DP.ho_CrossFirst.Clone();
                toolWindow.Add_Object_disp(temp1, "yellow", "margin", 1);
                toolWindow.Add_Object_disp(temp2, "yellow", "margin", 1);
                if (Eage_num.Maximum > 1)
                {
                    Eage_num.Value = 2;
                    Eage_num.Value = 1;
                }
            }
            if (M1DP.ho_CrossSecond != null)
            {
                temp3 = M1DP.ho_CrossSecond.Clone();
                toolWindow.Add_Object_disp(temp3, "yellow", "margin", 1);
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
            if (M1DP.hv_RowEdgeFirst.Length != 0)
                Eage_num.Maximum = M1DP.hv_RowEdgeFirst.Length ;
            else
                Eage_num.Maximum = 2;

            HTuple hv_Width, hv_Height;
            HObject Temp;

            HOperatorSet.GetImageSize(Measure_Image.GetImage, out hv_Width, out hv_Height);
            HOperatorSet.SetSystem("width", hv_Width);
            HOperatorSet.SetSystem("height", hv_Height);

            if ((int)Eage_num.Value < M1DP.hv_RowEdgeFirst.Length+1)
            {
                hv_Height = M1DP.hv_RowEdgeFirst[(int)Eage_num.Value-1];
                hv_Width = M1DP.hv_ColumnEdgeFirst[(int)Eage_num.Value-1];
                HOperatorSet.SetPart(EageWindow.HalconWindow, hv_Height - 100, hv_Width - 100, hv_Height + 100, hv_Width + 100);
                HOperatorSet.ClearWindow(EageWindow.HalconWindow);

                HOperatorSet.GenCrossContourXld(out Temp, hv_Height, hv_Width, ROIWeight_trackBar.Value * 2, region_line.line_rec.phi);

                HOperatorSet.SetColor(EageWindow.HalconWindow, "yellow");
                HOperatorSet.SetDraw(EageWindow.HalconWindow, "margin");
                HOperatorSet.SetLineWidth(EageWindow.HalconWindow, 1);

                HOperatorSet.DispObj(Measure_Image.GetImage, EageWindow.HalconWindow);
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
            if (loadfinish)
            {
                Measure_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage.CopyImagetoThis(Measure_Image.GetImage);
                toolWindow.showImage();
                Showresult();
            }
        }

        private void Measure_1D_FormClosing(object sender, FormClosingEventArgs e)
        {
            ifopenformornot = true;
            Hide();
        }
    }
}
