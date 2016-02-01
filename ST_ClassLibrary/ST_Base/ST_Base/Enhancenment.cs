using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
/*
Enhancenment Filter的一些函式整理以及變數說明
src_Image   輸入圖片
dst_Image   輸出處理過後圖片

    會寫成兩個是因為讓他可以使用預設數值(設置參數不同)
*/

namespace ST_Base
{
    public class Enhancenment
    {
        /*CoherenceEnhancingDiff
        Sigma (input_control)  real → (real)
        Smoothing for derivative operator.
            Default value: 0.5
            Suggested values: 0.0, 0.1, 0.5, 1.0
            Restriction: Sigma >= 0
        Rho (input_control)  real → (real)
        Smoothing for diffusion coefficients.
            Default value: 3.0
            Suggested values: 0.0, 1.0, 3.0, 5.0, 10.0, 30.0
            Restriction: Rho >= 0
        Theta (input_control)  real → (real)
        Time step.
            Default value: 0.5
            Suggested values: 0.1, 0.2, 0.3, 0.4, 0.5
            Restriction: (0 < Theta) <= 0.5
        Iterations (input_control)  integer → (integer)
        Number of iterations.
            Default value: 10
            Suggested values: 1, 5, 10, 20, 50, 100, 500
            Restriction: Iterations >= 1
        */
        public  void CoherenceEnhancingDiff(ImageBase src_Image, ImageBase dst_Image, HTuple sigma, HTuple rho, HTuple theta, HTuple iterations)
        {
            HObject dst;
            HOperatorSet.CoherenceEnhancingDiff(src_Image.GetImage, out dst, sigma, rho, theta, iterations);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void CoherenceEnhancingDiff(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.CoherenceEnhancingDiff(src_Image.GetImage, out dst, 0.5, 3, 0.5, 10);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }

        /*Emphasize
        MaskWidth (input_control)  extent.x → (integer)
        Width of low pass MaskBase.
            Default value: 7
            Suggested values: 3, 5, 7, 9, 11, 15, 21, 25, 31, 39
            Typical range of values: 3 ≤ MaskWidth ≤ 201
            Minimum increment: 2
            Recommended increment: 2
        MaskHeight (input_control)  extent.y → (integer)
        Height of the low pass MaskBase.
            Default value: 7
            Suggested values: 3, 5, 7, 9, 11, 15, 21, 25, 31, 39
            Typical range of values: 3 ≤ MaskHeight ≤ 201
            Minimum increment: 2
            Recommended increment: 2
        Factor (input_control)  real → (real)
        Intensity of contrast emphasis.
            Default value: 1.0
            Suggested values: 0.3, 0.5, 0.7, 1.0, 1.4, 1.8, 2.0
            Typical range of values: 0.0 ≤ Factor ≤ 20.0 (sqrt)
            Minimum increment: 0.01
            Recommended increment: 0.2
            Restriction: (0 < Factor) && (Factor < 20)
        */
        public  void Emphasize(ImageBase src_Image, ImageBase dst_Image,MaskBase maskEmphasize, HTuple factor)
        {
            HObject dst;
            HOperatorSet.Emphasize(src_Image.GetImage, out dst, maskEmphasize.W, maskEmphasize.H, factor);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void Emphasize(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.Emphasize(src_Image.GetImage, out dst, 7, 7, 1);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        
        public  void EquHistoImage(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.EquHistoImage(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }

        /*Illuminate
        MaskWidth (input_control)  extent.x → (integer)
        Width of low pass MaskBase.
            Default value: 101
            Suggested values: 31, 41, 51, 71, 101, 121, 151, 201
            Typical range of values: 3 ≤ MaskWidth ≤ 299
            Minimum increment: 2
            Recommended increment: 10
        MaskHeight (input_control)  extent.y → (integer)
        Height of low pass MaskBase.
            Default value: 101
            Suggested values: 31, 41, 51, 71, 101, 121, 151, 201
            Typical range of values: 3 ≤ MaskHeight ≤ 299
            Minimum increment: 2
            Recommended increment: 10
        Factor (input_control)  real → (real)
        Scales the “correction gray value” added to the original gray values.
            Default value: 0.7
            Suggested values: 0.3, 0.5, 0.7, 1.0, 1.5, 2.0, 3.0, 5.0
            Typical range of values: 0.0 ≤ Factor ≤ 5.0
            Minimum increment: 0.01
            Recommended increment: 0.2
            Restriction: (0 < Factor) && (Factor < 5)
        */
        public  void Illuminate(ImageBase src_Image, ImageBase dst_Image, MaskBase maskIlluminate, HTuple factor)
        {
            HObject dst;
            HOperatorSet.Illuminate(src_Image.GetImage, out dst, maskIlluminate.W, maskIlluminate.H, factor);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void Illuminate(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.Illuminate(src_Image.GetImage, out dst, 101, 101, 0.7);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        

        public  void ScaleImageMax(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.ScaleImageMax(src_Image.GetImage, out dst);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }

        /*ShockFilter
        Theta (input_control)  real → (real)
        Time step.
            Default value: 0.5
            Suggested values: 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7
            Restriction: (0 < Theta) <= 0.7
        Iterations (input_control)  integer → (integer)
        Number of iterations.
            Default value: 10
            Suggested values: 1, 3, 10, 100
            Restriction: Iterations >= 1
        Mode (input_control)  string → (string)
        Type of edge detector.
            Default value: 'canny'
            List of values: 'canny', 'laplace'
        Sigma (input_control)  real → (real)
        Smoothing of edge detector.
            Default value: 1.0
            Suggested values: 0.0, 0.5, 1.0, 2.0, 5.0
            Restriction: Theta >= 0
            */
        public  void ShockFilter(ImageBase src_Image, ImageBase dst_Image, HTuple theta, HTuple iterations, HTuple mode, HTuple sigma)
        {
            HObject dst;
            HOperatorSet.ShockFilter(src_Image.GetImage, out dst, theta, iterations, mode, sigma);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }
        public  void ShockFilter(ImageBase src_Image, ImageBase dst_Image)
        {
            HObject dst;
            HOperatorSet.ShockFilter(src_Image.GetImage, out dst, 0.5, 10, "canny", 1);
            dst_Image.CopyImagetoThis(dst);
            dst.Dispose();
        }



    }
}
