using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Order
    {
        public int User_ID;
        public int Shirt;
        public int Pant;
        public int Suit;
        public int  Bed_Sheet;
        public string Shirt_type;
        public string Pant_type;
        public string Suit_type;
        public string Bedsheet_type;
        public int shirt_amount;
        public int pant_amount;
        public int suit_amount;
        public int bedsheet_amount;
        public int shirt_price = 10;
        public int pant_price = 12;
        public int bedsheet_price = 6;
        public int suit_price = 8;
        public int Amount;
       
        public Order( int User_ID,int Shirt, int Pant, int Suit, int Bed_Sheet, string Shirt_type, string Pant_type, string Suit_type, string Bedsheet_type, int shirt_amount,int pant_amount, int suit_amount, int bedsheet_amount)
        {
            this.User_ID = User_ID;
            this.Shirt = Shirt;
            this.Pant = Pant;
            this.Suit = Suit;
            this.Bed_Sheet = Bed_Sheet;
            this.Shirt_type = Shirt_type;
            this.Pant_type = Pant_type;
            this.Suit_type = Suit_type;
            this.Bedsheet_type = Bedsheet_type;
            this.shirt_amount = shirt_amount;
            this.pant_amount = pant_amount;
            this.suit_amount = suit_amount;
            this.bedsheet_amount = bedsheet_amount;

    }
        public string getInfo1()
        {
            string Info = "shirts" + "\t" + this.Shirt + "\t" + this.Shirt_type + "\t" + this.shirt_amount + "\t";
            return Info;
        }
        public string getInfo2()
        {
            string Info2 = "Pants" + "\t" + this.Pant + "\t" + this.Pant_type + "\t" + this.pant_amount + "\t";
           
            return Info2;
        }
public string getInfo3()
        {
            string Info3 = "suit" + "\t" + this.Suit + "\t" + this.Suit_type + "\t" + this.suit_amount + "\t";
            return Info3;
        }
        public string getInfo4()
        {
            string Info = "bedsheet" + "\t" + this.Bed_Sheet + "\t" + this.Bedsheet_type + "\t" + this.bedsheet_amount + "\t";
            return Info;
        }
    }
}
