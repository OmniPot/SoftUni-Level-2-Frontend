namespace _2_Custom_Linq_Extension_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestLinqExtensionMethods
    {
        public static void Main()
        {
            // WhereNot<T>() method example
            int[] arrayOfNumbers = new int[] { 5, 7, 8, 1, 30, 15 };
            var oddNumbers = arrayOfNumbers.WhereNot<int>(i => i > 10);
            Console.Write("All numbers NTO GREATER THAN 10: ");
            oddNumbers.ToList().ForEach(num => Console.Write(num + " "));
            Console.WriteLine();

            // Repeat<T>() method example
            List<string> listOfNumbers = new List<string>() { "razbira", "se", " " };
            var resultOfRepeat = listOfNumbers.Repeat<string>(3);
            resultOfRepeat.ToList().ForEach(x => Console.WriteLine(x));

            // WhereEndsWith() method example
            string[] suffixes = { "able", "ible", "ed", "full", "less" };
            string[] collection = { "wanted", "handfull", "power", "strength", "helpless", "agility", "musaka", "flexible" };
            var foundResults = collection.WhereEndsWith(suffixes);
            foundResults.ToList().ForEach(Console.WriteLine);
        }
    }
}
