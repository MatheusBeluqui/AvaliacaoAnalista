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
            string str;

            do {
                Console.WriteLine("Digite uma string alfanumérica: ");
                str = Console.ReadLine();

                if (!string.IsNullOrEmpty(str) && str.All(c => char.IsLetterOrDigit(c))) {
                    str = str.ToUpper();

                    StringBuilder sb = new StringBuilder(str[0].ToString());

                    foreach (char c in str)
                    {
                        if (sb[sb.Length - 1] != c) sb.Append(c);
                    }

                    Console.WriteLine($"Seu resultado: {sb.ToString()}");
                    break;
                } 
                else {
                    Console.WriteLine("Sua string deve conter apenas letras e numeros!");
                }

            } while (true);
        }
    }
}