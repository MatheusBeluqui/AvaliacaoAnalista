/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.Write("Digite um número inteiro positivo entre 1 e 19: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out number) && number > 0 && number < 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                }
            }

            Console.WriteLine($"Sequência de Fibonacci com {number} termos:");

            for (int i = 0; i < number; i++)
                Console.Write(Fibonacci(i) + " ");

            Console.WriteLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}