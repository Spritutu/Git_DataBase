using System;
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
    enum procedure_M { readimage = 1, Measure_1D, Measure_2D_Circle, Measure_2D_Line, Measure_2D_Ellipse, CreateMatchingModel , TheVerticalLine , PL_distance };

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

        int p_clk = 0;//載入圖片序數
        private void 載入圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();
            p.ProcedureName = "載入圖片" + p_clk;
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.readimage;

            Camera.Procedure.Insert(cm.Position + 1, p);
            Camera.Object.Insert(cm.Position + 1, O);
            p_clk++;

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
            //設定Procedure_Table以及Object_Table
            Procedure_Table P = new Procedure_Table();
            Object_Table O = new Object_Table();

            P.ProcedureName = "Measure_1D";
            P.Setornot = false;
            P.ProcedureMethod = (int)procedure_M.Measure_1D;
            P.SettingForm = new Measure_1D();

            Camera.Procedure.Insert(cm.Position + 1, P);
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
            //載入圖片函式
            

            switch (Camera.Procedure[cm.Position].ProcedureMethod)
            {
                case (int)procedure_M.readimage:
                    
                    AccessImage readthefuckingimage = new AccessImage();
                    //由檔案載入圖片
                    readthefuckingimage.ImagefromFile();
                    
                    if (readthefuckingimage.getimagebase().GetImage != null)
                    {
                        p.procedurefunction.doprocedurefunction += readthefuckingimage.show;
                        string temp = "(procedure_" + cm.Position + ",Image_" + Camera.Object[cm.Position].OImage.Count + ")";

                        if (readthefuckingimage.getimagebase().GetImage != null)
                        {
                            Camera.Object[cm.Position].OImage.Clear();
                            Camera.Object[cm.Position].OImageName.Clear();
                        }


                        Camera.Object[cm.Position].OImage.Add(readthefuckingimage.getimagebase().GetImage);
                        Camera.Object[cm.Position].OImageName.Add(temp);

                        Camera.Procedure[cm.Position].Setornot = true;
                    }
                    break;

                case (int)procedure_M.Measure_1D:

                    Measure_1D M1_temp = (Measure_1D)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        M1_temp.O_T = Camera.Object;
                    }
                    M1_temp.ShowDialog();

                    if (M1_temp.setornot == true)
                    {
                        Camera.Object[cm.Position].OPoint.Clear();
                        Camera.Object[cm.Position].OPointName.Clear();
                        if (M1_temp.dstfirstpoint != null)
                        {
                            for (int i = 0; i < M1_temp.dstfirstpoint.Count; i++)
                            {
                                Camera.Object[cm.Position].OPoint.Add(M1_temp.dstfirstpoint[i]);
                                Camera.Object[cm.Position].OPointName.Add("dstfirstpoint" + i);
                            }
                        }
                        if (M1_temp.dstsecondpoint != null)
                        {
                            for (int i = 0; i < M1_temp.dstsecondpoint.Count; i++)
                            {
                                Camera.Object[cm.Position].OPoint.Add(M1_temp.dstsecondpoint[i]);
                                Camera.Object[cm.Position].OPointName.Add("dstsecondpoint" + i);
                            }
                        }
                    }

                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += M1_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = M1_temp;
                    Camera.Procedure[cm.Position].Setornot = M1_temp.setornot;

                    break;

                case (int)procedure_M.Measure_2D_Ellipse:

                    Measure_2D_Ellipse M2DE_temp = (Measure_2D_Ellipse)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        M2DE_temp.MeasureImage = Camera.Object[cm.Position - 1].OImage[0];           //暫時使用前一個程序的圖片(載入圖片)
                    }

                    M2DE_temp.ShowDialog();
                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += M2DE_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = M2DE_temp;
                    Camera.Procedure[cm.Position].Setornot = M2DE_temp.setornot;
                    break;

                case (int)procedure_M.Measure_2D_Line:

                    Measure_2D_Line M2DL_temp = (Measure_2D_Line)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        M2DL_temp.MeasureImage = Camera.Object[cm.Position - 1].OImage[0];           //暫時使用前一個程序的圖片(載入圖片)
                    }

                    M2DL_temp.ShowDialog();
                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += M2DL_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = M2DL_temp;
                    Camera.Procedure[cm.Position].Setornot = M2DL_temp.setornot;

                    break;

                case (int)procedure_M.Measure_2D_Circle:

                    Measure_2D_Circle M2DC_temp = (Measure_2D_Circle)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        M2DC_temp.O_T = Camera.Object;          //暫時使用前一個程序的圖片(載入圖片)
                    }
                    M2DC_temp.ShowDialog();

                    if (M2DC_temp.setornot == true)
                    {
                        Camera.Object[cm.Position].OCircle.Clear();
                        Camera.Object[cm.Position].OCircleName.Clear();
                        if (M2DC_temp.dstCircle != null)
                        {
                            Camera.Object[cm.Position].OCircle.Add(M2DC_temp.dstCircle);
                            Camera.Object[cm.Position].OCircleName.Add("testcircle");
                        }
                    }


                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += M2DC_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = M2DC_temp;
                    Camera.Procedure[cm.Position].Setornot = M2DC_temp.setornot;

                    break;

                case (int)procedure_M.CreateMatchingModel:

                    CreateMatchingModel CMM_temp = (CreateMatchingModel)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        CMM_temp.O_T = Camera.Object;
                    }
                    CMM_temp.ShowDialog();

                    if (CMM_temp.setornot ==true)
                    {
                        Camera.Object[cm.Position].OImage.Clear();
                        Camera.Object[cm.Position].OImageName.Clear();
                        if (CMM_temp.dstImage != null)
                        {
                            Camera.Object[cm.Position].OImage.Add(CMM_temp.dstImage);
                            Camera.Object[cm.Position].OImageName.Add("CreateMatchingModel");
                        }
                    }

                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += CMM_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = CMM_temp;
                    Camera.Procedure[cm.Position].Setornot = CMM_temp.setornot;

                    break;
                case (int)procedure_M.TheVerticalLine:

                    TheVerticalLine TVL_temp = (TheVerticalLine)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        TVL_temp.O_T = Camera.Object;
                    }
                    TVL_temp.ShowDialog();

                    if (TVL_temp.setornot == true)
                    {
                        Camera.Object[cm.Position].OLine.Clear();
                        Camera.Object[cm.Position].OLineName.Clear();
                        if (TVL_temp.DstLine != null)
                        {
                            Camera.Object[cm.Position].OLine.Add(TVL_temp.DstLine);
                            Camera.Object[cm.Position].OLineName.Add("TheVerticalLine");
                        }
                    }


                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += TVL_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = TVL_temp;
                    Camera.Procedure[cm.Position].Setornot = TVL_temp.setornot;

                    break; 
                case (int)procedure_M.PL_distance:

                    PL_distance PLD_temp = (PL_distance)Camera.Procedure[cm.Position].SettingForm;
                    if (cm.Position != 0)
                    {
                        PLD_temp.O_T = Camera.Object;
                    }
                    PLD_temp.ShowDialog();


                    Camera.Procedure[cm.Position].procedurefunction.doprocedurefunction += PLD_temp.run;
                    Camera.Procedure[cm.Position].SettingForm = PLD_temp;
                    Camera.Procedure[cm.Position].Setornot = PLD_temp.setornot;

                    break;


            }
            setProcedurecolor();


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
            }

            else
                MessageBox.Show("還有參數沒有設定喔");
        }


        private void 二維量測circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "Measure_2D_Circle";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.Measure_2D_Circle;
            p.SettingForm = new Measure_2D_Circle();

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

        private void 二維量測LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "Measure_2D_Line";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.Measure_2D_Line;
            p.SettingForm = new Measure_2D_Line();

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

        private void 二維量測EllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "Measure_2D_Eillpse";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.Measure_2D_Ellipse;
            p.SettingForm = new Measure_2D_Ellipse();

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

        private void 中垂線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "TheVerticalLine";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.TheVerticalLine;
            p.SettingForm = new TheVerticalLine();

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

        private void 兩點距離ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //控制項目前cell位置
            CurrencyManager cm = (CurrencyManager)this.BindingContext[ProcedureTable.DataSource];
            //設定Procedure_Table顯示字串
            Procedure_Table p = new Procedure_Table();
            Object_Table O = new Object_Table();

            p.ProcedureName = "PL_distance";
            p.Setornot = false;
            p.ProcedureMethod = (int)procedure_M.PL_distance;
            p.SettingForm = new PL_distance();

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
    }
}
