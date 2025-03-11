using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Odevi.Models
{
    public class BankTansferPayment:IPayment
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }

        public BankTansferPayment(string bankName, string accountNumber)
        {
            BankName = bankName;
            AccountNumber = accountNumber;
        }

        public bool ProcessPayment(double amount)
        {
            Console.WriteLine($"Havale ile {amount} TL ödendi");
            return true;
        }
    }
}
