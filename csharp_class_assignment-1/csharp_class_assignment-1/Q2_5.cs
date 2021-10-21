using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_class_assignment_1
{
    class Shapes
    {
        public void area(float x)
        {
            Console.WriteLine("Area of Square: " + x * x);
        }
        public void area(float x, float y)
        {
            Console.WriteLine("Area of Rectangle: " + x * y);
        }
        public void area(double x)
        {
            double res = 3.14 * x * x;
            Console.WriteLine("Area of Circle: " + res);
        }
        public void area(double x, double y)
        {
            double res = 0.5 * x * y;
            Console.WriteLine("Area of Triangle: " + res);
        }

    }
    class Q2_5
    { 
        static void Main()
        {
            Shapes S = new Shapes();
            S.area(15);
            S.area(31, 32);
            S.area(3.25);
            S.area(1.25, 1.5);

        }
    }
}