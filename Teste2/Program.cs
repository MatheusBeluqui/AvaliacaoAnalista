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
            Console.WriteLine("Digite um número inteiro e maior que zero...");
            int input;

            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0 || input > 20) 
            {
				Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo, maior que 0 e menor que 20:");
			}

            var output = GetSequence(input);

            Console.WriteLine($"A sequência gerada é {output}");
        }

        static int SumValues(List<int> values)
        {
            int penultimateValue = values[values.Count - 2];
            int lastValue = values[values.Count - 1];

            return penultimateValue + lastValue;
        }

        static string GetSequence(int input)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < input; i++)
            {
                int currentValue = output.Count < 2 ? 1 : SumValues(output);
                output.Add(currentValue);
            }

            return String.Join(" ", output);
        }
    }


}