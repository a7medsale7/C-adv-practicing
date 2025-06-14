using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    class Magazine : LibraryItem
    {
        public string IssueNumber { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"{title} - issue: {IssueNumber}  ({year})");}
    }
}
