using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Ducking_Wookie
{
    class Detect
    {
        AdaptiveSkinDetector sd = new AdaptiveSkinDetector(1, AdaptiveSkinDetector.MorphingMethod.NONE);
        public Image<Gray, byte> detectSkinBlobs(Image<Bgr, byte> img)
        {
            Image<Gray, byte> target = new Image<Gray, byte>(img.Width, img.Height);
            sd.Process(img, target);

            return target;
        }
    }
}
