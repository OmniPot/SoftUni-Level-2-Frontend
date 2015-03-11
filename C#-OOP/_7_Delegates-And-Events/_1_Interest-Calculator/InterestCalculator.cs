namespace InterestCalculator
{
    using System;
    using System.Linq;

    public class InterestCalculator
    {
        public InterestCalculator(double sum, double interest, double years, Func<double, double, double, double> calculator)
        {
            this.Interest = calculator(sum, years, interest);
        }

        public double Interest { get; set; }

        public static double GetSimpleInterest(double sum, double interest, double years)
        {
            return Math.Round(sum * (1 + (interest / 100) * years), 4);
        }

        public static double GetCompoundInterest(double sum, double interest, double years)
        {
            return Math.Round(sum * Math.Pow((1 + (interest / 100) / 12), years * 12), 4);
        }
    }
}
