﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.Drawing.Imaging;
using System.Drawing;

namespace MainProject
{
    /// <summary>
    /// 主視窗的物件中的Object
    /// 目前包括：image
    /// </summary>
    public class Object_Table
    {
        private HObject image ;
        public HObject Image { get { return image; }set { image = value; } }
    }
}
