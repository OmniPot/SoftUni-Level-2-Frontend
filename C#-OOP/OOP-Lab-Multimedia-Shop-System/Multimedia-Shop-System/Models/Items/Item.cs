namespace MultimediaShopSystem.Models.Items
{
    using System;
    using MultimediaShopSystem.Contracts;

    public abstract class Item : IItem
    {
        private string id;
        private string title;
        private double price;

        public Item()
        {
        }

        public Item(string id, string title, double price, params string[] genres)
        {
            this.ID = id;
            this.Title = title;
            this.Price = price;
            this.Genres = genres;
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Id's length must be more than 4 symbols long.");
                }

                this.id = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (value.Trim() == string.Empty && value != null)
                {
                    throw new ArgumentNullException("Title cannot be empty.");
                }

                this.title = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Item's price cannot be negative.");
                }

                this.price = value;
            }
        }

        public string[] Genres { get; set; }
    }
}
