using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class Instructor : Person , IUser
    {
        public List<string> Skills { get; set; }
        public List<Course> TeachingCourses { get; set; }
        public string AssignCourse(Course course)
        {
            if (TeachingCourses == null)
            {
                TeachingCourses = new List<Course>();
            }
            TeachingCourses.Add(course);
            return $"Successfully assigned to course: {course.Title}";

        }
        public void ViewTeachingCourses()
        {
            if (TeachingCourses == null || TeachingCourses.Count == 0)
            {
                Console.WriteLine("No courses assigned.");
                return;
            }
            foreach (var course in TeachingCourses)
            {
                Console.WriteLine(course.DisplayInfo());
            }
        }
        public override string DisplayDetails()
        {
            return $"Name: {Name}, Email: {Email}, ID: {Id}, Skills: {string.Join(", ", Skills)}";

        }

        public void Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }

        public void Logout()
        {
            Console.WriteLine("Logged out successfully.");
        }
    }
}
