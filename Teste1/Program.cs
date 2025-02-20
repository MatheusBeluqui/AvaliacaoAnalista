/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text.RegularExpressions;
using Teste1.Core;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string alfanumérica:");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !ValidarEntrada(input))
            {
                Console.WriteLine("Entrada inválida. Digite apenas caracteres alfanuméricos.");
                return;
            }

            string resultado = input.RemoverDuplicatasProximas();

            Console.WriteLine(resultado);
        }

        /// <summary>
        /// Valida se a string contém apenas caracteres alfanuméricos (letras e números).
        /// </summary>
        private static bool ValidarEntrada(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
        }
    }
}