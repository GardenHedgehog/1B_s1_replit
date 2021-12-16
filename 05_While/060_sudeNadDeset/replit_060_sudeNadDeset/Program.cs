using System;

namespace replit_030_nactiSude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte sudé číslo větší než 10: ");
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Clear();


            if (((input%2)==0)&&(input>10))
            {
                Console.WriteLine($"správně");
                Environment.Exit(0);
            }
            else
            {
                while (!(((input % 2) == 0) && (input > 10)))
                {
                    Console.Clear();
                    Console.Write($"číslo je špatné, zkuste to znovu: ");
                    input = Math.Abs(int.Parse(Console.ReadLine()));
                }
                Console.Clear();
                Console.WriteLine($"správně");
                Environment.Exit(0);
            }
        }
    }
}
