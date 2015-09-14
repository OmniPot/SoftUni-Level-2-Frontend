namespace MultimediaShopSystem.Models
{
    using System;
    using MultimediaShopSystem.Contracts;

    public class Sale : Trade, ISale
    {
        public Sale(IItem item, DateTime saleDate)
        {
            this.Item = item;
            this.SaleDate = saleDate;
        }

        public Sale(IItem item)
        {
            this.Item = item;
            this.SaleDate = DateTime.Now;
        }

        public DateTime SaleDate { get; set; }
    }
}
