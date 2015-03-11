using System;

public class Test
{
    public static void Main()
    {
        //Deposit Account Functionality Example
        DepositAccount depositAccount1 = new DepositAccount("Martin", CustomerType.Individual, 2);
        Console.WriteLine("Account interest rate: {0}%", depositAccount1.InterestRate);

        depositAccount1.Deposit(3200);
        depositAccount1.Withdraw(760);

        //throws ArgumentOutOfRangeException
        //sumToWithdraw = 3800;
        //depositAccount.Withdraw(sumToWithdraw);

        int interestPeriod = 8;
        Console.WriteLine("Months {0} interest: {1}lv.", interestPeriod,
            depositAccount1.CalculateInterest(interestPeriod));
        Console.WriteLine();

        depositAccount1.Withdraw(2000);

        //Deposit account with less than 1000lv. balance has no interest.
        Console.WriteLine("Months {0} interest: {1}lv.", interestPeriod,
            depositAccount1.CalculateInterest(interestPeriod));
        Console.WriteLine();

        //Loan Account Functionality Example
        LoanAccount loanAccount = new LoanAccount("Dimitrov", CustomerType.Individual, 2);
        Console.WriteLine("Account interest rate: {0}%", loanAccount.InterestRate);
        loanAccount.Deposit(500);

        interestPeriod = 2;
        //Loan account with individual customer and less than 3 months period of interest has no interest
        Console.WriteLine("Months {0} interest: {1}lv.", interestPeriod,
            loanAccount.CalculateInterest(interestPeriod));
        Console.WriteLine();

        LoanAccount loanAccount2 = new LoanAccount("Sirma OOD", CustomerType.Company, 2);
        Console.WriteLine("Account interest rate: {0}%", loanAccount2.InterestRate);
        loanAccount2.Deposit(500);

        interestPeriod = 1;
        //Loan account with company customer and less than 2 months period of interest has no interest
        Console.WriteLine("Months {0} interest: {1}lv.", interestPeriod,
            loanAccount2.CalculateInterest(interestPeriod));
        Console.WriteLine();

        LoanAccount loanAccount3 = new LoanAccount("Microsoft", CustomerType.Company, 2);
        Console.WriteLine("Account interest rate: {0}%", loanAccount3.InterestRate);
        loanAccount3.Deposit(500);

        interestPeriod = 6;
        //Loan account with company customer and less than 2 months period of interest has no interest
        Console.WriteLine("Months {0} interest: {1}lv.", interestPeriod,
            loanAccount3.CalculateInterest(interestPeriod));
    }
}