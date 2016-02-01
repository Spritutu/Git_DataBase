namespace WindowsFormsApplication1
{
    partial class Form1
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
            ST_Base.ImageBase imageBase1 = new ST_Base.ImageBase();
            ST_Base.RegionBase regionBase1 = new ST_Base.RegionBase();
            this.sT_LoadImage = new ST_LoadImage.ST_LoadImage();
            this.sT_Window = new ST_Window.ST_Window();
            this.circle_button = new System.Windows.Forms.Button();
            this.fit_button = new System.Windows.Forms.Button();
            this.Match_button = new System.Windows.Forms.Button();
            this.Measure_button = new System.Windows.Forms.Button();
            this.MatchingNMeasure_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sT_LoadImage
            // 
            this.sT_LoadImage.Location = new System.Drawing.Point(12, 12);
            this.sT_LoadImage.Name = "sT_LoadImage";
            this.sT_LoadImage.Size = new System.Drawing.Size(75, 29);
            this.sT_LoadImage.TabIndex = 0;
            this.sT_LoadImage.Click += new System.EventHandler(this.sT_LoadImage_Click);
            // 
            // sT_Window
            // 
            this.sT_Window.Location = new System.Drawing.Point(12, 47);
            this.sT_Window.Name = "sT_Window";
            this.sT_Window.Size = new System.Drawing.Size(735, 649);
            this.sT_Window.TabIndex = 1;
            this.sT_Window.Window_Image = imageBase1;
            this.sT_Window.Window_Region = regionBase1;
            // 
            // circle_button
            // 
            this.circle_button.Location = new System.Drawing.Point(93, 12);
            this.circle_button.Name = "circle_button";
            this.circle_button.Size = new System.Drawing.Size(75, 29);
            this.circle_button.TabIndex = 2;
            this.circle_button.Text = "rec";
            this.circle_button.UseVisualStyleBackColor = true;
            this.circle_button.Click += new System.EventHandler(this.circle_button_Click);
            // 
            // fit_button
            // 
            this.fit_button.Location = new System.Drawing.Point(174, 12);
            this.fit_button.Name = "fit_button";
            this.fit_button.Size = new System.Drawing.Size(75, 29);
            this.fit_button.TabIndex = 3;
            this.fit_button.Text = "fit";
            this.fit_button.UseVisualStyleBackColor = true;
            this.fit_button.Click += new System.EventHandler(this.fit_button_Click);
            // 
            // Match_button
            // 
            this.Match_button.Location = new System.Drawing.Point(255, 12);
            this.Match_button.Name = "Match_button";
            this.Match_button.Size = new System.Drawing.Size(75, 29);
            this.Match_button.TabIndex = 4;
            this.Match_button.Text = "Match";
            this.Match_button.UseVisualStyleBackColor = true;
            this.Match_button.Click += new System.EventHandler(this.Match_button_Click);
            // 
            // Measure_button
            // 
            this.Measure_button.Location = new System.Drawing.Point(336, 12);
            this.Measure_button.Name = "Measure_button";
            this.Measure_button.Size = new System.Drawing.Size(75, 29);
            this.Measure_button.TabIndex = 5;
            this.Measure_button.Text = "Measure";
            this.Measure_button.UseVisualStyleBackColor = true;
            this.Measure_button.Click += new System.EventHandler(this.Measure_button_Click);
            // 
            // MatchingNMeasure_button
            // 
            this.MatchingNMeasure_button.Location = new System.Drawing.Point(417, 12);
            this.MatchingNMeasure_button.Name = "MatchingNMeasure_button";
            this.MatchingNMeasure_button.Size = new System.Drawing.Size(106, 29);
            this.MatchingNMeasure_button.TabIndex = 6;
            this.MatchingNMeasure_button.Text = "Matching&Measure";
            this.MatchingNMeasure_button.UseVisualStyleBackColor = true;
            this.MatchingNMeasure_button.Click += new System.EventHandler(this.MatchingNMeasure_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 708);
            this.Controls.Add(this.MatchingNMeasure_button);
            this.Controls.Add(this.Measure_button);
            this.Controls.Add(this.Match_button);
            this.Controls.Add(this.fit_button);
            this.Controls.Add(this.circle_button);
            this.Controls.Add(this.sT_Window);
            this.Controls.Add(this.sT_LoadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ST_LoadImage.ST_LoadImage sT_LoadImage;
        private ST_Window.ST_Window sT_Window;
        private System.Windows.Forms.Button circle_button;
        private System.Windows.Forms.Button fit_button;
        private System.Windows.Forms.Button Match_button;
        private System.Windows.Forms.Button Measure_button;
        private System.Windows.Forms.Button MatchingNMeasure_button;
    }
}

