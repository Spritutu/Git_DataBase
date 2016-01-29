namespace MainProject
{
    partial class MainForm_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_test));
            this.startButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stopButton = new System.Windows.Forms.Button();
            this.procedureButton = new System.Windows.Forms.Button();
            this.srtButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.Camera_1 = new System.Windows.Forms.TabPage();
            this.cameraProcedure1 = new CameraProcedure.CameraProcedure();
            this.Camera_2 = new System.Windows.Forms.TabPage();
            this.Camera_3 = new System.Windows.Forms.TabPage();
            this.Camera_4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.Camera_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(13, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 60);
            this.startButton.TabIndex = 0;
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1586, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 896);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1586, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(79, 27);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 60);
            this.stopButton.TabIndex = 3;
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // procedureButton
            // 
            this.procedureButton.Image = ((System.Drawing.Image)(resources.GetObject("procedureButton.Image")));
            this.procedureButton.Location = new System.Drawing.Point(145, 27);
            this.procedureButton.Name = "procedureButton";
            this.procedureButton.Size = new System.Drawing.Size(60, 60);
            this.procedureButton.TabIndex = 6;
            this.procedureButton.UseVisualStyleBackColor = true;
            this.procedureButton.Click += new System.EventHandler(this.procedureButton_Click);
            // 
            // srtButton
            // 
            this.srtButton.Image = ((System.Drawing.Image)(resources.GetObject("srtButton.Image")));
            this.srtButton.Location = new System.Drawing.Point(211, 27);
            this.srtButton.Name = "srtButton";
            this.srtButton.Size = new System.Drawing.Size(60, 60);
            this.srtButton.TabIndex = 7;
            this.srtButton.UseVisualStyleBackColor = true;
            // 
            // infoButton
            // 
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.Location = new System.Drawing.Point(277, 27);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(60, 60);
            this.infoButton.TabIndex = 8;
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.Camera_1);
            this.mainTabControl.Controls.Add(this.Camera_2);
            this.mainTabControl.Controls.Add(this.Camera_3);
            this.mainTabControl.Controls.Add(this.Camera_4);
            this.mainTabControl.Location = new System.Drawing.Point(12, 93);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1505, 764);
            this.mainTabControl.TabIndex = 9;
            // 
            // Camera_1
            // 
            this.Camera_1.Controls.Add(this.cameraProcedure1);
            this.Camera_1.Location = new System.Drawing.Point(4, 22);
            this.Camera_1.Name = "Camera_1";
            this.Camera_1.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_1.Size = new System.Drawing.Size(1497, 738);
            this.Camera_1.TabIndex = 1;
            this.Camera_1.Text = "Camera No.1";
            this.Camera_1.UseVisualStyleBackColor = true;
            // 
            // cameraProcedure1
            // 
            this.cameraProcedure1.Location = new System.Drawing.Point(3, 3);
            this.cameraProcedure1.Name = "cameraProcedure1";
            this.cameraProcedure1.Size = new System.Drawing.Size(1502, 733);
            this.cameraProcedure1.TabIndex = 0;
            // 
            // Camera_2
            // 
            this.Camera_2.Location = new System.Drawing.Point(4, 22);
            this.Camera_2.Name = "Camera_2";
            this.Camera_2.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_2.Size = new System.Drawing.Size(1497, 738);
            this.Camera_2.TabIndex = 2;
            this.Camera_2.Text = "Camera No.2";
            this.Camera_2.UseVisualStyleBackColor = true;
            // 
            // Camera_3
            // 
            this.Camera_3.Location = new System.Drawing.Point(4, 22);
            this.Camera_3.Name = "Camera_3";
            this.Camera_3.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_3.Size = new System.Drawing.Size(1497, 738);
            this.Camera_3.TabIndex = 3;
            this.Camera_3.Text = "Camera No.3";
            this.Camera_3.UseVisualStyleBackColor = true;
            // 
            // Camera_4
            // 
            this.Camera_4.Location = new System.Drawing.Point(4, 22);
            this.Camera_4.Name = "Camera_4";
            this.Camera_4.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_4.Size = new System.Drawing.Size(1497, 738);
            this.Camera_4.TabIndex = 4;
            this.Camera_4.Text = "Camera No.4";
            this.Camera_4.UseVisualStyleBackColor = true;
            // 
            // MainForm_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1586, 918);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.srtButton);
            this.Controls.Add(this.procedureButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm_test";
            this.Text = "MainForm_test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.Camera_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button procedureButton;
        private System.Windows.Forms.Button srtButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TabPage Camera_2;
        private System.Windows.Forms.TabPage Camera_3;
        private System.Windows.Forms.TabPage Camera_4;
        private System.Windows.Forms.TabPage Camera_1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private CameraProcedure.CameraProcedure cameraProcedure1;
    }
}