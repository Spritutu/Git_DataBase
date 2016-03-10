namespace CameraProcedure
{
    partial class PL_distance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PL_distance));
            ST_Base.ImageBase imageBase1 = new ST_Base.ImageBase();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.set = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.whichLline = new System.Windows.Forms.ComboBox();
            this.gen_result = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.whichpoint1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whichpicture = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.OK = new System.Windows.Forms.Button();
            this.distance_pl = new System.Windows.Forms.TextBox();
            this.tabControl4.SuspendLayout();
            this.set.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.set);
            this.tabControl4.Location = new System.Drawing.Point(12, 63);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(860, 697);
            this.tabControl4.TabIndex = 21;
            // 
            // set
            // 
            this.set.Controls.Add(this.distance_pl);
            this.set.Controls.Add(this.groupBox5);
            this.set.Controls.Add(this.gen_result);
            this.set.Controls.Add(this.groupBox4);
            this.set.Controls.Add(this.groupBox1);
            this.set.Controls.Add(this.groupBox2);
            this.set.Location = new System.Drawing.Point(4, 22);
            this.set.Name = "set";
            this.set.Padding = new System.Windows.Forms.Padding(3);
            this.set.Size = new System.Drawing.Size(852, 671);
            this.set.TabIndex = 0;
            this.set.Text = "設定";
            this.set.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.whichLline);
            this.groupBox5.Location = new System.Drawing.Point(669, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 53);
            this.groupBox5.TabIndex = 65;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "線選擇(L1)";
            // 
            // whichLline
            // 
            this.whichLline.FormattingEnabled = true;
            this.whichLline.Location = new System.Drawing.Point(6, 21);
            this.whichLline.Name = "whichLline";
            this.whichLline.Size = new System.Drawing.Size(121, 20);
            this.whichLline.TabIndex = 61;
            this.whichLline.SelectedValueChanged += new System.EventHandler(this.whichLine_SelectedValueChanged);
            // 
            // gen_result
            // 
            this.gen_result.Image = ((System.Drawing.Image)(resources.GetObject("gen_result.Image")));
            this.gen_result.Location = new System.Drawing.Point(800, 620);
            this.gen_result.Name = "gen_result";
            this.gen_result.Size = new System.Drawing.Size(46, 45);
            this.gen_result.TabIndex = 21;
            this.gen_result.UseVisualStyleBackColor = true;
            this.gen_result.Click += new System.EventHandler(this.gen_result_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.whichpoint1);
            this.groupBox4.Location = new System.Drawing.Point(669, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 53);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "點選擇(P1)";
            // 
            // whichpoint1
            // 
            this.whichpoint1.FormattingEnabled = true;
            this.whichpoint1.Location = new System.Drawing.Point(6, 21);
            this.whichpoint1.Name = "whichpoint1";
            this.whichpoint1.Size = new System.Drawing.Size(121, 20);
            this.whichpoint1.TabIndex = 61;
            this.whichpoint1.SelectedValueChanged += new System.EventHandler(this.whichpoint1_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.whichpicture);
            this.groupBox1.Location = new System.Drawing.Point(669, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 53);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影像選擇";
            // 
            // whichpicture
            // 
            this.whichpicture.FormattingEnabled = true;
            this.whichpicture.Location = new System.Drawing.Point(6, 21);
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
            this.toolWindow.WindowImage = imageBase1;
            // 
            // OK
            // 
            this.OK.Image = ((System.Drawing.Image)(resources.GetObject("OK.Image")));
            this.OK.Location = new System.Drawing.Point(12, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(46, 45);
            this.OK.TabIndex = 22;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // distance_pl
            // 
            this.distance_pl.Location = new System.Drawing.Point(696, 643);
            this.distance_pl.Name = "distance_pl";
            this.distance_pl.Size = new System.Drawing.Size(100, 22);
            this.distance_pl.TabIndex = 66;
            // 
            // PL_distance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 778);
            this.Controls.Add(this.tabControl4);
            this.Controls.Add(this.OK);
            this.Name = "PL_distance";
            this.Text = "PP_distance";
            this.Activated += new System.EventHandler(this.PL_distance_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PL_distance_FormClosing);
            this.tabControl4.ResumeLayout(false);
            this.set.ResumeLayout(false);
            this.set.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage set;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox whichLline;
        private System.Windows.Forms.Button gen_result;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox whichpoint1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox whichpicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox distance_pl;
    }
}