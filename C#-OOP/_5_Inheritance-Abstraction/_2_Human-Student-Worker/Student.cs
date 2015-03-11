using System;

class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string faultyNumber)
        : base(firstName, lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.facultyNumber = faultyNumber;
    }

    public string FaultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length > 10 || value.Length < 5)
            {
                throw new ArgumentOutOfRangeException("Faulty Number must be between 5-10 characters.");
            }
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Faulty number cannot be null or empty.");
            }
        }
    }
}

