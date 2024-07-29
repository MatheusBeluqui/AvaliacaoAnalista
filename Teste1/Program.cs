/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using Teste1.Constants;
using Teste1.InputHandler;

namespace Teste1
{
    internal partial class Program
    {
        static void Main()
        {
            User.RequestInputHandler();
        }
    }
}
