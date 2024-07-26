/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1
{
    public class Program
    {

        public static string? RemoveConsecutiveDuplicates(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            char previousChar = input[0];
            result.Append(previousChar);

            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar != previousChar)
                {
                    result.Append(currentChar);
                    previousChar = currentChar;
                }
            }

            return result.ToString();
        }

        public static string? Run(string? entrada)
        {
            var resultado = RemoveConsecutiveDuplicates(entrada);
            return resultado;
        }

        static void Main(string[] args)
        {
            var entrada = string.Empty;

            Console.WriteLine("Digite uma string:");
            entrada = Console.ReadLine();

            var retorno = Run(entrada);
            Console.WriteLine("Resultado:");
            Console.WriteLine(retorno);
            Console.ReadLine();
        }
    }
}