/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Digite uma string alfanumérica:");
                string input = Console.ReadLine();

                string resultado = RemoveNearbyDuplicates(input);

                Console.WriteLine($"Resultado modificado: {resultado}");

                string resposta = AskWantContinue();

                if (resposta == "n")
                {
                    Console.WriteLine("Aplicação encerrada!");
                    break;
                }
            }
        }

        public static string RemoveNearbyDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            string resultado = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || input[i] != input[i - 1])
                    resultado += input[i];
            }

            return resultado;
        }

        public static string AskWantContinue()
        {
            string resposta;
            while (true)
            {
                Console.WriteLine("Deseja continuar? (s/n)");
                resposta = Console.ReadLine().ToLower();

                // Utiliza o switch para verificar a resposta
                switch (resposta)
                {
                    case "s":
                        return resposta;
                    case "n":
                        return resposta;
                    default:
                        Console.WriteLine("Resposta inválida! Por favor, digite 's' para sim ou 'n' para não.");
                        break;
                }
            }
        }
    }
}