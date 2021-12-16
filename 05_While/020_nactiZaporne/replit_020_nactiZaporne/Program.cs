using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Zadej záporné číslo: ");
        double input = double.Parse(Console.ReadLine());
                Console.Clear();

        if (input<0)
        {
            Console.Write($"{input} je záporné.");
            Environment.Exit(0);
        }
        else
        {
            while (input>=0)
            {
                Console.Clear();
                Console.Write($"{input} není záporné. Zkuste to znovu: ");
                input = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write($"{input} je záporné");
            Environment.Exit(0);
        }
    }
}