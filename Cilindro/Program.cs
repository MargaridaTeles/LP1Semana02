using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira a altura do cilindro: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insira o raio do cilindro: ");
            int r = int.Parse(Console.ReadLine());

            double volume = MathF.PI * MathF.Pow(r, 2) * a;
            double area = 2 * MathF.PI * r * (r + a);

            Console.WriteLine($"Volume do cilindro: {volume:f3}");
            Console.WriteLine($"Área de superfície do cilindro: {area:f3}");
        }
    }
}
