using System;
using System.Collections.Generic;

public class Discipline
{
    private string name;
    private int numberOfLectures;
    private List<Student> students;
    private string details;

    public Discipline(string name, int numberOfLectures, List<Student> students, string details = null)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.Students = students;
        this.Details = details;
    }
    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set
        {
            if (numberOfLectures < 0)
            {
                throw new ArgumentException("Number of lectures cannot be negative!");
            }
            this.numberOfLectures = value;
        }
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Discipline name cannot be null or empty!");
            }
            this.name = value;
        }
    }

    public List<Student> Students
    {
        get { return this.students; }
        set
        {
            if (value.Count <= 0)
            {
                throw new ArgumentException("List of students cannot be empty!");
            }
            this.students = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            if (value.Trim() == "" && value != null)
            {
                throw new ArgumentException("Details cannot be empty string!");
            }
            this.details = value;
        }
    }
}

