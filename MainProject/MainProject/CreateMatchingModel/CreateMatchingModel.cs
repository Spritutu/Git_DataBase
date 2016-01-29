using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST_Base;
namespace MainProject
{
    public partial class CreateMatchingModel : Form
    {
        public bool setornot = false;

        public CreateMatchingModel()
        {
            InitializeComponent();
        }
        private ImageBase CreateMatchingModel_window_image = new ImageBase();
        private void CreatMatchingModel_window_HMouseMove(object sender, HalconDotNet.HMouseEventArgs e)
        {
            PointBase mousePosition = new PointBase();
            //取得滑鼠在視窗上的位置
            mousePosition.GetMposition(CreateMatchingModel_window.HalconWindow);
            //顯示位置
            MouseXY.Text = "Mouse(" + mousePosition.col.ToString() + "," + mousePosition.row.ToString() + ")";
            //顯示滑鼠位置的灰階值
            pixelvalue.Text = "pixelvalue =" + CreateMatchingModel_window_image.PiexlGrayval(mousePosition).ToString();
        }
    }
}
