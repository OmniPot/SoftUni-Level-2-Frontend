using System;
using System.Collections.Generic;

public class Class : IDetailable
{
    private string uniqueTextIdentifier;
    private List<Student> students;
    private List<Teacher> teachers;
    private string details;

    public Class(string textIdentifier, List<Teacher> teachers, List<Student> students, string details = null)
    {
        this.UniqueTextIdentifier = textIdentifier;
        this.Teachers = teachers;
        this.Students = students;
        this.Details = details;
    }

    public string UniqueTextIdentifier
    {
        get { return this.uniqueTextIdentifier; }
        set
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Unique Identifier cannot be null or empty!");
            }
            this.uniqueTextIdentifier = value;
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

    public List<Teacher> Teachers
    {
        get { return this.teachers; }
        set
        {
            if (value.Count <= 0)
            {
                throw new ArgumentException("List of teachers cannot be empty!");
            }
            this.teachers = value;
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

