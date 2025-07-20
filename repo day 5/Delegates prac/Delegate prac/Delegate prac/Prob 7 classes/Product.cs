using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prac
{
  public abstract class Product: IComparable<Product> 
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract string GetInfo();

        public int CompareTo(Product product)
        {
            if (product == null) return 1;
            if (this.Price < product.Price) return -1;
            if (this.Price > product.Price) return 1;
            return 0;
        }

       
    }
}
