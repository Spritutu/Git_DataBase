using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ST_Base;
using HalconDotNet;
namespace CameraProcedure
{
    public class Measure2DlineParameter_in
    {
        public HTuple Length1;
        public HTuple Length2;
        public HTuple Sigma;
        public HTuple Threshold;
        public List<Object_Table> O_T = new List<Object_Table>();
        public RegionBase region_line = new RegionBase();
    }
}