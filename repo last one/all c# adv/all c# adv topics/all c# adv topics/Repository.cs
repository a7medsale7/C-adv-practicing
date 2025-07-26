using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_c__adv_topics
{
    internal class Repository<T>
    {
        List<T> items = new List<T>();

        public void AddItem(T item)
        {
            if (item != null)
            {
                items.Add(item);
                Console.WriteLine($"Item added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid item data.");
            }
        }
        public string DisplayAllItems()
        {
            if (items.Count == 0)
            {
                return "No items available.";
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public string GetItemById(int id)
        {
            var item = items.FirstOrDefault(i => i.GetHashCode() == id);
            if (item != null)
            {
                return item.ToString();
            }
            else
            {
                return "Item not found.";
            }
        }
    }
}
