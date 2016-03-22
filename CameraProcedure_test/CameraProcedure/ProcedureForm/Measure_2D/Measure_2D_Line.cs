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
    public partial class Measure_2D_Line : Form
    {

        public Measure2DlineParameter_in M2DLP_in = new Measure2DlineParameter_in();
        public Measure2DlineParameter_out M2DLP_out = new Measure2DlineParameter_out();
        private Measure2DlineParameter_form M2DLP_form = new Measure2DlineParameter_form();

        public Measure_2D_Line()
        {
            InitializeComponent();
        }

        private void Measure_2D_Line_Activated(object sender, EventArgs e)
        {
            if (M2DLP_form.ifopenformornot == false)
            {
                M2DLP_in.Length1 = 20;
                M2DLP_in.Length2 = 5;
                M2DLP_in.Sigma = 1;
                M2DLP_in.Threshold = 10;

                this.Length1_trackBar.Value = 20;
                this.Length2_trackBar.Value = 5;
                this.Sigma_trackBar.Value = 1;
                this.Threshold_trackBar.Value = 10;

                M2DLP_form.ifopenformornot = true;
                M2DLP_form.SelectImage.Clear();
                for (int i = 0; i < M2DLP_in.O_T.Count; i++)
                {
                    for (int j = 0; j < M2DLP_in.O_T[i].OImage.Count; j++)
                    {
                        if (M2DLP_in.O_T[i].OImage[j] != null)
                        {
                            SelectImageNName M1S = new SelectImageNName();
                            M1S.Image = M2DLP_in.O_T[i].OImage[j];
                            M1S.ImageName = (string)M2DLP_in.O_T[i].OImageName[j];
                            M2DLP_form.SelectImage.Add(M1S);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            M2DLP_form.index.Add(ij_temp);
                        }
                    }
                }
                whichpicture.DataSource = null;
                whichpicture.DataSource = M2DLP_form.SelectImage;
                whichpicture.DisplayMember = "ImageName";
                whichpicture.ValueMember = "Image";
                M2DLP_form.loadfinish = true;



                M2DLP_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                if (M2DLP_form.src_Image.GetImage != null)
                    M2DLP_form.src_Image.GetImageSize();

                toolWindow.WindowImage.SetImage = M2DLP_form.src_Image.GetImage;
                toolWindow1.WindowImage.SetImage = M2DLP_form.src_Image.GetImage;

                tabControl.SelectedTab = setimage;
            }

            if (toolWindow.WindowImage.GetImage != null)
                toolWindow.showImage();
            if (toolWindow1.WindowImage.GetImage != null)
                toolWindow1.showImage();
        }

        private void Length1_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DLP_in.Length1 = (int)this.Length1.Value;
            Showresult();
        }

        private void Length1_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length1.Value = (int)this.Length1_trackBar.Value;
            M2DLP_in.Length1 = (int)this.Length1_trackBar.Value;
        }

        private void Length2_ValueChanged(object sender, EventArgs e)
        {
            this.Length2_trackBar.Value = (int)this.Length2.Value;
            M2DLP_in.Length2 = (int)this.Length2.Value;
            Showresult();
        }

        private void Length2_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length2.Value = (int)this.Length2_trackBar.Value;
            M2DLP_in.Length2 = (int)this.Length2_trackBar.Value;
        }

        private void Sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.Sigma.Value;
            M2DLP_in.Sigma = (int)this.Sigma.Value;
            Showresult();
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma.Value = (int)this.Sigma_trackBar.Value;
            M2DLP_in.Sigma = (int)this.Sigma_trackBar.Value;
        }

        private void Threshold_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DLP_in.Length1 = (int)this.Length1.Value;
            Showresult();
        }
        private void Threshold_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Threshold.Value = (int)this.Threshold_trackBar.Value;
            M2DLP_in.Threshold = (int)this.Threshold_trackBar.Value;
        }

        public void run()
        {
            M2DLP_form.src_Image.SetImage = M2DLP_in.O_T[M2DLP_form.index[whichpicture.SelectedIndex].i].OImage[M2DLP_form.index[whichpicture.SelectedIndex].j];
            HOperatorSet.ClearMetrologyModel(M2DLP_form.hv_MetrologyHandle);
            HOperatorSet.CreateMetrologyModel(out M2DLP_form.hv_MetrologyHandle);
            HOperatorSet.SetMetrologyModelImageSize(M2DLP_form.hv_MetrologyHandle, M2DLP_form.src_Image.GetWidth, M2DLP_form.src_Image.GetHeight);

            HOperatorSet.AddMetrologyObjectLineMeasure(M2DLP_form.hv_MetrologyHandle, M2DLP_in.region_line.line.row_start,
                M2DLP_in.region_line.line.column_start, M2DLP_in.region_line.line.row_end, M2DLP_in.region_line.line.column_end, M2DLP_in.Length1,
                M2DLP_in.Length2, M2DLP_in.Sigma, M2DLP_in.Threshold, "measure_transition", "all", out M2DLP_form.hv_Index);
            HOperatorSet.ApplyMetrologyModel(M2DLP_form.src_Image.GetImage, M2DLP_form.hv_MetrologyHandle);
            HOperatorSet.GetMetrologyObjectResult(M2DLP_form.hv_MetrologyHandle, "all", "all", "result_type", "all_param", out M2DLP_form.hv_Par);
            //M2DP.ho_MeasureConts.Dispose();
            HOperatorSet.GetMetrologyObjectMeasures(out M2DLP_form.ho_MeasureConts, M2DLP_form.hv_MetrologyHandle, "all", "all", out M2DLP_form.hv_Rtmp, out M2DLP_form.hv_Ctmp);
            HOperatorSet.GetMetrologyObjectResultContour(out M2DLP_form.ho_Contours, M2DLP_form.hv_MetrologyHandle, "all", "all", 1.5);
            if (M2DLP_form.hv_Par != null)
            {
                M2DLP_out.dst_line.row_start = M2DLP_form.hv_Par[0];
                M2DLP_out.dst_line.column_start = M2DLP_form.hv_Par[1];
                M2DLP_out.dst_line.row_end = M2DLP_form.hv_Par[2];
                M2DLP_out.dst_line.column_end = M2DLP_form.hv_Par[3];
            }

        }

        private void Showresult()
        {
            if (M2DLP_form.hv_MetrologyHandle != null)
            {
                HOperatorSet.ClearMetrologyModel(M2DLP_form.hv_MetrologyHandle);
                HOperatorSet.CreateMetrologyModel(out M2DLP_form.hv_MetrologyHandle);
                HOperatorSet.SetMetrologyModelImageSize(M2DLP_form.hv_MetrologyHandle, M2DLP_form.src_Image.GetWidth, M2DLP_form.src_Image.GetHeight);

                HOperatorSet.AddMetrologyObjectLineMeasure(M2DLP_form.hv_MetrologyHandle, M2DLP_in.region_line.line.row_start,
                    M2DLP_in.region_line.line.column_start, M2DLP_in.region_line.line.row_end, M2DLP_in.region_line.line.column_end, M2DLP_in.Length1,
                    M2DLP_in.Length2, M2DLP_in.Sigma, M2DLP_in.Threshold, "measure_transition", "all", out M2DLP_form.hv_Index);
                HOperatorSet.ApplyMetrologyModel(M2DLP_form.src_Image.GetImage, M2DLP_form.hv_MetrologyHandle);
                HOperatorSet.GetMetrologyObjectResult(M2DLP_form.hv_MetrologyHandle, "all", "all", "result_type", "all_param", out M2DLP_form.hv_Par);
                HOperatorSet.GetMetrologyObjectMeasures(out M2DLP_form.ho_MeasureConts, M2DLP_form.hv_MetrologyHandle, "all", "all", out M2DLP_form.hv_Rtmp, out M2DLP_form.hv_Ctmp);
                HOperatorSet.GetMetrologyObjectResultContour(out M2DLP_form.ho_Contours, M2DLP_form.hv_MetrologyHandle, "all", "all", 1.5);

                HOperatorSet.GenCrossContourXld(out M2DLP_form.ho_Cross, M2DLP_form.hv_Rtmp, M2DLP_form.hv_Ctmp, 6, 0.785398);

                toolWindow1.Window.HalconWindow.ClearWindow();
                toolWindow1.WindowImage.SetImage = M2DLP_form.src_Image.GetImage;
                toolWindow1.Add_Object_disp(M2DLP_form.ho_Cross, "blue", "margin", 1);
                toolWindow1.Add_Object_disp(M2DLP_form.ho_Contours, "red", "margin", 1);
                toolWindow1.showImage();
            }

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            toolWindow1.Window.Focus();
            toolWindow1.Clear_Object_disp();
            toolWindow1.WindowImage.ShowImage_autosize(toolWindow1.Window.HalconWindow);
            M2DLP_in.region_line.DrawLine(toolWindow1.Window.HalconWindow);
            M2DLP_in.region_line.showROI(toolWindow1.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);
            HOperatorSet.CreateMetrologyModel(out M2DLP_form.hv_MetrologyHandle);
            Showresult();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            M2DLP_form.loadfinish = false;
            if (M2DLP_form.hv_Par != null)
            {
                M2DLP_form.ifopenformornot = false;
                M2DLP_out.setornot = true;

                M2DLP_out.dst_line.row_start = M2DLP_form.hv_Par[0];
                M2DLP_out.dst_line.column_start = M2DLP_form.hv_Par[1];
                M2DLP_out.dst_line.row_end = M2DLP_form.hv_Par[2];
                M2DLP_out.dst_line.column_end = M2DLP_form.hv_Par[3];
            }

            Hide();
        }

        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (M2DLP_form.loadfinish)
            {
                toolWindow.ClearAll();
                toolWindow1.ClearAll();
                M2DLP_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage = M2DLP_form.src_Image;
                if (toolWindow.WindowImage != null)
                    toolWindow.showImage();
                toolWindow1.WindowImage = M2DLP_form.src_Image;
                if (toolWindow1.WindowImage != null)
                    toolWindow1.showImage();
            }
        }
        private void ClearAllToolWindow()
        {
            toolWindow.ClearAll();
            toolWindow1.ClearAll();
        }

        private void Measure_2D_Line_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果已經設定過了則不要清除資訊
            if (!M2DLP_out.setornot)
            {
                ClearAllToolWindow();
            }
            M2DLP_form.ifopenformornot = false;
            Hide();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolWindow.showImage();
            toolWindow1.showImage();
        }
    }
}
