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
            IniciarInterfaceInterativa();
        }

        private static void IniciarInterfaceInterativa()
        {
            Console.WriteLine($"Digite uma string alfanumérica: ");

            string? entrada = Console.ReadLine();

            if (!string.IsNullOrEmpty(entrada))
                Console.WriteLine(Regex.Replace(entrada, @"(.)\1+", "$1"));
        }
    }
}