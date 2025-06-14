using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
           Employee employee = other as Employee;
            if (employee == null)
            {
                return 1; 
            }
            return this.Salary.CompareTo(employee.Salary);
        }
       
    }
}
