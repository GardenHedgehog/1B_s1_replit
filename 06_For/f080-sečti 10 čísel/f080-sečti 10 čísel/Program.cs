using System;

namespace f080_sečti_10_čísel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Zadejte deset čísel, budu je sčítat: ");
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Suma: {sum}");
        }
    }
}