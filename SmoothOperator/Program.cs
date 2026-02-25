using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            string input = Console.ReadLine();

            sbyte n = Convert.ToSByte(input);

            Console.WriteLine($"Operação de decremento: {--n}");
            Console.WriteLine($"Operação de incremento: {++n}");
        }
    }
}
