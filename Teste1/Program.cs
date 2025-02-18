/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using Helper;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(CustomMessage.MSG0001);
                var input = Console.ReadLine();

                if (input.IsAlphanumericText())
                {
                    var result = input.RemoveConsecutiveDuplicates();

                    Console.WriteLine($"Resultado: {result}");
                    break;
                }
                else
                    Console.WriteLine(CustomMessage.MSG0002);
            }
        }
    }
}