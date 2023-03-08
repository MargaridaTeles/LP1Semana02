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
            Console.WriteLine($"Incremento: {incremento}");
        }
    }
}
