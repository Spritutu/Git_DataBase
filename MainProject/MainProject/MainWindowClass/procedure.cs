using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    /// <summary>
    /// 主視窗的物件中的procedure
    /// 目前包括：num、procedureName
    /// </summary>
    public class procedure
    {
        private double num;
        private string procedureName;
        public procedure() { }
        public procedure(int i) { num = i; }
        public procedure(string s) { procedureName = s; }
        public procedure(int i, string s) { num = i; procedureName = s; }
        public double Num { get { return num; } set { num = value; } }
        public string Procedure { get { return procedureName; } set { procedureName = value; } }
        //public procedurefunction procedurefunction = new procedurefunction();
    }
}
