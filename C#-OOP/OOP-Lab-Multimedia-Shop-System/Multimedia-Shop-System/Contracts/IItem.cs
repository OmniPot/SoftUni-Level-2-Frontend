namespace MultimediaShopSystem.Contracts
{
    using System;

    public interface IItem
    {
        string ID { get; set; }

        string Title { get; set; }

        double Price { get; set; }

        string[] Genres { get; set; }
    }
}
