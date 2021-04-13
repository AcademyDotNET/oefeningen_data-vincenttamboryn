using System;

namespace Op_De_Poef
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double poef = 0;
            while (i < 5)
                {
                poef += BedragInlezen();
                i++;
                Console.WriteLine($"De poef bedraagd momenteel {Math.Round(poef,2)} euro");
                }
            int betaalTijd = (int)Math.Ceiling(poef/10);
            Console.WriteLine($"Als de schuldenaar wekelijks 10 euro betaald, zijn over {betaalTijd} weken al zijn schulden terugbetaald zijn");
        }
        static double BedragInlezen()
        {
            Console.WriteLine("Voer bedrag in?");
            double schulde =Convert.ToDouble(Console.ReadLine());
            return schulde;
        }
    }
}
