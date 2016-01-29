namespace CameraProcedure
{
    partial class Measure
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
            ST_Base.ImageBase imageBase2 = new ST_Base.ImageBase();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page_1DMeasure = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parameter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ROIWeight_label = new System.Windows.Forms.Label();
            this.Sigma_label = new System.Windows.Forms.Label();
            this.最大Eage_label = new System.Windows.Forms.Label();
            this.ROIWeight = new System.Windows.Forms.NumericUpDown();
            this.sigma = new System.Windows.Forms.NumericUpDown();
            this.MaxEdge = new System.Windows.Forms.NumericUpDown();
            this.ROIWeight_trackBar = new System.Windows.Forms.TrackBar();
            this.Sigma_trackBar = new System.Windows.Forms.TrackBar();
            this.MaxEage_trackBar = new System.Windows.Forms.TrackBar();
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.Page_result = new System.Windows.Forms.TabPage();
            this.toolWindow1 = new ToolWindow.ToolWindow();
            this.tabControl1.SuspendLayout();
            this.Page_1DMeasure.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEage_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page_1DMeasure);
            this.tabControl1.Controls.Add(this.Page_result);
            this.tabControl1.Location = new System.Drawing.Point(733, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 762);
            this.tabControl1.TabIndex = 1;
            // 
            // Page_1DMeasure
            // 
            this.Page_1DMeasure.Controls.Add(this.groupBox1);
            this.Page_1DMeasure.Controls.Add(this.parameter);
            this.Page_1DMeasure.Location = new System.Drawing.Point(4, 22);
            this.Page_1DMeasure.Name = "Page_1DMeasure";
            this.Page_1DMeasure.Padding = new System.Windows.Forms.Padding(3);
            this.Page_1DMeasure.Size = new System.Drawing.Size(582, 736);
            this.Page_1DMeasure.TabIndex = 0;
            this.Page_1DMeasure.Text = "1維測量";
            this.Page_1DMeasure.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邊緣選擇";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(207, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "Transition";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "位置";
            // 
            // parameter
            // 
            this.parameter.Controls.Add(this.label1);
            this.parameter.Controls.Add(this.numericUpDown1);
            this.parameter.Controls.Add(this.ROIWeight_label);
            this.parameter.Controls.Add(this.Sigma_label);
            this.parameter.Controls.Add(this.最大Eage_label);
            this.parameter.Controls.Add(this.ROIWeight);
            this.parameter.Controls.Add(this.sigma);
            this.parameter.Controls.Add(this.MaxEdge);
            this.parameter.Controls.Add(this.ROIWeight_trackBar);
            this.parameter.Controls.Add(this.Sigma_trackBar);
            this.parameter.Controls.Add(this.MaxEage_trackBar);
            this.parameter.Controls.Add(this.hWindowControl1);
            this.parameter.Location = new System.Drawing.Point(6, 6);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(556, 244);
            this.parameter.TabIndex = 1;
            this.parameter.TabStop = false;
            this.parameter.Text = "邊緣量測參數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "邊緣序號";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 34);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown1.TabIndex = 52;
            // 
            // ROIWeight_label
            // 
            this.ROIWeight_label.AutoSize = true;
            this.ROIWeight_label.Location = new System.Drawing.Point(230, 181);
            this.ROIWeight_label.Name = "ROIWeight_label";
            this.ROIWeight_label.Size = new System.Drawing.Size(59, 12);
            this.ROIWeight_label.TabIndex = 51;
            this.ROIWeight_label.Text = "ROIWeight";
            // 
            // Sigma_label
            // 
            this.Sigma_label.AutoSize = true;
            this.Sigma_label.Location = new System.Drawing.Point(230, 118);
            this.Sigma_label.Name = "Sigma_label";
            this.Sigma_label.Size = new System.Drawing.Size(34, 12);
            this.Sigma_label.TabIndex = 50;
            this.Sigma_label.Text = "Sigma";
            // 
            // 最大Eage_label
            // 
            this.最大Eage_label.AutoSize = true;
            this.最大Eage_label.Location = new System.Drawing.Point(230, 62);
            this.最大Eage_label.Name = "最大Eage_label";
            this.最大Eage_label.Size = new System.Drawing.Size(52, 12);
            this.最大Eage_label.TabIndex = 49;
            this.最大Eage_label.Text = "最大Eage";
            // 
            // ROIWeight
            // 
            this.ROIWeight.Location = new System.Drawing.Point(232, 196);
            this.ROIWeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ROIWeight.Name = "ROIWeight";
            this.ROIWeight.Size = new System.Drawing.Size(52, 22);
            this.ROIWeight.TabIndex = 48;
            // 
            // sigma
            // 
            this.sigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sigma.Location = new System.Drawing.Point(232, 133);
            this.sigma.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.sigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sigma.Name = "sigma";
            this.sigma.Size = new System.Drawing.Size(52, 22);
            this.sigma.TabIndex = 47;
            this.sigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxEdge
            // 
            this.MaxEdge.Location = new System.Drawing.Point(232, 77);
            this.MaxEdge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MaxEdge.Name = "MaxEdge";
            this.MaxEdge.Size = new System.Drawing.Size(52, 22);
            this.MaxEdge.TabIndex = 46;
            // 
            // ROIWeight_trackBar
            // 
            this.ROIWeight_trackBar.Location = new System.Drawing.Point(290, 181);
            this.ROIWeight_trackBar.Maximum = 255;
            this.ROIWeight_trackBar.Name = "ROIWeight_trackBar";
            this.ROIWeight_trackBar.Size = new System.Drawing.Size(260, 45);
            this.ROIWeight_trackBar.TabIndex = 45;
            this.ROIWeight_trackBar.TickFrequency = 5;
            // 
            // Sigma_trackBar
            // 
            this.Sigma_trackBar.Location = new System.Drawing.Point(290, 118);
            this.Sigma_trackBar.Maximum = 32;
            this.Sigma_trackBar.Minimum = 1;
            this.Sigma_trackBar.Name = "Sigma_trackBar";
            this.Sigma_trackBar.Size = new System.Drawing.Size(260, 45);
            this.Sigma_trackBar.TabIndex = 44;
            this.Sigma_trackBar.Value = 1;
            // 
            // MaxEage_trackBar
            // 
            this.MaxEage_trackBar.Location = new System.Drawing.Point(290, 62);
            this.MaxEage_trackBar.Maximum = 255;
            this.MaxEage_trackBar.Name = "MaxEage_trackBar";
            this.MaxEage_trackBar.Size = new System.Drawing.Size(260, 45);
            this.MaxEage_trackBar.TabIndex = 43;
            this.MaxEage_trackBar.TickFrequency = 5;
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(8, 62);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(218, 164);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(218, 164);
            // 
            // Page_result
            // 
            this.Page_result.Location = new System.Drawing.Point(4, 22);
            this.Page_result.Name = "Page_result";
            this.Page_result.Padding = new System.Windows.Forms.Padding(3);
            this.Page_result.Size = new System.Drawing.Size(582, 736);
            this.Page_result.TabIndex = 1;
            this.Page_result.Text = "測量結果";
            this.Page_result.UseVisualStyleBackColor = true;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(12, 12);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(715, 762);
            this.toolWindow1.TabIndex = 2;
            this.toolWindow1.WindowImage = imageBase2;
            // 
            // Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 783);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolWindow1);
            this.Name = "Measure";
            this.Text = "Measure";
            this.Activated += new System.EventHandler(this.Measure_Activated);
            this.tabControl1.ResumeLayout(false);
            this.Page_1DMeasure.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEage_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox parameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ROIWeight_label;
        private System.Windows.Forms.Label Sigma_label;
        private System.Windows.Forms.Label 最大Eage_label;
        private System.Windows.Forms.NumericUpDown ROIWeight;
        private System.Windows.Forms.NumericUpDown sigma;
        private System.Windows.Forms.NumericUpDown MaxEdge;
        private System.Windows.Forms.TrackBar ROIWeight_trackBar;
        private System.Windows.Forms.TrackBar Sigma_trackBar;
        private System.Windows.Forms.TrackBar MaxEage_trackBar;
        private HalconDotNet.HWindowControl hWindowControl1;
        private ToolWindow.ToolWindow toolWindow1;
        private System.Windows.Forms.TabPage Page_result;
        private System.Windows.Forms.TabPage Page_1DMeasure;
        private System.Windows.Forms.TabControl tabControl1;
    }
}