﻿namespace CameraProcedure
{
    partial class CameraProcedure
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
            this.components = new System.ComponentModel.Container();
            ST_Base.ImageBase imageBase1 = new ST_Base.ImageBase();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraProcedure));
            this.toolWindow = new ToolWindow.ToolWindow();
            this.ProcedureTable = new System.Windows.Forms.DataGridView();
            this.PrcedureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.插入程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相機ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一維測量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二維量測LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二維量測ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.建立匹配ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中垂線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.兩點距離ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).BeginInit();
            this.PrcedureMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolWindow
            // 
            this.toolWindow.Location = new System.Drawing.Point(3, 3);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.Size = new System.Drawing.Size(738, 717);
            this.toolWindow.TabIndex = 0;
            this.toolWindow.WindowImage = imageBase1;
            // 
            // ProcedureTable
            // 
            this.ProcedureTable.AllowUserToResizeColumns = false;
            this.ProcedureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcedureTable.Location = new System.Drawing.Point(747, 66);
            this.ProcedureTable.Name = "ProcedureTable";
            this.ProcedureTable.ReadOnly = true;
            this.ProcedureTable.RowTemplate.Height = 24;
            this.ProcedureTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcedureTable.Size = new System.Drawing.Size(584, 654);
            this.ProcedureTable.TabIndex = 4;
            this.ProcedureTable.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.ProcedureTable_CellContextMenuStripNeeded);
            this.ProcedureTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcedureTable_CellDoubleClick);
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
            this.相機ToolStripMenuItem,
            this.載入圖片ToolStripMenuItem,
            this.一維測量ToolStripMenuItem,
            this.二維量測LineToolStripMenuItem,
            this.二維量測ToolStripMenuItem,
            this.建立匹配ModelToolStripMenuItem,
            this.中垂線ToolStripMenuItem,
            this.兩點距離ToolStripMenuItem});
            this.插入程序ToolStripMenuItem.Name = "插入程序ToolStripMenuItem";
            this.插入程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.插入程序ToolStripMenuItem.Text = "插入程序";
            // 
            // 相機ToolStripMenuItem
            // 
            this.相機ToolStripMenuItem.Name = "相機ToolStripMenuItem";
            this.相機ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.相機ToolStripMenuItem.Text = "相機";
            this.相機ToolStripMenuItem.Click += new System.EventHandler(this.相機ToolStripMenuItem_Click);
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
            // 二維量測LineToolStripMenuItem
            // 
            this.二維量測LineToolStripMenuItem.Name = "二維量測LineToolStripMenuItem";
            this.二維量測LineToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.二維量測LineToolStripMenuItem.Text = "二維量測_Line";
            this.二維量測LineToolStripMenuItem.Click += new System.EventHandler(this.二維量測LineToolStripMenuItem_Click);
            // 
            // 二維量測ToolStripMenuItem
            // 
            this.二維量測ToolStripMenuItem.Name = "二維量測ToolStripMenuItem";
            this.二維量測ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.二維量測ToolStripMenuItem.Text = "二維量測_Circle";
            this.二維量測ToolStripMenuItem.Click += new System.EventHandler(this.二維量測circleToolStripMenuItem_Click);
            // 
            // 建立匹配ModelToolStripMenuItem
            // 
            this.建立匹配ModelToolStripMenuItem.Name = "建立匹配ModelToolStripMenuItem";
            this.建立匹配ModelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.建立匹配ModelToolStripMenuItem.Text = "建立匹配Model";
            this.建立匹配ModelToolStripMenuItem.Click += new System.EventHandler(this.建立匹配ModelToolStripMenuItem_Click);
            // 
            // 中垂線ToolStripMenuItem
            // 
            this.中垂線ToolStripMenuItem.Name = "中垂線ToolStripMenuItem";
            this.中垂線ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.中垂線ToolStripMenuItem.Text = "中垂線";
            this.中垂線ToolStripMenuItem.Click += new System.EventHandler(this.中垂線ToolStripMenuItem_Click);
            // 
            // 兩點距離ToolStripMenuItem
            // 
            this.兩點距離ToolStripMenuItem.Name = "兩點距離ToolStripMenuItem";
            this.兩點距離ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.兩點距離ToolStripMenuItem.Text = "點線距離";
            this.兩點距離ToolStripMenuItem.Click += new System.EventHandler(this.兩點距離ToolStripMenuItem_Click);
            // 
            // 刪除程序ToolStripMenuItem
            // 
            this.刪除程序ToolStripMenuItem.Name = "刪除程序ToolStripMenuItem";
            this.刪除程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刪除程序ToolStripMenuItem.Text = "刪除程序";
            this.刪除程序ToolStripMenuItem.Click += new System.EventHandler(this.刪除程序ToolStripMenuItem_Click);
            // 
            // startButton
            // 
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(747, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 60);
            this.startButton.TabIndex = 10;
            this.startButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(813, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // CameraProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ProcedureTable);
            this.Controls.Add(this.toolWindow);
            this.Name = "CameraProcedure";
            this.Size = new System.Drawing.Size(1342, 733);
            this.Load += new System.EventHandler(this.CameraProcedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).EndInit();
            this.PrcedureMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolWindow.ToolWindow toolWindow;
        private System.Windows.Forms.DataGridView ProcedureTable;
        private System.Windows.Forms.ContextMenuStrip PrcedureMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 插入程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 載入圖片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一維測量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建立匹配ModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除程序ToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ToolStripMenuItem 二維量測ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二維量測LineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中垂線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 兩點距離ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 相機ToolStripMenuItem;
    }
}
