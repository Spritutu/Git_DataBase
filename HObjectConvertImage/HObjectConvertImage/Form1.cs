using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;


namespace HObjectConvertImage
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32", EntryPoint = "RtlMoveMemory", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern void CopyMemory(int Destination, int Source, int length);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HImage img1 = new HImage();
            IntPtr pt;
            int mwidth, mheight;
            string mtype = "";
            Bitmap img;
            ColorPalette pal;
            int i;
            const int Alpha = 255;
            BitmapData bitmapData;
            Rectangle rect;
            int[] ptr = new int[2];
            int PixelSize;
            img1.ReadImage("clip");
            pt = img1.GetImagePointer1(out mtype, out mwidth, out mheight);
            img = new Bitmap(mwidth, mheight, PixelFormat.Format8bppIndexed);
            pal = img.Palette;
            for (i = 0; i <= 255; i++)
            {
                pal.Entries = Color.FromArgb(Alpha, i, i, i);
            }
            img.Palette = pal;
            rect = new Rectangle(0, 0, mwidth, mheight);
            bitmapData = img.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            PixelSize = Bitmap.GetPixelFormatSize(bitmapData.PixelFormat) / 8;
            ptr[0] = bitmapData.Scan0.ToInt32();
            ptr[1] = pt.ToInt32();
            if (mwidth % 4 == 0)
                CopyMemory(ptr[0], ptr[1], mwidth * mheight * PixelSize);
            else
            {
                for (i = 0; i < mheight; i++)
                {
                    ptr[1] += mwidth;
                    CopyMemory(ptr[0], ptr[1], mwidth * PixelSize);
                    ptr[0] += bitmapData.Stride;
                }
            }
            img.UnlockBits(bitmapData);
            pictureBox.Image = img;
            img1.Dispose();
        }
    }
}