namespace MainProject
{
    partial class MainProjectForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcedureTable = new System.Windows.Forms.DataGridView();
            this.MainWindow = new HalconDotNet.HWindowControl();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ProcedureMenuStrip = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.MainWindowObjectTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcedureTable
            // 
            this.ProcedureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcedureTable.Location = new System.Drawing.Point(1092, 72);
            this.ProcedureTable.Name = "ProcedureTable";
            this.ProcedureTable.RowTemplate.Height = 24;
            this.ProcedureTable.Size = new System.Drawing.Size(373, 681);
            this.ProcedureTable.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.MainWindow.BackColor = System.Drawing.Color.Black;
            this.MainWindow.BorderColor = System.Drawing.Color.Black;
            this.MainWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.MainWindow.Location = new System.Drawing.Point(12, 72);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(851, 681);
            this.MainWindow.TabIndex = 1;
            this.MainWindow.WindowSize = new System.Drawing.Size(851, 681);
            this.MainWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 761);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1490, 22);
            this.MainStatusStrip.TabIndex = 2;
            this.MainStatusStrip.Text = "MainStatusStrip";
            // 
            // ProcedureMenuStrip
            // 
            this.ProcedureMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProcedureMenuStrip.Name = "ProcedureMenuStrip";
            this.ProcedureMenuStrip.Size = new System.Drawing.Size(1490, 24);
            this.ProcedureMenuStrip.TabIndex = 3;
            this.ProcedureMenuStrip.Text = "ProcedureMenuStrip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindowObjectTable
            // 
            this.MainWindowObjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainWindowObjectTable.Location = new System.Drawing.Point(869, 72);
            this.MainWindowObjectTable.Name = "MainWindowObjectTable";
            this.MainWindowObjectTable.RowTemplate.Height = 24;
            this.MainWindowObjectTable.Size = new System.Drawing.Size(217, 681);
            this.MainWindowObjectTable.TabIndex = 5;
            // 
            // MainProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1490, 783);
            this.Controls.Add(this.MainWindowObjectTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.ProcedureMenuStrip);
            this.Controls.Add(this.MainWindow);
            this.Controls.Add(this.ProcedureTable);
            this.MainMenuStrip = this.ProcedureMenuStrip;
            this.Name = "MainProjectForm";
            this.Text = "MainProjectForm";
            this.Load += new System.EventHandler(this.MainProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// 程序表格 DataGridView。
        /// </summary>
        private System.Windows.Forms.DataGridView ProcedureTable;
        /// <summary>
        /// halcon視窗。
        /// </summary>
        private HalconDotNet.HWindowControl MainWindow;
        /// <summary>
        /// MainProject狀態列。
        /// </summary>
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        /// <summary>
        /// MainProject工具列。
        /// </summary>
        private System.Windows.Forms.MenuStrip ProcedureMenuStrip;
        /// <summary>
        /// 測試按鈕。
        /// </summary>
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView MainWindowObjectTable;
    }
}

