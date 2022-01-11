using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
   public class Test

    {
        public static void Go(string[] args)
        {
            using (Image original = Image.FromFile("original.jpg"))
            using (Bitmap bigger = new Bitmap(original.Width * 2,
                                       original.Height * 2,
                                       original.PixelFormat))
            using (Graphics g = Graphics.FromImage(bigger))
            {
                g.DrawImage(original, new Rectangle(Point.Empty, bigger.Size));
                bigger.Save("bigger.jpg");
            }
        }
    }
}

