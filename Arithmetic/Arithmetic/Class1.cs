using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author : Jonah Cummins P458162
// Date : 9/5/19

namespace Arithmetic
{
    public class Arithmetic
    {
        // Adds two inputed numbers
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        // Subtracts two inputed numbers
        public static double Sub(double a, double b)
        {
            return (a - b);
        }

        // Divides two inputed numbers
        public static double Div(double a, double b)
        {
            return ((double)a / b);
        }

        // Mutiplys two inputed numbers
        public static double Mult(double a, double b)
        {
            return (a * b);
        }
    }
}
