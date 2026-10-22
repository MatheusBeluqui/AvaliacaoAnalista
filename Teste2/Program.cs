
using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de elementos: ");

            if (!int.TryParse(Console.ReadLine(), out int quantidade) ||
                quantidade <= 0)
            {
                Console.WriteLine("Informe um número inteiro maior que zero.");
                return;
            }

            if (quantidade > 93)
            {
                Console.WriteLine("A quantidade máxima permitida é 93.");
                return;
            }

            Console.WriteLine("Sequência de Fibonacci:");

            GerarFibonacci(quantidade);
        }

        private static void GerarFibonacci(int quantidade)
        {
            ulong anterior = 0;
            ulong atual = 1;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(atual);

                if (i < quantidade - 1)
                    Console.Write(", ");

                if (i < quantidade - 1)
                {
                    ulong proximo = checked(anterior + atual);
                    anterior = atual;
                    atual = proximo;
                }
            }

            Console.WriteLine();
        }
    }
}
