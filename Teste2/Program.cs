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
            var input = GetUserInput();
            GenerateFibonacci(input);
        }

        static int GetUserInput()
        {
            bool validInput = false;
            string input = string.Empty;

            while (!validInput)
            {
                Console.WriteLine("Por favor digite um número entre 1 e 19:");
                input = Console.ReadLine()!;
                validInput = IsAValidNumber(input);
            }

            return int.Parse(input);
        }

        static bool IsAValidNumber(string input)
        {           
            var isNumber = int.TryParse(input, out var parsedNumber);
            if(!isNumber)
                return false;

            if (parsedNumber <= 0 || parsedNumber >= 20)
                return false;

            return true;
        }

        static void GenerateFibonacci(int input)
        {
            var returnValue = string.Empty;

            int num1 = 0;
            int num2 = 1;
            for (int i = 0; i < input; i++)
            {
                returnValue += $"{num2},";
                int temp = num1;
                num1 = num2;
                num2 += temp;
            }

            Console.WriteLine(returnValue);
        }
    }
}