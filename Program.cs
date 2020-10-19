using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerArithmetics
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите трёхзначное число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = ((num1 / 100) * 100 + ((num1 %  100) % 10) * 10 + (num1 % 100) / 10);
            Console.WriteLine("Число после перестановки цифр десятков и единиц равно: " + num2);
            Console.ReadKey();


        }
    }
}
