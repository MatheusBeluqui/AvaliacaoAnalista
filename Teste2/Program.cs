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

            Console.Write("Digite um número entre 1 e 19: ");

            while (!int.TryParse(Console.ReadLine(), out quantidade) ||
                   quantidade <= 0 || quantidade >= 20)
            {
                Console.Write("Número inválido. Digite um inteiro entre 1 e 19: ");
            }

            int anterior = 1;
            int atual = 1;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(anterior);

                if (i < quantidade - 1)
                    Console.Write(", ");

                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine();
        }
    }
}
