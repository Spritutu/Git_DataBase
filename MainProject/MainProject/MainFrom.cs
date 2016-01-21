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
            test();
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
            Object O = new Object(); 

            string str = System.Windows.Forms.Application.StartupPath;
            List<MiniImages> L = new List<MiniImages>();

            for (int i = 0; i < mwo.Object.Count; i++)
            {
                
                O = (Object)mwo.Object[i];
                if (O.Image != null)
                {
                    MiniImages mini = new MiniImages();
                    mini.Bitmap = minipicture(O.Image);
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
             

        private void 刪除程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];
            mwo.Procedure.RemoveAt(cm.Position);
            mwo.Object.RemoveAt(cm.Position);
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



        int clk = 0;
        private void 載入圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ReadImage readthefuckingimage = new ReadImage();
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];
            procedure p = new procedure();

            readthefuckingimage.readimageNsetwindow(MainWindow.HalconWindow);

            if (readthefuckingimage.getObject().Image != null)
            {
                p.Procedure = "載入圖片" + clk;
                p.procedurefunction.doprocedurefunction += readthefuckingimage.show;
                
                mwo.Procedure.Insert(cm.Position + 1, p);
                mwo.Object.Insert(cm.Position + 1, readthefuckingimage.getObject());

                clk++;
            }

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




        public class ReadImage
        {
            ImageBase imagebase = new ImageBase();
            Object O = new Object();
            HTuple window;

            public void readimageNsetwindow(HTuple win)
            {
                window = win;
                imagebase.ImagefromFile();
                O.Image = imagebase.GetImage;
            }
            public Object getObject()
            {
                return O;
            }

            public void show()
            {
                HOperatorSet.SetPart(window, 0, 0, imagebase.GetHeight - 1, imagebase.GetWidth - 1);
                HOperatorSet.ClearWindow(window);
                HOperatorSet.DispObj(imagebase.GetImage, window);
            }
            
        }

        public Bitmap minipicture(HObject obj) {

            HObject obj_temp;
            HOperatorSet.ZoomImageSize(obj,out obj_temp, 100,100, "constant");
            return HObject_Bitmap.HObject2Bitmap(obj_temp);
        }
        

        private void DO_Click(object sender, EventArgs e)
        {
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];
            procedure p = new procedure();

            for (int i = 0; i < mwo.Procedure.Count; i++)
            {
                p = (procedure)mwo.Procedure[i];
                p.procedurefunction.dofunction();
            }
            BindObjectToGrid(MainWindowObjectTable, 0);
        }
    }
}
