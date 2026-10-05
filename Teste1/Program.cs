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
            string entrada = LerStringAlfanumerica();
            string resultado = RemoverDuplicadosAdjacentes(entrada);

            Console.WriteLine($"Retorno: {resultado}");
        }

        static string LerStringAlfanumerica()
        {
            while (true)
            {
                Console.Write("Digite uma string alfanumérica: ");
                string? entrada = Console.ReadLine();

                if (entrada is null)
                {
                    Console.WriteLine("Nenhuma entrada recebida. Encerrando.");
                    Environment.Exit(1);
                }

                entrada = entrada.Trim();

                if (entrada.Length > 0 && entrada.All(char.IsLetterOrDigit))
                    return entrada;

                Console.WriteLine("Entrada inválida: digite apenas letras e números, sem espaços ou símbolos.");
            }
        }

        static string RemoverDuplicadosAdjacentes(string texto)
        {
            var resultado = new StringBuilder(texto.Length);

            foreach (char caractere in texto)
            {
                if (resultado.Length == 0 || resultado[resultado.Length - 1] != caractere)
                    resultado.Append(caractere);
            }

            return resultado.ToString();
        }
    }
}
