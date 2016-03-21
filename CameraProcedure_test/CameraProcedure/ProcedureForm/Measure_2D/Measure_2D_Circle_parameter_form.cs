using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;
namespace CameraProcedure
{ 
    public class Measure_2D_Circle_parameter_form
    {
        public HObject ho_Image, ho_Circle, ho_Contours, ho_Contour;
        public HObject ho_Cross;
        public HTuple hv_Width, hv_Height, hv_Row;
        public HTuple hv_Column, hv_Radius, hv_MetrologyHandle;
        public HTuple hv_MetrologyCircleIndices, hv_Row1;
        public HTuple hv_Column1;
        public HTuple hv_Parameter;
        
        public bool ifopenformornot = false;

        public List<SelectImageNName> SelectImage = new List<SelectImageNName>();

        public ImageBase src_Image = new ImageBase();

        public bool loadfinish = false;

        public List<index_ij> index = new List<index_ij>();
    }
}
