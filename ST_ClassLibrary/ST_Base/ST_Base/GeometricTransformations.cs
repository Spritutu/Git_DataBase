using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
namespace ST_Base
{
    public class GeometricTransformations
    {
        public void AffineTransImage(ImageBase srcImage, ImageBase dstImage, HTuple row, HTuple col , HTuple ang)
        {
            HTuple hv_HomMat2D=null;
            HObject tempImage = null;
            HOperatorSet.VectorAngleToRigid(srcImage.GetWidth / 2, srcImage.GetHeight / 2, 0 ,row ,col, ang , out hv_HomMat2D);
            HOperatorSet.AffineTransImage(srcImage.GetImage, out tempImage, hv_HomMat2D,"constant", "'false");
            dstImage.CopyImagetoThis(tempImage);
            tempImage.Dispose();
        }
        public void ZoomImageFactor(ImageBase srcImage, ImageBase dstImage, HTuple scaleWidth, HTuple scaleHeight)
        {
            HObject tempImage = null;
            HOperatorSet.ZoomImageFactor(srcImage.GetImage, out tempImage, scaleWidth, scaleHeight, "constant");
            dstImage.CopyImagetoThis(tempImage);
            tempImage.Dispose();
        }

    }
}
