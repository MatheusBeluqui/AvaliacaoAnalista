
using System;
using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe uma sequência alfanumérica: ");
            string entrada = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Nenhum valor informado.");
                return;
            }

            string resultado = RemoverRepeticoes(entrada);

            Console.WriteLine($"Resultado: {resultado}");
        }

        private static string RemoverRepeticoes(string texto)
        {
            var resultado = new StringBuilder(texto.Length);
            char? anterior = null;

            foreach (char atual in texto)
            {
                if (atual == anterior)
                    continue;

                resultado.Append(atual);
                anterior = atual;
            }

            return resultado.ToString();
        }
    }
}
