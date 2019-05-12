using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author : Jonah Cummins P458162
// Date : 9/5/19

namespace Trigonometric
{
    public class Trigonometric
    {
        // Tangent a inputed number in degrees
        public static double Tan(double a)
        {
            a = a * Math.PI / 180;
            return Math.Tan(a);
        }

        // Cosine a inputed number in degrees
        public static double Cos(double a)
        {
            a = a * Math.PI / 180;
            return Math.Cos(a);
        }

        // Sine a inputed number in degrees
        public static double Sin(double a)
        {
            a = a * Math.PI / 180;
            return Math.Sin(a);
        }
    }
}
