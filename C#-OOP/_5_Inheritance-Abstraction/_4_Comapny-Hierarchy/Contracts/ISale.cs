using System;

public interface ISale
{
    string ProductName { get; set; }

    DateTime Date { get; set; }

    double Price { get; set; }

    string ToString();
}