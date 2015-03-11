using System;
using System.Collections.Generic;

public class Manager : Employee, IManager
{
    private List<IEmployee> employees;

    public Manager(int id, string firstName, string lastName, double salary, Department department, List<IEmployee> employees)
        : base(id, firstName, lastName, salary, department)
    {
        this.Employees = employees;
    }

    public List<IEmployee> Employees
    {
        get { return this.employees; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Manager employees cannot be zero/null.");
            }
            this.employees = value;
        }
    }
}

