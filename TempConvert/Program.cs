using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            double input = double.Parse(Console.ReadLine());
            Console.Write("Unit (C/F): ");
            string unidade = Console.ReadLine();

            // F = C * 1.8 + 32        C = (F - 32) / 1.8
            switch (unidade)
            {
                case "F":
                    double fahrenheit = input * 1.8 + 32;
                    Console.WriteLine($"{fahrenheit:f2} F = {input:f2} C");
                    Console.WriteLine($"Absolute value: {Math.Abs(input):f2}");
                    break;

                case "C":
                    double celsius = (input - 32) / 1.8;                    
                    Console.WriteLine($"{celsius:f2} C = {input:f2} F");
                    Console.WriteLine($"Absolute value: {Math.Abs(input):f2}");
                    break;

                default:
                    Console.WriteLine("Invalid unit");
                    break;
            }
        }
    }
}
