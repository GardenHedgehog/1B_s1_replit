using System;

namespace replit_030_nactiSude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte trojciferné číslo: ");
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Clear();


            if ((input<1000)&&(input>=100))
            {
                Console.WriteLine($"číslo je trojciferné");
                Environment.Exit(0);
            }
            else
            {
                while (!((input < 1000) && (input >= 100)))
                {
                    Console.Clear();
                    Console.Write($"číslo není trojciferné, zkuste to znovu: ");
                    input = Math.Abs(int.Parse(Console.ReadLine()));
                }
                Console.Clear();
                Console.WriteLine($"{input} je trojciferné");

                Environment.Exit(0);
            }
        }
    }
}
