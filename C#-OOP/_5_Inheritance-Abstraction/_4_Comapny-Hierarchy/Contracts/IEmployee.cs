using System;

public interface IEmployee
{
    double Salary{ get; set; }

    Department Department { get; set; }
}