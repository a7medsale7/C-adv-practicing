using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class Student:Person , IComparable<Student> , IEnumerable<Course> , IUser
    {
        public double GPA { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        public int CompareTo(Student other)
        {
            Student student = other as Student;
            if (student == null) return 1;
            if (this.GPA > student.GPA) return 1;
            if (this.GPA < student.GPA) return -1;
            else  return 0;

        }

        public override string DisplayDetails()
        {
            return $"Name: {Name}, Email: {Email}, ID: {Id}, GPA: {GPA}";
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return ((IEnumerable<Course>)EnrolledCourses).GetEnumerator();
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            Console.WriteLine("Logged out successfully.");
        }

        public string RegisterCourse(Course course)
        { 
            if (EnrolledCourses == null)
            {
                EnrolledCourses = new List<Course>();
            }
            EnrolledCourses.Add(course);
            return $"Successfully registered for course: {course.Title}";

        }
        public void ViewCourses()
        { 
            if (EnrolledCourses == null || EnrolledCourses.Count == 0)
            {
                Console.WriteLine("No courses enrolled.");
                return;
            }
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine(course.DisplayInfo());
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)EnrolledCourses).GetEnumerator();
        }
    }
}
