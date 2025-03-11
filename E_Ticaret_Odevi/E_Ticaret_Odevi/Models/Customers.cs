using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Ticaret_Odevi.Models
{
    public class Customers:Users
    {
        public string Address { get; set; }
        public Cart ShoppingCart { get; set; }

        public Customers(int id, string name, string email, string address)
            : base(id, name, email)
        {
            Address = address;
            ShoppingCart = new Cart();
        }

        public override string GetUserInfo()
        {
            return $"Müşteri: {Name}";
        }

        public void AddToCart(Products product, int quantity)
        {
            ShoppingCart.AddItem(product, quantity);
        }

        public Order Checkout(IPayment payment)
        {
            double total = ShoppingCart.CalculateTotal();
            if (payment.ProcessPayment(total))
            {
                Order order = new Order(1, this, ShoppingCart.Items, total);
                ShoppingCart.ClearCart();
                return order;
            }
            return null;
        }
    }
}
