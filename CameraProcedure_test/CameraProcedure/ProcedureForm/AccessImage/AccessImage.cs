using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;
namespace CameraProcedure
{
    public class AccessImage
    {

        private ImageBase imagebase = new ImageBase();
        private HTuple window;

        public void ImagefromFile()
        {
            imagebase.ImagefromFile();
        }
        public void setwindow(HTuple win)
        {
            window = win;
        }

        public ImageBase getimagebase()
        {
            return imagebase;
        }
        

        public void show()
        {
            HOperatorSet.SetPart(window, 0, 0, imagebase.GetHeight - 1, imagebase.GetWidth - 1);
            HOperatorSet.ClearWindow(window);
            HOperatorSet.DispObj(imagebase.GetImage, window);
        }
    }
}
