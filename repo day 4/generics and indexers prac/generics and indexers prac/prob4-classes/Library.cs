using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    class Library : IEnumerable<LibraryItem>
    {
     
        List<LibraryItem> items;


        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }
        public IEnumerator<LibraryItem> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
