using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Jakou dělitelnost budeme vyžadovat? ");
        double del = double.Parse(Console.ReadLine());

        Console.Clear();
        System.Threading.Thread.Sleep(700);
        Console.Write($"Zadejte číslo dělitelné {del}: ");
        double input = double.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(100);
        Console.Clear();

        if (input%del==0)
        {
           Console.WriteLine("Správně.");
        }
        else
        {
            while (!(input % del == 0))
            {
                Console.Write($"Špatně, zadejte číslo dělitelné {del}: ");
                input = double.Parse(Console.ReadLine());
                System.Threading.Thread.Sleep(100);
                Console.Clear();
            }
            Console.WriteLine("Správně.");

        }

        Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení programu.");
        Console.ReadKey();

    }
}