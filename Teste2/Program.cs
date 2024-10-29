/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = ObterNumeroDoUsuario();

            if (numero > 0)
            {
                Console.WriteLine("Sequência de Fibonacci:");
                GerarSequenciaFibonacci(numero);
            }
        }

        static int ObterNumeroDoUsuario()
        {
            while (true)
            {
                Console.WriteLine("Digite um número inteiro positivo entre 1 e 19:");

                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero < 20)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. número precisa ser maior que 0 e menor que 20");
                }
            }
        }

        static void GerarSequenciaFibonacci(int quantidade)
        {
            int anterior = 1, atual = 1;

            if (quantidade >= 1)
                Console.Write(anterior);

            for (int i = 1; i < quantidade; i++)
            {
                Console.Write($", {atual}");
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine();
        }
    }
}
