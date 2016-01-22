//
//  File generated by HDevelop for HALCON/DOTNET (C#) Version 12.0
//

using HalconDotNet;

public class HDevelopExport2
{
#if !(NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
  public HDevelopExport2()
  {
    // Default settings used in HDevelop 
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
    if (HalconAPI.isWindows)
      HOperatorSet.SetSystem("use_window_thread","true");
    action();
  }
#endif

#if !NO_EXPORT_MAIN
  // Main procedure 
  private void action()
  {
    // Local iconic variables 

    HObject ho_Image, ho_Regions, ho_DestRegions=null;

    // Local control variables 

    HTuple hv_WindowID = null, hv_Number = null;
    HTuple hv_Button = null, hv_Row = new HTuple(), hv_Column = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_Image);
    HOperatorSet.GenEmptyObj(out ho_Regions);
    HOperatorSet.GenEmptyObj(out ho_DestRegions);
    ho_Image.Dispose();
    HOperatorSet.ReadImage(out ho_Image, "fabrik");
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.CloseWindow(HDevWindowStack.Pop());
    }
    HOperatorSet.SetWindowAttr("background_color","black");
    HOperatorSet.OpenWindow(0,0,512,512,0,"","",out hv_WindowID);
    HDevWindowStack.Push(hv_WindowID);
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.SetColor(HDevWindowStack.GetActive(), "white");
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.SetDraw(HDevWindowStack.GetActive(), "fill");
    }
    ho_Regions.Dispose();
    HOperatorSet.Regiongrowing(ho_Image, out ho_Regions, 1, 1, 3, 400);
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.ClearWindow(HDevWindowStack.GetActive());
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.SetColor(HDevWindowStack.GetActive(), "white");
    }
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.DispObj(ho_Regions, HDevWindowStack.GetActive());
    }
    HOperatorSet.CountObj(ho_Regions, out hv_Number);
    hv_Button = 1;
    if (HDevWindowStack.IsOpen())
    {
      HOperatorSet.SetColor(HDevWindowStack.GetActive(), "red");
    }
    while ((int)(new HTuple(hv_Button.TupleEqual(1))) != 0)
    {
      //Select region with the mouse
      //Use right mouse button to quit the loop
      HOperatorSet.GetMbutton(hv_WindowID, out hv_Row, out hv_Column, out hv_Button);
      if (HDevWindowStack.IsOpen())
      {
        HOperatorSet.ClearWindow(HDevWindowStack.GetActive());
      }
      if (HDevWindowStack.IsOpen())
      {
        HOperatorSet.SetColor(HDevWindowStack.GetActive(), "white");
      }
      if (HDevWindowStack.IsOpen())
      {
        HOperatorSet.DispObj(ho_Regions, HDevWindowStack.GetActive());
      }
      if (HDevWindowStack.IsOpen())
      {
        HOperatorSet.SetColor(HDevWindowStack.GetActive(), "red");
      }
      ho_DestRegions.Dispose();
      HOperatorSet.SelectRegionPoint(ho_Regions, out ho_DestRegions, hv_Row, hv_Column);
        if (HDevWindowStack.IsOpen())
        {
            HOperatorSet.DispObj(ho_DestRegions, HDevWindowStack.GetActive());
        }
      }

        while (true)
        {
            //Select region with the mouse
            //Use right mouse button to quit the loop
            HOperatorSet.GetMbutton(hv_WindowID, out hv_Row, out hv_Column, out hv_Button);
            if (hv_Button == 4)
            {
                HOperatorSet.CloseWindow(HDevWindowStack.Pop());
                break;
            }
        }
    ho_Image.Dispose();
    ho_Regions.Dispose();
    ho_DestRegions.Dispose();
        

    }

#endif


}


