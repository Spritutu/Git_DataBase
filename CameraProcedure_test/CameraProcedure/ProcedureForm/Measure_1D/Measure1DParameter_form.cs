using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST_Base;
using HalconDotNet;

namespace CameraProcedure
{ 
    public class Measure1DParameter_form
    {

        //pair的前標點(ho_CrossFirst)and後標點(ho_CrossSecond)  其中ho_CrossFirst與pos模式下的標點共用
        public HObject ho_CrossFirst;
        public HObject ho_CrossSecond;
        //測量控制器
        public HTuple hv_MeasureHandle;

        //********測量參數(in)**********
        public HTuple sigma;
        public HTuple threshold;
        public HTuple transition_pair;
        public HTuple transition_pos;
        public HTuple select;
        //********測量參數(out)**********
        public HTuple hv_RowEdgeFirst;
        public HTuple hv_ColumnEdgeFirst;
        public HTuple hv_AmplitudeFirst;
        public HTuple hv_RowEdgeSecond;
        public HTuple hv_ColumnEdgeSecond;
        public HTuple hv_AmplitudeSecond;
        public HTuple hv_Distance;
        public HTuple hv_PinWidth;
        public HTuple hv_PinDistance;
        public HTuple ROIweight;


        /// <summary>
        /// TransitionData_pair下拉式表單參數
        /// </summary>
        public List<string> TransitionData_pair = new List<string>();
        /// <summary>
        /// TransitionData_pos下拉式表單參數
        /// </summary>
        public List<string> TransitionData_pos = new List<string>();
        /// <summary>
        /// SelectData下拉式表單參數
        /// </summary>
        public List<string> SelectData = new List<string>();
        /// <summary>
        /// SelectImage下拉式表單參數
        /// </summary>
        public List<SelectImageNName> SelectImage = new List<SelectImageNName>();
        /// <summary>
        /// 待測圖片
        /// </summary>
        public ImageBase Measure_Image = new ImageBase();

        //***********暫存未整理區域***********
        public HObject temp1;
        public HObject temp2;
        public HObject temp3;
        //***********暫存未整理區域***********


        /// <summary>
        /// 測量模式
        /// </summary>
        public int measuretype = 0;
        /// <summary>
        /// 是否設定完成->按下OK鈕
        /// </summary>
        public bool setornot = false;

        public List<index_ij> index_img = new List<index_ij>();

        public bool ifopenformornot = false;
        public bool loadfinish = false;
    }
}
