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
            Console.WriteLine("Digite um texto qualquer, com letras e/ou números");
            
			string input = Console.ReadLine();
            string result = RemoveNearDulicate(input);

            Console.WriteLine($"Retorno sem repetidos {result}");
        }

        /// <summary>
        /// Function that will remove identical near charecters
        /// </summary>
        /// <param name="input">Value that is passed by user</param>
        /// <returns>New string with no chars repeated</returns>
        static string RemoveNearDulicate(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] chars = input.ToCharArray(); 
            char prevChar = chars[0];
            string output = prevChar.ToString();

			for (int i = 0; i < chars.Length; i++)
			{
                if (!chars[i].Equals(prevChar)) { 
                    output += chars[i];
                    prevChar = chars[i];
                }
			}

            return output;
		}
    }
}