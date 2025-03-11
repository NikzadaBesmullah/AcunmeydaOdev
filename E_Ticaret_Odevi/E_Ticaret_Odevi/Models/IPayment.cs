using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Odevi.Models
{
    public interface IPayment
    {
        bool ProcessPayment(double amount);
    }
}
