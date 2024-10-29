/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Digite uma string alfanumérica (ou 'sair' para encerrar): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Nenhum valor foi informado.");
                    continue;
                }

                if (input.Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    continuar = false;
                    break;
                }

                if (!input.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine("A string informada não é alfanumérica.");
                    continue;
                }

                if (input.Length == 1)
                {
                    Console.WriteLine("A string informada possui apenas um caractere.");
                    continue;
                }

                string result = RemoveDuplicates(input);

                Console.WriteLine($"Resultado: {result}");
                Console.WriteLine();
            }

            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        private static string RemoveDuplicates(string input)
        {
            StringBuilder result = new StringBuilder();
            char lastChar = input[0];
            result.Append(lastChar);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != lastChar)
                {
                    result.Append(input[i]);
                    lastChar = input[i];
                }
            }

            return result.ToString();
        }
    }
}
