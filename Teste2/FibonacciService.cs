namespace Teste2;

public class FibonacciService
{
    public List<int> GerarFibonacci(int n)
    {
        List<int> fibonacci = new List<int> { 1, 1 };

        for (int i = 2; i < n; i++)
        {
            fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
        }

        return fibonacci.GetRange(0, n);
    }
}
