using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System__lab_03_
{
    
    internal class User_History
    {
        public int ID;
        public string Name;
        public string Address;
        public int borrow;
       
        public  User_History(int ID, string Name,string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
        }
       public string getInfo()
        {
            string Info = ID + "\t" + Name + "\t" + Address + "\t" + borrow + "\t";
            return Info;
        }

    }
}
