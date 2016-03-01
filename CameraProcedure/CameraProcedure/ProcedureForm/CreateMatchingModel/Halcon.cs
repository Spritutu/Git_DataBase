using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.Windows.Forms;

namespace CameraProcedure
{
    public class Halcon
    {
        //HalconData Image
        public HObject Image = null;
        public HTuple ImageWidth = null;
        public HTuple ImageHeight = null;
        public HTuple uEye = null;
        public HTuple setexposure = 15;
        public OpenFileDialog OpenFileDialog = new OpenFileDialog();

        //Rectangle
        public HTuple RowRectangle = null, ColumnRectangle = null;
        public HTuple PhiRectangle = null;
        public HTuple Length1Rectangle = null, Length2Rectangle = null;
        public HObject Mod_ROI = null;
        public HObject ROI = null;

        //Creat
        public HTuple NumLevelsCreat = 0, AngleStartCreat = 0, AngleExtentCreat = 360;
        public HTuple ContrastCreat = 30, MinContrastCreat = 10;
        public HTuple ModelIDCreat = null;
        public HObject ShapeModelCreat = null;

        //Fine
        public HTuple MovementOfObjectFind = new HTuple();
        public HTuple RowFind = null, ColumnFind = null, AngleFind = null, ScoreFind = null;
        public HTuple AngleStartFind = 0, AngleExtentFind = 360, MinScoreFind = 0.6;
        public HTuple NumMatchFind = 3, NumLevelsFind = 0;
        public HTuple GreedinessFind = 0.7;
        public HObject ModelAtNewPosition = null;
        public HObject ShowMatch = null;

        public void setImage(HObject obj) 
        {
            Image = obj;
            HOperatorSet.GetImageSize(obj, out ImageWidth, out ImageHeight);
        }


    //開啟相機-------------------------------------------------------
    public void OpenCamera()
        {
            HOperatorSet.OpenFramegrabber("uEye", 1, 1, 0, 0, 0, 0, "default", -1, "default", -1, "default", "default", "4102742318", -1, -1, out uEye);
        }

        //setexposure曝光時間
        public void SerSetexposure(HTuple setexposure)
        {
            HOperatorSet.SetFramegrabberParam(uEye, "exposure", setexposure);
        }

        //相機選取檔案(Image) -----------
        public void ImageFomCamera(HWindow Window)
        {
            DisposeImage();
            HOperatorSet.GenEmptyObj(out Image);

            HOperatorSet.GrabImageStart(uEye, -1);
            HOperatorSet.GrabImageAsync(out Image, uEye, -1);

            HOperatorSet.GetImageSize(Image, out ImageWidth, out ImageHeight);
            if (Image != null)
            {
                HOperatorSet.SetSystem("width", ImageWidth);
                HOperatorSet.SetSystem("height", ImageHeight);
                HOperatorSet.SetPart(Window, 0, 0, ImageHeight - 1, ImageWidth - 1);
                HOperatorSet.ClearWindow(Window);
                HOperatorSet.DispObj(Image, Window);
            }
        }

        //檔案位置讀取圖片(Image)---------------------------
        public void ImageFomFile(HWindow Window)
        {
            OpenFileDialog OpenFileDialo_2 = new OpenFileDialog();
            if (OpenFileDialo_2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DisposeImage();
                HOperatorSet.GenEmptyObj(out Image);
                HOperatorSet.ReadImage(out Image, OpenFileDialo_2.FileName);
                HOperatorSet.GetImageSize(Image, out ImageWidth, out ImageHeight);
            }
            if (Image != null)
            {
                HOperatorSet.SetSystem("width", ImageWidth);
                HOperatorSet.SetSystem("height", ImageHeight);
                HOperatorSet.SetPart(Window, 0, 0, ImageHeight - 1, ImageWidth - 1);
                HOperatorSet.ClearWindow(Window);
                HOperatorSet.DispObj(Image, Window);
                OpenFileDialog = OpenFileDialo_2;
            }
            OpenFileDialo_2.Dispose();
        }

        //將圖片顯示在指定的halcon視窗上  輸入變數：HTuple Window(視窗)---
        public void ShowImage(HWindow Window)
        {
            if (Image != null)
            {
                HOperatorSet.SetSystem("width", ImageWidth);
                HOperatorSet.SetSystem("height", ImageHeight);
                HOperatorSet.SetPart(Window, 0, 0, ImageHeight - 1, ImageWidth - 1);
                HOperatorSet.ClearWindow(Window);
                HOperatorSet.DispObj(Image, Window);
            }
        }

        //關閉相機-------------------------------------------------------
        public void CameraClose()
        {
            HOperatorSet.CloseAllFramegrabbers();
        }

        //釋放Image物件------------------------------------------------
        public void DisposeImage()
        {
            if (Image != null)
            {
                Image.Dispose();
            }
        }

        //畫方形輸入:顯示視窗 , 圖 , ROI資料--------------------------------------------------------------------
        public void DrawRectangle(HTuple hwindows)
        {
            //Rectangle
            HObject Mod_ROI_2 = null;
            HObject ROI_2 = null;
            HOperatorSet.GenEmptyObj(out Mod_ROI_2);
            SettingLine(hwindows, "red", "margin", 2);
            HOperatorSet.DrawRectangle2Mod(hwindows,
                                           ImageHeight / 2,
                                           ImageWidth / 2,
                                           0,
                                           50,
                                           50,
                                           out RowRectangle,
                                           out ColumnRectangle,
                                           out PhiRectangle,
                                           out Length1Rectangle,
                                           out Length2Rectangle);
            //HOperatorSet.DrawRectangle2(hwindows,
            //                            out RowRectangle,
            //                            out ColumnRectangle,
            //                            out PhiRectangle,
            //                            out Length1Rectangle,
            //                            out Length2Rectangle);
            HOperatorSet.GenRectangle2(out ROI_2,
                                       RowRectangle,
                                       ColumnRectangle,
                                       PhiRectangle,
                                       Length1Rectangle,
                                       Length2Rectangle);
            HOperatorSet.ReduceDomain(Image, ROI_2, out Mod_ROI_2);
            HOperatorSet.DispObj(ROI_2, hwindows);

            ROI = ROI_2.Clone();
            Mod_ROI = Mod_ROI_2.Clone();

            ROI_2.Dispose();
            Mod_ROI_2.Dispose();
        }

        //線條參數-------------------------------------------------------------------------------
        public void SettingLine(HTuple hwindows, HTuple Color, HTuple Draw, HTuple LineWidth)
        {
            HOperatorSet.SetColor(hwindows, Color);
            HOperatorSet.SetDraw(hwindows, Draw);
            HOperatorSet.SetLineWidth(hwindows, LineWidth);
        }

        //Create---------------------------------------------------------------------------
        public void CreateShape(HTuple hwindows)
        {

            if (ShapeModelCreat != null)
            {
                ModelIDCreat.TupleRemove(ModelIDCreat);
                ShapeModelCreat.Dispose();
            }
            HOperatorSet.GenEmptyObj(out ShapeModelCreat);
            ////step 2: create the model
            SettingLine(hwindows, "yellow", "margin", 2);
            HOperatorSet.CreateShapeModel(Mod_ROI,
                                          NumLevelsCreat,
                                          (AngleStartCreat).TupleRad(),
                                          (AngleExtentCreat).TupleRad(),
                                          "auto",
                                          "none",
                                          "use_polarity",
                                          ContrastCreat,
                                          MinContrastCreat,
                                          out ModelIDCreat);
            HOperatorSet.GetShapeModelContours(out ShapeModelCreat, ModelIDCreat, 1);
        }

        //Find------------------------------------------------------------------------------------
        public void FindShape(HTuple hwindows)
        {

            if (ModelAtNewPosition != null)
            {
                ModelAtNewPosition.Dispose();
            }
            if (ShowMatch != null)
            {
                ShowMatch.Dispose();
            }
            HOperatorSet.GenEmptyObj(out ModelAtNewPosition);
            HOperatorSet.GenEmptyObj(out ShowMatch);
            SettingLine(hwindows, "red", "margin", 2);
            //step 3: find the object in other images
            HOperatorSet.FindShapeModel(Image,
                                        ModelIDCreat,
                                        (AngleStartFind).TupleRad(),
                                        (AngleExtentFind).TupleRad(),
                                        MinScoreFind,
                                        NumMatchFind,
                                        0.5,
                                        "least_squares",
                                        NumLevelsFind,
                                        GreedinessFind,
                                        out RowFind,
                                        out ColumnFind,
                                        out AngleFind,
                                        out ScoreFind);

            for (int i = 0; i <= (int)((new HTuple(ScoreFind.TupleLength())) - 1); i = i + 1)
            {
                HOperatorSet.VectorAngleToRigid(0,
                                                0,
                                                0,
                                                RowFind.TupleSelect(i),
                                                ColumnFind.TupleSelect(i),
                                                AngleFind.TupleSelect(i),
                                                out MovementOfObjectFind);
                HOperatorSet.AffineTransContourXld(ShapeModelCreat,
                                                   out ModelAtNewPosition,
                                                   MovementOfObjectFind);
                HOperatorSet.GenRectangle2ContourXld(out ShowMatch,
                                                    RowFind.TupleSelect(i),
                                                    ColumnFind.TupleSelect(i),
                                                    PhiRectangle + AngleFind.TupleSelect(i),
                                                    Length1Rectangle,
                                                    Length2Rectangle);
                HOperatorSet.DispObj(ShowMatch, hwindows);
            }
            
        }

        //ADDDataGridView------------------------------------------------------
        public void ADDCreatDataGridView(DataGridView DataGridView)
        {
            DataGridView.Rows.Clear();
            DataGridViewRowCollection rows = DataGridView.Rows;
            for (int i = 0; i <= (int)((new HTuple(ScoreFind.TupleLength())) - 1); i = i + 1)
            {
                rows.Add(new Object[] { RowFind.TupleSelect(i), ColumnFind.TupleSelect(i), AngleFind.TupleSelect(i), ScoreFind.TupleSelect(i) });
            }
        }
    }
}
