using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira um temperatura: ");
            string input = Console.ReadLine();
            Console.Write("Insira a unidade de origem (C) Celsious ou (F) Fahrenheit: ");
            string unidade = Console.ReadLine();

            double celsius, fahrenheit;

            switch (unidade)
            {
                case "F":
                    celsius = double.Parse(input);
                    fahrenheit = celsius * 1.8 + 32;
                    break;

                case "f":
                    celsius = double.Parse(input);
                    fahrenheit = celsius * 1.8 + 32;
                    break;

                case "C":
                    fahrenheit = double.Parse(input);
                    celsius = (fahrenheit - 32) / 1.8;
                    break;

                case "c":
                    fahrenheit = double.Parse(input);
                    celsius = (fahrenheit - 32) / 1.8;
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
