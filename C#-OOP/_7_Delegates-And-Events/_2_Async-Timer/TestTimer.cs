namespace AsyncTimer
{
    using System;
    using System.Threading;

    public class TestTimer
    {
        public static void Main()
        {
            AsyncTimer asyncTimer = new AsyncTimer(AsyncTimer.ChangeTime, 10, 1000);

            Thread timerThread = new Thread(asyncTimer.Run);
            timerThread.Start();

            Console.WriteLine("Side timer-thread started!");

            Thread.Sleep(5000);
            Console.WriteLine("From main thread: 5 seconds passed.");
            Thread.Sleep(5000);
            Console.WriteLine("Thanks for waiting! :)");
        }
    }
}
