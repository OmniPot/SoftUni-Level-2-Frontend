using System;

public class Student : Person
{
    private int uniqueClassNumber;

    public Student(string name, int classnumber, string details = null)
        : base(name, details)
    {
        this.UniqueClassNumber = classnumber;
    }

    public int UniqueClassNumber
    {
        get { return this.uniqueClassNumber; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Class number cannot be negative!");
            }
            this.uniqueClassNumber = value;
        }
    }


}

