namespace ZQSFP_detection
{
    partial class CameraWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Camera_halcon_Vedio = new HalconDotNet.HWindowControl();
            this.CameraCaptrue = new System.Windows.Forms.Button();
            this.Camera_halcon_Capture = new HalconDotNet.HWindowControl();
            this.OK = new System.Windows.Forms.Button();
            this.CamerabackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.exposure_trackBar = new System.Windows.Forms.TrackBar();
            this.exposure = new System.Windows.Forms.Label();
            this.exposure_domainUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_domainUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Camera_halcon_Vedio
            // 
            this.Camera_halcon_Vedio.BackColor = System.Drawing.Color.Black;
            this.Camera_halcon_Vedio.BorderColor = System.Drawing.Color.Black;
            this.Camera_halcon_Vedio.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Camera_halcon_Vedio.Location = new System.Drawing.Point(12, 12);
            this.Camera_halcon_Vedio.Name = "Camera_halcon_Vedio";
            this.Camera_halcon_Vedio.Size = new System.Drawing.Size(513, 467);
            this.Camera_halcon_Vedio.TabIndex = 0;
            this.Camera_halcon_Vedio.WindowSize = new System.Drawing.Size(513, 467);
            // 
            // CameraCaptrue
            // 
            this.CameraCaptrue.Location = new System.Drawing.Point(531, 369);
            this.CameraCaptrue.Name = "CameraCaptrue";
            this.CameraCaptrue.Size = new System.Drawing.Size(286, 52);
            this.CameraCaptrue.TabIndex = 1;
            this.CameraCaptrue.Text = "擷圖";
            this.CameraCaptrue.UseVisualStyleBackColor = true;
            this.CameraCaptrue.Click += new System.EventHandler(this.CameraCaptrue_Click);
            // 
            // Camera_halcon_Capture
            // 
            this.Camera_halcon_Capture.BackColor = System.Drawing.Color.Black;
            this.Camera_halcon_Capture.BorderColor = System.Drawing.Color.Black;
            this.Camera_halcon_Capture.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Camera_halcon_Capture.Location = new System.Drawing.Point(531, 42);
            this.Camera_halcon_Capture.Name = "Camera_halcon_Capture";
            this.Camera_halcon_Capture.Size = new System.Drawing.Size(286, 189);
            this.Camera_halcon_Capture.TabIndex = 3;
            this.Camera_halcon_Capture.WindowSize = new System.Drawing.Size(286, 189);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(531, 427);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(286, 52);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CamerabackgroundWorker
            // 
            this.CamerabackgroundWorker.WorkerSupportsCancellation = true;
            this.CamerabackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CamerabackgroundWorker_DoWork);
            // 
            // exposure_trackBar
            // 
            this.exposure_trackBar.Location = new System.Drawing.Point(531, 318);
            this.exposure_trackBar.Maximum = 255;
            this.exposure_trackBar.Name = "exposure_trackBar";
            this.exposure_trackBar.Size = new System.Drawing.Size(286, 45);
            this.exposure_trackBar.TabIndex = 5;
            this.exposure_trackBar.TickFrequency = 5;
            this.exposure_trackBar.ValueChanged += new System.EventHandler(this.exposure_trackBar_ValueChanged);
            // 
            // exposure
            // 
            this.exposure.AutoSize = true;
            this.exposure.Location = new System.Drawing.Point(531, 275);
            this.exposure.Name = "exposure";
            this.exposure.Size = new System.Drawing.Size(53, 12);
            this.exposure.TabIndex = 6;
            this.exposure.Text = "曝光時間";
            // 
            // exposure_domainUpDown
            // 
            this.exposure_domainUpDown.Location = new System.Drawing.Point(531, 290);
            this.exposure_domainUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.exposure_domainUpDown.Name = "exposure_domainUpDown";
            this.exposure_domainUpDown.Size = new System.Drawing.Size(120, 22);
            this.exposure_domainUpDown.TabIndex = 7;
            this.exposure_domainUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // CameraWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 491);
            this.Controls.Add(this.exposure_domainUpDown);
            this.Controls.Add(this.exposure);
            this.Controls.Add(this.exposure_trackBar);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Camera_halcon_Capture);
            this.Controls.Add(this.CameraCaptrue);
            this.Controls.Add(this.Camera_halcon_Vedio);
            this.Name = "CameraWindow";
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraWindow_FormClosing);
            this.Load += new System.EventHandler(this.CameraWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exposure_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_domainUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl Camera_halcon_Vedio;
        private System.Windows.Forms.Button CameraCaptrue;
        private HalconDotNet.HWindowControl Camera_halcon_Capture;
        private System.Windows.Forms.Button OK;
        private System.ComponentModel.BackgroundWorker CamerabackgroundWorker;
        private System.Windows.Forms.TrackBar exposure_trackBar;
        private System.Windows.Forms.Label exposure;
        private System.Windows.Forms.NumericUpDown exposure_domainUpDown;
    }
}