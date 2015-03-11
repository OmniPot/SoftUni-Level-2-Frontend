using System;

public class DepositAccount : Account, IDepositable, IWithdrawable
{
    private double balance;

    public DepositAccount(string customerName, CustomerType customerType, double interestRate)
        : base(customerName, customerType, interestRate) { }

    public void Deposit(double amount)
    {
        this.Balance += amount;
        Console.WriteLine("Deposited {0}lv. balance: {1}lv.", amount, this.Balance);
    }

    public void Withdraw(double amount)
    {
        if (this.Balance <= 0)
        {
            throw new InvalidOperationException("Cannot withdraw from a zero or negative balanced account.");
        }
        if (this.Balance - amount < 0)
        {
            throw new ArgumentOutOfRangeException("Amount to withdraw cannot be more than account's balance.");
        }
        this.Balance -= amount;
        Console.WriteLine("Withdrawn {0}lv. balance: {1}lv.", amount, this.Balance);
    }

    public override double CalculateInterest(int months)
    {
        double interest = 0;
        if (this.Balance > 1000)
        {
            interest = base.CalculateInterest(months);
        }
        return interest;
    }
}
