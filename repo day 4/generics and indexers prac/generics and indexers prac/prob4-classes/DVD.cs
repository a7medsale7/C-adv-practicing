using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    class DVD : LibraryItem
    {
        public string Duration { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"{title} - {Duration} ({year})");
        }
    }
}
