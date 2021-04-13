using System;

namespace Donderdag1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = ReadNumber();
            double secondNumber = ReadNumber();
            double thirdNumber = ReadNumber();
            double Mean = (firstNumber + secondNumber + thirdNumber) / 3;
            Console.WriteLine(Mean);
        }
        static double ReadNumber()
        {
            string input;
            double number;
            Console.WriteLine("Give a decimal (use ',' not '.')");
            input = Console.ReadLine();
            bool b2 = Microsoft.VisualBasic.Information.IsNumeric(input);
            if (!b2)
            {
                Console.WriteLine("This is not a decimal. Please give a decimal");
                double number1 = ReadNumber();
                return number1;
            }
            else
            {
                number = Convert.ToDouble(input);
                return number;
            }
        }
    }
}
