namespace CameraProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageFromCamera));
            ST_Base.ImageBase imageBase2 = new ST_Base.ImageBase();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.最大Eage_label = new System.Windows.Forms.Label();
            this.Exposure = new System.Windows.Forms.NumericUpDown();
            this.Exposure_trackBar = new System.Windows.Forms.TrackBar();
            this.parameter = new System.Windows.Forms.GroupBox();
            this.CaptrueImageBotton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exposure_trackBar)).BeginInit();
            this.parameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Image = ((System.Drawing.Image)(resources.GetObject("OK.Image")));
            this.OK.Location = new System.Drawing.Point(12, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(46, 45);
            this.OK.TabIndex = 21;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolWindow);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 659);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "影像";
            // 
            // toolWindow
            // 
            this.toolWindow.Location = new System.Drawing.Point(6, 20);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.Size = new System.Drawing.Size(645, 616);
            this.toolWindow.TabIndex = 5;
            this.toolWindow.WindowImage = imageBase2;
            // 
            // 最大Eage_label
            // 
            this.最大Eage_label.AutoSize = true;
            this.最大Eage_label.Location = new System.Drawing.Point(10, 21);
            this.最大Eage_label.Name = "最大Eage_label";
            this.最大Eage_label.Size = new System.Drawing.Size(53, 12);
            this.最大Eage_label.TabIndex = 49;
            this.最大Eage_label.Text = "曝光時間";
            // 
            // Exposure
            // 
            this.Exposure.Location = new System.Drawing.Point(12, 44);
            this.Exposure.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Exposure.Name = "Exposure";
            this.Exposure.Size = new System.Drawing.Size(52, 22);
            this.Exposure.TabIndex = 46;
            this.Exposure.ValueChanged += new System.EventHandler(this.Exposure_ValueChanged);
            // 
            // Exposure_trackBar
            // 
            this.Exposure_trackBar.Location = new System.Drawing.Point(70, 21);
            this.Exposure_trackBar.Maximum = 255;
            this.Exposure_trackBar.Name = "Exposure_trackBar";
            this.Exposure_trackBar.Size = new System.Drawing.Size(183, 45);
            this.Exposure_trackBar.TabIndex = 43;
            this.Exposure_trackBar.TickFrequency = 5;
            this.Exposure_trackBar.ValueChanged += new System.EventHandler(this.Exposure_trackBar_ValueChanged);
            // 
            // parameter
            // 
            this.parameter.Controls.Add(this.最大Eage_label);
            this.parameter.Controls.Add(this.Exposure);
            this.parameter.Controls.Add(this.Exposure_trackBar);
            this.parameter.Location = new System.Drawing.Point(675, 114);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(267, 75);
            this.parameter.TabIndex = 62;
            this.parameter.TabStop = false;
            this.parameter.Text = "相機參數";
            // 
            // CaptrueImageBotton
            // 
            this.CaptrueImageBotton.Image = ((System.Drawing.Image)(resources.GetObject("CaptrueImageBotton.Image")));
            this.CaptrueImageBotton.Location = new System.Drawing.Point(675, 63);
            this.CaptrueImageBotton.Name = "CaptrueImageBotton";
            this.CaptrueImageBotton.Size = new System.Drawing.Size(46, 45);
            this.CaptrueImageBotton.TabIndex = 63;
            this.CaptrueImageBotton.UseVisualStyleBackColor = true;
            this.CaptrueImageBotton.Click += new System.EventHandler(this.CaptrueImageBotton_Click);
            // 
            // ImageFromCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 717);
            this.Controls.Add(this.CaptrueImageBotton);
            this.Controls.Add(this.parameter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OK);
            this.Name = "ImageFromCamera";
            this.Text = "ImageFromCamera";
            this.Activated += new System.EventHandler(this.ImageFromCamera_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageFromCamera_FormClosing);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exposure_trackBar)).EndInit();
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox2;
        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.Label 最大Eage_label;
        private System.Windows.Forms.NumericUpDown Exposure;
        private System.Windows.Forms.TrackBar Exposure_trackBar;
        private System.Windows.Forms.GroupBox parameter;
        private System.Windows.Forms.Button CaptrueImageBotton;
    }
}