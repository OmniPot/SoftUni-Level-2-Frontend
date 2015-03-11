using System;

public class LoanAccount : Account, IDepositable
{
    private CustomerType customerType;
    private double balance;

    public LoanAccount(string customerName, CustomerType customerType, double interestRate)
        : base(customerName, customerType, interestRate) { }

    public void Deposit(double amount)
    {
        this.Balance += amount;
        Console.WriteLine("Deposited {0}lv. balance: {1}lv.", amount, this.Balance);
    }

    public override double CalculateInterest(int months)
    {
        double interest = 0;
        int noInterestIndividualPeriod = 3;
        int noInterestCompanyPeriod = 2;
        if (this.CustomerType == CustomerType.Individual && months >= noInterestIndividualPeriod)
        {
            interest = this.Balance - base.CalculateInterest(months - 3);
        }
        else if (this.CustomerType == CustomerType.Company && months >= noInterestCompanyPeriod)
        {
            interest = this.Balance - base.CalculateInterest(months - noInterestCompanyPeriod);
        }
        return interest;
    }
}