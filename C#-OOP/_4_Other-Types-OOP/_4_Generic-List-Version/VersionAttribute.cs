using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Method | AttributeTargets.Enum, AllowMultiple = true)]

public class VersionAttribute : System.Attribute
{
    public VersionAttribute(int minor, int major)
    {
        this.Minor = minor;
        this.Major = major;
    }

    public int Major { get; private set; }

    public int Minor { get; private set; }

    public override string ToString()
    {
        return string.Format("{0}.{1}", this.Major, this.Minor);
    }
}
