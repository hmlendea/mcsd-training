using System;

namespace CertificationTraining.Workspace.Enumerations
{
    // SAMPLE: Flags enum
    // The values must be powers of true. This does not happen automatically when using the Flags attribute
    [Flags]
    enum MonthWithFlags
    {
        None = 0, // There must always be an equivalent of the "None" value because an AND operation with 0 will always result in 0 (false)
        January = 1,
        February = 2,
        March = 4,
        April = 8,
        May = 16,
        June = 32,
        July = 64,
        August = 128,
        September = 256,
        October = 512,
        November = 1024,
        December = 2048
    }

    enum MonthWithoutFlags
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
}
