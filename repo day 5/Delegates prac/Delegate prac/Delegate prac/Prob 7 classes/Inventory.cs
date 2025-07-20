using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
    internal class Inventory<T> : IEnumerable<T>
    {
        private List<T> products = new List<T>();

        public void Add(T product)
        {
            products.Add(product);

        }
             public T this[int index]
        {
            get => products[index];
            set => products[index] = value;
        }

        public IEnumerator<T> GetEnumerator() => products.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public List<T> Filter(Func<T, bool> predicate)
        {
            return products.Where(predicate).ToList();
        }

        public List<T> GetSorted()
        {
            List<T> sorted = new List<T>(products);
            sorted.Sort();
            return sorted;
        }

    }
}
