using System;

namespace f090_secti_suda
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int sum = 0;
            Console.WriteLine("Zadejte deset čísel, budu je sčítat: ");
            for (int i = 0; i < 10; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sum += input;
            }
            Console.WriteLine($"Suma: {sum}");
        }
    }
}