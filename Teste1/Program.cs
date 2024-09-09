/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite uma string alfanumérica:");
            string input = Console.ReadLine();

            string result = RemoveAdjacentDuplicates(input);

            Console.WriteLine("Resultado: " + result);
        }

        static string RemoveAdjacentDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var cleanedString = "";
            cleanedString += input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    cleanedString += input[i];
                }
            }

            return cleanedString;
        }
    }
}