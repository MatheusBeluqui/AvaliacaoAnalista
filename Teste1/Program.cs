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
            string? entrada;

            while (true)
            {
                Console.Write("Digite uma string alfanumérica: ");
                entrada = Console.ReadLine();

                if (entrada == null)
                    return;

                if (entrada.Length > 0 && entrada.All(char.IsLetterOrDigit))
                    break;

                Console.WriteLine("Entrada inválida, digite apenas letras e números");
            }

            var resultado = new StringBuilder();

            foreach (char c in entrada)
            {
                if (resultado.Length == 0 || resultado[resultado.Length - 1] != c)
                    resultado.Append(c);
            }

            Console.WriteLine($"Retorno: {resultado}");
        }
    }
}
