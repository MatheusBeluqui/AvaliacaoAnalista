/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica. (OK)
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos. (OK)
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");
            string valor = Console.ReadLine() ?? string.Empty;

            if (valor.Length == 0 || valor.Any(c => !char.IsLetterOrDigit(c)))
            {
                Console.WriteLine("Digite apenas letras e números.");
                return;
            }

            string result = string.Empty;
            //c ->  char do caractere
            foreach (char c in valor)
            {
                if (result.Length == 0 || result[^1] != c)
                {
                    result += c;
                }
            }

            Console.WriteLine($"Resultado: {result}");
        }
    }
}