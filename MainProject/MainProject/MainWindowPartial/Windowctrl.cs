using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using HalconDotNet;//測試用 不應該存在於使用者介面


namespace MainProject
{
    public partial class MainFrom : Form  //視窗控制部分
    {
        //-----------測試區-----------------------------------------------
        private ImageBase window_image = new ImageBase();
        PointBase mousePosition_pre = new PointBase();
        PointBase mousePosition = new PointBase();
        //-----------測試區-----------------------------------------------

        private void test()
        {
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camera[0];
            
            HObject Image;
            HOperatorSet.GenEmptyObj(out Image);
            string str = System.Windows.Forms.Application.StartupPath;
            HOperatorSet.ReadImage(out Image, str+ "\\OnePounch.jpg");
            Object O = new Object();
            O = (Object)mwo.Object[0];


            window_image.SetImage = Image;
            O.Image = Image;
            mwo.Object[0] = O;

            window_image.ShowImage_autosize(MainWindow.HalconWindow);

        }
        


        private void MainWindow_HMouseMove(object sender, HMouseEventArgs e)
        {
            mousePosition.GetMposition(MainWindow.HalconWindow);
            MouseXY.Text = "Mouse(" + mousePosition.col.ToString() + "," + mousePosition.row.ToString() + ")";
            pixelvalue.Text = "pixelvalue =" + window_image.PiexlGrayval(mousePosition).ToString();

        }
    }
}
