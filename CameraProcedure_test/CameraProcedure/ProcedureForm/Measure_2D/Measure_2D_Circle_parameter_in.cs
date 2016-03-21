using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;
namespace CameraProcedure
{
    public class Measure_2D_Circle_parameter_in
    {
        public HTuple Length1;
        public HTuple Length2;
        public HTuple Sigma;
        public HTuple Threshold;
        public RegionBase region_circle = new RegionBase();
        public List<Object_Table> O_T = new List<Object_Table>();
    }
}
