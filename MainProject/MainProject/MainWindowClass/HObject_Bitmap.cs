using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using HalconDotNet;

namespace MainProject
{
    class HObject_Bitmap
    {
        public static Bitmap HObject2Bitmap(HObject myHObject)
        {

            HTuple pointerRed = null;
            HTuple pointerGreen = null;
            HTuple pointerBlue = null;
            HTuple type;
            HTuple width;
            HTuple height;
            HOperatorSet.GetImagePointer3(myHObject, out pointerRed, out pointerGreen, out pointerBlue, out type, out width, out height);

            Bitmap bitmap = new Bitmap((Int32)width, (Int32)height, PixelFormat.Format32bppRgb);
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width / 4, bitmap.Height / 4), ImageLockMode.ReadWrite, bitmap.PixelFormat);
            IntPtr source_scan = bmpData.Scan0;

            unsafe
            {
                byte* source_p = (byte*)source_scan.ToPointer();
                byte* Red = (byte*)pointerRed.IP.ToPointer();
                byte* Blue = (byte*)pointerBlue.IP.ToPointer();
                byte* Green = (byte*)pointerGreen.IP.ToPointer();

                for (int h = 0; h < bitmap.Height; h++)
                {
                    for (int w = 0; w < bitmap.Width; w++)
                    {
                        source_p[0] = Blue[0];  //A
                        source_p++;
                        Blue++;
                        source_p[0] = Green[0];  //R
                        source_p++;
                        Green++;
                        source_p[0] = Red[0];  //G
                        source_p++;
                        Red++;
                        //source_p[0] = Blue[0];   //B
                        source_p++;
                    }
                }

            }

            bitmap.UnlockBits(bmpData);
            return bitmap;
        }

        public static HObject Bitmap2HObject(Bitmap myBitmap)
        {
            int iwidth = myBitmap.Width;
            int iHeight = myBitmap.Height;

            Bitmap myBitmap_New = new Bitmap(iwidth, iHeight, PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(myBitmap_New);
            g.DrawImage(myBitmap, new Point(0, 0));
            g.Dispose();

            HObject img;
            Rectangle rect = new Rectangle(0, 0, myBitmap_New.Width, myBitmap_New.Height);
            BitmapData bitmapData = myBitmap_New.LockBits(rect, ImageLockMode.ReadWrite, myBitmap_New.PixelFormat);
            HOperatorSet.GenImageInterleaved(out img, bitmapData.Scan0, "bgrx", myBitmap_New.Width, myBitmap_New.Height, -1, "byte", 0, 0, 0, 0, -1, 0);
            myBitmap_New.UnlockBits(bitmapData);
            return img;
        }
    }
}
