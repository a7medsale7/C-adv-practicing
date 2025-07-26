using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class InstructorManager
    {
        List<Instructor> Instructors = new List<Instructor>();
        public void AddInstructor(Instructor instructor)
        {
            if (instructor != null)
            {
                Instructors.Add(instructor);
                Console.WriteLine($"Instructor {instructor.Name} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid instructor data.");
            }
        }
        public string DisplayAllInstructors()
        {
            if (Instructors.Count == 0)
            {
                return "No instructors available.";
            }
            StringBuilder sb = new StringBuilder();
            foreach (var instructor in Instructors)
            {
                sb.AppendLine(instructor.DisplayDetails());
            }
            return sb.ToString();
        }
        //======================================

        public string GetInstructorById(int id)
        {
          foreach (var instructor in Instructors)
          {
              if (instructor.Id == id)
              {
                  return instructor.DisplayDetails();
              }
            }
            return "Instructor not found.";
        }
        //======================================


    }
}
