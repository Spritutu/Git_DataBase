using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST_Base;
using HalconDotNet;
namespace CameraProcedure
{
     public class Measure2DlineParameter_form
    {

        public HObject ho_Cross;
        public HObject ho_Contours;
        public HObject ho_MeasureConts;
        public HObject ho_line;
        public HTuple hv_MetrologyHandle;
        public HTuple hv_Index;
        public HTuple hv_Par;
        public HTuple hv_Rtmp;
        public HTuple hv_Ctmp;
        
        public bool ifopenformornot = false;
        public List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        public ImageBase src_Image = new ImageBase();
        public bool loadfinish = false;
        public List<index_ij> index = new List<index_ij>();
        
    }
}
