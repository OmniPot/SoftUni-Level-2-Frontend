namespace MultimediaShopSystem.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShopSystem.Contracts;
    using MultimediaShopSystem.Enumerations;
    using MultimediaShopSystem.Exceptions;
    using MultimediaShopSystem.Models;

    public static class RentMenager
    {
        private static HashSet<IRent> Rents = new HashSet<IRent>() { };

        public static void AddRent(IItem rentItem, DateTime dateOfRent, DateTime deadLine)
        {
            Rents.Add(new Rent(rentItem, dateOfRent, deadLine));
            if (SupplyMenager.Supplies[rentItem] == 0)
            {
                throw new InsufficientSuppliesException("Not enough supplies to finish the Rent.");
            }

            SupplyMenager.Supplies[rentItem]--;
        }

        public static List<IRent> AggregateRentsToReport()
        {
            List<IRent> rentsToReport = Rents
                .Where(r => r.RentState == RentState.Overdue)
                .OrderBy(r => r.RentFine)
                .ThenBy(r => r.Item.Title)
                .ToList<IRent>();

            return rentsToReport;
        }
    }
}
