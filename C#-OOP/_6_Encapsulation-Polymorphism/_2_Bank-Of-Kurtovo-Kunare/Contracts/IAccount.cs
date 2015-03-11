using System;

public interface IAccount
{
    string CustomerName { get; set; }

    double Balance { get; }

    double InterestRate { get; set; }

    double CalculateInterest(int months);
}