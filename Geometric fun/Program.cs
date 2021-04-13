using System;

namespace Geometric_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle = IsNumber();
            double radians = angle * Math.PI / 180.0;
            Console.WriteLine($"an angle of {angle}° is equivalent to an angle of {radians} radians");
            Console.WriteLine($"the sine of {angle}° is {Math.Sin(radians)}, its cosine is {Math.Cos(radians)} and its tangent is {Math.Tan(radians)}");
        }
        static double IsNumber()
        {
            Console.WriteLine("Give an angle in degrees");
            string number = Console.ReadLine();
            bool b2 = Microsoft.VisualBasic.Information.IsNumeric(number);
            if (!b2)
            {
                Console.WriteLine("This is not a valid angle. Please give a decimal number");
                double number2 = IsNumber();
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
