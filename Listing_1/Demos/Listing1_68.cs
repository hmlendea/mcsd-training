using System;

namespace CertifV2.Demos
{
    class Listing1_68
    {
        class Alarm
        {
            // Delegate for the alarm event
            public event EventHandler OnAlarmRaised = delegate { };

            // Called to raise an alarm
            // Does not provide any event arguments
            public void RaiseAlarm()
            {
                // Raises the alarm
                // The event handler receivers a reference to the alarm that is 
                // raising this event
                OnAlarmRaised(this, EventArgs.Empty);
            }
        }

        // Method that must run when the alarm is raised
        static void AlarmListener1(object source, EventArgs e)
        {
            Console.WriteLine("Alarm listener 1 called");
        }

        // Method that must run when the alarm is raised
        static void AlarmListener2(object source, EventArgs e)
        {
            Console.WriteLine("Alarm listener 2 called");
        }

        static void Main(string[] args)
        {
            // Create a new alarm
            Alarm alarm = new Alarm();

            // Connect the two listener methods
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;

            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised");

            alarm.OnAlarmRaised -= AlarmListener1;
            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised");
        }
    }
}
