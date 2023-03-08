using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            int incremento = x;
            incremento++;
            int decremento = x;
            --decremento;
            Console.WriteLine($"Incremento: {incremento}");
            Console.WriteLine($"Decremento: {decremento}");
        }
    }
}
