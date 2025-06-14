using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    class Course
    {

        public string Name { get; set; }
        private List<string> students = new List<string>();

        // Indexer to access students by index
        public string this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }

        // Method to add a student
        public void AddStudent(string student)
        {
            students.Add(student);
        }

        // Method to remove a student by name
        public void RemoveStudent(string student)
        {
            students.Remove(student);
        }

        // Optional: method to display all students
        public void PrintStudents()
        {
            Console.WriteLine($"Course: {Name}");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Student at index {i}: {students[i]}");
            }
        }
    }
}
