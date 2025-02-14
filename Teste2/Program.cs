/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Text.RegularExpressions;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo menor que 20: ");
            string input = Console.ReadLine();

            if (!isValidNumber(input))
            {
                Console.WriteLine("Digite um número válido!");

                return;
            }

            string result = generateFibonacciSequence(int.Parse(input));

            Console.WriteLine($"Sequência Fibonacci gerada: {result}");
        }

        static bool isValidNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                return false;
            }

            int parsedInput = int.Parse(input);

            return parsedInput > 0 && parsedInput < 20;
        }

        static string generateFibonacciSequence(int input)
        {
            string result = "";
            int penultimateNumber = 0;
            int lastNumber = 0;

            for (int i = 0; i < input; i++)
            {
                if (i == 0)
                {
                    result += 1;
                    lastNumber = 1;
                }
                else
                {
                    int calculation = penultimateNumber + lastNumber;
                    result += ", " + calculation;
                    penultimateNumber = lastNumber;
                    lastNumber = calculation;
                }
            }

            return result;
        }
    }
}