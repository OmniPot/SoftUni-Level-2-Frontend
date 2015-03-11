namespace MultimediaShopSystem.Models.Items
{
    using System;

    public class Book : Item
    {
        private string author;

        public Book(string id, string title, double price, string author, string[] genres)
            : base(id, title, price, genres)
        {
            this.Author = author;
        }

        public Book(string id, string title, double price, string author, string genre)
            : base(id, title, price, genre)
        {
            this.Author = author;
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Book Author must be at lease 2 chars long.");
                }

                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("Book Author cannot be empty or null.");
                }

                this.author = value;
            }
        }
    }
}
