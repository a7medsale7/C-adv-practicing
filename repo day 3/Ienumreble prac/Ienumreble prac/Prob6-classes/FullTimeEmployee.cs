using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class FullTimeEmployee : Employee , IReportable
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating report for full-time employee: " + name + " " + BaseSalary);
        }

        public  int GetMonthlySalary()
        {
            
            return BaseSalary;
        }
    }
}
