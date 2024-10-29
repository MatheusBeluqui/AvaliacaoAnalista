/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string alfanumérica:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            string resultado = RemoverDuplicatasConsecutivas(input);
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
        }

        static string RemoverDuplicatasConsecutivas(string input)
        {
            if (input.Length < 2)
                return input;

            char ultimoChar = input[0];
            string resultado = ultimoChar.ToString();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != ultimoChar)
                {
                    resultado += input[i];
                    ultimoChar = input[i];
                }
            }

            return resultado;
        }
    }
}
