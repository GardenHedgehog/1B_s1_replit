using System;

namespace f020_odpocet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (int i = 60; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("ZÁŽEH!");
        }
    }
}