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
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");

            Console.WriteLine($"Resultado: {RemoveDuplicata(Console.ReadLine())}");
        }

        static string RemoveDuplicata(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] resultado = new char[input.Length];
            int index = 0;

            resultado[index++] = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    resultado[index++] = input[i];
                }
            }

            return new string(resultado);
        }
    }
}