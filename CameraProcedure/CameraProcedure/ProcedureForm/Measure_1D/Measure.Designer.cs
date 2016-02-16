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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measure));
            ST_Base.ImageBase imageBase1 = new ST_Base.ImageBase();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page_1DMeasure = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TransitionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectBox = new System.Windows.Forms.ComboBox();
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
            this.result_list = new System.Windows.Forms.ListView();
            this.DrawROI_button = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.pairButton = new System.Windows.Forms.RadioButton();
            this.posButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.Page_result.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.TransitionBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SelectBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邊緣選擇";
            // 
            // TransitionBox
            // 
            this.TransitionBox.FormattingEnabled = true;
            this.TransitionBox.Location = new System.Drawing.Point(207, 56);
            this.TransitionBox.Name = "TransitionBox";
            this.TransitionBox.Size = new System.Drawing.Size(121, 20);
            this.TransitionBox.TabIndex = 57;
            this.TransitionBox.SelectedIndexChanged += new System.EventHandler(this.TransitionBox_SelectedIndexChanged);
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
            // SelectBox
            // 
            this.SelectBox.FormattingEnabled = true;
            this.SelectBox.Location = new System.Drawing.Point(207, 21);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(121, 20);
            this.SelectBox.TabIndex = 55;
            this.SelectBox.SelectedIndexChanged += new System.EventHandler(this.SelectBox_SelectedIndexChanged);
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
            this.parameter.Controls.Add(this.panel2);
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
            this.Eage_num.ValueChanged += new System.EventHandler(this.Eage_num_ValueChanged);
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
            this.Page_result.Controls.Add(this.result_list);
            this.Page_result.Location = new System.Drawing.Point(4, 22);
            this.Page_result.Name = "Page_result";
            this.Page_result.Padding = new System.Windows.Forms.Padding(3);
            this.Page_result.Size = new System.Drawing.Size(582, 649);
            this.Page_result.TabIndex = 1;
            this.Page_result.Text = "測量結果";
            this.Page_result.UseVisualStyleBackColor = true;
            // 
            // result_list
            // 
            this.result_list.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.result_list.GridLines = true;
            this.result_list.LabelEdit = true;
            this.result_list.Location = new System.Drawing.Point(6, 6);
            this.result_list.Name = "result_list";
            this.result_list.Size = new System.Drawing.Size(570, 637);
            this.result_list.TabIndex = 29;
            this.result_list.UseCompatibleStateImageBehavior = false;
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
            this.toolWindow.WindowImage = imageBase1;
            // 
            // pairButton
            // 
            this.pairButton.AutoSize = true;
            this.pairButton.Location = new System.Drawing.Point(3, 23);
            this.pairButton.Name = "pairButton";
            this.pairButton.Size = new System.Drawing.Size(41, 16);
            this.pairButton.TabIndex = 6;
            this.pairButton.TabStop = true;
            this.pairButton.Text = "pair";
            this.pairButton.UseVisualStyleBackColor = true;
            this.pairButton.CheckedChanged += new System.EventHandler(this.pairButton_CheckedChanged);
            // 
            // posButton
            // 
            this.posButton.AutoSize = true;
            this.posButton.Location = new System.Drawing.Point(3, 3);
            this.posButton.Name = "posButton";
            this.posButton.Size = new System.Drawing.Size(39, 16);
            this.posButton.TabIndex = 7;
            this.posButton.TabStop = true;
            this.posButton.Text = "pos";
            this.posButton.UseVisualStyleBackColor = true;
            this.posButton.CheckedChanged += new System.EventHandler(this.posButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.posButton);
            this.panel1.Controls.Add(this.pairButton);
            this.panel1.Location = new System.Drawing.Point(116, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 45);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(123, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 44);
            this.panel2.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "pos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "pair";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 696);
            this.Controls.Add(this.panel1);
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
            this.Page_result.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TransitionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectBox;
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
        private System.Windows.Forms.RadioButton pairButton;
        private System.Windows.Forms.RadioButton posButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView result_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}