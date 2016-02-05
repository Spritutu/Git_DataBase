using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
namespace ST_Base
{
    public class ImagewithRegion
    {
        public ImageBase ReduceDomain(ImageBase image , RegionBase region)//基本上同Addchannels   將原有區域與Region取交集
        {
           
            ImageBase imagewithregion = new ImageBase();
            HObject temp;
            HOperatorSet.ReduceDomain(image.GetImage, region.GetROI, out temp);
            imagewithregion.CopyImagetoThis(temp);
            temp.Dispose();
            return imagewithregion;
        }
        public ImageBase ChangeDomain(ImageBase image, RegionBase newregion)//取代原本的Region
        {
            ImageBase imagewithregion = new ImageBase();
            HObject temp;
            HOperatorSet.ChangeDomain(image.GetImage, newregion.GetROI, out temp);
            imagewithregion.CopyImagetoThis(temp);
            temp.Dispose();
            return imagewithregion;
        }
        public RegionBase GetDomain(ImageBase image)//取得圖片的Region
        {
            RegionBase Regioninimage = new RegionBase();
            HObject temp;
            HOperatorSet.GetDomain(image.GetImage, out temp);
            Regioninimage.CopyRegiontoThis(temp);
            temp.Dispose();
            return Regioninimage;
        }
    }
}
