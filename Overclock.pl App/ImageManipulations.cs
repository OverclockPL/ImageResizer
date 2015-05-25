using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Overclock.pl_App
{
    class ImageManipulations
    {
        public static Bitmap resize(Image image, int width)
        {
            int height = width * image.Height;
            height /= image.Width;

            Bitmap bmp = new Bitmap(width, height);
            Graphics graph = Graphics.FromImage(bmp);
            graph.InterpolationMode = InterpolationMode.High;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.DrawImage(image, new Rectangle(0, 0, width, height));

            return bmp;
        }

        public static int getAverageValueOfPixelsForWatermarkAreaOn(Bitmap bitmap, Bitmap watermark)
        {
            Rectangle area = new Rectangle(
                    new Point(73, bitmap.Height - watermark.Height + 15),
                    new Size(watermark.Width - 73, watermark.Height - 22));

            Bitmap watermarkArea = bitmap.Clone(area, bitmap.PixelFormat);

            BitmapData bitmapData = watermarkArea.LockBits(
                new Rectangle(0, 0, watermarkArea.Width, watermarkArea.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            int valueOfPixels = 0;
            int quanityOfPixels = 0;

            int stride = bitmapData.Stride;
            int offset = stride - watermarkArea.Width * 3;
            int width = watermarkArea.Width * 3;

            IntPtr Scan0 = bitmapData.Scan0;

            unsafe
            {
                byte* pointer = (byte*)(void*)Scan0;

                for (int y = 0; y < watermarkArea.Height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        valueOfPixels += pointer[0];
                        ++quanityOfPixels;
                        ++pointer;
                    }
                    pointer += offset;
                }
            }

            watermarkArea.UnlockBits(bitmapData);

            watermarkArea = null;
            bitmapData = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            return valueOfPixels / quanityOfPixels;
        }

        public static void addWatermark(Bitmap bitmap, Watermarks watermarks)
        {
            Bitmap watermarkBitmap = watermarks.get("Overclock.pl dla jasnego tła");

            if (getAverageValueOfPixelsForWatermarkAreaOn(bitmap, watermarkBitmap) < 127)
            {
                watermarkBitmap = watermarks.get("Overclock.pl dla ciemnego tła");
            }

            Graphics bitmapAsGraphic = Graphics.FromImage(bitmap);
            bitmapAsGraphic.DrawImage(watermarkBitmap, new Point(0, bitmap.Height - watermarkBitmap.Height));
        }

        public static void addMagnifier(Bitmap bitmap, Watermarks watermarks)
        {
            Graphics bitmapAsGraphic = Graphics.FromImage(bitmap);
            Bitmap magnifier = watermarks.get("Lupka");

            bitmapAsGraphic.DrawImage(magnifier, new Point(bitmap.Width - magnifier.Width, bitmap.Height - magnifier.Height));
        }
    }
}
