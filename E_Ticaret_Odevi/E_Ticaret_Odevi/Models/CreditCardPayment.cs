using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Odevi.Models
{
    public class CreditCardPayment:IPayment
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }

        public CreditCardPayment(string cardNumber, string name)
        {
            CardNumber = cardNumber;
            Name = name;
        }

        public bool ProcessPayment(double amount)
        {
            Console.WriteLine($"Kredi kartı ile {amount} TL ödendi");
            return true;
        }
    }
}
