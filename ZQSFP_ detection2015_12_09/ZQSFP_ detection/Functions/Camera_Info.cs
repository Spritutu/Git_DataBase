using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
namespace ZQSFP_detection
{
    partial class Camera
    {
        //---------------- Local iconic variables --------------------------
        HSystem sys = new HSystem();

        public static HObject ho_Image;//影像串流儲存位置
        public static HObject ho_Image_capture;//影像串流儲存位置
        //----------------------相機及影像參數--------------------------------
        public static HTuple hv_RevInfo = null, hv_RevInfoValues = null;
        public static HTuple hv_BoardInfo = null, hv_BoardInfoValues = null;
        public static HTuple hv_AcqHandle = null, hv_CameraInfo = null, hv_SensorType = null;
        public static HTuple hv_ImageWidth = null, hv_ImageHeight = null;
        public static HTuple hv_HalconError = null;
        public static HTuple hv_LowErrorFlag = null;
        public static HTuple hv_GeneralInfo = null;
        public static HTuple hv_GeneralInfoValues = null;
        public static HTuple hv_CamTypeInfo = null;
        public static HTuple hv_CamTypeValues = null, hv_PortInfo = null, hv_PortInfoValues = null;
        public static HTuple hv_DefaultInfo = null, hv_DefaultInfoValues = null;
        public static HTuple hv_ParameterInfo = null, hv_ParameterInfoValues = null;
        public static HTuple hv_ColorspaceInfo = null, hv_ColorspaceValues = null;
        public static HTuple hv_BitsPerChannelInfo = null, hv_BitsPerChannelValues = null;
        public static HTuple hv_DeviceInfo = null, hv_DeviceValues = null, hv_TriggerInfo = null;
        public static HTuple hv_TriggerValues = null, hv_FieldInfo = null, hv_FieldValues = null;
        public static HTuple hv_WindowHandle = new HTuple();
        public static HTuple hv_i = new HTuple(), hv_ParameterValue = new HTuple();
        public static HTuple hv_j = new HTuple();
        //----------------------相機參數--------------------------------
        public static bool alreadyopen = false;//影像是否已經開始讀取
        public static bool Cancel = false;//項機關閉參數

        static HTuple hv_ExpDefaultWinHandle_vedio;//影像視窗
    }
}
