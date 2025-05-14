using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class SortByName : IComparer<Story>
    {
         public int Compare(Story x, Story y)
        {
            return x.Name.CompareTo(y.Name);
        }
    
    }
}
