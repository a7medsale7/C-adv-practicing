using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_properites_prac
{
    class Laptop : IProduct, IComparable<IProduct>
    {
        public string Name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public int CompareTo(IProduct other)
        {
            Laptop otherLaptop = other as Laptop;
            //return this.price.CompareTo(otherLaptop.price);
            if (otherLaptop == null) return 1;
            if (this.stock > otherLaptop.stock) { return 1; }
            if (this.stock < otherLaptop.stock) return -1;
            return 0;
        }
        public void display()
        {
            Console.WriteLine($"Laptop: {Name} - {price} - Stock: {stock}");
        }
    }
    
    }

