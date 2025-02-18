/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text.RegularExpressions;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = GetUserInput();
            var returnValue = string.Empty;

            HashSet<char> charSet = [.. input];

            foreach (char c in charSet) 
            {
                returnValue += c;
            }

            Console.WriteLine(returnValue);
        }

        static string GetUserInput()
        {
            bool validInput = false;
            string input = string.Empty;

            while (!validInput)
            {
                Console.WriteLine("Por favor digite uma string alfanúmerica.");
                input = Console.ReadLine()!;
                validInput = IsAlphaNumeric(input);
            }

            return input;
        }

        static bool IsAlphaNumeric(string input)
        {
            Regex rg = new(@"^[a-zA-Z0-9]+$");
            return rg.IsMatch(input);
        }
    }
}