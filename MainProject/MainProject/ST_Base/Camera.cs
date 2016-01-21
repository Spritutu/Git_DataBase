using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.Windows.Forms;
using ST_Base;

namespace MainProject
{
    public class Camera
    {
        public HTuple hv_AcqHandle = null;
        public HTuple hv_exposure = null;
        public HTuple exposure { set { hv_exposure = value; } get { return hv_exposure; } }
        public HTuple hv_ImageWidth = null;
        public HTuple hv_ImageHeight = null;
        public HTuple hv_Width = null;
        public HTuple hv_Height = null;
        public HObject IMG = null;
        public bool open = false;


        public void Open()
        {
            if (open == false)
            {
                HOperatorSet.OpenFramegrabber("uEye", 1, 1, 0, 0, 0, 0, "default", -1, "default",
                        -1, "default", "default", "default", -1, -1, out hv_AcqHandle);
            }
            open = true;
        }

        public void captrue(out HObject ho_Image_capture)
        {
            if (open == true)
            {
                HOperatorSet.GrabImageAsync(out ho_Image_capture, hv_AcqHandle, -1);//影像擷取序列打開.
            }

            else
            {
                MessageBox.Show("相機沒打開");
                ho_Image_capture = null;
            }
        }

        public  void setexposure()
        {
            HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "exposure", hv_exposure);//曝光時間設定
        }

        public void Close()
        {   if (open == true)
            {
                HOperatorSet.CloseFramegrabber(hv_AcqHandle);
            }
            open = false; 
        }
    }
}
