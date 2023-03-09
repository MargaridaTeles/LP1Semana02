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
            float pi = Convert.ToSingle(Math.PI);
            //Pedir medidas ao utilizador
            Console.Write($"Insira um número para o raio: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write($"Insira uma altura: ");
            int a = int.Parse(Console.ReadLine());

            float r_quadrado = Convert.ToSingle(Math.Pow(r, 2));
            //Contas com os valores inseridos pelo utilizador
            float V = pi * r_quadrado * a;
            float Sa = 2 * pi * r * (r + a);

            //Mostra resultado ao utilizador
            Console.WriteLine($"O volume do cilíndro é: " + V
                        +"\nA área da superfície do cilindro é: " + Sa);



        }
    }
}
