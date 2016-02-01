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

namespace ST_LoadImage
{
    public partial class ST_LoadImage : UserControl
    {
        internal static ImageBase loadimage = new ImageBase();

        public ImageBase getloadimage
        {
            get { return loadimage; }
        }

        public ST_LoadImage()
        {
            InitializeComponent();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose();
            choose.ShowDialog();
            choose.Close();
            this.OnClick(e);
        }
    }
}
