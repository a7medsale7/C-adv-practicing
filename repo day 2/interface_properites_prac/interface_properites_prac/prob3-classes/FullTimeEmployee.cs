    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace interface_properites_prac
    {
        class FullTimeEmployee : Employee, IReportable ,  IComparable
        {
            public int bonus { get; set; }
            public override int CalculateSalary()
            {
                return baseSalary + bonus;
            }
            public void GenerateReport()
            {
                Console.WriteLine($"{name} ({type}) : {CalculateSalary()}");
            }
            public int CompareTo(object other)
            {
                FullTimeEmployee otherEmployee = other as FullTimeEmployee;
                if (otherEmployee == null) return 1;
            //return this.CalculateSalary().CompareTo(otherEmployee.CalculateSalary());


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
