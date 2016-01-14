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

            string str = System.Windows.Forms.Application.StartupPath;
            List<Images> L = new List<Images>();
            for (int i = 0; i < mwo.Object.Count; i++)
            {
                L.Add(new Images() { Im = Image.FromFile(str +"\\MinimizingChart\\1.bmp") });
            }

            Table.DataSource = L;//繫結到圖片集合

            Table.Columns[0].HeaderText = "圖片";//設定列文字
            Table.Columns[0].Width =100;//設定列寬度
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Table.Rows[i].Height = 70;//設定行高度
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

        Imagefucker fucker = new Imagefucker();


        private void 載入圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];

            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[0];
            procedure p = new procedure();



            p.procedurefunction.doprocedurefunction += fucker.readimage;
            p.Procedure = "載入圖片";

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


        public class Imagefucker
        {
            //--------------Image物件，讀寫函式------------------------------
            protected HObject Image = null;
            public HObject GetImage { get { return Image; } }
            public HObject SetImage { set { Image = value; } }
            //-------------Image物件長寬，讀取函式---------------------------
            protected HTuple hv_Width = null;
            public HTuple GetWidth { get { return hv_Width; } }
            protected HTuple hv_Height = null;
            public HTuple GetHeight { get { return hv_Height; } }

            public void readimage()
            {
                HOperatorSet.ReadImage(out Image, "C:/Users/User/Desktop/images.jpg");
                HOperatorSet.GetImageSize(Image, out hv_Width, out hv_Height);
                HOperatorSet.SetSystem("width", hv_Width);
                HOperatorSet.SetSystem("height", hv_Height);
            }
        }






        public void show()
        {

            HOperatorSet.SetPart(MainWindow.HalconWindow, 0, 0, fucker.GetHeight - 1, fucker.GetWidth - 1);
            HOperatorSet.ClearWindow(MainWindow.HalconWindow);
            HOperatorSet.DispObj(fucker.GetImage, MainWindow.HalconWindow);
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
            show();
        }
    }
}
