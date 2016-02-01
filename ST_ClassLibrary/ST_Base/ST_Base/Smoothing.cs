using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace ST_Base
{
    public class Smoothing
    {
        public  void AnisotropicDiffusion(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.AnisotropicDiffusion(src_Image.GetImage, out dst, "weickert", 5, 1, 10);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void BinomialFilter(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.BinomialFilter(src_Image.GetImage, out dst, 5, 5);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void EliminateMinMax(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.EliminateMinMax(src_Image.GetImage, out dst, 3, 3, 1, 3);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void EliminateSp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.EliminateSp(src_Image.GetImage, out dst, 3, 3, 1, 254);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void FillInterlace(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.FillInterlace(src_Image.GetImage, out dst, "odd");
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void GaussFilter(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.GaussFilter(src_Image.GetImage, out dst, 5);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void IsotropicDiffusion(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.IsotropicDiffusion(src_Image.GetImage, out dst, 1, 10);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MeanImage(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MeanImage(src_Image.GetImage, out dst, 9, 9);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MeanN(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MeanN(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MeanSp(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MeanSp(src_Image.GetImage, out dst, 3, 3, 1, 254);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MedianImage(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MedianImage(src_Image.GetImage, out dst, "circle", 1, "mirrored");
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MedianSeparate(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MedianSeparate(src_Image.GetImage, out dst, 25, 25, "mirrored");
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MedianRect(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MedianRect(src_Image.GetImage, out dst, 15, 15);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void MedianWeighted(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.MedianWeighted(src_Image.GetImage, out dst, "inner", 3);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void RankRect(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.RankRect(src_Image.GetImage, out dst, 15, 15, 5);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void SigmaImage(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.SigmaImage(src_Image.GetImage, out dst, 5, 5, 3);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void SmoothImage(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;HOperatorSet.SmoothImage(src_Image.GetImage, out dst, "deriche2", 0.5);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }

    }
}