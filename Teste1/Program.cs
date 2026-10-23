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
            Console.WriteLine("Digite uma string alfanumérica:");
            string texto = Console.ReadLine() ?? "";

            string resultado = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 0 || texto[i] != texto[i - 1])
                {
                    resultado += texto[i];
                }
            }

            Console.WriteLine(resultado);
        }
    }
}
