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
        private const int MenorValor = 0;
        private const int MaiorValor = 20;
        static void Main(string[] args)
        {
            IniciarInterfaceInterativa();
        }

        private static void IniciarInterfaceInterativa()
        {
            string? entrada;
            int numero;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Digite um número inteiro maior que {MenorValor} e menor que {MaiorValor}: ");
                entrada = Console.ReadLine();                
            }
            while (!ValidaEntrada(entrada, out numero));

            Console.WriteLine(GerarFibonacci(numero));
        }

        private static string GerarFibonacci(int numero)
        {
            List<int> sequencia = [];
            int penultimo = 0;
            int ultimo = 1;

            for (int i = 0; i < numero; i++)
            {
                sequencia.Add(ultimo);
                int proximo = ultimo + penultimo;
                penultimo = ultimo;
                ultimo = proximo;
            }

            return string.Join(", ", sequencia);
        }

        private static bool ValidaEntrada(string? entrada, out int numero)
        {            
            if (!int.TryParse(entrada, out numero))
            {
                GerarErro($"Digite apenas números inteiros!");
                return false;
            }
            if(numero < MenorValor || numero > MaiorValor)
            {
                GerarErro($"Digite apenas números inteiros positivos maiores que {MenorValor} e menores que {MaiorValor}!");
                return false;
            }
            return true;
        }

        private static void GerarErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}