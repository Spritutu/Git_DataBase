namespace MainProject
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
            this.CreateMatchingModel_window = new HalconDotNet.HWindowControl();
            this.WindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MouseXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pixelvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.WindowStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateMatchingModel_window
            // 
            this.CreateMatchingModel_window.BackColor = System.Drawing.Color.Black;
            this.CreateMatchingModel_window.BorderColor = System.Drawing.Color.Black;
            this.CreateMatchingModel_window.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.CreateMatchingModel_window.Location = new System.Drawing.Point(12, 12);
            this.CreateMatchingModel_window.Name = "CreateMatchingModel_window";
            this.CreateMatchingModel_window.Size = new System.Drawing.Size(622, 527);
            this.CreateMatchingModel_window.TabIndex = 0;
            this.CreateMatchingModel_window.WindowSize = new System.Drawing.Size(622, 527);
            this.CreateMatchingModel_window.HMouseMove += new HalconDotNet.HMouseEventHandler(this.CreatMatchingModel_window_HMouseMove);
            // 
            // WindowStatusStrip
            // 
            this.WindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MouseXY,
            this.pixelvalue});
            this.WindowStatusStrip.Location = new System.Drawing.Point(0, 553);
            this.WindowStatusStrip.Name = "WindowStatusStrip";
            this.WindowStatusStrip.Size = new System.Drawing.Size(774, 22);
            this.WindowStatusStrip.TabIndex = 5;
            this.WindowStatusStrip.Text = "MainWindowStatusStrip";
            // 
            // MouseXY
            // 
            this.MouseXY.Name = "MouseXY";
            this.MouseXY.Size = new System.Drawing.Size(98, 17);
            this.MouseXY.Text = "Mouse(null,null)";
            // 
            // pixelvalue
            // 
            this.pixelvalue.Name = "pixelvalue";
            this.pixelvalue.Size = new System.Drawing.Size(100, 17);
            this.pixelvalue.Text = "pixelvalue = null";
            // 
            // CreateMatchingModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 575);
            this.Controls.Add(this.WindowStatusStrip);
            this.Controls.Add(this.CreateMatchingModel_window);
            this.Name = "CreateMatchingModel";
            this.Text = "CreateMatchingModel";
            this.WindowStatusStrip.ResumeLayout(false);
            this.WindowStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl CreateMatchingModel_window;
        private System.Windows.Forms.StatusStrip WindowStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MouseXY;
        private System.Windows.Forms.ToolStripStatusLabel pixelvalue;
    }
}