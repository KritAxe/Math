using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathLab
{
    public class AlgebraClass
    {
        public static double Quadraticequation(double a, double b, double c)
        {
            double x1;
            double x2;
            double[] array;
            double D = Math.Pow(b, 2) - 4 * a * c;
            if(D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
                
                
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
            
        }
        //public static double Linearequation()
        //{

        //}

    }
}
