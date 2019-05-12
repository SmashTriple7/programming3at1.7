using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author : Jonah Cummins P458162
// Date : 9/5/19

namespace Algebraic
{
    public class Algebraic
    {
        // Square roots an inputed number
        public static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        // Cube roots an inputed number
        public static double CubeRoot(double a)
        {
            return Math.Pow(a, (double)1 / 3);
        }

        // Inverts an inputed number
        public static double Inverse(double a)
        {
            return 1 / a;
        }
    }
}
