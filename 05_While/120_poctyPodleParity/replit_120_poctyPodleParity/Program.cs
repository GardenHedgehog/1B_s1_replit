using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int odd = 0;
        int even = 0;
        int? input = null;

        Console.Clear();

        Console.WriteLine("Zadávejte celá čísla." +
            "\nZadávání ukončíte zadáním \"0\" nebo záporného čísla." +
            "\nPotom spočítám, kolik bylo lichých a kolik sudých čísel.\n");
        while (!(input<=0))
        {
            input = int.Parse(Console.ReadLine());

            switch (input % 2)
            {
                case 0:
                    even++;
                    break;
                case 1:
                    odd++;
                    break;
            }
        }

        Console.WriteLine($"\nPočet lichých čísel: {odd}" +
            $"\nPočet sudých čísel: {even}\n\n");
    }
}