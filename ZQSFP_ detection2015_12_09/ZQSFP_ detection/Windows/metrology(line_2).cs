//
//  File generated by HDevelop for HALCON/DOTNET (C#) Version 12.0
//

using HalconDotNet;

public partial class HDevelopExport1
{
#if !(NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
  public HDevelopExport1(HObject ho_Image)
  {
    // Default settings used in HDevelop 
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
    if (HalconAPI.isWindows)
      HOperatorSet.SetSystem("use_window_thread","true");
    action(ho_Image);
  }
#endif

#if !NO_EXPORT_MAIN
  // Main procedure 
  private void action(HObject ho_Image)
  {
    // Local iconic variables 

    HObject ho_MeasureConts, ho_Cross;
    HObject ho_Point1, ho_Point2, ho_Point3, ho_Point4, ho_RegionLines1;
    HObject ho_RegionLines2;
        HTuple hv_Button = null;

    // Local control variables 

        HTuple hv_WindowHandle = null, hv_Width = null;
    HTuple hv_Height = null, hv_MetrologyHandle = null, hv_L_Row1 = null;
    HTuple hv_L_Column1 = null, hv_L_Row2 = null, hv_L_Column2 = null;
    HTuple hv_R_Row1 = null, hv_R_Column1 = null, hv_R_Row2 = null;
    HTuple hv_R_Column2 = null, hv_Index1 = null, hv_Index2 = null;
    HTuple hv_Par = null, hv_Rtmp = null, hv_Ctmp = null, hv_Row = null;
    HTuple hv_Column = null, hv_IsOverlapping = null, hv_Angle = null;
    HTuple hv_Angle1 = null;
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_MeasureConts);
    HOperatorSet.GenEmptyObj(out ho_Cross);
    HOperatorSet.GenEmptyObj(out ho_Point1);
    HOperatorSet.GenEmptyObj(out ho_Point2);
    HOperatorSet.GenEmptyObj(out ho_Point3);
    HOperatorSet.GenEmptyObj(out ho_Point4);
    HOperatorSet.GenEmptyObj(out ho_RegionLines1);
    HOperatorSet.GenEmptyObj(out ho_RegionLines2);

        //ho_Image.Dispose();
        //HOperatorSet.ReadImage(out ho_Image, "C:/Users/User/Desktop/parallel_15_b_30.png");
        if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.CloseWindow(HDevWindowStack.Pop());
    }
    HOperatorSet.SetWindowAttr("background_color","black");
    HOperatorSet.OpenWindow(0,0,1024,1024,0,"","",out hv_WindowHandle);
    HDevWindowStack.Push(hv_WindowHandle);

        HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
        HOperatorSet.CreateMetrologyModel(out hv_MetrologyHandle);
        HOperatorSet.SetMetrologyModelImageSize(hv_MetrologyHandle, hv_Width, hv_Height);
        if (HDevWindowStack.IsOpen())
    {

            HOperatorSet.SetSystem("width", hv_Width);                                                  //�]�whalcon�����j�p(2448X2048)
            HOperatorSet.SetSystem("height", hv_Height);                                                //�]�whalcon�����j�p(2448X2048)
            HOperatorSet.SetPart(HDevWindowStack.GetActive(), 0, 0, hv_Height - 1, hv_Width - 1);       //
            HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
    }

    HOperatorSet.DrawPoint(hv_WindowHandle, out hv_L_Row1, out hv_L_Column1);
    HOperatorSet.DrawPoint(hv_WindowHandle, out hv_L_Row2, out hv_L_Column2);
    HOperatorSet.DrawPoint(hv_WindowHandle, out hv_R_Row1, out hv_R_Column1);
    HOperatorSet.DrawPoint(hv_WindowHandle, out hv_R_Row2, out hv_R_Column2);
    HOperatorSet.AddMetrologyObjectLineMeasure(hv_MetrologyHandle, hv_L_Row1, hv_L_Column1, 
        hv_L_Row2, hv_L_Column2, 20, 5, 1, 10, "measure_transition", "all", out hv_Index1);
    HOperatorSet.AddMetrologyObjectLineMeasure(hv_MetrologyHandle, hv_R_Row1, hv_R_Column1, 
        hv_R_Row2, hv_R_Column2, 20, 5, 1, 10, "measure_transition", "all", out hv_Index2);
    HOperatorSet.ApplyMetrologyModel(ho_Image, hv_MetrologyHandle);
    HOperatorSet.GetMetrologyObjectResult(hv_MetrologyHandle, "all", "all", "result_type", 
        "all_param", out hv_Par);
    ho_MeasureConts.Dispose();
    HOperatorSet.GetMetrologyObjectMeasures(out ho_MeasureConts, hv_MetrologyHandle, 
        "all", "all", out hv_Rtmp, out hv_Ctmp);
    ho_Cross.Dispose();
    HOperatorSet.GenCrossContourXld(out ho_Cross, hv_Rtmp, hv_Ctmp, 6, (new HTuple(45)).TupleRad()
        );


    HOperatorSet.IntersectionLines(hv_Par.TupleSelect(0), hv_Par.TupleSelect(1), 
        hv_Par.TupleSelect(2), hv_Par.TupleSelect(3), hv_Par.TupleSelect(4), hv_Par.TupleSelect(
        5), hv_Par.TupleSelect(6), hv_Par.TupleSelect(7), out hv_Row, out hv_Column, 
        out hv_IsOverlapping);
    ho_Point1.Dispose();
    HOperatorSet.GenCrossContourXld(out ho_Point1, hv_Par.TupleSelect(0), hv_Par.TupleSelect(
        1), 35, 0);
    ho_Point2.Dispose();
    HOperatorSet.GenCrossContourXld(out ho_Point2, hv_Par.TupleSelect(2), hv_Par.TupleSelect(
        3), 35, 0);
    ho_Point3.Dispose();
    HOperatorSet.GenCrossContourXld(out ho_Point3, hv_Par.TupleSelect(4), hv_Par.TupleSelect(
        5), 35, 0);
    ho_Point4.Dispose();
    HOperatorSet.GenCrossContourXld(out ho_Point4, hv_Par.TupleSelect(6), hv_Par.TupleSelect(
        7), 35, 0);


    ho_RegionLines1.Dispose();
    HOperatorSet.GenRegionLine(out ho_RegionLines1, hv_Par.TupleSelect(0), hv_Par.TupleSelect(
        1), hv_Par.TupleSelect(2), hv_Par.TupleSelect(3));
    ho_RegionLines2.Dispose();
    HOperatorSet.GenRegionLine(out ho_RegionLines2, hv_Par.TupleSelect(4), hv_Par.TupleSelect(
        5), hv_Par.TupleSelect(6), hv_Par.TupleSelect(7));

    HOperatorSet.AngleLl(hv_Par.TupleSelect(0), hv_Par.TupleSelect(1), hv_Par.TupleSelect(
        2), hv_Par.TupleSelect(3), hv_Par.TupleSelect(4), hv_Par.TupleSelect(5), 
        hv_Par.TupleSelect(6), hv_Par.TupleSelect(7), out hv_Angle);
    HOperatorSet.AngleLx(hv_Par.TupleSelect(0), hv_Par.TupleSelect(1), hv_Par.TupleSelect(
        2), hv_Par.TupleSelect(3), out hv_Angle1);

    //gen_cross_contour_xld (Point5, Row, Column, 35, 0)

    ho_RegionLines2.Dispose();
    HOperatorSet.GenRegionLine(out ho_RegionLines2, hv_Par.TupleSelect(0), hv_Par.TupleSelect(
        1), hv_Par.TupleSelect(2), hv_Par.TupleSelect(3));
    ho_RegionLines1.Dispose();
    HOperatorSet.GenRegionLine(out ho_RegionLines1, hv_Par.TupleSelect(4), hv_Par.TupleSelect(
        5), hv_Par.TupleSelect(6), hv_Par.TupleSelect(7));

    //gen_cross_contour_xld (Point, Row, Column, 35, 0)
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Cross, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.SetColor(HDevWindowStack.GetActive(), "blue");
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_RegionLines2, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_RegionLines1, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.SetColor(HDevWindowStack.GetActive(), "red");
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Point1, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Point2, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Point3, HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Point4, HDevWindowStack.GetActive());
    }
    
        

        while (true)
        {
            //Select region with the mouse
            //Use right mouse button to quit the loop
            HOperatorSet.GetMbutton(hv_WindowHandle, out hv_Row, out hv_Column, out hv_Button);
            if (hv_Button == 4)
            {
                HOperatorSet.CloseWindow(HDevWindowStack.Pop());
                break;
            }
        }
        ho_Image.Dispose();
        ho_MeasureConts.Dispose();
        ho_Cross.Dispose();
        ho_Point1.Dispose();
        ho_Point2.Dispose();
        ho_Point3.Dispose();
        ho_Point4.Dispose();
        ho_RegionLines1.Dispose();
        ho_RegionLines2.Dispose();

    }

#endif


}

