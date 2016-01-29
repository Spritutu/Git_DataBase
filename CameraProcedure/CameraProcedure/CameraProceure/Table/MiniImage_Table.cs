using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HalconDotNet; 

namespace CameraProcedure
{
    public class MiniImage_Table
    {
        public Bitmap Bitmap { get; set; }

        public void Object2minipicture(HObject obj)
        {
            HObject obj_temp;
            HOperatorSet.ZoomImageSize(obj, out obj_temp, 100, 100, "constant");
            Bitmap = HObject_Bitmap.HObject2Bitmap(obj_temp);
        }
    }
}
