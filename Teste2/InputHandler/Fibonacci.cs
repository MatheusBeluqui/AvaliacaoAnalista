using Teste2.Constants;

namespace Teste2.InputHandler
{
    internal static class Fibonacci
    {
        public static void RequestInputHandler()
        {
            Console.WriteLine(ConsoleMessage.Obs);

            string input;

            do
            {
                Console.WriteLine(ConsoleMessage.InputRequest);

                input = Console.ReadLine()!;
            } while (!ValidationInput(
                input)
            );
            
            GenerateSequence(int.Parse(input!));
        }

        private static bool ValidationInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            var parse = int.TryParse(input, out int numberOfTerms);

            if (!parse)
                return false;

            return parse && numberOfTerms > 0 && numberOfTerms < 20;
        }

        private static void GenerateSequence(int terms)
        {
            int[] sequence = new int[terms];

            if (terms >= 1) sequence[0] = 1;
            if (terms >= 2) sequence[1] = 1;

            for (int i = 2; i < terms; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }

            DisplaySequence(sequence);
        }

        private static void DisplaySequence(int[] sequence)
        {
            Console.WriteLine(ConsoleMessage.OutputSequenceRequested);

            foreach (int number in sequence)
            {
                Console.Write(number + " ");
            }
        }
    }
}
