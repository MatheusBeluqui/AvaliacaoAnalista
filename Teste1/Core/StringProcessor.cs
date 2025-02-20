using System.Text;

namespace Teste1.Core
{
    /// <summary>
    /// Serviço responsável pelo processamento de textos.
    /// </summary>
    public static class StringProcessor
    {
        /// <summary>
        /// Remove caracteres consecutivos duplicados da string.
        /// </summary>
        public static string RemoverDuplicatasProximas(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var resultado = new StringBuilder();
            resultado.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                    resultado.Append(input[i]);
            }

            return resultado.ToString();
        }
    }
}
