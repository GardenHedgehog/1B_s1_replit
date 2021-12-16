using System;

namespace replit_030_nactiSude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte liché číslo: ");
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Clear();


            int pom = input % 10;
            int nasobek = input - pom + 10;
            ///////////

            if ((input%2)==1)
            {
                Console.WriteLine($"číslo je liché");
                Console.WriteLine($"nejbližší násobek deseti je {nasobek}");
                Environment.Exit(0);
            }
            else
            {
                while (!((input % 2) == 1))
                {
                    Console.Clear();
                    Console.Write($"číslo není liché, zkuste to znovu: ");
                    input = Math.Abs(int.Parse(Console.ReadLine()));
                }
                Console.Clear();
                Console.WriteLine($"{input} je liché");
                Console.WriteLine($"nejbližší násobek deseti je {nasobek}");
                Environment.Exit(0);
            }
        }
    }
}
