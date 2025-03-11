using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Odevi.Models
{
  public class Order
    {
        public int Id { get; set; }
        public Customers Customer { get; set; }
        public Dictionary<Products, int> Items { get; set; }
        public double TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int id, Customers customer, Dictionary<Products, int> items, double totalAmount)
        {
            Id = id;
            Customer = customer;
            Items = new Dictionary<Products, int>(items);
            TotalAmount = totalAmount;
            OrderDate = DateTime.Now;

            // Stok güncelleme
            foreach (var item in items)
            {
                item.Key.DecreaseStock(item.Value);
            }
        }
    }
}
