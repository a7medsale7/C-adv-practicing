using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class StudentNameSorter : IComparer<Student>, ISortable<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            // Assuming T has a Name property
            string nameX = x.Name.ToLower();
            string nameY = y.Name.ToLower();
            return string.Compare(nameX, nameY);
        }

        public void Sort(List<Student> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("List is empty or null.");
                return;
            }
            list.Sort(this);
            Console.WriteLine("Students sorted by name.");
        }
    }
}
