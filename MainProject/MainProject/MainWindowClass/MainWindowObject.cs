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
    public class MainWindowObject
    {
        public List<Object> Object = new List<Object>();
        public List<Procedure> Procedure = new List<Procedure>();
    }
}
