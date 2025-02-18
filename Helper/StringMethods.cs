using System.Text.RegularExpressions;

namespace Helper
{
    public static partial class StringMethods
    {
        /// <summary>
        /// Checks if the entered text is alphanumeric 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsAlphanumericText(this string text) => Regex.IsMatch(text, @"^[a-zA-Z0-9]+$");

        /// <summary>
        ///  Checks if the entered text is numeric 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNumericText(this string text) => Regex.IsMatch(text, @"^[0-9]+$");

        /// <summary>
        /// Remove all consecutive duplicates
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemoveConsecutiveDuplicates(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            char previous = text[0];
            string result = previous.ToString();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != previous)
                {
                    result += text[i];
                    previous = text[i];
                }
            }

            return result;
        }
    }
}