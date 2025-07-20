using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal abstract  class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public abstract string GetDetails();


    }
}
