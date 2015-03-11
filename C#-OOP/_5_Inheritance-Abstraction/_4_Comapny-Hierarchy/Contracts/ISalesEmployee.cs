using System;
using System.Collections.Generic;

public interface ISalesEmployee<T>
{
    List<T> Sales { get; set; }
}