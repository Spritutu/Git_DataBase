using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    class Morphology
    {
        public void GrayDilationRect(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.GrayDilationRect(src_Image.GetImage, out dst, 20, 20);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public void GrayErosionRect(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.GrayErosionRect(src_Image.GetImage, out dst, 20, 20);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }


    }
}
