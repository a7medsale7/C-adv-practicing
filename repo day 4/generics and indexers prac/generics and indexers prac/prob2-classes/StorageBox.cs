using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_and_indexers_prac
{
    class StorageBox<T>
    {
        List<T> items = new List<T>();
        public T this[int index]
        {
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Invalid index");
                return items[index];
            }
            set
            {
                while (items.Count <= index)
                {
                    items.Add(default);
                }
                items[index] = value;
            }
        }
        public void displayItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (!EqualityComparer<T>.Default.Equals(items[i], default(T)))
                {
                    Console.WriteLine($"Item at index {i}: {items[i]}");
                }
            }
        }
    }
}

    
