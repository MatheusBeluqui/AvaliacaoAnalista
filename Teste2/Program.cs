using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            while (true)
            {
                Console.Write("Digite um número inteiro de 1 a 19: ");
                string entrada = Console.ReadLine() ?? "";

                if (int.TryParse(entrada, out quantidade) &&
                    quantidade > 0 && quantidade < 20)
                {
                    break;
                }

                Console.WriteLine(
                    "Entrada inválida. Digite um inteiro maior que 0 e menor que 20.");
            }

            int anterior = 1;
            int atual = 1;

            Console.Write("Sequência de Fibonacci: ");

            for (int i = 0; i < quantidade; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }

                Console.Write(anterior);

                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine();
        }
    }
}
