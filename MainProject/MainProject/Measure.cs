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

namespace MainProject
{
    public partial class Measure : Form
    {
        private HObject Measure_Image;                                                                  //待測影像
        DrawlinetoRectangle2 drawlinetoRectangle2 = new DrawlinetoRectangle2();                         //畫線轉矩形 
        GenMesure_point mesure_point = new GenMesure_point();
        HTuple H, W;

        public Measure()                                                                                //初始化
        {
            InitializeComponent();
        }

        private void drawline_Click(object sender, EventArgs e)
        {
            measure_window.Focus();                                                                     //聚焦視窗

            HOperatorSet.SetSystem("width", W);
            HOperatorSet.SetSystem("height", H);
            HOperatorSet.SetPart(this.measure_window.HalconWindow, 0, 0, H - 1, W - 1);
            HOperatorSet.DispObj(Measure_Image, measure_window.HalconWindow);                           //刷新頁面

            drawlinetoRectangle2.draw(this.measure_window.HalconWindow);                                //畫測量線段

            mesure_point.dowork(drawlinetoRectangle2, this.measure_window.HalconWindow,                 //開始測量(輸入參數)
                (int)this.sigma.Value, (int)this.MaxEdge.Value, Measure_Image);

            drawlinetoRectangle2.drawROI(this.measure_window.HalconWindow);                             //畫出測量線段

            setlist.set_list(mesure_point.get_RowEdge, mesure_point.get_ColumnEdge,                     //更新表格
                    mesure_point.get_Amplitude, mesure_point.get_Distance, listView);
        }

        private void reset_Click(object sender, EventArgs e)                                            //重新繪線段
        {
            if (Measure_Image != null)
                HOperatorSet.DispObj(Measure_Image, this.measure_window.HalconWindow);
        }

        private void MaxEdge_ValueChanged(object sender, EventArgs e)                                   //MaxEdge數字與拉條連動
        {
            this.MaxEage_trackBar.Value = (int)this.MaxEdge.Value;

        }

        private void sigma_ValueChanged(object sender, EventArgs e)                                     //sigma數字與拉條連動
        {
            this.Sigma_trackBar.Value = (int)this.sigma.Value;
        }

        private void ROIWeight_ValueChanged(object sender, EventArgs e)                                 //ROIWeight數字與拉條連動
        {
            this.ROIWeight_trackBar.Value = (int)this.ROIWeight.Value;
        }

        private void MaxEage_trackBar_ValueChanged(object sender, EventArgs e)                          //MaxEdge數字與拉條連動
        {
            this.MaxEdge.Value = this.MaxEage_trackBar.Value;
            if (drawlinetoRectangle2.get_rectangle_ROI != null)
            {
                HOperatorSet.DispObj(Measure_Image, this.measure_window.HalconWindow);                  //將畫面洗清 預備新顯示新的參數測量結果

                mesure_point.dowork(drawlinetoRectangle2, this.measure_window.HalconWindow,             //重新測量
                    (int)this.sigma.Value, (int)this.MaxEdge.Value, Measure_Image);

                drawlinetoRectangle2.drawROI(this.measure_window.HalconWindow);                         //重新繪製新的測量結果

                setlist.set_list(mesure_point.get_RowEdge, mesure_point.get_ColumnEdge,                 //更新表格
                    mesure_point.get_Amplitude, mesure_point.get_Distance, listView);
            }
        }

        private void Sigma_trackBar_ValueChanged(object sender, EventArgs e)                            //sigma數字與拉條連動
        {
            this.sigma.Value = this.Sigma_trackBar.Value;                                               //以下同MaxEage裡的連動
            if (drawlinetoRectangle2.get_rectangle_ROI != null)
            {
                HOperatorSet.DispObj(Measure_Image, this.measure_window.HalconWindow);

                mesure_point.dowork(drawlinetoRectangle2, this.measure_window.HalconWindow,
                    (int)this.sigma.Value, (int)this.MaxEdge.Value, Measure_Image);

                drawlinetoRectangle2.drawROI(this.measure_window.HalconWindow);

                setlist.set_list(mesure_point.get_RowEdge, mesure_point.get_ColumnEdge,                 //更新表格
                    mesure_point.get_Amplitude, mesure_point.get_Distance, listView);
            }
        }

        private void ROIWeight_trackBar_ValueChanged(object sender, EventArgs e)                        //ROIWeight數字與拉條連動
        {
            this.ROIWeight.Value = this.ROIWeight_trackBar.Value;                                       //以下同MaxEage裡的連動
            if (drawlinetoRectangle2.get_rectangle_ROI != null)
            {
                HOperatorSet.DispObj(Measure_Image, this.measure_window.HalconWindow);

                drawlinetoRectangle2.get_rectangle_Length2 = this.ROIWeight_trackBar.Value;             //將ROIWeight丟給畫線的函式

                mesure_point.dowork(drawlinetoRectangle2, this.measure_window.HalconWindow,
                    (int)this.sigma.Value, (int)this.MaxEdge.Value, Measure_Image);

                drawlinetoRectangle2.drawROI(this.measure_window.HalconWindow);

                setlist.set_list(mesure_point.get_RowEdge, mesure_point.get_ColumnEdge,                 //更新表格
                    mesure_point.get_Amplitude, mesure_point.get_Distance, listView);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //---------------------------Measure 視窗 輸出資料 -------------------------------------
        public HTuple get_rectangle_Row { get { return drawlinetoRectangle2.get_rectangle_Row; } }
        public HTuple get_rectangle_Column { get { return drawlinetoRectangle2.get_rectangle_Column; } }
        public HTuple get_rectangle_Phi { get { return drawlinetoRectangle2.get_rectangle_Phi; } }
        public HTuple get_rectangle_Length1 { get { return drawlinetoRectangle2.get_rectangle_Length1; } }
        public HTuple get_rectangle_Length2 { get { return drawlinetoRectangle2.get_rectangle_Length2; } }
        public HTuple get_rectangle_MaxEge_Measure { get { return (HTuple)this.MaxEdge.Value; } }
        public HTuple get_rectangle_Sigma_Measure { get { return (HTuple)this.sigma.Value; } }
        public HTuple get_line_Row1 { get { return drawlinetoRectangle2.get_line_Row1; } }
        public HTuple get_line_Column1 { get { return drawlinetoRectangle2.get_line_Column1; } }
        public HTuple get_line_Row2 { get { return drawlinetoRectangle2.get_line_Row2; } }
        public HTuple get_line_Column2 { get { return drawlinetoRectangle2.get_line_Column2; } }
        public HObject get_rectangle_ROI { get { return drawlinetoRectangle2.get_rectangle_ROI; } }
        public HObject get_line_ROI { get { return drawlinetoRectangle2.get_line_ROI; } }
        public HObject get_cross { get { return mesure_point.get_Cross; } }

        private void Measure_Activated(object sender, EventArgs e)
        {
            //---------------------------表格參數預載-------------------------------------------
            this.MaxEdge.Value = 40;
            this.sigma.Value = 1;
            this.ROIWeight.Value = 30;
            this.MaxEage_trackBar.Value = 40;
            this.Sigma_trackBar.Value = 1;
            this.ROIWeight_trackBar.Value = 30;
            drawlinetoRectangle2.get_rectangle_Length2 = this.ROIWeight_trackBar.Value;                 //先行設定ROIWeight給畫線的函式
            //--------------------------表格參數預載----------------------------------------------

            this.listView.BeginUpdate();                                                                //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            listView.View = View.Details;
            listView.Columns.Add("編號");
            listView.Columns.Add("行");
            listView.Columns.Add("列");
            listView.Columns.Add("振幅");
            listView.Columns.Add("距離");

            this.listView.EndUpdate();                                                                  //结束数据处理，UI界面一次性绘制。  


            if (Measure_Image != null)                                                                  //如果有圖片則載入圖片至halcon視窗裡
            {
                measure_window.Focus();
                HOperatorSet.GetImageSize(Measure_Image, out W, out H);
                HOperatorSet.SetSystem("width", W);
                HOperatorSet.SetSystem("height", H);
                HOperatorSet.SetPart(this.measure_window.HalconWindow, 0, 0, H - 1, W - 1);
                HOperatorSet.DispObj(Measure_Image, measure_window.HalconWindow);
            }
            listView.Items.Clear();

        }

        private void Measure_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        //---------------------------Measure 視窗 輸入資料 -------------------------------------
        public HObject MeasureImage { set { Measure_Image = value; } }

    }
}