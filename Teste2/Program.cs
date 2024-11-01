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
            Console.WriteLine("Digite um número qualquer: ");
            string input = Console.ReadLine();


            bool isValid = IsNumberValid(input);

            if (isValid)
                Console.WriteLine("número valido");

            Console.WriteLine(GetFibonacciSequence(10));
        }

        private static bool IsNumberValid(string input)
        {
            bool isInteger = int.TryParse(input, out int nvalid);

            //valida um número inteiro
            if (!isInteger)
            {
                Console.WriteLine($"Numero Invalido. Numero informado não é inteiro");
                return false;
            }

            if (nvalid <= 0 || nvalid > 20)
            {
                Console.WriteLine($"Numero invalido. Negativo ou maior que 20.");
                return false;
            }

            return true;
        }

        private static string GetFibonacciSequence(int count)
        {

            int[] fibonacciNumbers = new int[count];

            fibonacciNumbers[0] = 1;
            if (count > 1) fibonacciNumbers[1] = 1;

            for (int i = 2; i < count; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            return string.Join(", ", fibonacciNumbers);
        }
    }
}