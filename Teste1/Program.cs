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
            Console.WriteLine("Digite uma string alfanumérica (apenas letras e números):");
            string input = Console.ReadLine();

            if (!IsValidString(input))
            {
                Console.WriteLine("Digite uma string válida!");

                return;
            }

            string result = input.Length == 1 ? input : RemoveDuplicate(input);

            Console.WriteLine($"string alfanumérica com duplicatas removidas: {result}");
        }

        static bool IsValidString(string input)
        {
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }

        static string RemoveDuplicate(string input)
        {
            char lastLetter = default;
            string result = lastLetter.ToString();

            foreach (char letter in input)
            {
                if (lastLetter != letter)
                {
                    result += letter;
                    lastLetter = letter;
                }
            }

            return result;
        }
    }
}