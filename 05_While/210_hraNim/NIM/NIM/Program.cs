using System;

namespace NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            int table = 21;
            int player = 2;
            int input;
            bool inputValidParse;
            
            Console.Clear();
            
            Console.WriteLine("---------------------\n" +
                              "---------NIM---------\n" +
                              "---------------------");

            Console.WriteLine("Na stole je 21 zápalek.\n" +
                              "Odebírejte 1–3 zápalky. Kdo odebere poslední, vyhrál.\n");
            
            while (table > 0)
            {
                if (player == 2) player = 1;
                else if (player == 1) player = 2;
                
                Console.Write($"Kolik bere hráč {player}? ");
                inputValidParse = int.TryParse(Console.ReadLine(), out input);
                while (input > 3 || input>table || !inputValidParse)
                {
                    Console.WriteLine("Chyba vstupu. Zadejte 1–3 a číslo nemůže být větší než počet zbývajících zápalek.");
                    inputValidParse = int.TryParse(Console.ReadLine(), out input);
                }

                table -= input;

                Console.Clear();
                
                Console.WriteLine($"Na stole je teď {table} zápalek.");
            }
            
            Console.WriteLine("Byla odebrána poslední zápalka.\n" +
                              $"Vyhrává hráč {player}.");
        }
    }
}