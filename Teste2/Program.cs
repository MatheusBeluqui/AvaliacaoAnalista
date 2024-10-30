/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Text;
using System.Text.RegularExpressions;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade da sequência de Fibonacci que deseja gerar. (Deve ser um numero de 1 a 19)");
            string fibonacciSequenceLength = Console.ReadLine() ?? string.Empty;

            if (ValidateInput(fibonacciSequenceLength))
            {
                List<int> fibonacciSequence = GenerateFibonacciSequence(int.Parse(fibonacciSequenceLength));

                StringBuilder result = new StringBuilder();
                result.Append("Sequência de Fibonacci gerada: ");
                foreach (int number in fibonacciSequence)
                {
                    result.Append(number + ", ");
                }

                Console.WriteLine(result.ToString().TrimEnd(','));
            }
        }

        public static bool ValidateInput(string fibonacciSequenceLength)
        {

            if (string.IsNullOrEmpty(fibonacciSequenceLength))
            {
                Console.WriteLine("O campo não pode ser vazio.");
                return false;
            }

            if (!Regex.IsMatch(fibonacciSequenceLength, @"^\d+$"))
            {
                Console.WriteLine("A quantidade de repetições deve conter apenas números.");
                return false;
            }

            if (int.Parse(fibonacciSequenceLength) <= 0 || int.Parse(fibonacciSequenceLength) >= 20)
            {
                Console.WriteLine("A quantidade da sequência deve ser de 1 a 19.");
                return false;
            }

            return true;
        }

        public static List<int> GenerateFibonacciSequence(int fibonacciSequenceLength)
        {
            List<int> fibonacciSequence = new List<int>();

            for (int i = 0; i < fibonacciSequenceLength; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciSequence.Add(1);
                }
                else
                {
                    fibonacciSequence.Add(fibonacciSequence[i - 1] + fibonacciSequence[i - 2]);
                }
            }
            return fibonacciSequence;
        }

    }
}