using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using ST_Base;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {//產生選擇檔案視窗-----------------------------------------------
        protected OpenFileDialog openFileDialog1 = new OpenFileDialog();
        HTuple hv_Width, hv_Height;
        HObject Image = new HObject();
        HObject Image2;
        HObject Image3;
        ImageBase ImageBase = new ImageBase();
        ImageBase ImageBase2 = new ImageBase();
        ImageBase ImageBase3 = new ImageBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "Image Files (*.bmp, *.gif, *.jpg,*.png)|*.bmp; *.gif*;*.jpg;*.png";
            openFileDialog1.InitialDirectory = "C:/Users/User/Desktop/ZQSFP_ detection2015_12_09/ZQSFP_ detection";
            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Image != null)
                {
                    Image.Dispose();
                }
                HOperatorSet.GenEmptyObj(out Image);
                HOperatorSet.ReadImage(out Image, openFileDialog1.FileName);
                HOperatorSet.GetImageSize(Image, out hv_Width, out hv_Height);

            }
            else
            {
                Image = null;
            }

            HOperatorSet.GetImageSize(Image, out hv_Width, out hv_Height);
            HOperatorSet.SetSystem("width", hv_Width);
            HOperatorSet.SetSystem("height", hv_Height);
            HOperatorSet.SetPart(hWindowControl1.HalconWindow, 0, 0, hv_Height - 1, hv_Width - 1);
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            HOperatorSet.DispObj(Image, hWindowControl1.HalconWindow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test te = new test();
            test te2 = new test();
            ImageBase.ImagefromFile();

            te.OBJ = ImageBase.GetImage;
            //te2 = te;
            te2.OBJ = te.OBJ;
            te2.OBJ = Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOperatorSet.ReadImage(out Image2, "C:/Users/User/Desktop/ccd+25mm.bmp");
            Image = Image2;
            HOperatorSet.GetImageSize(Image, out hv_Width, out hv_Height);
            HOperatorSet.SetSystem("width", hv_Width);
            HOperatorSet.SetSystem("height", hv_Height);
            HOperatorSet.SetPart(hWindowControl1.HalconWindow, 0, 0, hv_Height - 1, hv_Width - 1);
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            HOperatorSet.DispObj(Image, hWindowControl1.HalconWindow);

        }
    }
}
