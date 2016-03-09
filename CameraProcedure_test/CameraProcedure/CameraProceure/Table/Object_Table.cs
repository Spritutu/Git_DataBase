using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.Drawing.Imaging;
using System.Drawing;
using ST_Base;

namespace CameraProcedure
{
    /// <summary>
    /// 主視窗的物件中的Object
    /// 目前包括：image
    /// </summary>
    public class Object_Table
    {
        public List<HObject> OImage = new List<HObject>();
        public List<string> OImageName = new List<string>();

        public List<Circle> OCircle = new List<Circle>();
        public List<string> OCircleName = new List<string>();

        public List<PointBase> OPoint = new List<PointBase>();
        public List<string> OPointName = new List<string>();

        public List<Line> OLine = new List<Line>();
        public List<string> OLineName = new List<string>();

    }

}
