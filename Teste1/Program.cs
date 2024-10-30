/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;
using System.Text.RegularExpressions;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o campo em alfanumérico (A-Z, a-z, 0-9):");
            string input = Console.ReadLine() ?? string.Empty;

            if (ValidateInput(input))
            {
                string result = input.Length > 1 ? RemoveDuplicates(input) : input;
                Console.WriteLine($"Resultado: {result}");
            }
        }

        public static bool ValidateInput(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("O campo não pode ser vazio.");
                return false;
            }

            if (!Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"))
            {
                Console.WriteLine("O campo deve conter apenas letras e números (A-Z, a-z, 0-9).");
                return false;
            }

            return true;
        }

        public static string RemoveDuplicates(string input)
        {
            StringBuilder result = new StringBuilder();
            char lastChar = '\0';

            foreach (char c in input)
            {
                if (c != lastChar)
                {
                    result.Append(c);
                    lastChar = c;
                }
            }

            return result.ToString();
        }
    }
}