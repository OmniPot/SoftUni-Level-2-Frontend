namespace TheSlum.Items
{
    using System.Linq;
    using System;
    using TheSlum.Interfaces;

    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int timeout, int countdown, bool hasTimedOut, int healthEffect, int defenceEffect, int attackEffect)
            : base(id, healthEffect, defenceEffect, attackEffect)
        {
            this.Timeout = timeout;
            this.Countdown = countdown;
            this.HasTimedOut = hasTimedOut;
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}