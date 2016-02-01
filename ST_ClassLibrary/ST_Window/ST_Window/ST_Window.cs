using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST_Base;
using HalconDotNet;
namespace ST_Window
{
    public partial class ST_Window : UserControl
    {
        private ImageBase window_image = new ImageBase();
        private RegionBase window_region = new RegionBase();

        public ImageBase Window_Image {
            get { return window_image; }
            set { window_image = value; }
        }
        public RegionBase Window_Region
        {
            get { return window_region; }
            set { window_region = value; }
        }

        PointBase mousePosition_pre = new PointBase();
        PointBase mousePosition = new PointBase();

        private HTuple zoom_beginRow, zoom_beginCol, zoom_endRow, zoom_endCol;
        private HTuple current_beginRow, current_beginCol, current_endRow, current_endCol;

        public bool flag = false;
        
        private void Window_HMouseDown(object sender, HMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle)
                flag = true;
        }

        private void Window_HMouseUp(object sender, HMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                flag = false;
        }

        public ST_Window()
        {
            InitializeComponent();
        }

        private void Window_HMouseMove(object sender, HalconDotNet.HMouseEventArgs e)
        {
            
            mousePosition.GetMposition(Window.HalconWindow);
            imagestatus_column.Text = mousePosition.col.ToString();
            imagestatus_row.Text = mousePosition.row.ToString();
            imagestatus_gravalue.Text = window_image.PiexlGrayval(mousePosition).ToString();

            if (window_image.GetImage != null && flag == true && mousePosition_pre != null)
            {
                HTuple diff_row, diff_col;
                diff_row = mousePosition.row - mousePosition_pre.row;
                diff_col = mousePosition.col - mousePosition_pre.col;
                mousePosition.GetMpositionSubPix(Window.HalconWindow);
                HOperatorSet.GetPart(Window.HalconWindow, out current_beginRow, out current_beginCol, out current_endRow, out current_endCol);
                HOperatorSet.ClearWindow(Window.HalconWindow);
                HOperatorSet.SetPaint(Window.HalconWindow, new HTuple("default"));//保持图像显示比例
                HOperatorSet.SetPart(Window.HalconWindow, current_beginRow- diff_row, current_beginCol-diff_col, current_endRow- diff_row, current_endCol-diff_col);
                HOperatorSet.DispObj(window_image.GetImage, Window.HalconWindow);
            }
            mousePosition_pre.GetMposition(Window.HalconWindow);

            //if (window_region != null)
            //{
            //    window_region.showROI(Window.HalconWindow);
            //}

        }

        public void DispImageFit(HTuple window)
        {
            HTuple window_Width, window_Height;
            HTuple ratio_win, ratio_img;
            HTuple image_Width, image_Height;

            HOperatorSet.GetSystem("width",out window_Width);
            HOperatorSet.GetSystem("width",out window_Height);
            if (window_image.GetImage!= null)
            {
                HOperatorSet.GetImageSize(window_image.GetImage, out image_Width, out image_Height);

                ratio_win = (double)window_Width / (double)window_Height;
                ratio_img = (double)image_Width / (double)image_Height;

                HTuple _beginRow, _begin_Col, _endRow, _endCol;

                if (ratio_win >= ratio_img)
                {
                    _beginRow = 0;
                    _endRow = image_Height - 1;
                    _begin_Col = (-image_Width * (ratio_win / ratio_img - 1d) / 2d);
                    _endCol = (image_Width + image_Width * (ratio_win / ratio_img - 1d) / 2d);
                }
                else
                {
                    _begin_Col = 0;
                    _endCol = image_Width - 1;
                    _beginRow = (-image_Height * (ratio_img / ratio_win - 1d) / 2d);
                    _endRow = (image_Height + image_Height * (ratio_img / ratio_win - 1d) / 2d);
                }

                HOperatorSet.ClearWindow(window);
                HOperatorSet.SetPart(window,_beginRow, _begin_Col, _endRow, _endCol);
                HOperatorSet.DispObj(window_image.GetImage, window);
            }
            //if (window_region != null)
            //{
            //    window_region.showROI(Window.HalconWindow);
            //}
        }

        private void Window_HMouseWheel(object sender, HalconDotNet.HMouseEventArgs e)
        {
            
            if (window_image.GetImage != null)
            {
                try
                {
                    mousePosition.GetMpositionSubPix(Window.HalconWindow);
                    HOperatorSet.GetPart(Window.HalconWindow,out current_beginRow, out current_beginCol, out current_endRow, out current_endCol);
                }
                catch (Exception ex)
                {
                    m_CtrlHStatusLabelCtrl.Text = ex.Message;
                }

                if (e.Delta > 0)// 放大图像
                {
                    zoom_beginRow = (current_beginRow + (mousePosition.row - current_beginRow) * 0.300d);
                    zoom_beginCol = (current_beginCol + (mousePosition.col - current_beginCol) * 0.300d);
                    zoom_endRow = (current_endRow - (current_endRow - mousePosition.row) * 0.300d);
                    zoom_endCol = (current_endCol - (current_endCol - mousePosition.col) * 0.300d);
                }
                else// 缩小图像
                {
                    zoom_beginRow = (mousePosition.row - (mousePosition.row - current_beginRow) / 0.700d);
                    zoom_beginCol = (mousePosition.col - (mousePosition.col - current_beginCol) / 0.700d);
                    zoom_endRow = (mousePosition.row + (current_endRow - mousePosition.row) / 0.700d);
                    zoom_endCol = (mousePosition.col + (current_endCol - mousePosition.col) / 0.700d);
                }

                try
                {
                    int hw_width, hw_height;
                    hw_width = Window.WindowSize.Width;
                    hw_height = Window.WindowSize.Height;

                    bool _isOutOfArea = true;
                    bool _isOutOfSize = true;
                    bool _isOutOfPixel = true; //避免像素过大

                    _isOutOfArea = zoom_beginRow >= window_image.GetHeight || zoom_endRow <= 0 || zoom_beginCol >= window_image.GetWidth || zoom_endCol < 0;
                    _isOutOfSize = (zoom_endRow - zoom_beginRow) > window_image.GetHeight * 20 || (zoom_endCol - zoom_beginCol) > window_image.GetWidth * 20;
                    _isOutOfPixel = hw_height / (zoom_endRow - zoom_beginRow) > 500 || hw_width / (zoom_endCol - zoom_beginCol) > 500;

                    if (_isOutOfArea || _isOutOfSize)
                    {
                        //DispImageFit(Window.HalconWindow);
                    }
                    else if (!_isOutOfPixel)
                    {
                        HOperatorSet.ClearWindow(Window.HalconWindow);
                        HOperatorSet.SetPaint(Window.HalconWindow,new HTuple("default"));//保持图像显示比例
                        HOperatorSet.SetPart(Window.HalconWindow,zoom_beginRow, zoom_beginCol, zoom_endRow, zoom_beginCol + (zoom_endRow - zoom_beginRow) * hw_width / hw_height);
                        HOperatorSet.DispObj(window_image.GetImage, Window.HalconWindow);
                    }
                }
                catch (Exception ex)
                {
                    //DispImageFit(Window.HalconWindow);
                    //m_CtrlHStatusLabelCtrl.Text = ex.Message;
                }
            }
            //if (window_region != null)
            //{
            //    window_region.showROI(Window.HalconWindow);
            //}
        }
    }
}
