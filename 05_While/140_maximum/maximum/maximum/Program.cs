using System;

namespace maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Zadávejte přirozená čísla. \n" +
                              "Pro skončení zadejte nulu nebo záporné číslo.");
            int input = 0;
            int counter = 0;
            do
            {
                input = int.Parse(Console.ReadLine());
                if (input > counter)
                {
                    counter = input;
                }
            } while (input>0);
    
            Console.WriteLine();
            
            if (counter == 0)
            {
                Console.WriteLine("Nezadali jste žádná čísla.");
            }
            else
            {
                Console.WriteLine($"Největší zadané číslo je {counter}.");
            }
        }
    }
}