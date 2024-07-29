using Teste1.Constants;
using Teste1.Entity;

namespace Teste1;


public partial class Program
{

    static void Main()
    {
        Console.WriteLine("Boa sorte!");
        Console.WriteLine(ConsoleMessage.TestTitle);

        Console.WriteLine(ConsoleMessage.Obs);

        var input = UserInput.RequestInput();
        var result = UserInput.ReturnInputWithoutDuplicates(input);

        Console.WriteLine(ConsoleMessage.OutputRequest);
        Console.WriteLine(result.ToString());
    }
}

