using System;

namespace Level3_OOPs_Advanced
{
    public class Program136_Events
    {
        public static void Run()
        {
            Alarm alarm = new Alarm();
            alarm.Ring += Alarm_Ring;
            alarm.Trigger();
        }

        private static void Alarm_Ring(object? sender, EventArgs e)
        {
            Console.WriteLine("Alarm event received.");
        }

        private class Alarm
        {
            public event EventHandler? Ring;

            public void Trigger()
            {
                Ring?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
