using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Zadávej čísla, já je budu násobit.\nKdyž vložíš 0, tak se program ukončí.");

        double count = 1;
        double input = 1;

        while (input!=0)
        {
            input = double.Parse(Console.ReadLine());

            if (input != 0) count = count * input;
        }
        Console.Clear();
        Console.WriteLine($"Součin zadaných čísel je {count}.");
    }
}