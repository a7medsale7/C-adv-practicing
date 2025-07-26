using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class CourseManager
    {
        List<Course> Courses = new List<Course>();
        public void AddCourse(Course course)
        {
            if (course != null)
            {
                Courses.Add(course);
                Console.WriteLine($"Course {course.Title} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid course data.");
            }
        }
        public string DisplayAllCourses()
        {
            if (Courses.Count == 0)
            {
                return "No courses available.";
            }
            StringBuilder sb = new StringBuilder();
            foreach (var course in Courses)
            {
                sb.AppendLine(course.DisplayInfo());
            }
            return sb.ToString();
        }
        public string GetByCode(string code)

        {
            foreach (var course in Courses)
            {
                if (course.Code == code)
                {
                    return course.DisplayInfo();
                }
            }
            return "Course not found.";
        }

    }
}
