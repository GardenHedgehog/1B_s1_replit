using System;

namespace replit_030_nactiSude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte sudé číslo: ");
            double input = double.Parse(Console.ReadLine());
            Console.Clear();

            double li = 0;

            if ((input % 2)==0)
            {
                Console.WriteLine($"{input} je sudé.");
                li = input + 1;
                Console.WriteLine($"Nejbližší liché číslo: {li}");
                    Environment.Exit(0);
            }
            else
            {
                while (!((input % 2) == 0))
                {
                    Console.Clear();
                    Console.Write($"{input} není sudé. Zkuste to znovu: ");
                    input = double.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine($"{input} je sudé");
                li = input + 1;
                Console.WriteLine($"Nejbližší liché číslo: {li}");

                Environment.Exit(0);
            }
        }
    }
}
