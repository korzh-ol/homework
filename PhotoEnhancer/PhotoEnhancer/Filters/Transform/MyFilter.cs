using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PhotoEnhancer
{
    public class MyFilter :RotateTransformer, ITransformer<SpecParameters>
    {
   
        Size size;
        double angleInRadians;
        public Size ResultSize { get; private set; }
        Bitmap bitmap;
       
        public MyFilter() {}

        public Point? MapPoint(Point newPoint)
        {
            var p = new Point(newPoint.X - ResultSize.Width / 2,
                        newPoint.Y - ResultSize.Height / 2);

            var x = (int)Math.Round((p.X * Math.Cos(angleInRadians) -
                p.Y * Math.Sin(angleInRadians) + size.Width / 2));

            var y = (int)Math.Round((p.X * Math.Sin(angleInRadians) +
                p.Y * Math.Cos(angleInRadians) + size.Height / 2));

            if (x < 0 || x >= size.Width || y < 0 || y >= size.Height)
                return null;

            return new Point(x, y);
        }

        public void Initialize(Size size, SpecParameters rotationParameters)
        {
            this.size = size;
            angleInRadians = rotationParameters.AngleInDegrees * Math.PI / 180;

            ResultSize = new Size(
                        (int)Math.Round((Math.Abs(Math.Cos(angleInRadians)) * size.Width +
                            Math.Abs(Math.Sin(angleInRadians)) * size.Height)),
                        (int)Math.Round(Math.Abs(Math.Sin(angleInRadians)) * size.Width +
                            Math.Abs(Math.Cos(angleInRadians)) * size.Height));
        }

       
    }
 }

        


