using System;

namespace f120_bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.Write("Kolik lichých čísel budete vkládat? ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Vkládejte čísla:");
            for (int i = 0; i < count; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input % 2 == 0) Environment.Exit(0);
            }

            Console.WriteLine("Všechna čísla byla lichá.");
        }
    }
}