using System;

namespace sekvence6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Random rnd = new Random();
            
            int counter = 0;
            int input;
            int sequence = 0;
            bool six = false;
            int cube;
            bool previous = true;
            int highSequence = 1;

            Console.Write("Kolik hodů mám provést? ");
            input = int.Parse(Console.ReadLine());
            Console.Clear();

            while (counter != input)
            {
                counter++;
                
                cube = rnd.Next(1, 7);
                
                six = cube == 6; //pokud je kostka šestka, nastav bool na true
                
                Console.WriteLine(cube);
                
                if (six) sequence++;
                else if (previous) sequence = 0;
                    
                highSequence = Math.Max(sequence, highSequence);

                previous = six;
            }
            
            Console.WriteLine($"Počet provedených hodů: {input}\n" +
                              $"Největší počet šestek za sebou: {highSequence}");
        }
    }
}