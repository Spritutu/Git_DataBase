﻿namespace ZQSFP_detection
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
            this.measure_window = new HalconDotNet.HWindowControl();
            this.drawline = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.ROIWeight_label = new System.Windows.Forms.Label();
            this.Sigma_label = new System.Windows.Forms.Label();
            this.最大Eage_label = new System.Windows.Forms.Label();
            this.ROIWeight = new System.Windows.Forms.NumericUpDown();
            this.sigma = new System.Windows.Forms.NumericUpDown();
            this.MaxEdge = new System.Windows.Forms.NumericUpDown();
            this.ROIWeight_trackBar = new System.Windows.Forms.TrackBar();
            this.Sigma_trackBar = new System.Windows.Forms.TrackBar();
            this.MaxEage_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEage_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // measure_window
            // 
            this.measure_window.BackColor = System.Drawing.Color.Black;
            this.measure_window.BorderColor = System.Drawing.Color.Black;
            this.measure_window.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.measure_window.Location = new System.Drawing.Point(12, 45);
            this.measure_window.Name = "measure_window";
            this.measure_window.Size = new System.Drawing.Size(725, 607);
            this.measure_window.TabIndex = 0;
            this.measure_window.WindowSize = new System.Drawing.Size(725, 607);
            // 
            // drawline
            // 
            this.drawline.Location = new System.Drawing.Point(12, 12);
            this.drawline.Name = "drawline";
            this.drawline.Size = new System.Drawing.Size(75, 23);
            this.drawline.TabIndex = 1;
            this.drawline.Text = "畫線";
            this.drawline.UseVisualStyleBackColor = true;
            this.drawline.Click += new System.EventHandler(this.drawline_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(93, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 2;
            this.reset.Text = "重畫";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // ROIWeight_label
            // 
            this.ROIWeight_label.AutoSize = true;
            this.ROIWeight_label.Location = new System.Drawing.Point(779, 137);
            this.ROIWeight_label.Name = "ROIWeight_label";
            this.ROIWeight_label.Size = new System.Drawing.Size(59, 12);
            this.ROIWeight_label.TabIndex = 27;
            this.ROIWeight_label.Text = "ROIWeight";
            // 
            // Sigma_label
            // 
            this.Sigma_label.AutoSize = true;
            this.Sigma_label.Location = new System.Drawing.Point(779, 89);
            this.Sigma_label.Name = "Sigma_label";
            this.Sigma_label.Size = new System.Drawing.Size(34, 12);
            this.Sigma_label.TabIndex = 26;
            this.Sigma_label.Text = "Sigma";
            // 
            // 最大Eage_label
            // 
            this.最大Eage_label.AutoSize = true;
            this.最大Eage_label.Location = new System.Drawing.Point(779, 41);
            this.最大Eage_label.Name = "最大Eage_label";
            this.最大Eage_label.Size = new System.Drawing.Size(52, 12);
            this.最大Eage_label.TabIndex = 25;
            this.最大Eage_label.Text = "最大Eage";
            // 
            // ROIWeight
            // 
            this.ROIWeight.Location = new System.Drawing.Point(779, 152);
            this.ROIWeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ROIWeight.Name = "ROIWeight";
            this.ROIWeight.Size = new System.Drawing.Size(120, 22);
            this.ROIWeight.TabIndex = 24;
            this.ROIWeight.ValueChanged += new System.EventHandler(this.ROIWeight_ValueChanged);
            // 
            // sigma
            // 
            this.sigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sigma.Location = new System.Drawing.Point(779, 104);
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
            this.sigma.Size = new System.Drawing.Size(120, 22);
            this.sigma.TabIndex = 23;
            this.sigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sigma.ValueChanged += new System.EventHandler(this.sigma_ValueChanged);
            // 
            // MaxEdge
            // 
            this.MaxEdge.Location = new System.Drawing.Point(779, 56);
            this.MaxEdge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MaxEdge.Name = "MaxEdge";
            this.MaxEdge.Size = new System.Drawing.Size(120, 22);
            this.MaxEdge.TabIndex = 22;
            this.MaxEdge.ValueChanged += new System.EventHandler(this.MaxEdge_ValueChanged);
            // 
            // ROIWeight_trackBar
            // 
            this.ROIWeight_trackBar.Location = new System.Drawing.Point(905, 152);
            this.ROIWeight_trackBar.Maximum = 255;
            this.ROIWeight_trackBar.Name = "ROIWeight_trackBar";
            this.ROIWeight_trackBar.Size = new System.Drawing.Size(287, 45);
            this.ROIWeight_trackBar.TabIndex = 21;
            this.ROIWeight_trackBar.TickFrequency = 5;
            this.ROIWeight_trackBar.ValueChanged += new System.EventHandler(this.ROIWeight_trackBar_ValueChanged);
            // 
            // Sigma_trackBar
            // 
            this.Sigma_trackBar.Location = new System.Drawing.Point(905, 104);
            this.Sigma_trackBar.Maximum = 32;
            this.Sigma_trackBar.Minimum = 1;
            this.Sigma_trackBar.Name = "Sigma_trackBar";
            this.Sigma_trackBar.Size = new System.Drawing.Size(287, 45);
            this.Sigma_trackBar.TabIndex = 20;
            this.Sigma_trackBar.Value = 1;
            this.Sigma_trackBar.ValueChanged += new System.EventHandler(this.Sigma_trackBar_ValueChanged);
            // 
            // MaxEage_trackBar
            // 
            this.MaxEage_trackBar.Location = new System.Drawing.Point(905, 56);
            this.MaxEage_trackBar.Maximum = 255;
            this.MaxEage_trackBar.Name = "MaxEage_trackBar";
            this.MaxEage_trackBar.Size = new System.Drawing.Size(287, 45);
            this.MaxEage_trackBar.TabIndex = 19;
            this.MaxEage_trackBar.TickFrequency = 5;
            this.MaxEage_trackBar.ValueChanged += new System.EventHandler(this.MaxEage_trackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "測量標點位置";
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView.GridLines = true;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(781, 191);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(411, 461);
            this.listView.TabIndex = 28;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(174, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 30;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 674);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.ROIWeight_label);
            this.Controls.Add(this.Sigma_label);
            this.Controls.Add(this.最大Eage_label);
            this.Controls.Add(this.ROIWeight);
            this.Controls.Add(this.sigma);
            this.Controls.Add(this.MaxEdge);
            this.Controls.Add(this.ROIWeight_trackBar);
            this.Controls.Add(this.Sigma_trackBar);
            this.Controls.Add(this.MaxEage_trackBar);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.drawline);
            this.Controls.Add(this.measure_window);
            this.Name = "Measure";
            this.Text = "measure";
            this.Activated += new System.EventHandler(this.Measure_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Measure_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROIWeight_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxEage_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl measure_window;
        private System.Windows.Forms.Button drawline;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label ROIWeight_label;
        private System.Windows.Forms.Label Sigma_label;
        private System.Windows.Forms.Label 最大Eage_label;
        private System.Windows.Forms.NumericUpDown ROIWeight;
        private System.Windows.Forms.NumericUpDown sigma;
        private System.Windows.Forms.NumericUpDown MaxEdge;
        private System.Windows.Forms.TrackBar ROIWeight_trackBar;
        private System.Windows.Forms.TrackBar Sigma_trackBar;
        private System.Windows.Forms.TrackBar MaxEage_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button OK;
    }
}