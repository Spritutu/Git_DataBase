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

namespace MainProject
{
    public partial class MainFrom : Form
    {


        //相機陣列
        private ArrayList Camrea = new ArrayList();


        public MainFrom()
        {
            InitializeComponent();
        }

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
                Camrea.Add(new MainWindowObject());

                MainWindowObject mwo;
                mwo = (MainWindowObject)Camrea[Camrea.Count - 1];

                mwo.Object.Add(new Object());
                mwo.Procedure.Add(new procedure());
                Camrea[Camrea.Count - 1] = mwo;
            }
        }

        /// <summary>
        /// 將Procedure表格綁定。
        /// </summary>
        /// <param name="Table">Procedure table。</param>
        private void BindProcedureToGrid(DataGridView Table,int whichcamera)
        {
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[whichcamera];
            Table.DataSource = mwo.Procedure;
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
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[whichcamera];
            Table.DataSource = mwo.Object;
            Table.Columns[0].Width = 100;//設定列寬
        }

        private void ProcedureTable_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.ClearSelection();
            dgv.Rows[e.RowIndex].Selected = true;

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];

            CurrencyManager cm = (CurrencyManager)this.BindingContext[mwo.Procedure];
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

        private void MainWindowObjectTable_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.ClearSelection();
            dgv.Rows[e.RowIndex].Selected = true;

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];

            CurrencyManager cm = (CurrencyManager)this.BindingContext[mwo.Object];
            cm.Position = e.RowIndex;

            if (e.RowIndex < 0)
            {
                int abd;
            }
            else if (e.ColumnIndex < 0)
            {

            }
            else
            {
                e.ContextMenuStrip = this.ObjectMenuStrip;
            }
        }

        private void MainWindowObjectTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ObjectXY.Text = "(" + e.ColumnIndex + "," + e.RowIndex + ")";
        }

        private void ProcedureTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProcedureXY.Text = "(" + e.ColumnIndex + "," + e.RowIndex + ")";
        }

        private void 新增程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 刪除程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];
            mwo.Procedure.RemoveAt(cm.Position);
            procedure p = new procedure();

            for (int i = 0; i < mwo.Procedure.Count; i++)
            {

                p = (procedure)mwo.Procedure[i];
                p.Num = i;
                mwo.Procedure[i] = p;
            }

            if (cm != null)
            {
                cm.Refresh();
            }
        }

        private void 插入程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];
            procedure p = new procedure();

            mwo.Procedure.Insert(cm.Position + 1, p);
            
            for (int i = 0; i < mwo.Procedure.Count; i++)
            {

                p = (procedure)mwo.Procedure[i];
                p.Num = i;
                mwo.Procedure[i] = p;
            }

            if (cm != null)
            {
                cm.Refresh();
            }
        }
    }
}
