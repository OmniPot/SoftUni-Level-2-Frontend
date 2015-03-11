namespace InterestCalculator
{
    using System;
    using System.Linq;

    public class TestInterestCalculator
    {
        public static void Main()
        {
            InterestCalculator simpleInterestCalculator = new InterestCalculator(2500, 7.2, 15, InterestCalculator.GetSimpleInterest);
            Console.Write("Simple interest:  ");
            Console.WriteLine(simpleInterestCalculator.Interest);

            InterestCalculator compoundInterestCalculator = new InterestCalculator(500, 5.6, 10, InterestCalculator.GetCompoundInterest);
            Console.Write("Compound interest:  ");
            Console.WriteLine(compoundInterestCalculator.Interest);
        }
    }
}
