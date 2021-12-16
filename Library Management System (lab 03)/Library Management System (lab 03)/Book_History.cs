using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System__lab_03_
{
    internal class Book_History
    {
        public int B_ID;
        public string B_Name;
        public string B_Author;
        public string B_Publisher;
        public int B_Quantity;
        public Book_History(int B_ID, string B_Name, string B_Author, string B_Publisher, int B_Quantity)
        {
            this.B_ID = B_ID;
            this.B_Name = B_Name;
            this.B_Author = B_Author;
            this.B_Publisher = B_Publisher;
            this.B_Quantity = B_Quantity;
        }
        public string GetInfo()
        {
            string Info = B_ID + "\t" + B_Name + "\t";
            return Info;
        }
    }
}
