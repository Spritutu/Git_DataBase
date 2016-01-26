namespace MainProject
{
    partial class MainFrom
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
            this.PrcedureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.插入程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一維測量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MouseXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pixelvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.Object = new System.Windows.Forms.Label();
            this.Procedure = new System.Windows.Forms.Label();
            this.ObjectMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectXY = new System.Windows.Forms.Label();
            this.ProcedureXY = new System.Windows.Forms.Label();
            this.DO = new System.Windows.Forms.Button();
            this.建立匹配ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).BeginInit();
            this.PrcedureMenuStrip.SuspendLayout();
            this.MainWindowStatusStrip.SuspendLayout();
            this.ObjectMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.MainWindow.BackColor = System.Drawing.Color.Black;
            this.MainWindow.BorderColor = System.Drawing.Color.Black;
            this.MainWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.MainWindow.Location = new System.Drawing.Point(12, 41);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(801, 669);
            this.MainWindow.TabIndex = 0;
            this.MainWindow.WindowSize = new System.Drawing.Size(801, 669);
            this.MainWindow.HMouseMove += new HalconDotNet.HMouseEventHandler(this.MainWindow_HMouseMove);
            // 
            // ProcedureTable
            // 
            this.ProcedureTable.AllowUserToResizeColumns = false;
            this.ProcedureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcedureTable.Location = new System.Drawing.Point(976, 41);
            this.ProcedureTable.Name = "ProcedureTable";
            this.ProcedureTable.ReadOnly = true;
            this.ProcedureTable.RowTemplate.Height = 24;
            this.ProcedureTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcedureTable.Size = new System.Drawing.Size(584, 669);
            this.ProcedureTable.TabIndex = 1;
            this.ProcedureTable.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.ProcedureTable_CellContextMenuStripNeeded);
            this.ProcedureTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcedureTable_CellDoubleClick);
            this.ProcedureTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProcedureTable_CellMouseMove);
            // 
            // MainWindowObjectTable
            // 
            this.MainWindowObjectTable.AllowUserToResizeColumns = false;
            this.MainWindowObjectTable.AllowUserToResizeRows = false;
            this.MainWindowObjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainWindowObjectTable.Location = new System.Drawing.Point(819, 41);
            this.MainWindowObjectTable.Name = "MainWindowObjectTable";
            this.MainWindowObjectTable.ReadOnly = true;
            this.MainWindowObjectTable.RowTemplate.Height = 24;
            this.MainWindowObjectTable.Size = new System.Drawing.Size(151, 669);
            this.MainWindowObjectTable.TabIndex = 2;
            this.MainWindowObjectTable.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.MainWindowObjectTable_CellContextMenuStripNeeded);
            this.MainWindowObjectTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainWindowObjectTable_CellDoubleClick);
            this.MainWindowObjectTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MainWindowObjectTable_CellMouseMove);
            // 
            // PrcedureMenuStrip
            // 
            this.PrcedureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入程序ToolStripMenuItem,
            this.刪除程序ToolStripMenuItem});
            this.PrcedureMenuStrip.Name = "PrcedureStrip";
            this.PrcedureMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // 插入程序ToolStripMenuItem
            // 
            this.插入程序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.載入圖片ToolStripMenuItem,
            this.一維測量ToolStripMenuItem,
            this.建立匹配ModelToolStripMenuItem});
            this.插入程序ToolStripMenuItem.Name = "插入程序ToolStripMenuItem";
            this.插入程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.插入程序ToolStripMenuItem.Text = "插入程序";
            // 
            // 載入圖片ToolStripMenuItem
            // 
            this.載入圖片ToolStripMenuItem.Name = "載入圖片ToolStripMenuItem";
            this.載入圖片ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.載入圖片ToolStripMenuItem.Text = "載入圖片";
            this.載入圖片ToolStripMenuItem.Click += new System.EventHandler(this.載入圖片ToolStripMenuItem_Click);
            // 
            // 一維測量ToolStripMenuItem
            // 
            this.一維測量ToolStripMenuItem.Name = "一維測量ToolStripMenuItem";
            this.一維測量ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.一維測量ToolStripMenuItem.Text = "一維測量";
            this.一維測量ToolStripMenuItem.Click += new System.EventHandler(this.一維測量ToolStripMenuItem_Click);
            // 
            // 刪除程序ToolStripMenuItem
            // 
            this.刪除程序ToolStripMenuItem.Name = "刪除程序ToolStripMenuItem";
            this.刪除程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.刪除程序ToolStripMenuItem.Text = "刪除程序";
            this.刪除程序ToolStripMenuItem.Click += new System.EventHandler(this.刪除程序ToolStripMenuItem_Click);
            // 
            // MainWindowStatusStrip
            // 
            this.MainWindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MouseXY,
            this.pixelvalue});
            this.MainWindowStatusStrip.Location = new System.Drawing.Point(0, 713);
            this.MainWindowStatusStrip.Name = "MainWindowStatusStrip";
            this.MainWindowStatusStrip.Size = new System.Drawing.Size(1570, 22);
            this.MainWindowStatusStrip.TabIndex = 4;
            this.MainWindowStatusStrip.Text = "MainWindowStatusStrip";
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
            // Object
            // 
            this.Object.AutoSize = true;
            this.Object.Location = new System.Drawing.Point(819, 23);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(35, 12);
            this.Object.TabIndex = 6;
            this.Object.Text = "Object";
            // 
            // Procedure
            // 
            this.Procedure.AutoSize = true;
            this.Procedure.Location = new System.Drawing.Point(974, 23);
            this.Procedure.Name = "Procedure";
            this.Procedure.Size = new System.Drawing.Size(52, 12);
            this.Procedure.TabIndex = 7;
            this.Procedure.Text = "Procedure";
            // 
            // ObjectMenuStrip
            // 
            this.ObjectMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.ObjectMenuStrip.Name = "PrcedureStrip";
            this.ObjectMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem3.Text = "顯示";
            // 
            // ObjectXY
            // 
            this.ObjectXY.AutoSize = true;
            this.ObjectXY.Location = new System.Drawing.Point(860, 23);
            this.ObjectXY.Name = "ObjectXY";
            this.ObjectXY.Size = new System.Drawing.Size(52, 12);
            this.ObjectXY.TabIndex = 9;
            this.ObjectXY.Text = "(null,null)";
            // 
            // ProcedureXY
            // 
            this.ProcedureXY.AutoSize = true;
            this.ProcedureXY.Location = new System.Drawing.Point(1032, 23);
            this.ProcedureXY.Name = "ProcedureXY";
            this.ProcedureXY.Size = new System.Drawing.Size(52, 12);
            this.ProcedureXY.TabIndex = 10;
            this.ProcedureXY.Text = "(null,null)";
            // 
            // DO
            // 
            this.DO.Location = new System.Drawing.Point(12, 12);
            this.DO.Name = "DO";
            this.DO.Size = new System.Drawing.Size(75, 23);
            this.DO.TabIndex = 11;
            this.DO.Text = "DO";
            this.DO.UseVisualStyleBackColor = true;
            this.DO.Click += new System.EventHandler(this.DO_Click);
            // 
            // 建立匹配ModelToolStripMenuItem
            // 
            this.建立匹配ModelToolStripMenuItem.Name = "建立匹配ModelToolStripMenuItem";
            this.建立匹配ModelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.建立匹配ModelToolStripMenuItem.Text = "建立匹配Model";
            this.建立匹配ModelToolStripMenuItem.Click += new System.EventHandler(this.建立匹配ModelToolStripMenuItem_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 735);
            this.Controls.Add(this.DO);
            this.Controls.Add(this.ProcedureXY);
            this.Controls.Add(this.ObjectXY);
            this.Controls.Add(this.Procedure);
            this.Controls.Add(this.Object);
            this.Controls.Add(this.MainWindowStatusStrip);
            this.Controls.Add(this.MainWindowObjectTable);
            this.Controls.Add(this.ProcedureTable);
            this.Controls.Add(this.MainWindow);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).EndInit();
            this.PrcedureMenuStrip.ResumeLayout(false);
            this.MainWindowStatusStrip.ResumeLayout(false);
            this.MainWindowStatusStrip.PerformLayout();
            this.ObjectMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl MainWindow;
        private System.Windows.Forms.DataGridView ProcedureTable;
        private System.Windows.Forms.DataGridView MainWindowObjectTable;
        private System.Windows.Forms.ContextMenuStrip PrcedureMenuStrip;
        private System.Windows.Forms.StatusStrip MainWindowStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem 插入程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除程序ToolStripMenuItem;
        private System.Windows.Forms.Label Object;
        private System.Windows.Forms.Label Procedure;
        private System.Windows.Forms.ContextMenuStrip ObjectMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label ObjectXY;
        private System.Windows.Forms.Label ProcedureXY;
        private System.Windows.Forms.ToolStripStatusLabel MouseXY;
        private System.Windows.Forms.ToolStripStatusLabel pixelvalue;
        private System.Windows.Forms.ToolStripMenuItem 載入圖片ToolStripMenuItem;
        private System.Windows.Forms.Button DO;
        private System.Windows.Forms.ToolStripMenuItem 一維測量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建立匹配ModelToolStripMenuItem;
    }
}

