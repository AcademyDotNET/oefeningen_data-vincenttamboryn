using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = IsNumber("height", "meters");
            double weight = IsNumber("weight", "kilograms");
            double _BMI = Math.Round(weight / (Math.Pow(height, 2)), 2);
            Console.WriteLine($"Your current BMI is {_BMI}");
        }
        static double IsNumber(string measurement, string unit)
        {
            Console.WriteLine($"Give an your {measurement} in {unit}");
            string number = Console.ReadLine();
            bool b2 = Microsoft.VisualBasic.Information.IsNumeric(number);
            if (!b2)
            {
                Console.WriteLine($"This is not a {measurement}. Please give a decimal number");
                double number2 = IsNumber(measurement,unit);
                return number2;
            }
            else
            {
                double number1 = Convert.ToDouble(number);
                return number1;
            }
        }
    }
}
