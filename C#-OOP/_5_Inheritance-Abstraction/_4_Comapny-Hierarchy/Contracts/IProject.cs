using System;

public interface IProject
{
    string ProjectName { get; set; }

    DateTime StartDate { get; set; }

    string Details { get; set; }

    ProjectState State { get; set; }

    bool CloseProject();

    string ToString();
}