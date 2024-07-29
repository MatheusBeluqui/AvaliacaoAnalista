using System.Text;
using System.Text.RegularExpressions;
using Teste1.Constants;
using Teste1.Helper;

namespace Teste1.InputHandler
{
    internal static partial class User
    {
        public static void RequestInputHandler()
        {
            string input;

            Console.WriteLine(ConsoleMessage.TestTitle);

            Console.WriteLine(ConsoleMessage.Obs);

            do
            {
                Console.WriteLine(ConsoleMessage.InputRequest);
                input = Console.ReadLine()!;
            } while (string.IsNullOrEmpty(input) || MyRegex().IsMatch(input));

            DistinctDuplicateValues(input);
        }

        private static void DistinctDuplicateValues(string input)
        {
            HashSet<char> charsControl = [];
            StringBuilder result = new();

            var uniqueChars = input
                .ToUpper()
                .Distinct()
                .Where(c => charsControl.Add(c))
                .ToList();

            result.AppendJoin("", uniqueChars);

            DisplayDistinctInputValue(result);
        }

        private static void DisplayDistinctInputValue(
            StringBuilder result)
        {
            Console.WriteLine(ConsoleMessage.OutputRequest);

            Console.WriteLine(result);
        }

        [GeneratedRegex(RegexPattern.SpacesPattern)]
        private static partial Regex MyRegex();
    }
}
