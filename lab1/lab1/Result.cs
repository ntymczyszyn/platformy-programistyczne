using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Result
    {
        public int total_weight;
        public int total_value;
        public int max_capacity { get; set; }
        public List<Item> packed_items;

        public Result(int p_capacity)
        {
            if (p_capacity < 1)
                throw new ArgumentException("Invalid capacity.", nameof(p_capacity));
            
            max_capacity = p_capacity;
            packed_items = new List<Item>();
        }

        public bool isBacpackFull()
        {
            return total_weight == max_capacity;
        }

        public bool itemCanBePacked(int item_weight)
        {
            return item_weight + total_weight <= max_capacity;
        }

        public void addItem(Item packed_item)
        {
            total_weight += packed_item.weight;
            total_value += packed_item.value;
            packed_items.Add(packed_item);
        }

        public override string ToString()
        {
            string result = "";
            result += "total value: " + total_value + "\r\n";
            result += "total weight: " + total_weight + "\r\n";
            result += "items: ";
            foreach(Item item in packed_items)
            {
                result += item.id + " ";
            }
            return result + "\r\n";
        }
    }
}
