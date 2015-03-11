using System;
using System.Collections.Generic;


public class Developer : Employee, IDeveloper<Project>
{
    private List<Project> projects;

    public Developer(int id, string firstName, string lastName, double salary, Department department, List<Project> projects)
        : base(id, firstName, lastName, salary, department)
    {
        this.Projects = projects;
    }

    public List<Project> Projects
    {
        get { return this.projects; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("List of projects cannot be null.");
            }
            this.projects = value;
        }
    }

}

