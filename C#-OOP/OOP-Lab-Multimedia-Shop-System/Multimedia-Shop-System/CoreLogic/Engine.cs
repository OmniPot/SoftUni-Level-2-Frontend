namespace MultimediaShopSystem.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShopSystem.Contracts;
    using MultimediaShopSystem.Models;

    public class Engine
    {
        public void Run()
        {
            while (true)
            {
                string commandLine = Console.ReadLine();
                this.RouteCommand(commandLine);
            }
        }

        private void RouteCommand(string paramsString)
        {
            string[] commandElements = paramsString.Split(' ');
            string command = commandElements[0];

            switch (command)
            {
                case "supply":
                    this.ProcessSupplyCommand(commandElements);
                    break;
                case "sell":
                    this.ProcessSellCommand(commandElements);
                    break;
                case "rent":
                    this.ProcessRentCommand(commandElements);
                    break;
                case "report":
                    this.ProcessReportCommand(commandElements);
                    break;
                default:
                    return;
            }
        }

        private void ProcessRentCommand(string[] commandElements)
        {
            string id = commandElements[1];
            IItem rentItem = SupplyMenager.GetItemById(id);
            DateTime dateOfRent = DateTime.Parse(commandElements[2]);
            DateTime deadLine = DateTime.Parse(commandElements[3]);
            RentMenager.AddRent(rentItem, dateOfRent, deadLine);
        }

        private void ProcessSellCommand(string[] commandElements)
        {
            string id = commandElements[1];
            IItem itemToSale = SupplyMenager.GetItemById(id);
            DateTime dateOfSale = DateTime.Parse(commandElements[2]);
            SaleMenager.AddSale(itemToSale, dateOfSale);
        }

        private void ProcessSupplyCommand(string[] commandElements)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string item = commandElements[1];
            int quantity = int.Parse(commandElements[2]);
            string[] commandParams = commandElements[3].Split('&');

            foreach (var pair in commandParams)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }

            SupplyMenager.CreateItemToSupply(item, keyValuePairs, quantity);
        }

        private void ProcessReportCommand(string[] commandElements)
        {
            string tradeType = commandElements[1];
            switch (tradeType)
            {
                case "rents":
                    List<IRent> rentsToReport = RentMenager.AggregateRentsToReport();
                    ReportMenager.PrintRentReport(rentsToReport);
                    break;

                case "sales":
                    DateTime startDate = DateTime.Parse(commandElements[2]);
                    List<ISale> salesToReport = SaleMenager.AggregateSalesToReport(startDate);
                    ReportMenager.PrintSalesReport(salesToReport);
                    break;

                default:
                    break;
            }
        }
    }
}
