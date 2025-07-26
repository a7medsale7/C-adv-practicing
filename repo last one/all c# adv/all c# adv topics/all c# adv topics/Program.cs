using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    public delegate void LogHandler(string msg);

    internal class Program
    {
        static void Main(string[] args)
        {

                Logger logger = new Logger();
                logger.log = logger.LogToConsole;
                logger.log += logger.LogWithTimestamp;

                Course c1 = new Course { Code = "CS101", Title = "Intro to Programming", CreditHours = 3 };
                Course c2 = new Course { Code = "MTH201", Title = "Calculus II", CreditHours = 4 };
                Course c3 = new Course { Code = "ENG150", Title = "English Literature", CreditHours = 2 };

                Instructor inst1 = new Instructor
                {
                    Id = 1,
                    Name = "Dr. Nour",
                    Email = "nour@uni.com",
                    Skills = new List<string> { "Programming", "Algorithms" },
                    TeachingCourses = new List<Course>()
                };

                inst1.AssignCourse(c1);
                c1.AssignedInstructor = inst1;

                Student s1 = new Student
                {
                    Id = 101,
                    Name = "Ahmed Saleh",
                    Email = "ahmed@gmail.com",
                    GPA = 3.8,
                    EnrolledCourses = new List<Course>()
                };

                Student s2 = new Student
                {
                    Id = 102,
                    Name = "Sara Ali",
                    Email = "sara@outlook.com",
                    GPA = 3.4,
                    EnrolledCourses = new List<Course>()
                };

                Student s3 = new Student
                {
                    Id = 103,
                    Name = "Mohamed Said",
                    Email = "mohamed@yahoo.com",
                    GPA = 3.9,
                    EnrolledCourses = new List<Course>()
                };

                // 🔹 Course Enrollment
                s1.RegisterCourse(c1);
                s2.RegisterCourse(c2);
                s1.RegisterCourse(c3);
                s3.RegisterCourse(c1);

                // 🔹 Logging Actions
                logger.LogAction("Student Ahmed registered for CS101");
                logger.LogAction("Instructor Dr. Nour assigned to CS101");

                // 🔹 Student Manager
                StudentManager sm = new StudentManager();
                sm.AddStudent(s1);
                sm.AddStudent(s2);
                sm.AddStudent(s3);

                Console.WriteLine("\n📋 All Students:");
                sm.DisplayAllStudents();

                Console.WriteLine("\n📋 Sorted by GPA:");
                var sortedByGPA = sm.SortStudentsByGPA();
            foreach (var s in sortedByGPA)
                {
                    Console.WriteLine($"{s.Name} - GPA: {s.GPA}");
                }

                Console.WriteLine("\n📋 Sorted by Name:");
                var sortedByName = sm.SortByName();
                foreach (var s in sortedByName)
                {
                    Console.WriteLine($"{s.Name}");
                }

                Console.WriteLine("\n📋 Courses Enrolled by Ahmed:");
                foreach (var course in s1)
                {
                    Console.WriteLine($"{course.Code} - {course.Title}");
                }

                // 🔹 Indexer Usage
                Console.WriteLine("\n📋 Access Student by Index (0):");
                Student firstStudent = sm[0];
                Console.WriteLine($"{firstStudent.Name}");

                Console.WriteLine("\n📋 Access Student by Name (\"Sara Ali\"):");
                Student sara = sm["Sara Ali"];
                Console.WriteLine($"{sara.Name} - GPA: {sara.GPA}");
            }
        }
    }
