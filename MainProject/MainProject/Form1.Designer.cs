namespace MainProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.MainWindow = new HalconDotNet.HWindowControl();
            this.ProcedureTable = new System.Windows.Forms.DataGridView();
            this.MainWindowObjectTable = new System.Windows.Forms.DataGridView();
            this.PrcedureStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.插入程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).BeginInit();
            this.PrcedureStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.MainWindow.BackColor = System.Drawing.Color.Black;
            this.MainWindow.BorderColor = System.Drawing.Color.Black;
            this.MainWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.MainWindow.Location = new System.Drawing.Point(12, 41);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(801, 616);
            this.MainWindow.TabIndex = 0;
            this.MainWindow.WindowSize = new System.Drawing.Size(801, 616);
            // 
            // ProcedureTable
            // 
            this.ProcedureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcedureTable.Location = new System.Drawing.Point(1021, 41);
            this.ProcedureTable.Name = "ProcedureTable";
            this.ProcedureTable.RowTemplate.Height = 24;
            this.ProcedureTable.Size = new System.Drawing.Size(386, 616);
            this.ProcedureTable.TabIndex = 1;
            // 
            // MainWindowObjectTable
            // 
            this.MainWindowObjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainWindowObjectTable.Location = new System.Drawing.Point(819, 41);
            this.MainWindowObjectTable.Name = "MainWindowObjectTable";
            this.MainWindowObjectTable.RowTemplate.Height = 24;
            this.MainWindowObjectTable.Size = new System.Drawing.Size(196, 616);
            this.MainWindowObjectTable.TabIndex = 2;
            // 
            // PrcedureStrip
            // 
            this.PrcedureStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增程序ToolStripMenuItem,
            this.插入程序ToolStripMenuItem,
            this.刪除程序ToolStripMenuItem});
            this.PrcedureStrip.Name = "PrcedureStrip";
            this.PrcedureStrip.Size = new System.Drawing.Size(125, 70);
            // 
            // MainWindowStatusStrip
            // 
            this.MainWindowStatusStrip.Location = new System.Drawing.Point(0, 713);
            this.MainWindowStatusStrip.Name = "MainWindowStatusStrip";
            this.MainWindowStatusStrip.Size = new System.Drawing.Size(1419, 22);
            this.MainWindowStatusStrip.TabIndex = 4;
            this.MainWindowStatusStrip.Text = "MainWindowStatusStrip";
            // 
            // 插入程序ToolStripMenuItem
            // 
            this.插入程序ToolStripMenuItem.Name = "插入程序ToolStripMenuItem";
            this.插入程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.插入程序ToolStripMenuItem.Text = "插入程序";
            // 
            // 刪除程序ToolStripMenuItem
            // 
            this.刪除程序ToolStripMenuItem.Name = "刪除程序ToolStripMenuItem";
            this.刪除程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刪除程序ToolStripMenuItem.Text = "刪除程序";
            // 
            // 新增程序ToolStripMenuItem
            // 
            this.新增程序ToolStripMenuItem.Name = "新增程序ToolStripMenuItem";
            this.新增程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增程序ToolStripMenuItem.Text = "新增程序";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 735);
            this.Controls.Add(this.MainWindowStatusStrip);
            this.Controls.Add(this.MainWindowObjectTable);
            this.Controls.Add(this.ProcedureTable);
            this.Controls.Add(this.MainWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).EndInit();
            this.PrcedureStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl MainWindow;
        private System.Windows.Forms.DataGridView ProcedureTable;
        private System.Windows.Forms.DataGridView MainWindowObjectTable;
        private System.Windows.Forms.ContextMenuStrip PrcedureStrip;
        private System.Windows.Forms.StatusStrip MainWindowStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem 新增程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除程序ToolStripMenuItem;
    }
}

