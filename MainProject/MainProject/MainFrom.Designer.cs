﻿namespace MainProject
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
            this.新增程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.Object = new System.Windows.Forms.Label();
            this.Procedure = new System.Windows.Forms.Label();
            this.ObjectMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectXY = new System.Windows.Forms.Label();
            this.ProcedureXY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).BeginInit();
            this.PrcedureMenuStrip.SuspendLayout();
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
            // 
            // ProcedureTable
            // 
            this.ProcedureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcedureTable.Location = new System.Drawing.Point(1021, 41);
            this.ProcedureTable.Name = "ProcedureTable";
            this.ProcedureTable.RowTemplate.Height = 24;
            this.ProcedureTable.Size = new System.Drawing.Size(386, 669);
            this.ProcedureTable.TabIndex = 1;
            this.ProcedureTable.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.ProcedureTable_CellContextMenuStripNeeded);
            this.ProcedureTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProcedureTable_CellMouseMove);
            // 
            // MainWindowObjectTable
            // 
            this.MainWindowObjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainWindowObjectTable.Location = new System.Drawing.Point(819, 41);
            this.MainWindowObjectTable.Name = "MainWindowObjectTable";
            this.MainWindowObjectTable.RowTemplate.Height = 24;
            this.MainWindowObjectTable.Size = new System.Drawing.Size(196, 669);
            this.MainWindowObjectTable.TabIndex = 2;
            this.MainWindowObjectTable.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.MainWindowObjectTable_CellContextMenuStripNeeded);
            this.MainWindowObjectTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MainWindowObjectTable_CellMouseMove);
            // 
            // PrcedureMenuStrip
            // 
            this.PrcedureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增程序ToolStripMenuItem,
            this.插入程序ToolStripMenuItem,
            this.刪除程序ToolStripMenuItem});
            this.PrcedureMenuStrip.Name = "PrcedureStrip";
            this.PrcedureMenuStrip.Size = new System.Drawing.Size(125, 70);
            // 
            // 新增程序ToolStripMenuItem
            // 
            this.新增程序ToolStripMenuItem.Name = "新增程序ToolStripMenuItem";
            this.新增程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增程序ToolStripMenuItem.Text = "新增程序";
            this.新增程序ToolStripMenuItem.Click += new System.EventHandler(this.新增程序ToolStripMenuItem_Click);
            // 
            // 插入程序ToolStripMenuItem
            // 
            this.插入程序ToolStripMenuItem.Name = "插入程序ToolStripMenuItem";
            this.插入程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.插入程序ToolStripMenuItem.Text = "插入程序";
            this.插入程序ToolStripMenuItem.Click += new System.EventHandler(this.插入程序ToolStripMenuItem_Click);
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
            this.MainWindowStatusStrip.Location = new System.Drawing.Point(0, 713);
            this.MainWindowStatusStrip.Name = "MainWindowStatusStrip";
            this.MainWindowStatusStrip.Size = new System.Drawing.Size(1419, 22);
            this.MainWindowStatusStrip.TabIndex = 4;
            this.MainWindowStatusStrip.Text = "MainWindowStatusStrip";
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
            this.Procedure.Location = new System.Drawing.Point(1019, 23);
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
            this.ProcedureXY.Location = new System.Drawing.Point(1077, 23);
            this.ProcedureXY.Name = "ProcedureXY";
            this.ProcedureXY.Size = new System.Drawing.Size(52, 12);
            this.ProcedureXY.TabIndex = 10;
            this.ProcedureXY.Text = "(null,null)";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 735);
            this.Controls.Add(this.ProcedureXY);
            this.Controls.Add(this.ObjectXY);
            this.Controls.Add(this.Procedure);
            this.Controls.Add(this.Object);
            this.Controls.Add(this.MainWindowStatusStrip);
            this.Controls.Add(this.MainWindowObjectTable);
            this.Controls.Add(this.ProcedureTable);
            this.Controls.Add(this.MainWindow);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcedureTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowObjectTable)).EndInit();
            this.PrcedureMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem 新增程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除程序ToolStripMenuItem;
        private System.Windows.Forms.Label Object;
        private System.Windows.Forms.Label Procedure;
        private System.Windows.Forms.ContextMenuStrip ObjectMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label ObjectXY;
        private System.Windows.Forms.Label ProcedureXY;
    }
}

