﻿/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Linq;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número inteiro positivo entre, maior que 0 e menor que 20: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0 || numero >= 20);

            Console.WriteLine($"Sequência de Fibonacci: {GeraFibonacci(numero)}");
        }

        static string GeraFibonacci(int n)
        {
            List<int> sequencia = new List<int> { 1, 1 };

            for (int i = 2; i < n; i++)
            {
                sequencia.Add(sequencia[i - 1] + sequencia[i - 2]);
            }

            return string.Join(", ", sequencia.GetRange(0, n));
        }
    }
}