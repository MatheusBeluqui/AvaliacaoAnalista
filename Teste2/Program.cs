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
            int number;
            while (true)
            {
                
            Console.WriteLine("Digite um numero entre 0 e 20: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out number) && number > 0 && number < 20)

                {
                    break;
                }

                Console.WriteLine("Numero invalido. Tente novamente! ");
          
            }

            int previous = 1;
            int current = 1;

            for (int i = 0; i < number; i++)
            {
                Console.Write(previous);

                if (i< number - 1)
                {
                    Console.Write(", ");
                }

                int next = previous + current;
                previous = current;
                current = next;
            }

            Console.WriteLine();

        }
    }
}