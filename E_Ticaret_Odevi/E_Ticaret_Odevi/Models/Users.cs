using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Odevi.Models
{
    public abstract class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Users(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public abstract string GetUserInfo();
    }
}

