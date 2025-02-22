/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

Console.WriteLine("Boa sorte!");

Console.Write("Digite uma string alfanumérica: ");
string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Necessário digitar algum valor para o funcionamento correto");
    return;
}

string result = ExcluiDuplicados(input);
Console.WriteLine($"Retorno: {result}");

string ExcluiDuplicados(string input)
{
    var result = new StringBuilder();
    result.Append(input[0]);

    for (int i = 1; i < input.Length; i++)
    {
        if (input[i] != input[i - 1])
        {
            result.Append(input[i]);
        }
    }

    return result.ToString();
}
