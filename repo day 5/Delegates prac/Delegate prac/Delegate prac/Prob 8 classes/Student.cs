using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Student : Person , IComparable<Student>
    {
        public int level { get; set; }
        private double Grade;

        public double grade
        {
            get => Grade;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
                Grade = value;
            }
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1; 
            return this.level.CompareTo(other.level); 
        }

        public override string GetDetails()
        {
           return $"{Name}: (ID) : {Id} - Lever {level}";
        }
    }
}
