using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLab
{
    public class GeometryClass
    {
        public static double Triangle(double a, double h)
        {
            return (a / 2) * h;
        }
        public static double Triangle2(double a, double b)
        {
            return (a / 2) * b;
        }
        public static double Rectangle(double a, double b)
        {
            return a * b;
        }
        public static double Circle(double a)
        {
            return (a* a) * 3.14;
        }
        public static double Trapezoid(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
    }
}
