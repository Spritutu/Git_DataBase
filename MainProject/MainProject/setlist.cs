using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace MainProject
{
    class setlist
    {
        public static void set_list (HTuple hv_RowEdge, HTuple hv_ColumnEdge, HTuple hv_Amplitude, HTuple hv_Distance, System.Windows.Forms.ListView listView) {

            listView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            listView.Items.Clear();
            for (int i = 0; i < hv_RowEdge.Length; i++) {

                string i_string = Convert.ToString(i);

                HTuple hv_RowEdge_string;
                HTuple hv_ColumnEdge_string;
                HTuple hv_Amplitude_string;
                HTuple hv_Distance_string;

                HOperatorSet.TupleString(hv_RowEdge, ".7f", out hv_RowEdge_string);
                HOperatorSet.TupleString(hv_ColumnEdge, ".7f", out hv_ColumnEdge_string);
                HOperatorSet.TupleString(hv_Amplitude, ".7f", out hv_Amplitude_string);
                HOperatorSet.TupleString(hv_Distance, ".7f", out hv_Distance_string);

                listView.Items.Add(i_string, i_string, 0);
                listView.Items[i_string].SubItems.Add(hv_RowEdge_string[i]);
                listView.Items[i_string].SubItems.Add(hv_ColumnEdge_string[i]);
                listView.Items[i_string].SubItems.Add(hv_Amplitude_string[i]);

                if(i != hv_RowEdge.Length-1)
                    listView.Items[i_string].SubItems.Add(hv_Distance_string[i]);

            }
            listView.EndUpdate();  //结束数据处理，UI界面一次性绘制。  
        }
    }
}
