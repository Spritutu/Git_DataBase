using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;

namespace CameraProcedure
{
    public class TheVerticalLineParameter_form
    {
        public HTuple hv_Center_row, hv_Center_col, hv_first_row, hv_Second_row, hv_first_col, hv_Second_col;
        public HTuple hv_m, hv_row1, hv_col1, hv_row2, hv_col2;
        public HObject ho_Cross_center, ho_Cross_firstpoint, ho_Cross_secondpoint, ho_RegionLines;
        public bool ifopenformornot = false;
        public bool loadfinish = false;
        public List<index_ij> index_img = new List<index_ij>();
        public List<index_ij> index_P1 = new List<index_ij>();
        public List<index_ij> index_C1 = new List<index_ij>();
        public List<index_ij> index_P2 = new List<index_ij>();
        public List<index_ij> index_C2 = new List<index_ij>();
        public List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        public List<SelectPointNName> SelectPoint1 = new List<SelectPointNName>();
        public List<SelectPointNName> SelectPoint2 = new List<SelectPointNName>();
        public ImageBase src_Image = new ImageBase();
        public PointBase src_Point1 = new PointBase();
        public PointBase src_Point2 = new PointBase();
    }
}
