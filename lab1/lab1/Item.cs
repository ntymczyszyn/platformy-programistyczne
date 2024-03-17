using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Item
    {
        public int value { get; set; }
        public int weight { get; set; }
        public double ratio { get; set; }
        public int id { get; set; }
        public Item(int p_id, int p_value, int p_weight)
        {
            this.id = p_id;
            this.value = p_value;
            this.weight = p_weight;
            this.ratio = (double)p_value / (double)p_weight;
        }
        
        public override string ToString()
        {
            return String.Format("no.: {0}, v: {1}, w: {2}, r: {3:0.00}\r\n", id, value, weight, ratio);
        }

        public override bool Equals(object obj)
        { 
            if (obj == null)
                return false;

            if (!(obj is Item))
                return false;

            return (this.id == ((Item)obj).id)
                && (this.value == ((Item)obj).value)
                && (this.weight == ((Item)obj).weight);
        }
    }
}
