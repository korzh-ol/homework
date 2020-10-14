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
            Console.WriteLine("Введите количество сотен, десятков и единиц в трёхзначном числе:");

            int sotni = Convert.ToInt32(Console.ReadLine());
            
            int desyatki = Convert.ToInt32(Console.ReadLine());

            int edinici = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введённое число равняется " + sotni + desyatki + edinici);

            Console.WriteLine("Число после перестановки цифр десятков и единиц равно " + sotni + edinici + desyatki);

            Console.ReadKey();


        }
    }
}
