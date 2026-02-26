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
            string input = Console.ReadLine();
            Console.Write("Unit (C/F): ");
            string unidade = Console.ReadLine();

            double fahrenheit, celsius;

            switch (unidade)
            {
                case "F":
                    celsius = double.Parse(input);
                    fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine($"{fahrenheit:f2} F = {celsius:f2} C");
                    break;

                case "f":
                    celsius = double.Parse(input);
                    fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine($"{fahrenheit:f2} F = {celsius:f2} C");
                    break;

                case "C":
                    fahrenheit = double.Parse(input);
                    celsius = (fahrenheit - 32) / 1.8;                    
                    Console.WriteLine($"{celsius:f2} C = {fahrenheit:f2} F");
                    break;

                case "c":
                    fahrenheit = double.Parse(input);
                    celsius = (fahrenheit - 32) / 1.8;                   
                    Console.WriteLine($"{celsius:f2} C = {fahrenheit:f2} F");
                    //Math.Abs()
                    break;

                default:
                    Console.WriteLine("Invalid unit");
                    break;
            }
        }
    }
}
