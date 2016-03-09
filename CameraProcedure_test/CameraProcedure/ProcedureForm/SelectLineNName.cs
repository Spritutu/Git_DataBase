using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;

namespace CameraProcedure
{
    public class SelectLineNName
    {
        private Line line;
        public Line Line { get { return line; } set { line = value; } }
        private string lineName;
        public string LineName { get { return lineName; } set { lineName = value; } }
    }
}
