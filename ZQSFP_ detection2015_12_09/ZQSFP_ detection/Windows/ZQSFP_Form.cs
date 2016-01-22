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

namespace ZQSFP_detection
{
    public partial class ZQSFP_Form : Form
    {
        public static HObject Mainpicture;                                                  //主頁面的圖檔儲存位置 
        public static HObject Temp;
        ImageBase Mainpicture_Base = new ImageBase();
        ImageBase Temp_Base = new ImageBase();
        int num = 0;

        DrawRectangle2 drawRectangle = new DrawRectangle2();                                //繪製一個ROI區域
        MatchModel matching = new MatchModel();                                             //匹配選取的物件
        findobjectNmesure FindobjectNmesure = new findobjectNmesure();                      //已經有了參數之後直接載入圖片進來做匹配
        Measure measureWindow = new Measure();                                              //測量視窗(有問題 等等回來處理)
        LoadImage loadImage = new LoadImage();                                              //載入圖片頁面資訊
        EnhanceImageWindow enhanceimagewindow = new EnhanceImageWindow();


        public ZQSFP_Form()                                                                 //初始化halcon視窗大小(2448X2048)
        {
            InitializeComponent();
            HOperatorSet.SetSystem("width", 2448);
            HOperatorSet.SetSystem("height", 2048);
            creatmodel.Enabled = false;
            measure.Enabled = false;
            starwork.Enabled = false;
            measure_2D.Enabled = false;
            EnhanceImage.Enabled = false;

        }

        private void Load_Image_Click(object sender, EventArgs e)                           //載入圖片按鈕
        {
            loadImage.ShowDialog();                                                         //開啟頁面
            HTuple H, W;                                                                    //影像長寬變數
            if (Mainpicture != null)
            {
                HOperatorSet.GetImageSize(Mainpicture, out W, out H);                       //得到影像大小
                HOperatorSet.SetSystem("width", W);                                         //設定halcon視窗大小(2448X2048)
                HOperatorSet.SetSystem("height", H);                                        //設定halcon視窗大小(2448X2048)
                HOperatorSet.SetPart(this.MainWindow.HalconWindow, 0, 0, H - 1, W - 1);     //
                HOperatorSet.DispObj(Mainpicture, this.MainWindow.HalconWindow);            //顯示主頁圖片(攝影機或讀取圖片)
                MainWindow.ImagePart = new System.Drawing.Rectangle(0, 0, W, H);

                Mainpicture_Base.SetImage = Mainpicture.Clone();


            }
            creatmodel.Enabled = true;
            measure.Enabled = true;
            starwork.Enabled = true;
            measure_2D.Enabled = true;
            EnhanceImage.Enabled = true;

            if (measureWindow.get_line_ROI != null)
                measureWindow.get_line_ROI.Dispose();
            if (drawRectangle.get_ROI != null)
                drawRectangle.get_ROI.Dispose();
            

        }

        private void ZQSFP_Form_FormClosing(object sender, FormClosingEventArgs e)          //關掉視窗時要顯示的對話框
        {

            DialogResult dr = MessageBox.Show("確定要關閉程式嗎?",
            "Closing event!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;//取消離開  
            else
            {
                e.Cancel = false;
                measureWindow.Close();
                loadImage.Close();
            }
        }

        private void creatmodel_Click(object sender, EventArgs e)                           //畫出ROI區域選出元件
        {
            MessageBox.Show("請畫出元件位置");
            this.MainWindow.Focus();                                                        //將焦點放到視窗
            HTuple H, W;
            
            if (Mainpicture != null)
            {
                HOperatorSet.GetImageSize(Mainpicture, out W, out H);                       //得到影像大小
                HOperatorSet.SetSystem("width", W);                                         //設定halcon視窗大小(2448X2048)
                HOperatorSet.SetSystem("height", H);                                        //設定halcon視窗大小(2448X2048)
                HOperatorSet.DispObj(Mainpicture, this.MainWindow.HalconWindow);            //顯示主頁圖片(攝影機或讀取圖片)
                HOperatorSet.SetColor(this.MainWindow.HalconWindow, "yellow");
                HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                drawRectangle.draw(this.MainWindow.HalconWindow);                           //畫出元件位置並且輸出建立參數 

                HOperatorSet.SetColor(this.MainWindow.HalconWindow, "red");
                HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                HOperatorSet.SetLineWidth(this.MainWindow.HalconWindow, 2);
                drawRectangle.Show(this.MainWindow.HalconWindow);                               //顯示出所畫的ROI範圍

                if (drawRectangle.get_ROI != null)
                {
                    HOperatorSet.SetColor(this.MainWindow.HalconWindow, "red");
                    HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                    HOperatorSet.SetLineWidth(this.MainWindow.HalconWindow, 2);
                    matching.match(drawRectangle.get_ROI, Mainpicture,1);                             //匹配所選取的元件
                    matching.Show(this.MainWindow.HalconWindow);                                    //顯是匹配的結果
                }
                else
                    MessageBox.Show("還沒有選定您的物件喔");
                if (measureWindow.get_line_ROI != null)
                {
                    HOperatorSet.SetColor(this.MainWindow.HalconWindow, "blue");
                    HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                    HOperatorSet.SetLineWidth(this.MainWindow.HalconWindow, 2);
                    HOperatorSet.DispObj(measureWindow.get_line_ROI, this.MainWindow.HalconWindow);
                }
                else
                    MessageBox.Show("你還沒有畫任何測量線!!");
            }
            else
                MessageBox.Show("沒有讀取到圖片喔");

            
        }

        private void measure_Click(object sender, EventArgs e)
        {
            
            if (Mainpicture != null)
            {
                measureWindow.MeasureImage = Mainpicture.Clone();
                measureWindow.ShowDialog();                                                 //顯示測量視窗

                if (Mainpicture != null)
                {

                    if (drawRectangle.get_ROI != null)
                    {

                        HOperatorSet.SetColor(this.MainWindow.HalconWindow, "red");
                        HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                        HOperatorSet.SetLineWidth(this.MainWindow.HalconWindow, 2);
                        drawRectangle.Show(this.MainWindow.HalconWindow);                               //顯示出所畫的ROI範圍

                        HOperatorSet.SetColor(this.MainWindow.HalconWindow, "red");
                        HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                        HOperatorSet.SetLineWidth(this.MainWindow.HalconWindow, 2);
                        matching.Show(this.MainWindow.HalconWindow);                                    //顯是匹配的結果
                    }
                    else
                        MessageBox.Show("還沒有選定您的物件喔!");
                    if (measureWindow.get_line_ROI != null)
                    {
                        HOperatorSet.SetColor(this.MainWindow.HalconWindow, "blue");
                        HOperatorSet.SetDraw(this.MainWindow.HalconWindow, "margin");
                        HOperatorSet.SetLineWidth(this.MainWindow.HalconWindow, 2);
                        HOperatorSet.DispObj(measureWindow.get_line_ROI, this.MainWindow.HalconWindow);
                        HOperatorSet.DispObj(measureWindow.get_cross, this.MainWindow.HalconWindow);
                    }
                    else
                        MessageBox.Show("你還沒有畫任何測量線!!");
                }
                else
                    MessageBox.Show("沒有讀取到圖片喔");
            }
        }

        private void starwork_Click(object sender, EventArgs e)
        {
            
            if (num < 4) {
                FindobjectNmesure.RunHalcon(this.MainWindow.HalconWindow, matching, measureWindow, drawRectangle, num,1);
                num++;
            }
            
        }

        private void measure_2D_Click(object sender, EventArgs e)
        {

            if (Mainpicture != null)
            {
                HDevelopExport1 HD = new HDevelopExport1(Mainpicture.Clone());
                
            }
            else
                MessageBox.Show("沒有讀取到圖片喔");
        }

        private void EnhanceImage_Click(object sender, EventArgs e)
        {
            if (Mainpicture != null)
            {
                enhanceimagewindow.SRC = Mainpicture;
                enhanceimagewindow.ShowDialog();
                Temp_Base.SetImage = Temp;
                Temp_Base.ShowImage_autosize(this.SecondWindow.HalconWindow);
            }

        }

        private void Regiongrowing_Click(object sender, EventArgs e)
        {

            if (Mainpicture != null)
            {
                HDevelopExport2 HD = new HDevelopExport2();

            }
            else
                MessageBox.Show("沒有讀取到圖片喔");

        }

        private void MainWindow_HMouseMove(object sender, HMouseEventArgs e)
        {
            PointBase mousePosition = new PointBase();
            mousePosition.col = (int)e.X;
            mousePosition.row = (int)e.Y;
            MouseX.Text = mousePosition.col.ToString();
            MouseY.Text = mousePosition.row.ToString();
            pixel.Text = Mainpicture_Base.PiexlGrayval(mousePosition).ToString();
        }
    }
}
