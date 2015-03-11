namespace MultimediaShopSystem.Models.Items
{
    using System;

    public class Movie : Item
    {
        private double minutes;

        public Movie(string id, string title, double price, double minutes, string[] genres)
            : base(id, title, price, genres)
        {
            this.Minutes = minutes;
        }

        public Movie(string id, string title, double price, double minutes, string genre)
            : base(id, title, price, genre)
        {
            this.Minutes = minutes;
        }

        public double Minutes
        {
            get
            {
                return this.minutes;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Movie length canno be negative or zero.");
                }

                this.minutes = value;
            }
        }
    }
}
