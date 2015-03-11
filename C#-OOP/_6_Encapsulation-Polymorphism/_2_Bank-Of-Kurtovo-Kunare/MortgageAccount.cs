using System;

public class MortgageAccount : Account, IDepositable
{
    private double balance;

    public MortgageAccount(string customerName, CustomerType customerType, double interestRate)
        : base(customerName, customerType, interestRate) { }

    public void Deposit(double amount)
    {
        this.Balance += amount;
        Console.WriteLine("Deposited {0}lv. balance: {1}lv.", amount, this.Balance);
    }

    public override double CalculateInterest(int months)
    {
        double interest = 0;
        int halfInterestPeriod = 12;
        int noInterestPeriod = 6;
        if (this.CustomerType == CustomerType.Company && months >= halfInterestPeriod)
        {
            interest = (this.Balance - base.CalculateInterest(halfInterestPeriod)) / 2;
            interest += this.Balance - base.CalculateInterest(months - halfInterestPeriod);
        }
        else if (this.CustomerType == CustomerType.Individual && months >= noInterestPeriod)
        {
            interest = this.Balance - base.CalculateInterest(months - noInterestPeriod);
        }
        return interest;
    }
}