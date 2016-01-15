using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public delegate void Procedurefunctionhandler();
    public class Procedurefunction
    {
        private Procedurefunctionhandler handler = null;
        public event Procedurefunctionhandler doprocedurefunction
        {
            add { if (value != null) { handler = value; } }
            remove { if (value == handler) { handler = null; } }
        }
        public void dofunction()
        {
            if (handler != null)
            {
                handler();
            }
        }
    }

    /// <summary>
    /// 主視窗的物件中的procedure
    /// 目前包括：num、procedureName
    /// </summary>
    public class Procedure
    {
        private double num;
        private string procedureName;
        public Procedure() { }
        public Procedure(int i) { num = i; }
        public Procedure(string s) { procedureName = s; }
        public Procedure(int i, string s) { num = i; procedureName = s; }
        public double Num { get { return num; } set { num = value; } }
        public string ProcedureName { get { return procedureName; } set { procedureName = value; } }
        public Procedurefunction procedurefunction = new Procedurefunction();
    }
}
