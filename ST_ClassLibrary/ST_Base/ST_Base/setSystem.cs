using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    public static class setSystem
    {
        public static void SetPen(HTuple hwindows, HTuple color, HTuple Draw, HTuple LineWidth)//線條參數
        {
            HOperatorSet.SetColor(hwindows, color);
            HOperatorSet.SetDraw(hwindows, Draw);
            HOperatorSet.SetLineWidth(hwindows, LineWidth);
            
        }
    }
}
