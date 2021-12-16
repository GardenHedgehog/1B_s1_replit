using System;

namespace f110_sečti_N_čísel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Kolik čísel chcete sečíst?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Teď za sebou zadejte čísla a já je sečtu.");
            for (int i = 0; i < count; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Suma: {sum}");
        }
    }
}