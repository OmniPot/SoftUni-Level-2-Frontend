using System;

public class Project : IProject
{
    private string projectName;
    private DateTime startDate;
    private string details;
    private ProjectState state;

    public Project(string projectName, DateTime startDate, string details = null, ProjectState state = ProjectState.Open)
    {
        this.ProjectName = projectName;
        this.StartDate = startDate;
        this.Details = details;
        this.State = state;
    }

    public string ProjectName
    {
        get { return this.projectName; }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Trim() == "")
            {
                throw new ArgumentNullException("Project name cannot be null or empty.");
            }
            this.projectName = value;
        }
    }

    public DateTime StartDate
    {
        get { return this.startDate; }
        set { this.startDate = value; }
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("Details cannot be and empty string.");
            }
            this.details = value;
        }
    }

    public ProjectState State
    {
        get { return this.state; }
        set
        {
            this.state = value;
        }
    }

    public bool CloseProject()
    {
        if (this.State == ProjectState.Open)
        {
            this.State = ProjectState.Closed;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return string.Format("Project name: {0}\nStart date: {1}\nDetails: {2}\nState: {3}",
           this.ProjectName, this.StartDate, this.Details, this.State);
    }
}

