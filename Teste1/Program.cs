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
            var input = string.Empty;
            do
            {
                Console.Write("Digite uma string alfanumérica: ");
                input = Console.ReadLine();
            } while (!isInputValid(input));

            var result = new string([.. input.Where((c, index) => index == 0 || c != input[index - 1])]);

            Console.WriteLine($"Resultado: {result}");
        }

        private static bool isInputValid(string input)
        {
            if (input.All(c => Char.IsLetterOrDigit(c))) return true;

            Console.WriteLine("A entrada possui caracteres não alfanumérico");
            return false;
        }
    }
}