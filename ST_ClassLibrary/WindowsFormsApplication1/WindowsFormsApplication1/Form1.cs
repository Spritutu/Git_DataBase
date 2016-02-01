using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST_LoadImage;
using HalconDotNet;
using ST_Window;
using ST_Base;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ImageBase MainImage = new ImageBase();
        ImageBase otherImage = new ImageBase();
        RegionBase rec = new RegionBase();
        MatchModel match = new MatchModel() ;
        Measure measure = new Measure();
        RegionBase rec_measure = new RegionBase();
        Matching matching = new Matching();


        public Form1()
        {
            InitializeComponent();
        }

        private void sT_LoadImage_Click(object sender, EventArgs e)
        {
            sT_Window.Window.Focus();
            sT_Window.Window_Image = sT_LoadImage.getloadimage;
            MainImage = sT_LoadImage.getloadimage;
            sT_Window.Window_Image.ShowImage_autosize(sT_Window.Window.HalconWindow);
            
        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            sT_Window.Window.Focus();
            rec.emptyallparameter();
            rec.DrawROIRectangle(sT_Window.Window.HalconWindow);
            if (rec != null)
                sT_Window.Window_Region = rec;
        }

        private void fit_button_Click(object sender, EventArgs e)
        {
            sT_Window.DispImageFit(sT_Window.Window.HalconWindow);
        }

        private void Match_button_Click(object sender, EventArgs e)
        {
            match.ShapeModel(rec, MainImage);
            match.Show(sT_Window.Window.HalconWindow);
        }

        private void Measure_button_Click(object sender, EventArgs e)
        {
            rec_measure.DrawROIRectangle(sT_Window.Window.HalconWindow);
            measure.Measure_rectangle2(rec_measure, MainImage,1,25);
            measure.disp_Measure_rectangle2(sT_Window.Window.HalconWindow);
        }

        private void MatchingNMeasure_button_Click(object sender, EventArgs e)
        {
            otherImage.ImagefromFile();
            matching.matchingNmeasure(match, measure, otherImage, rec, rec_measure, sT_Window.Window.HalconWindow);


        }
    }
}
