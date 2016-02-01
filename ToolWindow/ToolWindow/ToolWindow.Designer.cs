using HalconDotNet;
namespace ToolWindow
{
    partial class ToolWindow
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

        #region 元件設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolWindow));
            this.window = new HalconDotNet.HWindowControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cursorButton = new System.Windows.Forms.ToolStripButton();
            this.moveButton = new System.Windows.Forms.ToolStripButton();
            this.ZoomButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fitButton = new System.Windows.Forms.ToolStripButton();
            this.ZoominButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ZoomoutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rulerButton = new System.Windows.Forms.ToolStripButton();
            this.WindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MouseXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pixelvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.WindowStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.window.BackColor = System.Drawing.Color.Black;
            this.window.BorderColor = System.Drawing.Color.Black;
            this.window.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.window.Location = new System.Drawing.Point(0, 25);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(738, 667);
            this.window.TabIndex = 0;
            this.window.WindowSize = new System.Drawing.Size(738, 667);
            this.window.HMouseMove += new HalconDotNet.HMouseEventHandler(this.Window_HMouseMove);
            this.window.HMouseDown += new HalconDotNet.HMouseEventHandler(this.Window_HMouseDown);
            this.window.HMouseUp += new HalconDotNet.HMouseEventHandler(this.Window_HMouseUp);
            this.window.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.Window_HMouseWheel);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursorButton,
            this.moveButton,
            this.ZoomButton,
            this.toolStripSeparator1,
            this.fitButton,
            this.ZoominButton,
            this.toolStripLabel1,
            this.ZoomoutButton,
            this.toolStripSeparator2,
            this.rulerButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(738, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // cursorButton
            // 
            this.cursorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursorButton.Image = ((System.Drawing.Image)(resources.GetObject("cursorButton.Image")));
            this.cursorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cursorButton.Name = "cursorButton";
            this.cursorButton.Size = new System.Drawing.Size(23, 22);
            this.cursorButton.Text = "cursor";
            this.cursorButton.ToolTipText = "cursor";
            this.cursorButton.Click += new System.EventHandler(this.cursorButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveButton.Image = ((System.Drawing.Image)(resources.GetObject("moveButton.Image")));
            this.moveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(23, 22);
            this.moveButton.Text = "move";
            this.moveButton.ToolTipText = "moveButton";
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // ZoomButton
            // 
            this.ZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("ZoomButton.Image")));
            this.ZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomButton.Text = "Zoom";
            this.ZoomButton.Click += new System.EventHandler(this.ZoomButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fitButton
            // 
            this.fitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fitButton.Image = ((System.Drawing.Image)(resources.GetObject("fitButton.Image")));
            this.fitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fitButton.Name = "fitButton";
            this.fitButton.Size = new System.Drawing.Size(23, 22);
            this.fitButton.Text = "fit";
            this.fitButton.Click += new System.EventHandler(this.fitButton_Click);
            // 
            // ZoominButton
            // 
            this.ZoominButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoominButton.Image = ((System.Drawing.Image)(resources.GetObject("ZoominButton.Image")));
            this.ZoominButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoominButton.Name = "ZoominButton";
            this.ZoominButton.Size = new System.Drawing.Size(23, 22);
            this.ZoominButton.Text = "Zoomin";
            this.ZoominButton.Click += new System.EventHandler(this.ZoominButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "Zoomout";
            // 
            // ZoomoutButton
            // 
            this.ZoomoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomoutButton.Image = ((System.Drawing.Image)(resources.GetObject("ZoomoutButton.Image")));
            this.ZoomoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomoutButton.Name = "ZoomoutButton";
            this.ZoomoutButton.Size = new System.Drawing.Size(23, 22);
            this.ZoomoutButton.Text = "toolStripButton4";
            this.ZoomoutButton.Click += new System.EventHandler(this.ZoomoutButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rulerButton
            // 
            this.rulerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rulerButton.Image = ((System.Drawing.Image)(resources.GetObject("rulerButton.Image")));
            this.rulerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rulerButton.Name = "rulerButton";
            this.rulerButton.Size = new System.Drawing.Size(23, 22);
            this.rulerButton.Text = "ruler";
            // 
            // WindowStatusStrip
            // 
            this.WindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MouseXY,
            this.pixelvalue});
            this.WindowStatusStrip.Location = new System.Drawing.Point(0, 695);
            this.WindowStatusStrip.Name = "WindowStatusStrip";
            this.WindowStatusStrip.Size = new System.Drawing.Size(738, 22);
            this.WindowStatusStrip.TabIndex = 5;
            this.WindowStatusStrip.Text = "WindowStatusStrip";
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
            // ToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WindowStatusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.window);
            this.Name = "ToolWindow";
            this.Size = new System.Drawing.Size(738, 717);
            this.Load += new System.EventHandler(this.ToolWindow_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.WindowStatusStrip.ResumeLayout(false);
            this.WindowStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton cursorButton;
        private System.Windows.Forms.ToolStripButton moveButton;
        private System.Windows.Forms.ToolStripButton ZoomoutButton;
        private System.Windows.Forms.ToolStripButton rulerButton;
        private System.Windows.Forms.StatusStrip WindowStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MouseXY;
        private System.Windows.Forms.ToolStripStatusLabel pixelvalue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ZoominButton;
        private System.Windows.Forms.ToolStripButton ZoomButton;
        private System.Windows.Forms.ToolStripButton fitButton;
        private HalconDotNet.HWindowControl window;

        public HWindowControl Window { get { return window; } }
    }
}
