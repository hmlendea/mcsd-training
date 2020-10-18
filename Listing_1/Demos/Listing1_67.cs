using System;

namespace CertifV2.Demos
{
    class Listing1_67
    {
        class Alarm
        {
            // Delegate for the alarm event
            public event Action OnAlarmRaised = delegate { };

            // Called to raise an alarm
            public void RaiseAlarm()
            {
                OnAlarmRaised();
            }
        }

        // Method that must run when the alarm is raised
        static void AlarmListener1()
        {
            Console.WriteLine("Alarm listener 1 called");
        }

        // Method that must run when the alarm is raised
        static void AlarmListener2()
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
