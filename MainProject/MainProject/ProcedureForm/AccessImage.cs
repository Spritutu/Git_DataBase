﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using ST_Base;
namespace MainProject
{
    public class AccessImage
    {

        private ImageBase imagebase = new ImageBase();
        private Object_Table O = new Object_Table();
        private HTuple window;

        public void ImagefromFile()
        {
            imagebase.ImagefromFile();
            O.Image = imagebase.GetImage;
        }
        public void setwindow(HTuple win)
        {
            window = win;
        }

        public Object_Table getObject()
        {
            return O;
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
