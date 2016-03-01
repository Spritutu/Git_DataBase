﻿namespace CameraProcedure
{
    partial class CreateMatchingModel
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
            ST_Base.ImageBase imageBase2 = new ST_Base.ImageBase();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.setROI = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Find_Greediness = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Find_Default = new System.Windows.Forms.Button();
            this.Find_AngleExtent = new System.Windows.Forms.TextBox();
            this.Find_NumLevels = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Find_AngleStart = new System.Windows.Forms.TextBox();
            this.Find_NumMatch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Find_MinScore = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Create_Default = new System.Windows.Forms.Button();
            this.Create_AngleStart = new System.Windows.Forms.TextBox();
            this.Create_MinContrast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Create_NumLevels = new System.Windows.Forms.TextBox();
            this.Create_Contrast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Create_AngleExtent = new System.Windows.Forms.TextBox();
            this.Test = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolWindow1 = new ToolWindow.ToolWindow();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.Find_MaxOverLap = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 639);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "影像設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolWindow);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 596);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影像";
            // 
            // toolWindow
            // 
            this.toolWindow.Location = new System.Drawing.Point(6, 20);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.Size = new System.Drawing.Size(645, 616);
            this.toolWindow.TabIndex = 5;
            this.toolWindow.WindowImage = imageBase1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.setROI);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.Test);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定位設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // setROI
            // 
            this.setROI.Location = new System.Drawing.Point(669, 15);
            this.setROI.Name = "setROI";
            this.setROI.Size = new System.Drawing.Size(128, 69);
            this.setROI.TabIndex = 26;
            this.setROI.Text = "設定ROI";
            this.setROI.UseVisualStyleBackColor = true;
            this.setROI.Click += new System.EventHandler(this.setROI_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Find_MaxOverLap);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.Find_Greediness);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.Find_Default);
            this.groupBox5.Controls.Add(this.Find_AngleExtent);
            this.groupBox5.Controls.Add(this.Find_NumLevels);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.Find_AngleStart);
            this.groupBox5.Controls.Add(this.Find_NumMatch);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.Find_MinScore);
            this.groupBox5.Location = new System.Drawing.Point(669, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 168);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "匹配參數(Find)";
            // 
            // Find_Greediness
            // 
            this.Find_Greediness.Location = new System.Drawing.Point(188, 13);
            this.Find_Greediness.Name = "Find_Greediness";
            this.Find_Greediness.Size = new System.Drawing.Size(29, 22);
            this.Find_Greediness.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(109, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Greediness";
            // 
            // Find_Default
            // 
            this.Find_Default.Location = new System.Drawing.Point(152, 135);
            this.Find_Default.Name = "Find_Default";
            this.Find_Default.Size = new System.Drawing.Size(62, 23);
            this.Find_Default.TabIndex = 24;
            this.Find_Default.Text = "預設值";
            this.Find_Default.UseVisualStyleBackColor = true;
            this.Find_Default.Click += new System.EventHandler(this.Find_Default_Click);
            // 
            // Find_AngleExtent
            // 
            this.Find_AngleExtent.Location = new System.Drawing.Point(77, 38);
            this.Find_AngleExtent.Name = "Find_AngleExtent";
            this.Find_AngleExtent.Size = new System.Drawing.Size(26, 22);
            this.Find_AngleExtent.TabIndex = 17;
            // 
            // Find_NumLevels
            // 
            this.Find_NumLevels.Location = new System.Drawing.Point(188, 63);
            this.Find_NumLevels.Name = "Find_NumLevels";
            this.Find_NumLevels.Size = new System.Drawing.Size(29, 22);
            this.Find_NumLevels.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "AngleStart";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(109, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "NumLevels";
            // 
            // Find_AngleStart
            // 
            this.Find_AngleStart.Location = new System.Drawing.Point(77, 13);
            this.Find_AngleStart.Name = "Find_AngleStart";
            this.Find_AngleStart.Size = new System.Drawing.Size(26, 22);
            this.Find_AngleStart.TabIndex = 15;
            // 
            // Find_NumMatch
            // 
            this.Find_NumMatch.Location = new System.Drawing.Point(188, 38);
            this.Find_NumMatch.Name = "Find_NumMatch";
            this.Find_NumMatch.Size = new System.Drawing.Size(29, 22);
            this.Find_NumMatch.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "AngleExtent";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(109, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "NumMatch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "MinScore";
            // 
            // Find_MinScore
            // 
            this.Find_MinScore.Location = new System.Drawing.Point(77, 63);
            this.Find_MinScore.Name = "Find_MinScore";
            this.Find_MinScore.Size = new System.Drawing.Size(26, 22);
            this.Find_MinScore.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Create_Default);
            this.groupBox4.Controls.Add(this.Create_AngleStart);
            this.groupBox4.Controls.Add(this.Create_MinContrast);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Create_NumLevels);
            this.groupBox4.Controls.Add(this.Create_Contrast);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Create_AngleExtent);
            this.groupBox4.Location = new System.Drawing.Point(669, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 178);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "建立匹配模板(Create)";
            // 
            // Create_Default
            // 
            this.Create_Default.Location = new System.Drawing.Point(149, 149);
            this.Create_Default.Name = "Create_Default";
            this.Create_Default.Size = new System.Drawing.Size(62, 23);
            this.Create_Default.TabIndex = 24;
            this.Create_Default.Text = "預設值";
            this.Create_Default.UseVisualStyleBackColor = true;
            this.Create_Default.Click += new System.EventHandler(this.Create_Default_Click);
            // 
            // Create_AngleStart
            // 
            this.Create_AngleStart.Location = new System.Drawing.Point(172, 38);
            this.Create_AngleStart.Name = "Create_AngleStart";
            this.Create_AngleStart.Size = new System.Drawing.Size(39, 22);
            this.Create_AngleStart.TabIndex = 17;
            // 
            // Create_MinContrast
            // 
            this.Create_MinContrast.Location = new System.Drawing.Point(172, 113);
            this.Create_MinContrast.Name = "Create_MinContrast";
            this.Create_MinContrast.Size = new System.Drawing.Size(39, 22);
            this.Create_MinContrast.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "NumLevels";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "MinContrast";
            // 
            // Create_NumLevels
            // 
            this.Create_NumLevels.Location = new System.Drawing.Point(172, 13);
            this.Create_NumLevels.Name = "Create_NumLevels";
            this.Create_NumLevels.Size = new System.Drawing.Size(39, 22);
            this.Create_NumLevels.TabIndex = 15;
            // 
            // Create_Contrast
            // 
            this.Create_Contrast.Location = new System.Drawing.Point(172, 88);
            this.Create_Contrast.Name = "Create_Contrast";
            this.Create_Contrast.Size = new System.Drawing.Size(39, 22);
            this.Create_Contrast.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "AngleStart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contrast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "AngleExtent";
            // 
            // Create_AngleExtent
            // 
            this.Create_AngleExtent.Location = new System.Drawing.Point(172, 63);
            this.Create_AngleExtent.Name = "Create_AngleExtent";
            this.Create_AngleExtent.Size = new System.Drawing.Size(39, 22);
            this.Create_AngleExtent.TabIndex = 19;
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(860, 549);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(102, 44);
            this.Test.TabIndex = 4;
            this.Test.Text = "測試執行";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolWindow1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 596);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "影像";
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(6, 20);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(645, 616);
            this.toolWindow1.TabIndex = 5;
            this.toolWindow1.WindowImage = imageBase2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(968, 613);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "定位結果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "詳細結果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 21;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 21;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Angle";
            this.Column3.Name = "Column3";
            this.Column3.Width = 21;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Score";
            this.Column4.Name = "Column4";
            this.Column4.Width = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(6, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "MaxOverLap";
            // 
            // Find_MaxOverLap
            // 
            this.Find_MaxOverLap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Find_MaxOverLap.Location = new System.Drawing.Point(77, 85);
            this.Find_MaxOverLap.Name = "Find_MaxOverLap";
            this.Find_MaxOverLap.Size = new System.Drawing.Size(26, 22);
            this.Find_MaxOverLap.TabIndex = 30;
            // 
            // CreateMatchingModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateMatchingModel";
            this.Text = "CreateMatchingModel";
            this.Activated += new System.EventHandler(this.CreateMatchingModel_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Find_Greediness;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Find_Default;
        private System.Windows.Forms.TextBox Find_AngleExtent;
        private System.Windows.Forms.TextBox Find_NumLevels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Find_AngleStart;
        private System.Windows.Forms.TextBox Find_NumMatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Find_MinScore;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Create_Default;
        private System.Windows.Forms.TextBox Create_AngleStart;
        private System.Windows.Forms.TextBox Create_MinContrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Create_NumLevels;
        private System.Windows.Forms.TextBox Create_Contrast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Create_AngleExtent;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.GroupBox groupBox2;
        private ToolWindow.ToolWindow toolWindow1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setROI;
        private System.Windows.Forms.TextBox Find_MaxOverLap;
        private System.Windows.Forms.Label label13;
    }
}