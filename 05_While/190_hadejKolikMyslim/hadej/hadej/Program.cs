using System;

namespace hadej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Random rnd = new Random();

            int randomNum = rnd.Next(1,101);

            bool repeat = true;

            int input;

            int round = 0;

            
            Console.WriteLine("Myslím si číslo od 1 do 100. \n" +
                              "Budeš hádat, já ti budu napovídat!\n");
            
            Console.WriteLine("1. kolo\n" +
                              "Hádej:");
            
            while (repeat)
            {
                round++;
                
                input = int.Parse(Console.ReadLine());

                Console.Clear();

                if (input == randomNum)
                {
                    Console.WriteLine("Správně!\n" +
                                      "Počet kol potřebných k uhádnutí: " + round);
                    repeat = false;
                }
                else if (input > randomNum)
                {
                    Console.WriteLine("Špatně! Hádej znovu.\n" +
                                      "Moje číslo je menší než to tvoje.\n" +
                                      "{0}. kolo", round);
                    repeat = true;
                }
                else if (input < randomNum)
                {
                    Console.WriteLine("Špatně! Hádej znovu.\n" +
                                      "Moje číslo je větší než to tvoje.\n" +
                                      "{0}. kolo", round);
                    repeat = true;
                }
                
            

            }






        }
    }
}