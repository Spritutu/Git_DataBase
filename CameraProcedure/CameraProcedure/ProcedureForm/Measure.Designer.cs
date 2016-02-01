﻿namespace CameraProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measure));
            ST_Base.ImageBase imageBase6 = new ST_Base.ImageBase();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page_1DMeasure = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Eage_ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parameter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eage_num = new System.Windows.Forms.NumericUpDown();
            this.ROIWeight_label = new System.Windows.Forms.Label();
            this.Sigma_label = new System.Windows.Forms.Label();
            this.最大Eage_label = new System.Windows.Forms.Label();
            this.ROIWeight = new System.Windows.Forms.NumericUpDown();
            this.sigma = new System.Windows.Forms.NumericUpDown();
            this.MaxEdge = new System.Windows.Forms.NumericUpDown();
            this.ROIWeight_trackBar = new System.Windows.Forms.TrackBar();
            this.Sigma_trackBar = new System.Windows.Forms.TrackBar();
            this.MaxEage_trackBar = new System.Windows.Forms.TrackBar();
            this.EageWindow = new HalconDotNet.HWindowControl();
            this.Page_result = new System.Windows.Forms.TabPage();
            this.DrawROI_button = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.tabControl1.SuspendLayout();
            this.Page_1DMeasure.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eage_num)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(590, 675);
            this.tabControl1.TabIndex = 1;
            // 
            // Page_1DMeasure
            // 
            this.Page_1DMeasure.Controls.Add(this.groupBox1);
            this.Page_1DMeasure.Controls.Add(this.parameter);
            this.Page_1DMeasure.Location = new System.Drawing.Point(4, 22);
            this.Page_1DMeasure.Name = "Page_1DMeasure";
            this.Page_1DMeasure.Padding = new System.Windows.Forms.Padding(3);
            this.Page_1DMeasure.Size = new System.Drawing.Size(582, 649);
            this.Page_1DMeasure.TabIndex = 0;
            this.Page_1DMeasure.Text = "1維測量";
            this.Page_1DMeasure.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Eage_);
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
            // Eage_
            // 
            this.Eage_.FormattingEnabled = true;
            this.Eage_.Location = new System.Drawing.Point(207, 21);
            this.Eage_.Name = "Eage_";
            this.Eage_.Size = new System.Drawing.Size(121, 20);
            this.Eage_.TabIndex = 55;
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
            this.parameter.Controls.Add(this.Eage_num);
            this.parameter.Controls.Add(this.ROIWeight_label);
            this.parameter.Controls.Add(this.Sigma_label);
            this.parameter.Controls.Add(this.最大Eage_label);
            this.parameter.Controls.Add(this.ROIWeight);
            this.parameter.Controls.Add(this.sigma);
            this.parameter.Controls.Add(this.MaxEdge);
            this.parameter.Controls.Add(this.ROIWeight_trackBar);
            this.parameter.Controls.Add(this.Sigma_trackBar);
            this.parameter.Controls.Add(this.MaxEage_trackBar);
            this.parameter.Controls.Add(this.EageWindow);
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
            // Eage_num
            // 
            this.Eage_num.Location = new System.Drawing.Point(65, 34);
            this.Eage_num.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Eage_num.Name = "Eage_num";
            this.Eage_num.Size = new System.Drawing.Size(52, 22);
            this.Eage_num.TabIndex = 52;
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
            this.ROIWeight.Location = new System.Drawing.Point(232, 204);
            this.ROIWeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ROIWeight.Name = "ROIWeight";
            this.ROIWeight.Size = new System.Drawing.Size(52, 22);
            this.ROIWeight.TabIndex = 48;
            this.ROIWeight.ValueChanged += new System.EventHandler(this.ROIWeight_ValueChanged);
            // 
            // sigma
            // 
            this.sigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sigma.Location = new System.Drawing.Point(232, 141);
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
            this.sigma.ValueChanged += new System.EventHandler(this.sigma_ValueChanged);
            // 
            // MaxEdge
            // 
            this.MaxEdge.Location = new System.Drawing.Point(232, 85);
            this.MaxEdge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MaxEdge.Name = "MaxEdge";
            this.MaxEdge.Size = new System.Drawing.Size(52, 22);
            this.MaxEdge.TabIndex = 46;
            this.MaxEdge.ValueChanged += new System.EventHandler(this.MaxEdge_ValueChanged);
            // 
            // ROIWeight_trackBar
            // 
            this.ROIWeight_trackBar.Location = new System.Drawing.Point(290, 181);
            this.ROIWeight_trackBar.Maximum = 255;
            this.ROIWeight_trackBar.Name = "ROIWeight_trackBar";
            this.ROIWeight_trackBar.Size = new System.Drawing.Size(260, 45);
            this.ROIWeight_trackBar.TabIndex = 45;
            this.ROIWeight_trackBar.TickFrequency = 5;
            this.ROIWeight_trackBar.ValueChanged += new System.EventHandler(this.ROIWeight_trackBar_ValueChanged);
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
            this.Sigma_trackBar.ValueChanged += new System.EventHandler(this.Sigma_trackBar_ValueChanged);
            // 
            // MaxEage_trackBar
            // 
            this.MaxEage_trackBar.Location = new System.Drawing.Point(290, 62);
            this.MaxEage_trackBar.Maximum = 255;
            this.MaxEage_trackBar.Name = "MaxEage_trackBar";
            this.MaxEage_trackBar.Size = new System.Drawing.Size(260, 45);
            this.MaxEage_trackBar.TabIndex = 43;
            this.MaxEage_trackBar.TickFrequency = 5;
            this.MaxEage_trackBar.ValueChanged += new System.EventHandler(this.MaxEage_trackBar_ValueChanged);
            // 
            // EageWindow
            // 
            this.EageWindow.BackColor = System.Drawing.Color.Black;
            this.EageWindow.BorderColor = System.Drawing.Color.Black;
            this.EageWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.EageWindow.Location = new System.Drawing.Point(8, 62);
            this.EageWindow.Name = "EageWindow";
            this.EageWindow.Size = new System.Drawing.Size(218, 164);
            this.EageWindow.TabIndex = 0;
            this.EageWindow.WindowSize = new System.Drawing.Size(218, 164);
            // 
            // Page_result
            // 
            this.Page_result.Location = new System.Drawing.Point(4, 22);
            this.Page_result.Name = "Page_result";
            this.Page_result.Padding = new System.Windows.Forms.Padding(3);
            this.Page_result.Size = new System.Drawing.Size(582, 649);
            this.Page_result.TabIndex = 1;
            this.Page_result.Text = "測量結果";
            this.Page_result.UseVisualStyleBackColor = true;
            // 
            // DrawROI_button
            // 
            this.DrawROI_button.Image = ((System.Drawing.Image)(resources.GetObject("DrawROI_button.Image")));
            this.DrawROI_button.Location = new System.Drawing.Point(12, 11);
            this.DrawROI_button.Name = "DrawROI_button";
            this.DrawROI_button.Size = new System.Drawing.Size(46, 45);
            this.DrawROI_button.TabIndex = 3;
            this.DrawROI_button.UseVisualStyleBackColor = true;
            this.DrawROI_button.Click += new System.EventHandler(this.DrawROI_button_Click);
            // 
            // OK
            // 
            this.OK.Image = ((System.Drawing.Image)(resources.GetObject("OK.Image")));
            this.OK.Location = new System.Drawing.Point(64, 11);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(46, 45);
            this.OK.TabIndex = 4;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // toolWindow
            // 
            this.toolWindow.Location = new System.Drawing.Point(12, 62);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.Size = new System.Drawing.Size(715, 625);
            this.toolWindow.TabIndex = 2;
            this.toolWindow.WindowImage = imageBase6;
            // 
            // Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 696);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.DrawROI_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolWindow);
            this.Name = "Measure";
            this.Text = "Measure";
            this.Activated += new System.EventHandler(this.Measure_Activated);
            this.tabControl1.ResumeLayout(false);
            this.Page_1DMeasure.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eage_num)).EndInit();
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
        private System.Windows.Forms.ComboBox Eage_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox parameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Eage_num;
        private System.Windows.Forms.Label ROIWeight_label;
        private System.Windows.Forms.Label Sigma_label;
        private System.Windows.Forms.Label 最大Eage_label;
        private System.Windows.Forms.NumericUpDown ROIWeight;
        private System.Windows.Forms.NumericUpDown sigma;
        private System.Windows.Forms.NumericUpDown MaxEdge;
        private System.Windows.Forms.TrackBar ROIWeight_trackBar;
        private System.Windows.Forms.TrackBar Sigma_trackBar;
        private System.Windows.Forms.TrackBar MaxEage_trackBar;
        private HalconDotNet.HWindowControl EageWindow;
        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.TabPage Page_result;
        private System.Windows.Forms.TabPage Page_1DMeasure;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button DrawROI_button;
        private System.Windows.Forms.Button OK;
    }
}