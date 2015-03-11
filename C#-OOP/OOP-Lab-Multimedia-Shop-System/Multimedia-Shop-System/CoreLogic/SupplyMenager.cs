namespace MultimediaShopSystem.CoreLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MultimediaShopSystem.Contracts;
    using MultimediaShopSystem.Enumerations;
    using MultimediaShopSystem.Models.Items;

    public static class SupplyMenager
    {
        public static readonly Dictionary<IItem, int> Supplies = new Dictionary<IItem, int>();

        public static void AddItemToSupplies(IItem item, int quantity)
        {
            IItem[] equalItems = Supplies.Keys.Where(k => k.ID == item.ID).ToArray();
            if (equalItems.Length > 0)
            {
                Supplies[equalItems.First()] += quantity;
            }
            else
            {
                Supplies.Add(item, quantity);
            }
        }

        public static void CreateItemToSupply(string item, Dictionary<string, string> pairs, int quantity)
        {
            switch (item)
            {
                case "book":
                    SupplyMenager.AddItemToSupplies(CreateBookItem(pairs), quantity);
                    break;
                case "game":
                    SupplyMenager.AddItemToSupplies(CreateGameItem(pairs), quantity);
                    break;
                case "video":
                    SupplyMenager.AddItemToSupplies(CreateVideoItem(pairs), quantity);
                    break;
                default:
                    break;
            }
        }

        public static IItem GetItemById(string id)
        {
            var itemsFound = Supplies.Keys.Where(k => k.ID.Equals(id));
            if (itemsFound.ToList().Count == 0)
            {
                return null;
            }

            return itemsFound.First();
        }

        private static IItem CreateBookItem(Dictionary<string, string> pairs)
        {
            return new Book(
                pairs["id"],
                pairs["title"],
                double.Parse(pairs["price"]),
                pairs["author"],
                pairs["genre"]);
        }

        private static IItem CreateGameItem(Dictionary<string, string> pairs)
        {
            AgeRestriction restriction = (AgeRestriction)Enum.Parse(typeof(AgeRestriction), pairs["ageRestriction"]);
            return new Game(
                pairs["id"],
                pairs["title"],
                double.Parse(pairs["price"]),
                pairs["genre"],
                restriction);
        }

        private static IItem CreateVideoItem(Dictionary<string, string> pairs)
        {
            return new Movie(
                pairs["id"],
                pairs["title"],
                double.Parse(pairs["price"]),
                double.Parse(pairs["length"]),
                pairs["genre"]);
        }
    }
}
