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
            // escopo de variaveis 
            int n = 0;
            bool ok = false;            
            int a = 1;
            int b = 1;

            // logica para verificar se o numero foi convertido ou nao

            while (ok == false)
            {
                Console.WriteLine("Digite um número:");

                // tenta converter a entrada para um número inteiro
                ok = int.TryParse(Console.ReadLine(), out n); // out coloca o valor convertido na variavel n

                //verificacao se o numero foi convertido ou nao
                //verifica se o numero é positivo e menor que 20
                if (ok == false || n <= 0 || n >= 20)
                {
                    Console.WriteLine("caracter invalido, Digite um numero inteiro positivo e menor que 20");
                    ok = false;
                }
            }


            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int soma = a + b;
                a = b;
                b = soma;
            }
        }
    }
}