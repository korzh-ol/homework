using System;

namespace zachet_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserPhrase = Console.ReadLine();
            UserPhrase.ToLower();

            char[] Vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

            int VowelSum = 0;
            for (int i = 0; i < Vowels.Length; i++)
            {
                if (UserPhrase.Contains(Vowels[i]))
                {
                    Console.WriteLine($"{Vowels[i]} - {UserPhrase.Split(Vowels[i]).Length - 1}");
                    VowelSum += UserPhrase.Split(Vowels[i]).Length - 1;
                }
                
            }
            Console.WriteLine($"Всего гласных - {VowelSum}");
            Console.ReadKey();
        }
    }
}
