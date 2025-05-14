using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class SmartHeater : SmartDevice, IBillable
    {
        public int TemperatureSetting { get; set; }

        public  decimal CalculateMonthlyBill()
        {
            float monthlyKWh = (PowerUsageWatts * UsageHoursPerDay * 30) / 1000f;
            decimal cost = (decimal)(monthlyKWh * 0.12f);
            if (TemperatureSetting > 25)
                cost += 5;
            return cost;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"SmartHeater: {DeviceName} - Monthly Bill: ${CalculateMonthlyBill():0.00}");
        }

    }

}
