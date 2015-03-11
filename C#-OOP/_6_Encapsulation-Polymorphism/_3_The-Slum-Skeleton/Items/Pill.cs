namespace TheSlum.Items
{
    using System.Linq;
    using System;

    public class Pill : Bonus
    {
        public Pill(string id)
            : base(id, 1, 1, false, 0, 0, 100) { }
    }
}
