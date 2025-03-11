using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Ticaret_Odevi.Models
{
    public class Seller:Users
    {
        public string CompanyName { get; set; }
        public List<Products> Products { get; set; }

        public Seller(int id, string name, string email, string companyName)
            : base(id, name, email)
        {
            CompanyName = companyName;
            Products = new List<Products>();
        }

        public override string GetUserInfo()
        {
            return $"Satıcı: {Name}, Şirket: {CompanyName}";
        }

        public void AddProduct(Products product)
        {
            Products.Add(product);
        }
    }
}
