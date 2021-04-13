using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            totaal += Prijsberekening("Hoeveel mosselen met frietjes", 20);
            Console.WriteLine($"De tussenprijs bedraagd {totaal} euro");

            totaal += Prijsberekening("Hoeveel koninginnehapjes", 10);
            Console.WriteLine($"De tussenprijs bedraagd {totaal} euro");

            totaal += Prijsberekening("Hoeveel ijsjes", 3);
            Console.WriteLine($"De tussenprijs bedraagd {totaal} euro");

            totaal += Prijsberekening("Hoeveel dranken", 2);
            Console.WriteLine($"De totaalprijs bedraagd {totaal} euro");
        }
        static int Prijsberekening(string gerecht, int prijs)
        {
            Console.WriteLine($"{gerecht}?");
            int aantal = Convert.ToInt32(Console.ReadLine());
            int totaal1 = prijs * aantal;
            return totaal1;
        }
    }
}
