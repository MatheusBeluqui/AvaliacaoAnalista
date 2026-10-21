using System;
using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");
            string entrada = Console.ReadLine() ?? "";

            StringBuilder resultado = new StringBuilder();

            foreach (char caractere in entrada)
            {
                if (resultado.Length == 0 ||
                    resultado[resultado.Length - 1] != caractere)
                {
                    resultado.Append(caractere);
                }
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
