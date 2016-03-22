using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST_Base;
using HalconDotNet;

namespace CameraProcedure
{
    public class Measure1DParameter_in
    {
        /// <summary>
        /// line的ROI
        /// </summary>
        public RegionBase region_line = new RegionBase();
        public List<Object_Table> O_T = new List<Object_Table>();
    }
}
