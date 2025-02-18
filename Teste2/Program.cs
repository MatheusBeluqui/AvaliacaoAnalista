/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    class Program
    {
        public static void Main()
        {
            int n;

            Console.WriteLine("Digite um número inteiro entre 1 e 20:");

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n >= 20)
            {
                Console.WriteLine("Número inválido! Por favor, digite um número entre 1 e 20:");
            }

            int[] fibonacci = new int[n];
        
            if (n > 0) fibonacci[0] = 1;
            if (n > 1) fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine("Sequência de Fibonacci:");
            foreach (var num in fibonacci)
            {
                Console.Write(num + " ");
            }
        }
    }
}