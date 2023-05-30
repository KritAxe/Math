using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLab;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeometryClass.Triangle(4, 6));
            Console.WriteLine(GeometryClass.Triangle2(5, 7));
            Console.WriteLine(GeometryClass.Rectangle(2, 4));
            Console.WriteLine(GeometryClass.Circle(6));
            Console.WriteLine(GeometryClass.Trapezoid(2, 4, 6));

            Console.WriteLine(AlgebraClass.Quadraticequation(3, 7, -6));
        }
    }
}
