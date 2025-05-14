using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class Book : IProduct , IComparable
    {
        public string Name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        public int CompareTo(object other)
        {
            Book otherBook = other as Book;
            //return this.price.CompareTo(otherBook.price);

            if (otherBook == null) return 1;
            
            if (this.stock > otherBook.stock) { return 1; }
            if (this.stock < otherBook.stock) return -1;
            return 0;
        }

        public void display()
        {
            Console.WriteLine($"Book: {Name} - {price} - Stock: {stock}");
        }
    }
}
