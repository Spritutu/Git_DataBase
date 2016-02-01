using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
namespace ST_Base
{
    public class Eages
    {
        public  void DerivateGauss(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.DerivateGauss(src_Image.GetImage, out dst, 1, "x");
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void DiffOfGauss(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.DiffOfGauss(src_Image.GetImage, out dst, 3, 1.6);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void EdgesImage(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HObject dst1;
            HOperatorSet.EdgesImage(src_Image.GetImage, out dst, out dst1, "canny", 1, "nms",20, 40);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        
        public  void FreiAmp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.FreiAmp(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void FreiDir(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;

            HObject dst1;
            HOperatorSet.FreiDir(src_Image.GetImage, out dst, out dst1);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void KirschAmp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.KirschAmp(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void KirschDir(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;

            HObject dst1;
            HOperatorSet.KirschDir(src_Image.GetImage, out dst, out dst1);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void Laplace(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.Laplace(src_Image.GetImage, out dst, "absolute", 3, "n_4");
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void LaplaceOfGauss(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.LaplaceOfGauss(src_Image.GetImage, out dst, 2);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void PrewittAmp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.PrewittAmp(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void PrewittDir(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;

            HObject dst1;
            HOperatorSet.PrewittDir(src_Image.GetImage, out dst, out dst1);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void Roberts(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.Roberts(src_Image.GetImage, out dst, "gradient_sum");
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void RobinsonAmp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.RobinsonAmp(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void RobinsonDir(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;

            HObject dst1;
            HOperatorSet.RobinsonDir(src_Image.GetImage, out dst, out dst1);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void SobelAmp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.SobelAmp(src_Image.GetImage, out dst, "sum_abs", 3);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void SobelDir(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;

            HObject dst1;
            HOperatorSet.SobelDir(src_Image.GetImage, out dst, out dst1, "sum_abs", 3);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }


    }
}
    
    
    