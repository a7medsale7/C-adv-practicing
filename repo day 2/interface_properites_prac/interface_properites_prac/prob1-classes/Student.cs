using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public float GPA { get; set; }

        public int CompareTo(object obj)
        {

            if (obj == null) return 1;
            Student otherstudent = obj as Student;
            //if (otherstudent == null)
            //{
            //    throw new ArgumentException("Object is not a Student");
            //}
            //if (this.GPA >otherstudent.GPA)
            //{
            //    return 1;
            //}
            //if (this.GPA < otherstudent.GPA)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            return this.GPA.CompareTo(otherstudent.GPA);

        }
    }
}
