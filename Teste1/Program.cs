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
            Console.Write("Digite um texto alfanumérico: ");
            var texto = Console.ReadLine();

            if (!ValidarTexto(texto)) return;

            var textoSemDuplicadosProximos = RemoverDuplicadosProximos(texto);

            Console.WriteLine("Resultado: " + textoSemDuplicadosProximos);
        }

        private static bool ValidarTexto(string? texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("O texto não pode estar em branco.");
                return false;
            }

            if (!SomenteAlfaNumerico(texto))
            {
                Console.WriteLine("O texto precisa ser alfanumérico");
                return false;
            }

            return true;
        }

        static bool SomenteAlfaNumerico(string texto)
        {
            foreach (var caracter in texto)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    return false;
                }
            }

            return true;
        }

        static string RemoverDuplicadosProximos(string texto)
        {
            var novoTexto = string.Empty;

            for (var i = 0; i < texto.Length; i++)
            {
                if (i == 0 || texto[i] != texto[i - 1])
                {
                    novoTexto += texto[i];
                }
            }

            return novoTexto;
        }
    }
}