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
            Console.Write("Digite um número inteiro entre 1 e 19: ");
            var textoNumero = Console.ReadLine();

            if (!ValidarNumero(textoNumero)) return;

            var numero = Convert.ToInt32(textoNumero);
            var sequenciaFibonacci = GerarSequenciaFibonacci(numero);

            Console.WriteLine(string.Join(", ", sequenciaFibonacci));
        }

        private static bool ValidarNumero(string? textoNumero)
        {
            if (string.IsNullOrEmpty(textoNumero))
            {
                Console.WriteLine("O número não pode estar em branco.");
                return false;
            }

            int numero;
            if (!int.TryParse(textoNumero, out numero))
            {
                Console.WriteLine("O número precisa ser um inteiro.");
                return false;
            }

            if (numero <= 0)
            {
                Console.WriteLine("O número precisa ser maior do que 0.");
                return false;
            }

            if (numero >= 20)
            {
                Console.WriteLine("O número precisa ser menor do que 20.");
                return false;
            }

            return true;
        }

        private static List<int> GerarSequenciaFibonacci(int quantidade)
        {
            var sequenciaFibonacci = new List<int>();

            var primeiro = 1;
            var segundo = 1;

            for (int i = 0; i < quantidade; i++)
            {
                sequenciaFibonacci.Add(primeiro);

                var proximo = primeiro + segundo;

                primeiro = segundo;
                segundo = proximo;
            }

            return sequenciaFibonacci;
        }
    }
}