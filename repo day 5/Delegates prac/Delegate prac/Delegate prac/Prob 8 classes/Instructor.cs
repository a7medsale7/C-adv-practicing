using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Instructor : Person
    {
        public string Department { get; set; }
        public override string GetDetails()
        {
            return $"{Name}: (ID) : {Id} - Department: {Department}";
        }
    }
}
