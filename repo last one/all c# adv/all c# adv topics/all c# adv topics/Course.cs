using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class Course
    { 
        public string Code { get; set; }
        public string Title { get; set; }
        public int CreditHours { get; set; }
        public Instructor AssignedInstructor { get; set; }
        public string DisplayInfo()
        {
            return $"Course Code: {Code}, Title: {Title}, Credit Hours: {CreditHours}, Instructor: {AssignedInstructor?.Name ?? "Not Assigned"}";
        }


    }
}
