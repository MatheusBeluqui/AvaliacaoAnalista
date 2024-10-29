/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Runtime.CompilerServices;
using System.Text;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write(
                    "Digite um número inteiro, positivo, maior que 0 e menor que 20 (ou 'sair' para encerrar): "
                );

                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Nenhum valor foi informado.");
                    continue;
                }

                if (input.Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    continuar = false;
                    break;
                }

                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("O valor informado não é um número.");
                    continue;
                }

                if (number <= 0 || number >= 20)
                {
                    Console.WriteLine("O número informado deve ser maior que 0 e menor que 20.");
                    continue;
                }

                string result = Fibonacci(number);

                Console.WriteLine($"Resultado: {result}");
                Console.WriteLine();
            }

            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        private static string Fibonacci(int number)
        {
            StringBuilder result = new StringBuilder();
            int a = 0;
            int b = 1;

            for (int i = 0; i < number; i++)
            {
                result.Append(a);
                if (i < number - 1)
                {
                    result.Append(",");
                }
                int temp = a;
                a = b;
                b = temp + b;
            }
            return result.ToString();
        }
    }
}
