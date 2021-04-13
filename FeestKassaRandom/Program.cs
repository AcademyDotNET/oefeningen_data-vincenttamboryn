using System;

namespace FeestKassaRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            totaal += Prijsberekening("Mosselen met frietjes", 20);
            Console.WriteLine($"De tussenprijs bedraagd {totaal} euro");
            Console.WriteLine("");

            totaal += Prijsberekening("Koninginnehapjes", 10);
            Console.WriteLine($"De tussenprijs bedraagd {totaal} euro");
            Console.WriteLine("");

            totaal += Prijsberekening("Ijsjes", 3);
            Console.WriteLine($"De tussenprijs bedraagd {totaal} euro");
            Console.WriteLine("");

            totaal += Prijsberekening("Dranken", 2);
            Console.WriteLine($"De totaalprijs bedraagd {totaal} euro");
            Console.WriteLine("");
        }
        static int Prijsberekening(string gerecht, int prijs)
        {
            Console.WriteLine($"Hoeveel {gerecht}?");
            Console.ReadLine();
            Random mygen = new Random();
            int aantal = mygen.Next(0, 100);
            if (aantal > 20)
            {
                if (gerecht == "Dranken")
                {
                    Console.WriteLine($"{aantal} {gerecht}? Wow you're going to be thirsty... hope you've got a designated driver...");
                }
                else
                {
                    Console.WriteLine($"{aantal} {gerecht}? Wow someone's having a party...");
                }
            }
            else 
            {
                Console.WriteLine($"{aantal} {gerecht}? I'll write that down.");
            }
            int totaal1 = prijs * aantal;
            return totaal1;
        }
    }
}
