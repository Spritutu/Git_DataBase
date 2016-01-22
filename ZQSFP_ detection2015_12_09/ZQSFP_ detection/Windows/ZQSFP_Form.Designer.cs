namespace ZQSFP_detection
{
    partial class ZQSFP_Form
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
            this.MainWindow = new HalconDotNet.HWindowControl();
            this.Load_Image = new System.Windows.Forms.Button();
            this.creatmodel = new System.Windows.Forms.Button();
            this.measure = new System.Windows.Forms.Button();
            this.starwork = new System.Windows.Forms.Button();
            this.measure_2D = new System.Windows.Forms.Button();
            this.SecondWindow = new HalconDotNet.HWindowControl();
            this.EnhanceImage = new System.Windows.Forms.Button();
            this.Regiongrowing = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MouseX = new System.Windows.Forms.ToolStripStatusLabel();
            this.MouseY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pixel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.MainWindow.BackColor = System.Drawing.Color.Black;
            this.MainWindow.BorderColor = System.Drawing.Color.Black;
            this.MainWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.MainWindow.Location = new System.Drawing.Point(12, 43);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(640, 480);
            this.MainWindow.TabIndex = 0;
            this.MainWindow.WindowSize = new System.Drawing.Size(640, 480);
            this.MainWindow.HMouseMove += new HalconDotNet.HMouseEventHandler(this.MainWindow_HMouseMove);
            // 
            // Load_Image
            // 
            this.Load_Image.Location = new System.Drawing.Point(12, 12);
            this.Load_Image.Name = "Load_Image";
            this.Load_Image.Size = new System.Drawing.Size(75, 23);
            this.Load_Image.TabIndex = 1;
            this.Load_Image.Text = "載入圖片";
            this.Load_Image.UseVisualStyleBackColor = true;
            this.Load_Image.Click += new System.EventHandler(this.Load_Image_Click);
            // 
            // creatmodel
            // 
            this.creatmodel.Location = new System.Drawing.Point(93, 12);
            this.creatmodel.Name = "creatmodel";
            this.creatmodel.Size = new System.Drawing.Size(95, 23);
            this.creatmodel.TabIndex = 2;
            this.creatmodel.Text = "建立匹配模型";
            this.creatmodel.UseVisualStyleBackColor = true;
            this.creatmodel.Click += new System.EventHandler(this.creatmodel_Click);
            // 
            // measure
            // 
            this.measure.Location = new System.Drawing.Point(194, 12);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(75, 23);
            this.measure.TabIndex = 3;
            this.measure.Text = "測量";
            this.measure.UseVisualStyleBackColor = true;
            this.measure.Click += new System.EventHandler(this.measure_Click);
            // 
            // starwork
            // 
            this.starwork.Location = new System.Drawing.Point(275, 12);
            this.starwork.Name = "starwork";
            this.starwork.Size = new System.Drawing.Size(75, 23);
            this.starwork.TabIndex = 4;
            this.starwork.Text = "開始檢測";
            this.starwork.UseVisualStyleBackColor = true;
            this.starwork.Click += new System.EventHandler(this.starwork_Click);
            // 
            // measure_2D
            // 
            this.measure_2D.Location = new System.Drawing.Point(356, 12);
            this.measure_2D.Name = "measure_2D";
            this.measure_2D.Size = new System.Drawing.Size(75, 23);
            this.measure_2D.TabIndex = 5;
            this.measure_2D.Text = "二維量測";
            this.measure_2D.UseVisualStyleBackColor = true;
            this.measure_2D.Click += new System.EventHandler(this.measure_2D_Click);
            // 
            // SecondWindow
            // 
            this.SecondWindow.BackColor = System.Drawing.Color.Black;
            this.SecondWindow.BorderColor = System.Drawing.Color.Black;
            this.SecondWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.SecondWindow.Location = new System.Drawing.Point(659, 43);
            this.SecondWindow.Name = "SecondWindow";
            this.SecondWindow.Size = new System.Drawing.Size(640, 480);
            this.SecondWindow.TabIndex = 6;
            this.SecondWindow.WindowSize = new System.Drawing.Size(640, 480);
            // 
            // EnhanceImage
            // 
            this.EnhanceImage.Location = new System.Drawing.Point(659, 12);
            this.EnhanceImage.Name = "EnhanceImage";
            this.EnhanceImage.Size = new System.Drawing.Size(75, 23);
            this.EnhanceImage.TabIndex = 7;
            this.EnhanceImage.Text = "EnhanceImage";
            this.EnhanceImage.UseVisualStyleBackColor = true;
            this.EnhanceImage.Click += new System.EventHandler(this.EnhanceImage_Click);
            // 
            // Regiongrowing
            // 
            this.Regiongrowing.Location = new System.Drawing.Point(437, 12);
            this.Regiongrowing.Name = "Regiongrowing";
            this.Regiongrowing.Size = new System.Drawing.Size(75, 23);
            this.Regiongrowing.TabIndex = 8;
            this.Regiongrowing.Text = "分區塊";
            this.Regiongrowing.UseVisualStyleBackColor = true;
            this.Regiongrowing.Click += new System.EventHandler(this.Regiongrowing_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MouseX,
            this.MouseY,
            this.pixel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1312, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MouseX
            // 
            this.MouseX.Name = "MouseX";
            this.MouseX.Size = new System.Drawing.Size(28, 17);
            this.MouseX.Text = "null";
            // 
            // MouseY
            // 
            this.MouseY.Name = "MouseY";
            this.MouseY.Size = new System.Drawing.Size(28, 17);
            this.MouseY.Text = "null";
            // 
            // pixel
            // 
            this.pixel.Name = "pixel";
            this.pixel.Size = new System.Drawing.Size(28, 17);
            this.pixel.Text = "null";
            // 
            // ZQSFP_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1312, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Regiongrowing);
            this.Controls.Add(this.EnhanceImage);
            this.Controls.Add(this.SecondWindow);
            this.Controls.Add(this.measure_2D);
            this.Controls.Add(this.starwork);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.creatmodel);
            this.Controls.Add(this.Load_Image);
            this.Controls.Add(this.MainWindow);
            this.Name = "ZQSFP_Form";
            this.Text = "ZQSFP_ detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZQSFP_Form_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl MainWindow;
        private System.Windows.Forms.Button Load_Image;
        private System.Windows.Forms.Button creatmodel;
        private System.Windows.Forms.Button measure;
        private System.Windows.Forms.Button starwork;
        private System.Windows.Forms.Button measure_2D;
        private HalconDotNet.HWindowControl SecondWindow;
        private System.Windows.Forms.Button EnhanceImage;
        private System.Windows.Forms.Button Regiongrowing;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MouseX;
        private System.Windows.Forms.ToolStripStatusLabel MouseY;
        private System.Windows.Forms.ToolStripStatusLabel pixel;
    }
}

