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
            string entrada;

            do
            {
                Console.WriteLine("Digite uma string alfanumérica:");
                entrada = Console.ReadLine()!; //null-forgiving
            } while (string.IsNullOrEmpty(entrada) || !entrada.All(char.IsLetterOrDigit));

            Console.Clear();

            string saida = RemoverCaracteresDuplicados(entrada);
            Console.WriteLine("Resultado");
            Console.WriteLine($"Entrada: {entrada}");
            Console.WriteLine($"Saída:   {saida}");
        }

        private static string RemoverCaracteresDuplicados(string entrada)
        {
            char comparador = entrada[0];
            StringBuilder saida = new StringBuilder();

            //a string builder já terá o primeiro caractere inclusa
            saida.Append(comparador);

            for (int i = 1; i < entrada.Length; i++)
            {
                char atual = entrada[i];

                // pula a iteração caso seja um caractere repetido
                if (atual == comparador)
                {
                    continue;
                }

                //concatena o atual a saida e troca o valor do comparador
                saida.Append(atual);
                comparador = atual;
            }
            
            return saida.ToString();
        }
    }
}