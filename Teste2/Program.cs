/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

// Já fiz tantos testes com Fibonacci pra vagas

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variável que vai armazenar o número entrado
            int numero;

            Console.WriteLine("Entre com um número inteiro maior que 0 e menor que 20: ");

            // laço que repete validação enquanto não for valido
            do
            {
                if (int.TryParse(Console.ReadLine(), out numero) && numero > 0 && numero < 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada não correspondente com o solicitado! Precisa ser um número maior que 0 e menor que 20");
                }
            } while (true);

            Console.WriteLine("Sequência numérica exigida:");

            // laço pra chamar o método recursivo e colocar os resultados na tela
            for (int i = 1; i < numero; i++)
            {
                Console.Write(FibonacciRecursiva(i) + " ");
            }

            Console.WriteLine();
        }

        // método recursivo
        static int FibonacciRecursiva(int numeroEntrada)
        {

            if (numeroEntrada <= 1)
            {
                return numeroEntrada;
            }

            return FibonacciRecursiva(numeroEntrada - 1) + FibonacciRecursiva(numeroEntrada - 2);

        }
    }
}