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
        private ArrayList Camrea = new ArrayList();


        public MainFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCamrea();
            BindProcedureToGrid(ProcedureTable);
            BindObjectToGrid(MainWindowObjectTable);

        }

        private void CreateCamrea() {
            Camrea.Add(new MainWindowObject());
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[Camrea.Count-1];
            mwo.Object.Add(new Object()); 
            mwo.Procedure.Add(new procedure());
            Camrea[Camrea.Count - 1] = mwo;
            
        }
        private void BindProcedureToGrid(DataGridView Table)
        {
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[Camrea.Count - 1];
            Table.DataSource = mwo.Procedure;
            Table.Columns[0].Width = 35;//設定列寬
            Table.Columns[0].Resizable = DataGridViewTriState.False;
            Table.Columns[1].Width = 300;//設定列寬
        }
        private void BindObjectToGrid(DataGridView Table)
        {
            MainWindowObject mwo;
            mwo = (MainWindowObject)Camrea[Camrea.Count - 1];
            Table.DataSource = mwo.Object;
            Table.Columns[0].Width = 100;//設定列寬
        }

    }
}
