namespace MainProject2._0
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.infoButton = new System.Windows.Forms.Button();
            this.srtButton = new System.Windows.Forms.Button();
            this.procedureButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Camerawindow2 = new System.Windows.Forms.TabControl();
            this.Camera_1 = new System.Windows.Forms.TabPage();
            this.Camerawindow1 = new HalconDotNet.HWindowControl();
            this.Camera_2 = new System.Windows.Forms.TabPage();
            this.hWindowControl3 = new HalconDotNet.HWindowControl();
            this.Camera_3 = new System.Windows.Forms.TabPage();
            this.Camerawindow3 = new HalconDotNet.HWindowControl();
            this.Camera_4 = new System.Windows.Forms.TabPage();
            this.Camerawindow4 = new HalconDotNet.HWindowControl();
            this.MainstatusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainmenuStrip.SuspendLayout();
            this.Camerawindow2.SuspendLayout();
            this.Camera_1.SuspendLayout();
            this.Camera_2.SuspendLayout();
            this.Camera_3.SuspendLayout();
            this.Camera_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoButton
            // 
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.Location = new System.Drawing.Point(277, 27);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(60, 60);
            this.infoButton.TabIndex = 15;
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // srtButton
            // 
            this.srtButton.Image = ((System.Drawing.Image)(resources.GetObject("srtButton.Image")));
            this.srtButton.Location = new System.Drawing.Point(211, 27);
            this.srtButton.Name = "srtButton";
            this.srtButton.Size = new System.Drawing.Size(60, 60);
            this.srtButton.TabIndex = 14;
            this.srtButton.UseVisualStyleBackColor = true;
            // 
            // procedureButton
            // 
            this.procedureButton.Image = ((System.Drawing.Image)(resources.GetObject("procedureButton.Image")));
            this.procedureButton.Location = new System.Drawing.Point(145, 27);
            this.procedureButton.Name = "procedureButton";
            this.procedureButton.Size = new System.Drawing.Size(60, 60);
            this.procedureButton.TabIndex = 13;
            this.procedureButton.UseVisualStyleBackColor = true;
            this.procedureButton.Click += new System.EventHandler(this.procedureButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(79, 27);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 60);
            this.stopButton.TabIndex = 12;
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(12, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 60);
            this.startButton.TabIndex = 9;
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // MainmenuStrip
            // 
            this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.MainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainmenuStrip.Name = "MainmenuStrip";
            this.MainmenuStrip.Size = new System.Drawing.Size(1081, 24);
            this.MainmenuStrip.TabIndex = 10;
            this.MainmenuStrip.Text = "MainmenuStrip";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // Camerawindow2
            // 
            this.Camerawindow2.Controls.Add(this.Camera_1);
            this.Camerawindow2.Controls.Add(this.Camera_2);
            this.Camerawindow2.Controls.Add(this.Camera_3);
            this.Camerawindow2.Controls.Add(this.Camera_4);
            this.Camerawindow2.Location = new System.Drawing.Point(12, 93);
            this.Camerawindow2.Name = "Camerawindow2";
            this.Camerawindow2.SelectedIndex = 0;
            this.Camerawindow2.Size = new System.Drawing.Size(1061, 607);
            this.Camerawindow2.TabIndex = 16;
            // 
            // Camera_1
            // 
            this.Camera_1.Controls.Add(this.splitContainer1);
            this.Camera_1.Controls.Add(this.Camerawindow1);
            this.Camera_1.Location = new System.Drawing.Point(4, 22);
            this.Camera_1.Name = "Camera_1";
            this.Camera_1.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_1.Size = new System.Drawing.Size(1053, 581);
            this.Camera_1.TabIndex = 1;
            this.Camera_1.Text = "Camera No.1";
            this.Camera_1.UseVisualStyleBackColor = true;
            // 
            // Camerawindow1
            // 
            this.Camerawindow1.BackColor = System.Drawing.Color.Black;
            this.Camerawindow1.BorderColor = System.Drawing.Color.Black;
            this.Camerawindow1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Camerawindow1.Location = new System.Drawing.Point(6, 6);
            this.Camerawindow1.Name = "Camerawindow1";
            this.Camerawindow1.Size = new System.Drawing.Size(647, 569);
            this.Camerawindow1.TabIndex = 1;
            this.Camerawindow1.WindowSize = new System.Drawing.Size(647, 569);
            // 
            // Camera_2
            // 
            this.Camera_2.Controls.Add(this.hWindowControl3);
            this.Camera_2.Location = new System.Drawing.Point(4, 22);
            this.Camera_2.Name = "Camera_2";
            this.Camera_2.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_2.Size = new System.Drawing.Size(1053, 581);
            this.Camera_2.TabIndex = 2;
            this.Camera_2.Text = "Camera No.2";
            this.Camera_2.UseVisualStyleBackColor = true;
            // 
            // hWindowControl3
            // 
            this.hWindowControl3.BackColor = System.Drawing.Color.Black;
            this.hWindowControl3.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl3.Location = new System.Drawing.Point(6, 3);
            this.hWindowControl3.Name = "hWindowControl3";
            this.hWindowControl3.Size = new System.Drawing.Size(647, 569);
            this.hWindowControl3.TabIndex = 1;
            this.hWindowControl3.WindowSize = new System.Drawing.Size(647, 569);
            // 
            // Camera_3
            // 
            this.Camera_3.Controls.Add(this.Camerawindow3);
            this.Camera_3.Location = new System.Drawing.Point(4, 22);
            this.Camera_3.Name = "Camera_3";
            this.Camera_3.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_3.Size = new System.Drawing.Size(1053, 581);
            this.Camera_3.TabIndex = 3;
            this.Camera_3.Text = "Camera No.3";
            this.Camera_3.UseVisualStyleBackColor = true;
            // 
            // Camerawindow3
            // 
            this.Camerawindow3.BackColor = System.Drawing.Color.Black;
            this.Camerawindow3.BorderColor = System.Drawing.Color.Black;
            this.Camerawindow3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Camerawindow3.Location = new System.Drawing.Point(6, 3);
            this.Camerawindow3.Name = "Camerawindow3";
            this.Camerawindow3.Size = new System.Drawing.Size(647, 569);
            this.Camerawindow3.TabIndex = 1;
            this.Camerawindow3.WindowSize = new System.Drawing.Size(647, 569);
            // 
            // Camera_4
            // 
            this.Camera_4.Controls.Add(this.Camerawindow4);
            this.Camera_4.Location = new System.Drawing.Point(4, 22);
            this.Camera_4.Name = "Camera_4";
            this.Camera_4.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_4.Size = new System.Drawing.Size(1053, 581);
            this.Camera_4.TabIndex = 4;
            this.Camera_4.Text = "Camera No.4";
            this.Camera_4.UseVisualStyleBackColor = true;
            // 
            // Camerawindow4
            // 
            this.Camerawindow4.BackColor = System.Drawing.Color.Black;
            this.Camerawindow4.BorderColor = System.Drawing.Color.Black;
            this.Camerawindow4.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Camerawindow4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Camerawindow4.Location = new System.Drawing.Point(6, 6);
            this.Camerawindow4.Name = "Camerawindow4";
            this.Camerawindow4.Size = new System.Drawing.Size(647, 569);
            this.Camerawindow4.TabIndex = 0;
            this.Camerawindow4.WindowSize = new System.Drawing.Size(647, 569);
            // 
            // MainstatusStrip
            // 
            this.MainstatusStrip.Location = new System.Drawing.Point(0, 708);
            this.MainstatusStrip.Name = "MainstatusStrip";
            this.MainstatusStrip.Size = new System.Drawing.Size(1081, 22);
            this.MainstatusStrip.TabIndex = 11;
            this.MainstatusStrip.Text = "MainstatusStrip";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(514, 163);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 730);
            this.Controls.Add(this.Camerawindow2);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.srtButton);
            this.Controls.Add(this.procedureButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.MainstatusStrip);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.MainmenuStrip);
            this.Name = "MainForm";
            this.Text = "Main";
            this.MainmenuStrip.ResumeLayout(false);
            this.MainmenuStrip.PerformLayout();
            this.Camerawindow2.ResumeLayout(false);
            this.Camera_1.ResumeLayout(false);
            this.Camera_2.ResumeLayout(false);
            this.Camera_3.ResumeLayout(false);
            this.Camera_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button srtButton;
        private System.Windows.Forms.Button procedureButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip MainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.TabControl Camerawindow2;
        private System.Windows.Forms.TabPage Camera_1;
        private System.Windows.Forms.TabPage Camera_2;
        private System.Windows.Forms.TabPage Camera_3;
        private System.Windows.Forms.TabPage Camera_4;
        private System.Windows.Forms.StatusStrip MainstatusStrip;
        private HalconDotNet.HWindowControl Camerawindow1;
        private HalconDotNet.HWindowControl hWindowControl3;
        private HalconDotNet.HWindowControl Camerawindow3;
        private HalconDotNet.HWindowControl Camerawindow4;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

