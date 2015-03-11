namespace AsyncTimer
{
    using System;
    using System.Linq;
    using System.Threading;

    public class AsyncTimer
    {
        private int interval;
        private int ticksCount;

        private Action<int> Tick;

        public AsyncTimer(Action<int> timeChange, int tickCount, int interval)
        {
            this.Interval = interval;
            this.TickCount = tickCount;
            this.Tick = timeChange;
        }

        public int TickCount
        {
            get { return this.ticksCount; }
            set { this.ticksCount = value; }
        }

        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        public static void ChangeTime(int ticks)
        {
            Console.WriteLine("Ticks left = {0}", ticks);
        }

        public void Run()
        {
            int ticksLeft = this.ticksCount;
            while (this.ticksCount > 0)
            {
                this.Tick(ticksLeft);
                ticksLeft--;
                Thread.Sleep(this.interval);
            }
        }
    }
}
