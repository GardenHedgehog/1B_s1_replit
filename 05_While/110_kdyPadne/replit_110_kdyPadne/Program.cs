using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //Deklarace:
        Random rnd = new Random();
        int hody;
        int? kostka;
        bool repeat = true;
        char? repeatInput = null;
        bool repeatCall;
        //

        Console.Clear();  //mažu bordel v konzoli
        Console.WriteLine("--- Měření počtu hodů k hození šestky ---\n" +
            "Stiskněte libovolnou klávesu pro start.");  //výzva
            Console.ReadKey();    //spusť program
            Console.Clear();

        while (repeat)
        {
            //reset proměnných
            hody = 0;
            kostka = null;
            repeatCall = true;
            //
            
            while (kostka != 6)
            {
                hody++;             //přičtení hodu do počítače
                kostka = rnd.Next(1, 7);           //generování čísla kostky
                Console.WriteLine($"{hody}. hod: {kostka}"); //vypsání jednotlivých hodů
            }

            Console.WriteLine($"\nPočet potřebných hodů k dosažení šestky: {hody}");  //výstup

            Console.WriteLine("\nChcete program spustit znovu? (a/n)");
            while (repeatCall)
            {
                repeatInput = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (repeatInput)
                {
                    case 'a':
                    case 'A':
                        repeat = true;
                        repeatCall = false;
                        Console.Clear();
                        break;
                    case 'n':
                    case 'N':
                        repeat = false;
                        repeatCall = false;
                        Console.Clear();
                        break;
                    default:
                        repeatCall = true;
                        Console.Clear();
                        Console.WriteLine("Zadali jste neplatnou hodnotu." +
                            "\nStiskněte \"a\" (chci spustit program znovu) " +
                            "nebo \"n\" (chci ukončit program).");
                        break;
                }
            }
            Console.Write("Program byl ukončen.");
        }
    }
}