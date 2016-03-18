using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;

namespace CameraProcedure
{
    public class CreateMatchingModelParameter_in
    {
        public HTuple Create_NumLevels;
        public HTuple Create_AngleStart;
        public HTuple Create_AngleExtent;
        public HTuple Create_Contrast;
        public HTuple Create_MinContrast;

        public HTuple Find_AngleStart;
        public HTuple Find_AngleExtent;
        public HTuple Find_MinScore;
        public HTuple Find_NumMatch;
        public HTuple Find_MaxOverLap;
        public HTuple Find_NumLevels;
        public HTuple Find_Greediness;

        public ImageBase Template_Image = new ImageBase();
        public RegionBase region_rec = new RegionBase();

        public List<Object_Table> O_T = new List<Object_Table>();
    }
}
