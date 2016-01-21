using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using HalconDotNet;

namespace MainProject
{
    /// <summary>
    /// 主視窗的物件
    /// 目前包括：Object、Procedure
    /// </summary>
    public class Camera_Table
    {
        public List<Object_Table> Object = new List<Object_Table>();
        public List<Procedure_Table> Procedure = new List<Procedure_Table>();
    }
}
