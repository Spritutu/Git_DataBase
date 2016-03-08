using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using ST_Base;

enum choose { cursor , move ,zoom, zoomin , zoomout , fit }


namespace ToolWindow
{
    public partial class ToolWindow: UserControl
    {
        // 建立事件和事件觸發函數
        public event HMouseEventHandler Toolwindow_UP;
        public event HMouseEventHandler Toolwindow_DWON;
        public event HMouseEventHandler Toolwindow_WHEEL;
        public event HMouseEventHandler Toolwindow_MOVE;

        protected void ToolwindowUP(HMouseEventArgs e)
        {
            if (Toolwindow_UP != null)
                Toolwindow_UP(this, e);
        }
        protected void ToolwindowDWON(HMouseEventArgs e)
        {
            if (Toolwindow_DWON != null)
                Toolwindow_DWON(this, e);
        }
        protected void ToolwindowWHEEL(HMouseEventArgs e)
        {
            if (Toolwindow_WHEEL != null)
                Toolwindow_WHEEL(this, e);
        }
        protected void ToolwindowMOVE(HMouseEventArgs e)
        {
            if (Toolwindow_MOVE != null)
                Toolwindow_MOVE(this, e);
        }
        
        private ImageBase windowImage = new ImageBase();
        public ImageBase WindowImage{get { return windowImage; }set { windowImage = value; }}






        private List<setObjectdisplay> setObject_display = new List<setObjectdisplay>();
        private List<HObject> Object_disp = new List<HObject>();
        public void Add_Object_disp(HObject obj, HTuple color, HTuple Draw, HTuple LineWidth)
        {
            setObjectdisplay OD = new setObjectdisplay();
            OD.color = color;
            OD.Draw = Draw;
            OD.LineWidth = LineWidth;
            Object_disp.Add(obj);
            setObject_display.Add(OD);
        }
        public void Remove_Object_disp(HObject obj)
        {
            Object_disp.Remove(obj);
        }
        private void DispObject()
        {
            for (int i = 0; i < Object_disp.Count; i++)
            {
                if (Object_disp[i] != null)
                {
                    setSystem.SetPen(this.window.HalconWindow, setObject_display[i].color, setObject_display[i].Draw, setObject_display[i].LineWidth);
                    HOperatorSet.DispObj(Object_disp[i], this.window.HalconWindow);
                }
            }
        }



        private PointBase mousePosition_pre = new PointBase();
        private PointBase mousePosition = new PointBase();
        private int dowhat = (int)choose.cursor;
        private bool move_flag = false;

        private HTuple zoom_beginRow, zoom_beginCol, zoom_endRow, zoom_endCol;
        private HTuple current_beginRow, current_beginCol, current_endRow, current_endCol;

        public ToolWindow()
        {
            InitializeComponent();
        }
        public void showImage() {
            if (windowImage != null)
                windowImage.ShowImage_autosize(window.HalconWindow);
            DispImageFit(window.HalconWindow);
        }

        private void Window_HMouseMove(object sender, HalconDotNet.HMouseEventArgs e)
        {
            //取得滑鼠在視窗上的位置
            mousePosition.GetMposition(window.HalconWindow);
            //顯示位置
            MouseXY.Text = "Mouse(" + mousePosition.col.ToString() + "," + mousePosition.row.ToString() + ")";
            //顯示滑鼠位置的灰階值
            pixelvalue.Text = "pixelvalue =" + windowImage.PiexlGrayval(mousePosition).ToString();

            switch (dowhat)
            {
                case (int)choose.cursor:
                    break;

                case (int)choose.move:

                    if (windowImage.GetImage != null && move_flag == true && mousePosition_pre != null)
                    {
                        HTuple diff_row, diff_col;
                        diff_row = mousePosition.row - mousePosition_pre.row;
                        diff_col = mousePosition.col - mousePosition_pre.col;
                        mousePosition.GetMpositionSubPix(window.HalconWindow);
                        HOperatorSet.GetPart(window.HalconWindow, out current_beginRow, out current_beginCol, out current_endRow, out current_endCol);
                        HOperatorSet.ClearWindow(window.HalconWindow);
                        HOperatorSet.SetPaint(window.HalconWindow, new HTuple("default"));//保持图像显示比例
                        HOperatorSet.SetPart(window.HalconWindow, current_beginRow - diff_row, current_beginCol - diff_col, current_endRow - diff_row, current_endCol - diff_col);
                        HOperatorSet.DispObj(windowImage.GetImage, window.HalconWindow);
                    }
                    mousePosition_pre.GetMposition(window.HalconWindow);
                    break;
            }
            ToolwindowMOVE(e);

           

        }


        

        private void ToolWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void ZoomButton_Click(object sender, EventArgs e)
        {
            dowhat = (int)choose.zoom;
        }

        private void Window_HMouseWheel(object sender, HMouseEventArgs e)
        {
            switch (dowhat)
            {
                case (int)choose.cursor:
                    break;

                case (int)choose.move:
                    break;
                case (int)choose.zoom:
                    if (windowImage.GetImage != null)
                    {
                        try
                        {
                            //mousePosition.GetMpositionSubPix(window.HalconWindow);
                            mousePosition.row = e.X;
                            mousePosition.col = e.Y;

                            HOperatorSet.GetPart(window.HalconWindow, out current_beginRow, out current_beginCol, out current_endRow, out current_endCol);
                        }
                        catch (Exception ex)
                        {
                            //m_CtrlHStatusLabelCtrl.Text = ex.Message;
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
                            hw_width = window.WindowSize.Width;
                            hw_height = window.WindowSize.Height;

                            bool _isOutOfArea = true;
                            bool _isOutOfSize = true;
                            bool _isOutOfPixel = true; //避免像素过大
                            

                            _isOutOfArea = zoom_beginRow >= windowImage.GetHeight || zoom_endRow <= 0 || zoom_beginCol >= windowImage.GetWidth || zoom_endCol < 0;
                            _isOutOfSize = (zoom_endRow - zoom_beginRow) > windowImage.GetHeight * 40 || (zoom_endCol - zoom_beginCol) > windowImage.GetWidth * 40;
                            //_isOutOfPixel = hw_height / (zoom_endRow - zoom_beginRow) > 500 || hw_width / (zoom_endCol - zoom_beginCol) > 500;
                            _isOutOfPixel = (zoom_endRow - zoom_beginRow) < 10 || (zoom_endCol - zoom_beginCol) < 10;

                            if (_isOutOfArea || _isOutOfSize)
                            {
                                //DispImageFit(Window.HalconWindow);
                            }
                            else if (!_isOutOfPixel)
                            {
                                HOperatorSet.ClearWindow(window.HalconWindow);
                                HOperatorSet.SetPaint(window.HalconWindow, new HTuple("default"));//保持图像显示比例
                                HOperatorSet.SetPart(window.HalconWindow, zoom_beginRow, zoom_beginCol, zoom_endRow, zoom_beginCol + (zoom_endRow - zoom_beginRow) * hw_width / hw_height);
                                HOperatorSet.DispObj(windowImage.GetImage, window.HalconWindow);
                            }
                        }
                        catch (Exception ex)
                        {
                            //DispImageFit(Window.HalconWindow);
                            //m_CtrlHStatusLabelCtrl.Text = ex.Message;
                        }
                    }
                    break;
            }
            ToolwindowWHEEL(e);
            DispObject();
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            dowhat = (int)choose.fit;
            DispImageFit(window.HalconWindow);


        }

        private void cursorButton_Click(object sender, EventArgs e)
        {
            dowhat = (int)choose.cursor;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            dowhat = (int)choose.move;
        }

        private void ZoominButton_Click(object sender, EventArgs e)
        {
            dowhat = (int)choose.zoomin;
        }

        private void ZoomoutButton_Click(object sender, EventArgs e)
        {
            dowhat = (int)choose.zoomout;
        }

        private void Window_HMouseDown(object sender, HMouseEventArgs e)
        {

            switch (dowhat)
            {
                case (int)choose.cursor:
                    break;

                case (int)choose.move:
                    if (e.Button == MouseButtons.Left)
                        move_flag = true;
                    this.Cursor = Cursors.SizeAll;
                    break;
            }
            ToolwindowDWON(e);
            DispObject();
        }

        private void Window_HMouseUp(object sender, HMouseEventArgs e)
        {
            switch (dowhat)
            {
                case (int)choose.cursor:
                    break;

                case (int)choose.move:
                    if (e.Button == MouseButtons.Left)
                        move_flag = false;
                    this.Cursor = Cursors.Arrow;
                    break;
            }

            // 觸發 ToolwindowUP Event
            ToolwindowUP(e);
            DispObject();
        }

        public void DispImageFit(HTuple window)
        {
            HTuple window_Width, window_Height;
            HTuple ratio_win, ratio_img;
            HTuple image_Width, image_Height;

            HOperatorSet.GetSystem("width", out window_Width);
            HOperatorSet.GetSystem("height", out window_Height);
            if (windowImage.GetImage != null)
            {
                HOperatorSet.GetImageSize(windowImage.GetImage, out image_Width, out image_Height);

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

                HOperatorSet.ClearWindow(this.window.HalconWindow);
                HOperatorSet.SetPart(this.window.HalconWindow, _beginRow, _begin_Col, _endRow, _endCol);
                HOperatorSet.DispObj(windowImage.GetImage, this.window.HalconWindow);
            }

            DispObject();
        }
    }
}
