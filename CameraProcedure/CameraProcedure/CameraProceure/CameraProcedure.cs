﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST_Base;

namespace CameraProcedure
{
    enum procedure_M { readimage = 1, Measure , CreateMatchingModel };
    public partial class CameraProcedure : UserControl
    {
        private Camera_Table Camera = new Camera_Table();
        //主視窗圖片(ImageBase)
        private ImageBase window_image = new ImageBase();
        //視窗滑鼠位置
        private PointBase mousePosition = new PointBase();

        public CameraProcedure()
        {
            InitializeComponent();
        }

        private void CameraProcedure_Load(object sender, EventArgs e)
        {
            //創造幾台相機
            CreateCamrea();
            //第幾台相機綁定Procedure表單
            BindProcedureToGrid(ProcedureTable);
            //第幾台相機綁定Object表單
            BindObjectToGrid(MainWindowObjectTable);
        }
        /// <summary>
        /// 創造一台相機。
        /// </summary>
        ///  <param name="camreanum">創造幾台相機。</param>
        private void CreateCamrea()
        {
            //新增相機裡的Procedure和Object
            Camera.Object.Add(new Object_Table());
            Camera.Procedure.Add(new Procedure_Table());
        }

        /// <summary>
        /// 將Procedure表格綁定。
        /// </summary>
        /// <param name="Table">Procedure table。</param>
        /// <param name="whichcamera">第幾台相機。</param>
        private void BindProcedureToGrid(DataGridView Table)
        {
            //表格物件
            Table.DataSource = Camera.Procedure;
            //設定列寬
            Table.Columns[0].Width = 35;
            //設定Columns可不可以由使用者移動
            Table.Columns[0].Resizable = DataGridViewTriState.False;
            //設定行寬
            Table.Columns[1].Width = 300;
        }


        /// <summary>
        /// 將Object表格綁定。
        /// </summary>
        /// <param name="Table">Object table。</param>
        private void BindObjectToGrid(DataGridView Table)
        {
            //縮圖列表 miniImage_Tabl
            List<MiniImage_Table> miniImage_Tabl = new List<MiniImage_Table>();

            //綁定指定Camera裡面的Object至miniImage_Tabl並且轉換成縮圖 100X100
            for (int i = 0; i < Camera.Object.Count; i++)
            {
                if (Camera.Object[i].Image != null)
                {
                    MiniImage_Table mini = new MiniImage_Table();
                    mini.Object2minipicture(Camera.Object[i].Image);
                    miniImage_Tabl.Add(mini);
                }
            }

            //表格物件
            Table.DataSource = miniImage_Tabl;//繫結到圖片集合
            //Columns[0]的標頭文字
            Table.Columns[0].HeaderText = "圖片";//設定列文字
            //設定行寬
            Table.Columns[0].Width = 100;//設定列寬度
            //設定列高
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Table.Rows[i].Height = 100;//設定行高度
            }
        }

        /// <summary>
        /// 設定ProcedureTable的左鍵表單
        /// </summary>
        private void ProcedureTable_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            //將object sender轉換成 DataGridView dgv
            DataGridView dgv = (DataGridView)sender;
            //清除選項
            dgv.ClearSelection();
            //選擇一整列
            dgv.Rows[e.RowIndex].Selected = true;

            //表單控制項(現在選在哪一格上)
            CurrencyManager cm = (CurrencyManager)this.BindingContext[Camera.Procedure];
            //滑鼠的row傳給cm 顯示控制
            cm.Position = e.RowIndex;

            if (e.RowIndex < 0 && e.ColumnIndex > 0)
            {
                //表單標頭備用
            }
            else if (e.ColumnIndex < 0 && e.RowIndex > 0)
            {
                //表單標頭備用
            }
            else
            {
                //右鍵Prcedure表單
                e.ContextMenuStrip = this.PrcedureMenuStrip;
            }
        }
        /// <summary>
        /// 設定MainWindowObjectTable的左鍵表單
        /// </summary>
        private void MainWindowObjectTable_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            //將object sender轉換成 DataGridView dgv
            DataGridView dgv = (DataGridView)sender;
            //清除選項
            dgv.ClearSelection();
            //選擇一整列
            dgv.Rows[e.RowIndex].Selected = true;

            //表單控制項(現在選在哪一格上)
            CurrencyManager cm = (CurrencyManager)this.BindingContext[Camera.Object];
            //滑鼠的row傳給cm 顯示控制
            cm.Position = e.RowIndex;

            if (e.RowIndex < 0)
            {
                //表單標頭備用
            }
            else if (e.ColumnIndex < 0)
            {
                //表單標頭備用
            }
            else
            {
                //右鍵Object表單
                e.ContextMenuStrip = this.ObjectMenuStrip;
            }
        }

        /// <summary>
        /// 刪除程序
        /// </summary>
        private void 刪除程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //表單控制項(現在選在哪一格上)
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //Remove cm 所選擇的那格 包含裡面的物件(Object & Procedure)
            Camera.Procedure.RemoveAt(cm.Position);
            Camera.Object.RemoveAt(cm.Position);

            remarkProcedure(0);

            if (cm != null)
            {
                cm.Refresh();
                ProcedureTable.ClearSelection();
                ProcedureTable.Rows[cm.Position].Selected = true;
            }
            setProcedurecolor();
        }
        /// <summary>
        /// 重新編號Procedure表格
        /// </summary>
        private void remarkProcedure(int camera)
        {

            for (int i = 0; i < Camera.Procedure.Count; i++)
            {
                Camera.Procedure[i].Num = i;
            }
        }

        int clk = 0;//載入圖片序數
        private void 載入圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();
            p.ProcedureName = "載入圖片" + clk;
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.readimage;
            

            Camera.Procedure.Insert(cm.Position + 1, p);
            Camera.Object.Insert(cm.Position + 1, O);
            clk++;

            //重新排序Procedure編號
            remarkProcedure(0);

            //更新表格
            if (cm != null)
            {
                //更新表單(會將所有設定清除....)
                cm.Refresh();

                //新增之後將cm移至新增的項目上
                ProcedureTable.ClearSelection();
                if (ProcedureTable.RowCount < cm.Position + 1)
                {
                    ProcedureTable.Rows[cm.Position + 1].Selected = true;
                }
                else
                {
                    ProcedureTable.Rows[cm.Position].Selected = true;
                }
            }
            //設定Procedurecolor 依照是否已經設定好參數
            setProcedurecolor();

        }
        /// <summary>
        /// 設定ProcedureTable是否設定的顏色(Setornot)
        /// </summary>
        private void setProcedurecolor()
        {
            for (int i = 0; i < Camera.Procedure.Count; i++)
            {
                if (Camera.Procedure[i].Setornot == false)
                {
                    ProcedureTable.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
                else if (Camera.Procedure[i].Setornot == true)
                {
                    ProcedureTable.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void 一維測量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "Measure";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.Measure;
            p.SettingForm = new Measure();
            


            Camera.Procedure.Insert(cm.Position + 1, p);
            Camera.Object.Insert(cm.Position + 1, O);

            //重新排序Procedure編號
            remarkProcedure(0);

            //更新表格
            if (cm != null)
            {
                cm.Refresh();
                ProcedureTable.ClearSelection();

                if (ProcedureTable.RowCount < cm.Position + 1)
                {
                    ProcedureTable.Rows[cm.Position + 1].Selected = true;
                }
                else
                {
                    ProcedureTable.Rows[cm.Position].Selected = true;
                }
            }

            setProcedurecolor();

        }
        private void 建立匹配ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "CreateMatchingModel";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.CreateMatchingModel;
            p.SettingForm = new CreateMatchingModel();

            Camera.Procedure.Insert(cm.Position + 1, p);
            Camera.Object.Insert(cm.Position + 1, O);

            //重新排序Procedure編號
            remarkProcedure(0);

            //更新表格
            if (cm != null)
            {
                cm.Refresh();
                ProcedureTable.ClearSelection();

                if (ProcedureTable.RowCount < cm.Position + 1)
                {
                    ProcedureTable.Rows[cm.Position + 1].Selected = true;
                }
                else
                {
                    ProcedureTable.Rows[cm.Position].Selected = true;
                }
            }

            setProcedurecolor();
        }

        private void ProcedureTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            Procedure_Table p = new Procedure_Table();

            switch (Camera.Procedure[cm.Position].ProcedureMethod)
            {
                case (int)procedure_M.readimage:

                    //載入圖片函式
                    AccessImage readthefuckingimage = new AccessImage();
                    //由檔案載入圖片
                    readthefuckingimage.ImagefromFile();
                    //設定顯示視窗
                    //readthefuckingimage.setwindow(MainWindow.HalconWindow);

                    if (readthefuckingimage.getObject().Image != null)
                    {
                        p.procedurefunction.doprocedurefunction += readthefuckingimage.show;
                        Camera.Object[cm.Position] = readthefuckingimage.getObject();
                        Camera.Procedure[cm.Position].Setornot = true;
                    }
                    break;

                case (int)procedure_M.Measure:

                    Measure M_temp = (Measure)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        M_temp.MeasureImage = Camera.Object[cm.Position - 1].Image;           //暫時使用前一個程序的圖片(載入圖片)
                        
                    }

                    M_temp.ShowDialog();
                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += M_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = M_temp;
                    Camera.Procedure[cm.Position].Setornot = M_temp.setornot;

                    break;

                case (int)procedure_M.CreateMatchingModel:

                    CreateMatchingModel C_temp = (CreateMatchingModel)Camera.Procedure[cm.Position].SettingForm;
                    //if (cm.Position != 0)
                    //{
                    //    C_temp.MeasureImage = Camera[0].Object[cm.Position - 1].Image;
                    //}
                    C_temp.ShowDialog();

                    C_temp = (CreateMatchingModel)Camera.Procedure[cm.Position].SettingForm;
                    Camera.Procedure[cm.Position].Setornot = C_temp.setornot;

                    break;


            }
            setProcedurecolor();


        }

        private void MainWindowObjectTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[MainWindowObjectTable.DataSource];
            ImageBase imgbs = new ImageBase();
            List<Object_Table> O_temp = new List<Object_Table>();

            for (int i = 0; i < Camera.Object.Count; i++)
            {
                if (Camera.Object[i].Image != null)
                {
                    O_temp.Add(Camera.Object[i]);
                }
            }
            imgbs.SetImage = O_temp[cm.Position].Image;
            toolWindow.WindowImage = imgbs;
            toolWindow.showImage();
            window_image = imgbs;
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {

            bool whethersettedornot = true;
            for (int i = 0; i < Camera.Procedure.Count; i++)
            {
                if (Camera.Procedure[i].Setornot == false)
                {
                    whethersettedornot = false;
                }
            }

            if (whethersettedornot == true)
            {
                for (int i = 0; i < Camera.Procedure.Count; i++)
                {
                    Camera.Procedure[i].procedurefunction.dofunction();
                }
                BindObjectToGrid(MainWindowObjectTable);
            }

            else
                MessageBox.Show("還有參數沒有設定喔");
        }
    }
}
