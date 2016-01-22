using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.Windows.Forms;

namespace ZQSFP_detection
{
    class ImageBase
    {

        //--------------Image物件，讀寫函式------------------------------
        protected HObject Image = null;
        public HObject GetImage { get { return Image; } }
        public HObject SetImage { set { Image = value; } }
        //-------------Image物件長寬，讀取函式---------------------------
        protected HTuple hv_Width = null;
        public HTuple GetWidth { get { return hv_Width; } }
        protected HTuple hv_Height = null;
        public HTuple GetHeight { get { return hv_Height; } }
        //產生選擇檔案視窗-----------------------------------------------
        protected OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public string GetFileName() { return openFileDialog1.FileName; }
        //---------------------------------------------------------------
        public ImageBase()//建構函式
        {
        }

        public void ShowImage_autosize(HTuple Window)//將圖片顯示在指定的halcon視窗上  輸入變數：HTuple Window(視窗)
        {
            if (Image != null)
            {
                HOperatorSet.GetImageSize(Image, out hv_Width, out hv_Height);
                HOperatorSet.SetSystem("width", hv_Width);
                HOperatorSet.SetSystem("height", hv_Height);
                HOperatorSet.SetPart(Window, 0, 0, hv_Height - 1, hv_Width - 1);
                HOperatorSet.ClearWindow(Window);
                HOperatorSet.DispObj(Image, Window);
            }
            else
                MessageBox.Show("Error Image 是空的!");
        }

        public void ShowImage(HTuple Window)//將圖片顯示在指定的halcon視窗上  輸入變數：HTuple Window(視窗)
        {
            if (Image != null)
            {
                HOperatorSet.ClearWindow(Window);
                HOperatorSet.DispObj(Image, Window);
            }
            else
                MessageBox.Show("Error Image 是空的!");

        }

        public void DisposeImage()//釋放Image物件
        {
            Image.Dispose();
        }
        
        public void ImagefromFile()//由自己選擇檔案位置讀取圖片(Image)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Image != null)
                {
                    Image.Dispose();
                }
                HOperatorSet.GenEmptyObj(out Image);
                HOperatorSet.ReadImage(out Image, openFileDialog1.FileName);
                HOperatorSet.GetImageSize(Image, out hv_Width, out hv_Height);

            }
        }


        public HTuple PiexlGrayval(PointBase point)//取得某點的pixel值 直接函式輸出
        {
            HTuple Grayval;
            if (Image != null)
                HOperatorSet.GetGrayval(Image, point.row, point.col, out Grayval);
            else 
                Grayval = "null";

            return Grayval;
        }

        public HTuple PiexlGrayval_Interpolated(PointBase point)//取得某點的pixel值(內插法) 直接函式輸出
        {
            HTuple Grayval_Interpolated;
            HOperatorSet.GetGrayvalInterpolated(Image, point.row, point.col, "bilinear", out Grayval_Interpolated);
            return Grayval_Interpolated;
        }

        
        public void GenImageConst(MaskBase picturesize)//創造一個空白的圖片給Image(預設值為0) 
        {
            HOperatorSet.SetSystem("init_new_image", "true");
            Image.Dispose();
            HOperatorSet.GenImageConst(out Image, "byte", picturesize.W, picturesize.H);
        }

        public void GrayHisto(out HTuple hv_AbsoluteHisto, out HTuple hv_RelativeHisto)//取得圖片的histo (不能選區域  整張圖)
        {
            HOperatorSet.GrayHisto(Image, Image, out hv_AbsoluteHisto, out hv_RelativeHisto);
        }

        public HTuple EstimateNoise(HTuple percent)//取得圖片的noise
        {
            HTuple Sigma;
            HOperatorSet.EstimateNoise(Image, "foerstner", percent, out Sigma);
            return Sigma;
            
        }
        public void Intensity(out HTuple mean, out HTuple deviation)//取得圖片的mean跟deviation
        {
            HOperatorSet.Intensity(Image, Image, out mean, out deviation);
        }
        public HTuple GrayFeatures(string Features )//有很多的參數輸入請參考halcon裡面
        {
            HTuple Value;
            HOperatorSet.GrayFeatures(Image, Image, Features, out Value);
            return Value;
        }
        public void CopyImagetoThis(HObject image) {

            Image = image.Clone();
        }
    }
}
