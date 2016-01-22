using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ZQSFP_detection
{
    class DrawRectangle2
    {
        private HTuple hv_ExpDefaultWinHandle;                                                              //要畫的視窗halcon
        private HTuple hv_Row, hv_Column, hv_Phi;                                                           //Rectangle2的中心和角度
        private HTuple hv_Length1, hv_Length2;                                                              //Rectangle2的長寬
        private HObject ho_ROI;                                                                             //Rectangle2的ROI範圍

        private void action()
        {
            HOperatorSet.DrawRectangle2(hv_ExpDefaultWinHandle,out hv_Row, out hv_Column, out hv_Phi,       //畫Rectangle2
                    out hv_Length1, out hv_Length2);
            HOperatorSet.GenRectangle2(out ho_ROI, hv_Row, hv_Column, hv_Phi, hv_Length1, hv_Length2);      //產生Rectangle2區域        
        }
        
        public void draw(HTuple Window)
        {
            hv_ExpDefaultWinHandle = Window;
            action();
        }

        public void Show(HTuple Window)
        {
            hv_ExpDefaultWinHandle = Window;

            HOperatorSet.DispObj(ho_ROI, hv_ExpDefaultWinHandle);
        }
        //----------------------輸出-------------------------------
        public HTuple get_Row { get { return hv_Row; } }                                                        
        public HTuple get_Column { get { return hv_Column; } }
        public HTuple get_Phi { get { return hv_Phi; } }
        public HTuple get_Length1 { get { return hv_Length1; } }
        public HTuple get_Length2 { get { return hv_Length2; } }
        public HObject get_ROI { get { return ho_ROI; } }
    }
}
