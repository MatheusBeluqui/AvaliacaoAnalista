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
            int quantidadeRepeticoes = 0; 
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Digite um número inteiro (1 a 19) para a sequência de Fibonacci: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out quantidadeRepeticoes))
                {
                    if (quantidadeRepeticoes > 0 && quantidadeRepeticoes < 20)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Número fora do intervalo válido (1 a 19). Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                }
            }

            Console.WriteLine($"Sequência de Fibonacci com {quantidadeRepeticoes} números:");

            int[] arrayFibonacci = GerarSequenciaFibonnacci(quantidadeRepeticoes);
            foreach (int fibonacci in arrayFibonacci)
            {
                Console.Write(fibonacci + " ");
            }

            Console.WriteLine();
        }

        static int[] GerarSequenciaFibonnacci(int quantidadeRepeticoes)
        {
            int[] fibonacci = new int[quantidadeRepeticoes];
            if (quantidadeRepeticoes >= 1)
            {
                fibonacci[0] = 1;
            }
            if (quantidadeRepeticoes >= 2)
            {
                fibonacci[1] = 1;
            }
            for (int i = 2; i < quantidadeRepeticoes; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

    }
}