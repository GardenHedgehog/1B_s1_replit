using System;

namespace hadiAZebriky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HADI A ŽEBŘÍKY\n");

            int field = 1;
            Random rnd = new Random();
            int counter = 0;
            int cube = rnd.Next();
            
            Console.WriteLine("Start: Pozice 1");
            
            do
            {
                counter++;
                cube = rnd.Next(1,7);

                field += cube;

                if (field<100) Console.WriteLine($"Tah {counter}: Hod {cube}, pozice {field}");
                
                if (field<100) 
                {if (field % 11 == 0)
                    {
                        field += 10;
                        Console.WriteLine($"+ Žebřík: Pozice {field}");
                    }
                    else if (field % 13 == 0)
                    {
                        field -= 12;
                        Console.WriteLine($"+ Had: Pozice {field}");
                    }}
                
                Console.WriteLine();
                
            } while (field < 100);

            Console.WriteLine($"Konec v {counter}. tahu");

        }
    }
}
