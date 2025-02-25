/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

Console.WriteLine("Boa sorte!");

int n = GetNumero();

SeqFibonacci(n);

static int GetNumero()
{
    for (bool numeroValido = false; !numeroValido;)
    {
        Console.Write("Digite um número inteiro, positivo, entre 1 e 19: ");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            if (input > 0 && input < 20)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Valor não corresponde ao especificado entre 1 e 19.");
            }
        }
        else
        {
            Console.WriteLine("Necessário digitar um valor válido para o funcionamento correto.");
        }
    }
    return 1;
}

static void SeqFibonacci(int n)
{
    int a = 0, b = 1;

    Console.WriteLine($"Sequência de Fibonacci do número {n}: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(a + " ");
        int temp = a + b;
        a = b;
        b = temp;
    }
}