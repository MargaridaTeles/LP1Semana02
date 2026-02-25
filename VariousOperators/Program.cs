using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira número inteiro-não negativo: ");
            uint input = uint.Parse(Console.ReadLine());

            byte n = Convert.ToByte(input);

            Console.WriteLine($"Divisão por 2: {n/2}");
            Console.WriteLine($"Shift Left por 3: {n << 3}");

            Console.WriteLine($"XOR com 6: {n ^ 6}");
            Console.WriteLine($"É maior que 10? {n > 10}");
        }
    }
}
