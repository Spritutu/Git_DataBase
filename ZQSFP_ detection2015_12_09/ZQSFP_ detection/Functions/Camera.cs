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
        private static HTuple hv_exposure = null;

        public static void Camera_startgabber() {
            if (alreadyopen == false)
            {
                HOperatorSet.GenEmptyObj(out ho_Image);//清空ho_Image記憶體
                HOperatorSet.InfoFramegrabber("uEye", "revision", out hv_RevInfo, out hv_RevInfoValues);//相機revision(修正)參數
                HOperatorSet.InfoFramegrabber("uEye", "info_boards", out hv_BoardInfo, out hv_BoardInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "revision", out hv_RevInfo, out hv_RevInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "general", out hv_GeneralInfo, out hv_GeneralInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "info_boards", out hv_BoardInfo, out hv_BoardInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "camera_types", out hv_CamTypeInfo, out hv_CamTypeValues);
                HOperatorSet.InfoFramegrabber("uEye", "ports", out hv_PortInfo, out hv_PortInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "defaults", out hv_DefaultInfo, out hv_DefaultInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "parameters", out hv_ParameterInfo, out hv_ParameterInfoValues);
                HOperatorSet.InfoFramegrabber("uEye", "color_space", out hv_ColorspaceInfo, out hv_ColorspaceValues);
                HOperatorSet.InfoFramegrabber("uEye", "bits_per_channel", out hv_BitsPerChannelInfo,
                out hv_BitsPerChannelValues);
                HOperatorSet.InfoFramegrabber("uEye", "device", out hv_DeviceInfo, out hv_DeviceValues);
                HOperatorSet.InfoFramegrabber("uEye", "external_trigger", out hv_TriggerInfo,
                out hv_TriggerValues);
                HOperatorSet.InfoFramegrabber("uEye", "field", out hv_FieldInfo, out hv_FieldValues);
                //open first uEye camera:
                HOperatorSet.OpenFramegrabber("uEye", 1, 1, 0, 0, 0, 0, "default", -1, "default",
                    -1, "default", "default", "default", -1, -1, out hv_AcqHandle);
                HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "camera_info", out hv_CameraInfo);
                HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "sensor_type", out hv_SensorType);
                HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "image_width", out hv_ImageWidth);
                HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "image_height", out hv_ImageHeight);
                //HOperatorSet.GetFramegrabberParam(hv_AcqHandle, "exposure", out hv_ImageHeight);
                HOperatorSet.SetSystem("width", hv_ImageWidth);
                HOperatorSet.SetSystem("height", hv_ImageHeight);

                //----------------------重新排序所有的參數 依照名稱----------------------------
                HOperatorSet.InfoFramegrabber("uEye", "parameters", out hv_ParameterInfo, out hv_ParameterInfoValues);
                HOperatorSet.TupleSort(hv_ParameterInfoValues, out hv_ParameterInfoValues);
                alreadyopen = true;
            }
        }
        
        private static void action()
        {
            while (Camera.Cancel == false)
            {
                HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);//影像擷取序列打開
                HOperatorSet.SetPart(hv_ExpDefaultWinHandle_vedio, 0, 0, hv_ImageHeight - 1, hv_ImageWidth - 1);//設定圖片對應視窗大小
                HOperatorSet.DispObj(ho_Image, hv_ExpDefaultWinHandle_vedio);//顯示
                Camera.ho_Image.Dispose();
            }
            Camera.Cancel = true;
        }
        public static void RunHalcon(HTuple Window)
        {
            hv_ExpDefaultWinHandle_vedio = Window;
            action();
        }

        public static void captrue(out HObject ho_Image_capture)
        {
            HOperatorSet.GrabImageAsync(out ho_Image_capture, hv_AcqHandle, -1);//影像擷取序列打開

        }
        public static void setexposure()
        {

            HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "exposure", hv_exposure);//曝光時間設定

        }

        public static HTuple exposure { set { hv_exposure = value; } get { return hv_exposure; } }


    }
}
