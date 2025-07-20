using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Course<T> : IEnumerable<T> ,  IComparer<Student>
    {
        List<T> students = new List<T>();
        public void AddStudent(T student)
        {
            if (student is Student)
            {
                students.Add(student);
            }
            else
            {
                throw new ArgumentException("Only Student objects can be added to the course.");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this [int index]
        {
            get => students[index];
            set
            {
                if (value is Student)
                {
                    students[index] = value;
                }
                else
                {
                    throw new ArgumentException("Only Student objects can be assigned to the course.");
                }
            }
        }
        public List<T> Filter(Predicate<T> match)
        {
            List<T> filteredList = new List<T>();
            foreach (var student in students)
            {
                if (match(student))
                {
                    filteredList.Add(student);
                }
            }
            return filteredList;
        }

        public int Compare(Student x, Student y)
        {
            if (x == null || y == null)
                return 0;

            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
