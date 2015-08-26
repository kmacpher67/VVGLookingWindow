using System;
using System.Diagnostics;
using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.Cuda;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace Ungu_CV1
{
    public static class FindPedestrian
    {
        /// <summary>
        /// Find the pedestrian in the image
        /// </summary>
        /// <param name="image">The image</param>
        /// <param name="processingTime">The pedestrian detection time in milliseconds</param>
        /// <returns>The image with pedestrian highlighted.</returns>
        public static Image<Bgr, Byte> Find(Image<Bgr, Byte> image, out long processingTime)
        {
            Stopwatch watch;
            Rectangle[] regions;

            //check if there is a compatible GPU to run pedestrian detection
            if (CudaInvoke.HasCuda)
            {  //this is the GPU version
                using (CudaHOG des = new CudaHOG(new Size(64, 128), new Size(16, 16), new Size(8, 8), new Size(8, 8)))
                {
                    des.SetSVMDetector(des.GetDefaultPeopleDetector());

                    watch = Stopwatch.StartNew();
                    using (CudaImage<Bgr, Byte> gpuImg = new CudaImage<Bgr, byte>(image))
                    using (CudaImage<Bgra, Byte> gpuBgra = gpuImg.Convert<Bgra, Byte>())
                    using (VectorOfRect vr = new VectorOfRect())
                    {
                        CudaInvoke.CvtColor(gpuBgra, gpuBgra, ColorConversion.Bgr2Bgra);
                        des.DetectMultiScale(gpuBgra,vr);
                        regions = vr.ToArray();
                    }
                }
            }
            else
            {  //this is the CPU version
                using (HOGDescriptor des = new HOGDescriptor())
                {
                    des.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
                    //load the image to umat so it will automatically use opencl is available
                    UMat umat = image.ToUMat();

                    watch = Stopwatch.StartNew();
                    //regions = des.DetectMultiScale(image);
                    MCvObjectDetection[] results = des.DetectMultiScale(umat);
                    regions = new Rectangle[results.Length];
                    for (int i = 0; i < results.Length; i++)
                        regions[i] = results[i].Rect;
                }
            }
            watch.Stop();

            processingTime = watch.ElapsedMilliseconds;

            foreach (Rectangle pedestrain in regions)
            {
                image.Draw(pedestrain, new Bgr(Color.Red), 1);
            }
            return image;
        }

    }
}
