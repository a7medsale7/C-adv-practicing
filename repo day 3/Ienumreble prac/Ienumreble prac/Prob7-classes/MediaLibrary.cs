using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class MediaLibrary : IEnumerable
    {
       private List<MediaItem>items = new List<MediaItem>();
        public void Add(MediaItem item)
        {
            items.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            items.Sort();  
            return items.GetEnumerator();
        }

    }
}
