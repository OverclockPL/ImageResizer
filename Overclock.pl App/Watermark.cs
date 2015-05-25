using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Overclock.pl_App
{
    class Watermarks
    {
        private List<KeyValuePair<String, Bitmap>> watermarks;

        public Watermarks()
        {
            watermarks = new List<KeyValuePair<String, Bitmap>>(3);
            KeyValuePair<String, Bitmap> light = new KeyValuePair<String, Bitmap>("Overclock.pl dla jasnego tła", new Bitmap(Image.FromFile("light.png")));
            KeyValuePair<String, Bitmap> dark = new KeyValuePair<String, Bitmap>("Overclock.pl dla ciemnego tła", new Bitmap(Image.FromFile("dark.png")));
            KeyValuePair<String, Bitmap> magnifier = new KeyValuePair<String, Bitmap>("Lupka", new Bitmap(Image.FromFile("magnifier.png")));

            watermarks.Add(light);
            watermarks.Add(dark);
            watermarks.Add(magnifier);
        }

        public Bitmap get(String name)
        {
            foreach (KeyValuePair<String, Bitmap> watermark in watermarks)
            {
                if (watermark.Key.Equals(name))
                {
                    return watermark.Value;
                }
            }

            throw new Exception("Program nie posiada dostępu do znaku wodnego o tej nazwie!");
        }
    }
}
