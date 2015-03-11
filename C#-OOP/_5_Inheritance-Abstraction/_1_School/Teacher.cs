using System;
using System.Collections.Generic;

public class Teacher : Person
{
    private List<Discipline> disciplines;

    public Teacher(string name, List<Discipline> disciplines, string details = null)
        : base(name, details)
    {
        this.Disciplines = disciplines;
    }

    public List<Discipline> Disciplines
    {
        get { return this.disciplines; }
        set
        {
            if (value.Count <= 0)
            {
                throw new ArgumentException("List of disciplines cannot be empty!");
            }
            this.disciplines = value;
        }
    }
}

