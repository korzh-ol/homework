using System;
using System.Dynamic;

namespace MethodFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetValue();
            Console.WriteLine("x = " + x);
            Console.ReadKey();
        }

        static double GetValue()
        {
            return F(2, 3) + F(7, 8) + F(1, 4);
        }
        static double F(double a, double b)
        {
            return Math.Sqrt(a + Math.Tan(b)) / (a * a + b * b);
        }
    }
}
