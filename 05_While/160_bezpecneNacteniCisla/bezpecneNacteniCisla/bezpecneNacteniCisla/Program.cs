using System;
using System.ComponentModel;

namespace bezpecneNacteniCisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            bool integerCheck;
            int bin;
            Console.Clear();
           
            
            Console.Write("Zadejte celé číslo: ");
            input = double.Parse(Console.ReadLine());
            if  (input%1==0)
            {
                integerCheck = true;
            }
            else
            {
                integerCheck = false;
            }
            Console.Clear();
            
            
            while (!integerCheck)
            {
                Console.Write("Nezadali jste celé číslo. Zkuste to ještě jednou: ");
                input = int.Parse(Console.ReadLine());
                if  (input%1==0)
                {
                    integerCheck = true;
                }
                else
                {
                    integerCheck = false;
                }

                Console.Clear();
            }

            if (integerCheck)
            {
                Console.WriteLine($"Zadali jste celé číslo {input}.");
            }
        }
    }
}