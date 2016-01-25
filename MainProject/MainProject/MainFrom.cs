using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using HalconDotNet;//測試用 不應該存在於使用者介面

enum procedure_M { readimage = 1 ,test};

namespace MainProject
{
    public partial class MainFrom : Form
    {
        #region //介面參數
        //相機陣列
         List<Camera_Table> Camrea = new List<Camera_Table>();

        private ImageBase window_image = new ImageBase();
        PointBase mousePosition_pre = new PointBase();
        PointBase mousePosition = new PointBase();

        #endregion

        #region //介面雜亂功能
        public MainFrom()
        {
            InitializeComponent();
        }
        private void MainWindowObjectTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ObjectXY.Text = "(" + e.ColumnIndex + "," + e.RowIndex + ")";
        }
        private void ProcedureTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProcedureXY.Text = "(" + e.ColumnIndex + "," + e.RowIndex + ")";
        }
        private void MainWindow_HMouseMove(object sender, HMouseEventArgs e)
        {
            mousePosition.GetMposition(MainWindow.HalconWindow);
            MouseXY.Text = "Mouse(" + mousePosition.col.ToString() + "," + mousePosition.row.ToString() + ")";
            pixelvalue.Text = "pixelvalue =" + window_image.PiexlGrayval(mousePosition).ToString();

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCamrea(1);
            BindProcedureToGrid(ProcedureTable,0);
            BindObjectToGrid(MainWindowObjectTable,0);
        }

        /// <summary>
        /// 創造一台相機。
        /// </summary>
        private void CreateCamrea(int camreanum) {

            for (int i = 0; i < camreanum; i++)
            {
                Camrea.Add(new Camera_Table());
                Camrea[Camrea.Count - 1].Object.Add(new Object_Table());
                Camrea[Camrea.Count - 1].Procedure.Add(new Procedure_Table());
            }
        }

        /// <summary>
        /// 將Procedure表格綁定。
        /// </summary>
        /// <param name="Table">Procedure table。</param>
        private void BindProcedureToGrid(DataGridView Table,int whichcamera)
        {
            Table.DataSource = Camrea[whichcamera].Procedure;
            Table.Columns[0].Width = 35;//設定列寬
            Table.Columns[0].Resizable = DataGridViewTriState.False;
            Table.Columns[1].Width = 300;//設定列寬
        }
        /// <summary>
        /// 將Object表格綁定。
        /// </summary>
        /// <param name="Table">Object table。</param>
        private void BindObjectToGrid(DataGridView Table, int whichcamera)
        {
            string str = System.Windows.Forms.Application.StartupPath;
            List<MiniImage_Table> L = new List<MiniImage_Table>();

            for (int i = 0; i < Camrea[whichcamera].Object.Count; i++)
            {
                if (Camrea[whichcamera].Object[i].Image != null)
                {
                    MiniImage_Table mini = new MiniImage_Table();
                    mini.Object2minipicture(Camrea[whichcamera].Object[i].Image);
                    L.Add(mini);
                }
            }

            Table.DataSource = L;//繫結到圖片集合
            Table.Columns[0].HeaderText = "圖片";//設定列文字
            Table.Columns[0].Width =100;//設定列寬度
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

            DataGridView dgv = (DataGridView)sender;
            dgv.ClearSelection();
            dgv.Rows[e.RowIndex].Selected = true;
            
            CurrencyManager cm = (CurrencyManager)this.BindingContext[Camrea[0].Procedure];
            cm.Position = e.RowIndex;

            if (e.RowIndex < 0)
            {
                
            }
            else if (e.ColumnIndex < 0)
            {

            }
            else
            {
                e.ContextMenuStrip = this.PrcedureMenuStrip;
            }
        }
        /// <summary>
        /// 設定MainWindowObjectTable的左鍵表單
        /// </summary>
        private void MainWindowObjectTable_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.ClearSelection();
            dgv.Rows[e.RowIndex].Selected = true;

            CurrencyManager cm = (CurrencyManager)this.BindingContext[Camrea[0].Object];
            cm.Position = e.RowIndex;

            if (e.RowIndex < 0)
            {
                
            }
            else if (e.ColumnIndex < 0)
            {

            }
            else
            {
                e.ContextMenuStrip = this.ObjectMenuStrip;
            }
        }
        

        private void 刪除程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];

            Camrea[0].Procedure.RemoveAt(cm.Position);
            Camrea[0].Object.RemoveAt(cm.Position);

            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                Camrea[0].Procedure[i].Num = i;
            }

            if (cm != null)
            {
                cm.Refresh();
                ProcedureTable.ClearSelection();
                ProcedureTable.Rows[cm.Position].Selected = true;
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

            Camrea[0].Procedure.Insert(cm.Position + 1, p);
            Camrea[0].Object.Insert(cm.Position + 1, O);
            clk++;

            //重新排序Procedure編號
            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                Camrea[0].Procedure[i].Num = i;
            }
            
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

            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                if (Camrea[0].Procedure[i].Setornot == false)
                {
                    ProcedureTable.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }

        }
        
        private void DO_Click(object sender, EventArgs e)
        {
            bool whethersettedornot =true;
            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                if (Camrea[0].Procedure[i].Setornot == false) {
                    whethersettedornot = false;
                }
            }

            if (whethersettedornot == true)
            {
                for (int i = 0; i < Camrea[0].Procedure.Count; i++)
                {
                    Camrea[0].Procedure[i].procedurefunction.dofunction();
                }
                BindObjectToGrid(MainWindowObjectTable, 0);
            }
            else
                MessageBox.Show("還有參數沒有設定喔");
        }

        private void MainWindowObjectTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[MainWindowObjectTable.DataSource];
            ImageBase imgbs = new ImageBase();
            List<Object_Table> O_temp = new List<Object_Table>();

            for (int i = 0; i < Camrea[0].Object.Count; i++)
            {
                if (Camrea[0].Object[i].Image != null)
                {
                    O_temp.Add(Camrea[0].Object[i]);
                }
            }


            imgbs.SetImage = O_temp[cm.Position].Image;


            imgbs.ShowImage_autosize(MainWindow.HalconWindow);
            window_image = imgbs;

        }

        private void ProcedureTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            Procedure_Table p = new Procedure_Table();

            switch (Camrea[0].Procedure[cm.Position].ProcedureMethod)
            {
                case (int)procedure_M.readimage:
                    //載入圖片函式
                    AccessImage readthefuckingimage = new AccessImage();
                    //由檔案載入圖片
                    readthefuckingimage.ImagefromFile();
                    //設定顯示視窗
                    readthefuckingimage.setwindow(MainWindow.HalconWindow);

                    if (readthefuckingimage.getObject().Image != null)
                    {
                        p.procedurefunction.doprocedurefunction += readthefuckingimage.show;
                        Camrea[0].Object[cm.Position] = readthefuckingimage.getObject();
                        Camrea[0].Procedure[cm.Position].Setornot = true;
                    }
                    break;
                case (int)procedure_M.test:
                    Camrea[0].Procedure[cm.Position].SettingForm.ShowDialog();
                    Camrea[0].Procedure[cm.Position].Setornot = true;
                    break;
                    
            }
            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                if (Camrea[0].Procedure[i].Setornot == false)
                {
                    ProcedureTable.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
                else if (Camrea[0].Procedure[i].Setornot == true)
                {
                    ProcedureTable.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }


        }

        private void 建立ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "creatMatchModel";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.test;
            
            Camrea[0].Procedure.Insert(cm.Position + 1, p);
            Camrea[0].Object.Insert(cm.Position + 1, O);
            Measure M = new Measure();
            M.MeasureImage = Camrea[0].Object[1].Image;
            p.SettingForm = M;

            //重新排序Procedure編號
            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                Camrea[0].Procedure[i].Num = i;
            }

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

            for (int i = 0; i < Camrea[0].Procedure.Count; i++)
            {
                if (Camrea[0].Procedure[i].Setornot == false)
                {
                    ProcedureTable.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }

        }
    }
}
