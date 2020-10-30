using System;
using System.Security.Cryptography.X509Certificates;

namespace mathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = CountFunction(x);
            Console.WriteLine("y(x)= " + y);
            Console.ReadKey();
        }
        static double CountFunction (double x)
        {
            return (2 / (x * x + 25) + Math.Cos(x)) / Math.Sqrt(Math.Pow(x, 4) + 1) + ((Math.Sin(x) + Math.Cos(x)) / 2);
        }
    }
}
