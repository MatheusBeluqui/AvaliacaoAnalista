namespace Teste2.Services
{
    public static class FibonacciService
    {
        /// <summary>
        /// Valida se a entrada é um número inteiro positivo entre 1 e 19.
        /// </summary>
        public static bool ValidarEntrada(string input, out int numero)
        {
            bool isValid = int.TryParse(input, out numero) && numero > 0 && numero < 20;
            return isValid;
        }

        /// <summary>
        /// Gera a sequência de Fibonacci até o número especificado.
        /// </summary>
        public static List<int> GerarFibonacci(int n)
        {
            if (n <= 0 || n >= 20)
                return [];

            List<int> fibonacci = [1];

            if (n == 1)
                return fibonacci;

            fibonacci.Add(1);

            for (int i = 2; i < n; i++)
            {
                int proximoNumero = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(proximoNumero);
            }

            return fibonacci;
        }
    }
}
