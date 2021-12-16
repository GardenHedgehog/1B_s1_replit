using System;

namespace minimax
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double num;
            bool repeat;
            double min = double.MaxValue;
            double max = double.MinValue;
            double average;
            double sum = 0;
            double counter = 0;
            
            Console.Clear();
            
            Console.WriteLine("Zadávejte čísla. Až zadáte X, vypíšu data.");

            do
            {
                input = Console.ReadLine();
                
                if (double.TryParse(input, out num))
                {
                    repeat = true;
                    
                    //AVERAGE
                    counter++;
                    sum += num;
                
                    //MIN
                    if (num < min)
                    {
                        min = num;
                    }

                    //MAX
                    if (num > max)
                    {
                        max = num;
                    }
                }

                else
                {
                    repeat = false;

                    if (input is "X" or "x")
                    {
                        average = sum / counter;
                        
                        Console.Clear();
                        Console.Write($"Nejmenší vstup: {min}\n" +
                                      $"Největší vstup: {max}\n" +
                                      $"Průměrná hodnota vstupů: {average}\n");
                    }

                    else
                    {
                        Console.Clear();
                        Console.Write("Neplatný vstup.\n");
                    }
                }
            } while (repeat);

            Console.Write("Stiskněte libovolnou klávesu pro ukončení programu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}