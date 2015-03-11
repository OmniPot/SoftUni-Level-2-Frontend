namespace MultimediaShopSystem.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MultimediaShopSystem.Contracts;
    using MultimediaShopSystem.Models;
    using MultimediaShopSystem.Models.Items;

    public static class ReportMenager
    {
        public static void PrintRentReport(List<IRent> rentsToReport)
        {
            foreach (Rent rent in rentsToReport)
            {
                StringBuilder rentReportBuilder = new StringBuilder();
                rentReportBuilder.AppendLine(string.Format("{0} {1}", rent.GetType().Name, rent.RentState));
                rentReportBuilder.Append(GenerateReportMainPart(rent));
                rentReportBuilder.AppendLine(string.Format("Rentfine: {0}", rent.RentFine));

                Console.WriteLine(rentReportBuilder.ToString());
            }
        }

        public static void PrintSalesReport(List<ISale> salesToReport)
        {
            double reportSum = Math.Round(salesToReport.Sum(p => p.Item.Price), 2);
            Console.WriteLine(reportSum);
        }

        private static string GenerateReportMainPart(ITradable trade)
        {
            StringBuilder tradeBuilder = new StringBuilder();
            tradeBuilder.AppendLine(string.Format("{0} {1}", trade.Item.GetType().Name, trade.Item.ID));
            tradeBuilder.AppendLine(string.Format("Title: {0}", trade.Item.Title));
            tradeBuilder.AppendLine(string.Format("Price: {0}", trade.Item.Price));
            tradeBuilder.AppendLine(string.Format("Genres: {0}", trade.Item.Genres));

            if (trade.Item is Game)
            {
                var game = (Game)trade.Item;
                tradeBuilder.AppendLine(string.Format("Age restriction: {0}", game.AgeRestriction));
            }
            else if (trade.Item is Book)
            {
                var book = (Book)trade.Item;
                tradeBuilder.AppendLine(string.Format("Author: {0}", book.Author));
            }
            else
            {
                var movie = (Movie)trade.Item;
                tradeBuilder.AppendLine(string.Format("Length: {0}", movie.Minutes));
            }

            return tradeBuilder.ToString();
        }
    }
}
