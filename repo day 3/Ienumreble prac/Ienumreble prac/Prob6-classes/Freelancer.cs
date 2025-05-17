using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class Freelancer : Employee , IReportable
    {
        public int GetMonthlySalary()
        {
            return BaseSalary;
        }
        public void GenerateReport()
        {
            Console.WriteLine("Generating report for freelancer: " + name + " " + BaseSalary);
        }

    }
}
