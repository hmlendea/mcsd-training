using System;

namespace CertificationTraining.Workspace.Classes
{
    // SAMPLE: Indexed properties
    public class IPAddress
    {
        readonly int[] ip;

        public int this[int index]
        {
            get
            {
                return ip[index];
            }
            set
            {
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Invalid value");
                }

                ip[index] = value;
            }
        }

        public IPAddress()
        {
            ip = new int[32];
        }
    }
}
