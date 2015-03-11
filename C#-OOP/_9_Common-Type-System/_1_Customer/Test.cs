using System.Collections.Generic;

namespace _1_Customer
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Payment p1 = new Payment("Bag", 33.99);
            Payment p2 = new Payment("Salad", 66.99);
            Customer c1 = new Customer("Rumen", "Todorov", "Tsonkov", "201", "Tuka sam N34", "0887333925", "ebavamSe.gmail.com",
                new List<Payment>() { p1, p2 }, CustomerType.OneTime);
            Customer c2 = new Customer("Rumen", "Todorov", "Tsonkov", "202", "Tam sam N32", "0887351225", "serizniq.gmail.com",
                new List<Payment>() { p1, p2 }, CustomerType.OneTime);

            switch (c1.CompareTo(c2))
            {
                case -1:
                    Console.WriteLine(c1.ToString());
                    break;
                case 1:
                    Console.WriteLine(c2.ToString());
                    break;
                case 0:
                    Console.WriteLine("Equal");
                    break;
            }

        }
    }
}
