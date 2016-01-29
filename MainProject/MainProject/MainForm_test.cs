using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class MainForm_test : Form
    {
        public MainForm_test()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void procedureButton_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.ShowDialog();
        }
    }
}
