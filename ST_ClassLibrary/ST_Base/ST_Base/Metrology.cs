using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    public class Metrology
    {
        // Main procedure 
        public void Metrology_line(HTuple Windows,ImageBase IMG)
        {
            // Local iconic variables 

            HObject ho_Image, ho_MeasureConts, ho_Cross;
            HObject ho_line;
            // Local control variables 

            HTuple hv_WindowHandle = new HTuple(), hv_Width = null;
            HTuple hv_Height = null, hv_MetrologyHandle = null, hv_Row1 = null;
            HTuple hv_Column1 = null, hv_Row2 = null, hv_Column2 = null;
            HTuple hv_Index1 = null, hv_Par = null, hv_Rtmp = null;
            HTuple hv_Ctmp = null;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.GenEmptyObj(out ho_MeasureConts);
            HOperatorSet.GenEmptyObj(out ho_Cross);
            HOperatorSet.GenEmptyObj(out ho_line);

            ho_Image.Dispose();
            ho_Image = IMG.GetImage.Clone();
            //dev_close_window(...);
            //dev_open_window(...);
            HOperatorSet.DispObj(ho_Image, Windows);
            HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
            HOperatorSet.CreateMetrologyModel(out hv_MetrologyHandle);
            HOperatorSet.SetMetrologyModelImageSize(hv_MetrologyHandle, hv_Width, hv_Height);
            HOperatorSet.DrawLine(Windows, out hv_Row1, out hv_Column1, out hv_Row2,
                out hv_Column2);
            HOperatorSet.AddMetrologyObjectLineMeasure(hv_MetrologyHandle, hv_Row1, hv_Column1,
                hv_Row2, hv_Column2, 20, 5, 1, 10, "measure_transition", "all", out hv_Index1);
            HOperatorSet.ApplyMetrologyModel(ho_Image, hv_MetrologyHandle);
            HOperatorSet.GetMetrologyObjectResult(hv_MetrologyHandle, "all", "all", "result_type",
                "all_param", out hv_Par);
            ho_MeasureConts.Dispose();
            HOperatorSet.GetMetrologyObjectMeasures(out ho_MeasureConts, hv_MetrologyHandle,
                "all", "all", out hv_Rtmp, out hv_Ctmp);
            ho_Cross.Dispose();
            HOperatorSet.GenCrossContourXld(out ho_Cross, hv_Rtmp, hv_Ctmp, 6, (new HTuple(45)).TupleRad()
                );

            HOperatorSet.DispObj(ho_Image, Windows);

            HOperatorSet.SetColor(Windows, "blue");
            HOperatorSet.DispObj(ho_Cross, Windows);

            HOperatorSet.SetColor(Windows, "red");
            ho_line.Dispose();
            HOperatorSet.GenRegionLine(out ho_line, hv_Par.TupleSelect(0), hv_Par.TupleSelect(
                1), hv_Par.TupleSelect(2), hv_Par.TupleSelect(3));
            HOperatorSet.DispObj(ho_line, Windows);

            ho_Image.Dispose();
            ho_MeasureConts.Dispose();
            ho_Cross.Dispose();
            ho_line.Dispose();
        }
    }
}
