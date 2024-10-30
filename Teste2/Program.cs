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
            string entrada;
            int repeticoes;

            do
            {
                Console.WriteLine("Digite um número:");
                entrada = Console.ReadLine()!; //null-forgiving
            } while (!EntradaEhValida(entrada, out repeticoes));

            Console.Clear();


            Console.WriteLine("Resultado:");

            IEnumerable<int> fibonacci = GerarFibonacci(repeticoes);
            foreach (int numero in fibonacci)
            {
                Console.WriteLine(numero);
            }
        }

        private static bool EntradaEhValida(string entrada, out int saida)
        {
            saida = default;

            int saidaIntermediaria;
            bool ehInt = int.TryParse(entrada, out saidaIntermediaria);

            if (!ehInt)
            {
                return false;
            }

            bool ehPositivoSemZero = saidaIntermediaria > 0;
            bool ehMenorQueVinte = saidaIntermediaria < 20;
            bool ehValido = ehPositivoSemZero && ehMenorQueVinte;

            if (ehValido)
            {
                saida = saidaIntermediaria;
            }

            return ehValido;
        }

        //retorna um IEnumerable pois não é responsabilidade do método exibir esses dados para o usuário
        private static IEnumerable<int> GerarFibonacci(int repeticoes)
        {
            int ultimo = 1;
            int anteriorAoUltimo = 0;

            //a primeira iteração já possui um resultado conhecido (1), portanto, continua a partir da segunda
            yield return ultimo;

            int repeticoesReais = repeticoes - 1;
            for (int i = 0; i < repeticoesReais; i++)
            {
                int atual = ultimo + anteriorAoUltimo;

                anteriorAoUltimo = ultimo;
                ultimo = atual;

                yield return atual;
            }
        }
    }
}