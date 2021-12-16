using System;

namespace KNP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputValid = true;
            string figureUser = null;
            string figurePC = null;
            string input = null;
            bool repeat;
            char decide;
            bool promptContinue;
            
            Console.Clear();

            {
                System.Threading.Thread.Sleep(200);
                Console.Write("Kámen, ");
                System.Threading.Thread.Sleep(900);
                Console.Write("nůžky, ");
                System.Threading.Thread.Sleep(900);
                Console.Write("papír, ");
                System.Threading.Thread.Sleep(900);
                Console.WriteLine("STOP!");
                System.Threading.Thread.Sleep(900);
            }
            
            do
            {
                repeat = false;
                
                Console.Write("Zadejte figuru: \"kamen\", \"nuzky\" nebo \"papir\": ");
                input = Console.ReadLine();
                
                do
                    switch (input)
                    {
                        case "kamen":
                            inputValid = true;
                            figureUser = "kámen";
                            break;

                        case "nuzky":
                            inputValid = true;
                            figureUser = "nůžky";
                            break;

                        case "papir":
                            inputValid = true;
                            figureUser = "papír";
                            break;

                        default:
                            inputValid = false;
                            Console.Clear();
                            Console.Write(
                                "Neplatný vstup. Zadejte malými písmeny slovo \"kamen\", \"nuzky\" nebo \"papir\": ");
                            input = Console.ReadLine();
                            break;
                    } while (!inputValid);

                Console.Clear();

                Random rnd = new Random();
                int numPC = rnd.Next(1, 4);
                switch (numPC)
                {
                    case 1:
                        figurePC = "kámen";
                        break;
                    case 2:
                        figurePC = "nůžky";
                        break;
                    case 3:
                        figurePC = "papír";
                        break;
                }

                Console.Write($"Vaše figura:     {figureUser}\n" +
                              $"Figura počítače: {figurePC}\n");
                
                if (figureUser == figurePC)
                {
                    Console.WriteLine("---REMÍZA---\n" +
                                      "Další kolo:");
                    repeat = true;
                }
                else if ((figureUser == "kámen" && figurePC == "papír")
                      || (figureUser == "nůžky" && figurePC == "kámen")
                      || (figureUser == "papír" && figurePC == "nůžky"))
                {
                    //PROHRA UŽIVATELE
                    Console.WriteLine("---PROHRA---");
                    repeat = false;
                }
                else if ((figureUser == "kámen" && figurePC == "nůžky")
                      || (figureUser == "nůžky" && figurePC == "papír")
                      || (figureUser == "papír" && figurePC == "kámen"))
                {
                    //VÝHRA UŽIVATELE
                    Console.WriteLine("---VÝHRA---");
                    repeat = false;
                }

                if (!repeat)
                {
                    do
                    {
                        Console.WriteLine("Chcete hrát znovu? (a/n)");
                        decide = Console.ReadKey().KeyChar;
                        switch (decide)
                        {
                            case 'a':
                                repeat = true;
                                promptContinue = true;
                                Console.Clear();
                                break;
                            case 'n':
                                repeat = false;
                                promptContinue = true;
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                promptContinue = false;
                                Console.Write("Zadejte platnou hodnotu: ");
                                break;
                        }
                    } while (!promptContinue);
                }

            } while (repeat);

            Console.Write("Program je ukončen.");
            
        }
    }
}