using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
   abstract class Employee
    {
        public string name { get; set; }
        public int baseSalary { get; set; }
        public string type { get; set; }
        public abstract int CalculateSalary();
    }
}
