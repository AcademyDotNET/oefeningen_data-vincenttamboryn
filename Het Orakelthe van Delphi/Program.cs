using System;

namespace Het_Orakelthe_van_Delphi
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomLifeExpectancy();
        }
        static void RandomLifeExpectancy()
        {
            Console.WriteLine("how old are you now?");
            int age = Convert.ToInt32(Console.ReadLine());

            Random mygen = new Random();
            int yearsToLive = mygen.Next(5,125);

            Console.WriteLine($"I expect you to live to the ripe old age of {age + yearsToLive}");
        }
    }
}
