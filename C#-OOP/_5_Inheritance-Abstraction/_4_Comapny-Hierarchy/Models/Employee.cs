using System;

public abstract class Employee : Person, IEmployee
{
    private double salary;
    private Department department;

    public Employee(int id, string firstName, string lastName, double salary, Department department)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
        this.Department = department;
    }

    public double Salary
    {
        get { return this.salary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Employee salary cannot be a negative number.");
            }
            this.salary = value;
        }
    }

    public Department Department
    {
        get { return this.department; }
        set
        {
            this.department = value;
        }
    }

    public override string ToString()
    {
        return string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: {3}",
           this.Id, this.FirstName, this.LastName, this.Salary);
    }
}

