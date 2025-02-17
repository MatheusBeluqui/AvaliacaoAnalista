/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

using System.Globalization;
using System.Text;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;

            do
            {
                Console.WriteLine("Digite um número entre 0 e 20 para sua sequência fibonacci: ");
                num = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(num) && int.TryParse(num, out int n) && 
                    (n > 0 && n < 20))
                {
                    int reps = n;
                    List<string> numbers = new List<string>() { "0" };
                    int num1 = 0, num2 = 1;

                    for (int i = 1; i < reps; i++)
                    {
                        numbers.Add(num2.ToString());
                        int temp = num1;
                        num1 = num2;
                        num2 += temp;
                    }

                    Console.WriteLine($"Sua sequência fibonacci com {reps} numeros é: {string.Join(", ", numbers)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Você deve informar um número maior que 0 e menor 20!");
                }

            } while (true);
        }
    }
}