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
    public partial class Measure_2D_Circle : Form
    {
        
        public Measure_2D_Circle_parameter_in M2DCP_in = new Measure_2D_Circle_parameter_in();
        public Measure_2D_Circle_parameter_out M2DCP_out = new Measure_2D_Circle_parameter_out();
        private Measure_2D_Circle_parameter_form M2DCP_form = new Measure_2D_Circle_parameter_form();

        public Measure_2D_Circle()
        {
            InitializeComponent();
        }

        private void Measure_2D_Circle_Activated(object sender, EventArgs e)
        {
            if (M2DCP_form.ifopenformornot == false)
            {
                M2DCP_in.Length1 = 20;
                M2DCP_in.Length2 = 5;
                M2DCP_in.Sigma = 1;
                M2DCP_in.Threshold = 10;

                this.Length1_trackBar.Value = 20;
                this.Length2_trackBar.Value = 5;
                this.Sigma_trackBar.Value = 1;
                this.Threshold_trackBar.Value = 10;

                M2DCP_form.ifopenformornot = true;
                M2DCP_form.SelectImage.Clear();
                for (int i = 0; i < M2DCP_in.O_T.Count; i++)
                {
                    for (int j = 0; j < M2DCP_in.O_T[i].OImage.Count; j++)
                    {
                        if (M2DCP_in.O_T[i].OImage[j] != null)
                        {
                            SelectImageNName M1S = new SelectImageNName();
                            M1S.Image = M2DCP_in.O_T[i].OImage[j];
                            M1S.ImageName = (string)M2DCP_in.O_T[i].OImageName[j];
                            M2DCP_form.SelectImage.Add(M1S);

                            index_ij ij_temp = new index_ij();
                            ij_temp.i = i;
                            ij_temp.j = j;
                            M2DCP_form.index.Add(ij_temp);
                        }
                    }
                }
                whichpicture.DataSource = null;
                whichpicture.DataSource = M2DCP_form.SelectImage;
                whichpicture.DisplayMember = "ImageName";
                whichpicture.ValueMember = "Image";
                M2DCP_form.loadfinish = true;
                
                    

                M2DCP_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                if(M2DCP_form.src_Image.GetImage!=null)
                    M2DCP_form.src_Image.GetImageSize();

                toolWindow.WindowImage.SetImage = M2DCP_form.src_Image.GetImage;
                toolWindow1.WindowImage.SetImage = M2DCP_form.src_Image.GetImage;

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
            M2DCP_in.Length1 = (int)this.Length1.Value;
            Showresult();
        }

        private void Length1_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length1.Value = (int)this.Length1_trackBar.Value;
            M2DCP_in.Length1 = (int)this.Length1_trackBar.Value;
        }

        private void Length2_ValueChanged(object sender, EventArgs e)
        {
            this.Length2_trackBar.Value = (int)this.Length2.Value;
            M2DCP_in.Length2 = (int)this.Length2.Value;
            Showresult();
        }

        private void Length2_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Length2.Value = (int)this.Length2_trackBar.Value;
            M2DCP_in.Length2 = (int)this.Length2_trackBar.Value;
        }

        private void Sigma_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma_trackBar.Value = (int)this.Sigma.Value;
            M2DCP_in.Sigma = (int)this.Sigma.Value;
            Showresult();
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Sigma.Value = (int)this.Sigma_trackBar.Value;
            M2DCP_in.Sigma = (int)this.Sigma_trackBar.Value;
        }

        private void Threshold_ValueChanged(object sender, EventArgs e)
        {
            this.Length1_trackBar.Value = (int)this.Length1.Value;
            M2DCP_in.Length1 = (int)this.Length1.Value;
            Showresult();
        }
        private void Threshold_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Threshold.Value = (int)this.Threshold_trackBar.Value;
            M2DCP_in.Threshold = (int)this.Threshold_trackBar.Value;
        }

        public void run()
        {
            M2DCP_form.src_Image.SetImage = M2DCP_in.O_T[M2DCP_form.index[whichpicture.SelectedIndex].i].OImage[M2DCP_form.index[whichpicture.SelectedIndex].j];
            HOperatorSet.CreateMetrologyModel(out M2DCP_form.hv_MetrologyHandle);
            HOperatorSet.SetMetrologyModelImageSize(M2DCP_form.hv_MetrologyHandle, M2DCP_form.src_Image.GetWidth, M2DCP_form.src_Image.GetHeight);
            HOperatorSet.AddMetrologyObjectCircleMeasure(M2DCP_form.hv_MetrologyHandle, M2DCP_in.region_circle.circle.row,
                    M2DCP_in.region_circle.circle.column, M2DCP_in.region_circle.circle.radius, M2DCP_in.Length1, M2DCP_in.Length2,
                    M2DCP_in.Sigma, M2DCP_in.Threshold, new HTuple(), new HTuple(), out M2DCP_form.hv_MetrologyCircleIndices);
            HOperatorSet.ApplyMetrologyModel(M2DCP_form.src_Image.GetImage, M2DCP_form.hv_MetrologyHandle);
            HOperatorSet.GetMetrologyObjectResultContour(out M2DCP_form.ho_Contours, M2DCP_form.hv_MetrologyHandle, "all", "all", 1.5);
            HOperatorSet.GetMetrologyObjectMeasures(out M2DCP_form.ho_Contour, M2DCP_form.hv_MetrologyHandle, "all", "all", out M2DCP_form.hv_Row1, out M2DCP_form.hv_Column1);
            HOperatorSet.GetMetrologyObjectResult(M2DCP_form.hv_MetrologyHandle, "all", "all", "result_type", "all_param", out M2DCP_form.hv_Parameter);

            M2DCP_out.dst_circle.row = M2DCP_form.hv_Parameter[0];
            M2DCP_out.dst_circle.column = M2DCP_form.hv_Parameter[1];
            M2DCP_out.dst_circle.radius = M2DCP_form.hv_Parameter[2];
        }

        private void Showresult()
        {
            if (M2DCP_form.hv_MetrologyHandle != null)
            {
                HOperatorSet.ClearMetrologyModel(M2DCP_form.hv_MetrologyHandle);
                HOperatorSet.CreateMetrologyModel(out M2DCP_form.hv_MetrologyHandle);
                HOperatorSet.SetMetrologyModelImageSize(M2DCP_form.hv_MetrologyHandle, M2DCP_form.src_Image.GetWidth, M2DCP_form.src_Image.GetHeight);

                HOperatorSet.AddMetrologyObjectCircleMeasure(M2DCP_form.hv_MetrologyHandle, M2DCP_in.region_circle.circle.row,
                    M2DCP_in.region_circle.circle.column, M2DCP_in.region_circle.circle.radius, M2DCP_in.Length1, M2DCP_in.Length2,
                    M2DCP_in.Sigma, M2DCP_in.Threshold, new HTuple(), new HTuple(), out M2DCP_form.hv_MetrologyCircleIndices);
                HOperatorSet.ApplyMetrologyModel(M2DCP_form.src_Image.GetImage, M2DCP_form.hv_MetrologyHandle);
                HOperatorSet.GetMetrologyObjectResultContour(out M2DCP_form.ho_Contours, M2DCP_form.hv_MetrologyHandle, "all", "all", 1.5);
                HOperatorSet.GetMetrologyObjectMeasures(out M2DCP_form.ho_Contour, M2DCP_form.hv_MetrologyHandle, "all","all", out M2DCP_form.hv_Row1, out M2DCP_form.hv_Column1);
                HOperatorSet.GetMetrologyObjectResult(M2DCP_form.hv_MetrologyHandle, "all", "all", "result_type", "all_param", out M2DCP_form.hv_Parameter);

                HOperatorSet.GenCrossContourXld(out M2DCP_form.ho_Cross, M2DCP_form.hv_Row1, M2DCP_form.hv_Column1, 6, 0.785398);                
                toolWindow1.Window.HalconWindow.ClearWindow();
                toolWindow1.WindowImage.SetImage = M2DCP_form.src_Image.GetImage;
                toolWindow1.Add_Object_disp(M2DCP_form.ho_Cross, "blue", "margin", 1);
                toolWindow1.Add_Object_disp(M2DCP_form.ho_Contours, "red", "margin", 1);
                toolWindow1.showImage();
            }

        }

        private void DrawROI_button_Click(object sender, EventArgs e)
        {
            toolWindow1.Window.Focus();
            toolWindow1.Clear_Object_disp();
            toolWindow1.WindowImage.ShowImage_autosize(toolWindow1.Window.HalconWindow);
            M2DCP_in.region_circle.DrawCircle(toolWindow1.Window.HalconWindow);
            M2DCP_in.region_circle.showROI(toolWindow1.Window.HalconWindow, (int)Shape.Line_rec, "yellow", "margin", 1);
            HOperatorSet.CreateMetrologyModel(out M2DCP_form.hv_MetrologyHandle);
            Showresult();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            M2DCP_form.loadfinish = false;
            if (M2DCP_form.hv_Row1 != null)
            {
                M2DCP_out.setornot = true;
                M2DCP_form.ifopenformornot = false;
                M2DCP_out.dst_circle.row = M2DCP_form.hv_Parameter[0];
                M2DCP_out.dst_circle.column = M2DCP_form.hv_Parameter[1];
                M2DCP_out.dst_circle.radius = M2DCP_form.hv_Parameter[2];
            }

            Hide();
        }
        
        private void whichpicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (M2DCP_form.loadfinish)
            {
                toolWindow.ClearAll();
                toolWindow1.ClearAll();
                M2DCP_form.src_Image.SetImage = (HObject)whichpicture.SelectedValue;
                toolWindow.WindowImage = M2DCP_form.src_Image;
                if(toolWindow.WindowImage!=null)
                    toolWindow.showImage();
                toolWindow1.WindowImage = M2DCP_form.src_Image;
                if (toolWindow1.WindowImage != null)
                    toolWindow1.showImage();
            }
        }
        private void ClearAllToolWindow()
        {
            toolWindow.ClearAll();
            toolWindow1.ClearAll();
        }

        private void Measure_2D_Circle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果已經設定過了則不要清除資訊
            if (!M2DCP_out.setornot)
            {
                ClearAllToolWindow();
            }
            M2DCP_form.ifopenformornot = false;
            Hide();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
           toolWindow.showImage();
           toolWindow1.showImage();
         }
    }
}
