/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Drawing;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa vai receber um número entre 1 e 20 e mostrar a quantidade desse numero na sequencia de Fibonacci");
            Console.WriteLine("Digite o Número");
            string? numero = Console.ReadLine();
            int numeroValido = ValidarNumero(numero);
            Console.WriteLine("Como quer que o problema seja resolvido? Digite 1 para o modo interativo ou 2 para o modo recursivo");
            string? opcao = Console.ReadLine();
            switch(opcao)
            {
                case "1":
                    ResolverModoInterativo(numeroValido);
                    break;
                case "2":
                    Console.WriteLine("Sequência de Fibonacci:");
                    for (int i = 0; i < numeroValido; i++)
                    {
                        Console.Write(ResolverModoRecursivo(i) + " ");
                    }
                    break;
                default: throw new ArgumentException("Opção invalida. Por favor digitar 1 ou 2");
            };
        }

        private static int? ResolverModoRecursivo(int numeroValido)
        {
            if (numeroValido <= 1)
                return numeroValido;
            return ResolverModoRecursivo(numeroValido - 1) + ResolverModoRecursivo(numeroValido - 2);
        }

        private static void ResolverModoInterativo(int numeroValido)
        {
            int primeiro = 0, segundo = 1;

            for (int i = 0; i < numeroValido; i++)
            {
                Console.Write(primeiro + " ");
                int proximo = primeiro + segundo;
                primeiro = segundo;
                segundo = proximo;
            }
        }

        private static int ValidarNumero(string? numero)
        {
            if (int.TryParse(numero, out int n) && n > 0 && n < 20)
                return n;
            else
                throw new ArgumentException("Por favor digite um número inteiro e que esteja entre 1 e 20");
        }
    }
}