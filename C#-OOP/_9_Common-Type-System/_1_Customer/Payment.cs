using System.Linq;

namespace _1_Customer
{
    using System;

    public class Payment
    {
        public Payment(string productName, double price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        private string ProductName { get; set; }

        private double Price { get; set; }

        public override string ToString()
        {
            return this.ProductName + " - " + this.Price;
        }
    }
}
