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
    public struct ImageFromCamreaParameter
    {
        //---------------- Local iconic variables --------------------------
        public  HObject ho_Image;//影像串流儲存位置
        public  HObject ho_Image_capture;//影像串流儲存位置
        //----------------------相機及影像參數--------------------------------
        public  HTuple hv_RevInfo , hv_RevInfoValues , hv_exposure;
        public  HTuple hv_BoardInfo  , hv_BoardInfoValues  ;
        public  HTuple hv_AcqHandle  , hv_CameraInfo  , hv_SensorType  ;
        public  HTuple hv_ImageWidth  , hv_ImageHeight  ;
        public  HTuple hv_HalconError  ;
        public  HTuple hv_LowErrorFlag  ;
        public  HTuple hv_GeneralInfo  ;
        public  HTuple hv_GeneralInfoValues  ;
        public  HTuple hv_CamTypeInfo  ;
        public  HTuple hv_CamTypeValues  , hv_PortInfo  , hv_PortInfoValues  ;
        public  HTuple hv_DefaultInfo  , hv_DefaultInfoValues  ;
        public  HTuple hv_ParameterInfo  , hv_ParameterInfoValues  ;
        public  HTuple hv_ColorspaceInfo  , hv_ColorspaceValues  ;
        public  HTuple hv_BitsPerChannelInfo  , hv_BitsPerChannelValues  ;
        public  HTuple hv_DeviceInfo  , hv_DeviceValues  , hv_TriggerInfo  ;
        public  HTuple hv_TriggerValues  , hv_FieldInfo  , hv_FieldValues  ;
        public  HTuple hv_WindowHandle ;
        public  HTuple hv_i , hv_ParameterValue ;
        public  HTuple hv_j ;
    }


    public partial class ImageFromCamera : Form
    {
        ImageFromCamreaParameter IFCP = new ImageFromCamreaParameter();
        bool alreadyopen = false;

        private ImageBase dst_Image = new ImageBase();
        public HObject dstImage { get { return dst_Image.GetImage; } }

        public bool setornot = false;
        bool ifopenformornot = false;
        

        public ImageFromCamera()
        {
            InitializeComponent();
        }

        private void ImageFromCamera_Activated(object sender, EventArgs e)
        { //判斷是否已經開啟視窗
            if (ifopenformornot == false)
            {
                Camera_startgabber();
                if (dst_Image.GetImage != null)
                {
                    toolWindow.WindowImage.SetImage = dst_Image.GetImage;
                    toolWindow.showImage();
                }
                ifopenformornot = true;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            setornot = true;
            ifopenformornot = false;
            dst_Image.SetImage = toolWindow.WindowImage.GetImage;
            HOperatorSet.CloseFramegrabber(IFCP.hv_AcqHandle);
            Hide();
        }

        private void CaptrueImageBotton_Click(object sender, EventArgs e)
        {
            HOperatorSet.GrabImageAsync(out IFCP.ho_Image_capture, IFCP.hv_AcqHandle, -1);//影像擷取序列打開
            this.Exposure_trackBar.Value = 36;
            toolWindow.WindowImage.SetImage = IFCP.ho_Image_capture;
            toolWindow.showImage();
        }

        private void Exposure_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Exposure.Value = (int)this.Exposure_trackBar.Value;
            IFCP.hv_exposure = (int)this.Exposure_trackBar.Value;
            HOperatorSet.SetFramegrabberParam(IFCP.hv_AcqHandle, "exposure", IFCP.hv_exposure);//曝光時間設定
        }

        private void Exposure_ValueChanged(object sender, EventArgs e)
        {
            this.Exposure_trackBar.Value = (int)this.Exposure.Value;
        }

        public void run()
        {
            if (ifopenformornot == false)
            {
                Camera_startgabber();
                ifopenformornot = true;
            }
            this.Exposure_trackBar.Value = 35;
            HOperatorSet.GrabImageAsync(out IFCP.ho_Image_capture, IFCP.hv_AcqHandle, -1);//影像擷取序列打開
            dst_Image.SetImage = IFCP.ho_Image_capture;
            HOperatorSet.WriteImage(dst_Image.GetImage, "bmp", 0, "D:/Git_DataBase/CameraProcedure_test/CameraProcedure/test.bmp");
        }

        public void Camera_startgabber()
        {
            if (alreadyopen == false)
            {
                HOperatorSet.GenEmptyObj(out IFCP.ho_Image);//清空ho_Image記憶體
                HOperatorSet.InfoFramegrabber("uEye", "revision", out IFCP.hv_RevInfo, out IFCP.hv_RevInfoValues);//相機revision(修正)參數
                HOperatorSet.InfoFramegrabber("uEye", "info_boards", out IFCP.hv_BoardInfo, out IFCP.hv_BoardInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "revision", out IFCP.hv_RevInfo, out IFCP.hv_RevInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "general", out IFCP.hv_GeneralInfo, out IFCP.hv_GeneralInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "info_boards", out IFCP.hv_BoardInfo, out IFCP.hv_BoardInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "camera_types", out IFCP.hv_CamTypeInfo, out IFCP.hv_CamTypeValues);
                HOperatorSet.InfoFramegrabber("uEye", "ports", out IFCP.hv_PortInfo, out IFCP.hv_PortInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "defaults", out IFCP.hv_DefaultInfo, out IFCP.hv_DefaultInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "parameters", out IFCP.hv_ParameterInfo, out IFCP.hv_ParameterInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "color_space", out IFCP.hv_ColorspaceInfo, out IFCP.hv_ColorspaceValues);
                HOperatorSet.InfoFramegrabber("uEye", "bits_per_channel", out IFCP.hv_BitsPerChannelInfo,
                out IFCP.hv_BitsPerChannelValues);
                HOperatorSet.InfoFramegrabber("uEye", "device", out IFCP.hv_DeviceInfo, out IFCP.hv_DeviceValues);
                HOperatorSet.InfoFramegrabber("uEye", "external_trigger", out IFCP.hv_TriggerInfo,
                out IFCP.hv_TriggerValues);
                HOperatorSet.InfoFramegrabber("uEye", "field", out IFCP.hv_FieldInfo, out IFCP.hv_FieldValues);
                //open first uEye camera:
                HOperatorSet.OpenFramegrabber("uEye", 1, 1, 0, 0, 0, 0, "default", -1, "default",
                    -1, "default", "default", "default", -1, -1, out IFCP.hv_AcqHandle);
                HOperatorSet.GetFramegrabberParam(IFCP.hv_AcqHandle, "camera_info", out IFCP.hv_CameraInfo);
                HOperatorSet.GetFramegrabberParam(IFCP.hv_AcqHandle, "sensor_type", out IFCP.hv_SensorType);
                HOperatorSet.GetFramegrabberParam(IFCP.hv_AcqHandle, "image_width", out IFCP.hv_ImageWidth);
                HOperatorSet.GetFramegrabberParam(IFCP.hv_AcqHandle, "image_height", out IFCP.hv_ImageHeight);
                //HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "exposure", out hv_ImageHeight);
                HOperatorSet.SetSystem("width", IFCP.hv_ImageWidth);
                HOperatorSet.SetSystem("height", IFCP.hv_ImageHeight);

                //----------------------重新排序所有的參數 依照名稱----------------------------
                HOperatorSet.InfoFramegrabber("uEye", "parameters", out IFCP.hv_ParameterInfo, out IFCP.hv_ParameterInfoValues);
                HOperatorSet.TupleSort(IFCP.hv_ParameterInfoValues, out IFCP.hv_ParameterInfoValues);
                alreadyopen = true;
            }
        }

        private void ImageFromCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            ifopenformornot = false;
            alreadyopen = false;
            Hide();
        }
    }
}
