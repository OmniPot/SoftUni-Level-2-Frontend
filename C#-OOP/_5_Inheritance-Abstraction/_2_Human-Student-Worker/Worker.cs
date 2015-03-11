using System;

class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        : base(firstName, lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public double WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < 40)
            {
                throw new ArgumentOutOfRangeException("Week salary cannot be less than 40 lv.");
            }
            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 0 || value > 8)
            {
                throw new ArgumentOutOfRangeException("Work hours per day cannot be less than 0 or greater than 8.");
            }
            this.workHoursPerDay = value;
        }
    }

    public double MoneyPerHour()
    {
        int workDays = 5;
        return this.WeekSalary / (this.WorkHoursPerDay * workDays);
    }
}

