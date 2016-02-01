namespace ST_LoadImage
{
    partial class ImageFromCamera
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
            this.exposure_domainUpDown = new System.Windows.Forms.NumericUpDown();
            this.exposure = new System.Windows.Forms.Label();
            this.exposure_trackBar = new System.Windows.Forms.TrackBar();
            this.OK = new System.Windows.Forms.Button();
            this.CameraCaptrue = new System.Windows.Forms.Button();
            this.Camera_capture = new HalconDotNet.HWindowControl();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_domainUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // exposure_domainUpDown
            // 
            this.exposure_domainUpDown.Location = new System.Drawing.Point(531, 291);
            this.exposure_domainUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.exposure_domainUpDown.Name = "exposure_domainUpDown";
            this.exposure_domainUpDown.Size = new System.Drawing.Size(120, 22);
            this.exposure_domainUpDown.TabIndex = 12;
            this.exposure_domainUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.exposure_domainUpDown.ValueChanged += new System.EventHandler(this.exposure_domainUpDown_ValueChanged);
            // 
            // exposure
            // 
            this.exposure.AutoSize = true;
            this.exposure.Location = new System.Drawing.Point(531, 276);
            this.exposure.Name = "exposure";
            this.exposure.Size = new System.Drawing.Size(53, 12);
            this.exposure.TabIndex = 11;
            this.exposure.Text = "曝光時間";
            // 
            // exposure_trackBar
            // 
            this.exposure_trackBar.Location = new System.Drawing.Point(531, 319);
            this.exposure_trackBar.Maximum = 255;
            this.exposure_trackBar.Name = "exposure_trackBar";
            this.exposure_trackBar.Size = new System.Drawing.Size(286, 45);
            this.exposure_trackBar.TabIndex = 10;
            this.exposure_trackBar.TickFrequency = 5;
            this.exposure_trackBar.ValueChanged += new System.EventHandler(this.exposure_trackBar_ValueChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(531, 428);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(286, 52);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // CameraCaptrue
            // 
            this.CameraCaptrue.Location = new System.Drawing.Point(531, 370);
            this.CameraCaptrue.Name = "CameraCaptrue";
            this.CameraCaptrue.Size = new System.Drawing.Size(286, 52);
            this.CameraCaptrue.TabIndex = 8;
            this.CameraCaptrue.Text = "擷圖";
            this.CameraCaptrue.UseVisualStyleBackColor = true;
            this.CameraCaptrue.Click += new System.EventHandler(this.CameraCaptrue_Click);
            // 
            // Camera_capture
            // 
            this.Camera_capture.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Camera_capture.BackColor = System.Drawing.Color.Black;
            this.Camera_capture.BorderColor = System.Drawing.Color.Black;
            this.Camera_capture.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Camera_capture.Location = new System.Drawing.Point(12, 12);
            this.Camera_capture.Name = "Camera_capture";
            this.Camera_capture.Size = new System.Drawing.Size(513, 467);
            this.Camera_capture.TabIndex = 13;
            this.Camera_capture.WindowSize = new System.Drawing.Size(513, 467);
            // 
            // ImageFromCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.Camera_capture);
            this.Controls.Add(this.exposure_domainUpDown);
            this.Controls.Add(this.exposure);
            this.Controls.Add(this.exposure_trackBar);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CameraCaptrue);
            this.Name = "ImageFromCamera";
            this.Text = "ImageFromCamera";
            this.Load += new System.EventHandler(this.ImageFromCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exposure_domainUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposure_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown exposure_domainUpDown;
        private System.Windows.Forms.Label exposure;
        private System.Windows.Forms.TrackBar exposure_trackBar;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button CameraCaptrue;
        private HalconDotNet.HWindowControl Camera_capture;
    }
}