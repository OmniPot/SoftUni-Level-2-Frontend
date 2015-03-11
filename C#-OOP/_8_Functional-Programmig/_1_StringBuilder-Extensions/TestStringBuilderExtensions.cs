namespace _1_StringBuilder_Extensions
{
    using System;
    using System.Linq;
    using System.Text;

    public class TestStringBuilderExtensions
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Az sym Rumen nai golemiq gazar!");

            // StringBuilder.Substring() method demo
            Console.WriteLine("Substring of the strinbuilder: " + sb.Substring(7, 13));
            Console.WriteLine();

            // StringBuilder.RemoveText() method demo
            sb.RemoveText("Rumen ");
            Console.WriteLine("Removed: \"Rumen \"\nResult: " + sb);
            Console.WriteLine();

            // StringBuilder.AppendAll() method demo
            string[] wordsToAppend = new string[] { "I ", "You ", "He ", "She ", "It " };
            sb.Remove(0, sb.Length);
            sb.AppendAll<string>(wordsToAppend);
            Console.WriteLine(sb);
        }
    }
}
