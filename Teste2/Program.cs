/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Diagnostics;
using System.Text;

namespace Teste2
{
    public class Program
    {

        public static string GetFibonacciSequence(int max)
        {
            StringBuilder sequence = new StringBuilder();
            int count = 1;
            AddFibonacciNumbers(max, 1, 1, sequence, count);

            if (sequence.Length > 1)
                sequence.Remove(sequence.Length - 1, 1);

            return sequence.ToString();
        }

        private static void AddFibonacciNumbers(int max, int a, int b, StringBuilder sequence, int count)
        {
            if (count > max)
                return;

            sequence.Append(a).Append(",");
            AddFibonacciNumbers(max, b, a + b, sequence, count+1);
        }

        ////////////////////////////////////////////////////////////////////////////////////
        public static string? Fibonacci(int quantidadeNumeros) 
        {
            StringBuilder sequence = new StringBuilder();
            int a = 1;
            int b = 1;

            if (a <= quantidadeNumeros)
                sequence.Append(a);

            int contador = 1;

            while (contador < quantidadeNumeros)
            {
                sequence.Append(",").Append(b);
                int temp = a;
                a = b;
                b = temp + b;
                contador++;
            }

            return sequence.ToString();
        }

        public static string? Run(string? entrada)
        {
            int quantidadeNumeros;
            string? resultado = string.Empty;

            if (int.TryParse(entrada, out quantidadeNumeros))
            {
                if (quantidadeNumeros < 0)
                    return "Valor passado não pode ser menor que zero";

                if (quantidadeNumeros == 0)
                    return "Valor passado não pode ser zero";

                if (quantidadeNumeros > 19)
                    return "Valor passado não pode ser maior que 20";

                // Recurviso desempenho exponencial (O(2^n))
                // resultado = GetFibonacciSequence(quantidadeNumeros);

                // Linear desempenho (O(n))
                resultado = Fibonacci(quantidadeNumeros);

                return resultado;
            }
            else
                return "Valor passado não é um número inteiro";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com algum valor:");
            string? entrada = Console.ReadLine();

            var result = Run(entrada);
            Console.WriteLine("Resultado:");
            Console.WriteLine(result);

            Console.WriteLine("Digite qualquer coisa para fechar");
            Console.ReadLine();
        }
    }
}