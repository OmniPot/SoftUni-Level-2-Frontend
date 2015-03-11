namespace MultimediaShopSystem.Exceptions
{
    using System;

    public class InsufficientSuppliesException : Exception
    {
        private string message;

        public InsufficientSuppliesException(string message)
        {
            this.Message = message;
        }

        public virtual string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Trim().Equals(string.Empty))
                {
                    throw new ArgumentException("Exception message cannot be null or empty string.");
                }

                this.message = value;
            }
        }
    }
}
