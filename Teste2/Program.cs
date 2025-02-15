/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            do
            {

                Console.Write("Digite um numero entre 1 e 19: ");
                input = Console.ReadLine();
            }
            while (!isValidInput(input));

            Console.WriteLine($"Resultado: {calcFibonnaci(Convert.ToInt32(input))}");
        }


        private static int calcFibonnaci(int n)
        {
            if (n == 1 || n == 2) return 1;

            return calcFibonnaci(n - 1) + calcFibonnaci(n - 2);
        }

        private static bool isValidInput(string input)
        {
            if (!int.TryParse(input, out int numero))
            {
                Console.WriteLine("A entrada deve ser um numero inteiro");
                return false;
            }

            if (numero <= 0)
            {
                Console.WriteLine("O número deve ser maior do que 0");
                return false;
            }

            if (numero >= 20)
            {
                Console.WriteLine("O número deve ser menor do que 20");
                return false;
            }

            return true;
        }
    }
}