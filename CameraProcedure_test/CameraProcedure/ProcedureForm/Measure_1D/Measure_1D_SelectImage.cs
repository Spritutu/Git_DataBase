using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace CameraProcedure
{
    public class Measure_1D_SelectImage
    {
        private HObject image;
        public HObject Image { get { return image; } set { image = value; } }
        private string imageName;
        public string ImageName { get { return imageName; } set { imageName = value; } }
    }
}
