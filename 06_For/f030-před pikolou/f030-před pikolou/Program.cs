using System;

namespace f030_před_pikolou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("PIKÁM!");
            for (int i = 10; i <= 200; i += 10)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("UŽ JDU!!");
        }
    }
}