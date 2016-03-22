using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    public class PointBase
    {
        public HTuple row = null;
        public HTuple col = null;
        public HTuple Button = null;

        public void GetMposition(HTuple Window)
        {
            try
            {
                HOperatorSet.GetMposition(Window, out row, out col, out Button);
            }
            catch (Exception) {

            }

        }
        public void GetMpositionSubPix(HTuple Window)
        {
            try
            {
                HOperatorSet.GetMpositionSubPix(Window, out row, out col, out Button);
            }
            catch (Exception)
            {

            }
        }
    }
}
