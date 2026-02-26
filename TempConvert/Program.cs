using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Temperature: ");
            string input = Console.ReadLine();
            Console.Write("Unit (C/F): ");
            string unidade = Console.ReadLine();

            double celsius, fahrenheit;

            switch (unidade)
            {
                case "F":
                    celsius = double.Parse(input);
                    fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine($"{celsius} C = {fahrenheit} F");
                    break;

                case "f":
                    celsius = double.Parse(input);
                    fahrenheit = celsius * 1.8 + 32;                    
                    Console.WriteLine($"{celsius} C = {fahrenheit} F");
                    break;

                case "C":
                    fahrenheit = double.Parse(input);
                    celsius = (fahrenheit - 32) / 1.8;                    
                    Console.WriteLine($"{celsius} C = {fahrenheit} F");
                    break;

                case "c":
                    fahrenheit = double.Parse(input);
                    celsius = (fahrenheit - 32) / 1.8;                   
                    Console.WriteLine($"{celsius} C = {fahrenheit} F");
                    break;

                default:
                    Console.WriteLine("Invalid unit");
                    break;
            }
        }
    }
}
