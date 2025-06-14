using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    abstract class LibraryItem
    {
        public string title { get; set; }
        public int year { get; set; }

        public abstract void GetDetails();
    }
}
