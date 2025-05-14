using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class Freelancer : Employee ,  IReportable , IComparable
    {
        public int hoursWorked { get; set; }
        public override int CalculateSalary()
        {
            return baseSalary * hoursWorked;
        }
        public void GenerateReport()
        {
            Console.WriteLine($"{name} ({type}) : {CalculateSalary()}");

        }
        public int CompareTo(object other)
        {
            Freelancer otherEmployee = other as Freelancer;
            if (otherEmployee == null) return 1;
            //return this.baseSalary.CompareTo(otherEmployee.baseSalary);

            if (this.baseSalary > otherEmployee.baseSalary)
            {
                return 1;
            }
            else if (this.baseSalary < otherEmployee.baseSalary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
