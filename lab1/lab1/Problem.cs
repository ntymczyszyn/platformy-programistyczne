using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Tests1"), InternalsVisibleTo("GUI")]
namespace lab1
{
    internal class Problem
    {
        int number_of_items;
        public List<Item> items;
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;

        public Problem()
        {
            items = new List<Item>();
        }
        public Problem(int p_number_of_items, int p_seed)
        {
            if (p_number_of_items < 1)
                throw new ArgumentException("Invalid number of items.", nameof(p_number_of_items));
            if (p_seed < 1)
                throw new ArgumentException("Invalid seed.", nameof(p_seed));

            items = new List<Item>();
            number_of_items = p_number_of_items;
            Random random = new Random(p_seed);
            for (int i = 0; i < number_of_items; i++)
            {
                Item new_item = new Item(i, random.Next(MIN_VALUE, MAX_VALUE), random.Next(MIN_VALUE, MAX_VALUE));
                items.Add(new_item);
            }
        }
        public Result Solve(int p_capacity)
        {
            if (items.Count == 0)
                throw new InvalidOperationException("No items to solve the problem.");

            List<Item> sorted_items = items.OrderByDescending(o => o.ratio).ToList();
            Result result = new Result(p_capacity);
            Console.WriteLine("Sorted: ");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(sorted_items[i]);

                if (result.isBacpackFull())
                {
                    break;
                } 
                else
                {
                    if (result.itemCanBePacked(sorted_items[i].weight))
                        result.addItem(sorted_items[i]);
                }
            }
            return result;
        }
        public override string ToString()
        {
            string result = "";
            foreach (Item item in items)
            {
                result += item;
            }
            return result;
        }
    }
}
