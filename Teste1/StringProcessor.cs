using System.Text;

namespace Teste1;

public class StringProcessor
{
    public string RemoveDuplicadosConsecutivos(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder result = new StringBuilder();
        char previousChar = input[0];
        result.Append(previousChar);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != previousChar)
            {
                result.Append(input[i]);
                previousChar = input[i];
            }
        }

        return result.ToString();
    }
}
