using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Odevi.Models
{
    public class Cart
    {
        public Dictionary<Products, int> Items { get; set; }

        public Cart()
        {
            Items = new Dictionary<Products, int>();
        }

        public void AddItem(Products product, int quantity)
        {
            if (Items.ContainsKey(product))
                Items[product] += quantity;
            else
                Items.Add(product, quantity);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }
}
