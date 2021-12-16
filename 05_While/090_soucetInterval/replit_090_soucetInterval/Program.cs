using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Zadej první kraj intervalu: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Clear();

        Console.Write("Zadej druhý kraj intervalu: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Clear();

        ////////

        int vetsi, mensi;

        if (input1>input2)
        {
            vetsi = input1;
            mensi = input2;
        }
        else
        {
            mensi = input1;
            vetsi = input2;
        }

        ////////

        int counter = mensi;
        int soucet = 0;

        while (counter<=vetsi)
        {
            soucet = soucet + counter;
            counter++;
        }

        ////////

        Console.WriteLine($"Součet všech čísel od {mensi} do {vetsi} je {soucet}.");
    }
}