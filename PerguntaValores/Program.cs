using System;

namespace PerguntaValores
{
    class Program
    {
        /// <summary>
        /// V = πr2a Sa = 2πr(r + a) π = 3.1415926
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            float π = 3.1415926f;

            //Pedir medidas ao utilizador
            Console.Write($"Insira um número para o raio: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write($"Insira uma altura: ");
            int a = int.Parse(Console.ReadLine());
            
            //Contas com os valores inseridos pelo utilizador
            float V = π * (r * r) * a;
            float Sa = 2 * π * r * (r + a);



        }
    }
}
