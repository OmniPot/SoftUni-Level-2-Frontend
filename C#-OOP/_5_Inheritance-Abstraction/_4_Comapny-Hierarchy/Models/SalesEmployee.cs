using System;
using System.Collections.Generic;

public class SalesEmployee : Employee, ISalesEmployee<Sale>
{
    private List<Sale> sales;

    public SalesEmployee(int id, string firstName, string lastName, double salary, Department department, List<Sale> sales)
        : base(id, firstName, lastName, salary, department)
    {
        this.Sales = sales;
    }

    public List<Sale> Sales
    {
        get { return this.sales; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("List of sales cannot be null.");
            }
            this.sales = value;
        }
    }

}

