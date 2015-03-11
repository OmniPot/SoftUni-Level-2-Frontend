namespace MultimediaShopSystem.Models.Items
{
    using System;
    using MultimediaShopSystem.Enumerations;
    
    public class Game : Item
    {
        private AgeRestriction ageRestriction;

        public Game(string id, string title, double price, string[] genres, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price, genres)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string id, string title, double price, string genre, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price, genre)
        {
            this.AgeRestriction = ageRestriction;
        }

        public AgeRestriction AgeRestriction
        {
            get { return this.ageRestriction; }
            set { this.ageRestriction = value; }
        }
    }
}
