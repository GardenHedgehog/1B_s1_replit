using System;

namespace poctyPodleVelikosti
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Zadávejte čísla." +
                              "\nUkončíte to zadáním 0 nebo záporného čísla." +
                              "\nPotom napíšu, kolik čísel bylo jednociferných," +
                              "\nkolik dvojciferných, trojciferných a větších.");
            int? input = null;
            int cif1 = 0;
            int cif2 = 0;
            int cif3 = 0;
            int cifMore = 0;

            do
            {
                input = int.Parse(Console.ReadLine());
                if (input > 0)
                {
                    if (input <= 9)
                    {
                        cif1++;
                    }
                    else if (input >= 10 && input <= 99)
                    {
                        cif2++;
                    }
                    else if (input >= 100 && input <= 999)
                    {
                        cif3++;
                    }
                    else if (input > 1000)
                    {
                        cifMore++;
                    }
                }
            } while (input > 0);
            
            Console.WriteLine($"Počet jednociferných čísel: {cif1}\n" +
                          $"Počet dvouciferných čísel:  {cif2}\n" +
                          $"Počet trojciferných čísel:  {cif3}\n" +
                          $"Počet víceciferných čísel:  {cifMore}");
        }
    }
}