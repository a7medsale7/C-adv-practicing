using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class SmartAC : SmartDevice, IBillable
    {
        public int RoomSize { get; set; }

        public  decimal CalculateMonthlyBill()
        {
            float monthlyKWh = (PowerUsageWatts * UsageHoursPerDay * 30) / 1000f;
            if (RoomSize > 20)
                monthlyKWh *= 1.2f;

            return (decimal)(monthlyKWh * 0.12f);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"SmartAC: {DeviceName} - Monthly Bill: ${CalculateMonthlyBill():0.00}");
        }

    }
}
