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

namespace ZQSFP_detection
{
    public partial class CameraWindow : Form
    {
        public HObject capture;
        public CameraWindow()
        {
            InitializeComponent();

            if (CamerabackgroundWorker.IsBusy != true)//背景執行緒沒啟動
            {
                CamerabackgroundWorker.RunWorkerAsync();
            }
            else//背景執行緒已啟動
                MessageBox.Show("攝影已經開始了");
            
            HOperatorSet.SetSystem("width", 2440);//????
            HOperatorSet.SetSystem("height", 2048);//???
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(capture != null)
            ZQSFP_Form.Mainpicture = capture.Clone();
            capture.Dispose();
            this.Close();
        }

        private void CameraCaptrue_Click(object sender, EventArgs e)
        {
            Camera.captrue(out capture);
            HOperatorSet.SetSystem("width", Camera.hv_ImageWidth);//????
            HOperatorSet.SetSystem("height", Camera.hv_ImageHeight);//???
            HOperatorSet.SetPart(this.Camera_halcon_Capture.HalconWindow, 0, 0, Camera.hv_ImageHeight - 1, Camera.hv_ImageWidth - 1);
            HOperatorSet.DispObj(capture, this.Camera_halcon_Capture.HalconWindow);

        }

        private void CamerabackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Camera.Cancel = false;
            Camera.Camera_startgabber();
            Camera.RunHalcon(Camera_halcon_Vedio.HalconWindow);//影像開始進入
        }
        private void CameraWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            Camera.Cancel = true;//相機運行參數關閉
            CamerabackgroundWorker.CancelAsync();//執行續關閉Cancel the asynchronous operation.
            CamerabackgroundWorker.Dispose();
            Close();
        }

        private void CameraWindow_Load(object sender, EventArgs e)
        {
            Camera.exposure = 15;
            while (true)
            {
                if (Camera.alreadyopen == true)
                    break;
            }
        }

        private void exposure_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.exposure_domainUpDown.Value = this.exposure_trackBar.Value;

            Camera.exposure = exposure_trackBar.Value;
            Camera.setexposure();
        }

        private void exposure_domainUpDown_VisibleChanged(object sender, EventArgs e)
        {
            
                 this.exposure_trackBar.Value = (int)this.exposure_domainUpDown.Value;
        }
    }
}
