using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    abstract class SmartDevice : IComparable

    { 
        public string DeviceName { get; set; }
        public float PowerUsageWatts { get; set; }
        public int UsageHoursPerDay { get; set; }
        public abstract void DisplayInfo();
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            SmartDevice otherDevice = obj as SmartDevice;
            if (otherDevice != null)
                return this.PowerUsageWatts.CompareTo(otherDevice.PowerUsageWatts);
            else
                throw new ArgumentException("Object is not a SmartDevice");
        }




    }
}
