using System;

namespace minimumZeCtvrtych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Zadávejte přirozená čísla.\n" +
                          "Zadávání ukončíte nulou.");

            int counter = 0;
            int input = 0;
            int lowest = int.MaxValue;
            do
            {
                input = int.Parse(Console.ReadLine());
                
                if (input > 0)
                {
                    counter++;
                    if ((counter % 4) == 0 && input<lowest )
                    {
                        lowest = input;
                    }
                }
            } while (input>0);

            if (counter < 4)
            {
                Console.WriteLine("Zadali jste méně než čtyři čísla. Chyba!");
                Environment.Exit(1);
            }
            
            Console.WriteLine($"Nejmenší čtvrté zadané číslo je {lowest}.");
        }
    }
}