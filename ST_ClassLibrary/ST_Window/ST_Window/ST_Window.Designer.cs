namespace ST_Window
{
    partial class ST_Window
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
            this.Window = new HalconDotNet.HWindowControl();
            this.imagestatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagestatus_column = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagestatus_row = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagestatus_gravalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_CtrlHStatusLabelCtrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagestatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Window
            // 
            this.Window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Window.BackColor = System.Drawing.Color.Black;
            this.Window.BorderColor = System.Drawing.Color.Black;
            this.Window.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.Window.Location = new System.Drawing.Point(3, 3);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(727, 560);
            this.Window.TabIndex = 0;
            this.Window.WindowSize = new System.Drawing.Size(727, 560);
            this.Window.HMouseMove += new HalconDotNet.HMouseEventHandler(this.Window_HMouseMove);
            this.Window.HMouseDown += new HalconDotNet.HMouseEventHandler(this.Window_HMouseDown);
            this.Window.HMouseUp += new HalconDotNet.HMouseEventHandler(this.Window_HMouseUp);
            this.Window.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.Window_HMouseWheel);
            // 
            // imagestatus
            // 
            this.imagestatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1,
            this.imagestatus_column,
            this.toolStripStatusLabel2,
            this.imagestatus_row,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel4,
            this.imagestatus_gravalue,
            this.m_CtrlHStatusLabelCtrl});
            this.imagestatus.Location = new System.Drawing.Point(0, 566);
            this.imagestatus.Name = "imagestatus";
            this.imagestatus.Size = new System.Drawing.Size(733, 22);
            this.imagestatus.TabIndex = 1;
            this.imagestatus.Text = "Imagestatus";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel5.Text = "coordinate";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "(";
            // 
            // imagestatus_column
            // 
            this.imagestatus_column.Name = "imagestatus_column";
            this.imagestatus_column.Size = new System.Drawing.Size(28, 17);
            this.imagestatus_column.Text = "null";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = ",";
            // 
            // imagestatus_row
            // 
            this.imagestatus_row.Name = "imagestatus_row";
            this.imagestatus_row.Size = new System.Drawing.Size(28, 17);
            this.imagestatus_row.Text = "null";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel3.Text = ")";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel6.Text = "        ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel4.Text = "gravalue=";
            // 
            // imagestatus_gravalue
            // 
            this.imagestatus_gravalue.Name = "imagestatus_gravalue";
            this.imagestatus_gravalue.Size = new System.Drawing.Size(28, 17);
            this.imagestatus_gravalue.Text = "null";
            // 
            // m_CtrlHStatusLabelCtrl
            // 
            this.m_CtrlHStatusLabelCtrl.Name = "m_CtrlHStatusLabelCtrl";
            this.m_CtrlHStatusLabelCtrl.Size = new System.Drawing.Size(0, 17);
            // 
            // ST_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imagestatus);
            this.Controls.Add(this.Window);
            this.Name = "ST_Window";
            this.Size = new System.Drawing.Size(733, 588);
            this.imagestatus.ResumeLayout(false);
            this.imagestatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip imagestatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel imagestatus_column;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel imagestatus_row;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel imagestatus_gravalue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        public HalconDotNet.HWindowControl Window;
        private System.Windows.Forms.ToolStripStatusLabel m_CtrlHStatusLabelCtrl;
    }
}
