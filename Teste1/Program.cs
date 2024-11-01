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

            Console.WriteLine("Digite uma palavra qualquer: ");
            string input = Console.ReadLine();


            input = RemoveDuplicidade(input);

            Console.WriteLine(input);
        }

        private static string RemoveDuplicidade(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return input;

            int i = 0;
            string ninput = input[i].ToString();

            for (i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                    ninput += input[i];
            }

            return ninput;
        }
    }
}