using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class StudentCourseCountSorter : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            // Compare the number of enrolled courses
            int countX = x.EnrolledCourses?.Count ?? 0;
            int countY = y.EnrolledCourses?.Count ?? 0;
            return countX.CompareTo(countY);
        }
    }
}
