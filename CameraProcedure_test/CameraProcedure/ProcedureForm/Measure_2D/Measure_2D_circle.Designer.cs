namespace CameraProcedure
{
    partial class Measure_2D_Circle
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
            ST_Base.ImageBase imageBase1 = new ST_Base.ImageBase();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measure_2D_Circle));
            ST_Base.ImageBase imageBase2 = new ST_Base.ImageBase();
            this.setcircle = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolWindow1 = new ToolWindow.ToolWindow();
            this.DrawROI_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page_2DMeasure = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Length1_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Sigma_trackBar = new System.Windows.Forms.TrackBar();
            this.Length2 = new System.Windows.Forms.NumericUpDown();
            this.Threshold_trackBar = new System.Windows.Forms.TrackBar();
            this.Length2_trackBar = new System.Windows.Forms.TrackBar();
            this.Length1 = new System.Windows.Forms.NumericUpDown();
            this.ROIWeight_label = new System.Windows.Forms.Label();
            this.Sigma = new System.Windows.Forms.NumericUpDown();
            this.Sigma_label = new System.Windows.Forms.Label();
            this.Threshold = new System.Windows.Forms.NumericUpDown();
            this.Leangth1 = new System.Windows.Forms.Label();
            this.Page_result = new System.Windows.Forms.TabPage();
            this.OK = new System.Windows.Forms.Button();
            this.setimage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.whichpicture = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.setcircle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Page_2DMeasure.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length1_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length2_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold)).BeginInit();
            this.setimage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // setcircle
            // 
            this.setcircle.Controls.Add(this.groupBox3);
            this.setcircle.Controls.Add(this.DrawROI_button);
            this.setcircle.Controls.Add(this.tabControl1);
            this.setcircle.Location = new System.Drawing.Point(4, 22);
            this.setcircle.Name = "setcircle";
            this.setcircle.Padding = new System.Windows.Forms.Padding(3);
            this.setcircle.Size = new System.Drawing.Size(1142, 697);
            this.setcircle.TabIndex = 1;
            this.setcircle.Text = "設定圓";
            this.setcircle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolWindow1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 659);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "影像";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(6, 20);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(645, 616);
            this.toolWindow1.TabIndex = 5;
            this.toolWindow1.WindowImage = imageBase1;
            // 
            // DrawROI_button
            // 
            this.DrawROI_button.Image = ((System.Drawing.Image)(resources.GetObject("DrawROI_button.Image")));
            this.DrawROI_button.Location = new System.Drawing.Point(669, 6);
            this.DrawROI_button.Name = "DrawROI_button";
            this.DrawROI_button.Size = new System.Drawing.Size(46, 45);
            this.DrawROI_button.TabIndex = 17;
            this.DrawROI_button.UseVisualStyleBackColor = true;
            this.DrawROI_button.Click += new System.EventHandler(this.DrawROI_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page_2DMeasure);
            this.tabControl1.Controls.Add(this.Page_result);
            this.tabControl1.Location = new System.Drawing.Point(669, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 629);
            this.tabControl1.TabIndex = 16;
            // 
            // Page_2DMeasure
            // 
            this.Page_2DMeasure.Controls.Add(this.groupBox1);
            this.Page_2DMeasure.Location = new System.Drawing.Point(4, 22);
            this.Page_2DMeasure.Name = "Page_2DMeasure";
            this.Page_2DMeasure.Padding = new System.Windows.Forms.Padding(3);
            this.Page_2DMeasure.Size = new System.Drawing.Size(455, 603);
            this.Page_2DMeasure.TabIndex = 0;
            this.Page_2DMeasure.Text = "2D測量參數";
            this.Page_2DMeasure.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Length1_trackBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Sigma_trackBar);
            this.groupBox1.Controls.Add(this.Length2);
            this.groupBox1.Controls.Add(this.Threshold_trackBar);
            this.groupBox1.Controls.Add(this.Length2_trackBar);
            this.groupBox1.Controls.Add(this.Length1);
            this.groupBox1.Controls.Add(this.ROIWeight_label);
            this.groupBox1.Controls.Add(this.Sigma);
            this.groupBox1.Controls.Add(this.Sigma_label);
            this.groupBox1.Controls.Add(this.Threshold);
            this.groupBox1.Controls.Add(this.Leangth1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 229);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "參數設定";
            // 
            // Length1_trackBar
            // 
            this.Length1_trackBar.Location = new System.Drawing.Point(74, 21);
            this.Length1_trackBar.Maximum = 255;
            this.Length1_trackBar.Minimum = 1;
            this.Length1_trackBar.Name = "Length1_trackBar";
            this.Length1_trackBar.Size = new System.Drawing.Size(363, 45);
            this.Length1_trackBar.TabIndex = 52;
            this.Length1_trackBar.TickFrequency = 5;
            this.Length1_trackBar.Value = 1;
            this.Length1_trackBar.ValueChanged += new System.EventHandler(this.Length1_trackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 63;
            this.label1.Text = "Length2";
            // 
            // Sigma_trackBar
            // 
            this.Sigma_trackBar.Location = new System.Drawing.Point(74, 123);
            this.Sigma_trackBar.Maximum = 32;
            this.Sigma_trackBar.Minimum = 1;
            this.Sigma_trackBar.Name = "Sigma_trackBar";
            this.Sigma_trackBar.Size = new System.Drawing.Size(363, 45);
            this.Sigma_trackBar.TabIndex = 53;
            this.Sigma_trackBar.Value = 1;
            this.Sigma_trackBar.ValueChanged += new System.EventHandler(this.Sigma_trackBar_ValueChanged);
            // 
            // Length2
            // 
            this.Length2.Location = new System.Drawing.Point(16, 95);
            this.Length2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Length2.Name = "Length2";
            this.Length2.Size = new System.Drawing.Size(52, 22);
            this.Length2.TabIndex = 62;
            this.Length2.ValueChanged += new System.EventHandler(this.Length2_ValueChanged);
            // 
            // Threshold_trackBar
            // 
            this.Threshold_trackBar.Location = new System.Drawing.Point(74, 174);
            this.Threshold_trackBar.Maximum = 255;
            this.Threshold_trackBar.Name = "Threshold_trackBar";
            this.Threshold_trackBar.Size = new System.Drawing.Size(363, 45);
            this.Threshold_trackBar.TabIndex = 54;
            this.Threshold_trackBar.TickFrequency = 5;
            this.Threshold_trackBar.ValueChanged += new System.EventHandler(this.Threshold_trackBar_ValueChanged);
            // 
            // Length2_trackBar
            // 
            this.Length2_trackBar.Location = new System.Drawing.Point(74, 72);
            this.Length2_trackBar.Maximum = 255;
            this.Length2_trackBar.Name = "Length2_trackBar";
            this.Length2_trackBar.Size = new System.Drawing.Size(363, 45);
            this.Length2_trackBar.TabIndex = 61;
            this.Length2_trackBar.TickFrequency = 5;
            this.Length2_trackBar.ValueChanged += new System.EventHandler(this.Length2_trackBar_ValueChanged);
            // 
            // Length1
            // 
            this.Length1.Location = new System.Drawing.Point(16, 44);
            this.Length1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Length1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Length1.Name = "Length1";
            this.Length1.Size = new System.Drawing.Size(52, 22);
            this.Length1.TabIndex = 55;
            this.Length1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Length1.ValueChanged += new System.EventHandler(this.Length1_ValueChanged);
            // 
            // ROIWeight_label
            // 
            this.ROIWeight_label.AutoSize = true;
            this.ROIWeight_label.Location = new System.Drawing.Point(14, 174);
            this.ROIWeight_label.Name = "ROIWeight_label";
            this.ROIWeight_label.Size = new System.Drawing.Size(52, 12);
            this.ROIWeight_label.TabIndex = 60;
            this.ROIWeight_label.Text = "Threshold";
            // 
            // Sigma
            // 
            this.Sigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Sigma.Location = new System.Drawing.Point(16, 146);
            this.Sigma.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.Sigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sigma.Name = "Sigma";
            this.Sigma.Size = new System.Drawing.Size(52, 22);
            this.Sigma.TabIndex = 56;
            this.Sigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sigma.ValueChanged += new System.EventHandler(this.Sigma_ValueChanged);
            // 
            // Sigma_label
            // 
            this.Sigma_label.AutoSize = true;
            this.Sigma_label.Location = new System.Drawing.Point(14, 123);
            this.Sigma_label.Name = "Sigma_label";
            this.Sigma_label.Size = new System.Drawing.Size(34, 12);
            this.Sigma_label.TabIndex = 59;
            this.Sigma_label.Text = "Sigma";
            // 
            // Threshold
            // 
            this.Threshold.Location = new System.Drawing.Point(16, 197);
            this.Threshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(52, 22);
            this.Threshold.TabIndex = 57;
            this.Threshold.ValueChanged += new System.EventHandler(this.Threshold_ValueChanged);
            // 
            // Leangth1
            // 
            this.Leangth1.AutoSize = true;
            this.Leangth1.Location = new System.Drawing.Point(14, 21);
            this.Leangth1.Name = "Leangth1";
            this.Leangth1.Size = new System.Drawing.Size(44, 12);
            this.Leangth1.TabIndex = 58;
            this.Leangth1.Text = "Length1";
            // 
            // Page_result
            // 
            this.Page_result.Location = new System.Drawing.Point(4, 22);
            this.Page_result.Name = "Page_result";
            this.Page_result.Padding = new System.Windows.Forms.Padding(3);
            this.Page_result.Size = new System.Drawing.Size(455, 603);
            this.Page_result.TabIndex = 1;
            this.Page_result.Text = "測量結果";
            this.Page_result.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Image = ((System.Drawing.Image)(resources.GetObject("OK.Image")));
            this.OK.Location = new System.Drawing.Point(12, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(46, 45);
            this.OK.TabIndex = 18;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // setimage
            // 
            this.setimage.Controls.Add(this.label14);
            this.setimage.Controls.Add(this.whichpicture);
            this.setimage.Controls.Add(this.groupBox2);
            this.setimage.Location = new System.Drawing.Point(4, 22);
            this.setimage.Name = "setimage";
            this.setimage.Padding = new System.Windows.Forms.Padding(3);
            this.setimage.Size = new System.Drawing.Size(1142, 697);
            this.setimage.TabIndex = 0;
            this.setimage.Text = "設定影像";
            this.setimage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(669, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 62;
            this.label14.Text = "影像選擇";
            // 
            // whichpicture
            // 
            this.whichpicture.FormattingEnabled = true;
            this.whichpicture.Location = new System.Drawing.Point(671, 44);
            this.whichpicture.Name = "whichpicture";
            this.whichpicture.Size = new System.Drawing.Size(121, 20);
            this.whichpicture.TabIndex = 61;
            this.whichpicture.SelectedValueChanged += new System.EventHandler(this.whichpicture_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolWindow);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 659);
            this.groupBox2.TabIndex = 60;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.setimage);
            this.tabControl.Controls.Add(this.setcircle);
            this.tabControl.Location = new System.Drawing.Point(12, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1150, 723);
            this.tabControl.TabIndex = 12;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Measure_2D_Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 796);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.OK);
            this.Name = "Measure_2D_Circle";
            this.Text = "Measure_2D_Circle";
            this.Activated += new System.EventHandler(this.Measure_2D_Circle_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Measure_2D_Circle_FormClosing);
            this.setcircle.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Page_2DMeasure.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length1_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length2_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold)).EndInit();
            this.setimage.ResumeLayout(false);
            this.setimage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage setcircle;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TabPage setimage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Page_result;
        private System.Windows.Forms.Label Leangth1;
        private System.Windows.Forms.NumericUpDown Threshold;
        private System.Windows.Forms.Label Sigma_label;
        private System.Windows.Forms.NumericUpDown Sigma;
        private System.Windows.Forms.Label ROIWeight_label;
        private System.Windows.Forms.NumericUpDown Length1;
        private System.Windows.Forms.TrackBar Length2_trackBar;
        private System.Windows.Forms.TrackBar Threshold_trackBar;
        private System.Windows.Forms.NumericUpDown Length2;
        private System.Windows.Forms.TrackBar Sigma_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Length1_trackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Page_2DMeasure;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button DrawROI_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox whichpicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.GroupBox groupBox3;
        private ToolWindow.ToolWindow toolWindow1;
    }
}