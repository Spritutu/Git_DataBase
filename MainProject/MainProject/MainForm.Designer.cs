namespace MainProject
{
    partial class MainForm
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
            ST_Base.ImageBase imageBase2 = new ST_Base.ImageBase();
            this.ProcedureTable = new System.Windows.Forms.DataGridView();
            this.MainWindowObjectTable = new System.Windows.Forms.DataGridView();
            this.PrcedureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.插入程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一維測量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.建立匹配ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Object = new System.Windows.Forms.Label();
            this.Procedure = new System.Windows.Forms.Label();
            this.ObjectMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectXY = new System.Windows.Forms.Label();
            this.ProcedureXY = new System.Windows.Forms.Label();
            this.DO = new System.Windows.Forms.Button();
            this.toolWindow = new ToolWindow.ToolWindow();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.Camera_1 = new System.Windows.Forms.TabPage();
            this.Camera_2 = new System.Windows.Forms.TabPage();
            this.Camera_3 = new System.Windows.Forms.TabPage();
            this.Camera_4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).BeginInit();
            this.PrcedureMenuStrip.SuspendLayout();
            this.ObjectMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.Camera_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcedureTable
            // 
            this.ProcedureTable.AllowUserToResizeColumns = false;
            this.ProcedureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcedureTable.Location = new System.Drawing.Point(968, 25);
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
            this.MainWindowObjectTable.Location = new System.Drawing.Point(813, 25);
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
            this.PrcedureMenuStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // 插入程序ToolStripMenuItem
            // 
            this.插入程序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.載入圖片ToolStripMenuItem,
            this.一維測量ToolStripMenuItem,
            this.建立匹配ModelToolStripMenuItem});
            this.插入程序ToolStripMenuItem.Name = "插入程序ToolStripMenuItem";
            this.插入程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
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
            // 建立匹配ModelToolStripMenuItem
            // 
            this.建立匹配ModelToolStripMenuItem.Name = "建立匹配ModelToolStripMenuItem";
            this.建立匹配ModelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.建立匹配ModelToolStripMenuItem.Text = "建立匹配Model";
            this.建立匹配ModelToolStripMenuItem.Click += new System.EventHandler(this.建立匹配ModelToolStripMenuItem_Click);
            // 
            // 刪除程序ToolStripMenuItem
            // 
            this.刪除程序ToolStripMenuItem.Name = "刪除程序ToolStripMenuItem";
            this.刪除程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刪除程序ToolStripMenuItem.Text = "刪除程序";
            this.刪除程序ToolStripMenuItem.Click += new System.EventHandler(this.刪除程序ToolStripMenuItem_Click);
            // 
            // Object
            // 
            this.Object.AutoSize = true;
            this.Object.Location = new System.Drawing.Point(813, 10);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(35, 12);
            this.Object.TabIndex = 6;
            this.Object.Text = "Object";
            // 
            // Procedure
            // 
            this.Procedure.AutoSize = true;
            this.Procedure.Location = new System.Drawing.Point(966, 10);
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
            this.ObjectXY.Location = new System.Drawing.Point(854, 10);
            this.ObjectXY.Name = "ObjectXY";
            this.ObjectXY.Size = new System.Drawing.Size(52, 12);
            this.ObjectXY.TabIndex = 9;
            this.ObjectXY.Text = "(null,null)";
            // 
            // ProcedureXY
            // 
            this.ProcedureXY.AutoSize = true;
            this.ProcedureXY.Location = new System.Drawing.Point(1024, 10);
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
            // toolWindow
            // 
            this.toolWindow.Location = new System.Drawing.Point(6, 10);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.Size = new System.Drawing.Size(801, 684);
            this.toolWindow.TabIndex = 12;
            this.toolWindow.WindowImage = imageBase2;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.Camera_1);
            this.mainTabControl.Controls.Add(this.Camera_2);
            this.mainTabControl.Controls.Add(this.Camera_3);
            this.mainTabControl.Controls.Add(this.Camera_4);
            this.mainTabControl.Location = new System.Drawing.Point(12, 41);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1566, 726);
            this.mainTabControl.TabIndex = 13;
            // 
            // Camera_1
            // 
            this.Camera_1.Controls.Add(this.toolWindow);
            this.Camera_1.Controls.Add(this.MainWindowObjectTable);
            this.Camera_1.Controls.Add(this.ProcedureTable);
            this.Camera_1.Controls.Add(this.Procedure);
            this.Camera_1.Controls.Add(this.ProcedureXY);
            this.Camera_1.Controls.Add(this.Object);
            this.Camera_1.Controls.Add(this.ObjectXY);
            this.Camera_1.Location = new System.Drawing.Point(4, 22);
            this.Camera_1.Name = "Camera_1";
            this.Camera_1.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_1.Size = new System.Drawing.Size(1558, 700);
            this.Camera_1.TabIndex = 1;
            this.Camera_1.Text = "Camera No.1";
            this.Camera_1.UseVisualStyleBackColor = true;
            // 
            // Camera_2
            // 
            this.Camera_2.Location = new System.Drawing.Point(4, 22);
            this.Camera_2.Name = "Camera_2";
            this.Camera_2.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_2.Size = new System.Drawing.Size(1558, 700);
            this.Camera_2.TabIndex = 2;
            this.Camera_2.Text = "Camera No.2";
            this.Camera_2.UseVisualStyleBackColor = true;
            // 
            // Camera_3
            // 
            this.Camera_3.Location = new System.Drawing.Point(4, 22);
            this.Camera_3.Name = "Camera_3";
            this.Camera_3.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_3.Size = new System.Drawing.Size(1558, 700);
            this.Camera_3.TabIndex = 3;
            this.Camera_3.Text = "Camera No.3";
            this.Camera_3.UseVisualStyleBackColor = true;
            // 
            // Camera_4
            // 
            this.Camera_4.Location = new System.Drawing.Point(4, 22);
            this.Camera_4.Name = "Camera_4";
            this.Camera_4.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_4.Size = new System.Drawing.Size(1294, 636);
            this.Camera_4.TabIndex = 4;
            this.Camera_4.Text = "Camera No.4";
            this.Camera_4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1587, 781);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.DO);
            this.Name = "MainForm";
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).EndInit();
            this.PrcedureMenuStrip.ResumeLayout(false);
            this.ObjectMenuStrip.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.Camera_1.ResumeLayout(false);
            this.Camera_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProcedureTable;
        private System.Windows.Forms.DataGridView MainWindowObjectTable;
        private System.Windows.Forms.ContextMenuStrip PrcedureMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 插入程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除程序ToolStripMenuItem;
        private System.Windows.Forms.Label Object;
        private System.Windows.Forms.Label Procedure;
        private System.Windows.Forms.ContextMenuStrip ObjectMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label ObjectXY;
        private System.Windows.Forms.Label ProcedureXY;
        private System.Windows.Forms.ToolStripMenuItem 載入圖片ToolStripMenuItem;
        private System.Windows.Forms.Button DO;
        private System.Windows.Forms.ToolStripMenuItem 一維測量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建立匹配ModelToolStripMenuItem;
        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage Camera_1;
        private System.Windows.Forms.TabPage Camera_2;
        private System.Windows.Forms.TabPage Camera_3;
        private System.Windows.Forms.TabPage Camera_4;
    }
}

