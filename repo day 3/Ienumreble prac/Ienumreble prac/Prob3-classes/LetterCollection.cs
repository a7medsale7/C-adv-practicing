using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class LetterCollection : IEnumerable
    {
        public List<char> letters = new List<char>();
        public void Add(char letter)
        {
            letters.Add(letter);
        }
        public IEnumerator GetEnumerator()
        {
            return letters.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void display()
        {
            foreach (char letter in letters)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
