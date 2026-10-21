/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número. 
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            while (true)
            {
                Console.Write("Digite um numero inteiro entre 1 e 19: ");
                string entrada = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(entrada, out quantidade) && quantidade > 0 && quantidade < 20)
                {
                    break;
                }

                //Valida o numero digitado e retorna msg especficia
                if(quantidade <= 0)
                {
                    Console.WriteLine("O numero deve ser maior que 0.");
                }
                else if (quantidade >= 20)
                {
                    Console.WriteLine("O numero deve ser menor que 20.");
                }
                else
                {
                    Console.WriteLine("Digite um numero inteiro válido.");
                }
            }

            List<long> sequencia = new();
            long anterior = 1;
            long atual = 1;

            for (int i = 0; i < quantidade; i++)
            {
                sequencia.Add(anterior);
                long proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine($"Sequência: {string.Join(", ", sequencia)}");
        }
    }
}