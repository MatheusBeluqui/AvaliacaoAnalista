namespace Helper
{
    public static partial class Util
    {
        public static List<int> GetFibonacciFrom(int start, int count)
        {
            List<int> sequence = [];
            int a = 0, b = 1, next;

            // Find the first Fibonacci number greater than or equal to start
            while (a < start)
            {
                next = a + b;
                a = b;
                b = next;
            }

            // Generate the Fibonacci sequence
            for (int i = 0; i < count; i++)
            {
                sequence.Add(a);
                next = a + b;
                a = b;
                b = next;
            }

            return sequence;
        }
    }
}
