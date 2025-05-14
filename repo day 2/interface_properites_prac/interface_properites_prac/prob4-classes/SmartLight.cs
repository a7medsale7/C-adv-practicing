using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class SmartLight : SmartDevice, IBillable
    {
        public bool IsDimmable { get; set; }

        public decimal CalculateMonthlyBill()
        {
            float power = PowerUsageWatts;
            if (IsDimmable)
                power *= 0.9f;

            float monthlyKWh = (power * UsageHoursPerDay * 30) / 1000f;
            return (decimal)(monthlyKWh * 0.12f);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"SmartLight: {DeviceName} - Monthly Bill: ${CalculateMonthlyBill():0.00}");

        }
    }
}
