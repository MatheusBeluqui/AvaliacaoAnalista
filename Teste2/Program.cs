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
        static void Main()
        {
            int n;

            while (true)
            {
                Console.WriteLine("Digite um número inteiro positivo maior que 0 e menor que 20:");

                if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo entre 1 e 19.");
                }
            }

            Console.WriteLine("Sequência de Fibonacci com " + n + " termos:");
            PrintFibonacciSequence(n);
        }

        static void PrintFibonacciSequence(int num)
        {
            int previous = 1, current = 1;

            if (num >= 1) Console.Write(previous + ",");
            if (num >= 2) Console.Write(current);

            for (int i = 3; i <= num; i++)
            {
                int next = previous + current;
                Console.Write("," + next);
                previous = current;
                current = next;
            }

            Console.WriteLine();
        }
    }
}