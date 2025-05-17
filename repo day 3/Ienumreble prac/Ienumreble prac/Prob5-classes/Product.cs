using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac
{
    class Product : IComparable , IEnumerable 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            products.Add(product);
        }
        public void display()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
        public IEnumerator GetEnumerator()
        {
            return products.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;
            Product otherProduct = obj as Product;
            if (otherProduct != null)
                return this.Price.CompareTo(otherProduct.Price);
            else
                throw new ArgumentException("Object is not a Product");
        }
            public void SortProductsByPrice()
        {
            products.Sort(); 
        }


    }
    }

