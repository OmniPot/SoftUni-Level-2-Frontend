using System;
using System.Collections.Generic;

public interface IDeveloper<T>
{
    List<T> Projects { get; set; }
}