using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe o a altura do triangulo e caracter
            int linha = int.Parse(args[0]);
            int alturatri = linha;
            string carater = args[1];

            for (int a = 0; a < alturatri; a+=1)
            {
                    for (int e = 0; e <= a; e+=1)
                    {
                        Console.Write($"{carater}");
                    }
                    Console.Write("\n");
            }
        }
    }
}
