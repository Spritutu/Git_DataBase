using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;

namespace CameraProcedure
{
    public class SelectPointNName
    {
        private PointBase point;
        public PointBase Point { get { return point; } set { point = value; } }
        private string pointName;
        public string PointName { get { return pointName; } set { pointName = value; } }
    }
}
