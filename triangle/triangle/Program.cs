using System;

namespace triangle
{
    class Program
    {
        static void Main()

        {

            Console.WriteLine("Введите длину первого катета: ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета: ");

            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Гипотенуза равна " + c);

            double s = 0.5 * a * b;

            Console.WriteLine("Площадь треугольника равна " + s);

            double p = a + b + c;

            Console.WriteLine("Периметр треугольника равен " + p);

            Console.ReadKey();


        }
    }
}
