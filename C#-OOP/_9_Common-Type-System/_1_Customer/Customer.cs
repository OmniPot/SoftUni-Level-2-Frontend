namespace _1_Customer
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, string id,
            string adress, string mobilePhone, string email, List<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Adress = adress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        private string FirstName { get; set; }

        private string MiddleName { get; set; }

        private string LastName { get; set; }

        private string FullName
        {
            get { return this.FirstName + " " + this.MiddleName + " " + this.LastName; }
        }

        private string Id { get; set; }

        private string Adress { get; set; }

        private string MobilePhone { get; set; }

        private string Email { get; set; }

        private List<Payment> Payments { get; set; }

        private CustomerType CustomerType { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Customer c = (Customer)obj;
            return this.FirstName == c.FirstName &&
                   this.MiddleName == c.MiddleName &&
                   this.LastName == c.LastName &&
                   this.Id == c.Id &&
                   this.Adress == c.Adress &&
                   this.MobilePhone == c.MobilePhone &&
                   this.Payments == c.Payments &&
                   this.CustomerType == c.CustomerType;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                   this.MiddleName.GetHashCode() ^
                   this.LastName.GetHashCode() ^
                   this.Id.GetHashCode() ^
                   this.Adress.GetHashCode() ^
                   this.MobilePhone.GetHashCode() ^
                   this.Payments.GetHashCode() ^
                   this.CustomerType.GetHashCode();
        }

        public object Clone()
        {
            return new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.Adress,
                this.MobilePhone,
                this.Email,
                this.Payments,
                this.CustomerType);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.FirstName);
            sb.AppendLine(this.MiddleName);
            sb.AppendLine(this.LastName);
            sb.AppendLine(this.Id);
            sb.AppendLine(this.Adress);
            sb.AppendLine(this.MobilePhone);
            sb.AppendLine(string.Join(", ", this.Payments
                .ConvertAll(p => p.ToString())
                .ToArray()));

            return sb.ToString();
        }

        public int CompareTo(Customer other)
        {
            if (!this.FullName.Equals(other.FullName))
            {
                return string.Compare(this.FullName, other.FullName) < 0 ? -1 : 1;
            }
            else if (!this.Id.Equals(other.Id))
            {
                return string.Compare(this.Id, other.Id) < 0 ? -1 : 1;
            }
            else
            {
                return 0;
            }
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !c1.Equals(c2);
        }
    }
}
