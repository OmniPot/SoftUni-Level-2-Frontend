namespace _1_StringBuilder_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder sb, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex > sb.Length - 2 || startIndex >= endIndex)
            {
                throw new ArgumentOutOfRangeException(
                    "Start index must be greater than the end index, less than the StringBuilder length - 2 and greater than or equal to 0!");
            }

            if (endIndex < 0 || endIndex > sb.Length - 1 || endIndex <= startIndex)
            {
                throw new ArgumentOutOfRangeException(
                    "End index must be greater than the start index, less than the StringBuilder length - 1 and greater than or equal to 1!");
            }

            return sb.ToString().Substring(startIndex, endIndex - startIndex);
        }

        public static StringBuilder RemoveText(this StringBuilder sb, string textToRemove)
        {
            if (sb.ToString().IndexOf(textToRemove) == -1)
            {
                throw new ArgumentException("The string builder must contain the specified text to be removed.");
            }

            if (string.IsNullOrEmpty(textToRemove))
            {
                throw new ArgumentNullException("The string to remove cannot be empty or null.");
            }

            int startPosition = sb.ToString().IndexOf(textToRemove);
            int endPosition;

            while (startPosition >= 0)
            {
                endPosition = startPosition + textToRemove.Length;
                sb.Remove(startPosition, endPosition - startPosition);
                startPosition = sb.ToString().IndexOf(textToRemove);
            }

            return sb;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder sb, IEnumerable<T> items)
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException("Specified collection to append cannot be empty.");
            }

            foreach (var item in items)
            {
                sb.Append(item.ToString());
            }

            return sb;
        }
    }
}
