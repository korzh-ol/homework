using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
   public class SpecParameters: IParameters
    {
        public double AngleInDegrees { get; set; }

        public ParameterInfo[] GetDisciption()
        {
            return new[]
            {
                new ParameterInfo()
                {
                    Name = "Rotate",
                    MinValue = -360,
                    MaxValue = 360,
                    DefaultValue = -90,
                    Increment = 45
                }
            };
        }

        public void SetValues(double[] values)
        {
            AngleInDegrees = values[0];
        }
         
    }

}

