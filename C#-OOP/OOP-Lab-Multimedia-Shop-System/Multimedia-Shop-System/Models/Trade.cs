namespace MultimediaShopSystem.Models
{
    using System;
    using MultimediaShopSystem.Contracts;

    public abstract class Trade : ITradable
    {
        private IItem item;

        public virtual IItem Item
        {
            get
            {
                return this.item;
            }

            set
            {
                this.item = value;
            }
        }
    }
}
