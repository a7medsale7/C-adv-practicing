using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class ColorCollection : IEnumerable
    {
        
       public List<string> colors = new List<string>();
        public void Add(string color)
        {
            colors.Add(color);
        }

        public IEnumerator GetEnumerator()
        {
            return colors.GetEnumerator();
        }
         IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void display()
        {
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }



    }
}
