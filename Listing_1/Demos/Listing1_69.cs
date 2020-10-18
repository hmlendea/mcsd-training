using System;

namespace CertifV2.Demos
{
    class Listing1_69
    {

        class AlarmEventArgs : EventArgs
        {
            public string Location { get; set; }

            public AlarmEventArgs(string location)
            {
                Location = location;
            }
        }

        class Alarm
        {
            // Delegate for the alarm event
            public event EventHandler<AlarmEventArgs> OnAlarmRaised = delegate { };

            // Called to raise an alarm
            public void RaiseAlarm(string location)
            {
                OnAlarmRaised(this, new AlarmEventArgs(location));
            }
        }

        // Method that must run when the alarm is raised
        static void AlarmListener1(object source, AlarmEventArgs args)
        {
            Console.WriteLine("Alarm listener 1 called");
            Console.WriteLine("Alarm in {0}", args.Location);
        }

        // Method that must run when the alarm is raised
        static void AlarmListener2(object source, AlarmEventArgs args)
        {
            Console.WriteLine("Alarm listener 2 called");
            Console.WriteLine("Alarm in {0}", args.Location);
        }

        static void Main(string[] args)
        {
            // Create a new alarm
            Alarm alarm = new Alarm();

            // Connect the two listener methods
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;

            alarm.RaiseAlarm("cluj");
            Console.WriteLine("Alarm raised");

            alarm.OnAlarmRaised -= AlarmListener1;
            alarm.RaiseAlarm("napoca");
            Console.WriteLine("Alarm raised");
        }
    }
}
