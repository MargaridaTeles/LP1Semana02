using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string pergunta, resposta;

            // Enquanto a questão for diferente de "EXIT" ele pede ao utilizador
            // uma nova questão
            do
            {
                // Colocar questão ao utilizador
                Console.Write("Insira um questão? ");
                pergunta = Console.ReadLine();

                // Verificar se se trata de uma questão conhecida e determinar uma
                // resposta adequada
                resposta = pergunta switch
                {
                    "Como estás?" => "Estou bem, obrigada",
                    "Qual é o teu nome?" => "Mother",
                    "Qual é a tua missão?" => "Informar-te",
                    "Que idade tens?" => "40",
                    "Cor favorita?" => "Turquesa",
                    "EXIT" => "Bye",
                    _ => "Não reconheço a questão"
                };

                // Responder adequadamente
                Console.WriteLine(resposta);

            } while (pergunta != "EXIT");

        }
    }
}
