namespace MultimediaShopSystem.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShopSystem.Contracts;
    using MultimediaShopSystem.Exceptions;
    using MultimediaShopSystem.Models;

    public static class SaleMenager
    {
        private static readonly HashSet<ISale> Sales = new HashSet<ISale>() { };

        public static void AddSale(IItem saleItem, DateTime dateOfSale)
        {
            Sales.Add(new Sale(saleItem, dateOfSale));
            if (SupplyMenager.Supplies[saleItem] == 0)
            {
                throw new InsufficientSuppliesException("Not enough supplies to finish the Sale.");
            }

            SupplyMenager.Supplies[saleItem]--;
        }

        public static List<ISale> AggregateSalesToReport(DateTime startDate)
        {
            List<ISale> salesToReport = Sales
                .Where(s => s.SaleDate.CompareTo(startDate) > 0)
                .ToList<ISale>();

            return salesToReport;
        }
    }
}
