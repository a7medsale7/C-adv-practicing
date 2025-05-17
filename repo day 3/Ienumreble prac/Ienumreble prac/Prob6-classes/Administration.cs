using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class Administration : IEnumerable/*, IComparable*/

    {
        private List<Employee> employees = new List<Employee>();
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
        public void GenerateReports()
        {
            foreach (Employee employee in employees)
            {

                if (employee is IReportable reportable)
                {
                    reportable.GenerateReport();
                }

                else
                {
                    Console.WriteLine("Employee " + employee.name + " is not reportable.");
                }

            }
        }
        //public int CompareTo(object obj)
        //{
        //    if (obj == null) return 1;
        //    Administration otherAdmin = obj as Administration;
        //    if (otherAdmin != null)
        //        return this.employees.Count.CompareTo(otherAdmin.employees.Count);
        //    else
        //        throw new ArgumentException("Object is not an Administration");
        //}


        public void SortEmployeesBySalary()
        {
            employees.Sort((x, y) => x.GetMonthlySalary().CompareTo(y.GetMonthlySalary()));
        }

    }
}
