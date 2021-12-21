using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class User
    {
        public int User_ID;
        public string Name;
        public string Address;
        public  User(int User_ID, string Name, string Address)
        {
            this.User_ID = User_ID;
            this.Name = Name;
            this.Address = Address;
        }
    }
}
