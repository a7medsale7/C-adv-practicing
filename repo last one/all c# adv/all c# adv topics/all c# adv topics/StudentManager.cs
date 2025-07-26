using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class StudentManager: IComparable<StudentManager> , IComparer<StudentManager>


    {
        public List<Student> Students = new List<Student>();
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                Students.Add(student);
                Console.WriteLine($"Student {student.Name} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid student data.");
            }
        }
        //======================================
        public string DisplayAllStudents()
        {
            if (Students.Count == 0)
            {
                return "No students available.";
            }
            StringBuilder sb = new StringBuilder();
            foreach (var student in Students)
            {
                sb.AppendLine(student.DisplayDetails());
            }
            return sb.ToString();
        }

        public int CompareTo(StudentManager other)
        {
            if (other == null) return 1;
            return this.Students.Count.CompareTo(other.Students.Count);
        }
        

        public List<Student> SortByName()
        {
            List<Student> sorted = new List<Student>(Students);
            sorted.Sort(new StudentNameSorter()); 
            return sorted;
        }

        public int Compare(StudentManager x, StudentManager y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Students.Count.CompareTo(y.Students.Count);
        }
        public List<Student> SortStudentsByGPA()
        {
            List<Student> sorted = new List<Student>(Students);
            sorted.Sort(); 
            return sorted;
        }


        //======================================
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= Students.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                return Students[index];
            }
        }
        //======================================

        public Student this[string name]
        {
            get
            {
                var student = Students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (student == null)
                {
                    throw new KeyNotFoundException($"Student with name '{name}' not found.");
                }
                return student;
            }
        }
        //======================================


    }
}
