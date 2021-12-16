using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Zadávej čísla, já je budu sčítat.\nKdyž vložíš 0, tak se program ukončí.");

        bool skip = true;
        double count = 0;
        double input = 0;



        while (skip)
        {
            input = double.Parse(Console.ReadLine());
            count = count + input;
            if (input == 0)
            {
                skip = false;
            }

        }
        Console.Clear();
        Console.WriteLine($"Součet zadaných čísel je {count}.");
    }
}