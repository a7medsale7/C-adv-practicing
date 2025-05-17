using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class Book : IEnumerable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        List<Book> books = new List<Book>();
        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
        public void add(Book book)
        {
            books.Add(book);
        }
        public void display()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }


    }
}
