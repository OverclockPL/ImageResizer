using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net;

namespace Overclock.pl_App
{
    class FileSaver
    {
        private static ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        private static ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
        private static System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
        private static EncoderParameters myEncoderParameters = new EncoderParameters(1);
        private static EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 90L);

        public static void save(Bitmap bitmap, String filePath, ImageFormat imageFormat)
        {
            myEncoderParameters.Param[0] = myEncoderParameter;

            bitmap.Save(filePath + "." + imageFormat.ToString(), jgpEncoder, myEncoderParameters);
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
