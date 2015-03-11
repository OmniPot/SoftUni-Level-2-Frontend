namespace MultimediaShopSystem.Models
{
    using System;
    using System.Linq;
    using MultimediaShopSystem.Contracts;
    using MultimediaShopSystem.Enumerations;

    public class Rent : Trade, IRent
    {
        private DateTime rentDate;
        private DateTime deadLine;

        public Rent(IItem item, DateTime rentDate, DateTime deadLine)
        {
            this.Item = item;
            this.RentDate = rentDate;
            this.DeadLine = deadLine;
        }

        public Rent(IItem item, DateTime rentDate)
            : this(item, rentDate, rentDate.AddDays(30))
        {
        }

        public Rent(IItem item)
            : this(item, DateTime.Now, DateTime.Now.AddDays(30))
        {
        }

        public RentState RentState
        {
            get
            {
                var now = DateTime.Now;

                if (this.ReturnDate.Year > 1)
                {
                    return RentState.Returned;
                }
                else if (now > this.DeadLine)
                {
                    return RentState.Overdue;
                }
                else
                {
                    return RentState.Pending;
                }
            }
        }

        public double RentFine
        {
            get
            {
                return this.CalculateRentFine();
            }
        }

        private DateTime RentDate
        {
            get
            {
                return this.rentDate;
            }

            set
            {
                if (value.Year < 2000 || value.Year > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Year of rent cannot be before 2000 of after the present year.");
                }

                this.rentDate = value;
            }
        }

        private DateTime DeadLine
        {
            get
            {
                return this.deadLine;
            }

            set
            {
                if (value.Year < 2000 || value.Year > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Year of rent deadline cannot be before 2000 of after the present year.");
                }

                this.deadLine = value;
            }
        }

        private DateTime ReturnDate { get; set; }

        public double CalculateRentFine()
        {
            double fine = 0;
            DateTime dl = this.DeadLine;

            while (dl.CompareTo(DateTime.Now) < 0)
            {
                fine += (1 * this.Item.Price) / 100;
                dl = dl.AddDays(1);
            }

            return fine;
        }

        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
        }
    }
}
