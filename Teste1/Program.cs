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
            Console.WriteLine("Digite uma string alfanumérica: ");
            string entrada = Console.ReadLine();

            string stringFormatada = StringFormatada(entrada);

            Console.WriteLine("Resultado: " + stringFormatada);

        }

        private static string StringFormatada(string entrada)
        {
            if(string.IsNullOrEmpty(entrada))
                return entrada;

            StringBuilder saida = new StringBuilder();

            for(int i = 0; i < entrada.Length; i++)
            {
                if(i == 0 || entrada[i] != entrada[i - 1])
                    saida.Append(entrada[i]);
            }

            return saida.ToString();
        }

       
    }
}