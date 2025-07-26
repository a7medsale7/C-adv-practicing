using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
      
        public abstract string DisplayDetails();

    }
}
